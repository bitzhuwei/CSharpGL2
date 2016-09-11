namespace CSharpGL.Winforms.Demo
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.btnLegacySimpleUIRect = new System.Windows.Forms.Button();
            this.btnSimpleUIAxis = new System.Windows.Forms.Button();
            this.btnDebugging = new System.Windows.Forms.Button();
            this.btnFormLegacyTexture3D = new System.Windows.Forms.Button();
            this.btnFormColorCodedPicking = new System.Windows.Forms.Button();
            this.btnFormTransformFeedback = new System.Windows.Forms.Button();
            this.btnFormInstancedRendering = new System.Windows.Forms.Button();
            this.btnTexImage2D = new System.Windows.Forms.Button();
            this.btnFormLegacyTexture3D2 = new System.Windows.Forms.Button();
            this.btnFormVolumeRendering01 = new System.Windows.Forms.Button();
            this.btnFormVolumeRendering_Hexahedron = new System.Windows.Forms.Button();
            this.btnVR01_modernOpenGL_Quads = new System.Windows.Forms.Button();
            this.btnVR02_modernOpenGL_Points = new System.Windows.Forms.Button();
            this.btnFormVolumeRendering04 = new System.Windows.Forms.Button();
            this.btnFormVolumeRendering05 = new System.Windows.Forms.Button();
            this.btnFromShaderDesigner1594 = new System.Windows.Forms.Button();
            this.btnFormDoubleTexture = new System.Windows.Forms.Button();
            this.btnFormNormalLine = new System.Windows.Forms.Button();
            this.btnFormSimpleRenderer = new System.Windows.Forms.Button();
            this.btnFormNewNormalLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLegacySimpleUIRect
            // 
            this.btnLegacySimpleUIRect.Location = new System.Drawing.Point(10, 277);
            this.btnLegacySimpleUIRect.Name = "btnLegacySimpleUIRect";
            this.btnLegacySimpleUIRect.Size = new System.Drawing.Size(265, 23);
            this.btnLegacySimpleUIRect.TabIndex = 4;
            this.btnLegacySimpleUIRect.Text = "LegacySimpleUIRect";
            this.btnLegacySimpleUIRect.UseVisualStyleBackColor = true;
            this.btnLegacySimpleUIRect.Click += new System.EventHandler(this.btnLegacySimpleUIRect_Click);
            // 
            // btnSimpleUIAxis
            // 
            this.btnSimpleUIAxis.Location = new System.Drawing.Point(10, 336);
            this.btnSimpleUIAxis.Name = "btnSimpleUIAxis";
            this.btnSimpleUIAxis.Size = new System.Drawing.Size(265, 23);
            this.btnSimpleUIAxis.TabIndex = 4;
            this.btnSimpleUIAxis.Text = "SimpleUIAxis";
            this.btnSimpleUIAxis.UseVisualStyleBackColor = true;
            this.btnSimpleUIAxis.Click += new System.EventHandler(this.btnSimpleUIAxis_Click);
            // 
            // btnDebugging
            // 
            this.btnDebugging.Location = new System.Drawing.Point(10, 425);
            this.btnDebugging.Name = "btnDebugging";
            this.btnDebugging.Size = new System.Drawing.Size(265, 23);
            this.btnDebugging.TabIndex = 4;
            this.btnDebugging.Text = "Debugging and profiling";
            this.btnDebugging.UseVisualStyleBackColor = true;
            this.btnDebugging.Click += new System.EventHandler(this.btnDebugging_Click);
            // 
            // btnFormLegacyTexture3D
            // 
            this.btnFormLegacyTexture3D.Location = new System.Drawing.Point(10, 514);
            this.btnFormLegacyTexture3D.Name = "btnFormLegacyTexture3D";
            this.btnFormLegacyTexture3D.Size = new System.Drawing.Size(265, 23);
            this.btnFormLegacyTexture3D.TabIndex = 4;
            this.btnFormLegacyTexture3D.Text = "FormLegacyTexture3D";
            this.btnFormLegacyTexture3D.UseVisualStyleBackColor = true;
            this.btnFormLegacyTexture3D.Click += new System.EventHandler(this.btnFormLegacyTexture3D_Click);
            // 
            // btnFormColorCodedPicking
            // 
            this.btnFormColorCodedPicking.Location = new System.Drawing.Point(10, 543);
            this.btnFormColorCodedPicking.Name = "btnFormColorCodedPicking";
            this.btnFormColorCodedPicking.Size = new System.Drawing.Size(265, 23);
            this.btnFormColorCodedPicking.TabIndex = 4;
            this.btnFormColorCodedPicking.Text = "FormColorCodedPicking";
            this.btnFormColorCodedPicking.UseVisualStyleBackColor = true;
            this.btnFormColorCodedPicking.Click += new System.EventHandler(this.btnFormColorCodedPicking_Click);
            // 
            // btnFormTransformFeedback
            // 
            this.btnFormTransformFeedback.Location = new System.Drawing.Point(280, 40);
            this.btnFormTransformFeedback.Name = "btnFormTransformFeedback";
            this.btnFormTransformFeedback.Size = new System.Drawing.Size(260, 23);
            this.btnFormTransformFeedback.TabIndex = 4;
            this.btnFormTransformFeedback.Text = "FormTransformFeedback";
            this.btnFormTransformFeedback.UseVisualStyleBackColor = true;
            this.btnFormTransformFeedback.Click += new System.EventHandler(this.btnFormTransformFeedback_Click);
            // 
            // btnFormInstancedRendering
            // 
            this.btnFormInstancedRendering.Enabled = false;
            this.btnFormInstancedRendering.Location = new System.Drawing.Point(280, 70);
            this.btnFormInstancedRendering.Name = "btnFormInstancedRendering";
            this.btnFormInstancedRendering.Size = new System.Drawing.Size(260, 23);
            this.btnFormInstancedRendering.TabIndex = 4;
            this.btnFormInstancedRendering.Text = "FormInstancedRendering";
            this.btnFormInstancedRendering.UseVisualStyleBackColor = true;
            this.btnFormInstancedRendering.Click += new System.EventHandler(this.btnFormInstancedRendering_Click);
            // 
            // btnTexImage2D
            // 
            this.btnTexImage2D.Location = new System.Drawing.Point(10, 158);
            this.btnTexImage2D.Name = "btnTexImage2D";
            this.btnTexImage2D.Size = new System.Drawing.Size(265, 23);
            this.btnTexImage2D.TabIndex = 1;
            this.btnTexImage2D.Text = "TexImage2D";
            this.btnTexImage2D.UseVisualStyleBackColor = true;
            this.btnTexImage2D.Click += new System.EventHandler(this.btnTexImage2D_Click);
            // 
            // btnFormLegacyTexture3D2
            // 
            this.btnFormLegacyTexture3D2.Location = new System.Drawing.Point(280, 188);
            this.btnFormLegacyTexture3D2.Name = "btnFormLegacyTexture3D2";
            this.btnFormLegacyTexture3D2.Size = new System.Drawing.Size(260, 23);
            this.btnFormLegacyTexture3D2.TabIndex = 4;
            this.btnFormLegacyTexture3D2.Text = "FormLegacyTexture3D-2";
            this.btnFormLegacyTexture3D2.UseVisualStyleBackColor = true;
            this.btnFormLegacyTexture3D2.Click += new System.EventHandler(this.btnFormLegacyTexture3D2_Click);
            // 
            // btnFormVolumeRendering01
            // 
            this.btnFormVolumeRendering01.Location = new System.Drawing.Point(280, 218);
            this.btnFormVolumeRendering01.Name = "btnFormVolumeRendering01";
            this.btnFormVolumeRendering01.Size = new System.Drawing.Size(260, 23);
            this.btnFormVolumeRendering01.TabIndex = 4;
            this.btnFormVolumeRendering01.Text = "FormVolumeRendering00-legacy opengl";
            this.btnFormVolumeRendering01.UseVisualStyleBackColor = true;
            this.btnFormVolumeRendering01.Click += new System.EventHandler(this.btnFormVolumeRendering01_Click);
            // 
            // btnFormVolumeRendering_Hexahedron
            // 
            this.btnFormVolumeRendering_Hexahedron.Location = new System.Drawing.Point(280, 306);
            this.btnFormVolumeRendering_Hexahedron.Name = "btnFormVolumeRendering_Hexahedron";
            this.btnFormVolumeRendering_Hexahedron.Size = new System.Drawing.Size(260, 23);
            this.btnFormVolumeRendering_Hexahedron.TabIndex = 4;
            this.btnFormVolumeRendering_Hexahedron.Text = "FormVolumeRendering03-hexahedron";
            this.btnFormVolumeRendering_Hexahedron.UseVisualStyleBackColor = true;
            this.btnFormVolumeRendering_Hexahedron.Click += new System.EventHandler(this.btnFormVolumeRendering_Hexahedron_Click);
            // 
            // btnVR01_modernOpenGL_Quads
            // 
            this.btnVR01_modernOpenGL_Quads.Location = new System.Drawing.Point(280, 247);
            this.btnVR01_modernOpenGL_Quads.Name = "btnVR01_modernOpenGL_Quads";
            this.btnVR01_modernOpenGL_Quads.Size = new System.Drawing.Size(260, 23);
            this.btnVR01_modernOpenGL_Quads.TabIndex = 4;
            this.btnVR01_modernOpenGL_Quads.Text = "FormVolumeRendering01-quads";
            this.btnVR01_modernOpenGL_Quads.UseVisualStyleBackColor = true;
            this.btnVR01_modernOpenGL_Quads.Click += new System.EventHandler(this.btnVR01_modernOpenGL_Quads_Click);
            // 
            // btnVR02_modernOpenGL_Points
            // 
            this.btnVR02_modernOpenGL_Points.Location = new System.Drawing.Point(280, 277);
            this.btnVR02_modernOpenGL_Points.Name = "btnVR02_modernOpenGL_Points";
            this.btnVR02_modernOpenGL_Points.Size = new System.Drawing.Size(260, 23);
            this.btnVR02_modernOpenGL_Points.TabIndex = 4;
            this.btnVR02_modernOpenGL_Points.Text = "FormVolumeRendering02-points";
            this.btnVR02_modernOpenGL_Points.UseVisualStyleBackColor = true;
            this.btnVR02_modernOpenGL_Points.Click += new System.EventHandler(this.btnVR02_modernOpenGL_Points_Click);
            // 
            // btnFormVolumeRendering04
            // 
            this.btnFormVolumeRendering04.Location = new System.Drawing.Point(280, 336);
            this.btnFormVolumeRendering04.Name = "btnFormVolumeRendering04";
            this.btnFormVolumeRendering04.Size = new System.Drawing.Size(260, 23);
            this.btnFormVolumeRendering04.TabIndex = 4;
            this.btnFormVolumeRendering04.Text = "FormVolumeRendering04-doubleRender-quads";
            this.btnFormVolumeRendering04.UseVisualStyleBackColor = true;
            this.btnFormVolumeRendering04.Click += new System.EventHandler(this.btnFormVolumeRendering04_Click);
            // 
            // btnFormVolumeRendering05
            // 
            this.btnFormVolumeRendering05.Location = new System.Drawing.Point(280, 366);
            this.btnFormVolumeRendering05.Name = "btnFormVolumeRendering05";
            this.btnFormVolumeRendering05.Size = new System.Drawing.Size(260, 23);
            this.btnFormVolumeRendering05.TabIndex = 4;
            this.btnFormVolumeRendering05.Text = "FormVolumeRendering05-how-many-points";
            this.btnFormVolumeRendering05.UseVisualStyleBackColor = true;
            this.btnFormVolumeRendering05.Click += new System.EventHandler(this.btnFormVolumeRendering05_Click);
            // 
            // btnFromShaderDesigner1594
            // 
            this.btnFromShaderDesigner1594.Location = new System.Drawing.Point(280, 395);
            this.btnFromShaderDesigner1594.Name = "btnFromShaderDesigner1594";
            this.btnFromShaderDesigner1594.Size = new System.Drawing.Size(260, 23);
            this.btnFromShaderDesigner1594.TabIndex = 4;
            this.btnFromShaderDesigner1594.Text = "FromShaderDesigner1.5.9.4";
            this.btnFromShaderDesigner1594.UseVisualStyleBackColor = true;
            this.btnFromShaderDesigner1594.Click += new System.EventHandler(this.btnFromShaderDesigner1594_Click);
            // 
            // btnFormDoubleTexture
            // 
            this.btnFormDoubleTexture.Location = new System.Drawing.Point(280, 425);
            this.btnFormDoubleTexture.Name = "btnFormDoubleTexture";
            this.btnFormDoubleTexture.Size = new System.Drawing.Size(260, 23);
            this.btnFormDoubleTexture.TabIndex = 4;
            this.btnFormDoubleTexture.Text = "FormDoubleTexture";
            this.btnFormDoubleTexture.UseVisualStyleBackColor = true;
            this.btnFormDoubleTexture.Click += new System.EventHandler(this.btnFormDoubleTexture_Click);
            // 
            // btnFormNormalLine
            // 
            this.btnFormNormalLine.Location = new System.Drawing.Point(280, 454);
            this.btnFormNormalLine.Name = "btnFormNormalLine";
            this.btnFormNormalLine.Size = new System.Drawing.Size(260, 23);
            this.btnFormNormalLine.TabIndex = 4;
            this.btnFormNormalLine.Text = "FormNormalLine";
            this.btnFormNormalLine.UseVisualStyleBackColor = true;
            this.btnFormNormalLine.Click += new System.EventHandler(this.btnFormNormalLine_Click);
            // 
            // btnFormSimpleRenderer
            // 
            this.btnFormSimpleRenderer.Location = new System.Drawing.Point(280, 484);
            this.btnFormSimpleRenderer.Name = "btnFormSimpleRenderer";
            this.btnFormSimpleRenderer.Size = new System.Drawing.Size(260, 23);
            this.btnFormSimpleRenderer.TabIndex = 4;
            this.btnFormSimpleRenderer.Text = "FormSimpleRenderer";
            this.btnFormSimpleRenderer.UseVisualStyleBackColor = true;
            this.btnFormSimpleRenderer.Click += new System.EventHandler(this.btnFormSimpleRenderer_Click);
            // 
            // btnFormNewNormalLine
            // 
            this.btnFormNewNormalLine.Location = new System.Drawing.Point(280, 514);
            this.btnFormNewNormalLine.Name = "btnFormNewNormalLine";
            this.btnFormNewNormalLine.Size = new System.Drawing.Size(260, 23);
            this.btnFormNewNormalLine.TabIndex = 4;
            this.btnFormNewNormalLine.Text = "FormNewNormalLine";
            this.btnFormNewNormalLine.UseVisualStyleBackColor = true;
            this.btnFormNewNormalLine.Click += new System.EventHandler(this.btnFormNewNormalLine_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 576);
            this.Controls.Add(this.btnTexImage2D);
            this.Controls.Add(this.btnFormInstancedRendering);
            this.Controls.Add(this.btnFormTransformFeedback);
            this.Controls.Add(this.btnFormColorCodedPicking);
            this.Controls.Add(this.btnFormSimpleRenderer);
            this.Controls.Add(this.btnFormNewNormalLine);
            this.Controls.Add(this.btnFormNormalLine);
            this.Controls.Add(this.btnFormDoubleTexture);
            this.Controls.Add(this.btnFromShaderDesigner1594);
            this.Controls.Add(this.btnFormVolumeRendering05);
            this.Controls.Add(this.btnFormVolumeRendering04);
            this.Controls.Add(this.btnFormVolumeRendering_Hexahedron);
            this.Controls.Add(this.btnVR02_modernOpenGL_Points);
            this.Controls.Add(this.btnVR01_modernOpenGL_Quads);
            this.Controls.Add(this.btnFormVolumeRendering01);
            this.Controls.Add(this.btnFormLegacyTexture3D2);
            this.Controls.Add(this.btnFormLegacyTexture3D);
            this.Controls.Add(this.btnDebugging);
            this.Controls.Add(this.btnSimpleUIAxis);
            this.Controls.Add(this.btnLegacySimpleUIRect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTest";
            this.Text = "测试窗口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLegacySimpleUIRect;
        private System.Windows.Forms.Button btnSimpleUIAxis;
        private System.Windows.Forms.Button btnDebugging;
        private System.Windows.Forms.Button btnFormLegacyTexture3D;
        private System.Windows.Forms.Button btnFormColorCodedPicking;
        private System.Windows.Forms.Button btnFormTransformFeedback;
        private System.Windows.Forms.Button btnFormInstancedRendering;
        private System.Windows.Forms.Button btnTexImage2D;
        private System.Windows.Forms.Button btnFormLegacyTexture3D2;
        private System.Windows.Forms.Button btnFormVolumeRendering01;
        private System.Windows.Forms.Button btnFormVolumeRendering_Hexahedron;
        private System.Windows.Forms.Button btnVR01_modernOpenGL_Quads;
        private System.Windows.Forms.Button btnVR02_modernOpenGL_Points;
        private System.Windows.Forms.Button btnFormVolumeRendering04;
        private System.Windows.Forms.Button btnFormVolumeRendering05;
        private System.Windows.Forms.Button btnFromShaderDesigner1594;
        private System.Windows.Forms.Button btnFormDoubleTexture;
        private System.Windows.Forms.Button btnFormNormalLine;
        private System.Windows.Forms.Button btnFormSimpleRenderer;
        private System.Windows.Forms.Button btnFormNewNormalLine;
    }
}