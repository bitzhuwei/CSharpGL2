﻿using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    /// <summary>
    /// shader中的一个uniform变量。
    /// </summary>
    public abstract class UniformVariable
    {

        /// <summary>
        /// 变量名。
        /// </summary>
        public string VarName { get; private set; }

        /// <summary>
        /// 已更新（需要在render时提交到GPU）
        /// </summary>
        public bool Updated { get; set; }

        /// <summary>
        /// shader中的一个uniform变量。
        /// </summary>
        /// <param name="varName"></param>
        public UniformVariable(string varName)
        {
            this.VarName = varName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        internal abstract bool SetValue(ValueType value);

        public abstract ValueType GetValue();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="program"></param>
        public abstract void SetUniform(ShaderProgram program);

        public virtual void ResetUniform(ShaderProgram program) { }

        public override string ToString()
        {
            return string.Format("{0}: {1}", this.VarName, this.GetValue());
        }

    }


    public struct samplerValue
    {
        public uint name;
        public ActiveTextureIndex index;

        public samplerValue(uint name, ActiveTextureIndex index)
        {
            this.name = name;
            this.index = index;
        }

        public override string ToString()
        {
            return string.Format("name:{0} index:{1}", name, index);
        }

        public static bool operator ==(samplerValue left, samplerValue right)
        {
            object leftObj = left, rightObj = right;
            if (leftObj == null)
            {
                if (rightObj == null) { return true; }
                else { return false; }
            }
            else
            {
                if (rightObj == null) { return false; }
            }

            return left.Equals(right);
        }

        public static bool operator !=(samplerValue left, samplerValue right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            var p = (samplerValue)obj;

            //return this.HashCode == p.HashCode;
            return (this.index == p.index && this.name == p.name);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
    public class UniformSampler2D : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private samplerValue Value;

        public UniformSampler2D(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            GL.GetDelegateFor<GL.glActiveTexture>()((uint)Value.index);
            GL.Enable(GL.GL_TEXTURE_2D);
            GL.BindTexture(GL.GL_TEXTURE_2D, Value.name);
            program.SetUniform(VarName, (int)((uint)Value.index - GL.GL_TEXTURE0));
        }

        public override void ResetUniform(ShaderProgram program)
        {
            GL.BindTexture(GL.GL_TEXTURE_2D, 0);
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(samplerValue))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (samplerValue)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetsamplerValue(samplerValue value)
        {
            var v = (samplerValue)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public samplerValue GetsamplerValue()
        {
            return Value;
        }
    }
    public class UniformFloat : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private float Value;

        public UniformFloat(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            program.SetUniform(VarName, Value);
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(float))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (float)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetFloat(float value)
        {
            var v = (float)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public float GetFloat()
        {
            return Value;
        }
    }

    public class UniformVec2 : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private vec2 Value;

        public UniformVec2(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            vec2 value = this.Value;
            program.SetUniform(VarName, value.x, value.y);
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(vec2))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (vec2)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetVec2(vec2 value)
        {
            var v = (vec2)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public vec2 GetVec2()
        {
            return Value;
        }
    }

    public class UniformVec3 : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private vec3 Value;

        public UniformVec3(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            vec3 value = this.Value;
            program.SetUniform(VarName, value.x, value.y, value.z);
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(vec3))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (vec3)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetVec3(vec3 value)
        {
            var v = (vec3)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public vec3 GetVec3()
        {
            return Value;
        }
    }

    public class UniformVec4 : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private vec4 Value;

        public UniformVec4(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            vec4 value = this.Value;
            program.SetUniform(VarName, value.x, value.y, value.z, value.w);
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(vec4))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (vec4)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetVec4(vec4 value)
        {
            var v = (vec4)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public vec4 GetVec4()
        {
            return Value;
        }
    }

    public class UniformMat2 : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private mat2 Value;

        public UniformMat2(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            program.SetUniformMatrix2(VarName, this.Value.to_array());
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(mat2))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (mat2)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetMat2(mat2 value)
        {
            var v = (mat2)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public mat2 GetMat2()
        {
            return Value;
        }
    }

    public class UniformMat3 : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private mat3 Value;

        public UniformMat3(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            program.SetUniformMatrix3(VarName, this.Value.to_array());
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(mat3))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (mat3)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetMat3(mat3 value)
        {
            var v = (mat3)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public mat3 GetMat3()
        {
            return Value;
        }
    }

    public class UniformMat4 : UniformVariable
    {

        /// <summary>
        /// 用字段减少复制，提升效率。
        /// </summary>
        private mat4 Value;

        public UniformMat4(string varName) : base(varName) { }

        public override void SetUniform(ShaderProgram program)
        {
            program.SetUniformMatrix4(VarName, this.Value.to_array());
        }

        internal override bool SetValue(ValueType value)
        {
            if (value.GetType() != typeof(mat4))
            {
                throw new ArgumentException(string.Format("[{0}] not match [{1}]'s value.",
                    value.GetType().Name, this.GetType().Name));
            }

            var v = (mat4)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ValueType GetValue()
        {
            return Value;
        }

        public void SetMat4(mat4 value)
        {
            var v = (mat4)value;
            if (v != this.Value)
            {
                this.Value = v;
                this.Updated = true;
            }
        }

        public mat4 GetMat4()
        {
            return Value;
        }

    }
}