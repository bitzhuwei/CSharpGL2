using GLM;
using CSharpGL.Objects.SceneElements;
using CSharpGL.Objects.Shaders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGL.UIs;

namespace CSharpGL.Objects.Demos.UIs
{
    public class SimpleUIColorIndicator : RendererBase//, IMVP,IUILayout
    {
        private SimpleUIColorIndicatorBar bar;

        public SimpleUIColorIndicator(IUILayoutParam param, ColorPalette colorPalette, GLColor textColor, float min, float max, float step)
        {
            this.bar = new SimpleUIColorIndicatorBar(param, colorPalette, min, max, step);
        }

        protected override void DoInitialize()
        {
            this.bar.Initialize();

        }

        protected override void DoRender(RenderEventArgs e)
        {
            // 去掉Camera，UI就不会旋转。
            RenderEventArgs barArg = new RenderEventArgs(e.RenderMode, null);
            this.bar.Render(barArg);
        }

        public IUILayoutParam Param { get; set; }

        protected override void DisposeUnmanagedResources()
        {
            this.bar.Dispose();
        }
    }
}
