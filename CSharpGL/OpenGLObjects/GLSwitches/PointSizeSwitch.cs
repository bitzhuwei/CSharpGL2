using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public class PointSizeSwitch : GLSwitch
    {

        public float PointSize { get; set; }

        public PointSizeSwitch()
        {
            this.PointSize = 1.0f;
        }

        float[] original = new float[1];

        public override void On()
        {
            GL.GetFloat(GetTarget.PointSize, original);

            GL.PointSize(PointSize);
        }

        public override void Off()
        {
            GL.PointSize(original[0]);
        }
    }
}
