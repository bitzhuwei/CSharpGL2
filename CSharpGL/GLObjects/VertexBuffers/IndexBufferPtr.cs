﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// 用GL.DrawElements()执行一个索引buffer的渲染操作。
    /// </summary>
    public sealed class IndexBufferPtr : IndexBufferPtrBase
    {
        /// <summary>
        /// 用GL.DrawElements()执行一个索引buffer的渲染操作。
        /// </summary>
        /// <param name="bufferID">用GL.GenBuffers()得到的VBO的ID。</param>
        /// <param name="mode">用哪种方式渲染各个顶点？（OpenGL.GL_TRIANGLES etc.）</param>
        /// <param name="elementCount">索引数组中有多少个元素。</param>
        /// <param name="type">type in GL.DrawElements(uint mode, int count, uint type, IntPtr indices);
        /// <para>表示第3个参数，表示索引元素的类型。</para></param>
        internal IndexBufferPtr(uint bufferID, DrawMode mode, int elementCount, IndexElementType type)
            : base(mode, bufferID)
        {
            this.ElementCount = elementCount;
            this.Type = type;
        }

        /// <summary>
        /// 要渲染多少个索引。
        /// </summary>
        public int ElementCount { get; set; }

        /// <summary>
        /// type in GL.DrawElements(uint mode, int count, uint type, IntPtr indices);
        /// 只能是OpenGL.UNSIGNED_BYTE, OpenGL.UNSIGNED_SHORT, or OpenGL.UNSIGNED_INT
        /// </summary>
        public IndexElementType Type { get; private set; }

        public override void Render(RenderEventArgs e, ShaderProgram shaderProgram)
        {
            GL.BindBuffer(GL.GL_ELEMENT_ARRAY_BUFFER, this.BufferID);
            GL.DrawElements(this.Mode, this.ElementCount, (uint)this.Type, IntPtr.Zero);
        }
    }
}
