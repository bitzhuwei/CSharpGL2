﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// 在渲染时此VBO要执行绑定自己、指明数据结构和启用此VBO等操作。
    /// </summary>
    public class PropertyBufferPtr : BufferPtr
    {
        /// <summary>
        /// 在渲染时此VBO要执行绑定自己、指明数据结构和启用此VBO等操作。
        /// </summary>
        /// <param name="varNameInVertexShader"></param>
        /// <param name="bufferID">用GL.GenBuffers()得到的VBO的ID。</param>
        /// <param name="dataSize">gl.VertexAttribPointer(attributeLocation, 3, OpenGL.GL_FLOAT, false, 0, IntPtr.Zero);
        /// <para>表示第2个参数</para></param>
        /// <param name="dataType">GL_FLOAT etc
        /// <para>gl.VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);</para>
        /// <para>gl.VertexAttribPointer(attributeLocation, 3, OpenGL.GL_FLOAT, false, 0, IntPtr.Zero);</para>
        /// <para>表示第3个参数</para></param>
        /// <param name="length">此VBO含有多个个元素？</param>
        internal PropertyBufferPtr(string varNameInVertexShader,
            uint bufferID, int dataSize, uint dataType, int length)
            : base(bufferID, length)
        {
            this.VarNameInVertexShader = varNameInVertexShader;
            this.DataSize = dataSize;
            this.DataType = dataType;
        }

        /// <summary>
        /// 此顶点属性VBO对应于vertex shader中的哪个in变量？
        /// </summary>
        public string VarNameInVertexShader { get; set; }

        /// <summary>
        /// GL_FLOAT etc
        /// <para>gl.VertexAttribPointer(uint index, int size, uint type, bool normalized, int stride, IntPtr pointer);</para>
        /// <para>gl.VertexAttribPointer(attributeLocation, 3, OpenGL.GL_FLOAT, false, 0, IntPtr.Zero);</para>
        /// <para>表示第3个参数</para>
        /// </summary>
        public uint DataType { get; private set; }

        /// <summary>
        /// gl.VertexAttribPointer(attributeLocation, 3, OpenGL.GL_FLOAT, false, 0, IntPtr.Zero);
        /// <para>表示第2个参数</para>
        /// </summary>
        public int DataSize { get; private set; }

        /// <summary>
        /// 在使用<see cref="VertexArrayObject"/>后，此方法只会执行一次。
        /// </summary>
        /// <param name="e"></param>
        /// <param name="shaderProgram"></param>
        public override void Render(RenderEventArgs e, ShaderProgram shaderProgram)
        {
            uint location = shaderProgram.GetAttributeLocation(this.VarNameInVertexShader);
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.BufferID);
            GL.GetDelegateFor<GL.glVertexAttribPointer>()(location, this.DataSize, this.DataType, false, 0, IntPtr.Zero);
            GL.GetDelegateFor<GL.glEnableVertexAttribArray>()(location);
        }

    }
}
