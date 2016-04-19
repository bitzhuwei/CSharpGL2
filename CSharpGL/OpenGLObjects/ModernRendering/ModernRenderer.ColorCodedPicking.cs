using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer : RendererBase, IColorCodedPicking
    {
        protected VertexArrayObject vertexArrayObject4Picking;
        protected PropertyBufferPtr positionBufferPtr;

        UniformMat4 pickingMVP = new UniformMat4("MVP");

        ShaderProgram pickingShaderProgram;

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
                PrimitiveModes.TriangleStrip, stageVertexID);

            if (pickedGeometry == null) { return null; }

            // Fill primitive's positions and colors. This maybe changes much more than lines above in second dev.
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

        protected override void DoRender(RenderEventArgs e)
        {
            if (e.RenderMode == RenderModes.ColorCodedPicking)
            {
                ColorCodedPickingRender(e);
            }
            else if (e.RenderMode == RenderModes.Render)
            {
                RenderRender(e);
            }

        }

        private void RenderRender(RenderEventArgs e)
        {
            ShaderProgram program = this.shaderProgram;

            // 绑定shader
            program.Bind();

            var updatedUniforms = (from item in this.uniformVariables where item.Updated select item).ToArray();
            foreach (var item in updatedUniforms) { item.SetUniform(program); }

            foreach (var item in switchList) { item.On(); }

            if (this.vertexArrayObject == null)
            {
                var vertexArrayObject = new VertexArrayObject(
                    this.indexBufferPtr, this.propertyBufferPtrs);
                vertexArrayObject.Create(e, program);

                this.vertexArrayObject = vertexArrayObject;
            }
            //else
            {
                this.vertexArrayObject.Render(e, program);
            }

            foreach (var item in switchList) { item.Off(); }

            foreach (var item in updatedUniforms) { item.ResetUniform(program); item.Updated = false; }

            // 解绑shader
            program.Unbind();
        }

        private void ColorCodedPickingRender(RenderEventArgs e)
        {
            if (this.pickingShaderProgram == null)
            { this.pickingShaderProgram = PickingShaderHelper.GetPickingShaderProgram(); }

            ShaderProgram program = this.pickingShaderProgram;

            // 绑定shader
            program.Bind();
            var picking = this as IColorCodedPicking;
            // TODO: use uint/int/float or ? use UniformUInt instead
            program.SetUniform("pickingBaseID", picking.PickingBaseID);
            pickingMVP.SetUniform(program);

            //foreach (var item in switchList) { item.On(); }

            if (this.vertexArrayObject4Picking == null)
            {
                var vertexArrayObject4Picking = new VertexArrayObject(
                    this.indexBufferPtr, this.positionBufferPtr);
                vertexArrayObject4Picking.Create(e, program);

                this.vertexArrayObject4Picking = vertexArrayObject4Picking;
            }
            //else
            {
                this.vertexArrayObject4Picking.Render(e, program);
            }

            //foreach (var item in switchList) { item.Off(); }

            // 解绑shader
            program.Unbind();
        }

    }
}
