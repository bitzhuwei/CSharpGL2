﻿using GLM;
using CSharpGL.Objects;
using CSharpGL.Objects.Common;
using CSharpGL.Objects.Shaders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpGL.GlyphTextures;
using CSharpGL.Objects.SceneElements;

namespace CSharpGL.UIs
{
    /// <summary>
    /// 用shader+VAO+组装的texture显示一个指定的字符串
    /// <para>代表一个三维空间内的内容不可变的字符串</para>
    /// </summary>
    public class SimpleUIPointSpriteStringElement : RendererBase, IUILayout
    {
        PointSpriteStringElement element;

        public SimpleUIPointSpriteStringElement(IUILayoutParam param,
            string content, vec3 position, 
            GLColor color = null, int fontSize = 32, int maxRowWidth = 256, FontResource fontResource = null)
        {
            IUILayout layout = this;
            layout.Param = param;
            this.element = new PointSpriteStringElement(content, position, color, fontSize, maxRowWidth, fontResource);
        }
        protected override void DoInitialize()
        {
            this.element.Initialize();
        }

        protected override void DoRender(RenderEventArgs e)
        {
            mat4 projectionMatrix, viewMatrix, modelMatrix;
            {
                IUILayout element = this as IUILayout;
                element.GetMatrix(out projectionMatrix, out viewMatrix, out modelMatrix, e.Camera);
            }

            this.element.mvp = projectionMatrix * viewMatrix * modelMatrix;

            this.element.Render(e);
        }

        IUILayoutParam IUILayout.Param { get; set; }

        protected override void DisposeUnmanagedResources()
        {
            this.element.Dispose();
        }
    }
}
