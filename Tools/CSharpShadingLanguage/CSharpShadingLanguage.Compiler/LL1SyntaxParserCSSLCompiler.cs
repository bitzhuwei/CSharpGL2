using System;
using bitzhuwei.CompilerBase;

namespace CSharpShadingLanguage.Compiler
{
    /// <summary>
    /// CSSLCompiler的LL1语法分析器
    /// </summary>
    public partial class LL1SyntaxParserCSSLCompiler : LL1SyntaxParserBase<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
    {
        #region 分析表中的元素
        
        /// <summary>
        /// 对 &lt;Expression&gt; ::= &quot;~&quot;... 进行分析
        /// <para>&lt;Expression&gt; ::= &quot;~&quot; &quot;!&quot; &quot;@&quot; &quot;#&quot; &quot;%&quot; &quot;^&quot; &quot;&amp;&quot; &quot;*&quot; &quot;(&quot; &quot;)&quot; &quot;-&quot; &quot;+&quot; &quot;=&quot; &quot;{&quot; &quot;}&quot; &quot;[&quot; &quot;]&quot; &quot;:&quot; &quot;;&quot; &quot;&lt;&quot; &quot;&gt;&quot; &quot;,&quot; &quot;.&quot; &quot;?&quot; &quot;/&quot; &quot;~=&quot; &quot;!=&quot; &quot;%=&quot; &quot;^=&quot; &quot;&amp;=&quot; &quot;*=&quot; &quot;-=&quot; &quot;+=&quot; &quot;&lt;=&quot; &quot;&gt;=&quot; &quot;/=&quot; &quot;&amp;&amp;&quot; &quot;++&quot; &quot;&lt;&lt;&quot; &quot;&gt;&gt;&quot; constString identifier number;</para>
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsecase_Expression___tail_reverse_Leave;
        
        /// <summary>
        /// 对 叶结点&quot;~&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_reverse_Leave_;
        /// <summary>
        /// 对 叶结点&quot;!&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_not_Leave_;
        /// <summary>
        /// 对 叶结点&quot;@&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_atLeave_;
        /// <summary>
        /// 对 叶结点&quot;#&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_pound_Leave_;
        /// <summary>
        /// 对 叶结点&quot;%&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_percent_Leave_;
        /// <summary>
        /// 对 叶结点&quot;^&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_xor_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&amp;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_and_Leave_;
        /// <summary>
        /// 对 叶结点&quot;*&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_multiply_Leave_;
        /// <summary>
        /// 对 叶结点&quot;(&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_leftParentheses_Leave_;
        /// <summary>
        /// 对 叶结点&quot;)&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_rightParentheses_Leave_;
        /// <summary>
        /// 对 叶结点&quot;-&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_minus_Leave_;
        /// <summary>
        /// 对 叶结点&quot;+&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_plus_Leave_;
        /// <summary>
        /// 对 叶结点&quot;=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;{&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_leftBrace_Leave_;
        /// <summary>
        /// 对 叶结点&quot;}&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_rightBrace_Leave_;
        /// <summary>
        /// 对 叶结点&quot;[&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_leftBracket_Leave_;
        /// <summary>
        /// 对 叶结点&quot;]&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_rightBracket_Leave_;
        /// <summary>
        /// 对 叶结点&quot;:&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_colon_Leave_;
        /// <summary>
        /// 对 叶结点&quot;;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_semicolon_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&lt;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_lessThan_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&gt;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_greaterThan_Leave_;
        /// <summary>
        /// 对 叶结点&quot;,&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_comma_Leave_;
        /// <summary>
        /// 对 叶结点&quot;.&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_dot_Leave_;
        /// <summary>
        /// 对 叶结点&quot;?&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_question_Leave_;
        /// <summary>
        /// 对 叶结点&quot;/&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_divide_Leave_;
        /// <summary>
        /// 对 叶结点&quot;~=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_reverse_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;!=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_not_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;%=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_percent_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;^=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_xor_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&amp;=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_and_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;*=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_multiply_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;-=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_minus_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;+=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_plus_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&lt;=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_lessThan_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&gt;=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_greaterThan_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;/=&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_divide_Equality_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&amp;&amp;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_and_And_Leave_;
        /// <summary>
        /// 对 叶结点&quot;++&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_plus_Plus_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&lt;&lt;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_lessThan_LessThan_Leave_;
        /// <summary>
        /// 对 叶结点&quot;&gt;&gt;&quot; 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_greaterThan_GreaterThan_Leave_;
        /// <summary>
        /// 对 叶结点constString 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParseconstStringLeave_;
        /// <summary>
        /// 对 叶结点identifier 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParseidentifierLeave_;
        /// <summary>
        /// 对 叶结点number 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsenumberLeave_;
        /// <summary>
        /// 对 叶结点# 进行分析
        /// </summary>
        private static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            FuncParsetail_startEndLeave_;
        
        #endregion 分析表中的元素
        #region 用于分析栈操作的字段-终结点
        
        private static readonly EnumVTypeCSSLCompiler m_tail_reverse_Leave = EnumVTypeCSSLCompiler.tail_reverse_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_not_Leave = EnumVTypeCSSLCompiler.tail_not_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_atLeave = EnumVTypeCSSLCompiler.tail_atLeave;
        private static readonly EnumVTypeCSSLCompiler m_tail_pound_Leave = EnumVTypeCSSLCompiler.tail_pound_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_percent_Leave = EnumVTypeCSSLCompiler.tail_percent_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_xor_Leave = EnumVTypeCSSLCompiler.tail_xor_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_and_Leave = EnumVTypeCSSLCompiler.tail_and_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_multiply_Leave = EnumVTypeCSSLCompiler.tail_multiply_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_leftParentheses_Leave = EnumVTypeCSSLCompiler.tail_leftParentheses_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_rightParentheses_Leave = EnumVTypeCSSLCompiler.tail_rightParentheses_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_minus_Leave = EnumVTypeCSSLCompiler.tail_minus_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_plus_Leave = EnumVTypeCSSLCompiler.tail_plus_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_equality_Leave = EnumVTypeCSSLCompiler.tail_equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_leftBrace_Leave = EnumVTypeCSSLCompiler.tail_leftBrace_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_rightBrace_Leave = EnumVTypeCSSLCompiler.tail_rightBrace_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_leftBracket_Leave = EnumVTypeCSSLCompiler.tail_leftBracket_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_rightBracket_Leave = EnumVTypeCSSLCompiler.tail_rightBracket_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_colon_Leave = EnumVTypeCSSLCompiler.tail_colon_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_semicolon_Leave = EnumVTypeCSSLCompiler.tail_semicolon_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_lessThan_Leave = EnumVTypeCSSLCompiler.tail_lessThan_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_greaterThan_Leave = EnumVTypeCSSLCompiler.tail_greaterThan_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_comma_Leave = EnumVTypeCSSLCompiler.tail_comma_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_dot_Leave = EnumVTypeCSSLCompiler.tail_dot_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_question_Leave = EnumVTypeCSSLCompiler.tail_question_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_divide_Leave = EnumVTypeCSSLCompiler.tail_divide_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_reverse_Equality_Leave = EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_not_Equality_Leave = EnumVTypeCSSLCompiler.tail_not_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_percent_Equality_Leave = EnumVTypeCSSLCompiler.tail_percent_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_xor_Equality_Leave = EnumVTypeCSSLCompiler.tail_xor_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_and_Equality_Leave = EnumVTypeCSSLCompiler.tail_and_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_multiply_Equality_Leave = EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_minus_Equality_Leave = EnumVTypeCSSLCompiler.tail_minus_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_plus_Equality_Leave = EnumVTypeCSSLCompiler.tail_plus_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_lessThan_Equality_Leave = EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_greaterThan_Equality_Leave = EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_divide_Equality_Leave = EnumVTypeCSSLCompiler.tail_divide_Equality_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_and_And_Leave = EnumVTypeCSSLCompiler.tail_and_And_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_plus_Plus_Leave = EnumVTypeCSSLCompiler.tail_plus_Plus_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_lessThan_LessThan_Leave = EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave;
        private static readonly EnumVTypeCSSLCompiler m_tail_greaterThan_GreaterThan_Leave = EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave;
        private static readonly EnumVTypeCSSLCompiler m_constStringLeave = EnumVTypeCSSLCompiler.constStringLeave;
        private static readonly EnumVTypeCSSLCompiler m_identifierLeave = EnumVTypeCSSLCompiler.identifierLeave;
        private static readonly EnumVTypeCSSLCompiler m_numberLeave = EnumVTypeCSSLCompiler.numberLeave;
        private static readonly EnumVTypeCSSLCompiler m_tail_startEndLeave = EnumVTypeCSSLCompiler.tail_startEndLeave;
        
        #endregion 用于分析栈操作的字段-终结点
        #region 用于分析栈操作的字段-非终结点
        
        private static readonly EnumVTypeCSSLCompiler m_case_Expression = EnumVTypeCSSLCompiler.case_Expression;
        
        #endregion 用于分析栈操作的字段-非终结点
        #region 获取分析表中的元素
        
        /// <summary>
        /// 对 &lt;Expression&gt; ::= &quot;~&quot;... 进行分析
        /// <para>&lt;Expression&gt; ::= &quot;~&quot; &quot;!&quot; &quot;@&quot; &quot;#&quot; &quot;%&quot; &quot;^&quot; &quot;&amp;&quot; &quot;*&quot; &quot;(&quot; &quot;)&quot; &quot;-&quot; &quot;+&quot; &quot;=&quot; &quot;{&quot; &quot;}&quot; &quot;[&quot; &quot;]&quot; &quot;:&quot; &quot;;&quot; &quot;&lt;&quot; &quot;&gt;&quot; &quot;,&quot; &quot;.&quot; &quot;?&quot; &quot;/&quot; &quot;~=&quot; &quot;!=&quot; &quot;%=&quot; &quot;^=&quot; &quot;&amp;=&quot; &quot;*=&quot; &quot;-=&quot; &quot;+=&quot; &quot;&lt;=&quot; &quot;&gt;=&quot; &quot;/=&quot; &quot;&amp;&amp;&quot; &quot;++&quot; &quot;&lt;&lt;&quot; &quot;&gt;&gt;&quot; constString identifier number;</para>
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsecase_Expression___tail_reverse_Leave()
        {
            return FuncParsecase_Expression___tail_reverse_Leave;
        }
        
        /// <summary>
        /// 对 叶结点&quot;~&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_reverse_Leave_()
        {
            return FuncParsetail_reverse_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;!&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_not_Leave_()
        {
            return FuncParsetail_not_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;@&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_atLeave_()
        {
            return FuncParsetail_atLeave_;
        }
        /// <summary>
        /// 对 叶结点&quot;#&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_pound_Leave_()
        {
            return FuncParsetail_pound_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;%&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_percent_Leave_()
        {
            return FuncParsetail_percent_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;^&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_xor_Leave_()
        {
            return FuncParsetail_xor_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&amp;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_and_Leave_()
        {
            return FuncParsetail_and_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;*&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_multiply_Leave_()
        {
            return FuncParsetail_multiply_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;(&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_leftParentheses_Leave_()
        {
            return FuncParsetail_leftParentheses_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;)&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_rightParentheses_Leave_()
        {
            return FuncParsetail_rightParentheses_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;-&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_minus_Leave_()
        {
            return FuncParsetail_minus_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;+&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_plus_Leave_()
        {
            return FuncParsetail_plus_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_equality_Leave_()
        {
            return FuncParsetail_equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;{&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_leftBrace_Leave_()
        {
            return FuncParsetail_leftBrace_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;}&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_rightBrace_Leave_()
        {
            return FuncParsetail_rightBrace_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;[&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_leftBracket_Leave_()
        {
            return FuncParsetail_leftBracket_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;]&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_rightBracket_Leave_()
        {
            return FuncParsetail_rightBracket_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;:&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_colon_Leave_()
        {
            return FuncParsetail_colon_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_semicolon_Leave_()
        {
            return FuncParsetail_semicolon_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&lt;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_lessThan_Leave_()
        {
            return FuncParsetail_lessThan_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&gt;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_greaterThan_Leave_()
        {
            return FuncParsetail_greaterThan_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;,&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_comma_Leave_()
        {
            return FuncParsetail_comma_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;.&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_dot_Leave_()
        {
            return FuncParsetail_dot_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;?&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_question_Leave_()
        {
            return FuncParsetail_question_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;/&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_divide_Leave_()
        {
            return FuncParsetail_divide_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;~=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_reverse_Equality_Leave_()
        {
            return FuncParsetail_reverse_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;!=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_not_Equality_Leave_()
        {
            return FuncParsetail_not_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;%=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_percent_Equality_Leave_()
        {
            return FuncParsetail_percent_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;^=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_xor_Equality_Leave_()
        {
            return FuncParsetail_xor_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&amp;=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_and_Equality_Leave_()
        {
            return FuncParsetail_and_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;*=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_multiply_Equality_Leave_()
        {
            return FuncParsetail_multiply_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;-=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_minus_Equality_Leave_()
        {
            return FuncParsetail_minus_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;+=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_plus_Equality_Leave_()
        {
            return FuncParsetail_plus_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&lt;=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_lessThan_Equality_Leave_()
        {
            return FuncParsetail_lessThan_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&gt;=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_greaterThan_Equality_Leave_()
        {
            return FuncParsetail_greaterThan_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;/=&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_divide_Equality_Leave_()
        {
            return FuncParsetail_divide_Equality_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&amp;&amp;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_and_And_Leave_()
        {
            return FuncParsetail_and_And_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;++&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_plus_Plus_Leave_()
        {
            return FuncParsetail_plus_Plus_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&lt;&lt;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_lessThan_LessThan_Leave_()
        {
            return FuncParsetail_lessThan_LessThan_Leave_;
        }
        /// <summary>
        /// 对 叶结点&quot;&gt;&gt;&quot; 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_greaterThan_GreaterThan_Leave_()
        {
            return FuncParsetail_greaterThan_GreaterThan_Leave_;
        }
        /// <summary>
        /// 对 叶结点constString 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParseconstStringLeave_()
        {
            return FuncParseconstStringLeave_;
        }
        /// <summary>
        /// 对 叶结点identifier 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParseidentifierLeave_()
        {
            return FuncParseidentifierLeave_;
        }
        /// <summary>
        /// 对 叶结点number 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsenumberLeave_()
        {
            return FuncParsenumberLeave_;
        }
        /// <summary>
        /// 对 叶结点# 进行分析
        /// </summary>
        public static CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            GetFuncParsetail_startEndLeave_()
        {
            return FuncParsetail_startEndLeave_;
        }
        
        #endregion 获取分析表中的元素
        #region 分析表中的元素指向的分析函数
        
        /// <summary>
        /// 对 &lt;Expression&gt; ::= &quot;~&quot;... 进行分析
        /// <para>&lt;Expression&gt; ::= &quot;~&quot; &quot;!&quot; &quot;@&quot; &quot;#&quot; &quot;%&quot; &quot;^&quot; &quot;&amp;&quot; &quot;*&quot; &quot;(&quot; &quot;)&quot; &quot;-&quot; &quot;+&quot; &quot;=&quot; &quot;{&quot; &quot;}&quot; &quot;[&quot; &quot;]&quot; &quot;:&quot; &quot;;&quot; &quot;&lt;&quot; &quot;&gt;&quot; &quot;,&quot; &quot;.&quot; &quot;?&quot; &quot;/&quot; &quot;~=&quot; &quot;!=&quot; &quot;%=&quot; &quot;^=&quot; &quot;&amp;=&quot; &quot;*=&quot; &quot;-=&quot; &quot;+=&quot; &quot;&lt;=&quot; &quot;&gt;=&quot; &quot;/=&quot; &quot;&amp;&amp;&quot; &quot;++&quot; &quot;&lt;&lt;&quot; &quot;&gt;&gt;&quot; constString identifier number;</para>
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsecase_Expression___tail_reverse_Leave(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            // <Expression> ::= "~" "!" "@" "#" "%" "^" "&" "*" "(" ")" "-" "+" "=" "{" "}" "[" "]" ":" ";" "<" ">" "," "." "?" "/" "~=" "!=" "%=" "^=" "&=" "*=" "-=" "+=" "<=" ">=" "/=" "&&" "++" "<<" ">>" constString identifier number;
            return Derivationcase_Expression___tail_reverse_Leavetail_not_Leavetail_atLeavetail_pound_Leavetail_percent_Leavetail_xor_Leavetail_and_Leavetail_multiply_Leavetail_leftParentheses_Leavetail_rightParentheses_Leavetail_minus_Leavetail_plus_Leavetail_equality_Leavetail_leftBrace_Leavetail_rightBrace_Leavetail_leftBracket_Leavetail_rightBracket_Leavetail_colon_Leavetail_semicolon_Leavetail_lessThan_Leavetail_greaterThan_Leavetail_comma_Leavetail_dot_Leavetail_question_Leavetail_divide_Leavetail_reverse_Equality_Leavetail_not_Equality_Leavetail_percent_Equality_Leavetail_xor_Equality_Leavetail_and_Equality_Leavetail_multiply_Equality_Leavetail_minus_Equality_Leavetail_plus_Equality_Leavetail_lessThan_Equality_Leavetail_greaterThan_Equality_Leavetail_divide_Equality_Leavetail_and_And_Leavetail_plus_Plus_Leavetail_lessThan_LessThan_Leavetail_greaterThan_GreaterThan_LeaveconstStringLeaveidentifierLeavenumberLeave(result, parser);
        }
        
        /// <summary>
        /// 对 叶结点&quot;~&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_reverse_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_reverse_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;!&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_not_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_not_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;@&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_atLeave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_atLeave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;#&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_pound_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_pound_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;%&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_percent_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_percent_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;^&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_xor_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_xor_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&amp;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_and_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_and_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;*&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_multiply_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_multiply_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;(&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_leftParentheses_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_leftParentheses_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;)&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_rightParentheses_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_rightParentheses_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;-&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_minus_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_minus_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;+&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_plus_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_plus_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;{&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_leftBrace_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_leftBrace_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;}&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_rightBrace_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_rightBrace_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;[&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_leftBracket_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_leftBracket_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;]&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_rightBracket_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_rightBracket_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;:&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_colon_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_colon_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_semicolon_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_semicolon_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&lt;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_lessThan_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_lessThan_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&gt;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_greaterThan_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_greaterThan_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;,&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_comma_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_comma_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;.&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_dot_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_dot_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;?&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_question_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_question_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;/&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_divide_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_divide_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;~=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_reverse_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;!=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_not_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_not_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;%=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_percent_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_percent_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;^=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_xor_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_xor_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&amp;=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_and_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_and_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;*=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_multiply_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;-=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_minus_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_minus_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;+=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_plus_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_plus_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&lt;=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_lessThan_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&gt;=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_greaterThan_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;/=&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_divide_Equality_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_divide_Equality_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&amp;&amp;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_and_And_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_and_And_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;++&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_plus_Plus_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_plus_Plus_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&lt;&lt;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_lessThan_LessThan_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点&quot;&gt;&gt;&quot; 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_greaterThan_GreaterThan_Leave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点constString 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            ParseconstStringLeave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.constStringLeave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点identifier 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            ParseidentifierLeave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.identifierLeave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点number 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            ParsenumberLeave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.numberLeave;
            result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ptNextToken++;
            result.MappedTokenLength = 1;
            parserCSSLCompiler.m_ParserStack.Pop();
            return Next(result, parserCSSLCompiler);
        }
        /// <summary>
        /// 对 叶结点# 进行分析
        /// <param name="result"></param>
        /// <param name="parser"></param>
        /// </summary>
        /// <returns></returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Parsetail_startEndLeave_(SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result, ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            if (result != null)
            {
                result.NodeValue.NodeType = EnumVTypeCSSLCompiler.tail_startEndLeave;
                result.NodeValue.NodeName = parserCSSLCompiler.m_TokenListSource[parserCSSLCompiler.m_ptNextToken].Detail;
                result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
                result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
                result.MappedTokenLength = 1;
            }
            parserCSSLCompiler.m_ParserStack.Pop();
            parserCSSLCompiler.m_ptNextToken++;
            return Next(result, parserCSSLCompiler);
        }
        
        #endregion 分析表中的元素指向的分析函数
        #region 所有推导式的推导动作函数
        
        /// <summary>
        /// &lt;Expression&gt; ::= &quot;~&quot; &quot;!&quot; &quot;@&quot; &quot;#&quot; &quot;%&quot; &quot;^&quot; &quot;&amp;&quot; &quot;*&quot; &quot;(&quot; &quot;)&quot; &quot;-&quot; &quot;+&quot; &quot;=&quot; &quot;{&quot; &quot;}&quot; &quot;[&quot; &quot;]&quot; &quot;:&quot; &quot;;&quot; &quot;&lt;&quot; &quot;&gt;&quot; &quot;,&quot; &quot;.&quot; &quot;?&quot; &quot;/&quot; &quot;~=&quot; &quot;!=&quot; &quot;%=&quot; &quot;^=&quot; &quot;&amp;=&quot; &quot;*=&quot; &quot;-=&quot; &quot;+=&quot; &quot;&lt;=&quot; &quot;&gt;=&quot; &quot;/=&quot; &quot;&amp;&amp;&quot; &quot;++&quot; &quot;&lt;&lt;&quot; &quot;&gt;&gt;&quot; constString identifier number;
        /// <summary>
        /// <param name="result">需要扩展的结点</param>
        /// <param name="parser">使用的分析器对象</param>
        /// <returns>下一个要扩展的结点</returns>
        private static SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>
            Derivationcase_Expression___tail_reverse_Leavetail_not_Leavetail_atLeavetail_pound_Leavetail_percent_Leavetail_xor_Leavetail_and_Leavetail_multiply_Leavetail_leftParentheses_Leavetail_rightParentheses_Leavetail_minus_Leavetail_plus_Leavetail_equality_Leavetail_leftBrace_Leavetail_rightBrace_Leavetail_leftBracket_Leavetail_rightBracket_Leavetail_colon_Leavetail_semicolon_Leavetail_lessThan_Leavetail_greaterThan_Leavetail_comma_Leavetail_dot_Leavetail_question_Leavetail_divide_Leavetail_reverse_Equality_Leavetail_not_Equality_Leavetail_percent_Equality_Leavetail_xor_Equality_Leavetail_and_Equality_Leavetail_multiply_Equality_Leavetail_minus_Equality_Leavetail_plus_Equality_Leavetail_lessThan_Equality_Leavetail_greaterThan_Equality_Leavetail_divide_Equality_Leavetail_and_And_Leavetail_plus_Plus_Leavetail_lessThan_LessThan_Leavetail_greaterThan_GreaterThan_LeaveconstStringLeaveidentifierLeavenumberLeave(
            SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> result,
            ISyntaxParser<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler> parser)
        {//<Expression> ::= "~" "!" "@" "#" "%" "^" "&" "*" "(" ")" "-" "+" "=" "{" "}" "[" "]" ":" ";" "<" ">" "," "." "?" "/" "~=" "!=" "%=" "^=" "&=" "*=" "-=" "+=" "<=" ">=" "/=" "&&" "++" "<<" ">>" constString identifier number;
            var parserCSSLCompiler = parser as LL1SyntaxParserCSSLCompiler;
            result.NodeValue.NodeType = EnumVTypeCSSLCompiler.case_Expression;
            result.NodeValue.NodeName = EnumVTypeCSSLCompiler.case_Expression.ToString();
            //result.NodeValue.Position = EnumProductionNodePosition.NonLeave;
            result.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            result.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            parserCSSLCompiler.m_ParserStack.Pop();
            // right-to-left push
            parserCSSLCompiler.m_ParserStack.Push(m_numberLeave);
            parserCSSLCompiler.m_ParserStack.Push(m_identifierLeave);
            parserCSSLCompiler.m_ParserStack.Push(m_constStringLeave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_greaterThan_GreaterThan_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_lessThan_LessThan_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_plus_Plus_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_and_And_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_divide_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_greaterThan_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_lessThan_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_plus_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_minus_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_multiply_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_and_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_xor_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_percent_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_not_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_reverse_Equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_divide_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_question_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_dot_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_comma_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_greaterThan_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_lessThan_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_semicolon_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_colon_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_rightBracket_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_leftBracket_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_rightBrace_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_leftBrace_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_equality_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_plus_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_minus_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_rightParentheses_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_leftParentheses_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_multiply_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_and_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_xor_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_percent_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_pound_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_atLeave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_not_Leave);
            parserCSSLCompiler.m_ParserStack.Push(m_tail_reverse_Leave);
            // generate syntax tree
            var tail_reverse_LeaveTree0 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_reverse_LeaveTree0.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_reverse_LeaveTree0.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_reverse_LeaveTree0.Parent = result;
            //tail_reverse_LeaveTree0.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_reverse_Leave);
            result.Children.Add(tail_reverse_LeaveTree0);
            var tail_not_LeaveTree1 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_not_LeaveTree1.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_not_LeaveTree1.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_not_LeaveTree1.Parent = result;
            //tail_not_LeaveTree1.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_not_Leave);
            result.Children.Add(tail_not_LeaveTree1);
            var tail_atLeaveTree2 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_atLeaveTree2.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_atLeaveTree2.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_atLeaveTree2.Parent = result;
            //tail_atLeaveTree2.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_atLeave);
            result.Children.Add(tail_atLeaveTree2);
            var tail_pound_LeaveTree3 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_pound_LeaveTree3.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_pound_LeaveTree3.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_pound_LeaveTree3.Parent = result;
            //tail_pound_LeaveTree3.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_pound_Leave);
            result.Children.Add(tail_pound_LeaveTree3);
            var tail_percent_LeaveTree4 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_percent_LeaveTree4.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_percent_LeaveTree4.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_percent_LeaveTree4.Parent = result;
            //tail_percent_LeaveTree4.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_percent_Leave);
            result.Children.Add(tail_percent_LeaveTree4);
            var tail_xor_LeaveTree5 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_xor_LeaveTree5.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_xor_LeaveTree5.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_xor_LeaveTree5.Parent = result;
            //tail_xor_LeaveTree5.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_xor_Leave);
            result.Children.Add(tail_xor_LeaveTree5);
            var tail_and_LeaveTree6 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_and_LeaveTree6.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_and_LeaveTree6.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_and_LeaveTree6.Parent = result;
            //tail_and_LeaveTree6.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_and_Leave);
            result.Children.Add(tail_and_LeaveTree6);
            var tail_multiply_LeaveTree7 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_multiply_LeaveTree7.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_multiply_LeaveTree7.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_multiply_LeaveTree7.Parent = result;
            //tail_multiply_LeaveTree7.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_multiply_Leave);
            result.Children.Add(tail_multiply_LeaveTree7);
            var tail_leftParentheses_LeaveTree8 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_leftParentheses_LeaveTree8.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_leftParentheses_LeaveTree8.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_leftParentheses_LeaveTree8.Parent = result;
            //tail_leftParentheses_LeaveTree8.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave);
            result.Children.Add(tail_leftParentheses_LeaveTree8);
            var tail_rightParentheses_LeaveTree9 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_rightParentheses_LeaveTree9.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_rightParentheses_LeaveTree9.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_rightParentheses_LeaveTree9.Parent = result;
            //tail_rightParentheses_LeaveTree9.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave);
            result.Children.Add(tail_rightParentheses_LeaveTree9);
            var tail_minus_LeaveTree10 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_minus_LeaveTree10.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_minus_LeaveTree10.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_minus_LeaveTree10.Parent = result;
            //tail_minus_LeaveTree10.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_minus_Leave);
            result.Children.Add(tail_minus_LeaveTree10);
            var tail_plus_LeaveTree11 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_plus_LeaveTree11.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_plus_LeaveTree11.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_plus_LeaveTree11.Parent = result;
            //tail_plus_LeaveTree11.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_plus_Leave);
            result.Children.Add(tail_plus_LeaveTree11);
            var tail_equality_LeaveTree12 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_equality_LeaveTree12.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_equality_LeaveTree12.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_equality_LeaveTree12.Parent = result;
            //tail_equality_LeaveTree12.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_equality_Leave);
            result.Children.Add(tail_equality_LeaveTree12);
            var tail_leftBrace_LeaveTree13 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_leftBrace_LeaveTree13.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_leftBrace_LeaveTree13.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_leftBrace_LeaveTree13.Parent = result;
            //tail_leftBrace_LeaveTree13.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_leftBrace_Leave);
            result.Children.Add(tail_leftBrace_LeaveTree13);
            var tail_rightBrace_LeaveTree14 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_rightBrace_LeaveTree14.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_rightBrace_LeaveTree14.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_rightBrace_LeaveTree14.Parent = result;
            //tail_rightBrace_LeaveTree14.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_rightBrace_Leave);
            result.Children.Add(tail_rightBrace_LeaveTree14);
            var tail_leftBracket_LeaveTree15 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_leftBracket_LeaveTree15.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_leftBracket_LeaveTree15.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_leftBracket_LeaveTree15.Parent = result;
            //tail_leftBracket_LeaveTree15.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_leftBracket_Leave);
            result.Children.Add(tail_leftBracket_LeaveTree15);
            var tail_rightBracket_LeaveTree16 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_rightBracket_LeaveTree16.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_rightBracket_LeaveTree16.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_rightBracket_LeaveTree16.Parent = result;
            //tail_rightBracket_LeaveTree16.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_rightBracket_Leave);
            result.Children.Add(tail_rightBracket_LeaveTree16);
            var tail_colon_LeaveTree17 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_colon_LeaveTree17.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_colon_LeaveTree17.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_colon_LeaveTree17.Parent = result;
            //tail_colon_LeaveTree17.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_colon_Leave);
            result.Children.Add(tail_colon_LeaveTree17);
            var tail_semicolon_LeaveTree18 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_semicolon_LeaveTree18.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_semicolon_LeaveTree18.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_semicolon_LeaveTree18.Parent = result;
            //tail_semicolon_LeaveTree18.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_semicolon_Leave);
            result.Children.Add(tail_semicolon_LeaveTree18);
            var tail_lessThan_LeaveTree19 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_lessThan_LeaveTree19.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_lessThan_LeaveTree19.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_lessThan_LeaveTree19.Parent = result;
            //tail_lessThan_LeaveTree19.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_lessThan_Leave);
            result.Children.Add(tail_lessThan_LeaveTree19);
            var tail_greaterThan_LeaveTree20 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_greaterThan_LeaveTree20.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_greaterThan_LeaveTree20.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_greaterThan_LeaveTree20.Parent = result;
            //tail_greaterThan_LeaveTree20.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_greaterThan_Leave);
            result.Children.Add(tail_greaterThan_LeaveTree20);
            var tail_comma_LeaveTree21 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_comma_LeaveTree21.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_comma_LeaveTree21.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_comma_LeaveTree21.Parent = result;
            //tail_comma_LeaveTree21.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_comma_Leave);
            result.Children.Add(tail_comma_LeaveTree21);
            var tail_dot_LeaveTree22 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_dot_LeaveTree22.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_dot_LeaveTree22.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_dot_LeaveTree22.Parent = result;
            //tail_dot_LeaveTree22.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_dot_Leave);
            result.Children.Add(tail_dot_LeaveTree22);
            var tail_question_LeaveTree23 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_question_LeaveTree23.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_question_LeaveTree23.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_question_LeaveTree23.Parent = result;
            //tail_question_LeaveTree23.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_question_Leave);
            result.Children.Add(tail_question_LeaveTree23);
            var tail_divide_LeaveTree24 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_divide_LeaveTree24.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_divide_LeaveTree24.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_divide_LeaveTree24.Parent = result;
            //tail_divide_LeaveTree24.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_divide_Leave);
            result.Children.Add(tail_divide_LeaveTree24);
            var tail_reverse_Equality_LeaveTree25 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_reverse_Equality_LeaveTree25.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_reverse_Equality_LeaveTree25.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_reverse_Equality_LeaveTree25.Parent = result;
            //tail_reverse_Equality_LeaveTree25.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave);
            result.Children.Add(tail_reverse_Equality_LeaveTree25);
            var tail_not_Equality_LeaveTree26 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_not_Equality_LeaveTree26.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_not_Equality_LeaveTree26.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_not_Equality_LeaveTree26.Parent = result;
            //tail_not_Equality_LeaveTree26.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_not_Equality_Leave);
            result.Children.Add(tail_not_Equality_LeaveTree26);
            var tail_percent_Equality_LeaveTree27 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_percent_Equality_LeaveTree27.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_percent_Equality_LeaveTree27.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_percent_Equality_LeaveTree27.Parent = result;
            //tail_percent_Equality_LeaveTree27.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave);
            result.Children.Add(tail_percent_Equality_LeaveTree27);
            var tail_xor_Equality_LeaveTree28 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_xor_Equality_LeaveTree28.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_xor_Equality_LeaveTree28.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_xor_Equality_LeaveTree28.Parent = result;
            //tail_xor_Equality_LeaveTree28.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave);
            result.Children.Add(tail_xor_Equality_LeaveTree28);
            var tail_and_Equality_LeaveTree29 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_and_Equality_LeaveTree29.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_and_Equality_LeaveTree29.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_and_Equality_LeaveTree29.Parent = result;
            //tail_and_Equality_LeaveTree29.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_and_Equality_Leave);
            result.Children.Add(tail_and_Equality_LeaveTree29);
            var tail_multiply_Equality_LeaveTree30 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_multiply_Equality_LeaveTree30.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_multiply_Equality_LeaveTree30.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_multiply_Equality_LeaveTree30.Parent = result;
            //tail_multiply_Equality_LeaveTree30.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave);
            result.Children.Add(tail_multiply_Equality_LeaveTree30);
            var tail_minus_Equality_LeaveTree31 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_minus_Equality_LeaveTree31.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_minus_Equality_LeaveTree31.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_minus_Equality_LeaveTree31.Parent = result;
            //tail_minus_Equality_LeaveTree31.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave);
            result.Children.Add(tail_minus_Equality_LeaveTree31);
            var tail_plus_Equality_LeaveTree32 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_plus_Equality_LeaveTree32.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_plus_Equality_LeaveTree32.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_plus_Equality_LeaveTree32.Parent = result;
            //tail_plus_Equality_LeaveTree32.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave);
            result.Children.Add(tail_plus_Equality_LeaveTree32);
            var tail_lessThan_Equality_LeaveTree33 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_lessThan_Equality_LeaveTree33.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_lessThan_Equality_LeaveTree33.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_lessThan_Equality_LeaveTree33.Parent = result;
            //tail_lessThan_Equality_LeaveTree33.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave);
            result.Children.Add(tail_lessThan_Equality_LeaveTree33);
            var tail_greaterThan_Equality_LeaveTree34 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_greaterThan_Equality_LeaveTree34.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_greaterThan_Equality_LeaveTree34.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_greaterThan_Equality_LeaveTree34.Parent = result;
            //tail_greaterThan_Equality_LeaveTree34.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave);
            result.Children.Add(tail_greaterThan_Equality_LeaveTree34);
            var tail_divide_Equality_LeaveTree35 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_divide_Equality_LeaveTree35.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_divide_Equality_LeaveTree35.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_divide_Equality_LeaveTree35.Parent = result;
            //tail_divide_Equality_LeaveTree35.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave);
            result.Children.Add(tail_divide_Equality_LeaveTree35);
            var tail_and_And_LeaveTree36 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_and_And_LeaveTree36.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_and_And_LeaveTree36.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_and_And_LeaveTree36.Parent = result;
            //tail_and_And_LeaveTree36.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_and_And_Leave);
            result.Children.Add(tail_and_And_LeaveTree36);
            var tail_plus_Plus_LeaveTree37 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_plus_Plus_LeaveTree37.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_plus_Plus_LeaveTree37.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_plus_Plus_LeaveTree37.Parent = result;
            //tail_plus_Plus_LeaveTree37.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave);
            result.Children.Add(tail_plus_Plus_LeaveTree37);
            var tail_lessThan_LessThan_LeaveTree38 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_lessThan_LessThan_LeaveTree38.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_lessThan_LessThan_LeaveTree38.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_lessThan_LessThan_LeaveTree38.Parent = result;
            //tail_lessThan_LessThan_LeaveTree38.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave);
            result.Children.Add(tail_lessThan_LessThan_LeaveTree38);
            var tail_greaterThan_GreaterThan_LeaveTree39 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            tail_greaterThan_GreaterThan_LeaveTree39.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            tail_greaterThan_GreaterThan_LeaveTree39.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            tail_greaterThan_GreaterThan_LeaveTree39.Parent = result;
            //tail_greaterThan_GreaterThan_LeaveTree39.Value = new ProductionNode(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave);
            result.Children.Add(tail_greaterThan_GreaterThan_LeaveTree39);
            var constStringLeaveTree40 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            constStringLeaveTree40.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            constStringLeaveTree40.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            constStringLeaveTree40.Parent = result;
            //constStringLeaveTree40.Value = new ProductionNode(EnumVTypeCSSLCompiler.constStringLeave);
            result.Children.Add(constStringLeaveTree40);
            var identifierLeaveTree41 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            identifierLeaveTree41.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            identifierLeaveTree41.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            identifierLeaveTree41.Parent = result;
            //identifierLeaveTree41.Value = new ProductionNode(EnumVTypeCSSLCompiler.identifierLeave);
            result.Children.Add(identifierLeaveTree41);
            var numberLeaveTree42 = new SyntaxTree<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>();
            numberLeaveTree42.MappedTotalTokenList = parserCSSLCompiler.m_TokenListSource;
            numberLeaveTree42.MappedTokenStartIndex = parserCSSLCompiler.m_ptNextToken;
            numberLeaveTree42.Parent = result;
            //numberLeaveTree42.Value = new ProductionNode(EnumVTypeCSSLCompiler.numberLeave);
            result.Children.Add(numberLeaveTree42);
            return tail_reverse_LeaveTree0;
        }//<Expression> ::= "~" "!" "@" "#" "%" "^" "&" "*" "(" ")" "-" "+" "=" "{" "}" "[" "]" ":" ";" "<" ">" "," "." "?" "/" "~=" "!=" "%=" "^=" "&=" "*=" "-=" "+=" "<=" ">=" "/=" "&&" "++" "<<" ">>" constString identifier number;
        
        #endregion 所有推导式的推导动作函数
        #region FillMapCells()
        
        private void FillMapCells()
        {
            m_Map.SetCell(EnumVTypeCSSLCompiler.case_Expression, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsecase_Expression___tail_reverse_Leave);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_reverse_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_reverse_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_not_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_not_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_atLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_atLeave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_atLeave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_pound_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_pound_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_pound_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_percent_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_percent_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_xor_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_xor_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_and_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_and_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_multiply_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_multiply_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_leftParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftParentheses_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_leftParentheses_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_rightParentheses_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightParentheses_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_rightParentheses_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_minus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_minus_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_plus_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_leftBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBrace_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_leftBrace_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_rightBrace_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBrace_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_rightBrace_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_leftBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_leftBracket_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_leftBracket_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_rightBracket_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_rightBracket_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_rightBracket_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_colon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_colon_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_colon_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_semicolon_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_semicolon_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_semicolon_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_lessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_lessThan_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_greaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_greaterThan_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_comma_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_comma_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_comma_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_dot_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_dot_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_dot_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_question_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_question_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_question_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_divide_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_divide_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_reverse_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_reverse_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_not_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_not_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_not_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_percent_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_percent_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_percent_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_xor_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_xor_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_xor_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_and_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_and_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_multiply_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_multiply_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_minus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_minus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_minus_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_plus_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_plus_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_lessThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_lessThan_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_greaterThan_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_greaterThan_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_divide_Equality_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_divide_Equality_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_divide_Equality_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_and_And_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_and_And_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_and_And_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_plus_Plus_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_plus_Plus_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_plus_Plus_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_lessThan_LessThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_lessThan_LessThan_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_greaterThan_GreaterThan_Leave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_greaterThan_GreaterThan_Leave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_At, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_And_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.constString, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.identifier, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.number, FuncParseconstStringLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.constStringLeave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParseconstStringLeave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_At, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_And_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.constString, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.identifier, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.number, FuncParseidentifierLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.identifierLeave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParseidentifierLeave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_At, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.constString, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.identifier, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.number, FuncParsenumberLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.numberLeave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsenumberLeave_);
            
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Reverse_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Not_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_At, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Pound_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Percent_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Xor_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_And_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Multiply_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_LeftParentheses_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_RightParentheses_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Minus_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Plus_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_LeftBrace_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_RightBrace_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_LeftBracket_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_RightBracket_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Colon_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Semicolon_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_LessThan_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Comma_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Dot_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Question_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Divide_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Not_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Percent_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Xor_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_And_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Minus_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Plus_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Divide_Equality_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_And_And_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_Plus_Plus_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.constString, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.identifier, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.number, FuncParsetail_startEndLeave_);
            m_Map.SetCell(EnumVTypeCSSLCompiler.tail_startEndLeave, EnumTokenTypeCSSLCompiler.token_startEnd, FuncParsetail_startEndLeave_);
        }
        
        #endregion FillMapCells()
        #region 为分析表中的元素配置分析函数
        
        private void InitFunc()
        {
            FuncParsecase_Expression___tail_reverse_Leave = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsecase_Expression___tail_reverse_Leave);
            
            FuncParsetail_reverse_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_reverse_Leave_);
            FuncParsetail_not_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_not_Leave_);
            FuncParsetail_atLeave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_atLeave_);
            FuncParsetail_pound_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_pound_Leave_);
            FuncParsetail_percent_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_percent_Leave_);
            FuncParsetail_xor_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_xor_Leave_);
            FuncParsetail_and_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_and_Leave_);
            FuncParsetail_multiply_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_multiply_Leave_);
            FuncParsetail_leftParentheses_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_leftParentheses_Leave_);
            FuncParsetail_rightParentheses_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_rightParentheses_Leave_);
            FuncParsetail_minus_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_minus_Leave_);
            FuncParsetail_plus_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_plus_Leave_);
            FuncParsetail_equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_equality_Leave_);
            FuncParsetail_leftBrace_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_leftBrace_Leave_);
            FuncParsetail_rightBrace_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_rightBrace_Leave_);
            FuncParsetail_leftBracket_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_leftBracket_Leave_);
            FuncParsetail_rightBracket_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_rightBracket_Leave_);
            FuncParsetail_colon_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_colon_Leave_);
            FuncParsetail_semicolon_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_semicolon_Leave_);
            FuncParsetail_lessThan_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_lessThan_Leave_);
            FuncParsetail_greaterThan_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_greaterThan_Leave_);
            FuncParsetail_comma_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_comma_Leave_);
            FuncParsetail_dot_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_dot_Leave_);
            FuncParsetail_question_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_question_Leave_);
            FuncParsetail_divide_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_divide_Leave_);
            FuncParsetail_reverse_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_reverse_Equality_Leave_);
            FuncParsetail_not_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_not_Equality_Leave_);
            FuncParsetail_percent_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_percent_Equality_Leave_);
            FuncParsetail_xor_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_xor_Equality_Leave_);
            FuncParsetail_and_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_and_Equality_Leave_);
            FuncParsetail_multiply_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_multiply_Equality_Leave_);
            FuncParsetail_minus_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_minus_Equality_Leave_);
            FuncParsetail_plus_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_plus_Equality_Leave_);
            FuncParsetail_lessThan_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_lessThan_Equality_Leave_);
            FuncParsetail_greaterThan_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_greaterThan_Equality_Leave_);
            FuncParsetail_divide_Equality_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_divide_Equality_Leave_);
            FuncParsetail_and_And_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_and_And_Leave_);
            FuncParsetail_plus_Plus_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_plus_Plus_Leave_);
            FuncParsetail_lessThan_LessThan_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_lessThan_LessThan_Leave_);
            FuncParsetail_greaterThan_GreaterThan_Leave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_greaterThan_GreaterThan_Leave_);
            FuncParseconstStringLeave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(ParseconstStringLeave_);
            FuncParseidentifierLeave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(ParseidentifierLeave_);
            FuncParsenumberLeave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(ParsenumberLeave_);
            FuncParsetail_startEndLeave_ = 
                new CandidateFunction<EnumTokenTypeCSSLCompiler, EnumVTypeCSSLCompiler, TreeNodeValueCSSLCompiler>(Parsetail_startEndLeave_);
        }
        
        #endregion 为分析表中的元素配置分析函数
        /// <summary>
        /// 初始化LL(1)分析表
        /// </summary>
        public override void InitMap()
        {
            InitFunc();
            // init parser map
            SetMapLinesAndColumns();
            FillMapCells();
        }
        /// <summary>
        /// LL1SyntaxParserCSSLCompiler的语法分析器
        /// </summary>
        public LL1SyntaxParserCSSLCompiler()
            : base(45, 44) { }
        /// LL1SyntaxParserCSSLCompiler的语法分析器
        /// </summary>
        /// <param name="tokens">要分析的单词列表</param>
        public LL1SyntaxParserCSSLCompiler(TokenList<EnumTokenTypeCSSLCompiler> tokens)
            : base(45, 44)
        {
            m_TokenListSource = tokens;
        }
        #region 重置语法分析器到初始状态，这样就可以重新对上次分析过的单词列表进行分析
        
        /// <summary>
        /// 重置语法分析器到初始状态，这样就可以重新对上次分析过的单词列表进行分析
        /// </summary>
        public override void Reset()
        {
            m_ptNextToken = 0;
            m_ParserStack.Clear();
            m_ParserStack.Push(m_tail_startEndLeave);
            m_ParserStack.Push(m_case_Expression);
            if (m_TokenListSource.Count == 0)
            {
                var newToken = new Token<EnumTokenTypeCSSLCompiler>()
                {
                    Detail = "#",
                    Line = 0,
                    Column = 0,
                    IndexOfSourceCode = 0,
                    Length = 1,
                    LexicalError = false,
                    TokenType = EnumTokenTypeCSSLCompiler.token_startEnd
                };
                m_TokenListSource.Add(newToken);
            }
            else
            {
                var token = m_TokenListSource[m_TokenListSource.Count - 1];
                {
                    var newToken = new Token<EnumTokenTypeCSSLCompiler>()
                    {
                        Detail = "#",
                        Line = token.Line,
                        Column = token.Column + token.Length + 1,
                        IndexOfSourceCode = token.IndexOfSourceCode + token.Length + 1,
                        Length = 1,
                        LexicalError = false,
                        TokenType = EnumTokenTypeCSSLCompiler.token_startEnd
                    };
                    m_TokenListSource.Add(newToken);
                }
            }
        }
        
        #endregion 重置语法分析器到初始状态，这样就可以重新对上次分析过的单词列表进行分析
        #region SetMapLinesAndColumns()
        
        private void SetMapLinesAndColumns()
        {
            m_Map.SetLine(0, EnumVTypeCSSLCompiler.case_Expression);
            
            m_Map.SetLine(1, EnumVTypeCSSLCompiler.tail_reverse_Leave);
            m_Map.SetLine(2, EnumVTypeCSSLCompiler.tail_not_Leave);
            m_Map.SetLine(3, EnumVTypeCSSLCompiler.tail_atLeave);
            m_Map.SetLine(4, EnumVTypeCSSLCompiler.tail_pound_Leave);
            m_Map.SetLine(5, EnumVTypeCSSLCompiler.tail_percent_Leave);
            m_Map.SetLine(6, EnumVTypeCSSLCompiler.tail_xor_Leave);
            m_Map.SetLine(7, EnumVTypeCSSLCompiler.tail_and_Leave);
            m_Map.SetLine(8, EnumVTypeCSSLCompiler.tail_multiply_Leave);
            m_Map.SetLine(9, EnumVTypeCSSLCompiler.tail_leftParentheses_Leave);
            m_Map.SetLine(10, EnumVTypeCSSLCompiler.tail_rightParentheses_Leave);
            m_Map.SetLine(11, EnumVTypeCSSLCompiler.tail_minus_Leave);
            m_Map.SetLine(12, EnumVTypeCSSLCompiler.tail_plus_Leave);
            m_Map.SetLine(13, EnumVTypeCSSLCompiler.tail_equality_Leave);
            m_Map.SetLine(14, EnumVTypeCSSLCompiler.tail_leftBrace_Leave);
            m_Map.SetLine(15, EnumVTypeCSSLCompiler.tail_rightBrace_Leave);
            m_Map.SetLine(16, EnumVTypeCSSLCompiler.tail_leftBracket_Leave);
            m_Map.SetLine(17, EnumVTypeCSSLCompiler.tail_rightBracket_Leave);
            m_Map.SetLine(18, EnumVTypeCSSLCompiler.tail_colon_Leave);
            m_Map.SetLine(19, EnumVTypeCSSLCompiler.tail_semicolon_Leave);
            m_Map.SetLine(20, EnumVTypeCSSLCompiler.tail_lessThan_Leave);
            m_Map.SetLine(21, EnumVTypeCSSLCompiler.tail_greaterThan_Leave);
            m_Map.SetLine(22, EnumVTypeCSSLCompiler.tail_comma_Leave);
            m_Map.SetLine(23, EnumVTypeCSSLCompiler.tail_dot_Leave);
            m_Map.SetLine(24, EnumVTypeCSSLCompiler.tail_question_Leave);
            m_Map.SetLine(25, EnumVTypeCSSLCompiler.tail_divide_Leave);
            m_Map.SetLine(26, EnumVTypeCSSLCompiler.tail_reverse_Equality_Leave);
            m_Map.SetLine(27, EnumVTypeCSSLCompiler.tail_not_Equality_Leave);
            m_Map.SetLine(28, EnumVTypeCSSLCompiler.tail_percent_Equality_Leave);
            m_Map.SetLine(29, EnumVTypeCSSLCompiler.tail_xor_Equality_Leave);
            m_Map.SetLine(30, EnumVTypeCSSLCompiler.tail_and_Equality_Leave);
            m_Map.SetLine(31, EnumVTypeCSSLCompiler.tail_multiply_Equality_Leave);
            m_Map.SetLine(32, EnumVTypeCSSLCompiler.tail_minus_Equality_Leave);
            m_Map.SetLine(33, EnumVTypeCSSLCompiler.tail_plus_Equality_Leave);
            m_Map.SetLine(34, EnumVTypeCSSLCompiler.tail_lessThan_Equality_Leave);
            m_Map.SetLine(35, EnumVTypeCSSLCompiler.tail_greaterThan_Equality_Leave);
            m_Map.SetLine(36, EnumVTypeCSSLCompiler.tail_divide_Equality_Leave);
            m_Map.SetLine(37, EnumVTypeCSSLCompiler.tail_and_And_Leave);
            m_Map.SetLine(38, EnumVTypeCSSLCompiler.tail_plus_Plus_Leave);
            m_Map.SetLine(39, EnumVTypeCSSLCompiler.tail_lessThan_LessThan_Leave);
            m_Map.SetLine(40, EnumVTypeCSSLCompiler.tail_greaterThan_GreaterThan_Leave);
            m_Map.SetLine(41, EnumVTypeCSSLCompiler.constStringLeave);
            m_Map.SetLine(42, EnumVTypeCSSLCompiler.identifierLeave);
            m_Map.SetLine(43, EnumVTypeCSSLCompiler.numberLeave);
            m_Map.SetLine(44, EnumVTypeCSSLCompiler.tail_startEndLeave);
            
            
            m_Map.SetColumn(0, EnumTokenTypeCSSLCompiler.token_Reverse_);
            m_Map.SetColumn(1, EnumTokenTypeCSSLCompiler.token_Not_);
            m_Map.SetColumn(2, EnumTokenTypeCSSLCompiler.token_At);
            m_Map.SetColumn(3, EnumTokenTypeCSSLCompiler.token_Pound_);
            m_Map.SetColumn(4, EnumTokenTypeCSSLCompiler.token_Percent_);
            m_Map.SetColumn(5, EnumTokenTypeCSSLCompiler.token_Xor_);
            m_Map.SetColumn(6, EnumTokenTypeCSSLCompiler.token_And_);
            m_Map.SetColumn(7, EnumTokenTypeCSSLCompiler.token_Multiply_);
            m_Map.SetColumn(8, EnumTokenTypeCSSLCompiler.token_LeftParentheses_);
            m_Map.SetColumn(9, EnumTokenTypeCSSLCompiler.token_RightParentheses_);
            m_Map.SetColumn(10, EnumTokenTypeCSSLCompiler.token_Minus_);
            m_Map.SetColumn(11, EnumTokenTypeCSSLCompiler.token_Plus_);
            m_Map.SetColumn(12, EnumTokenTypeCSSLCompiler.token_Equality_);
            m_Map.SetColumn(13, EnumTokenTypeCSSLCompiler.token_LeftBrace_);
            m_Map.SetColumn(14, EnumTokenTypeCSSLCompiler.token_RightBrace_);
            m_Map.SetColumn(15, EnumTokenTypeCSSLCompiler.token_LeftBracket_);
            m_Map.SetColumn(16, EnumTokenTypeCSSLCompiler.token_RightBracket_);
            m_Map.SetColumn(17, EnumTokenTypeCSSLCompiler.token_Colon_);
            m_Map.SetColumn(18, EnumTokenTypeCSSLCompiler.token_Semicolon_);
            m_Map.SetColumn(19, EnumTokenTypeCSSLCompiler.token_LessThan_);
            m_Map.SetColumn(20, EnumTokenTypeCSSLCompiler.token_GreaterThan_);
            m_Map.SetColumn(21, EnumTokenTypeCSSLCompiler.token_Comma_);
            m_Map.SetColumn(22, EnumTokenTypeCSSLCompiler.token_Dot_);
            m_Map.SetColumn(23, EnumTokenTypeCSSLCompiler.token_Question_);
            m_Map.SetColumn(24, EnumTokenTypeCSSLCompiler.token_Divide_);
            m_Map.SetColumn(25, EnumTokenTypeCSSLCompiler.token_Reverse_Equality_);
            m_Map.SetColumn(26, EnumTokenTypeCSSLCompiler.token_Not_Equality_);
            m_Map.SetColumn(27, EnumTokenTypeCSSLCompiler.token_Percent_Equality_);
            m_Map.SetColumn(28, EnumTokenTypeCSSLCompiler.token_Xor_Equality_);
            m_Map.SetColumn(29, EnumTokenTypeCSSLCompiler.token_And_Equality_);
            m_Map.SetColumn(30, EnumTokenTypeCSSLCompiler.token_Multiply_Equality_);
            m_Map.SetColumn(31, EnumTokenTypeCSSLCompiler.token_Minus_Equality_);
            m_Map.SetColumn(32, EnumTokenTypeCSSLCompiler.token_Plus_Equality_);
            m_Map.SetColumn(33, EnumTokenTypeCSSLCompiler.token_LessThan_Equality_);
            m_Map.SetColumn(34, EnumTokenTypeCSSLCompiler.token_GreaterThan_Equality_);
            m_Map.SetColumn(35, EnumTokenTypeCSSLCompiler.token_Divide_Equality_);
            m_Map.SetColumn(36, EnumTokenTypeCSSLCompiler.token_And_And_);
            m_Map.SetColumn(37, EnumTokenTypeCSSLCompiler.token_Plus_Plus_);
            m_Map.SetColumn(38, EnumTokenTypeCSSLCompiler.token_LessThan_LessThan_);
            m_Map.SetColumn(39, EnumTokenTypeCSSLCompiler.token_GreaterThan_GreaterThan_);
            m_Map.SetColumn(40, EnumTokenTypeCSSLCompiler.constString);
            m_Map.SetColumn(41, EnumTokenTypeCSSLCompiler.identifier);
            m_Map.SetColumn(42, EnumTokenTypeCSSLCompiler.number);
            m_Map.SetColumn(43, EnumTokenTypeCSSLCompiler.token_startEnd);
        }
        
        #endregion SetMapLinesAndColumns()
    }

}

