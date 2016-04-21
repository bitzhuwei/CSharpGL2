﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.FileParser._3DSParser.Chunks
{
    public class ObjectBlockChunk : ChunkBase
    {
        public string Name;

        internal override void Process(ParsingContext context)
        {
            var reader = context.reader;
            var chunk = this;

            {
                StringBuilder builder = new StringBuilder();

                byte b = reader.ReadByte();
                uint idx = 0;
                while (b != 0)
                {
                    builder.Append((char)b);
                    b = reader.ReadByte();
                    idx++;
                }
                chunk.BytesRead += idx + 1;

                this.Name = builder.ToString();
            }

            this.ChunkBaseProcess(context);
        }

        public override string ToString()
        {
            return string.Format("{0}, Name: {1}", this.GetBasicInfo(), Name);
        }
    }
}
