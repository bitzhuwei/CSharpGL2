﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpGL.Winforms.Demo
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnLegacySimpleUIRect_Click(object sender, EventArgs e)
        {
            (new FormLegacySimpleUIRect()).Show();
            //string message = string.Format("{0}", "This is no longer useful!");
            //MessageBox.Show(message, "tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSimpleUIAxis_Click(object sender, EventArgs e)
        {
            (new FormSimpleUIAxis()).Show();
            //(new FormSimpleUIAxis2()).Show();
        }

        private void btnDebugging_Click(object sender, EventArgs e)
        {
            (new FormDebugging()).Show();
        }

        private void btnFormLegacyTexture3D_Click(object sender, EventArgs e)
        {
            (new FormLegacyTexture3D()).Show();
        }

        private void btnFormColorCodedPicking_Click(object sender, EventArgs e)
        {
            (new FormColorCodedPicking()).Show();
        }

        private void btnFormTransformFeedback_Click(object sender, EventArgs e)
        {
            (new FormTransformFeedback()).Show();
        }

        private void btnFormInstancedRendering_Click(object sender, EventArgs e)
        {

        }

        private void btnTexImage2D_Click(object sender, EventArgs e)
        {
            (new FormTexImage2D()).Show();
        }

        private void btnFormLegacyTexture3D2_Click(object sender, EventArgs e)
        {
            (new FormLegacyTexture3D2()).Show();
        }

        private void btnFormVolumeRendering01_Click(object sender, EventArgs e)
        {
            (new FormVolumeRendering00()).Show();
        }


        private void btnVR01_modernOpenGL_Quads_Click(object sender, EventArgs e)
        {
            (new FormVolumeRendering01()).Show();
        }

        private void btnVR02_modernOpenGL_Points_Click(object sender, EventArgs e)
        {
            (new FormVolumeRendering02()).Show();
        }

        private void btnFormVolumeRendering_Hexahedron_Click(object sender, EventArgs e)
        {
            (new FormVolumeRendering03()).Show();
        }

        private void btnFormVolumeRendering04_Click(object sender, EventArgs e)
        {
            (new FormVolumeRendering04()).Show();
        }

        private void btnFormVolumeRendering05_Click(object sender, EventArgs e)
        {
            (new FormVolumeRendering05()).Show();
        }

        private void btnFromShaderDesigner1594_Click(object sender, EventArgs e)
        {
            //(new FormShaderDesigner1594Demos.FormDemosPanel()).Show();
        }

        private void btnFormDoubleTexture_Click(object sender, EventArgs e)
        {
            (new FormDoubleTexture()).Show();
        }

        private void btnFormNormalLine_Click(object sender, EventArgs e)
        {
            (new FormNormalLine()).Show();
        }

        private void btnFormSimpleRenderer_Click(object sender, EventArgs e)
        {

            (new FormSimpleRenderer()).Show();
        }

        private void btnFormNewNormalLine_Click(object sender, EventArgs e)
        {
            (new FormNewNormalLine()).Show();
        }

        private void btnCamera_Click(object sender, EventArgs e)
        {

        }

    }
}
