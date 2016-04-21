using GLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public partial class ModernRenderer 
    {
        private List<UniformVariableBase> uniformVariables = new List<UniformVariableBase>();

        protected OrderedCollection<string> uniformVariableNames = new OrderedCollection<string>(", ");

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

    }
}
