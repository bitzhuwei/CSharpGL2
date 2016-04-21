﻿using GLM;
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
                if (lastVertexID == 0 && vertexCount == 2)
                {
                    // This is when mode is GL_LINE_LOOP and picked last line(the loop back one)
                    PickingLastLineInLineLoop(pickedGeometry);
                }
                else
                {
                    // Other conditions
                    ContinuousBufferRange(lastVertexID, vertexCount, pickedGeometry);
                }
            }

            return pickedGeometry;
        }
        private void PickingLastLineInLineLoop(PickedGeometry pickedGeometry)
        {
            //const int lastVertexID = 0;
            const int vertexCount = 2;
            var offsets = new int[vertexCount] { (this.positionBufferPtr.Length - 1) * this.positionBufferPtr.DataSize * sizeof(float), 0, };
            pickedGeometry.Positions = new vec3[vertexCount];
            pickedGeometry.Indexes = new uint[vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                GL.BindBuffer(BufferTarget.ArrayBuffer, this.positionBufferPtr.BufferID);
                //IntPtr pointer = GL.MapBuffer(BufferTarget.ArrayBuffer, MapBufferAccess.ReadOnly);
                IntPtr pointer = GL.MapBufferRange(BufferTarget.ArrayBuffer,
                    offsets[i],
                    1 * this.positionBufferPtr.DataSize * sizeof(float),
                    MapBufferRangeAccess.MapReadBit);
                if (pointer.ToInt32() != 0)
                {
                    unsafe
                    {
                        vec3* array = (vec3*)pointer.ToPointer();
                        pickedGeometry.Positions[i] = array[0];
                    }
                }
                else
                {
                    ErrorCode error = (ErrorCode)GL.GetError();
                    Debug.WriteLine("Error:[{0}] MapBufferRange failed: buffer ID: [{1}]", error, this.positionBufferPtr.BufferID);
                }
                GL.UnmapBuffer(BufferTarget.ArrayBuffer);
                pickedGeometry.Indexes[i] = (uint)offsets[i] / (uint)(this.positionBufferPtr.DataSize * sizeof(float));
            }
        }

        private void ContinuousBufferRange(uint lastVertexID, int vertexCount, PickedGeometry pickedGeometry)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.positionBufferPtr.BufferID);
            //IntPtr pointer = GL.MapBuffer(BufferTarget.ArrayBuffer, MapBufferAccess.ReadOnly);
            int offset = (int)((lastVertexID - (vertexCount - 1)) * this.positionBufferPtr.DataSize * sizeof(float));
            IntPtr pointer = GL.MapBufferRange(BufferTarget.ArrayBuffer,
                offset,
                vertexCount * this.positionBufferPtr.DataSize * sizeof(float),
                MapBufferRangeAccess.MapReadBit);
            pickedGeometry.Positions = new vec3[vertexCount];
            pickedGeometry.Indexes = new uint[vertexCount];
            if (pointer.ToInt32() != 0)
            {
                unsafe
                {
                    vec3* array = (vec3*)pointer.ToPointer();
                    for (uint i = 0; i < vertexCount; i++)
                    {
                        pickedGeometry.Positions[i] = array[i];
                        pickedGeometry.Indexes[i] = lastVertexID - ((uint)vertexCount - 1) + i;
                    }
                    //for (int j = (positions.Length - 1), i = vertexCount - 1; j >= 0; i--, j--)
                    //{
                    //    positions[j] = array[i];
                    //}
                }
            }
            else
            {
                ErrorCode error = (ErrorCode)GL.GetError();
                Debug.WriteLine("Error:[{0}] MapBufferRange failed: buffer ID: [{1}]", error, this.positionBufferPtr.BufferID);
            }
            GL.UnmapBuffer(BufferTarget.ArrayBuffer);
        }

        void IRenderable.Render(RenderEventArgs e)
        {
            base.Render(e);
        }


    }
}
