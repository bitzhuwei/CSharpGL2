﻿using CSharpGL.FileParser._3DSParser.Chunks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.FileParser._3DSParser.ToLegacyOpenGL.ChunkDumpers
{
    public static partial class ChunkDumper
    {
        public static void Dump(this ReflectionMapChunk chunk, ThreeDSModel4LegacyOpenGL model, ThreeDSMaterial4LegacyOpenGL material)
        {
            foreach (var item in chunk.Children)
            {
                if(item is MappingFilenameChunk)
                {
                    string filename = string.Empty;
                    (item as MappingFilenameChunk).Dump(out filename);
                    material.ReflectionFilename = filename;
                }
                else if(item is MappingParametersChunk)
                {
                    (item as MappingParametersChunk).Dump(model, material);
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
