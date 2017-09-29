using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Diagnostics;

namespace demo
{
    public partial class Form1 : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void romfile_ButtonCustomClick(object sender, EventArgs e)
        {
            //MessageBoxEx.Show("Execute custom action here...", "IntegerInput", MessageBoxButtons.OK, MessageBoxIcon.Information);
            romfile.Clear();
            systemfile.Enabled = true;
            romfile.ButtonCustom.Visible = false;
            txtsytem.Enabled = true;
            btUnpack.Enabled = true;
            btRemove.Enabled = true;
        }
        private void romfile_ButtonCustom2Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Zip files (*.zip)|*.zip";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            romfile.Text = openFileDialog1.FileName;
                            if (romfile.Text != null)
                            {
                                //MessageBox.Show("aaa");
                                systemfile.Clear();
                                romfile.ButtonCustom.Visible = true;
                                systemfile.Enabled = false;
                                txtsytem.Enabled = false;
                                btUnpack.Enabled = false;
                                btRemove.Enabled = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void systemfile_ButtonCustomClick(object sender, EventArgs e)
        {
            //MessageBoxEx.Show("Execute custom action here...", "IntegerInput", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Stream myStream = null;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog2.Filter = "DAT files (*.dat)|*.dat|IMG files (*.img)|*.img";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog2.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            systemfile.Text = openFileDialog2.FileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


        private void buttonX1_MouseMove(object sender, MouseEventArgs e)
        {
            labelX4.Text = "Extract ROM";
            labelX4.Location = new Point(531, 393);
        }

        private void buttonX1_MouseLeave(object sender, EventArgs e)
        {
            labelX4.Text = "";
        }

        private void buttonX2_MouseMove(object sender, MouseEventArgs e)
        {
            labelX4.Text = "Unpack";
            labelX4.Location = new Point(531, 342);
        }

        private void buttonX2_MouseLeave(object sender, EventArgs e)
        {
            labelX4.Text = "";
        }

        private void buttonX3_MouseMove(object sender, MouseEventArgs e)
        {
            labelX4.Text = "Remove app";
            labelX4.Location = new Point(531, 290);
        }

        private void buttonX3_MouseLeave(object sender, EventArgs e)
        {
            labelX4.Text = "";
        }

        private void btExtrat_Click(object sender, EventArgs e)
        {
            //RunApp("bin\\7za.exe", "x " + romfile.Text + " -o" + "INPUT" + " -y");
            backgroundWorker1.RunWorkerAsync();
        }
        private void RunApp(string FileName, string Arguments)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            //p.WindowStyle = ProcessWindowStyle.Normal;
            p.CreateNoWindow = true;
            p.UseShellExecute = false;
            p.FileName = FileName;
            p.Arguments = Arguments;
            Process x = Process.Start(p);
            x.WaitForExit();

        }
        private void RunApp1(string FileName, string Arguments)
        {
            Process p = new Process();
            p.StartInfo.FileName = FileName;
            p.StartInfo.Arguments = Arguments;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.Start();
            p.BeginOutputReadLine();
            p.WaitForExit();
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data != null)
            {
                BeginInvoke(new MethodInvoker(() => { txtout.AppendText(outLine.Data + Environment.NewLine); }));
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            RunApp1("bin\\7za.exe", "x " + romfile.Text + " -o" + "INPUT" + " -y");
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            systemfile.Enabled = true;
            txtsytem.Enabled = true;
            systemfile.Text = AppDomain.CurrentDomain.BaseDirectory + "INPUT\\system.new.dat";
        }





    }
}
