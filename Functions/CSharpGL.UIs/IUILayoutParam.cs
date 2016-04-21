﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.UIs
{
    public struct IUILayoutParam
    {

        /// <summary>
        /// the edges of the <see cref="GLCanvas"/> to which a UI’s rect is bound and determines how it is resized with its parent.
        /// <para>something like AnchorStyles.Left | AnchorStyles.Bottom.</para>
        /// </summary>
        public System.Windows.Forms.AnchorStyles Anchor;

        /// <summary>
        /// Gets or sets the space between viewport and SimpleRect.
        /// </summary>
        public System.Windows.Forms.Padding Margin;

        /// <summary>
        /// Stores width when <see cref="OpenGLUIRect.Anchor"/>.Left &amp; <see cref="OpenGLUIRect.Anchor"/>.Right is <see cref="OpenGLUIRect.Anchor"/>.None.
        /// <para> and height when <see cref="OpenGLUIRect.Anchor"/>.Top &amp; <see cref="OpenGLUIRect.Anchor"/>.Bottom is <see cref="OpenGLUIRect.Anchor"/>.None.</para>
        /// </summary>
        public System.Drawing.Size Size;

        public int zNear;

        public int zFar;

        public IUILayoutParam(AnchorStyles anchorStyle, Padding padding, System.Drawing.Size size,
            int zNear = -1000, int zFar = 1000)
        {
            // TODO: Complete member initialization
            this.Anchor = anchorStyle;
            this.Margin = padding;
            this.Size = size;
            this.zNear = zNear;
            this.zFar = zFar;
        }

    }
}
