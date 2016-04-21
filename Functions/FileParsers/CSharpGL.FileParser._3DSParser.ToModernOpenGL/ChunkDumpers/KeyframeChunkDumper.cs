﻿using CSharpGL.FileParser._3DSParser.Chunks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.FileParser._3DSParser.ToModernOpenGL.ChunkDumpers
{
    public static partial class ChunkDumper
    {
        public static void Dump(this KeyframeChunk chunk, ThreeDSModel4ModernOpengl model)
        {
            foreach (var item in chunk.Children)
            {
                if(item is MeshInformationBlockChunk)
                {
                    (item as MeshInformationBlockChunk).Dump(model);
                }
                else if(item is SpotLightInformationBlockChunk)
                {
                    (item as SpotLightInformationBlockChunk).Dump(model);
                }
                else if (item is FramesChunk)
                {
                    (item as FramesChunk).Dump(model);
                }
                else if (!(item is UndefinedChunk))
                {
                    throw new NotImplementedException(string.Format(
                        "not dumper implemented for {0}", item.GetType()));
                }
            }
        }
    }
}
