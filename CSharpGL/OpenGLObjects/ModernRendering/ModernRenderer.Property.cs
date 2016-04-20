﻿using GLM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer
    {

        public DrawMode DrawMode
        {
            get
            {
                if (this.indexBufferPtr != null)
                {
                    return this.indexBufferPtr.Mode;
                }
                else
                {
                    return CSharpGL.DrawMode.Points;
                }
            }
            set
            {
                if (this.indexBufferPtr != null)
                {
                    this.indexBufferPtr.Mode = value;
                }
            }
        }
        public List<GLSwitch> SwitchList
        {
            get { return switchList; }
        }

    }
}