using CSharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// 试验版的Renderer，使用modern OpenGL
    /// 整合了数据结构（buffers' renderers）和算法（shader program）
    /// </summary>
    public class ModernRenderer : RendererBase
    {
        // 算法
        protected ShaderProgram shaderProgram;

        // 数据结构
        protected VertexArrayObject vertexArrayObject;
        protected BufferPtr[] propertyBufferPointers;
        protected IndexBufferPtrBase indexBufferPointer;
        protected UniformVariableBase[] uniformVariables;
        //protected UniformVariableBase[] uniformSamplers;
        private List<GLSwitch> switchList = new List<GLSwitch>();

        public IList<GLSwitch> SwitchList
        {
            get { return switchList; }
        }

        /// <summary>
        /// 从模型到buffer的pointer
        /// </summary>
        private IUpload2GPU model;
        /// <summary>
        /// shader代码
        /// </summary>
        private CodeShader[] allShaderCodes;
        /// <summary>
        /// vertex shader中的in变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        /// </summary>
        private PropertyNameMap propertyNameMap;
        /// <summary>
        /// 各个shader中的uniform变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        /// </summary>
        protected UniformNameMap uniformNameMap;


        public PolygonModes polygonMode = PolygonModes.Filled;

        private int elementCount;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model">从模型到buffer的renderer</param>
        /// <param name="allShaderCodes">shader代码</param>
        /// <param name="propertyNameMap">vertex shader中的in变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。</param>
        public ModernRenderer(IUpload2GPU model, CodeShader[] allShaderCodes, PropertyNameMap propertyNameMap, UniformNameMap uniformNameMap)
        {
            this.model = model;
            this.allShaderCodes = allShaderCodes;
            this.propertyNameMap = propertyNameMap;
            this.uniformNameMap = uniformNameMap;
        }

        public bool GetUniformValue<T>(string uniformNameInIConvert2BufferRenderer, out T value) where T : struct
        {
            string uniformNameInShader = this.uniformNameMap[uniformNameInIConvert2BufferRenderer];
            foreach (var item in this.uniformVariables)
            {
                if (item.VarName == uniformNameInShader)
                {
                    value = (T)item.GetValue();
                    return true;
                }
            }

            value = default(T);

            return false;
        }
        public bool SetUniformValue(string uniformNameInIConvert2BufferRenderer, ValueType value)
        {
            string uniformNameInShader = this.uniformNameMap[uniformNameInIConvert2BufferRenderer];
            foreach (var item in this.uniformVariables)
            {
                if (item.VarName == uniformNameInShader)
                {
                    item.SetValue(value);
                    return true;
                }
            }

            return false;
        }

        protected override void DoRender(RenderEventArgs e)
        {
            ShaderProgram program = this.shaderProgram;
            // 绑定shader
            program.Bind();

            foreach (var item in this.uniformVariables)
            {
                item.SetUniform(program);
            }

            foreach (var item in switchList)
            {
                item.On();
            }

            int[] originalPolygonMode = new int[1];
            GL.GetInteger(GetTarget.PolygonMode, originalPolygonMode);

            GL.PolygonMode(PolygonModeFaces.FrontAndBack, this.polygonMode);

            GL.Enable(GL.GL_PRIMITIVE_RESTART);
            GL.PrimitiveRestartIndex(uint.MaxValue);

            if (this.vertexArrayObject == null)
            {
                var vertexArrayObject = new VertexArrayObject(this.indexBufferPointer, this.propertyBufferPointers);
                vertexArrayObject.Create(e, program);

                this.vertexArrayObject = vertexArrayObject;
            }
            //else
            {
                this.vertexArrayObject.Render(e, program);
            }

            GL.Disable(GL.GL_PRIMITIVE_RESTART);

            GL.PolygonMode(PolygonModeFaces.FrontAndBack, (PolygonModes)(originalPolygonMode[0]));

            foreach (var item in switchList)
            {
                item.Off();
            }

            foreach (var item in this.uniformVariables)
            {
                item.ResetUniform(program);
            }

            // 解绑shader
            program.Unbind();
        }

        protected override void DoInitialize()
        {
            // init shader program
            ShaderProgram program = new ShaderProgram();
            string vertexShaderCode = null, geometryShaderCode = null, fragmentShaderCode = null;
            FillShaderCodes(this.allShaderCodes, ref vertexShaderCode, ref geometryShaderCode, ref fragmentShaderCode);
            program.Create(vertexShaderCode, fragmentShaderCode, geometryShaderCode, null);
            this.shaderProgram = program;

            // init property buffer objects' renderer
            var propertyBufferRenderers = new BufferPtr[propertyNameMap.Count()];
            int index = 0;
            foreach (var item in propertyNameMap)
            {
                BufferPtr bufferRenderer = this.model.GetBufferRenderer(
                item.NameInIConvert2BufferRenderer, item.VarNameInShader);
                if (bufferRenderer == null) { throw new Exception(); }
                propertyBufferRenderers[index++] = bufferRenderer;
            }
            this.propertyBufferPointers = propertyBufferRenderers;

            // init index buffer object's renderer
            this.indexBufferPointer = this.model.GetIndexBufferRenderer();

            this.model = null;
            this.allShaderCodes = null;
            this.propertyNameMap = null;
            //this.uniformNameMap = null;

            {
                IndexBufferPtr renderer = this.indexBufferPointer as IndexBufferPtr;
                if (renderer != null)
                {
                    this.elementCount = renderer.ElementCount;
                }
            }
            {
                ZeroIndexBufferPointer renderer = this.indexBufferPointer as ZeroIndexBufferPointer;
                if (renderer != null)
                {
                    this.elementCount = renderer.VertexCount;
                }
            }

        }


        private void FillShaderCodes(CodeShader[] allShaderCodes, ref string vertexShaderCode, ref string geometryShaderCode, ref string fragmentShaderCode)
        {
            bool vertexShaderFilled = false, geometryShaderFilled = false, fragmentShaderFilled = false;
            foreach (var item in allShaderCodes)
            {
                switch (item.ShaderType)
                {
                    case CodeShader.GLSLShaderType.VertexShader:
                        if (vertexShaderFilled)
                        { throw new Exception(string.Format("There should be only 1 vertex shader.")); }
                        vertexShaderCode = item.SourceCode;
                        vertexShaderFilled = true;
                        break;
                    case CodeShader.GLSLShaderType.GeometryShader:
                        if (geometryShaderFilled)
                        { throw new Exception(string.Format("There should be only 1 geometry shader.")); }
                        geometryShaderCode = item.SourceCode;
                        geometryShaderFilled = true;
                        break;
                    case CodeShader.GLSLShaderType.FragmentShader:
                        if (fragmentShaderFilled)
                        { throw new Exception(string.Format("There should be only 1 fragment shader.")); }
                        fragmentShaderCode = item.SourceCode;
                        fragmentShaderFilled = true;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
            if (!vertexShaderFilled)
            { throw new Exception("No vertex shader specified!"); }
            if (!geometryShaderFilled)
            { geometryShaderCode = null; }
            if (!fragmentShaderFilled)
            { throw new Exception("No fragment shader specified!"); }
        }

        protected override void DisposeUnmanagedResources()
        {
            if (this.vertexArrayObject != null)
            {
                this.vertexArrayObject.Dispose();
            }
        }

        public void DecreaseVertexCount()
        {
            {
                IndexBufferPtr renderer = this.indexBufferPointer as IndexBufferPtr;
                if (renderer != null)
                {
                    if (renderer.ElementCount > 0)
                    {
                        renderer.ElementCount--;
                    }
                    return;
                }
            }
            {
                ZeroIndexBufferPointer renderer = this.indexBufferPointer as ZeroIndexBufferPointer;
                if (renderer != null)
                {
                    if (renderer.VertexCount > 0)
                    {
                        renderer.VertexCount--;
                    }
                    return;
                }
            }
        }

        public void IncreaseVertexCount()
        {
            {
                IndexBufferPtr renderer = this.indexBufferPointer as IndexBufferPtr;
                if (renderer != null)
                {
                    if (renderer.ElementCount < this.elementCount)
                    {
                        renderer.ElementCount++;
                    }
                    return;
                }
            }
            {
                ZeroIndexBufferPointer renderer = this.indexBufferPointer as ZeroIndexBufferPointer;
                if (renderer != null)
                {
                    if (renderer.VertexCount < this.elementCount)
                    {
                        renderer.VertexCount++;
                    }
                    return;
                }
            }
        }
    }
}
