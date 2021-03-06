﻿using CSharpGL;
using CSharpGL.Objects;
using CSharpGL.Objects.Cameras;
using CSharpGL.Objects.Models;
using GLM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpGL
{
    public partial class FormModernOpenGL : Form
    {
        private Camera camera;
        private SatelliteRotator rotator;
        private PyramidRenderer pyramidRenderer;
        private float rotationAngle;

        public FormModernOpenGL()
        {
            InitializeComponent();

            //GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);

            this.camera = new Camera(CameraType.Perspecitive, this.glCanvas1.Width, this.glCanvas1.Height);
            this.camera.Position = new vec3(-5,5,-5);
            rotator = new SatelliteRotator(this.camera);

            var model = new PyramidModel();
            IModel modelAdapter = new PyramidModelAdapter(model);
            this.pyramidRenderer = new PyramidRenderer(modelAdapter);
            this.pyramidRenderer.Initialize();

            this.glCanvas1.MouseWheel += glCanvas1_MouseWheel;
            this.glCanvas1.MouseDown += glCanvas1_MouseDown;
            this.glCanvas1.MouseMove += glCanvas1_MouseMove;
            this.glCanvas1.MouseUp += glCanvas1_MouseUp;
            this.glCanvas1.OpenGLDraw += glCanvas1_OpenGLDraw;
            this.glCanvas1.Resize += glCanvas1_Resize;
            this.glCanvas1.KeyPress += glCanvas1_KeyPress;
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
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            var arg = new RenderEventArgs(RenderModes.Render, this.camera);
            mat4 projectionMatrix = camera.GetProjectionMat4();
            mat4 viewMatrix = camera.GetViewMat4();
            mat4 modelMatrix = glm.rotate(rotationAngle, new vec3(0, 1, 0)); //mat4.identity();
            //mat4 mvp = projectionMatrix * viewMatrix * modelMatrix;

            this.pyramidRenderer.projectionMatrix = projectionMatrix;
            this.pyramidRenderer.viewMatrix = viewMatrix;
            this.pyramidRenderer.modelMatrix = modelMatrix;

            this.pyramidRenderer.Render(arg);

            this.Text = string.Format("FormModernOpenGL FPS: {0}", this.glCanvas1.FPS);
        }

        private void glCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            this.rotator.SetBounds(this.glCanvas1.Width, this.glCanvas1.Height);
            this.rotator.MouseDown(e.X, e.Y);
        }

        private void glCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.rotator.MouseDownFlag)
            {
                this.rotator.MouseMove(e.X, e.Y);
            }
        }

        private void glCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            this.rotator.MouseUp(e.X, e.Y);
        }

        private void FormModernOpenGL_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Use 'c' to switch camera types between perspective and ortho");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.rotationAngle += 3.0f;
        }

    }
}
