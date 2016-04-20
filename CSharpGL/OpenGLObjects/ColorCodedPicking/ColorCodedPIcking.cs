using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public static class ColorCodedPicking
    {
        public static IPickedGeometry Pick(Camera camera, int x, int y, int width, int height, params IColorCodedPicking[] pickableElements)
        {
            if (pickableElements.Length == 0) { return null; }

            // 暂存clear color
            var originalClearColor = new float[4];
            GL.GetFloat(GetTarget.ColorClearValue, originalClearColor);

            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);// 白色意味着没有拾取到任何对象
            GL.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT | GL.GL_STENCIL_BUFFER_BIT);

            SharedStageInfo info = new SharedStageInfo();
            var arg = new RenderEventArgs(RenderModes.ColorCodedPicking, camera);

            foreach (var pickable in pickableElements)
            {
                info.RenderForPicking(pickable, arg);
            }

            GL.Flush();

            IPickedGeometry pickedGeometry = null;
            // get coded color.
            //byte[] codedColor = new byte[4];
            UnmanagedArray<byte> codedColor = new UnmanagedArray<byte>(4);
            GL.ReadPixels(x, height - y - 1, 1, 1, GL.GL_RGBA, GL.GL_UNSIGNED_BYTE, codedColor.Header);
            if (codedColor[0] == byte.MaxValue && codedColor[1] == byte.MaxValue
                && codedColor[2] == byte.MaxValue && codedColor[3] == byte.MaxValue)
            {
                // This is when (x, y) is on background and no primitive is picked.
                pickableElements = null;
            }
            else
            {
                /* // This is how is vertexID coded into color in vertex shader.
                 * 	int objectID = gl_VertexID;
                    codedColor = vec4(
                        float(objectID & 0xFF), 
                        float((objectID >> 8) & 0xFF), 
                        float((objectID >> 16) & 0xFF), 
                        float((objectID >> 24) & 0xFF));
                 */
                // get vertexID from coded color.
                // the vertexID is the last vertex that constructs the primitive.
                // see http://www.cnblogs.com/bitzhuwei/p/modern-opengl-picking-primitive-in-VBO-2.html
                uint shiftedR = (uint)codedColor[0];
                uint shiftedG = (uint)codedColor[1] << 8;
                uint shiftedB = (uint)codedColor[2] << 16;
                uint shiftedA = (uint)codedColor[3] << 24;
                uint stageVertexID = shiftedR + shiftedG + shiftedB + shiftedA;

                // get picked primitive.
                foreach (var item in pickableElements)
                {
                    pickedGeometry = item.Pick(stageVertexID);
                    if (pickedGeometry != null)
                    { break; }
                }
            }

            // 恢复clear color
            GL.ClearColor(originalClearColor[0], originalClearColor[1], originalClearColor[2], originalClearColor[3]);

            return pickedGeometry;
        }
    }
}
