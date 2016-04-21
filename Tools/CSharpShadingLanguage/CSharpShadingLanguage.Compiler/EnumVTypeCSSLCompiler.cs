namespace CSharpShadingLanguage.Compiler
{
    /// <summary>
    /// 文法CSSLCompiler的语法树结点枚举类型
    /// </summary>
    public enum EnumVTypeCSSLCompiler
    {
        /// <summary>
        /// 未知的语法结点符号
        /// </summary>
        Unknown,
        /// <summary>
        /// &lt;Expression&gt; ::= &quot;~&quot; &quot;!&quot; &quot;@&quot; &quot;#&quot; &quot;%&quot; &quot;^&quot; &quot;&amp;&quot; &quot;*&quot; &quot;(&quot; &quot;)&quot; &quot;-&quot; &quot;+&quot; &quot;=&quot; &quot;{&quot; &quot;}&quot; &quot;[&quot; &quot;]&quot; &quot;:&quot; &quot;;&quot; &quot;&lt;&quot; &quot;&gt;&quot; &quot;,&quot; &quot;.&quot; &quot;?&quot; &quot;/&quot; &quot;~=&quot; &quot;!=&quot; &quot;%=&quot; &quot;^=&quot; &quot;&amp;=&quot; &quot;*=&quot; &quot;-=&quot; &quot;+=&quot; &quot;&lt;=&quot; &quot;&gt;=&quot; &quot;/=&quot; &quot;&amp;&amp;&quot; &quot;++&quot; &quot;&lt;&lt;&quot; &quot;&gt;&gt;&quot; constString identifier number;
        /// </summary>
        case_Expression,
        /// <summary>
        /// &quot;~&quot;
        /// </summary>
        tail_reverse_Leave,
        /// <summary>
        /// &quot;!&quot;
        /// </summary>
        tail_not_Leave,
        /// <summary>
        /// &quot;@&quot;
        /// </summary>
        tail_atLeave,
        /// <summary>
        /// &quot;#&quot;
        /// </summary>
        tail_pound_Leave,
        /// <summary>
        /// &quot;%&quot;
        /// </summary>
        tail_percent_Leave,
        /// <summary>
        /// &quot;^&quot;
        /// </summary>
        tail_xor_Leave,
        /// <summary>
        /// &quot;&amp;&quot;
        /// </summary>
        tail_and_Leave,
        /// <summary>
        /// &quot;*&quot;
        /// </summary>
        tail_multiply_Leave,
        /// <summary>
        /// &quot;(&quot;
        /// </summary>
        tail_leftParentheses_Leave,
        /// <summary>
        /// &quot;)&quot;
        /// </summary>
        tail_rightParentheses_Leave,
        /// <summary>
        /// &quot;-&quot;
        /// </summary>
        tail_minus_Leave,
        /// <summary>
        /// &quot;+&quot;
        /// </summary>
        tail_plus_Leave,
        /// <summary>
        /// &quot;=&quot;
        /// </summary>
        tail_equality_Leave,
        /// <summary>
        /// &quot;{&quot;
        /// </summary>
        tail_leftBrace_Leave,
        /// <summary>
        /// &quot;}&quot;
        /// </summary>
        tail_rightBrace_Leave,
        /// <summary>
        /// &quot;[&quot;
        /// </summary>
        tail_leftBracket_Leave,
        /// <summary>
        /// &quot;]&quot;
        /// </summary>
        tail_rightBracket_Leave,
        /// <summary>
        /// &quot;:&quot;
        /// </summary>
        tail_colon_Leave,
        /// <summary>
        /// &quot;;&quot;
        /// </summary>
        tail_semicolon_Leave,
        /// <summary>
        /// &quot;&lt;&quot;
        /// </summary>
        tail_lessThan_Leave,
        /// <summary>
        /// &quot;&gt;&quot;
        /// </summary>
        tail_greaterThan_Leave,
        /// <summary>
        /// &quot;,&quot;
        /// </summary>
        tail_comma_Leave,
        /// <summary>
        /// &quot;.&quot;
        /// </summary>
        tail_dot_Leave,
        /// <summary>
        /// &quot;?&quot;
        /// </summary>
        tail_question_Leave,
        /// <summary>
        /// &quot;/&quot;
        /// </summary>
        tail_divide_Leave,
        /// <summary>
        /// &quot;~=&quot;
        /// </summary>
        tail_reverse_Equality_Leave,
        /// <summary>
        /// &quot;!=&quot;
        /// </summary>
        tail_not_Equality_Leave,
        /// <summary>
        /// &quot;%=&quot;
        /// </summary>
        tail_percent_Equality_Leave,
        /// <summary>
        /// &quot;^=&quot;
        /// </summary>
        tail_xor_Equality_Leave,
        /// <summary>
        /// &quot;&amp;=&quot;
        /// </summary>
        tail_and_Equality_Leave,
        /// <summary>
        /// &quot;*=&quot;
        /// </summary>
        tail_multiply_Equality_Leave,
        /// <summary>
        /// &quot;-=&quot;
        /// </summary>
        tail_minus_Equality_Leave,
        /// <summary>
        /// &quot;+=&quot;
        /// </summary>
        tail_plus_Equality_Leave,
        /// <summary>
        /// &quot;&lt;=&quot;
        /// </summary>
        tail_lessThan_Equality_Leave,
        /// <summary>
        /// &quot;&gt;=&quot;
        /// </summary>
        tail_greaterThan_Equality_Leave,
        /// <summary>
        /// &quot;/=&quot;
        /// </summary>
        tail_divide_Equality_Leave,
        /// <summary>
        /// &quot;&amp;&amp;&quot;
        /// </summary>
        tail_and_And_Leave,
        /// <summary>
        /// &quot;++&quot;
        /// </summary>
        tail_plus_Plus_Leave,
        /// <summary>
        /// &quot;&lt;&lt;&quot;
        /// </summary>
        tail_lessThan_LessThan_Leave,
        /// <summary>
        /// &quot;&gt;&gt;&quot;
        /// </summary>
        tail_greaterThan_GreaterThan_Leave,
        /// <summary>
        /// constString
        /// </summary>
        constStringLeave,
        /// <summary>
        /// identifier
        /// </summary>
        identifierLeave,
        /// <summary>
        /// number
        /// </summary>
        numberLeave,
        /// <summary>
        /// #
        /// </summary>
        tail_startEndLeave,
    }

}

