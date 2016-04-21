namespace CSharpShadingLanguage.Compiler
{
    /// <summary>
    /// 文法CSSLCompiler的语法树结点的值
    /// </summary>
    public class TreeNodeValueCSSLCompiler : System.ICloneable
    {
        private string m_NodeName = string.Empty;
        /// <summary>
        /// 结点名称
        /// </summary>
        public string NodeName
        {
            get { return m_NodeName; }
            set { m_NodeName = value; }
        }
        private EnumVTypeCSSLCompiler m_NodeType = EnumVTypeCSSLCompiler.Unknown;
        /// <summary>
        /// 结点类型
        /// </summary>
        public EnumVTypeCSSLCompiler NodeType
        {
            get { return m_NodeType; }
            set { m_NodeType = value; }
        }
        /// <summary>
        /// "名称, 类型"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}, {1}", m_NodeName, m_NodeType);
        }
        public object Clone()
        {
            var result = new TreeNodeValueCSSLCompiler();
            result.NodeName = this.NodeName;
            result.NodeType = this.NodeType;
            return result;
        }
    }

}

