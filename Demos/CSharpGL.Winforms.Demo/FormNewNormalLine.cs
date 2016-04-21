﻿
using CSharpGL.Objects;
using CSharpGL.Objects.Cameras;
using CSharpGL.Objects.Common;
using CSharpGL.Objects.Demos;
using CSharpGL.Objects.Demos.UIs;
using CSharpGL.Objects.ModelFactories;
using CSharpGL.Objects.Models;
using CSharpGL.Objects.ModernRendering;
using CSharpGL.Texts;
using CSharpGL.Texts.StringModelFactory;
using CSharpGL.UIs;
using GLM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Winforms.Demo
{
    public partial class FormNewNormalLine : Form
    {
        ModernRenderer groundRenderer;

        SimpleUIAxis uiAxis;
        ModernRenderer renderer;
        //NormalLineRenderer demolifebarRenderer;
        LifeBarRenderer lifebarRenderer;
        StringRenderer stringRenderer;
        DummyLabel label;
        ArcBallRotator modelRotator;

        Camera camera;
        SatelliteRotator cameraRotator;

        //Camera modelRotationCamera;
        //SatelliteRotator modelRotator;
        //private float rotateAngle;

        public FormNewNormalLine()
        {
            InitializeComponent();

            this.camera = new Camera(CameraType.Perspecitive, this.glCanvas1.Width, this.glCanvas1.Height);
            this.camera.Position = new GLM.vec3(50, 5, 5);

            this.cameraRotator = new SatelliteRotator(this.camera);

            //this.modelRotationCamera = new Camera(CameraType.Perspecitive, this.glCanvas1.Width, this.glCanvas1.Height);
            //this.modelRotator = new SatelliteRotator(this.modelRotationCamera);
            this.modelRotator = new ArcBallRotator(this.camera);

            {
                const string strGround = "Ground";
                IConvert2BufferPointer model = new Ground();
                CodeShader[] shaders = new CodeShader[2];
                shaders[0] = CSharpGL.Objects.Common.ShaderLoadingHelper.LoadShaderSourceCode(strGround, CodeShader.GLSLShaderType.VertexShader);
                shaders[1] = CSharpGL.Objects.Common.ShaderLoadingHelper.LoadShaderSourceCode(strGround, CodeShader.GLSLShaderType.FragmentShader);
                PropertyNameMap propertyNameMap = CSharpGL.Objects.Common.ShaderLoadingHelper.LoadPropertyNameMap(strGround);
                UniformNameMap uniformNameMap = CSharpGL.Objects.Common.ShaderLoadingHelper.LoadUniformNameMap(strGround);
                this.groundRenderer = new ModernRenderer(model, shaders, propertyNameMap, uniformNameMap);
                this.groundRenderer.Initialize();
            }

            Padding uiPadding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            Size uiSize = new System.Drawing.Size(50, 50);
            IUILayoutParam uiParam = new IUILayoutParam(AnchorStyles.Left | AnchorStyles.Bottom, uiPadding, uiSize);
            uiAxis = new SimpleUIAxis(uiParam);
            uiAxis.Initialize();

            //IModel model = (new TeapotFactory()).Create(1.0f);
            {
                IConvert2BufferPointer model = new NewNormalLineDemoModel();
                CodeShader[] codeShaders = new CodeShader[3];
                codeShaders[0] = new CodeShader(ShaderHelper.Load("NewNormalLine.vert"), CodeShader.GLSLShaderType.VertexShader);
                codeShaders[1] = new CodeShader(ShaderHelper.Load("NewNormalLine.geom"), CodeShader.GLSLShaderType.GeometryShader);
                codeShaders[2] = new CodeShader(ShaderHelper.Load("NewNormalLine.frag"), CodeShader.GLSLShaderType.FragmentShader);
                var propertyNameMap = new PropertyNameMap();
                propertyNameMap.Add("in_Position", NewNormalLineDemoModel.strPosition);
                propertyNameMap.Add("in_Normal", NewNormalLineDemoModel.strNormal);
                var uniformNameMap = new UniformNameMap();
                uniformNameMap.Add("model matrix", "modelMatrix");
                uniformNameMap.Add("view matrix", "viewMatrix");
                uniformNameMap.Add("projection matrix", "projectionMatrix");
                uniformNameMap.Add("show model", "showModel");
                uniformNameMap.Add("show normal", "showNormal");
                uniformNameMap.Add("normal length", "normalLength");
                this.renderer = new ModernRenderer(model, codeShaders, propertyNameMap, uniformNameMap);
                this.renderer.Initialize();//不在此显式初始化也可以。
                this.renderer.SetUniformValue("show model", 1.0f);
                this.renderer.SetUniformValue("show normal", 1.0f);
                this.renderer.SetUniformValue("normal length", 1.0f);
            }

            //this.demoLifebar = new DemoLifeBar(0.2f, 0.02f, 4);
            //this.demolifebarRenderer = new NormalLineRenderer(this.demoLifebar);
            //this.demolifebarRenderer.Initialize();

            this.lifebarRenderer = new LifeBarRenderer(new LifeBar(2f, 0.2f, 4f));
            this.lifebarRenderer.Initialize();

            //StringModel stringModel = DummyStringModelFactory.GetModel("teapot");
            this.stringRenderer = new StringRenderer("teapot".GetDummyModel());
            this.stringRenderer.Initialize();

            uiParam = new IUILayoutParam(AnchorStyles.Right | AnchorStyles.Bottom, new Padding(10, 10, 120, 10), new Size(50, 50));
            this.label = new DummyLabel(uiParam, "Hello Label!");
            this.label.Initialize();

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
            this.lblCamera.Text = string.Format("P: {0}, T: {1}, U: {2}, D: {3}",
                this.camera.Position, this.camera.Target, this.camera.UpVector,
                (this.camera.Position - this.camera.Target).Magnitude());
        }

        private vec3 translate = new vec3();
        private float interval = 0.1f;
        private DemoLifeBar demoLifebar;
        private bool alwaysFaceCamera = true;
        private bool alwaysSameSize = true;

        private void glCanvas1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.camera.MouseWheel(e.Delta);
        }

        private void FormGLCanvas_Load(object sender, EventArgs e)
        {
            GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);
            glCanvas1_Resize(this.glCanvas1, e);

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("This is a diffuse reflection demo with directional light and ambient light.");
            builder.AppendLine("Use 'm' to change model.");
            builder.AppendLine("Use 'c' to switch camera types between perspective and ortho.");
            builder.AppendLine("Use right mouse to rotate camera.");
            builder.AppendLine("Use left mouse to rotate model.");
            builder.AppendLine("Use 'j' to decrease vertex count.");
            builder.AppendLine("Use 'k' to increase vertex count.");
            builder.AppendLine("Use '1' to show/hide model.");
            builder.AppendLine("Use '2' to show/hide normal.");
            builder.AppendLine("Use '3' to switch 'always face camera.");
            builder.AppendLine("Use '4' to switch 'always same size.");

            MessageBox.Show(builder.ToString());

        }

        void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            var arg = new RenderEventArgs(RenderModes.Render, this.camera);
            mat4 projectionMatrix = camera.GetProjectionMat4();
            mat4 viewMatrix = camera.GetViewMat4();
            //mat4 modelMatrix = glm.rotate(rotateAngle, new vec3(0, 1, 0)); //modelRotationCamera.GetViewMat4(); //mat4.identity();
            //rotateAngle += 0.03f;
            //mat4 modelMatrix = this.modelRotator.GetModelRotation();//glm.rotate(rotateAngle, new vec3(0, 1, 0)); //modelRotationCamera.GetViewMat4(); //mat4.identity();
            mat4 modelMatrix = this.modelRotator.GetRotationMatrix();

            this.renderer.SetUniformValue("projection matrix", projectionMatrix);
            this.renderer.SetUniformValue("view matrix", glm.translate(viewMatrix, translate));
            this.renderer.SetUniformValue("model matrix", modelMatrix);

            //this.demolifebarRenderer.projectionMatrix = projectionMatrix;
            //this.demolifebarRenderer.viewMatrix = AlwaysFaceCamera(glm.translate(viewMatrix, translate));
            //this.demolifebarRenderer.modelMatrix = AlwaysSameSize(
            //    (this.camera.Target - this.camera.Position).Magnitude(), this.demoLifebar.Height);

            this.lifebarRenderer.projectionMatrix = projectionMatrix;
            this.lifebarRenderer.viewMatrix =
                alwaysFaceCamera ? AlwaysFaceCamera(glm.translate(viewMatrix, translate)) : glm.translate(viewMatrix, translate);
            this.lifebarRenderer.modelMatrix =
                alwaysSameSize ?
                    AlwaysSameSize(
                        (this.camera.Target - this.camera.Position).Magnitude() / 10,
                        this.lifebarRenderer.model.Height)
                    : glm.translate(mat4.identity(), new vec3(0, this.lifebarRenderer.model.Height, 0));

            this.stringRenderer.mvp = //projectionMatrix * viewMatrix * modelMatrix;
                projectionMatrix
                * (alwaysFaceCamera ? AlwaysFaceCamera(glm.translate(viewMatrix, translate)) : glm.translate(viewMatrix, translate))
                * (alwaysSameSize ?
                    AlwaysSameSize(
                        (this.camera.Target - this.camera.Position).Magnitude() / 10,
                        this.lifebarRenderer.model.Height + 1)
                    : glm.translate(mat4.identity(), new vec3(0, this.lifebarRenderer.model.Height, 0)));

            this.groundRenderer.SetUniformValue("projectionMatrix", projectionMatrix);
            this.groundRenderer.SetUniformValue("viewMatrix", viewMatrix);
            this.groundRenderer.SetUniformValue("modelMatrix", mat4.identity());
            this.groundRenderer.SetUniformValue("lineColor", new vec3(1, 1, 1));

            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT | GL.GL_STENCIL_BUFFER_BIT);

            this.uiAxis.Render(arg);
            this.label.Render(arg);

            this.renderer.Render(arg);
            //this.demolifebarRenderer.Render(arg);
            this.lifebarRenderer.Render(arg);
            this.stringRenderer.Render(arg);
            this.groundRenderer.Render(arg);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">camera的Position和Target之间的距离</param>
        /// <param name="height">血条高度</param>
        /// <returns></returns>
        private mat4 AlwaysSameSize(float length, float height)
        {
            mat4 result = glm.translate(glm.scale(mat4.identity(),
                new vec3(length, length, 1)),
                new vec3(0, height / length, 0));

            //float scale = -viewMatrix[3].z;// scale会失常。
            //mat4 result2 = new mat4(
            //    new vec4(scale, 0, 0, 0),
            //    new vec4(0, scale, 0, 0),
            //    new vec4(0, 0, 1, 0),
            //    new vec4(0, this.lifebar.Height, 0, 1)
            //    );

            return result;
        }

        private mat4 AlwaysFaceCamera(mat4 viewMatrix)
        {
            mat4 result = mat4.identity();
            for (int i = 0; i < 3; i++)
            {
                vec4 v = result[i];
                v.w = viewMatrix[i].w;
                result[i] = v;
            }
            result[3] = viewMatrix[3];

            return result;
        }

        private void glCanvas1_Resize(object sender, EventArgs e)
        {
            ////  Set the projection matrix.
            //GL.MatrixMode(GL.GL_PROJECTION);

            ////  Load the identity.
            //GL.LoadIdentity();

            ////  Create a perspective transformation.
            //GL.gluPerspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);

            ////  Use the 'look at' helper function to position and aim the camera.
            //GL.gluLookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);

            ////  Set the modelview matrix.
            //GL.MatrixMode(GL.GL_MODELVIEW);
        }


        private void glCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                modelRotator.SetBounds(this.glCanvas1.Width, this.glCanvas1.Height);
                modelRotator.MouseDown(e.X, e.Y);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cameraRotator.SetBounds(this.glCanvas1.Width, this.glCanvas1.Height);
                cameraRotator.MouseDown(e.X, e.Y);
            }

            PrintCameraInfo();
        }

        private void glCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                modelRotator.MouseMove(e.X, e.Y);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right && cameraRotator.MouseDownFlag)
            {
                cameraRotator.MouseMove(e.X, e.Y);
            }
            PrintCameraInfo();
        }

        private void glCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                modelRotator.MouseUp(e.X, e.Y);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cameraRotator.MouseUp(e.X, e.Y);
            }
            PrintCameraInfo();
        }

        private void PrintCameraInfo()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string.Format("position:{0}", this.camera.Position));
            builder.Append(string.Format(" target:{0}", this.camera.Target));
            builder.Append(string.Format(" up:{0}", this.camera.UpVector));
            builder.Append(string.Format(" camera type: {0}", this.camera.CameraType));

            //this.txtInfo.Text = builder.ToString();
        }

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

                PrintCameraInfo();
            }
            else if (e.KeyChar == 'j')
            {
                this.renderer.DecreaseVertexCount();
            }
            else if (e.KeyChar == 'k')
            {
                this.renderer.IncreaseVertexCount();
            }
            else if (e.KeyChar == 'p')
            {
                switch (this.renderer.polygonMode)
                {
                    case PolygonModes.Points:
                        this.renderer.polygonMode = PolygonModes.Lines;
                        break;
                    case PolygonModes.Lines:
                        this.renderer.polygonMode = PolygonModes.Filled;
                        break;
                    case PolygonModes.Filled:
                        this.renderer.polygonMode = PolygonModes.Points;
                        break;
                    default:
                        break;
                }
            }
            else if (e.KeyChar == '1')
            {
                //this.renderer.showModel = !this.renderer.showModel;
                float value = 0;
                this.renderer.GetUniformValue("show model", out value);
                this.renderer.SetUniformValue("show model", value == 1.0f ? 0.0f : 1.0f);
                //this.demolifebarRenderer.showModel = !this.demolifebarRenderer.showModel;
            }
            else if (e.KeyChar == '2')
            {
                //this.renderer.showNormal = !this.renderer.showNormal;
                float value = 0;
                this.renderer.GetUniformValue("show normal", out value);
                this.renderer.SetUniformValue("show normal", value == 1.0f ? 0.0f : 1.0f);
                //this.demolifebarRenderer.showNormal = !this.demolifebarRenderer.showNormal;
            }
            else if (e.KeyChar == 'w')
            {
                vec3 direction = (this.camera.Target - this.camera.Position);
                direction.y = 0;
                direction = direction.normalize();
                vec3 movement = interval * direction;
                this.translate += movement;

                FollowTargetObject();
            }
            else if (e.KeyChar == 's')
            {
                vec3 direction = -(this.camera.Target - this.camera.Position);
                direction.y = 0;
                direction = direction.normalize();
                vec3 movement = interval * direction;
                this.translate += movement;

                FollowTargetObject();
            }
            else if (e.KeyChar == 'a')
            {
                vec3 direction = -this.camera.UpVector.cross(this.camera.Target - this.camera.Position);
                direction.y = 0;
                direction = direction.normalize();
                vec3 movement = interval * direction;
                this.translate += movement;

                FollowTargetObject();
            }
            else if (e.KeyChar == 'd')
            {
                vec3 direction = this.camera.UpVector.cross(-(this.camera.Target - this.camera.Position));
                direction.y = 0;
                direction = direction.normalize();
                vec3 movement = interval * direction;
                this.translate += movement;

                FollowTargetObject();
            }
            else if (e.KeyChar == ',')
            {
                this.lifebarRenderer.model.Wdith -= 0.1f;
                this.lblState.Text = string.Format("length: {0}, width: {1}",
                    this.lifebarRenderer.model.Length,
                    this.lifebarRenderer.model.Wdith);
            }
            else if (e.KeyChar == '.')
            {
                this.lifebarRenderer.model.Wdith += 0.1f;
                this.lblState.Text = string.Format("length: {0}, width: {1}",
                    this.lifebarRenderer.model.Length,
                    this.lifebarRenderer.model.Wdith);
            }
            else if (e.KeyChar == '3')
            {
                this.alwaysFaceCamera = !this.alwaysFaceCamera;
            }
            else if (e.KeyChar == '4')
            {
                this.alwaysSameSize = !this.alwaysSameSize;
            }
        }

        private void FollowTargetObject()
        {
            //vec3 eyeVector = this.camera.Position - this.camera.Target;
            //this.camera.Target = this.translate;
            //this.camera.Position = this.translate + eyeVector;
        }

    }
}
