﻿using CSharpGL.Objects.Models;
using FormShaderDesigner1594Demos.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormShaderDesigner1594Demos.RendererFactories
{
    class Polkadot3dFactory : RendererFactory
    {
        public override ShaderDesignerRendererBase GetRenderer(IModel model)
        {
            return new Polkadot3dRenderer(model);
        }
    }
}
