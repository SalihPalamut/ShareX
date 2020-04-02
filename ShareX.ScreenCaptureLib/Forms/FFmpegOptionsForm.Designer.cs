namespace ShareX.ScreenCaptureLib
{
    partial class FFmpegOptionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFmpegOptionsForm));
            this.lblx264CRF = new System.Windows.Forms.Label();
            this.nudx264CRF = new System.Windows.Forms.NumericUpDown();
            this.ttHelpTip = new System.Windows.Forms.ToolTip(this.components);
            this.nudXvidQscale = new System.Windows.Forms.NumericUpDown();
            this.cbx264Preset = new System.Windows.Forms.ComboBox();
            this.tbVorbis_qscale = new System.Windows.Forms.TrackBar();
            this.tbMP3_qscale = new System.Windows.Forms.TrackBar();
            this.tbAACBitrate = new System.Windows.Forms.TrackBar();
            this.cbGIFStatsMode = new System.Windows.Forms.ComboBox();
            this.cbGIFDither = new System.Windows.Forms.ComboBox();
            this.pbAudioCodecWarning = new System.Windows.Forms.PictureBox();
            this.pbx264PresetWarning = new System.Windows.Forms.PictureBox();
            this.tbOpusBitrate = new System.Windows.Forms.TrackBar();
            this.watermark_opacity = new System.Windows.Forms.TrackBar();
            this.lblCodec = new System.Windows.Forms.Label();
            this.cboVideoCodec = new System.Windows.Forms.ComboBox();
            this.lblx264Preset = new System.Windows.Forms.Label();
            this.lblXvidQscale = new System.Windows.Forms.Label();
            this.gbFFmpegExe = new System.Windows.Forms.GroupBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnFFmpegBrowse = new System.Windows.Forms.Button();
            this.txtFFmpegPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.watermark_opacity_text = new System.Windows.Forms.Label();
            this.cbOverrideFFmpegPath = new System.Windows.Forms.CheckBox();
            this.gbCommandLinePreview = new System.Windows.Forms.GroupBox();
            this.cbCustomCommands = new System.Windows.Forms.CheckBox();
            this.txtCommandLinePreview = new System.Windows.Forms.TextBox();
            this.gbCommandLineArgs = new System.Windows.Forms.GroupBox();
            this.tbUserArgs = new System.Windows.Forms.TextBox();
            this.tcFFmpegVideoCodecs = new System.Windows.Forms.TabControl();
            this.tpX264 = new System.Windows.Forms.TabPage();
            this.tpVpx = new System.Windows.Forms.TabPage();
            this.lblVP8BitrateK = new System.Windows.Forms.Label();
            this.nudVP8Bitrate = new System.Windows.Forms.NumericUpDown();
            this.lblVP8Bitrate = new System.Windows.Forms.Label();
            this.tpXvid = new System.Windows.Forms.TabPage();
            this.tpNVENC = new System.Windows.Forms.TabPage();
            this.cbNVENCPreset = new System.Windows.Forms.ComboBox();
            this.lblNVENCPreset = new System.Windows.Forms.Label();
            this.nudNVENCBitrate = new System.Windows.Forms.NumericUpDown();
            this.lblNVENCBitrate = new System.Windows.Forms.Label();
            this.tpGIF = new System.Windows.Forms.TabPage();
            this.lblGIFDither = new System.Windows.Forms.Label();
            this.lblGIFStatsMode = new System.Windows.Forms.Label();
            this.tbAMF = new System.Windows.Forms.TabPage();
            this.cbAMFQuality = new System.Windows.Forms.ComboBox();
            this.lblAMFQuality = new System.Windows.Forms.Label();
            this.cbAMFUsage = new System.Windows.Forms.ComboBox();
            this.lblAMFUsage = new System.Windows.Forms.Label();
            this.tbQSV = new System.Windows.Forms.TabPage();
            this.cbQSVPreset = new System.Windows.Forms.ComboBox();
            this.lblQSVPreset = new System.Windows.Forms.Label();
            this.nudQSVBitrate = new System.Windows.Forms.NumericUpDown();
            this.lblQSVBitrate = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCopyPreview = new System.Windows.Forms.Button();
            this.tcFFmpegAudioCodecs = new System.Windows.Forms.TabControl();
            this.tpAAC = new System.Windows.Forms.TabPage();
            this.lblAACQuality = new System.Windows.Forms.Label();
            this.tpOpus = new System.Windows.Forms.TabPage();
            this.lblOpusQuality = new System.Windows.Forms.Label();
            this.tpVorbis = new System.Windows.Forms.TabPage();
            this.lblVorbisQuality = new System.Windows.Forms.Label();
            this.tpMP3 = new System.Windows.Forms.TabPage();
            this.lblMP3Quality = new System.Windows.Forms.Label();
            this.cboVideoSource = new System.Windows.Forms.ComboBox();
            this.lblVideoSource = new System.Windows.Forms.Label();
            this.cboAudioSource = new System.Windows.Forms.ComboBox();
            this.lblAudioSource = new System.Windows.Forms.Label();
            this.cboAudioCodec = new System.Windows.Forms.ComboBox();
            this.lblAudioCodec = new System.Windows.Forms.Label();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.btnHelperDevicesHelp = new System.Windows.Forms.Button();
            this.lblHelperDevices = new System.Windows.Forms.Label();
            this.btnInstallHelperDevices = new System.Windows.Forms.Button();
            this.btnRefreshSources = new System.Windows.Forms.Button();
            this.gbCodecs = new System.Windows.Forms.GroupBox();
            this.WaterMark = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.watermark_Y = new System.Windows.Forms.NumericUpDown();
            this.watermark_X = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.watermark_location_right = new System.Windows.Forms.RadioButton();
            this.watermark_location_left = new System.Windows.Forms.RadioButton();
            this.watermark_location_top = new System.Windows.Forms.RadioButton();
            this.watermark_location_bottom = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.watermark_show = new System.Windows.Forms.PictureBox();
            this.watermark_use = new System.Windows.Forms.CheckBox();
            this.eiFFmpeg = new ShareX.HelpersLib.ExportImportControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudx264CRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXvidQscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVorbis_qscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMP3_qscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAACBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudioCodecWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx264PresetWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpusBitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_opacity)).BeginInit();
            this.gbFFmpegExe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbCommandLinePreview.SuspendLayout();
            this.gbCommandLineArgs.SuspendLayout();
            this.tcFFmpegVideoCodecs.SuspendLayout();
            this.tpX264.SuspendLayout();
            this.tpVpx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVP8Bitrate)).BeginInit();
            this.tpXvid.SuspendLayout();
            this.tpNVENC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNVENCBitrate)).BeginInit();
            this.tpGIF.SuspendLayout();
            this.tbAMF.SuspendLayout();
            this.tbQSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQSVBitrate)).BeginInit();
            this.tcFFmpegAudioCodecs.SuspendLayout();
            this.tpAAC.SuspendLayout();
            this.tpOpus.SuspendLayout();
            this.tpVorbis.SuspendLayout();
            this.tpMP3.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbCodecs.SuspendLayout();
            this.WaterMark.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_X)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_show)).BeginInit();
            this.SuspendLayout();
            // 
            // lblx264CRF
            // 
            resources.ApplyResources(this.lblx264CRF, "lblx264CRF");
            this.lblx264CRF.Name = "lblx264CRF";
            // 
            // nudx264CRF
            // 
            resources.ApplyResources(this.nudx264CRF, "nudx264CRF");
            this.nudx264CRF.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.nudx264CRF.Name = "nudx264CRF";
            this.ttHelpTip.SetToolTip(this.nudx264CRF, resources.GetString("nudx264CRF.ToolTip"));
            this.nudx264CRF.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudx264CRF.ValueChanged += new System.EventHandler(this.nudx264CRF_ValueChanged);
            // 
            // ttHelpTip
            // 
            this.ttHelpTip.AutomaticDelay = 0;
            this.ttHelpTip.AutoPopDelay = 30000;
            this.ttHelpTip.BackColor = System.Drawing.SystemColors.Window;
            this.ttHelpTip.InitialDelay = 500;
            this.ttHelpTip.IsBalloon = true;
            this.ttHelpTip.ReshowDelay = 100;
            this.ttHelpTip.UseAnimation = false;
            this.ttHelpTip.UseFading = false;
            // 
            // nudXvidQscale
            // 
            resources.ApplyResources(this.nudXvidQscale, "nudXvidQscale");
            this.nudXvidQscale.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudXvidQscale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudXvidQscale.Name = "nudXvidQscale";
            this.ttHelpTip.SetToolTip(this.nudXvidQscale, resources.GetString("nudXvidQscale.ToolTip"));
            this.nudXvidQscale.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudXvidQscale.ValueChanged += new System.EventHandler(this.nudQscale_ValueChanged);
            // 
            // cbx264Preset
            // 
            this.cbx264Preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx264Preset.FormattingEnabled = true;
            resources.ApplyResources(this.cbx264Preset, "cbx264Preset");
            this.cbx264Preset.Name = "cbx264Preset";
            this.ttHelpTip.SetToolTip(this.cbx264Preset, resources.GetString("cbx264Preset.ToolTip"));
            this.cbx264Preset.SelectedIndexChanged += new System.EventHandler(this.cbPreset_SelectedIndexChanged);
            // 
            // tbVorbis_qscale
            // 
            this.tbVorbis_qscale.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbVorbis_qscale, "tbVorbis_qscale");
            this.tbVorbis_qscale.LargeChange = 1;
            this.tbVorbis_qscale.Name = "tbVorbis_qscale";
            this.tbVorbis_qscale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttHelpTip.SetToolTip(this.tbVorbis_qscale, resources.GetString("tbVorbis_qscale.ToolTip"));
            this.tbVorbis_qscale.Value = 3;
            this.tbVorbis_qscale.ValueChanged += new System.EventHandler(this.tbVorbis_qscale_ValueChanged);
            // 
            // tbMP3_qscale
            // 
            this.tbMP3_qscale.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbMP3_qscale, "tbMP3_qscale");
            this.tbMP3_qscale.LargeChange = 1;
            this.tbMP3_qscale.Maximum = 9;
            this.tbMP3_qscale.Name = "tbMP3_qscale";
            this.tbMP3_qscale.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttHelpTip.SetToolTip(this.tbMP3_qscale, resources.GetString("tbMP3_qscale.ToolTip"));
            this.tbMP3_qscale.Value = 5;
            this.tbMP3_qscale.ValueChanged += new System.EventHandler(this.tbMP3_qscale_ValueChanged);
            // 
            // tbAACBitrate
            // 
            this.tbAACBitrate.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbAACBitrate, "tbAACBitrate");
            this.tbAACBitrate.LargeChange = 1;
            this.tbAACBitrate.Maximum = 16;
            this.tbAACBitrate.Minimum = 1;
            this.tbAACBitrate.Name = "tbAACBitrate";
            this.tbAACBitrate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttHelpTip.SetToolTip(this.tbAACBitrate, resources.GetString("tbAACBitrate.ToolTip"));
            this.tbAACBitrate.Value = 4;
            this.tbAACBitrate.Scroll += new System.EventHandler(this.tbAACBitrate_Scroll);
            this.tbAACBitrate.ValueChanged += new System.EventHandler(this.tbAACBitrate_ValueChanged);
            // 
            // cbGIFStatsMode
            // 
            this.cbGIFStatsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGIFStatsMode.FormattingEnabled = true;
            resources.ApplyResources(this.cbGIFStatsMode, "cbGIFStatsMode");
            this.cbGIFStatsMode.Name = "cbGIFStatsMode";
            this.ttHelpTip.SetToolTip(this.cbGIFStatsMode, resources.GetString("cbGIFStatsMode.ToolTip"));
            this.cbGIFStatsMode.SelectedIndexChanged += new System.EventHandler(this.cbGIFStatsMode_SelectedIndexChanged);
            // 
            // cbGIFDither
            // 
            this.cbGIFDither.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGIFDither.FormattingEnabled = true;
            resources.ApplyResources(this.cbGIFDither, "cbGIFDither");
            this.cbGIFDither.Name = "cbGIFDither";
            this.ttHelpTip.SetToolTip(this.cbGIFDither, resources.GetString("cbGIFDither.ToolTip"));
            this.cbGIFDither.SelectedIndexChanged += new System.EventHandler(this.cbGIFDither_SelectedIndexChanged);
            // 
            // pbAudioCodecWarning
            // 
            this.pbAudioCodecWarning.Image = global::ShareX.ScreenCaptureLib.Properties.Resources.exclamation_button;
            resources.ApplyResources(this.pbAudioCodecWarning, "pbAudioCodecWarning");
            this.pbAudioCodecWarning.Name = "pbAudioCodecWarning";
            this.pbAudioCodecWarning.TabStop = false;
            this.ttHelpTip.SetToolTip(this.pbAudioCodecWarning, resources.GetString("pbAudioCodecWarning.ToolTip"));
            // 
            // pbx264PresetWarning
            // 
            this.pbx264PresetWarning.Image = global::ShareX.ScreenCaptureLib.Properties.Resources.exclamation_button;
            resources.ApplyResources(this.pbx264PresetWarning, "pbx264PresetWarning");
            this.pbx264PresetWarning.Name = "pbx264PresetWarning";
            this.pbx264PresetWarning.TabStop = false;
            this.ttHelpTip.SetToolTip(this.pbx264PresetWarning, resources.GetString("pbx264PresetWarning.ToolTip"));
            // 
            // tbOpusBitrate
            // 
            this.tbOpusBitrate.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.tbOpusBitrate, "tbOpusBitrate");
            this.tbOpusBitrate.LargeChange = 1;
            this.tbOpusBitrate.Maximum = 16;
            this.tbOpusBitrate.Minimum = 1;
            this.tbOpusBitrate.Name = "tbOpusBitrate";
            this.tbOpusBitrate.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ttHelpTip.SetToolTip(this.tbOpusBitrate, resources.GetString("tbOpusBitrate.ToolTip"));
            this.tbOpusBitrate.Value = 4;
            this.tbOpusBitrate.ValueChanged += new System.EventHandler(this.tbOpusBirate_ValueChanged);
            // 
            // watermark_opacity
            // 
            resources.ApplyResources(this.watermark_opacity, "watermark_opacity");
            this.watermark_opacity.Maximum = 100;
            this.watermark_opacity.Name = "watermark_opacity";
            this.ttHelpTip.SetToolTip(this.watermark_opacity, resources.GetString("watermark_opacity.ToolTip"));
            this.watermark_opacity.Value = 50;
            this.watermark_opacity.Scroll += new System.EventHandler(this.opacity_Scroll);
            // 
            // lblCodec
            // 
            resources.ApplyResources(this.lblCodec, "lblCodec");
            this.lblCodec.Name = "lblCodec";
            // 
            // cboVideoCodec
            // 
            this.cboVideoCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoCodec.FormattingEnabled = true;
            resources.ApplyResources(this.cboVideoCodec, "cboVideoCodec");
            this.cboVideoCodec.Name = "cboVideoCodec";
            this.cboVideoCodec.SelectedIndexChanged += new System.EventHandler(this.cboVideoCodec_SelectedIndexChanged);
            // 
            // lblx264Preset
            // 
            resources.ApplyResources(this.lblx264Preset, "lblx264Preset");
            this.lblx264Preset.Name = "lblx264Preset";
            // 
            // lblXvidQscale
            // 
            resources.ApplyResources(this.lblXvidQscale, "lblXvidQscale");
            this.lblXvidQscale.Name = "lblXvidQscale";
            // 
            // gbFFmpegExe
            // 
            this.gbFFmpegExe.Controls.Add(this.btnDownload);
            this.gbFFmpegExe.Controls.Add(this.btnFFmpegBrowse);
            this.gbFFmpegExe.Controls.Add(this.txtFFmpegPath);
            resources.ApplyResources(this.gbFFmpegExe, "gbFFmpegExe");
            this.gbFFmpegExe.Name = "gbFFmpegExe";
            this.gbFFmpegExe.TabStop = false;
            // 
            // btnDownload
            // 
            resources.ApplyResources(this.btnDownload, "btnDownload");
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnFFmpegBrowse
            // 
            resources.ApplyResources(this.btnFFmpegBrowse, "btnFFmpegBrowse");
            this.btnFFmpegBrowse.Name = "btnFFmpegBrowse";
            this.btnFFmpegBrowse.UseVisualStyleBackColor = true;
            this.btnFFmpegBrowse.Click += new System.EventHandler(this.buttonFFmpegBrowse_Click);
            // 
            // txtFFmpegPath
            // 
            resources.ApplyResources(this.txtFFmpegPath, "txtFFmpegPath");
            this.txtFFmpegPath.Name = "txtFFmpegPath";
            this.txtFFmpegPath.TextChanged += new System.EventHandler(this.txtFFmpegPath_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.watermark_opacity_text);
            this.groupBox3.Controls.Add(this.watermark_opacity);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // watermark_opacity_text
            // 
            resources.ApplyResources(this.watermark_opacity_text, "watermark_opacity_text");
            this.watermark_opacity_text.Name = "watermark_opacity_text";
            // 
            // cbOverrideFFmpegPath
            // 
            resources.ApplyResources(this.cbOverrideFFmpegPath, "cbOverrideFFmpegPath");
            this.cbOverrideFFmpegPath.Name = "cbOverrideFFmpegPath";
            this.cbOverrideFFmpegPath.UseVisualStyleBackColor = true;
            this.cbOverrideFFmpegPath.CheckedChanged += new System.EventHandler(this.cbOverrideFFmpegPath_CheckedChanged);
            // 
            // gbCommandLinePreview
            // 
            this.gbCommandLinePreview.Controls.Add(this.cbCustomCommands);
            this.gbCommandLinePreview.Controls.Add(this.txtCommandLinePreview);
            resources.ApplyResources(this.gbCommandLinePreview, "gbCommandLinePreview");
            this.gbCommandLinePreview.Name = "gbCommandLinePreview";
            this.gbCommandLinePreview.TabStop = false;
            // 
            // cbCustomCommands
            // 
            resources.ApplyResources(this.cbCustomCommands, "cbCustomCommands");
            this.cbCustomCommands.Name = "cbCustomCommands";
            this.cbCustomCommands.UseVisualStyleBackColor = true;
            this.cbCustomCommands.CheckedChanged += new System.EventHandler(this.cbCustomCommands_CheckedChanged);
            // 
            // txtCommandLinePreview
            // 
            resources.ApplyResources(this.txtCommandLinePreview, "txtCommandLinePreview");
            this.txtCommandLinePreview.Name = "txtCommandLinePreview";
            this.txtCommandLinePreview.ReadOnly = true;
            this.txtCommandLinePreview.TextChanged += new System.EventHandler(this.txtCommandLinePreview_TextChanged);
            // 
            // gbCommandLineArgs
            // 
            this.gbCommandLineArgs.Controls.Add(this.tbUserArgs);
            resources.ApplyResources(this.gbCommandLineArgs, "gbCommandLineArgs");
            this.gbCommandLineArgs.Name = "gbCommandLineArgs";
            this.gbCommandLineArgs.TabStop = false;
            // 
            // tbUserArgs
            // 
            resources.ApplyResources(this.tbUserArgs, "tbUserArgs");
            this.tbUserArgs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbUserArgs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbUserArgs.Name = "tbUserArgs";
            this.tbUserArgs.TextChanged += new System.EventHandler(this.tbUserArgs_TextChanged);
            // 
            // tcFFmpegVideoCodecs
            // 
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpX264);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpVpx);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpXvid);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpNVENC);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tpGIF);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tbAMF);
            this.tcFFmpegVideoCodecs.Controls.Add(this.tbQSV);
            resources.ApplyResources(this.tcFFmpegVideoCodecs, "tcFFmpegVideoCodecs");
            this.tcFFmpegVideoCodecs.Name = "tcFFmpegVideoCodecs";
            this.tcFFmpegVideoCodecs.SelectedIndex = 0;
            // 
            // tpX264
            // 
            this.tpX264.BackColor = System.Drawing.SystemColors.Window;
            this.tpX264.Controls.Add(this.pbx264PresetWarning);
            this.tpX264.Controls.Add(this.nudx264CRF);
            this.tpX264.Controls.Add(this.lblx264CRF);
            this.tpX264.Controls.Add(this.cbx264Preset);
            this.tpX264.Controls.Add(this.lblx264Preset);
            resources.ApplyResources(this.tpX264, "tpX264");
            this.tpX264.Name = "tpX264";
            // 
            // tpVpx
            // 
            this.tpVpx.BackColor = System.Drawing.SystemColors.Window;
            this.tpVpx.Controls.Add(this.lblVP8BitrateK);
            this.tpVpx.Controls.Add(this.nudVP8Bitrate);
            this.tpVpx.Controls.Add(this.lblVP8Bitrate);
            resources.ApplyResources(this.tpVpx, "tpVpx");
            this.tpVpx.Name = "tpVpx";
            // 
            // lblVP8BitrateK
            // 
            resources.ApplyResources(this.lblVP8BitrateK, "lblVP8BitrateK");
            this.lblVP8BitrateK.Name = "lblVP8BitrateK";
            // 
            // nudVP8Bitrate
            // 
            this.nudVP8Bitrate.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            resources.ApplyResources(this.nudVP8Bitrate, "nudVP8Bitrate");
            this.nudVP8Bitrate.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nudVP8Bitrate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudVP8Bitrate.Name = "nudVP8Bitrate";
            this.nudVP8Bitrate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudVP8Bitrate.ValueChanged += new System.EventHandler(this.nudVP8Bitrate_ValueChanged);
            // 
            // lblVP8Bitrate
            // 
            resources.ApplyResources(this.lblVP8Bitrate, "lblVP8Bitrate");
            this.lblVP8Bitrate.Name = "lblVP8Bitrate";
            // 
            // tpXvid
            // 
            this.tpXvid.BackColor = System.Drawing.SystemColors.Window;
            this.tpXvid.Controls.Add(this.nudXvidQscale);
            this.tpXvid.Controls.Add(this.lblXvidQscale);
            resources.ApplyResources(this.tpXvid, "tpXvid");
            this.tpXvid.Name = "tpXvid";
            // 
            // tpNVENC
            // 
            this.tpNVENC.BackColor = System.Drawing.SystemColors.Window;
            this.tpNVENC.Controls.Add(this.cbNVENCPreset);
            this.tpNVENC.Controls.Add(this.lblNVENCPreset);
            this.tpNVENC.Controls.Add(this.nudNVENCBitrate);
            this.tpNVENC.Controls.Add(this.lblNVENCBitrate);
            resources.ApplyResources(this.tpNVENC, "tpNVENC");
            this.tpNVENC.Name = "tpNVENC";
            // 
            // cbNVENCPreset
            // 
            this.cbNVENCPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNVENCPreset.FormattingEnabled = true;
            resources.ApplyResources(this.cbNVENCPreset, "cbNVENCPreset");
            this.cbNVENCPreset.Name = "cbNVENCPreset";
            this.cbNVENCPreset.SelectedIndexChanged += new System.EventHandler(this.cbNVENCPreset_SelectedIndexChanged);
            // 
            // lblNVENCPreset
            // 
            resources.ApplyResources(this.lblNVENCPreset, "lblNVENCPreset");
            this.lblNVENCPreset.Name = "lblNVENCPreset";
            // 
            // nudNVENCBitrate
            // 
            resources.ApplyResources(this.nudNVENCBitrate, "nudNVENCBitrate");
            this.nudNVENCBitrate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudNVENCBitrate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudNVENCBitrate.Name = "nudNVENCBitrate";
            this.nudNVENCBitrate.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudNVENCBitrate.ValueChanged += new System.EventHandler(this.nudNVENCBitrate_ValueChanged);
            // 
            // lblNVENCBitrate
            // 
            resources.ApplyResources(this.lblNVENCBitrate, "lblNVENCBitrate");
            this.lblNVENCBitrate.Name = "lblNVENCBitrate";
            // 
            // tpGIF
            // 
            this.tpGIF.BackColor = System.Drawing.SystemColors.Window;
            this.tpGIF.Controls.Add(this.cbGIFDither);
            this.tpGIF.Controls.Add(this.lblGIFDither);
            this.tpGIF.Controls.Add(this.cbGIFStatsMode);
            this.tpGIF.Controls.Add(this.lblGIFStatsMode);
            resources.ApplyResources(this.tpGIF, "tpGIF");
            this.tpGIF.Name = "tpGIF";
            // 
            // lblGIFDither
            // 
            resources.ApplyResources(this.lblGIFDither, "lblGIFDither");
            this.lblGIFDither.Name = "lblGIFDither";
            // 
            // lblGIFStatsMode
            // 
            resources.ApplyResources(this.lblGIFStatsMode, "lblGIFStatsMode");
            this.lblGIFStatsMode.Name = "lblGIFStatsMode";
            // 
            // tbAMF
            // 
            this.tbAMF.Controls.Add(this.cbAMFQuality);
            this.tbAMF.Controls.Add(this.lblAMFQuality);
            this.tbAMF.Controls.Add(this.cbAMFUsage);
            this.tbAMF.Controls.Add(this.lblAMFUsage);
            resources.ApplyResources(this.tbAMF, "tbAMF");
            this.tbAMF.Name = "tbAMF";
            this.tbAMF.UseVisualStyleBackColor = true;
            // 
            // cbAMFQuality
            // 
            this.cbAMFQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAMFQuality.FormattingEnabled = true;
            resources.ApplyResources(this.cbAMFQuality, "cbAMFQuality");
            this.cbAMFQuality.Name = "cbAMFQuality";
            this.cbAMFQuality.SelectedIndexChanged += new System.EventHandler(this.cbAMFQuality_SelectedIndexChanged);
            // 
            // lblAMFQuality
            // 
            resources.ApplyResources(this.lblAMFQuality, "lblAMFQuality");
            this.lblAMFQuality.Name = "lblAMFQuality";
            // 
            // cbAMFUsage
            // 
            this.cbAMFUsage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAMFUsage.FormattingEnabled = true;
            resources.ApplyResources(this.cbAMFUsage, "cbAMFUsage");
            this.cbAMFUsage.Name = "cbAMFUsage";
            this.cbAMFUsage.SelectedIndexChanged += new System.EventHandler(this.cbAMFUsage_SelectedIndexChanged);
            // 
            // lblAMFUsage
            // 
            resources.ApplyResources(this.lblAMFUsage, "lblAMFUsage");
            this.lblAMFUsage.Name = "lblAMFUsage";
            // 
            // tbQSV
            // 
            this.tbQSV.Controls.Add(this.cbQSVPreset);
            this.tbQSV.Controls.Add(this.lblQSVPreset);
            this.tbQSV.Controls.Add(this.nudQSVBitrate);
            this.tbQSV.Controls.Add(this.lblQSVBitrate);
            resources.ApplyResources(this.tbQSV, "tbQSV");
            this.tbQSV.Name = "tbQSV";
            this.tbQSV.UseVisualStyleBackColor = true;
            // 
            // cbQSVPreset
            // 
            this.cbQSVPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQSVPreset.FormattingEnabled = true;
            resources.ApplyResources(this.cbQSVPreset, "cbQSVPreset");
            this.cbQSVPreset.Name = "cbQSVPreset";
            this.cbQSVPreset.SelectedIndexChanged += new System.EventHandler(this.cbQSVPreset_SelectedIndexChanged);
            // 
            // lblQSVPreset
            // 
            resources.ApplyResources(this.lblQSVPreset, "lblQSVPreset");
            this.lblQSVPreset.Name = "lblQSVPreset";
            // 
            // nudQSVBitrate
            // 
            resources.ApplyResources(this.nudQSVBitrate, "nudQSVBitrate");
            this.nudQSVBitrate.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudQSVBitrate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudQSVBitrate.Name = "nudQSVBitrate";
            this.nudQSVBitrate.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudQSVBitrate.ValueChanged += new System.EventHandler(this.nudQSVBitrate_ValueChanged);
            // 
            // lblQSVBitrate
            // 
            resources.ApplyResources(this.lblQSVBitrate, "lblQSVBitrate");
            this.lblQSVBitrate.Name = "lblQSVBitrate";
            // 
            // btnTest
            // 
            resources.ApplyResources(this.btnTest, "btnTest");
            this.btnTest.Name = "btnTest";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnCopyPreview
            // 
            resources.ApplyResources(this.btnCopyPreview, "btnCopyPreview");
            this.btnCopyPreview.Name = "btnCopyPreview";
            this.btnCopyPreview.UseVisualStyleBackColor = true;
            this.btnCopyPreview.Click += new System.EventHandler(this.btnCopyPreview_Click);
            // 
            // tcFFmpegAudioCodecs
            // 
            this.tcFFmpegAudioCodecs.Controls.Add(this.tpAAC);
            this.tcFFmpegAudioCodecs.Controls.Add(this.tpOpus);
            this.tcFFmpegAudioCodecs.Controls.Add(this.tpVorbis);
            this.tcFFmpegAudioCodecs.Controls.Add(this.tpMP3);
            resources.ApplyResources(this.tcFFmpegAudioCodecs, "tcFFmpegAudioCodecs");
            this.tcFFmpegAudioCodecs.Name = "tcFFmpegAudioCodecs";
            this.tcFFmpegAudioCodecs.SelectedIndex = 0;
            // 
            // tpAAC
            // 
            this.tpAAC.BackColor = System.Drawing.SystemColors.Window;
            this.tpAAC.Controls.Add(this.tbAACBitrate);
            this.tpAAC.Controls.Add(this.lblAACQuality);
            resources.ApplyResources(this.tpAAC, "tpAAC");
            this.tpAAC.Name = "tpAAC";
            // 
            // lblAACQuality
            // 
            resources.ApplyResources(this.lblAACQuality, "lblAACQuality");
            this.lblAACQuality.Name = "lblAACQuality";
            // 
            // tpOpus
            // 
            this.tpOpus.Controls.Add(this.tbOpusBitrate);
            this.tpOpus.Controls.Add(this.lblOpusQuality);
            resources.ApplyResources(this.tpOpus, "tpOpus");
            this.tpOpus.Name = "tpOpus";
            this.tpOpus.UseVisualStyleBackColor = true;
            // 
            // lblOpusQuality
            // 
            resources.ApplyResources(this.lblOpusQuality, "lblOpusQuality");
            this.lblOpusQuality.Name = "lblOpusQuality";
            // 
            // tpVorbis
            // 
            this.tpVorbis.BackColor = System.Drawing.SystemColors.Window;
            this.tpVorbis.Controls.Add(this.tbVorbis_qscale);
            this.tpVorbis.Controls.Add(this.lblVorbisQuality);
            resources.ApplyResources(this.tpVorbis, "tpVorbis");
            this.tpVorbis.Name = "tpVorbis";
            // 
            // lblVorbisQuality
            // 
            resources.ApplyResources(this.lblVorbisQuality, "lblVorbisQuality");
            this.lblVorbisQuality.Name = "lblVorbisQuality";
            // 
            // tpMP3
            // 
            this.tpMP3.BackColor = System.Drawing.SystemColors.Window;
            this.tpMP3.Controls.Add(this.tbMP3_qscale);
            this.tpMP3.Controls.Add(this.lblMP3Quality);
            resources.ApplyResources(this.tpMP3, "tpMP3");
            this.tpMP3.Name = "tpMP3";
            // 
            // lblMP3Quality
            // 
            resources.ApplyResources(this.lblMP3Quality, "lblMP3Quality");
            this.lblMP3Quality.Name = "lblMP3Quality";
            // 
            // cboVideoSource
            // 
            this.cboVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideoSource.FormattingEnabled = true;
            resources.ApplyResources(this.cboVideoSource, "cboVideoSource");
            this.cboVideoSource.Name = "cboVideoSource";
            this.cboVideoSource.SelectedIndexChanged += new System.EventHandler(this.cboVideoSource_SelectedIndexChanged);
            // 
            // lblVideoSource
            // 
            resources.ApplyResources(this.lblVideoSource, "lblVideoSource");
            this.lblVideoSource.Name = "lblVideoSource";
            // 
            // cboAudioSource
            // 
            this.cboAudioSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioSource.FormattingEnabled = true;
            resources.ApplyResources(this.cboAudioSource, "cboAudioSource");
            this.cboAudioSource.Name = "cboAudioSource";
            this.cboAudioSource.SelectedIndexChanged += new System.EventHandler(this.cboAudioSource_SelectedIndexChanged);
            // 
            // lblAudioSource
            // 
            resources.ApplyResources(this.lblAudioSource, "lblAudioSource");
            this.lblAudioSource.Name = "lblAudioSource";
            // 
            // cboAudioCodec
            // 
            this.cboAudioCodec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAudioCodec.FormattingEnabled = true;
            resources.ApplyResources(this.cboAudioCodec, "cboAudioCodec");
            this.cboAudioCodec.Name = "cboAudioCodec";
            this.cboAudioCodec.SelectedIndexChanged += new System.EventHandler(this.cboAudioCodec_SelectedIndexChanged);
            // 
            // lblAudioCodec
            // 
            resources.ApplyResources(this.lblAudioCodec, "lblAudioCodec");
            this.lblAudioCodec.Name = "lblAudioCodec";
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.btnHelperDevicesHelp);
            this.gbSource.Controls.Add(this.lblHelperDevices);
            this.gbSource.Controls.Add(this.btnInstallHelperDevices);
            this.gbSource.Controls.Add(this.cboVideoSource);
            this.gbSource.Controls.Add(this.lblVideoSource);
            this.gbSource.Controls.Add(this.cboAudioSource);
            this.gbSource.Controls.Add(this.lblAudioSource);
            this.gbSource.Controls.Add(this.btnRefreshSources);
            resources.ApplyResources(this.gbSource, "gbSource");
            this.gbSource.Name = "gbSource";
            this.gbSource.TabStop = false;
            // 
            // btnHelperDevicesHelp
            // 
            resources.ApplyResources(this.btnHelperDevicesHelp, "btnHelperDevicesHelp");
            this.btnHelperDevicesHelp.Name = "btnHelperDevicesHelp";
            this.btnHelperDevicesHelp.UseVisualStyleBackColor = true;
            this.btnHelperDevicesHelp.Click += new System.EventHandler(this.btnHelperDevicesHelp_Click);
            // 
            // lblHelperDevices
            // 
            resources.ApplyResources(this.lblHelperDevices, "lblHelperDevices");
            this.lblHelperDevices.Name = "lblHelperDevices";
            // 
            // btnInstallHelperDevices
            // 
            resources.ApplyResources(this.btnInstallHelperDevices, "btnInstallHelperDevices");
            this.btnInstallHelperDevices.Name = "btnInstallHelperDevices";
            this.btnInstallHelperDevices.UseVisualStyleBackColor = true;
            this.btnInstallHelperDevices.Click += new System.EventHandler(this.btnInstallHelperDevices_Click);
            // 
            // btnRefreshSources
            // 
            resources.ApplyResources(this.btnRefreshSources, "btnRefreshSources");
            this.btnRefreshSources.Name = "btnRefreshSources";
            this.btnRefreshSources.UseVisualStyleBackColor = true;
            this.btnRefreshSources.Click += new System.EventHandler(this.btnRefreshSources_Click);
            // 
            // gbCodecs
            // 
            this.gbCodecs.Controls.Add(this.pbAudioCodecWarning);
            this.gbCodecs.Controls.Add(this.cboAudioCodec);
            this.gbCodecs.Controls.Add(this.lblAudioCodec);
            this.gbCodecs.Controls.Add(this.cboVideoCodec);
            this.gbCodecs.Controls.Add(this.lblCodec);
            this.gbCodecs.Controls.Add(this.tcFFmpegAudioCodecs);
            this.gbCodecs.Controls.Add(this.tcFFmpegVideoCodecs);
            resources.ApplyResources(this.gbCodecs, "gbCodecs");
            this.gbCodecs.Name = "gbCodecs";
            this.gbCodecs.TabStop = false;
            // 
            // WaterMark
            // 
            this.WaterMark.Controls.Add(this.groupBox3);
            this.WaterMark.Controls.Add(this.groupBox2);
            this.WaterMark.Controls.Add(this.groupBox1);
            this.WaterMark.Controls.Add(this.panel3);
            resources.ApplyResources(this.WaterMark, "WaterMark");
            this.WaterMark.Name = "WaterMark";
            this.WaterMark.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.watermark_Y);
            this.groupBox2.Controls.Add(this.watermark_X);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // watermark_Y
            // 
            resources.ApplyResources(this.watermark_Y, "watermark_Y");
            this.watermark_Y.Name = "watermark_Y";
            this.watermark_Y.ValueChanged += new System.EventHandler(this.watermark_location_CheckedChanged);
            // 
            // watermark_X
            // 
            resources.ApplyResources(this.watermark_X, "watermark_X");
            this.watermark_X.Name = "watermark_X";
            this.watermark_X.ValueChanged += new System.EventHandler(this.watermark_location_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.watermark_location_top);
            this.panel1.Controls.Add(this.watermark_location_bottom);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.watermark_location_right);
            this.panel2.Controls.Add(this.watermark_location_left);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // watermark_location_right
            // 
            resources.ApplyResources(this.watermark_location_right, "watermark_location_right");
            this.watermark_location_right.Name = "watermark_location_right";
            this.watermark_location_right.Tag = "";
            this.watermark_location_right.UseVisualStyleBackColor = true;
            this.watermark_location_right.CheckedChanged += new System.EventHandler(this.watermark_location_CheckedChanged);
            // 
            // watermark_location_left
            // 
            resources.ApplyResources(this.watermark_location_left, "watermark_location_left");
            this.watermark_location_left.Name = "watermark_location_left";
            this.watermark_location_left.Tag = "";
            this.watermark_location_left.UseVisualStyleBackColor = true;
            this.watermark_location_left.CheckedChanged += new System.EventHandler(this.watermark_location_CheckedChanged);
            // 
            // watermark_location_top
            // 
            resources.ApplyResources(this.watermark_location_top, "watermark_location_top");
            this.watermark_location_top.Name = "watermark_location_top";
            this.watermark_location_top.Tag = "";
            this.watermark_location_top.UseVisualStyleBackColor = true;
            this.watermark_location_top.CheckedChanged += new System.EventHandler(this.watermark_location_CheckedChanged);
            // 
            // watermark_location_bottom
            // 
            resources.ApplyResources(this.watermark_location_bottom, "watermark_location_bottom");
            this.watermark_location_bottom.Name = "watermark_location_bottom";
            this.watermark_location_bottom.Tag = "";
            this.watermark_location_bottom.UseVisualStyleBackColor = true;
            this.watermark_location_bottom.CheckedChanged += new System.EventHandler(this.watermark_location_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.watermark_show);
            this.panel3.Controls.Add(this.watermark_use);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // watermark_show
            // 
            this.watermark_show.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.watermark_show, "watermark_show");
            this.watermark_show.Name = "watermark_show";
            this.watermark_show.TabStop = false;
            this.watermark_show.MouseClick += new System.Windows.Forms.MouseEventHandler(this.watermark_chose_MouseClick);
            // 
            // watermark_use
            // 
            resources.ApplyResources(this.watermark_use, "watermark_use");
            this.watermark_use.Name = "watermark_use";
            this.watermark_use.UseVisualStyleBackColor = true;
            this.watermark_use.CheckedChanged += new System.EventHandler(this.watermark_use_CheckedChanged);
            // 
            // eiFFmpeg
            // 
            this.eiFFmpeg.DefaultFileName = null;
            resources.ApplyResources(this.eiFFmpeg, "eiFFmpeg");
            this.eiFFmpeg.Name = "eiFFmpeg";
            this.eiFFmpeg.ObjectType = null;
            this.eiFFmpeg.ExportRequested += new ShareX.HelpersLib.ExportImportControl.ExportEventHandler(this.eiFFmpeg_ExportRequested);
            this.eiFFmpeg.ImportRequested += new ShareX.HelpersLib.ExportImportControl.ImportEventHandler(this.eiFFmpeg_ImportRequested);
            // 
            // FFmpegOptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.WaterMark);
            this.Controls.Add(this.cbOverrideFFmpegPath);
            this.Controls.Add(this.eiFFmpeg);
            this.Controls.Add(this.gbCodecs);
            this.Controls.Add(this.gbSource);
            this.Controls.Add(this.btnCopyPreview);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.gbCommandLinePreview);
            this.Controls.Add(this.gbFFmpegExe);
            this.Controls.Add(this.gbCommandLineArgs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFmpegOptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FFmpegOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudx264CRF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXvidQscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVorbis_qscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMP3_qscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAACBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAudioCodecWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx264PresetWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpusBitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_opacity)).EndInit();
            this.gbFFmpegExe.ResumeLayout(false);
            this.gbFFmpegExe.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbCommandLinePreview.ResumeLayout(false);
            this.gbCommandLinePreview.PerformLayout();
            this.gbCommandLineArgs.ResumeLayout(false);
            this.gbCommandLineArgs.PerformLayout();
            this.tcFFmpegVideoCodecs.ResumeLayout(false);
            this.tpX264.ResumeLayout(false);
            this.tpX264.PerformLayout();
            this.tpVpx.ResumeLayout(false);
            this.tpVpx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVP8Bitrate)).EndInit();
            this.tpXvid.ResumeLayout(false);
            this.tpXvid.PerformLayout();
            this.tpNVENC.ResumeLayout(false);
            this.tpNVENC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNVENCBitrate)).EndInit();
            this.tpGIF.ResumeLayout(false);
            this.tpGIF.PerformLayout();
            this.tbAMF.ResumeLayout(false);
            this.tbAMF.PerformLayout();
            this.tbQSV.ResumeLayout(false);
            this.tbQSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQSVBitrate)).EndInit();
            this.tcFFmpegAudioCodecs.ResumeLayout(false);
            this.tpAAC.ResumeLayout(false);
            this.tpAAC.PerformLayout();
            this.tpOpus.ResumeLayout(false);
            this.tpOpus.PerformLayout();
            this.tpVorbis.ResumeLayout(false);
            this.tpVorbis.PerformLayout();
            this.tpMP3.ResumeLayout(false);
            this.tpMP3.PerformLayout();
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbCodecs.ResumeLayout(false);
            this.gbCodecs.PerformLayout();
            this.WaterMark.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_X)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watermark_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblx264CRF;
        private System.Windows.Forms.NumericUpDown nudx264CRF;
        private System.Windows.Forms.ToolTip ttHelpTip;
        private System.Windows.Forms.Label lblCodec;
        private System.Windows.Forms.ComboBox cboVideoCodec;
        private System.Windows.Forms.ComboBox cbx264Preset;
        private System.Windows.Forms.Label lblx264Preset;
        private System.Windows.Forms.NumericUpDown nudXvidQscale;
        private System.Windows.Forms.Label lblXvidQscale;
        private System.Windows.Forms.GroupBox gbFFmpegExe;
        private System.Windows.Forms.Button btnFFmpegBrowse;
        private System.Windows.Forms.TextBox txtFFmpegPath;
        private System.Windows.Forms.GroupBox gbCommandLinePreview;
        private System.Windows.Forms.TextBox txtCommandLinePreview;
        private System.Windows.Forms.GroupBox gbCommandLineArgs;
        private System.Windows.Forms.TextBox tbUserArgs;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TabControl tcFFmpegVideoCodecs;
        private System.Windows.Forms.TabPage tpX264;
        private System.Windows.Forms.TabPage tpVpx;
        private System.Windows.Forms.TabPage tpXvid;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnCopyPreview;
        private System.Windows.Forms.TabControl tcFFmpegAudioCodecs;
        private System.Windows.Forms.TabPage tpVorbis;
        private System.Windows.Forms.TabPage tpMP3;
        private System.Windows.Forms.ComboBox cboVideoSource;
        private System.Windows.Forms.Label lblVideoSource;
        private System.Windows.Forms.ComboBox cboAudioSource;
        private System.Windows.Forms.Label lblAudioSource;
        private System.Windows.Forms.ComboBox cboAudioCodec;
        private System.Windows.Forms.Label lblAudioCodec;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.GroupBox gbCodecs;
        private System.Windows.Forms.Button btnRefreshSources;
        private System.Windows.Forms.TrackBar tbVorbis_qscale;
        private System.Windows.Forms.Label lblVorbisQuality;
        private System.Windows.Forms.TrackBar tbMP3_qscale;
        private System.Windows.Forms.Label lblMP3Quality;
        private System.Windows.Forms.TabPage tpAAC;
        private System.Windows.Forms.TrackBar tbAACBitrate;
        private System.Windows.Forms.Label lblAACQuality;
        private System.Windows.Forms.CheckBox cbCustomCommands;
        private ShareX.HelpersLib.ExportImportControl eiFFmpeg;
        private System.Windows.Forms.Label lblVP8BitrateK;
        private System.Windows.Forms.NumericUpDown nudVP8Bitrate;
        private System.Windows.Forms.Label lblVP8Bitrate;
        private System.Windows.Forms.TabPage tpGIF;
        private System.Windows.Forms.ComboBox cbGIFDither;
        private System.Windows.Forms.Label lblGIFDither;
        private System.Windows.Forms.ComboBox cbGIFStatsMode;
        private System.Windows.Forms.Label lblGIFStatsMode;
        private System.Windows.Forms.Button btnHelperDevicesHelp;
        private System.Windows.Forms.Label lblHelperDevices;
        private System.Windows.Forms.Button btnInstallHelperDevices;
        private System.Windows.Forms.CheckBox cbOverrideFFmpegPath;
        private System.Windows.Forms.PictureBox pbAudioCodecWarning;
        private System.Windows.Forms.PictureBox pbx264PresetWarning;
        private System.Windows.Forms.TabPage tpNVENC;
        private System.Windows.Forms.ComboBox cbNVENCPreset;
        private System.Windows.Forms.Label lblNVENCPreset;
        private System.Windows.Forms.NumericUpDown nudNVENCBitrate;
        private System.Windows.Forms.Label lblNVENCBitrate;
        private System.Windows.Forms.TabPage tbAMF;
        private System.Windows.Forms.ComboBox cbAMFUsage;
        private System.Windows.Forms.Label lblAMFUsage;
        private System.Windows.Forms.ComboBox cbAMFQuality;
        private System.Windows.Forms.Label lblAMFQuality;
        private System.Windows.Forms.TabPage tbQSV;
        private System.Windows.Forms.ComboBox cbQSVPreset;
        private System.Windows.Forms.Label lblQSVPreset;
        private System.Windows.Forms.NumericUpDown nudQSVBitrate;
        private System.Windows.Forms.Label lblQSVBitrate;
        private System.Windows.Forms.TabPage tpOpus;
        private System.Windows.Forms.TrackBar tbOpusBitrate;
        private System.Windows.Forms.Label lblOpusQuality;
        private System.Windows.Forms.GroupBox WaterMark;
        private System.Windows.Forms.PictureBox watermark_show;
        private System.Windows.Forms.CheckBox watermark_use;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton watermark_location_right;
        private System.Windows.Forms.RadioButton watermark_location_left;
        private System.Windows.Forms.RadioButton watermark_location_bottom;
        private System.Windows.Forms.RadioButton watermark_location_top;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown watermark_Y;
        private System.Windows.Forms.NumericUpDown watermark_X;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label watermark_opacity_text;
        private System.Windows.Forms.TrackBar watermark_opacity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}