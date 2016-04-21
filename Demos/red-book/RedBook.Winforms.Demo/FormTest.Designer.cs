﻿namespace RedBook.Winforms.Demo
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
            this.btnLightingExample = new System.Windows.Forms.Button();
            this.btnTeapotExample = new System.Windows.Forms.Button();
            this.btnFurRendering = new System.Windows.Forms.Button();
            this.btnParticleSimulatorExample = new System.Windows.Forms.Button();
            this.btnInstancedRendering = new System.Windows.Forms.Button();
            this.btnCubeMap = new System.Windows.Forms.Button();
            this.btnLoadTexture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLightingExample
            // 
            this.btnLightingExample.Location = new System.Drawing.Point(12, 12);
            this.btnLightingExample.Name = "btnLightingExample";
            this.btnLightingExample.Size = new System.Drawing.Size(254, 23);
            this.btnLightingExample.TabIndex = 0;
            this.btnLightingExample.Text = "LightingExample";
            this.btnLightingExample.UseVisualStyleBackColor = true;
            this.btnLightingExample.Click += new System.EventHandler(this.btnLightingExample_Click);
            // 
            // btnTeapotExample
            // 
            this.btnTeapotExample.Enabled = false;
            this.btnTeapotExample.Location = new System.Drawing.Point(12, 41);
            this.btnTeapotExample.Name = "btnTeapotExample";
            this.btnTeapotExample.Size = new System.Drawing.Size(254, 23);
            this.btnTeapotExample.TabIndex = 0;
            this.btnTeapotExample.Text = "TeapotExample";
            this.btnTeapotExample.UseVisualStyleBackColor = true;
            this.btnTeapotExample.Click += new System.EventHandler(this.btnTeapotExample_Click);
            // 
            // btnFurRendering
            // 
            this.btnFurRendering.Location = new System.Drawing.Point(12, 70);
            this.btnFurRendering.Name = "btnFurRendering";
            this.btnFurRendering.Size = new System.Drawing.Size(254, 23);
            this.btnFurRendering.TabIndex = 0;
            this.btnFurRendering.Text = "Fur Rendering";
            this.btnFurRendering.UseVisualStyleBackColor = true;
            this.btnFurRendering.Click += new System.EventHandler(this.btnFurRendering_Click);
            // 
            // btnParticleSimulatorExample
            // 
            this.btnParticleSimulatorExample.Location = new System.Drawing.Point(12, 99);
            this.btnParticleSimulatorExample.Name = "btnParticleSimulatorExample";
            this.btnParticleSimulatorExample.Size = new System.Drawing.Size(254, 23);
            this.btnParticleSimulatorExample.TabIndex = 0;
            this.btnParticleSimulatorExample.Text = "ParticleSimulatorExample";
            this.btnParticleSimulatorExample.UseVisualStyleBackColor = true;
            this.btnParticleSimulatorExample.Click += new System.EventHandler(this.btnParticleSimulatorExample_Click);
            // 
            // btnInstancedRendering
            // 
            this.btnInstancedRendering.Location = new System.Drawing.Point(12, 128);
            this.btnInstancedRendering.Name = "btnInstancedRendering";
            this.btnInstancedRendering.Size = new System.Drawing.Size(254, 23);
            this.btnInstancedRendering.TabIndex = 0;
            this.btnInstancedRendering.Text = "InstancedRendering";
            this.btnInstancedRendering.UseVisualStyleBackColor = true;
            this.btnInstancedRendering.Click += new System.EventHandler(this.btnInstancedRendering_Click);
            // 
            // btnCubeMap
            // 
            this.btnCubeMap.Location = new System.Drawing.Point(12, 157);
            this.btnCubeMap.Name = "btnCubeMap";
            this.btnCubeMap.Size = new System.Drawing.Size(254, 23);
            this.btnCubeMap.TabIndex = 0;
            this.btnCubeMap.Text = "CubeMap";
            this.btnCubeMap.UseVisualStyleBackColor = true;
            this.btnCubeMap.Click += new System.EventHandler(this.btnCubeMap_Click);
            // 
            // btnLoadTexture
            // 
            this.btnLoadTexture.Location = new System.Drawing.Point(12, 186);
            this.btnLoadTexture.Name = "btnLoadTexture";
            this.btnLoadTexture.Size = new System.Drawing.Size(254, 23);
            this.btnLoadTexture.TabIndex = 0;
            this.btnLoadTexture.Text = "LoadTexture";
            this.btnLoadTexture.UseVisualStyleBackColor = true;
            this.btnLoadTexture.Click += new System.EventHandler(this.btnLoadTexture_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 626);
            this.Controls.Add(this.btnTeapotExample);
            this.Controls.Add(this.btnLoadTexture);
            this.Controls.Add(this.btnCubeMap);
            this.Controls.Add(this.btnInstancedRendering);
            this.Controls.Add(this.btnParticleSimulatorExample);
            this.Controls.Add(this.btnFurRendering);
            this.Controls.Add(this.btnLightingExample);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLightingExample;
        private System.Windows.Forms.Button btnTeapotExample;
        private System.Windows.Forms.Button btnFurRendering;
        private System.Windows.Forms.Button btnParticleSimulatorExample;
        private System.Windows.Forms.Button btnInstancedRendering;
        private System.Windows.Forms.Button btnCubeMap;
        private System.Windows.Forms.Button btnLoadTexture;
    }
}