﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.FileParser._3DSParser.Chunks
{
    /// <summary>
    /// 此类型chunk的内容只有一个字符串。
    /// </summary>
    public abstract class StringChunk : ChunkBase
    {
        protected string Content;

        internal override void Process(ParsingContext context)
        {
            StringChunkProcess(context);
        }

        internal void StringChunkProcess(ParsingContext context)
        {
            var reader = context.reader;

            StringBuilder builder = new StringBuilder();

            byte b = reader.ReadByte();
            uint idx = 0;
            while (b != 0)
            {
                builder.Append((char)b);
                b = reader.ReadByte();
                idx++;
            }
            this.BytesRead += idx + 1;

            this.Content = builder.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}, Content: {1}", this.GetBasicInfo(), Content);
        }
    }
}
