﻿using GLM;
using CSharpGL.ColorCodedPicking;
using CSharpGL.Objects.Shaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGL.Objects.Cameras;

namespace CSharpGL.Objects.Demos
{
    /// <summary>
    /// 演示如何使用<see cref="IColorCodedPicking"/>进行拾取。
    /// </summary>
    public class DemoColorCodedPickingElement : RendererBase, IColorCodedPicking
    {
        const float unitSpace = 6f;
        private static readonly vec3[] unitCubePos;
        private static readonly uint[] unitCubeIndex;
        /// <summary>
        /// http://images.cnblogs.com/cnblogs_com/bitzhuwei/482613/o_Cube-small.jpg
        /// </summary>
        static DemoColorCodedPickingElement()
        {
            unitCubePos = new vec3[8];
            unitCubePos[0] = new vec3(1, 1, 1);
            unitCubePos[1] = new vec3(-1, 1, 1);
            unitCubePos[2] = new vec3(1, -1, 1);
            unitCubePos[3] = new vec3(-1, -1, 1);
            unitCubePos[4] = new vec3(1, 1, -1);
            unitCubePos[5] = new vec3(-1, 1, -1);
            unitCubePos[6] = new vec3(1, -1, -1);
            unitCubePos[7] = new vec3(-1, -1, -1);

            unitCubeIndex = new uint[14];
            unitCubeIndex[0] = 0;
            unitCubeIndex[1] = 2;
            unitCubeIndex[2] = 4;
            unitCubeIndex[3] = 6;
            unitCubeIndex[4] = 7;
            unitCubeIndex[5] = 2;
            unitCubeIndex[6] = 3;
            unitCubeIndex[7] = 0;
            unitCubeIndex[8] = 1;
            unitCubeIndex[9] = 4;
            unitCubeIndex[10] = 5;
            unitCubeIndex[11] = 7;
            unitCubeIndex[12] = 1;
            unitCubeIndex[13] = 3;
        }


        private ShaderProgram shaderProgram;
        private ShaderProgram currentShaderProgram;
        const string strin_Position = "in_Position";
        const string strin_Color = "in_Color";
        const string strMVP = "MVP";
        public mat4 mvp;

        private uint[] vao;
        private int size;

        public DemoColorCodedPickingElement(int size)
        {
            this.size = size;
            this.pickingShaderProgram = PickingShaderHelper.GetPickingShaderProgram();
        }

        protected override void DoInitialize()
        {
            this.shaderProgram = InitializeShader();

            InitVAO();

        }

        private void InitVAO()
        {
            int size = this.size;

            this.vao = new uint[1];

            GL.GenVertexArrays(1, vao);

            GL.BindVertexArray(vao[0]);

            // prepare positions
            {
                var positionArray = new UnmanagedArray<vec3>(size * size * size * 8);
                int index = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            for (int cubeIndex = 0; cubeIndex < 8; cubeIndex++)
                            {
                                positionArray[index++] = unitCubePos[cubeIndex]
                                    + new vec3((i - size / 2) * unitSpace, (j - size / 2) * unitSpace, (k - size / 2) * unitSpace);
                            }
                        }
                    }
                }

                uint in_PositionLocation = shaderProgram.GetAttributeLocation(strin_Position);

                uint[] ids = new uint[1];
                GL.GenBuffers(1, ids);
                GL.BindBuffer(BufferTarget.ArrayBuffer, ids[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, positionArray, BufferUsage.StaticDraw);
                GL.VertexAttribPointer(in_PositionLocation, 3, GL.GL_FLOAT, false, 0, IntPtr.Zero);
                GL.EnableVertexAttribArray(in_PositionLocation);

                positionArray.Dispose();
            }
            // prepare colors
            {
                var colorArray = new UnmanagedArray<vec3>(size * size * size * 8);
                Random random = new Random();
                int index = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            //vec3 color = new vec3((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
                            for (int cubeIndex = 0; cubeIndex < 8; cubeIndex++)
                            {
                                vec3 color = new vec3((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
                                colorArray[index++] = color;
                            }
                        }
                    }
                }

                uint in_ColorLocation = shaderProgram.GetAttributeLocation(strin_Color);

                uint[] ids = new uint[1];
                GL.GenBuffers(1, ids);
                GL.BindBuffer(BufferTarget.ArrayBuffer, ids[0]);
                GL.BufferData(BufferTarget.ArrayBuffer, colorArray, BufferUsage.StaticDraw);
                GL.VertexAttribPointer(in_ColorLocation, 3, GL.GL_FLOAT, false, 0, IntPtr.Zero);
                GL.EnableVertexAttribArray(in_ColorLocation);

                colorArray.Dispose();
            }
            // prepare index
            {
                var indexArray = new UnmanagedArray<uint>(size * size * size * (14 + 1));
                int index = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            for (int cubeIndex = 0; cubeIndex < 14; cubeIndex++)
                            {
                                long posIndex = unitCubeIndex[cubeIndex] + (i * size * size + j * size + k) * 8;
                                indexArray[index++] = (uint)posIndex;
                            }

                            indexArray[index++] = uint.MaxValue;
                        }
                    }
                }

                uint[] ids = new uint[1];
                GL.GenBuffers(1, ids);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, ids[0]);
                GL.BufferData(BufferTarget.ElementArrayBuffer, indexArray, BufferUsage.StaticDraw);

                indexArray.Dispose();
            }

            //  Unbind the vertex array, we've finished specifying data for it.
            GL.BindVertexArray(0);
        }

        protected ShaderProgram InitializeShader()
        {
            var vertexShaderSource = ManifestResourceLoader.LoadTextFile(@"DemoColorCodedPickingElement.vert");
            var fragmentShaderSource = ManifestResourceLoader.LoadTextFile(@"DemoColorCodedPickingElement.frag");

            var shaderProgram = new ShaderProgram();
            shaderProgram.Create(vertexShaderSource, fragmentShaderSource, null);

            return shaderProgram;
        }

        private int count = 3;
        private ShaderProgram pickingShaderProgram;
        public float pickedVertexID = uint.MaxValue;
        public bool picked;

        public int Count
        {
            get { return count; }
            set
            {
                int size = this.size;
                int count = size * size * size * 15;
                if (3 <= value && value <= count)
                { this.count = value; }
            }
        }

        protected override void DoRender(RenderEventArgs e)
        {
            if (e.RenderMode == RenderModes.HitTest)
            {
                this.currentShaderProgram = this.pickingShaderProgram;
            }
            else
            {
                this.currentShaderProgram = this.shaderProgram;
            }
            ShaderProgram shaderProgram = this.currentShaderProgram;

            shaderProgram.Bind();
            if (shaderProgram == this.pickingShaderProgram)
            {
                shaderProgram.SetUniform("pickingBaseID", ((IColorCodedPicking)this).PickingBaseID);
                shaderProgram.SetUniformMatrix4(strMVP, mvp.to_array());
                //shaderProgram.SetUniform("picked", 0.0f);
                shaderProgram.SetUniform("pickedVertexIDMin", this.pickedVertexID);
                shaderProgram.SetUniform("pickedVertexIDMax", this.pickedVertexID - 1);
            }
            else
            {
                shaderProgram.SetUniformMatrix4(strMVP, mvp.to_array());
                //shaderProgram.SetUniform("picked", picked ? 1.0f : 0.0f);
                if (this.picked)
                {
                    shaderProgram.SetUniform("pickedVertexIDMin", this.pickedVertexID - 7);
                    shaderProgram.SetUniform("pickedVertexIDMax", this.pickedVertexID);
                }
                else
                {
                    shaderProgram.SetUniform("pickedVertexIDMin", this.pickedVertexID);
                    shaderProgram.SetUniform("pickedVertexIDMax", this.pickedVertexID - 1);
                }
            }

            GL.Enable(GL.GL_PRIMITIVE_RESTART);
            GL.PrimitiveRestartIndex(uint.MaxValue);

            GL.BindVertexArray(vao[0]);

            //int size = this.size;
            //int count = size * size * size * 15;
            //GL.DrawElements(PrimitiveModes.TriangleStrip, count, GL.GL_UNSIGNED_INT, IntPtr.Zero);
            GL.DrawElements(DrawMode.TriangleStrip, this.count, GL.GL_UNSIGNED_INT, IntPtr.Zero);

            GL.BindVertexArray(0);

            GL.Disable(GL.GL_PRIMITIVE_RESTART);

            shaderProgram.Unbind();
        }

        uint IColorCodedPicking.PickingBaseID { get; set; }

        uint IColorCodedPicking.GetVertexCount()
        {
            int size = this.size;
            int count = size * size * size * 15;
            return (uint)count;
        }

        IPickedGeometry IColorCodedPicking.Pick(uint stageVertexID)
        {
            IColorCodedPicking element = this as IColorCodedPicking;
            PickedGeometryIndexed pickedGeometry = element.TryPick<PickedGeometryIndexed>(
                PrimitiveModes.TriangleStrip, stageVertexID);

            if (pickedGeometry == null) { return null; }

            // Fill primitive's positions and colors. This maybe changes much more than lines above in second dev.
            uint lastVertexID;
            if (element.GetLastVertexIDOfPickedGeometry(stageVertexID, out lastVertexID))
            {
                pickedGeometry.CubeIndex = lastVertexID / 8;
                var vertexIndex = lastVertexID % 8;
                pickedGeometry.positions = new vec3[1] { unitCubePos[vertexIndex] };
            }

            return pickedGeometry;
        }


        protected override void DisposeUnmanagedResources()
        {
            GL.DeleteVertexArrays(vao.Length, vao);
            this.shaderProgram.Delete();
        }
    }
}
