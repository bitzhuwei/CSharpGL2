﻿using CSharpGL.Objects;
using CSharpGL.Objects.Cameras;
using CSharpGL.Objects.VolumeRendering;
using GLM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Winforms.Demo
{
    public partial class FormVolumeRendering00 : Form
    {
        private CRawDataProcessor processor = new CRawDataProcessor();
        private CTranformationMgr m_pTransform = new CTranformationMgr();
        private CRendererHelper m_Renderer = new CRendererHelper();
        private bool nFlags;
        private const string textureFilename = "head256x256x109";


        public FormVolumeRendering00()
        {
            InitializeComponent();

            processor.ReadFile(textureFilename, 256, 256, 109);
            m_Renderer.Initialize(processor, m_pTransform);

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
            //if (this.camera != null)
            //{
            //    this.camera.Resize(this.glCanvas1.Width, this.glCanvas1.Height);
            //}
            m_Renderer.Resize(this.glCanvas1.Width, this.glCanvas1.Height);
        }

        void glCanvas1_MouseWheel(object sender, MouseEventArgs e)
        {
            //this.camera.MouseWheel(e.Delta);
            m_Renderer.MouseWheel(e.Delta);
        }

        void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            //var arg = new RenderEventArgs(RenderModes.Render, this.camera);
            //element.Render(arg);

            m_Renderer.Render();
        }

        private void glCanvas1_MouseDown(object sender, MouseEventArgs e)
        {
            //this.rotator.SetBounds(this.glCanvas1.Width, this.glCanvas1.Height);
            //this.rotator.MouseDown(e.X, e.Y);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                lastPoint = e.Location;
                nFlags = true;
            }
        }

        Point lastPoint = new Point();

        private void glCanvas1_MouseMove(object sender, MouseEventArgs e)
        {
            //if (this.rotator.mouseDownFlag)
            //{
            //    this.rotator.MouseMove(e.X, e.Y);
            //}
            if (nFlags && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                m_pTransform.Rotate(lastPoint.Y - e.Y, lastPoint.X - e.X, 0);
                lastPoint = e.Location;
            }
        }

        private void glCanvas1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                nFlags = false;
            }
            //this.rotator.MouseUp(e.X, e.Y);
        }

        private void glCanvas1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 'c')
            //{
            //    switch (this.camera.CameraType)
            //    {
            //        case CameraType.Perspecitive:
            //            this.camera.CameraType = CameraType.Ortho;
            //            break;
            //        case CameraType.Ortho:
            //            this.camera.CameraType = CameraType.Perspecitive;
            //            break;
            //        default:
            //            throw new NotImplementedException();
            //    }

            //}
        }

        private void 打开OToolStripButton_Click(object sender, EventArgs e)
        {
            //if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //CRawDataProcessor c = new CRawDataProcessor();
                //c.ReadFile(this.openFileDialog1.FileName, 256, 256, 109);
                //this.processor = c;
            }
        }

        private void FormVolumeRendering01_Load(object sender, EventArgs e)
        {
            this.glCanvas1_Resize(this.glCanvas1, e);

            MessageBox.Show("此示例是从（http://www.codeproject.com/Articles/352270/Getting-started-with-Volume-Rendering）的C++代码转换来的。");
        }

        private void lblExport3DTexture_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Export3DTexture(textureFilename, 256, 256, 109, this.saveFileDialog1.FileName);

                Process.Start("explorer", (new FileInfo(this.saveFileDialog1.FileName)).DirectoryName);
            }
        }


        private void Export3DTexture(string lpDataFile_i, int imageWidth, int imageHeight, int imageCount, string exportFilename)
        {
            FileStream file = new FileStream(lpDataFile_i, FileMode.Open, FileAccess.Read);

            byte[] chBuffer = new byte[imageWidth * imageHeight * imageCount];

            // Holds the RGBA buffer
            file.Read(chBuffer, 0, chBuffer.Length);

            int index = 0;
            for (int i = 0; i < imageCount; i++)
            {
                Bitmap bitmap = new Bitmap(imageWidth, imageHeight);
                for (int col = 0; col < imageWidth; col++)
                {
                    for (int row = 0; row < imageHeight; row++)
                    {
                        byte component = chBuffer[index++];
                        Color c = Color.FromArgb(component, component, component, component);
                        bitmap.SetPixel(col, row, c);
                    }
                }
                bitmap.Save(string.Format("{0}{1}.png", exportFilename, i), System.Drawing.Imaging.ImageFormat.Png);
            }

        }

        private void trackAlpha_Scroll(object sender, EventArgs e)
        {
            var value = (float)this.trackAlpha.Value / 100.0f;
            this.m_Renderer.alphaThreshold = value;
            this.lblAlphaThreshold.Text = value.ToShortString();
        }

        private void trackNegativeZ_Scroll(object sender, EventArgs e)
        {
            var value = (float)this.trackNegativeZ.Value / 100.0f;
            this.m_Renderer.negativeZ = value;
            this.lblNegativeZ.Text = value.ToShortString();
        }

        private void trackPositiveZ_Scroll(object sender, EventArgs e)
        {
            var value = (float)this.trackPositiveZ.Value / 100.0f;
            this.m_Renderer.positiveZ = value;
            this.lblPositiveZ.Text = value.ToShortString();
        }
    }
}
