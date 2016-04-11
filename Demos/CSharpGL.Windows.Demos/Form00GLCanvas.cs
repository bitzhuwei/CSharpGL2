using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Windows.Demos
{
    public partial class Form00GLCanvas : Form
    {

        public Form00GLCanvas()
        {
            InitializeComponent();

            // 天蓝色背景
            GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);
        }

        private void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            int a = random.Next(0, 256);
            GL.ClearColor(r / 255.0f, g / 255.0f, b / 255.0f, a / 255.0f);
        }

        Random random = new Random();
    }
}
