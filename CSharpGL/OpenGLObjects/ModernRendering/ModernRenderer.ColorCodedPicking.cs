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
            get { return pickingMVP.Value; }
            set { pickingMVP.Value = value; }
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
                //if (lastVertexID + 1 < vertexCount) { throw new Exception(); }
                IntPtr pointer = GL.MapBufferRange(BufferTarget.ArrayBuffer,
                    (int)((lastVertexID - (vertexCount - 1)) * this.positionBufferPtr.DataSize * sizeof(float)),
                    vertexCount * this.positionBufferPtr.DataSize * sizeof(float),
                    MapBufferRangeAccess.MapReadBit);
                pickedGeometry.positions = new vec3[vertexCount];
                if (pointer.ToInt32() != 0)
                {
                    unsafe
                    {
                        vec3* array = (vec3*)pointer.ToPointer();
                        uint i = 0;
                        if (lastVertexID * 3 + 2 == uint.MaxValue)// This is when mode is GL_LINE_LOOP.
                        { i = (uint)(this.positionBufferPtr.Length - 1); }
                        else
                        { i = (uint)(vertexCount - 1); }
                        for (int j = (pickedGeometry.positions.Length - 1); j >= 0; i--, j--)
                        {
                            pickedGeometry.positions[j] = array[i];
                        }
                    }
                }
                else
                {
                    ErrorCode error = (ErrorCode)GL.GetError();
                    Debug.WriteLine("Error:[{0}] MapBufferRange failed: buffer ID: [{1}]", error, this.positionBufferPtr.BufferID);
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
