using FlatUI;

namespace OIDN
{
	partial class Form1
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
            this.FlatClose = new FlatUI.FlatClose();
            this.FlatMini = new FlatUI.FlatMini();
            this.flatProgressBar1 = new FlatUI.FlatProgressBar();
            this.FormSkin = new FlatUI.FormSkin();
            this.button_abort = new FlatUI.FlatButton();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatLabel11 = new FlatUI.FlatLabel();
            this.textbox_Threads = new FlatUI.FlatTextBox();
            this.checkBox_useallthreads = new FlatUI.FlatCheckBox();
            this.checkBox_is32bpc = new FlatUI.FlatCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatLabel10 = new FlatUI.FlatLabel();
            this.numInput_EndFrame = new FlatUI.FlatNumeric();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.numInput_StartFrame = new FlatUI.FlatNumeric();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flatLabel12 = new FlatUI.FlatLabel();
            this.comboBox_Presets = new FlatUI.FlatComboBox();
            this.textbox_PatternNormal = new FlatUI.FlatTextBox();
            this.flatLabel9 = new FlatUI.FlatLabel();
            this.textbox_PatternAlbedo = new FlatUI.FlatTextBox();
            this.flatLabel8 = new FlatUI.FlatLabel();
            this.textbox_PatternBeauty = new FlatUI.FlatTextBox();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.AddFolderButton_Beauty = new FlatUI.FlatButton();
            this.button_setOutput = new FlatUI.FlatButton();
            this.textbox_outputPath = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatAlertBox1 = new FlatUI.FlatAlertBox();
            this.button_run = new FlatUI.FlatButton();
            this.AddButton_Normal = new FlatUI.FlatButton();
            this.textbox_NormalPath = new FlatUI.FlatTextBox();
            this.AddButton_Albedo = new FlatUI.FlatButton();
            this.textbox_AlbedoPath = new FlatUI.FlatTextBox();
            this.AddButton_Beauty = new FlatUI.FlatButton();
            this.textbox_BeautyPath = new FlatUI.FlatTextBox();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.picturebox_preview = new System.Windows.Forms.PictureBox();
            this.FormSkin.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // FlatClose
            // 
            this.FlatClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatClose.BackColor = System.Drawing.Color.White;
            this.FlatClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FlatClose.Font = new System.Drawing.Font("Marlett", 10F);
            this.FlatClose.Location = new System.Drawing.Point(752, 11);
            this.FlatClose.Name = "FlatClose";
            this.FlatClose.Size = new System.Drawing.Size(18, 18);
            this.FlatClose.TabIndex = 4;
            this.FlatClose.Text = "Exit";
            this.FlatClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.FlatClose.Click += new System.EventHandler(this.FlatClose_Click);
            // 
            // FlatMini
            // 
            this.FlatMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlatMini.BackColor = System.Drawing.Color.White;
            this.FlatMini.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FlatMini.Font = new System.Drawing.Font("Marlett", 12F);
            this.FlatMini.Location = new System.Drawing.Point(728, 11);
            this.FlatMini.Name = "FlatMini";
            this.FlatMini.Size = new System.Drawing.Size(18, 18);
            this.FlatMini.TabIndex = 5;
            this.FlatMini.Text = "Minimize";
            this.FlatMini.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatProgressBar1
            // 
            this.flatProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.flatProgressBar1.Location = new System.Drawing.Point(0, 486);
            this.flatProgressBar1.Maximum = 100;
            this.flatProgressBar1.Name = "flatProgressBar1";
            this.flatProgressBar1.Pattern = false;
            this.flatProgressBar1.PercentSign = false;
            this.flatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.flatProgressBar1.ShowBalloon = false;
            this.flatProgressBar1.Size = new System.Drawing.Size(783, 42);
            this.flatProgressBar1.TabIndex = 10;
            this.flatProgressBar1.Text = "flatProgressBar1";
            this.flatProgressBar1.Value = 0;
            // 
            // FormSkin
            // 
            this.FormSkin.BackColor = System.Drawing.Color.White;
            this.FormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.FormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.FormSkin.Controls.Add(this.button_abort);
            this.FormSkin.Controls.Add(this.picturebox_preview);
            this.FormSkin.Controls.Add(this.flatTabControl1);
            this.FormSkin.Controls.Add(this.AddFolderButton_Beauty);
            this.FormSkin.Controls.Add(this.button_setOutput);
            this.FormSkin.Controls.Add(this.textbox_outputPath);
            this.FormSkin.Controls.Add(this.flatLabel6);
            this.FormSkin.Controls.Add(this.flatAlertBox1);
            this.FormSkin.Controls.Add(this.button_run);
            this.FormSkin.Controls.Add(this.AddButton_Normal);
            this.FormSkin.Controls.Add(this.textbox_NormalPath);
            this.FormSkin.Controls.Add(this.AddButton_Albedo);
            this.FormSkin.Controls.Add(this.textbox_AlbedoPath);
            this.FormSkin.Controls.Add(this.AddButton_Beauty);
            this.FormSkin.Controls.Add(this.textbox_BeautyPath);
            this.FormSkin.Controls.Add(this.flatLabel3);
            this.FormSkin.Controls.Add(this.flatLabel2);
            this.FormSkin.Controls.Add(this.flatLabel1);
            this.FormSkin.Controls.Add(this.FlatMini);
            this.FormSkin.Controls.Add(this.FlatClose);
            this.FormSkin.Controls.Add(this.flatProgressBar1);
            this.FormSkin.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.FormSkin.HeaderMaximize = false;
            this.FormSkin.Location = new System.Drawing.Point(0, 0);
            this.FormSkin.Name = "FormSkin";
            this.FormSkin.Size = new System.Drawing.Size(782, 528);
            this.FormSkin.TabIndex = 0;
            this.FormSkin.Text = "OIDN 0.1.0";
            // 
            // button_abort
            // 
            this.button_abort.BackColor = System.Drawing.Color.Transparent;
            this.button_abort.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_abort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_abort.Enabled = false;
            this.button_abort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_abort.Location = new System.Drawing.Point(12, 467);
            this.button_abort.Name = "button_abort";
            this.button_abort.Rounded = false;
            this.button_abort.Size = new System.Drawing.Size(115, 33);
            this.button_abort.TabIndex = 43;
            this.button_abort.Text = "Abort";
            this.button_abort.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_abort.Visible = false;
            this.button_abort.Click += new System.EventHandler(this.button_abort_Click);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(11, 222);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(435, 179);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.flatLabel11);
            this.tabPage1.Controls.Add(this.textbox_Threads);
            this.tabPage1.Controls.Add(this.checkBox_useallthreads);
            this.tabPage1.Controls.Add(this.checkBox_is32bpc);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Params";
            // 
            // flatLabel11
            // 
            this.flatLabel11.AutoSize = true;
            this.flatLabel11.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel11.Enabled = false;
            this.flatLabel11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel11.ForeColor = System.Drawing.Color.White;
            this.flatLabel11.Location = new System.Drawing.Point(144, 43);
            this.flatLabel11.Name = "flatLabel11";
            this.flatLabel11.Size = new System.Drawing.Size(51, 13);
            this.flatLabel11.TabIndex = 24;
            this.flatLabel11.Text = "Threads:";
            // 
            // textbox_Threads
            // 
            this.textbox_Threads.BackColor = System.Drawing.Color.Transparent;
            this.textbox_Threads.Enabled = false;
            this.textbox_Threads.FocusOnHover = false;
            this.textbox_Threads.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.textbox_Threads.Location = new System.Drawing.Point(196, 39);
            this.textbox_Threads.MaxLength = 32767;
            this.textbox_Threads.Multiline = false;
            this.textbox_Threads.Name = "textbox_Threads";
            this.textbox_Threads.ReadOnly = false;
            this.textbox_Threads.Size = new System.Drawing.Size(54, 22);
            this.textbox_Threads.TabIndex = 23;
            this.textbox_Threads.Text = "0";
            this.textbox_Threads.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_Threads.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_Threads.UseSystemPasswordChar = false;
            // 
            // checkBox_useallthreads
            // 
            this.checkBox_useallthreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.checkBox_useallthreads.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.checkBox_useallthreads.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_useallthreads.Checked = true;
            this.checkBox_useallthreads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_useallthreads.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox_useallthreads.Location = new System.Drawing.Point(11, 38);
            this.checkBox_useallthreads.Name = "checkBox_useallthreads";
            this.checkBox_useallthreads.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.checkBox_useallthreads.Size = new System.Drawing.Size(112, 22);
            this.checkBox_useallthreads.TabIndex = 22;
            this.checkBox_useallthreads.Text = "Use all threads";
            this.checkBox_useallthreads.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.flatCheckBox1_CheckedChanged);
            // 
            // checkBox_is32bpc
            // 
            this.checkBox_is32bpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.checkBox_is32bpc.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.checkBox_is32bpc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox_is32bpc.Checked = false;
            this.checkBox_is32bpc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_is32bpc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox_is32bpc.Location = new System.Drawing.Point(11, 10);
            this.checkBox_is32bpc.Name = "checkBox_is32bpc";
            this.checkBox_is32bpc.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.checkBox_is32bpc.Size = new System.Drawing.Size(67, 22);
            this.checkBox_is32bpc.TabIndex = 21;
            this.checkBox_is32bpc.Text = "32bpc";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flatLabel10);
            this.tabPage2.Controls.Add(this.numInput_EndFrame);
            this.tabPage2.Controls.Add(this.flatLabel5);
            this.tabPage2.Controls.Add(this.flatLabel4);
            this.tabPage2.Controls.Add(this.numInput_StartFrame);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Animation";
            // 
            // flatLabel10
            // 
            this.flatLabel10.AutoSize = true;
            this.flatLabel10.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel10.ForeColor = System.Drawing.Color.White;
            this.flatLabel10.Location = new System.Drawing.Point(9, 81);
            this.flatLabel10.Name = "flatLabel10";
            this.flatLabel10.Size = new System.Drawing.Size(85, 13);
            this.flatLabel10.TabIndex = 44;
            this.flatLabel10.Text = "Total: 1  Digit: -";
            // 
            // numInput_EndFrame
            // 
            this.numInput_EndFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numInput_EndFrame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numInput_EndFrame.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numInput_EndFrame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numInput_EndFrame.ForeColor = System.Drawing.Color.White;
            this.numInput_EndFrame.Location = new System.Drawing.Point(162, 26);
            this.numInput_EndFrame.Maximum = ((long)(9999999));
            this.numInput_EndFrame.Minimum = ((long)(0));
            this.numInput_EndFrame.Name = "numInput_EndFrame";
            this.numInput_EndFrame.Size = new System.Drawing.Size(132, 30);
            this.numInput_EndFrame.TabIndex = 43;
            this.numInput_EndFrame.Text = "flatNumeric1";
            this.numInput_EndFrame.Value = ((long)(0));
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(159, 10);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(62, 13);
            this.flatLabel5.TabIndex = 42;
            this.flatLabel5.Text = "End-Frame";
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(9, 10);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(66, 13);
            this.flatLabel4.TabIndex = 41;
            this.flatLabel4.Text = "Start-Frame";
            // 
            // numInput_StartFrame
            // 
            this.numInput_StartFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numInput_StartFrame.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numInput_StartFrame.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.numInput_StartFrame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numInput_StartFrame.ForeColor = System.Drawing.Color.White;
            this.numInput_StartFrame.Location = new System.Drawing.Point(12, 26);
            this.numInput_StartFrame.Maximum = ((long)(9999999));
            this.numInput_StartFrame.Minimum = ((long)(0));
            this.numInput_StartFrame.Name = "numInput_StartFrame";
            this.numInput_StartFrame.Size = new System.Drawing.Size(132, 30);
            this.numInput_StartFrame.TabIndex = 40;
            this.numInput_StartFrame.Text = "flatNumeric2";
            this.numInput_StartFrame.Value = ((long)(0));
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.flatLabel12);
            this.tabPage3.Controls.Add(this.comboBox_Presets);
            this.tabPage3.Controls.Add(this.textbox_PatternNormal);
            this.tabPage3.Controls.Add(this.flatLabel9);
            this.tabPage3.Controls.Add(this.textbox_PatternAlbedo);
            this.tabPage3.Controls.Add(this.flatLabel8);
            this.tabPage3.Controls.Add(this.textbox_PatternBeauty);
            this.tabPage3.Controls.Add(this.flatLabel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(427, 131);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sequence Pattern";
            // 
            // flatLabel12
            // 
            this.flatLabel12.AutoSize = true;
            this.flatLabel12.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel12.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel12.ForeColor = System.Drawing.Color.White;
            this.flatLabel12.Location = new System.Drawing.Point(10, 73);
            this.flatLabel12.Name = "flatLabel12";
            this.flatLabel12.Size = new System.Drawing.Size(88, 13);
            this.flatLabel12.TabIndex = 49;
            this.flatLabel12.Text = "Renderer Preset";
            // 
            // comboBox_Presets
            // 
            this.comboBox_Presets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboBox_Presets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Presets.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Presets.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboBox_Presets.ForeColor = System.Drawing.Color.White;
            this.comboBox_Presets.FormattingEnabled = true;
            this.comboBox_Presets.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox_Presets.ItemHeight = 18;
            this.comboBox_Presets.Items.AddRange(new object[] {
            "Redshift",
            "Arnold"});
            this.comboBox_Presets.Location = new System.Drawing.Point(12, 89);
            this.comboBox_Presets.Name = "comboBox_Presets";
            this.comboBox_Presets.Size = new System.Drawing.Size(210, 24);
            this.comboBox_Presets.TabIndex = 48;
            this.comboBox_Presets.SelectedIndexChanged += new System.EventHandler(this.flatComboBox1_SelectedIndexChanged);
            // 
            // textbox_PatternNormal
            // 
            this.textbox_PatternNormal.BackColor = System.Drawing.Color.Transparent;
            this.textbox_PatternNormal.FocusOnHover = false;
            this.textbox_PatternNormal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textbox_PatternNormal.Location = new System.Drawing.Point(242, 26);
            this.textbox_PatternNormal.MaxLength = 32767;
            this.textbox_PatternNormal.Multiline = false;
            this.textbox_PatternNormal.Name = "textbox_PatternNormal";
            this.textbox_PatternNormal.ReadOnly = false;
            this.textbox_PatternNormal.Size = new System.Drawing.Size(95, 26);
            this.textbox_PatternNormal.TabIndex = 47;
            this.textbox_PatternNormal.Text = "_n_";
            this.textbox_PatternNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_PatternNormal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_PatternNormal.UseSystemPasswordChar = false;
            // 
            // flatLabel9
            // 
            this.flatLabel9.AutoSize = true;
            this.flatLabel9.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel9.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel9.ForeColor = System.Drawing.Color.White;
            this.flatLabel9.Location = new System.Drawing.Point(239, 10);
            this.flatLabel9.Name = "flatLabel9";
            this.flatLabel9.Size = new System.Drawing.Size(44, 13);
            this.flatLabel9.TabIndex = 46;
            this.flatLabel9.Text = "Normal";
            // 
            // textbox_PatternAlbedo
            // 
            this.textbox_PatternAlbedo.BackColor = System.Drawing.Color.Transparent;
            this.textbox_PatternAlbedo.FocusOnHover = false;
            this.textbox_PatternAlbedo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textbox_PatternAlbedo.Location = new System.Drawing.Point(127, 26);
            this.textbox_PatternAlbedo.MaxLength = 32767;
            this.textbox_PatternAlbedo.Multiline = false;
            this.textbox_PatternAlbedo.Name = "textbox_PatternAlbedo";
            this.textbox_PatternAlbedo.ReadOnly = false;
            this.textbox_PatternAlbedo.Size = new System.Drawing.Size(95, 26);
            this.textbox_PatternAlbedo.TabIndex = 45;
            this.textbox_PatternAlbedo.Text = "_diffusefilter_";
            this.textbox_PatternAlbedo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_PatternAlbedo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_PatternAlbedo.UseSystemPasswordChar = false;
            // 
            // flatLabel8
            // 
            this.flatLabel8.AutoSize = true;
            this.flatLabel8.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel8.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel8.ForeColor = System.Drawing.Color.White;
            this.flatLabel8.Location = new System.Drawing.Point(124, 10);
            this.flatLabel8.Name = "flatLabel8";
            this.flatLabel8.Size = new System.Drawing.Size(44, 13);
            this.flatLabel8.TabIndex = 44;
            this.flatLabel8.Text = "Albedo";
            // 
            // textbox_PatternBeauty
            // 
            this.textbox_PatternBeauty.BackColor = System.Drawing.Color.Transparent;
            this.textbox_PatternBeauty.FocusOnHover = false;
            this.textbox_PatternBeauty.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.textbox_PatternBeauty.Location = new System.Drawing.Point(13, 26);
            this.textbox_PatternBeauty.MaxLength = 32767;
            this.textbox_PatternBeauty.Multiline = false;
            this.textbox_PatternBeauty.Name = "textbox_PatternBeauty";
            this.textbox_PatternBeauty.ReadOnly = false;
            this.textbox_PatternBeauty.Size = new System.Drawing.Size(95, 26);
            this.textbox_PatternBeauty.TabIndex = 43;
            this.textbox_PatternBeauty.Text = "_beauty_";
            this.textbox_PatternBeauty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_PatternBeauty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_PatternBeauty.UseSystemPasswordChar = false;
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(10, 10);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(41, 13);
            this.flatLabel7.TabIndex = 42;
            this.flatLabel7.Text = "Beauty";
            // 
            // AddFolderButton_Beauty
            // 
            this.AddFolderButton_Beauty.BackColor = System.Drawing.Color.Transparent;
            this.AddFolderButton_Beauty.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddFolderButton_Beauty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFolderButton_Beauty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFolderButton_Beauty.Location = new System.Drawing.Point(706, 76);
            this.AddFolderButton_Beauty.Name = "AddFolderButton_Beauty";
            this.AddFolderButton_Beauty.Rounded = false;
            this.AddFolderButton_Beauty.Size = new System.Drawing.Size(64, 26);
            this.AddFolderButton_Beauty.TabIndex = 36;
            this.AddFolderButton_Beauty.Text = "Add Seq";
            this.AddFolderButton_Beauty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AddFolderButton_Beauty.Click += new System.EventHandler(this.AddFolderButton_Beauty_Click);
            // 
            // button_setOutput
            // 
            this.button_setOutput.BackColor = System.Drawing.Color.Transparent;
            this.button_setOutput.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_setOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_setOutput.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_setOutput.Location = new System.Drawing.Point(706, 430);
            this.button_setOutput.Name = "button_setOutput";
            this.button_setOutput.Rounded = false;
            this.button_setOutput.Size = new System.Drawing.Size(64, 26);
            this.button_setOutput.TabIndex = 34;
            this.button_setOutput.Text = "Set path";
            this.button_setOutput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_setOutput.Click += new System.EventHandler(this.button_setOutput_Click);
            // 
            // textbox_outputPath
            // 
            this.textbox_outputPath.BackColor = System.Drawing.Color.Transparent;
            this.textbox_outputPath.FocusOnHover = false;
            this.textbox_outputPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_outputPath.Location = new System.Drawing.Point(12, 430);
            this.textbox_outputPath.MaxLength = 32767;
            this.textbox_outputPath.Multiline = false;
            this.textbox_outputPath.Name = "textbox_outputPath";
            this.textbox_outputPath.ReadOnly = false;
            this.textbox_outputPath.Size = new System.Drawing.Size(688, 26);
            this.textbox_outputPath.TabIndex = 33;
            this.textbox_outputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_outputPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_outputPath.UseSystemPasswordChar = false;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(9, 413);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(45, 13);
            this.flatLabel6.TabIndex = 32;
            this.flatLabel6.Text = "Output";
            // 
            // flatAlertBox1
            // 
            this.flatAlertBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatAlertBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatAlertBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatAlertBox1.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.flatAlertBox1.Location = new System.Drawing.Point(452, 3);
            this.flatAlertBox1.Name = "flatAlertBox1";
            this.flatAlertBox1.Size = new System.Drawing.Size(248, 42);
            this.flatAlertBox1.TabIndex = 31;
            this.flatAlertBox1.Text = "Success";
            this.flatAlertBox1.Visible = false;
            // 
            // button_run
            // 
            this.button_run.BackColor = System.Drawing.Color.Transparent;
            this.button_run.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_run.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_run.Location = new System.Drawing.Point(560, 467);
            this.button_run.Name = "button_run";
            this.button_run.Rounded = false;
            this.button_run.Size = new System.Drawing.Size(210, 33);
            this.button_run.TabIndex = 30;
            this.button_run.Text = "Run Denoiser";
            this.button_run.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // AddButton_Normal
            // 
            this.AddButton_Normal.BackColor = System.Drawing.Color.Transparent;
            this.AddButton_Normal.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddButton_Normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton_Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton_Normal.Location = new System.Drawing.Point(636, 185);
            this.AddButton_Normal.Name = "AddButton_Normal";
            this.AddButton_Normal.Rounded = false;
            this.AddButton_Normal.Size = new System.Drawing.Size(134, 26);
            this.AddButton_Normal.TabIndex = 20;
            this.AddButton_Normal.Text = "Add File";
            this.AddButton_Normal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AddButton_Normal.Click += new System.EventHandler(this.AddButton_Normal_Click);
            // 
            // textbox_NormalPath
            // 
            this.textbox_NormalPath.BackColor = System.Drawing.Color.Transparent;
            this.textbox_NormalPath.FocusOnHover = false;
            this.textbox_NormalPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_NormalPath.Location = new System.Drawing.Point(12, 185);
            this.textbox_NormalPath.MaxLength = 32767;
            this.textbox_NormalPath.Multiline = false;
            this.textbox_NormalPath.Name = "textbox_NormalPath";
            this.textbox_NormalPath.ReadOnly = false;
            this.textbox_NormalPath.Size = new System.Drawing.Size(618, 26);
            this.textbox_NormalPath.TabIndex = 19;
            this.textbox_NormalPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_NormalPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_NormalPath.UseSystemPasswordChar = false;
            // 
            // AddButton_Albedo
            // 
            this.AddButton_Albedo.BackColor = System.Drawing.Color.Transparent;
            this.AddButton_Albedo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddButton_Albedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton_Albedo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton_Albedo.Location = new System.Drawing.Point(636, 129);
            this.AddButton_Albedo.Name = "AddButton_Albedo";
            this.AddButton_Albedo.Rounded = false;
            this.AddButton_Albedo.Size = new System.Drawing.Size(134, 26);
            this.AddButton_Albedo.TabIndex = 18;
            this.AddButton_Albedo.Text = "Add File";
            this.AddButton_Albedo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AddButton_Albedo.Click += new System.EventHandler(this.AddButton_Albedo_Click);
            // 
            // textbox_AlbedoPath
            // 
            this.textbox_AlbedoPath.BackColor = System.Drawing.Color.Transparent;
            this.textbox_AlbedoPath.FocusOnHover = false;
            this.textbox_AlbedoPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_AlbedoPath.Location = new System.Drawing.Point(12, 129);
            this.textbox_AlbedoPath.MaxLength = 32767;
            this.textbox_AlbedoPath.Multiline = false;
            this.textbox_AlbedoPath.Name = "textbox_AlbedoPath";
            this.textbox_AlbedoPath.ReadOnly = false;
            this.textbox_AlbedoPath.Size = new System.Drawing.Size(618, 26);
            this.textbox_AlbedoPath.TabIndex = 17;
            this.textbox_AlbedoPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_AlbedoPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_AlbedoPath.UseSystemPasswordChar = false;
            // 
            // AddButton_Beauty
            // 
            this.AddButton_Beauty.BackColor = System.Drawing.Color.Transparent;
            this.AddButton_Beauty.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AddButton_Beauty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton_Beauty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton_Beauty.Location = new System.Drawing.Point(636, 76);
            this.AddButton_Beauty.Name = "AddButton_Beauty";
            this.AddButton_Beauty.Rounded = false;
            this.AddButton_Beauty.Size = new System.Drawing.Size(64, 26);
            this.AddButton_Beauty.TabIndex = 16;
            this.AddButton_Beauty.Text = "Add File";
            this.AddButton_Beauty.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AddButton_Beauty.Click += new System.EventHandler(this.AddButton_Beauty_Click);
            // 
            // textbox_BeautyPath
            // 
            this.textbox_BeautyPath.BackColor = System.Drawing.Color.Transparent;
            this.textbox_BeautyPath.FocusOnHover = false;
            this.textbox_BeautyPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_BeautyPath.Location = new System.Drawing.Point(12, 76);
            this.textbox_BeautyPath.MaxLength = 32767;
            this.textbox_BeautyPath.Multiline = false;
            this.textbox_BeautyPath.Name = "textbox_BeautyPath";
            this.textbox_BeautyPath.ReadOnly = false;
            this.textbox_BeautyPath.Size = new System.Drawing.Size(618, 26);
            this.textbox_BeautyPath.TabIndex = 14;
            this.textbox_BeautyPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textbox_BeautyPath.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textbox_BeautyPath.UseSystemPasswordChar = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(9, 168);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(70, 13);
            this.flatLabel3.TabIndex = 12;
            this.flatLabel3.Text = "Normal AOV";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(9, 112);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(70, 13);
            this.flatLabel2.TabIndex = 11;
            this.flatLabel2.Text = "Albedo AOV";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(9, 59);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(41, 13);
            this.flatLabel1.TabIndex = 8;
            this.flatLabel1.Text = "Beauty";
            // 
            // picturebox_preview
            // 
            this.picturebox_preview.BackColor = System.Drawing.Color.Black;
            this.picturebox_preview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picturebox_preview.ErrorImage = global::OIDN.Properties.Resources.logo_tiny;
            this.picturebox_preview.InitialImage = global::OIDN.Properties.Resources.load2;
            this.picturebox_preview.Location = new System.Drawing.Point(452, 222);
            this.picturebox_preview.Name = "picturebox_preview";
            this.picturebox_preview.Size = new System.Drawing.Size(318, 179);
            this.picturebox_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_preview.TabIndex = 42;
            this.picturebox_preview.TabStop = false;
            this.picturebox_preview.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 528);
            this.Controls.Add(this.FormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OIDN";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormSkin.ResumeLayout(false);
            this.FormSkin.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_preview)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private FlatClose FlatClose;
        private FlatMini FlatMini;
        private FlatProgressBar flatProgressBar1;
        private FormSkin FormSkin;
        private FlatLabel flatLabel1;
        private FlatLabel flatLabel3;
        private FlatLabel flatLabel2;
        private FlatTextBox textbox_BeautyPath;
        private FlatButton AddButton_Beauty;
        private FlatButton AddButton_Normal;
        private FlatTextBox textbox_NormalPath;
        private FlatButton AddButton_Albedo;
        private FlatTextBox textbox_AlbedoPath;
        private FlatCheckBox checkBox_is32bpc;
        private FlatButton button_run;
        private FlatAlertBox flatAlertBox1;
        private FlatButton button_setOutput;
        private FlatTextBox textbox_outputPath;
        private FlatLabel flatLabel6;
        private FlatButton AddFolderButton_Beauty;
        private FlatNumeric numInput_StartFrame;
        private FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FlatLabel flatLabel5;
        private FlatLabel flatLabel4;
        private FlatNumeric numInput_EndFrame;
        private System.Windows.Forms.TabPage tabPage3;
        private FlatTextBox textbox_PatternNormal;
        private FlatLabel flatLabel9;
        private FlatTextBox textbox_PatternAlbedo;
        private FlatLabel flatLabel8;
        private FlatTextBox textbox_PatternBeauty;
        private FlatLabel flatLabel7;
        private FlatLabel flatLabel10;
        private FlatCheckBox checkBox_useallthreads;
        private FlatTextBox textbox_Threads;
        private FlatLabel flatLabel11;
        private System.Windows.Forms.PictureBox picturebox_preview;
        private FlatComboBox comboBox_Presets;
        private FlatLabel flatLabel12;
        private FlatButton button_abort;
    }
}

