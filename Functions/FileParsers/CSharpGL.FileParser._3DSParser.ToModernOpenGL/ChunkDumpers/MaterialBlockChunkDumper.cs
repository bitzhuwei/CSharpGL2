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
        public static void Dump(this MaterialBlockChunk chunk, ThreeDSModel4ModernOpengl model)
        {
            ThreeDSMaterial4ModernOpenGL material = new ThreeDSMaterial4ModernOpenGL();

            foreach (var item in chunk.Children)
            {
                if(item is MaterialNameChunk)
                {
                    (item as MaterialNameChunk).Dump(model, material);
                }
                else if(item is AmbientColorChunk)
                {
                    (item as AmbientColorChunk).Dump(model, material);
                }
                else if (item is DiffuseColorChunk)
                {
                    (item as DiffuseColorChunk).Dump(model, material);
                }
                else if(item is SpecularColorChunk)
                {
                    (item as SpecularColorChunk).Dump(model, material);
                }
                else if(item is MatShininessChunk)
                {
                    (item as MatShininessChunk).Dump(model, material);
                }
                else if(item is TextureMapChunk)
                {
                    (item as TextureMapChunk).Dump(model, material);
                }
                else if(item is BumpMapChunk)
                {
                    (item as BumpMapChunk).Dump(model, material);
                }
                else if(item is ReflectionMapChunk)
                {
                    (item as ReflectionMapChunk).Dump(model, material);
                }
                else if (!(item is UndefinedChunk))
                {
                    throw new NotImplementedException(string.Format(
                        "not dumper implemented for {0}", item.GetType()));
                }
            }

            model.MaterialDict.Add(material.MaterialName, material);
        }
    }
}
