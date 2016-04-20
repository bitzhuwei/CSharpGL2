using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Demos
{
    public partial class FormBulletinBoard : Form
    {
        public FormBulletinBoard()
        {
            InitializeComponent();
        }

        public void SetContent(string str)
        {
            this.textBox1.Text = str;
        }
    }
}
