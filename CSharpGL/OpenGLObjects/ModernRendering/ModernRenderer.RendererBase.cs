﻿using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer : RendererBase
    {

        protected override void DoRender(RenderEventArgs e)
        {
            if (e.RenderMode == RenderModes.ColorCodedPicking)
            {
                ColorCodedPickingRender(e);
            }
            else if (e.RenderMode == RenderModes.Render)
            {
                RenderRender(e);
            }

        }

        protected override void DoInitialize()
        {
            // init shader program
            ShaderProgram program = new ShaderProgram();
            var shaders = (from item in shaderCode select item.CreateShader()).ToArray();
            program.Create(shaders);
            this.shaderProgram = program;
            foreach (var item in shaders) { item.Delete(); }

            // init property buffer objects
            var propertyBufferPtrs = new PropertyBufferPtr[propertyNameMap.Count()];
            int index = 0;
            foreach (var item in propertyNameMap)
            {
                PropertyBufferPtr bufferPtr = this.bufferable.GetPropery(
                    item.nameInIBufferable, item.VarNameInShader);
                if (bufferPtr == null) { throw new Exception(); }
                propertyBufferPtrs[index++] = bufferPtr;

                if (item.nameInIBufferable == positionNameInIBufferable)
                {
                    this.positionBufferPtr = new PropertyBufferPtr(
                        "in_Position",// in_Postion same with in the PickingShader.vert shader
                        bufferPtr.BufferID,
                        bufferPtr.DataSize,
                        bufferPtr.DataType,
                        bufferPtr.Length);
                }
            }
            this.propertyBufferPtrs = propertyBufferPtrs;

            // init index buffer object's renderer
            this.indexBufferPtr = this.bufferable.GetIndex();

            this.bufferable = null;
            this.shaderCode = null;
            this.propertyNameMap = null;

            InitializeElementCount();
        }

    }
}
