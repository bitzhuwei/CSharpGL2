﻿using GLM;
using CSharpGL.Objects;
using CSharpGL.Objects.Cameras;
using CSharpGL.Objects.Shaders;
using CSharpGL.UIs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpGL;
using CSharpGL.Objects.Models;
using CSharpGL.Objects.ModelFactories;
using FormShaderDesigner1594Demos.Renderers;
using FormShaderDesigner1594Demos.RendererFactories;

namespace FormShaderDesigner1594Demos
{
    /// <summary>
    /// 本例演示了SimpleUIAxis、SimpleUIRect的用法，也证明了CSharpGL.Maths库里的mat4的mvp相乘的结果与glgl里的结果相同。
    /// </summary>
    public partial class FormRenderers : Form
    {
        SimpleUIAxis uiLeftBottomAxis;

        ShaderDesignerRendererBase element;
        ShaderDesignerRendererBase newElement;

        Camera camera;

        SatelliteRotator satelliteRoration;

        public FormRenderers()
        {
            InitializeComponent();

            GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);

            this.camera = new Camera(CameraType.Ortho, this.glCanvas1.Width, this.glCanvas1.Height);

            satelliteRoration = new SatelliteRotator(camera);

            Padding padding = new System.Windows.Forms.Padding(40, 40, 40, 40);
            Size size = new Size(100, 100);
            IUILayoutParam param;
            param = new IUILayoutParam(AnchorStyles.Left | AnchorStyles.Bottom, padding, size);
            uiLeftBottomAxis = new SimpleUIAxis(param);

            uiLeftBottomAxis.Initialize();

            CreateElement();

            this.glCanvas1.MouseWheel += glCanvas1_MouseWheel;
            this.glCanvas1.KeyPress += glCanvas1_KeyPress;
            this.glCanvas1.MouseDown += glCanvas1_MouseDown;
            this.glCanvas1.MouseMove += glCanvas1_MouseMove;
            this.glCanvas1.MouseUp += glCanvas1_MouseUp;
            this.glCanvas1.OpenGLDraw += glCanvas1_OpenGLDraw;
            this.glCanvas1.Resize += glCanvas1_Resize;

            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            PrintCameraInfo();
        }

        private void glCanvas1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.camera.MouseWheel(e.Delta);
        }

        private void FormTranslateOnScreen_Load(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Use 'c' to switch camera types between perspective and ortho");
            builder.AppendLine("Use 'wsadqe' to translate light's position");
            builder.AppendLine("Use 'jk' to decrease/increase rendering element count");
            builder.AppendLine("Use 'p' to switch sphere's polygon mode");
            builder.AppendLine("Use 'm' to switch model");
            builder.AppendLine("Use 'r' to reset model size");
            builder.AppendLine("Use '-' to decrease model size");
            builder.AppendLine("Use '+' to increase model size");
            builder.AppendLine("Use '0' to reset model size");
            MessageBox.Show(builder.ToString());
        }

        void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            PrintCameraInfo();

            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            var arg = new RenderEventArgs(RenderModes.Render, this.camera);

            mat4 projectionMatrix = camera.GetProjectionMat4();
            mat4 viewMatrix = camera.GetViewMat4();
            mat4 modelMatrix = mat4.identity();

            if (this.newElement != null)
            {
                if (this.element != null)
                {
                    this.element.Dispose();
                }
                this.element = this.newElement;
                this.newElement = null;
            }
            ShaderDesignerRendererBase element = this.element;
            element.projectionMatrix = projectionMatrix;
            element.viewMatrix = viewMatrix;
            element.modelMatrix = modelMatrix;

            element.Render(arg);
            uiLeftBottomAxis.Render(arg);
        }

        private void glCanvas1_Resize(object sender, EventArgs e)
        {
            if (this.camera != null)
            {
                this.camera.Resize(this.glCanvas1.Width, this.glCanvas1.Height);
            }
        }


        private void glCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            satelliteRoration.SetBounds(this.glCanvas1.Width, this.glCanvas1.Height);
            satelliteRoration.MouseDown(e.X, e.Y);
        }

        private void glCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (satelliteRoration.MouseDownFlag)
            {
                satelliteRoration.MouseMove(e.X, e.Y);
            }
        }

        private void glCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            satelliteRoration.MouseUp(e.X, e.Y);
        }

        private void PrintCameraInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("camera:"));
            builder.Append(string.Format(" position:{0},", this.camera.Position));
            builder.Append(string.Format(" target:{0},", this.camera.Target));
            builder.Append(string.Format(" up:{0},", this.camera.UpVector));
            builder.Append(string.Format(" camera type: {0},", this.camera.CameraType));
            builder.Append(string.Format(" model size: {0}", this.radius));
            this.textBox1.Text = builder.ToString();
        }

        float translateX = 0, translateY = 0, translateZ = 0;
        const float interval = 0.1f;

        private void glCanvas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c')
            {
                switch (this.camera.CameraType)
                {
                    case CameraType.Perspecitive:
                        this.camera.CameraType = CameraType.Ortho;
                        break;
                    case CameraType.Ortho:
                        this.camera.CameraType = CameraType.Perspecitive;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else if (e.KeyChar == 'w')
            {
                translateY += interval;
            }
            else if (e.KeyChar == 's')
            {
                translateY -= interval;
            }
            else if (e.KeyChar == 'a')
            {
                translateX -= interval;
            }
            else if (e.KeyChar == 'd')
            {
                translateX += interval;
            }
            else if (e.KeyChar == 'q')
            {
                translateZ -= interval;
            }
            else if (e.KeyChar == 'e')
            {
                translateZ += interval;
            }
            else if (e.KeyChar == 'j')
            {
                this.element.DecreaseVertexCount();
            }
            else if (e.KeyChar == 'k')
            {
                this.element.IncreaseVertexCount();
            }
            else if (e.KeyChar == 'p')
            {
                switch (this.element.polygonMode)
                {
                    case PolygonModes.Points:
                        this.element.polygonMode = PolygonModes.Lines;
                        break;
                    case PolygonModes.Lines:
                        this.element.polygonMode = PolygonModes.Filled;
                        break;
                    case PolygonModes.Filled:
                        this.element.polygonMode = PolygonModes.Points;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            else if (e.KeyChar == 'm')
            {
                currentModelIndex++;
                if (currentModelIndex >= modelFactories.Length) { currentModelIndex = 0; }

                CreateElement();
            }
            else if (e.KeyChar == 'r')
            {
                currentRendererIndex++;
                if (currentRendererIndex >= rendererFactories.Length) { currentRendererIndex = 0; }

                CreateElement();
            }
            else if (e.KeyChar == '-')
            {
                this.radius -= 0.1f;
                if (this.radius <= 0) { this.radius = 0.1f; }

                CreateElement();
            }
            else if (e.KeyChar == '+')
            {
                this.radius += 0.1f;

                CreateElement();
            }
            else if (e.KeyChar == '0')
            {
                this.radius = 2;

                CreateElement();
            }
        }

        private void CreateElement()
        {
            IModel model = modelFactories[currentModelIndex].Create(this.radius);
            ShaderDesignerRendererBase element = rendererFactories[currentRendererIndex].GetRenderer(model);
            element.Initialize();
            this.newElement = element;

            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("{0}", model.GetType().Name));
            builder.Append(" - ");
            builder.Append(string.Format("{0}", element.GetType().Name));
            builder.Append(string.Format(" - radius: {0}", radius));
            this.Text = builder.ToString();
        }

        float radius = 2;
        int currentModelIndex = 1;
        int currentRendererIndex = 0;
        static readonly ModelFactory[] modelFactories = new ModelFactory[] 
        { 
            new CubeFactory(), 
            new IceCreamFactory(), 
            new SphereFactory(), 
            new TeapotFactory(), 
        };
        static readonly RendererFactory[] rendererFactories = new RendererFactory[] 
        { 
            new GoochFactory(),
            new Polkadot3dFactory(), 
            new XRayFactory(), 
            new CloudRendererFactory(), 
        };
    }
}
