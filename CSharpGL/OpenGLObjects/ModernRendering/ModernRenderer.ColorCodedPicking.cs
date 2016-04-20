using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer : IColorCodedPicking
    {

        mat4 IColorCodedPicking.MVP
        { get { return pickingMVP.Value; } set { pickingMVP.Value = value; } }

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
                if (vertexCount == -1) { vertexCount = this.positionBufferPtr.Length / this.positionBufferPtr.DataSize; }
                GL.BindBuffer(BufferTarget.ArrayBuffer, this.positionBufferPtr.BufferID);
                IntPtr pointer = GL.MapBuffer(BufferTarget.ArrayBuffer, MapBufferAccess.ReadOnly);
                unsafe
                {
                    vec3* array = (vec3*)pointer.ToPointer();
                    var geometryPositions = new vec3[vertexCount];
                    uint i = lastVertexID;
                    for (int j = (geometryPositions.Length - 1); j >= 0; i--, j--)
                    {
                        if (i * 3 + 2 == uint.MaxValue)// This is when mode is GL_LINE_LOOP.
                        { i = (uint)(this.positionBufferPtr.Length / this.positionBufferPtr.DataSize - 1); }
                        geometryPositions[j] = array[i];
                    }
                    pickedGeometry.positions = geometryPositions;
                }
                GL.UnmapBuffer(BufferTarget.ArrayBuffer);
            }

            return pickedGeometry;
        }

        void IRenderable.Render(RenderEventArgs e)
        {
            base.Render(e);
        }


    }
}
