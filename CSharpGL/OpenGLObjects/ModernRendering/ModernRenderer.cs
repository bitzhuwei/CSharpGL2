using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer : RendererBase
    {
        // 算法
        protected ShaderProgram shaderProgram;

        // 数据结构
        protected VertexArrayObject vertexArrayObject;
        protected PropertyBufferPtr[] propertyBufferPtrs;
        protected IndexBufferPtr indexBufferPtr;
        private List<GLSwitch> switchList = new List<GLSwitch>();

        public IList<GLSwitch> SwitchList
        {
            get { return switchList; }
        }

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

            // init property buffer objects
            var propertyBufferPtrs = new PropertyBufferPtr[propertyNameMap.Count()];
            int index = 0;
            foreach (var item in propertyNameMap)
            {
                PropertyBufferPtr bufferPtr = this.bufferable.GetPropery(
                    item.nameInIBufferable, item.VarNameInShader);
                if (bufferPtr == null) { throw new Exception(); }
                propertyBufferPtrs[index++] = bufferPtr;
            }
            this.propertyBufferPtrs = propertyBufferPtrs;

            // init index buffer object's renderer
            this.indexBufferPtr = this.bufferable.GetIndex();

            this.bufferable = null;
            this.shaderCode = null;
            this.propertyNameMap = null;

            InitializeElementCount();
        }

        protected override void DoRender(RenderEventArgs e)
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

    }
}
