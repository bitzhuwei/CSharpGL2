using GLM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer : IColorCodedPicking
    {

        mat4 IColorCodedPicking.MVP
        {
            get { return pickingMVP.GetMat4(); }
            set { pickingMVP.SetMat4(value); }
        }

        uint IColorCodedPicking.PickingBaseID { get; set; }

        uint IColorCodedPicking.GetVertexCount()
        {
            if (this.elementCount < 0) { return 0; }
            else { return (uint)this.elementCount; }
        }

        IPickedGeometry IColorCodedPicking.Pick(uint stageVertexID)
        {
            var element = this as IColorCodedPicking;
            PickedGeometry pickedGeometry = element.TryPick<PickedGeometry>(
                this.indexBufferPtr.Mode.ToPrimitiveMode(), stageVertexID);

            if (pickedGeometry == null) { return null; }

            // Fill primitive's position information.
            uint lastVertexID;
            if (element.GetLastVertexIDOfPickedGeometry(stageVertexID, out lastVertexID))
            {
                int vertexCount = pickedGeometry.GeometryType.GetVertexCount();
                if (vertexCount == -1) { vertexCount = this.positionBufferPtr.Length; }
                GL.BindBuffer(BufferTarget.ArrayBuffer, this.positionBufferPtr.BufferID);
                //IntPtr pointer = GL.MapBuffer(BufferTarget.ArrayBuffer, MapBufferAccess.ReadOnly);
                IntPtr pointer = GL.MapBufferRange(BufferTarget.ArrayBuffer, 0, this.positionBufferPtr.ByteLength, MapBufferAccess.ReadOnly);
                //(int)((lastVertexID - (vertexCount - 1)) * 3), vertexCount * 3, MapBufferAccess.ReadOnly);
                if (pointer.ToInt32() != 0)
                {
                    unsafe
                    {
                        vec3* array = (vec3*)pointer.ToPointer();
                        var geometryPositions = new vec3[vertexCount];
                        //uint i = lastVertexID;
                        uint i = (uint)(vertexCount * 3 - 1);
                        for (int j = (geometryPositions.Length - 1); j >= 0; i--, j--)
                        {
                            if (i * 3 + 2 == uint.MaxValue)// This is when mode is GL_LINE_LOOP.
                            { i = (uint)(this.positionBufferPtr.Length / this.positionBufferPtr.DataSize - 1); }
                            geometryPositions[j] = array[i];
                        }
                        pickedGeometry.positions = geometryPositions;
                    }
                    success++;
                }
                else
                {
                    Debug.WriteLine("MapBufferRange failed: buffer ID: [{0}]", this.positionBufferPtr.BufferID);
                    failure++;
                }
                GL.UnmapBuffer(BufferTarget.ArrayBuffer);
            }

            return pickedGeometry;
        }

        int success = 0;
        int failure = 0;

        void IRenderable.Render(RenderEventArgs e)
        {
            base.Render(e);
        }


    }
}
