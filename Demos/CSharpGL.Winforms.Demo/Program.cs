using GLM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Winforms.Demo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            float max = 0;
            vec3 maxCondition = new vec3();
            for (float r = 0; r < 1; r += 0.01f)
            {
                for (float g = 0; g < 1; g += 0.01f)
                {
                    for (float b = 0; b < 1; b += 0.01f)
                    {
                        float variance = (r - g) * (r - g) + (g - b) * (g - b) + (b - r) * (b - r);
                        if (max < variance)
                        {
                            max = variance;
                            maxCondition = new vec3(r, g, b);
                        }
                    }
                }
            }
            Console.WriteLine(max);
            //MoveGLPrefix();
            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormTest());
            //Application.Run(new FormColorCodedPicking());
        }

        /// <summary>
        /// 给GL_Functions.cs里的glXxx添加EntryPoint
        /// </summary>
        static void MoveGLPrefix()
        {
            using (StreamReader sr = new StreamReader("GL_Functions.cs"))
            {
                using (StreamWriter sw = new StreamWriter("GL_Functions2.cs"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains("DllImport"))
                        {
                            int entryPointIndex = line.IndexOf("Win32.OpenGL32,") + "Win32.OpenGL32,".Length;
                            string nextLine = sr.ReadLine();
                            int glIndex = nextLine.IndexOf("gl") + "gl".Length;
                            int leftParenthesesIndex = nextLine.IndexOf("(");
                            sw.Write(line.Substring(0, entryPointIndex));
                            sw.Write(" EntryPoint=\"");
                            sw.Write(nextLine.Substring(glIndex - 2, leftParenthesesIndex - (glIndex - 2)));
                            sw.Write("\", ");
                            sw.WriteLine(line.Substring(entryPointIndex));
                            sw.Write(nextLine.Substring(0, glIndex - 2));
                            sw.WriteLine(nextLine.Substring(glIndex));
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
