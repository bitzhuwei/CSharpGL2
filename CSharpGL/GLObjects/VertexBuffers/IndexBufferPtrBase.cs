﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// 索引buffer渲染器的基类。
    /// </summary>
    public abstract class IndexBufferPtrBase : BufferPtr
    {

        /// <summary>
        /// 用哪种方式渲染各个顶点？（OpenGL.GL_TRIANGLES etc.）
        /// </summary>
        public DrawMode Mode { get; private set; }

        /// <summary>
        /// 索引buffer渲染器的基类。
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="bufferID"></param>
        internal IndexBufferPtrBase(DrawMode mode, uint bufferID)
            : base(bufferID)
        {
            this.Mode = mode;
        }
    }
}
