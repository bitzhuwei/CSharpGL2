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
        // Color Coded Picking
        protected VertexArrayObject vertexArrayObject4Picking;
        protected string positionNameInIBufferable;
        protected PropertyBufferPtr positionBufferPtr;
        protected UniformMat4 pickingMVP = new UniformMat4("MVP");
        protected ShaderProgram pickingShaderProgram;

        // normal rendering
        // 算法
        protected ShaderProgram shaderProgram;
        // 数据结构
        protected VertexArrayObject vertexArrayObject;
        protected PropertyBufferPtr[] propertyBufferPtrs;
        protected IndexBufferPtr indexBufferPtr;
        protected List<GLSwitch> switchList = new List<GLSwitch>();
        public IList<GLSwitch> SwitchList
        {
            get { return switchList; }
        }

        /// <summary>
        /// 从模型到buffer的pointer
        /// </summary>
        protected IBufferable bufferable;
        protected ShaderCode[] shaderCode;
        /// <summary>
        /// vertex shader中的in变量与<see cref="propertyBufferPointers"/>中的元素名字的对应关系。
        /// </summary>
        protected PropertyNameMap propertyNameMap;
    }
}
