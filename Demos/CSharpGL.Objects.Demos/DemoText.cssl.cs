
namespace CSharpShadingLanguage.DemoText
{
	// 不可将此文件中的代码复制到其他文件内（如果包含了其他的using ...;，那么CSSL2GLSL.exe就无法正常编译这些代码了。）
    using CSharpShadingLanguage;

#if DEBUG

    class VS_GS_VERTEX
    {
        public vec3 normal;
    }
	
    class GS_FS_VERTEX
    {
        public vec3 color;
    }

    /// <summary>
    /// 一个<see cref="DemoTextVert"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// 这就是C#Shader形式的vertex shader。
    /// </summary>
    [Dump2File(true)]
	[GLSLVersion(GLSLVersion.v150)]
    sealed class DemoTextVert : VertexCSShaderCode
    {
        /// <summary>
        /// vertex's position.
        /// </summar>
        [In]
        vec3 in_Position;

        /// <summary>
        /// vertex's normal.
        /// </summar>
        [In]
        vec3 in_Normal;

        [Out]
        VS_GS_VERTEX vertex_out;

        /// <summary>
        /// scale, rotate and translate model.
        /// </summar>
        [Uniform]
        mat4 modelMatrix;

        /// <summary>
        /// setup camera's position, target and up.
        /// </summar>
        [Uniform]
        mat4 viewMatrix;

        /// <summary>
        /// project 3D scene to 2D screen.
        /// </summar>
        [Uniform]
        mat4 projectionMatrix;

        public override void main()
        {
            // TODO: this is where you should start with vertex shader. Only ASCII code are welcome.
            gl_Position = projectionMatrix * viewMatrix * modelMatrix * vec4(in_Position, 1.0f);

            vertex_out.normal = in_Normal;
            // this is where your vertex shader ends.
        }
    }

    /// <summary>
    /// 一个<see cref="DemoTextFrag"/>对应一个(vertex shader+fragment shader+..shader)组成的shader program。
    /// 这就是C#Shader形式的fragment shader。
    /// </summary>
    [Dump2File(true)]
	[GLSLVersion(GLSLVersion.v150)]
    sealed class DemoTextFrag : FragmentCSShaderCode
    {

        [In]
        GS_FS_VERTEX fragment_in;

        /// <summary>
        /// color that fragment shader dumped.
        /// </summar>
        [Out]
        vec4 outColor;

        public override void main()
        {
            // TODO: this is where you should start with fragment shader. Only ASCII code are welcome.
            vec3 color = fragment_in.color;
            if (color.r < 0) { color.r = -color.r; }
            if (color.g < 0) { color.g = -color.g; }
            if (color.b < 0) { color.b = -color.b; }
            outColor = vec4(color, 1.0f);
            // this is where your fragment shader ends.
        }
    }

	[Dump2File(true)]
	[GLSLVersion(GLSLVersion.v150)]
    sealed class DemoTextGeom : GeometryCSShaderCode
    {
        public override InType LayoutIn
        {
            get { return InType.triangles; }
        }

        public override OutType LayoutOut
        {
            get { return OutType.triangle_strip; }
        }

        public override int max_vertices
        {
            get { return 27; }
        }

        [In]
        VS_GS_VERTEX[] vertex_in;

        [Out]
        GS_FS_VERTEX vertex_out;

        [Uniform]
        float normalLength = 0.5f;

        /// <summary>
        /// scale, rotate and translate model.
        /// </summar>
        [Uniform]
        mat4 modelMatrix;

        /// <summary>
        /// setup camera's position, target and up.
        /// </summar>
        [Uniform]
        mat4 viewMatrix;

        /// <summary>
        /// project 3D scene to 2D screen.
        /// </summar>
        [Uniform]
        mat4 projectionMatrix;

        public override void main()
        {
            int i;

            for (i = 0; i < gl_in.length(); i++)
            {
                vertex_out.color = vertex_in[i].normal;
                vec4 position = gl_in[i].gl_Position;
                gl_Position = projectionMatrix * viewMatrix * (modelMatrix * position);
                EmitVertex();
            }
            EndPrimitive();

            for (i = 0; i < gl_in.length(); i++)
            {
                vertex_out.color = vec3(1, 1, 1);

                vec4 position = gl_in[i].gl_Position;
                vec4 target = vec4(position.xyz + vertex_in[i].normal * normalLength, 1.0f);
                {
                    vec4 v0 = position;
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v0);
                    EmitVertex();

                    vec4 v1 = target;
                    if (target.x > position.x) { v1.x += normalLength / 30.0f; }
                    else { v1.x -= normalLength / 10.0f; }
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v1);
                    EmitVertex();

                    vec4 v2 = position;
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v2);
                    EmitVertex();

                    vec4 v3 = target;
                    if (target.y > position.y) { v3.y += normalLength / 30.0f; }
                    else { v3.y -= normalLength / 10.0f; }
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v3);
                    EmitVertex();

                    vec4 v4 = position;
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v4);
                    EmitVertex();

                    vec4 v5 = target;
                    if (target.z > position.z) { v5.z += normalLength / 30.0f; }
                    else { v5.z -= normalLength / 10.0f; }
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v5);
                    EmitVertex();

                    vec4 v6 = position;
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v6);
                    EmitVertex();

                    vec4 v7 = target;
                    if (target.x > position.x) { v7.x += normalLength / 30.0f; }
                    else { v7.x -= normalLength / 10.0f; }
                    gl_Position = projectionMatrix * viewMatrix * (modelMatrix * v7);
                    EmitVertex();

                }

                EndPrimitive();
            }
        }
    }

#endif
}
