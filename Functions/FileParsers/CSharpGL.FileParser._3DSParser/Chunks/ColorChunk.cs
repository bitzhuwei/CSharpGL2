﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpGL.FileParser._3DSParser.Chunks
{
    public abstract class ColorChunk : ChunkBase
    {
        public float R;
        public float G;
        public float B;

        internal override void Process(ParsingContext context)
        {
            var reader = context.reader;

            //COL_TRU 0x0011 //真彩色模式，以char存放3个分量
            /*
0x0011：字节格式的颜色。
父chunk：任何可能的chunk
子chunk：无
长度：头长度+内容长度
内容：
颜色（三个字节red,green,blue）
             */
            var child = reader.ReadChunk();
            this.R = (float)reader.ReadByte() / 256;
            this.G = (float)reader.ReadByte() / 256;
            this.B = (float)reader.ReadByte() / 256;

            this.BytesRead += child.Length;
        }

        public override string ToString()
        {
            return string.Format("{0}, RGB: {1}, {2}, {3}", this.GetBasicInfo(), this.R, this.G, this.B);
        }
    }
}
