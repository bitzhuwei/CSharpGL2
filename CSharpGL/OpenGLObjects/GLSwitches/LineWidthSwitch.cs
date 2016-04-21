﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public class LineWidthSwitch : GLSwitch
    {
        static float min;
        static float max;

        static LineWidthSwitch()
        {
            float[] lineWidthRange = new float[2];
            GL.GetFloat(GetTarget.LineWidthRange, lineWidthRange);
            min = lineWidthRange[0];
            max = lineWidthRange[1];
            GL.GetFloat(GetTarget.LineWidthGranularity, lineWidthRange);//TODO: what does LineWidthGranularity mean?
        }

        public float MinLineWidth { get; private set; }
        public float MaxLineWidth { get; private set; }

        public float LineWidth { get; set; }

        public LineWidthSwitch() : this(1.0f) { }

        public LineWidthSwitch(float lineWidth)
        {
            this.LineWidth = lineWidth;
            this.MinLineWidth = min;
            this.MaxLineWidth = max;
        }

        float[] original = new float[1];

        public override void On()
        {
            GL.GetFloat(GetTarget.LineWidth, original);

            GL.LineWidth(LineWidth);
        }

        public override void Off()
        {
            GL.LineWidth(original[0]);
        }
    }
}
