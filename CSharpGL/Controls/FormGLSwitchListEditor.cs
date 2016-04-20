using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL
{
    public partial class FormGLSwitchListEditor : Form
    {
        private List<GLSwitch> list;

        public FormGLSwitchListEditor(List<GLSwitch> list)
        {
            InitializeComponent();
            this.list = new List<GLSwitch>(list);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmSelectType = new FormGLSwtichType();
            if (frmSelectType.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Type type = frmSelectType.SelectedType;
                object obj = Activator.CreateInstance(type);
                this.lstMember.Items.Add(obj);
                this.propertyGrid.SelectedObject = obj;
            }
        }
    }
}
