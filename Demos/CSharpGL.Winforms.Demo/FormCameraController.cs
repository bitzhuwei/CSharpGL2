﻿using CSharpGL.Objects.Cameras;
using System;
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
    public partial class FormCameraController : Form
    {
        public FormCameraController(Camera camera)
        {
            InitializeComponent();

            this.cameraController1.TargetCamera = camera;
        }
    }
}
