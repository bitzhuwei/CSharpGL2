﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL.Objects.Shaders
{
    public class TransformShaderProgram
    {
        private readonly Shader vertexShader = new Shader();

        /// <summary>
        /// Creates the shader program.
        /// </summary>
        /// <param name="vertexShaderSource">The vertex shader source.</param>
        /// <param name="fragmentShaderSource">The fragment shader source.</param>
        /// <param name="attributeLocations">The attribute locations. This is an optional array of
        /// uint attribute locations to their names.</param>
        /// <exception cref="ShaderCompilationException"></exception>
        public void Create(string vertexShaderSource)
        {
            //  Create the shaders.
            vertexShader.Create(GL.GL_VERTEX_SHADER, vertexShaderSource);

            //  Create the program, attach the shaders.
            ShaderProgramObject = GL.CreateProgram();
            GL.AttachShader(ShaderProgramObject, vertexShader.ShaderObject);

            var varyings = new string[] { "gl_Position", "block.Color" };
            GL.TransformFeedbackVaryings(ShaderProgramObject, 2, varyings, GL.GL_INTERLEAVED_ATTRIBS);

            //  Now we can link the program.
            GL.LinkProgram(ShaderProgramObject);

            //  Now that we've compiled and linked the shader, check it's link status. If it's not linked properly, we're
            //  going to throw an exception.
            if (GetLinkStatus() == false)
            {
                throw new ShaderCompilationException(string.Format("Failed to link shader program with ID {0}.", ShaderProgramObject), GetInfoLog());
            }
        }

        public void Delete()
        {
            GL.DetachShader(ShaderProgramObject, vertexShader.ShaderObject);
            vertexShader.Delete();
            GL.DeleteProgram(ShaderProgramObject);
            ShaderProgramObject = 0;
        }

        public uint GetAttributeLocation(string attributeName)
        {
            //  If we don't have the attribute name in the dictionary, get it's
            //  location and add it.
            if (attributeNamesToLocations.ContainsKey(attributeName) == false)
            {
                int location = GL.GetAttribLocation(ShaderProgramObject, attributeName);
                if (location < 0) { throw new Exception(); }

                attributeNamesToLocations[attributeName] = (uint)location;
            }

            //  Return the attribute location.
            return attributeNamesToLocations[attributeName];
        }

        public void BindAttributeLocation(uint location, string attribute)
        {
            GL.BindAttribLocation(ShaderProgramObject, location, attribute);
        }

        public void Bind()
        {
            GL.UseProgram(ShaderProgramObject);
        }

        public void Unbind()
        {
            GL.UseProgram(0);
        }

        public bool GetLinkStatus()
        {
            int[] parameters = new int[] { 0 };
            GL.GetProgram(ShaderProgramObject, GL.GL_LINK_STATUS, parameters);
            return parameters[0] == GL.GL_TRUE;
        }

        public string GetInfoLog()
        {
            //  Get the info log length.
            int[] infoLength = new int[] { 0 };
            GL.GetProgram(ShaderProgramObject, GL.GL_INFO_LOG_LENGTH, infoLength);
            int bufSize = infoLength[0];

            //  Get the compile info.
            StringBuilder il = new StringBuilder(bufSize);
            GL.GetProgramInfoLog(ShaderProgramObject, bufSize, IntPtr.Zero, il);

            string log = il.ToString();
            return log;
        }

        public void AssertValid()
        {
            if (vertexShader.GetCompileStatus() == false)
            {
                string log = vertexShader.GetInfoLog();
                throw new Exception(log);
            }

            if (GetLinkStatus() == false)
            {
                string log = GetInfoLog();
                throw new Exception(log);
            }
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        public void SetUniform(string uniformName, int v1)
        {
            GL.Uniform1(GetUniformLocation(uniformName), v1);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        public void SetUniform(string uniformName, int v1, int v2)
        {
            GL.Uniform2(GetUniformLocation(uniformName), v1, v2);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        public void SetUniform(string uniformName, int v1, int v2, int v3)
        {
            GL.Uniform3(GetUniformLocation(uniformName), v1, v2, v3);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <param name="v4"></param>
        public void SetUniform(string uniformName, int v1, int v2, int v3, int v4)
        {
            GL.Uniform4(GetUniformLocation(uniformName), v1, v2, v3, v4);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        public void SetUniform(string uniformName, float v1)
        {
            GL.Uniform1(GetUniformLocation(uniformName), v1);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        public void SetUniform(string uniformName, float v1, float v2)
        {
            GL.Uniform2(GetUniformLocation(uniformName), v1, v2);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        public void SetUniform(string uniformName, float v1, float v2, float v3)
        {
            GL.Uniform3(GetUniformLocation(uniformName), v1, v2, v3);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <param name="v4"></param>
        public void SetUniform(string uniformName, float v1, float v2, float v3, float v4)
        {
            GL.Uniform4(GetUniformLocation(uniformName), v1, v2, v3, v4);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="m"></param>
        public void SetUniformMatrix3(string uniformName, float[] m)
        {
            GL.UniformMatrix3(GetUniformLocation(uniformName), 1, false, m);
        }

        /// <summary>
        /// 请注意你的数据类型最终将转换为int还是float
        /// </summary>
        /// <param name="uniformName"></param>
        /// <param name="m"></param>
        public void SetUniformMatrix4(string uniformName, float[] m)
        {
            GL.UniformMatrix4(GetUniformLocation(uniformName), 1, false, m);
        }

        public int GetUniformLocation(string uniformName)
        {
            //  If we don't have the uniform name in the dictionary, get it's
            //  location and add it.
            if (uniformNamesToLocations.ContainsKey(uniformName) == false)
            {
                int location = GL.GetUniformLocation(ShaderProgramObject, uniformName);
                if (location < 0)
                { throw new Exception(string.Format("invalid uniform name [{0}]'s location [{1}]", uniformName, location)); }
                else
                {
                    uniformNamesToLocations[uniformName] = location;
                }
            }

            //  Return the uniform location.
            return uniformNamesToLocations[uniformName];
        }

        /// <summary>
        /// Gets the shader program object.
        /// </summary>
        /// <value>
        /// The shader program object.
        /// </value>
        public uint ShaderProgramObject { get; protected set; }


        /// <summary>
        /// A mapping of uniform names to locations. This allows us to very easily specify
        /// uniform data by name, quickly looking up the location first if needed.
        /// </summary>
        private readonly Dictionary<string, int> uniformNamesToLocations = new Dictionary<string, int>();

        /// <summary>
        /// A mapping of attribute names to locations. This allows us to very easily specify
        /// attribute data by name, quickly looking up the location first if needed.
        /// </summary>
        private readonly Dictionary<string, uint> attributeNamesToLocations = new Dictionary<string, uint>();
    }
}
