using CSharpGL.Windows.Demos.ModelAdapters;
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

namespace CSharpGL.Windows.Demos
{
    public partial class Form01ModernRenderer : Form
    {

        ModernRenderer renderer;
        Camera camera;

        public Form01ModernRenderer()
        {
            InitializeComponent();

            // 天蓝色背景
            GL.ClearColor(0x87 / 255.0f, 0xce / 255.0f, 0xeb / 255.0f, 0xff / 255.0f);
        }

        private void glCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);

            mat4 projectionMatrix = camera.GetProjectionMat4();
            mat4 viewMatrix = camera.GetViewMat4();
            mat4 modelMatrix = mat4.identity();
            ModernRenderer renderer = this.renderer;
            if (renderer != null)
            {
                renderer.SetUniformValue("projectionMatrix", projectionMatrix);
                renderer.SetUniformValue("viewMatrix", viewMatrix);
                renderer.SetUniformValue("modelMatrix", modelMatrix);
                renderer.Render(new RenderEventArgs(RenderModes.Render, this.camera));
            }
        }

        private void Form01ModernRenderer_Load(object sender, EventArgs e)
        {
            {
                var camera = new Camera(CameraType.Perspecitive, this.glCanvas1.Width, this.glCanvas1.Height);
                this.camera = camera;
            }
            {
                IBufferable bufferable = new BigDipperAdapter(new Models.BigDipper());
                ShaderCode[] shaders = new ShaderCode[2];
                shaders[0] = new ShaderCode(@"Shaders\BigDipper.vert", ShaderType.VertexShader);
                shaders[1] = new ShaderCode(@"Shaders\BigDipper.frag", ShaderType.FragmentShader);
                var propertyNameMap = new PropertyNameMap();
                propertyNameMap.Add("in_Position", "position");
                propertyNameMap.Add("in_Color", "color");
                var uniformNameMap = new UniformNameMap();
                uniformNameMap.Add("projectionMatrix", "projectionMatrix");
                uniformNameMap.Add("viewMatrix", "viewMatrix");
                uniformNameMap.Add("modelMatrix", "modelMatrix");
                var renderer = new ModernRenderer(bufferable, shaders, propertyNameMap, uniformNameMap);
                renderer.Initialize();
                this.renderer = renderer;
            }
        }
    }
}
