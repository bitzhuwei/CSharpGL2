using GLM;
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
        protected List<UniformVariableBase> uniformVariables = new List<UniformVariableBase>();
        protected OrderedCollection<string> uniformVariableNames = new OrderedCollection<string>(", ");
        private List<GLSwitch> switchList = new List<GLSwitch>();
        private int elementCount;

        /// <summary>
        /// 从模型到buffer的pointer
        /// </summary>
        private IBufferable bufferable;
        private ShaderCode[] shaderCode;
        /// <summary>
        /// vertex shader中的in变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        /// </summary>
        private PropertyNameMap propertyNameMap;
        ///// <summary>
        ///// 各个shader中的uniform变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        ///// </summary>
        //protected UniformNameMap uniformNameMap;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bufferable">一种渲染方式</param>
        /// <param name="shaderCodes">各种类型的shader代码</param>
        /// <param name="propertyNameMap">关联<see cref="BufferPtr"/>和<see cref="ShaderCode"/>中的属性</param>
        /// <param name="uniformNameMap">关联<see cref="BufferPtr"/>和<see cref="ShaderCode"/>中的uniform变量</param>
        ///<param name="switches"></param>
        public ModernRenderer(IBufferable bufferable, ShaderCode[] shaderCodes,
            PropertyNameMap propertyNameMap, //UniformNameMap uniformNameMap,
            params GLSwitch[] switches)
        {
            this.bufferable = bufferable;
            this.shaderCode = shaderCodes;
            this.propertyNameMap = propertyNameMap;
            //this.uniformNameMap = uniformNameMap;
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

            InitializeElementCount();
        }

        private void InitializeElementCount()
        {
            {
                var renderer = this.indexBufferPtr as OneIndexBufferPtr;
                if (renderer != null)
                {
                    this.elementCount = renderer.ElementCount;
                    return;
                }
            }
            {
                var renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
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
                if (item.Updated)
                {
                    item.SetUniform(program);
                }
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
                if (item.Updated)
                {
                    item.ResetUniform(program);
                    item.Updated = false;
                }
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
                var renderer = this.indexBufferPtr as OneIndexBufferPtr;
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
                var renderer = this.indexBufferPtr as ZeroIndexBufferPtr;
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

        public bool GetUniformValue<T>(string varNameInShader, out T value) where T : struct
        {
            int index = this.uniformVariableNames.IndexOf(varNameInShader);
            if (index < 0)
            {
                value = default(T);
                return false;
            }
            else
            {
                UniformVariableBase variable = this.uniformVariables[index];
                value = (T)variable.GetValue();
                return true;
            }
        }

        public bool SetUniformValue(string varNameInShader, ValueType value)
        {
            int index = this.uniformVariableNames.IndexOf(varNameInShader);
            if (index < 0)
            {
                int location = shaderProgram.GetUniformLocation(varNameInShader);
                if (location < 0)
                {
                    throw new Exception(string.Format(
                        "uniform variable [{0}] not exists!", varNameInShader));
                }

                UniformVariableBase variable = GetVariable(value, varNameInShader);
                variable.SetValue(value);
                this.uniformVariableNames.TryInsert(varNameInShader);
                index = this.uniformVariableNames.IndexOf(varNameInShader);
                this.uniformVariables.Insert(index, variable);
                return true;
            }
            else
            {
                UniformVariableBase variable = this.uniformVariables[index];
                bool updated = variable.SetValue(value);
                return updated;
            }
        }

        private UniformVariableBase GetVariable(ValueType value, string varNameInShader)
        {
            Type t = value.GetType();
            Type varType;
            if (variableDict.TryGetValue(t, out varType))
            {
                object variable = Activator.CreateInstance(varType, varNameInShader);
                return variable as UniformVariableBase;
            }
            else
            {
                return null;
            }
        }

        static Dictionary<Type, Type> variableDict = new Dictionary<Type, Type>();
        static ModernRenderer()
        {
            variableDict.Add(typeof(float), typeof(UniformFloat));
            variableDict.Add(typeof(vec2), typeof(UniformVec2));
            variableDict.Add(typeof(vec3), typeof(UniformVec3));
            variableDict.Add(typeof(vec4), typeof(UniformVec4));
            variableDict.Add(typeof(mat2), typeof(UniformMat2));
            variableDict.Add(typeof(mat3), typeof(UniformMat3));
            variableDict.Add(typeof(mat4), typeof(UniformMat4));
            variableDict.Add(typeof(samplerValue), typeof(UniformSampler2D));
        }

        public IList<GLSwitch> SwitchList
        {
            get { return switchList; }
        }

    }
}
