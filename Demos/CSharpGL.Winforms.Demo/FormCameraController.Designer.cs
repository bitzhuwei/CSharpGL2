﻿namespace CSharpGL.Winforms.Demo
{
    partial class FormCameraController
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
            this.cameraController1 = new CSharpGL.Objects.Controllers.CameraController();
            this.SuspendLayout();
            // 
            // cameraController1
            // 
            this.cameraController1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraController1.Location = new System.Drawing.Point(12, 12);
            this.cameraController1.Name = "cameraController1";
            this.cameraController1.Size = new System.Drawing.Size(972, 715);
            this.cameraController1.TabIndex = 0;
            this.cameraController1.TargetCamera = null;
            // 
            // FormCameraController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 739);
            this.Controls.Add(this.cameraController1);
            this.Name = "FormCameraController";
            this.Text = "FormCameraController";
            this.ResumeLayout(false);

        }

        #endregion

        private Objects.Controllers.CameraController cameraController1;
    }
}