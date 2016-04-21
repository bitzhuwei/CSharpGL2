﻿using CSharpGL.Objects.Models;
using CSharpGL.Objects.VertexBuffers;
using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.Objects.Demos
{
    public class DemoLifeBar : IModel
    {
        vec3[] positions = new vec3[4];
        vec3[] normals = new vec3[4];

        public DemoLifeBar(float length = 0.2f, float width = 0.02f, float height = 4f)
        {
            this.Length = length;
            this.Wdith = width;
            this.Height = height;

            this.positions[0] = new vec3(length / 2, +width / 2, 0);
            this.positions[1] = new vec3(length / 2, -width / 2, 0);
            this.positions[2] = new vec3(-length / 2, +width / 2, 0);
            this.positions[3] = new vec3(-length / 2, -width / 2, 0);

            //this.normals[0] = new vec3(length, width, 0);
            //this.normals[1] = new vec3(length, -width, 0);
            //this.normals[2] = new vec3(-length, width, 0);
            //this.normals[3] = new vec3(-length, -width, 0);
            //for (int i = 0; i < this.normals.Length; i++)
            //{
            //    this.normals[i].Normalize();
            //}
            for (int i = 0; i < this.normals.Length; i++)
            {
                this.normals[i] = new vec3(1, 0, 0);
            }
        }

        VertexBuffers.BufferPointer IModel.GetPositionBufferRenderer(string varNameInShader)
        {
            using (var buffer = new PositionBuffer(varNameInShader))
            {
                buffer.Alloc(this.positions.Length);
                unsafe
                {
                    vec3* array = (vec3*)buffer.FirstElement();
                    for (int i = 0; i < this.positions.Length; i++)
                    {
                        array[i] = this.positions[i];
                    }
                }

                return buffer.GetRenderer();
            }
        }

        VertexBuffers.BufferPointer IModel.GetColorBufferRenderer(string varNameInShader)
        {
            throw new NotImplementedException();
        }

        VertexBuffers.BufferPointer IModel.GetNormalBufferRenderer(string varNameInShader)
        {
            using (var buffer = new NormalBuffer(varNameInShader))
            {
                buffer.Alloc(this.normals.Length);
                unsafe
                {
                    vec3* array = (vec3*)buffer.FirstElement();
                    for (int i = 0; i < this.normals.Length; i++)
                    {
                        array[i] = this.normals[i];
                    }
                }

                return buffer.GetRenderer();
            }
        }

        IndexBufferPointerBase IModel.GetIndexes()
        {
            using (var buffer = new ZeroIndexBuffer(DrawMode.TriangleStrip, 0, this.positions.Length))
            {
                return buffer.GetRenderer() as IndexBufferPointerBase;
            }
        }

        class PositionBuffer : PropertyBuffer<vec3>
        {
            public PositionBuffer(string varNameInShader)
                : base(varNameInShader, 3, GL.GL_FLOAT, BufferUsage.StaticDraw)
            { }
        }

        class NormalBuffer : PropertyBuffer<vec3>
        {
            public NormalBuffer(string varNameInShader)
                : base(varNameInShader, 3, GL.GL_FLOAT, BufferUsage.StaticDraw)
            { }
        }

        public float Height { get; set; }

        public float Length { get; set; }

        public float Wdith { get; set; }
    }
}
