﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapComparer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBrowseBMP1_Click(object sender, EventArgs e)
        {
            if (openBmpDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtBitmapFullname1.Text = openBmpDlg.FileName;
            }
        }

        private void btnBrowseBMP2_Click(object sender, EventArgs e)
        {
            if (openBmpDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtBitmapFullname2.Text = openBmpDlg.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtBitmapFullname1.Text))
            {
                string message = string.Format("{0}", "Please select a bitmap file first!");
                MessageBox.Show(message);
                return;
            }

            if (string.IsNullOrEmpty(this.txtBitmapFullname2.Text))
            {
                string message = string.Format("{0}", "Please select another bitmap file first!");
                MessageBox.Show(message);
                return;
            }

            Bitmap bmp1 = null;
            Bitmap bmp2 = null;
            try
            {
                string name1 = this.txtBitmapFullname1.Text;
                string name2 = this.txtBitmapFullname2.Text;

                bmp1 = new Bitmap(name1);
                bmp2 = new Bitmap(name2);

                if (bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
                {
                    MessageBox.Show("not the same size!");
                }
                else
                {

                    FileInfo bmpFile1Info = new FileInfo(this.txtBitmapFullname1.Text);
                    string outputFile = string.Format("{0}\\{1}.txt", bmpFile1Info.DirectoryName, bmpFile1Info.Name);
                    using (StreamWriter sw = new StreamWriter(outputFile))
                    {
                        sw.WriteLine("comparer:");
                        sw.WriteLine(name1);
                        sw.WriteLine(name2);
                        int diffCount = 0;
                        for (int row = 0; row < bmp1.Height; row++)
                        {
                            for (int col = 0; col < bmp1.Width; col++)
                            {
                                Color c1 = bmp1.GetPixel(col, row);
                                Color c2 = bmp2.GetPixel(col, row);
                                if (c1.R != c2.R || c1.G != c2.G || c1.B != c2.B || c1.A != c2.A)
                                {
                                    sw.WriteLine(string.Format("@ ({0}, {1}) diff: {2} vs {3}",
                                        row, col, c1, c2));
                                    diffCount++;
                                }
                            }
                        }

                        sw.WriteLine(string.Format("{0} diffs.", diffCount));
                    }

                    Process.Start("explorer", outputFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (bmp1 != null)
                { bmp1.Dispose(); }
                if (bmp2 != null)
                { bmp2.Dispose(); }

            }
        }


    }
}
