using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer : RendererBase
    {
        private int elementCount;

        private void InitializeElementCount()
        {
            {
                var renderer = this.indexBufferPtr as OneIndexBufferPtr;
                if (renderer != null)
                {
                    this.elementCount = renderer.ElementCount;
                    return;
                }
            }
            {
                var renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
                if (renderer != null)
                {
                    this.elementCount = renderer.VertexCount;
                    return;
                }
            }
        }

        public void DecreaseVertexCount()
        {
            {
                var renderer = this.indexBufferPtr as OneIndexBufferPtr;
                if (renderer != null)
                {
                    if (renderer.ElementCount > 0)
                    {
                        renderer.ElementCount--;
                    }
                    return;
                }
            }
            {
                var renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
                if (renderer != null)
                {
                    if (renderer.VertexCount > 0)
                    {
                        renderer.VertexCount--;
                    }
                    return;
                }
            }
        }

        public void IncreaseVertexCount()
        {
            {
                var renderer = this.indexBufferPtr as OneIndexBufferPtr;
                if (renderer != null)
                {
                    if (renderer.ElementCount < this.elementCount)
                    {
                        renderer.ElementCount++;
                    }
                    return;
                }
            }
            {
                var renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
                if (renderer != null)
                {
                    if (renderer.VertexCount < this.elementCount)
                    {
                        renderer.VertexCount++;
                    }
                    return;
                }
            }
        }

    }
}
