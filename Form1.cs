using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FlatUI;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Timers;

namespace OIDN
{
    public partial class Form1 : Form
    {
        string path_beauty = "";
        string path_albedo = "";
        string path_normal = "";
        string path_output = "";

        string extension = "";
        string path_header_beauty = "";
        string path_header_albedo = "";
        string path_header_normal = "";

        bool isAnimation = false;
        int digit = 0;
        string digit_str = "";
        int minFrame = 0;
        int maxFrame = 0;
        int totalFrame = 0;

        bool denoiserRunning = false;
        bool seqRunning = false;
        IniFile ini = new IniFile("./oidn.ini");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            int indexparse = 0; int.TryParse(ini["Seq", "CB_Index"], out indexparse);
            comboBox_Presets.SelectedIndex = indexparse;

            if (textbox_PatternBeauty.Text != "")
            {
                textbox_PatternBeauty.Text = ini["Seq", "PatternBeauty"];
            }
            if (textbox_PatternAlbedo.Text != "")
            {
                textbox_PatternAlbedo.Text = ini["Seq", "PatternAlbedo"];
            }
            if (textbox_PatternNormal.Text != "")
            {
                textbox_PatternNormal.Text = ini["Seq", "PatternNormal"];
            }
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            path_beauty = textbox_BeautyPath.Text;
            path_albedo = textbox_AlbedoPath.Text;
            path_normal = textbox_NormalPath.Text;
            path_output = textbox_outputPath.Text;

            if (path_beauty == "")
            {
                alertError("Beauty path is invalid");
                return;
            }
            if (path_albedo == "" || path_albedo == digit_str + extension)
            {
                alertError("Albedo AOV path invalid");
                return;
            }
            if (path_normal == "" || path_normal == digit_str + extension)
            {
                alertError("Normal AOV path invalid");
                return;
            }
            if (path_output == "")
            {
                alertError("Output path is empty");
                return;
            }

            button_run.Enabled = false;
            picturebox_preview.Image = Properties.Resources.load2;

            if (!isAnimation)
            {
                string args = "";
                args += "-i " + "\"" + path_beauty + "\" ";
                args += "-a " + "\"" + path_albedo + "\" ";
                args += "-n " + "\"" + path_normal + "\" ";
                args += "-o " + "\"" + path_output + "\" ";

                if (checkBox_is32bpc.Checked == true)
                {
                    args += "-hdr 1 ";
                }
                else
                {
                    args += "-hdr 0 ";
                }

                if (!checkBox_useallthreads.Checked)
                {
                    try
                    {
                        int result = Int32.Parse(textbox_Threads.Text);
                        if (result != 0)
                        {
                            args += "-t " + result + " ";
                        }
                    }
                    catch (Exception)
                    {
                        //
                    }
                }

                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "/lib/core.exe";
                p.StartInfo.Arguments = args;
                p.SynchronizingObject = this;
                p.Exited += new EventHandler(p_Exited);
                p.EnableRaisingEvents = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.OutputDataReceived += p_OutputDataReceived;

                p.Start();
                alertClose();

                p.BeginOutputReadLine();
                denoiserRunning = true;
                while (denoiserRunning)
                {
                    Application.DoEvents();
                    Thread.Sleep(32);
                }
                Thread.Sleep(128);

                button_run.Enabled = true;
                alertSuccess("Success");

                try
                {
                    picturebox_preview.ImageLocation = path_output;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            else
            {
                //seq
                string args_pre = "";
                if (checkBox_is32bpc.Checked == true)
                {
                    args_pre += "-hdr 1 ";
                }
                else
                {
                    args_pre += "-hdr 0 ";
                }
                if (!checkBox_useallthreads.Checked)
                {
                    try
                    {
                        int result = Int32.Parse(textbox_Threads.Text);
                        if (result != 0)
                        {
                            args_pre += "-t " + result + " ";
                        }
                    }
                    catch (Exception)
                    {
                        //
                    }
                }


                alertClose();
                seqRunning = true;
                button_abort.Visible = true;
                button_abort.Enabled = true;

                for (int i = 0; i < totalFrame; i++)
                {
                    if (!seqRunning)
                    {
                        break;
                    }

                    string args = "";
                    string framenum = (i + minFrame).ToString("D" + digit);

                    string seq_path_beauty = path_beauty.Replace(digit_str, framenum);
                    string seq_path_albedo = path_albedo.Replace(digit_str, framenum);
                    string seq_path_normal = path_normal.Replace(digit_str, framenum);
                    string seq_path_output = path_output.Replace(digit_str, framenum);

                    args += "-i " + "\"" + seq_path_beauty + "\" ";
                    args += "-a " + "\"" + seq_path_albedo + "\" ";
                    args += "-n " + "\"" + seq_path_normal + "\" ";
                    args += "-o " + "\"" + seq_path_output + "\" ";

                    args += args_pre;

                    if (!File.Exists(seq_path_beauty) || !File.Exists(seq_path_albedo) || !File.Exists(seq_path_normal))
                    {
                        alertError("File not found on " + framenum + "F");
                        button_run.Enabled = true;
                        break;
                    }

                    Process p = new Process();
                    p.StartInfo.FileName = Application.StartupPath + "/lib/core.exe";
                    p.StartInfo.Arguments = args;
                    p.SynchronizingObject = this;
                    p.Exited += new EventHandler(p_Exited);
                    p.EnableRaisingEvents = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.OutputDataReceived += p_OutputDataReceived;

                    p.Start();
                    p.BeginOutputReadLine();
                    denoiserRunning = true;
                    while (denoiserRunning)
                    {
                        Application.DoEvents();
                        Thread.Sleep(32);
                    }
                    alertSuccess("Processed " + framenum + "F (" + Math.Round(((double)i / totalFrame * 1.000) * 100.00) + "%)");
                    Thread.Sleep(64);

                    try
                    {
                        picturebox_preview.ImageLocation = path_output;
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
                seqRunning = false;

                button_run.Enabled = true;
                button_abort.Visible = false;
                button_abort.Enabled = false;
            }
        }

        void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                string str = e.Data;

                if (str.Contains("Initializing OIDN"))
                {
                    //
                }

                if (str.Contains("Done!"))
                {
                    flatProgressBar1.Value = 0;
                }

                if (str.Contains("Denoising complete in"))
                {
                    flatProgressBar1.Value = 100;

                }

                if (str.Contains("Denoising ") && str.Contains("%") && !str.Contains("complete"))
                {
                    string dur = str.Replace("Denoising ", "").Replace("%", "");

                    int prog = int.Parse("" + dur);

                    if (prog > 100 || prog < 0)
                    {
                        prog = 100;
                    }
                    flatProgressBar1.Value = prog;
                }
            }
        }


        private void p_Exited(object sender, EventArgs e)
        {
            denoiserRunning = false;
        }


        private void alertSuccess(string str)
        {
            this.flatAlertBox1.Visible = false;
            this.flatAlertBox1.kind = FlatAlertBox._Kind.Success;
            this.flatAlertBox1.Text = str;
            this.flatAlertBox1.Visible = true;
        }

        private void alertInfo(string str)
        {
            this.flatAlertBox1.Visible = false;
            this.flatAlertBox1.kind = FlatAlertBox._Kind.Info;
            this.flatAlertBox1.Text = str;
            this.flatAlertBox1.Visible = true;
        }

        private void alertError(string str)
        {
            this.flatAlertBox1.Visible = false;
            this.flatAlertBox1.kind = FlatAlertBox._Kind.Error;
            this.flatAlertBox1.Text = str;
            this.flatAlertBox1.Visible = true;
        }

        private void alertClose()
        {
            this.flatAlertBox1.Visible = false;
        }

        private void AddButton_Beauty_Click(object sender, EventArgs e)
        {
            alertClose();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Title = "Open Beauty";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_beauty = ofd.FileName;
                textbox_BeautyPath.Text = ofd.FileName;

                extension = Path.GetExtension(path_beauty);

                minFrame = 0;
                maxFrame = 0;
                numInput_StartFrame.Value = 0;
                numInput_EndFrame.Value = 0;
                flatLabel10.Text = "Total: 1  Digit: -";

                isAnimation = false;
                numInput_StartFrame.Enabled = false;
                numInput_EndFrame.Enabled = false;

                string tempAlbedoPath = path_beauty.Replace("_beauty", "").Replace(extension, "") + "_albedo" + extension;
                if (File.Exists(tempAlbedoPath))
                {
                    path_albedo = tempAlbedoPath;
                    textbox_AlbedoPath.Text = tempAlbedoPath;
                }

                string tempNormalPath = path_beauty.Replace("_beauty", "").Replace(extension, "") + "_N" + extension;
                if (File.Exists(tempNormalPath))
                {
                    path_normal = tempNormalPath;
                    textbox_NormalPath.Text = tempNormalPath;
                }
                path_output = path_beauty.Replace("_beauty", "").Replace(extension, "") + "_denoised" + extension;
                textbox_outputPath.Text = path_output;
            }
        }

        private void AddButton_Albedo_Click(object sender, EventArgs e)
        {
            alertClose();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Title = "Open Albedo AOV";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_albedo = ofd.FileName;
                textbox_AlbedoPath.Text = ofd.FileName;
            }
        }

        private void AddButton_Normal_Click(object sender, EventArgs e)
        {
            alertClose();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Title = "Open Normal AOV";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_normal = ofd.FileName;
                textbox_NormalPath.Text = ofd.FileName;
            }
        }

        private void button_setOutput_Click(object sender, EventArgs e)
        {
            alertClose();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Output";
            sfd.FileName = Path.GetFileNameWithoutExtension(path_output);
            sfd.Filter = "" + extension.Replace(".", "") + "(*" + extension + ")|*" + extension + "|All types(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path_output = sfd.FileName;
                textbox_outputPath.Text = sfd.FileName;
            }
        }

        private void AddFolderButton_Beauty_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.Title = "Open Beauty";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_beauty = ofd.FileName;
                textbox_BeautyPath.Text = ofd.FileName;

                extension = Path.GetExtension(path_beauty);

                alertClose();

                //regex
                try
                {
                    DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(path_beauty));
                    FileInfo[] files = di.GetFiles("*" + extension, SearchOption.AllDirectories);

                    minFrame = 9999;
                    maxFrame = 0;
                    totalFrame = 0;

                    bool beautyFound = false;
                    bool albedoFound = false;
                    bool normalFound = false;

                    foreach (System.IO.FileInfo f in files)
                    {
                        string filename = f.FullName;
                        bool ArnoldFix = false;

                        //Arnold fix
                        if (filename.Contains("_RGBA Image"))
                        {
                            filename = filename.Replace("_RGBA Image", "_RGBA Image_");
                            ArnoldFix = true;
                        }

                        MatchCollection mc = Regex.Matches(filename, @"(^|\r?\n|.*_|.*\.)\d{3,}.*\" + extension);
                        foreach (Match m in mc)
                        {
                            if (m.Value.Contains("_Albedo") || m.Value.Contains("_diffuse filter_") || m.Value.Contains("_DiffuseFilter") || m.Value.Contains("_diffusefilter") || m.Value.Contains(textbox_PatternAlbedo.Text))
                            {
                                string header = m.Groups[1].Value;
                                path_header_albedo = header;
                                albedoFound = true;
                            }
                            else if (m.Value.Contains("_Normal_") || m.Value.Contains("_shading normal_") || m.Value.Contains("_N_") || m.Value.Contains("_n_") || m.Value.Contains(textbox_PatternNormal.Text))
                            {
                                string header = m.Groups[1].Value;
                                path_header_normal = header;
                                normalFound = true;

                            }
                            else if (m.Value.Contains("_beauty") || m.Value.Contains("_Beauty") || m.Value.Contains(textbox_PatternBeauty.Text))
                            {
                                if (!m.Value.Contains("_denoised"))
                                {
                                    string header = m.Groups[1].Value;
                                    string frame = m.Groups[0].Value.Replace(m.Groups[1].Value, "").Replace(extension, "");

                                    //Arnold fix
                                    if (header.Contains("_RGBA Image_") && ArnoldFix)
                                    {
                                        header = header.Replace("_RGBA Image_", "_RGBA Image");
                                    }

                                    path_header_beauty = header;

                                    if (minFrame > int.Parse(frame))
                                    {
                                        minFrame = int.Parse(frame);
                                    }

                                    if (maxFrame < int.Parse(frame))
                                    {
                                        maxFrame = int.Parse(frame);
                                    }

                                    digit = frame.Length;
                                    beautyFound = true;
                                }
                            }
                        }


                    }

                    if (!beautyFound)
                    {
                        minFrame = 0;
                        maxFrame = 0;
                        totalFrame = (maxFrame - minFrame + 1);
                        numInput_StartFrame.Value = minFrame;
                        numInput_EndFrame.Value = maxFrame;
                        flatLabel10.Text = "Total: 1  Digit: -";
                        numInput_StartFrame.Enabled = false;
                        numInput_EndFrame.Enabled = false;

                        path_output = "";
                        textbox_outputPath.Text = path_output;

                        path_beauty = "";
                        textbox_BeautyPath.Text = path_beauty;
                        alertError("Beauty not found");
                    }
                    else
                    {
                        digit_str = "";
                        for (int i = 0; i < digit; i++)
                        {
                            digit_str += "#";
                        }
                        //MessageBox.Show("Min: " + minFrame + " Max: " + maxFrame + " Total: " + (maxFrame - minFrame + 1));
                        numInput_StartFrame.Value = minFrame;
                        numInput_EndFrame.Value = maxFrame;
                        totalFrame = (maxFrame - minFrame + 1);
                        flatLabel10.Text = "Total: " + totalFrame + "  Digit: " + digit;

                        isAnimation = true;
                        numInput_StartFrame.Enabled = true;
                        numInput_EndFrame.Enabled = true;

                        path_beauty = path_header_beauty + digit_str + extension;
                        path_albedo = path_header_albedo + digit_str + extension;
                        path_normal = path_header_normal + digit_str + extension;

                        textbox_BeautyPath.Text = path_beauty;
                        textbox_AlbedoPath.Text = path_albedo;
                        textbox_NormalPath.Text = path_normal;


                        path_output = path_beauty.Replace("_beauty", "").Replace(extension, "") + "_denoised" + extension;
                        textbox_outputPath.Text = path_output;
                    }

                    if (!albedoFound)
                    {
                        alertError("Albedo not found");
                        path_albedo = "";
                        textbox_AlbedoPath.Text = path_albedo;
                    }
                    if (!normalFound)
                    {
                        alertError("Normal not found");
                        path_normal = "";
                        textbox_NormalPath.Text = path_normal;
                    }

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }

        private void flatCheckBox1_CheckedChanged(object sender)
        {
            if (checkBox_useallthreads.Checked)
            {
                flatLabel11.Enabled = false;
                textbox_Threads.Enabled = false;
            }
            else
            {
                flatLabel11.Enabled = true;
                textbox_Threads.Enabled = true;
            }
        }

        bool imageMode = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (imageMode)
            {
                picturebox_preview.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                picturebox_preview.SizeMode = PictureBoxSizeMode.Zoom;
            }

            imageMode = !imageMode;
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Presets.SelectedIndex == 0)
            {
                textbox_PatternBeauty.Text = "_beauty_";
                textbox_PatternAlbedo.Text = "_diffusefilter_";
                textbox_PatternNormal.Text = "_n_";
            }
            if (comboBox_Presets.SelectedIndex == 1)
            {
                textbox_PatternBeauty.Text = "_RGBA";
                textbox_PatternAlbedo.Text = "_albedo_";
                textbox_PatternNormal.Text = "_N_";
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            onClose();
        }

        private void FlatClose_Click(object sender, EventArgs e)
        {
            onClose();
        }

        private void onClose()
        {
            ini["Seq", "PatternBeauty"] = textbox_PatternBeauty.Text;
            ini["Seq", "PatternAlbedo"] = textbox_PatternAlbedo.Text;
            ini["Seq", "PatternNormal"] = textbox_PatternNormal.Text;
            ini["Seq", "CB_Index"] = "" + comboBox_Presets.SelectedIndex;
            Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }

        private void button_abort_Click(object sender, EventArgs e)
        {
            if (seqRunning)
            {
                denoiserRunning = false;
                seqRunning = false;
            }
        }
    }
}
