﻿using GLM;
using CSharpGL.Objects;
using CSharpGL.Objects.Cameras;
using CSharpGL.Objects.Demos.UIs;
using CSharpGL.Objects.SceneElements;
using CSharpGL.Objects.Shaders;
using CSharpGL.UIs;
using System;
using System.Text;
using System.Windows.Forms;
using CSharpGL.Objects.Demos;

namespace CSharpGL.Winforms.Demo
{
    public partial class FormFontElement : Form
    {
        Camera camera;

        SatelliteRotator satelliteRoration;

        FontElement element;
        SimpleUIAxis uiAxisElement;

        public FormFontElement()
        {
            InitializeComponent();

            //if (CameraDictionary.Instance.ContainsKey(this.GetType().Name))
            //{
            //    this.camera = CameraDictionary.Instance[this.GetType().Name];
            //}
            //else
            {
                this.camera = new Camera(CameraType.Perspecitive, this.glCanvas1.Width, this.glCanvas1.Height);
                //CameraDictionary.Instance.Add(this.GetType().Name, this.camera);
            }

            IPerspectiveCamera perspectiveCamera = this.camera;
            perspectiveCamera.FieldOfView = 60f;
            perspectiveCamera.AspectRatio = (double)this.glCanvas1.Width / (double)this.glCanvas1.Height;
            perspectiveCamera.Near = 0.01;
            perspectiveCamera.Far = 10000;

            IOrthoCamera orthoCamera = this.camera;
            orthoCamera.Left = -this.glCanvas1.Width / 2;
            orthoCamera.Right = this.glCanvas1.Width / 2;
            orthoCamera.Bottom = -this.glCanvas1.Height / 2;
            orthoCamera.Top = this.glCanvas1.Height / 2;
            orthoCamera.Near = -10000;
            orthoCamera.Far = 10000;

            this.camera.Position = new vec3(0, 0, 9.23f);

            satelliteRoration = new SatelliteRotator(camera);

            //element = new ModernSingleTextureFont("simsun.ttf", 48, '祝', '神');//char.MinValue, char.MaxValue);
            //element = new FontElement("simsun.ttf", 48, '一', '龟');//包含了几乎所有汉字字符
            element = new FontElement("simsun.ttf", 48, (char)0, '~');
            element.Initialize();

            //element.SetText("祝神");
            //element.SetText("一龟");
            element.SetText("The quick brown fox jumps over the lazy dog!");

            uiAxisElement = new SimpleUIAxis(
                new IUILayoutParam(AnchorStyles.Left | AnchorStyles.Bottom,
                    new Padding(0, 0, 0, 0), new System.Drawing.Size(100, 100)));
            uiAxisElement.Initialize();

            this.glCanvas1.MouseWheel += glCanvas1_MouseWheel;
            this.glCanvas1.KeyPress += glCanvas1_KeyPress;
            this.glCanvas1.MouseDown += glCanvas1_MouseDown;
            this.glCanvas1.MouseMove += glCanvas1_MouseMove;
            this.glCanvas1.MouseUp += glCanvas1_MouseUp;
            this.glCanvas1.OpenGLDraw += glCanvas1_OpenGLDraw;
            this.glCanvas1.Resize += glCanvas1_Resize;
        }

        private void glCanvas1_Resize(object sender, EventArgs e)
        {
            if (this.camera != null)
            {
                this.camera.Resize(this.glCanvas1.Width, this.glCanvas1.Height);
            }
        }

        void glCanvas1_MouseWheel(object sender, MouseEventArgs e)
        {
            this.camera.MouseWheel(e.Delta);
        }

        void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            PrintCameraInfo();

            mat4 projectionMatrix = this.camera.GetProjectionMat4();
            mat4 viewMatrix = this.camera.GetViewMat4();
            mat4 modelMatrix = mat4.identity();

            element.mvp = projectionMatrix * viewMatrix * modelMatrix;

            var arg = new RenderEventArgs(RenderModes.Render, this.camera);

            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            element.Render(arg);
            uiAxisElement.Render(arg);
        }

        private void FormFreeTypeTextVAOElement_Load(object sender, EventArgs e)
        {
            PrintCameraInfo();
            MessageBox.Show(string.Format("{1}{0}{2}",
                Environment.NewLine,
                "Use 'c' to switch camera types between perspective and ortho",
                "Use 'b' to switch blend effect"));
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

            this.txtInfo.Text = builder.ToString();
        }

        private void glCanvas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'b')
            {
                element.blend = !element.blend;
            }
            else if (e.KeyChar == 'c')
            {
                if (camera.CameraType == CameraType.Perspecitive)
                {
                    camera.CameraType = CameraType.Ortho;
                }
                else
                {
                    camera.CameraType = CameraType.Perspecitive;
                }
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);

            this.element.Dispose();
        }
    }
}
