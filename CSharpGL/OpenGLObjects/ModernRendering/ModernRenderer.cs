using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public class ModernRenderer : RendererBase
    {
        // 算法
        protected ShaderProgram shaderProgram;

        // 数据结构
        protected VertexArrayObject vertexArrayObject;
        protected PropertyBufferPtr[] propertyBufferPtrs;
        protected IndexBufferPtr indexBufferPtr;
        protected UniformVariableBase[] uniformVariables;
        private List<GLSwitch> switchList = new List<GLSwitch>();
        public int elementCount;

        /// <summary>
        /// 从模型到buffer的pointer
        /// </summary>
        private IBufferable bufferable;
        private ShaderCode[] shaderCode;
        /// <summary>
        /// vertex shader中的in变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        /// </summary>
        private PropertyNameMap propertyNameMap;
        /// <summary>
        /// 各个shader中的uniform变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        /// </summary>
        protected UniformNameMap uniformNameMap;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bufferable">一种渲染方式</param>
        /// <param name="shaderCodes">各种类型的shader代码</param>
        /// <param name="propertyNameMap">关联<see cref="BufferPtr"/>和<see cref="ShaderCode"/>中的属性</param>
        /// <param name="uniformNameMap">关联<see cref="BufferPtr"/>和<see cref="ShaderCode"/>中的uniform变量</param>
        ///<param name="switches"></param>
        public ModernRenderer(IBufferable bufferable, ShaderCode[] shaderCodes,
            PropertyNameMap propertyNameMap, UniformNameMap uniformNameMap,
            params GLSwitch[] switches)
        {
            this.bufferable = bufferable;
            this.shaderCode = shaderCodes;
            this.propertyNameMap = propertyNameMap;
            this.uniformNameMap = uniformNameMap;
            this.switchList.AddRange(switches);
        }

        protected override void DoInitialize()
        {
            // init shader program
            ShaderProgram program = new ShaderProgram();
            var shaders = (from item in shaderCode select item.CreateShader()).ToArray();
            program.Create(shaders);
            this.shaderProgram = program;
            foreach (var item in shaders) { item.Delete(); }

            // init property buffer objects' renderer
            var propertyBufferPtrs = new PropertyBufferPtr[propertyNameMap.Count()];
            int index = 0;
            foreach (var item in propertyNameMap)
            {
                PropertyBufferPtr bufferRenderer = this.bufferable.GetPropery(
                    item.nameInIBufferable, item.VarNameInShader);
                if (bufferRenderer == null) { throw new Exception(); }
                propertyBufferPtrs[index++] = bufferRenderer;
            }
            this.propertyBufferPtrs = propertyBufferPtrs;

            // init index buffer object's renderer
            this.indexBufferPtr = this.bufferable.GetIndex();

            this.bufferable = null;
            this.shaderCode = null;
            this.propertyNameMap = null;
            this.uniformNameMap = null;

            InitializeElementCount();
        }

        private void InitializeElementCount()
        {
            {
                OneIndexBufferPtr renderer = this.indexBufferPtr as OneIndexBufferPtr;
                if (renderer != null)
                {
                    this.elementCount = renderer.ElementCount;
                    return;
                }
            }
            {
                ZeroIndexBufferPtr renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
                if (renderer != null)
                {
                    this.elementCount = renderer.VertexCount;
                    return;
                }
            }
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

        protected override void DisposeUnmanagedResources()
        {
            if (this.vertexArrayObject != null)
            {
                this.vertexArrayObject.Dispose();
                this.vertexArrayObject = null;
            }
            if (this.propertyBufferPtrs != null)
            {
                foreach (var item in this.propertyBufferPtrs) { item.Dispose(); }
                this.propertyBufferPtrs = null;
            }
            if (this.indexBufferPtr != null)
            {
                this.indexBufferPtr.Dispose();
                this.indexBufferPtr = null;
            }
            if (this.shaderProgram != null)
            {
                this.shaderProgram.Delete();
                this.shaderProgram = null;
            }
        }

        public void DecreaseVertexCount()
        {
            {
                OneIndexBufferPtr renderer = this.indexBufferPtr as OneIndexBufferPtr;
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
                ZeroIndexBufferPtr renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
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
                var renderer = this.indexBufferPtr as OneIndexBufferPtr;
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
                var renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
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

        public bool GetUniformValue<T>(string uniformNameInIBufferable, out T value) where T : struct
        {
            string uniformNameInShader = this.uniformNameMap[uniformNameInIBufferable];
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

        public IList<GLSwitch> SwitchList
        {
            get { return switchList; }
        }

    }
}
