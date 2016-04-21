// 此文件由CSharpGL.CSSLGenerator.exe生成。
// 用法：使用CSSL2GLSL.exe编译此文件，即可获得对应的vertex shader, geometry shader, fragment shader。
// 此文件中的类型不应被直接调用，发布release时可以去掉。
// 不可将此文件中的代码复制到其他文件内（如果包含了其他的using ...;，那么CSSL2GLSL.exe就无法正常编译这些代码了。）
namespace CSharpShadingLanguage.SomeShader
{
    using CSharpShadingLanguage;
    
    
    public class VS_GS_Vertex
    {
        
        private vec3 position;
        
        private vec3 normal;
        
        private vec3 color;
    }
    
    public class GS_FS_Vertex
    {
        
        private vec3 color;
    }
    
    /// <summary>
    /// 一个<see cref="SomeShaderVert"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// (GLSLVersion)0 is GLSLVersion.v150
    /// </summary>
    [CSharpShadingLanguage.Dump2FileAttribute(true)]
    [CSharpShadingLanguage.GLSLVersionAttribute(((CSharpShadingLanguage.GLSLVersion)(0u)))]
    public class SomeShaderVert : CSharpShadingLanguage.VertexCSShaderCode
    {
        
        [CSharpShadingLanguage.InAttribute()]
        private vec3 position;
        
        [CSharpShadingLanguage.InAttribute()]
        private vec3 color;
        
        [CSharpShadingLanguage.OutAttribute()]
        private vec3 passColor;
        
        [CSharpShadingLanguage.UniformAttribute()]
        private mat4 projectionMatrix;
        
        [CSharpShadingLanguage.UniformAttribute()]
        private mat4 viewMatrix;
        
        [CSharpShadingLanguage.UniformAttribute()]
        private mat4 modelMatrix;
        
        [CSharpShadingLanguage.OutAttribute()]
        private VS_GS_Vertex vertexOut;
        
        public override void main()
        {
        }
    }
    
    /// <summary>
    /// 一个<see cref="SomeShaderGeom"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// (GLSLVersion)0 is GLSLVersion.v150
    /// </summary>
    [CSharpShadingLanguage.Dump2FileAttribute(true)]
    [CSharpShadingLanguage.GLSLVersionAttribute(((CSharpShadingLanguage.GLSLVersion)(0u)))]
    public class SomeShaderGeom : CSharpShadingLanguage.GeometryCSShaderCode
    {
        
        [CSharpShadingLanguage.UniformAttribute()]
        private mat4 projectionMatrix;
        
        [CSharpShadingLanguage.UniformAttribute()]
        private mat4 viewMatrix;
        
        [CSharpShadingLanguage.UniformAttribute()]
        private mat4 modelMatrix;
        
        [CSharpShadingLanguage.InAttribute()]
        private VS_GS_Vertex vertexIn;
        
        [CSharpShadingLanguage.OutAttribute()]
        private GS_FS_Vertex vertexOut;
        
        public override void main()
        {
        }
    }
    
    /// <summary>
    /// 一个<see cref="SomeShaderFrag"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// (GLSLVersion)0 is GLSLVersion.v150
    /// </summary>
    [CSharpShadingLanguage.Dump2FileAttribute(true)]
    [CSharpShadingLanguage.GLSLVersionAttribute(((CSharpShadingLanguage.GLSLVersion)(0u)))]
    public class SomeShaderFrag : CSharpShadingLanguage.FragmentCSShaderCode
    {
        
        [CSharpShadingLanguage.InAttribute()]
        private vec3 passColor;
        
        [CSharpShadingLanguage.OutAttribute()]
        private vec4 outputColor;
        
        [CSharpShadingLanguage.InAttribute()]
        private GS_FS_Vertex vertexIn;
        
        public override void main()
        {
        }
    }
}
