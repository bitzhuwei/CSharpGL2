﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.FileParser._3DSParser.Chunks
{
    public class MappingCoordinatesListChunk : ChunkBase
    {
        public TexCoord[] texCoords;

        internal override void Process(ParsingContext context)
        {
            var reader = context.reader;
            var chunk = this;

            int cnt = reader.ReadUInt16();
            chunk.BytesRead += 2;

            Console.WriteLine("	TexCoords: {0}", cnt);
            var texCoords = new TexCoord[cnt];
            for (int ii = 0; ii < cnt; ii++)
            {
                texCoords[ii] = new TexCoord(reader.ReadSingle(), reader.ReadSingle());
            }

            chunk.BytesRead += (uint)(cnt * (4 * 2));

            this.texCoords = texCoords;
        }

        public override string ToString()
        {
            int length = 0;
            if (texCoords != null)
            { length = texCoords.Length; }
            return string.Format("{0}, {1} texCoords", this.GetBasicInfo(), length);
        }
    }
}
