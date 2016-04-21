﻿using GLM;
using CSharpGL.Objects;
using CSharpGL.Objects.Cameras;
using CSharpGL.Objects.Demos.UIs;
using CSharpGL.Objects.SceneElements;
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
using CSharpGL.Objects.Common;

namespace CSharpGL.Winforms.Demo
{
    public partial class FormSimpleUIRect : Form
    {
        LegacySimpleUIRect legacyLeftBottomRect;
        LegacySimpleUIRect legacyLeftTopRect;
        LegacySimpleUIRect legacyRightBottomRect;
        LegacySimpleUIRect legacyRightTopRect;

        SimpleUIRect uiLeftBottomRect;
        SimpleUIRect uiLeftTopRect;
        SimpleUIRect uiRightBottomRect;
        SimpleUIRect uiRightTopRect;

        AxisElement axisElement;

        Camera camera;

        SatelliteRotator satelliteRoration;
        private int renderSign;

        public FormSimpleUIRect()
        {
            InitializeComponent();

            //if (CameraDictionary.Instance.ContainsKey(this.GetType().Name))
            //{
            //    this.camera = CameraDictionary.Instance[this.GetType().Name];
            //}
            //else
            {
                this.camera = new Camera(CameraType.Ortho, this.glCanvas1.Width, this.glCanvas1.Height);
                //CameraDictionary.Instance.Add(this.GetType().Name, this.camera);
            }

            satelliteRoration = new SatelliteRotator(camera);

            Padding padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            Size size = new Size(100, 100);
            IUILayoutParam param;
            param = new IUILayoutParam(AnchorStyles.Left | AnchorStyles.Bottom, padding, size);
            uiLeftBottomRect = new SimpleUIRect(param);
            legacyLeftBottomRect = new LegacySimpleUIRect(param, new Objects.GLColor(1, 1, 1, 1));

            param = new IUILayoutParam(AnchorStyles.Left | AnchorStyles.Top, padding, size);
            uiLeftTopRect = new SimpleUIRect(param);
            legacyLeftTopRect = new LegacySimpleUIRect(param, new Objects.GLColor(1, 1, 1, 1));

            param = new IUILayoutParam(AnchorStyles.Right | AnchorStyles.Bottom, padding, size);
            uiRightBottomRect = new SimpleUIRect(param);
            legacyRightBottomRect = new LegacySimpleUIRect(param, new Objects.GLColor(1, 1, 1, 1));

            param = new IUILayoutParam(AnchorStyles.Right | AnchorStyles.Top, padding, size);
            uiRightTopRect = new SimpleUIRect(param);
            legacyRightTopRect = new LegacySimpleUIRect(param, new Objects.GLColor(1, 1, 1, 1));

            uiLeftBottomRect.Initialize();
            uiLeftTopRect.Initialize();
            uiRightBottomRect.Initialize();
            uiRightTopRect.Initialize();

            legacyLeftBottomRect.Initialize();
            legacyLeftTopRect.Initialize();
            legacyRightBottomRect.Initialize();
            legacyRightTopRect.Initialize();

            axisElement = new AxisElement();
            axisElement.Initialize();

            this.glCanvas1.MouseWheel += glCanvas1_MouseWheel;
            this.glCanvas1.KeyPress += glCanvas1_KeyPress;
            this.glCanvas1.MouseDown += glCanvas1_MouseDown;
            this.glCanvas1.MouseMove += glCanvas1_MouseMove;
            this.glCanvas1.MouseUp += glCanvas1_MouseUp;
            this.glCanvas1.OpenGLDraw += glCanvas1_OpenGLDraw;
            this.glCanvas1.Resize += glCanvas1_Resize;
        }

        private void glCanvas1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.camera.MouseWheel(e.Delta);
        }

        private void FormTranslateOnScreen_Load(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{1}{0}{2}",
                Environment.NewLine,
                "Use 'c' to switch camera types between perspective and ortho",
                "Use 'a' to switch render sign between legacy and modern opengl"));
        }

        void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            PrintCameraInfo();

            //GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            var arg = new RenderEventArgs(RenderModes.Render, this.camera);
            mat4 projectionMatrix = camera.GetProjectionMat4();
            mat4 viewMatrix = camera.GetViewMat4();
            mat4 modelMatrix = mat4.identity();
            mat4 mvp = projectionMatrix * viewMatrix * modelMatrix;

            axisElement.mvp = mvp;

            axisElement.Render(arg);

            var uiArg = new RenderEventArgs(RenderModes.Render, null);
            if (this.renderSign % 2 == 0)
            {
                uiLeftBottomRect.Render(uiArg);
                uiLeftTopRect.Render(uiArg);
                uiRightBottomRect.Render(uiArg);
                uiRightTopRect.Render(uiArg);
            }
            else if (this.renderSign % 2 == 1)
            {
                legacyLeftBottomRect.Render(uiArg);
                legacyLeftTopRect.Render(uiArg);
                legacyRightBottomRect.Render(uiArg);
                legacyRightTopRect.Render(uiArg);
            }
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
            builder.Append(string.Format("position:{0}", this.camera.Position));
            builder.Append(string.Format(" target:{0}", this.camera.Target));
            builder.Append(string.Format(" up:{0}", this.camera.UpVector));
            builder.Append(string.Format(" camera type: {0}", this.camera.CameraType));

            this.txtInfo.Text = builder.ToString();
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
            }
            else if (e.KeyChar == 'a')
            {
                this.renderSign = (this.renderSign + 1) % 2;
            }
        }
    }
}
