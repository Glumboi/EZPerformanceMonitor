namespace EZPerformanceMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.RadToastNotificationManager.RadToastNotification radToastNotification11 = new Telerik.RadToastNotificationManager.RadToastNotification();
            this.bunifuRadialGauge_cpu = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.bunifuRadialGauge_ram = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.bunifuRadialGauge_gpu = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.groupBox_GPU = new System.Windows.Forms.GroupBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox_CPU = new System.Windows.Forms.GroupBox();
            this.groupBox_Ram = new System.Windows.Forms.GroupBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.MinimizeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.radContextMenu_notify = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem_Show = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_Close = new Telerik.WinControls.UI.RadMenuItem();
            this.ToggleSwitch_ontop = new Telerik.WinControls.UI.RadToggleSwitch();
            this.radFormConverter1 = new Telerik.WinControls.UI.RadFormConverter();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.Github_toast = new Telerik.WinControls.UI.RadToastNotificationManager(this.components);
            this.Github_notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_GPU.SuspendLayout();
            this.groupBox_CPU.SuspendLayout();
            this.groupBox_Ram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitch_ontop)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuRadialGauge_cpu
            // 
            this.bunifuRadialGauge_cpu.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge_cpu.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge_cpu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge_cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bunifuRadialGauge_cpu.LighteningFactor = 70;
            this.bunifuRadialGauge_cpu.Location = new System.Drawing.Point(10, 23);
            this.bunifuRadialGauge_cpu.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuRadialGauge_cpu.Maximum = 100;
            this.bunifuRadialGauge_cpu.Minimum = 0;
            this.bunifuRadialGauge_cpu.Name = "bunifuRadialGauge_cpu";
            this.bunifuRadialGauge_cpu.Prefix = "";
            this.bunifuRadialGauge_cpu.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge_cpu.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge_cpu.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge_cpu.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_cpu.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_cpu.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_cpu.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_cpu.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_cpu.ProgressHighValueMark = 90;
            this.bunifuRadialGauge_cpu.RangeEnd = 100;
            this.bunifuRadialGauge_cpu.RangeLabelsColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge_cpu.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuRadialGauge_cpu.RangeStart = 0;
            this.bunifuRadialGauge_cpu.ShowRangeLabels = true;
            this.bunifuRadialGauge_cpu.ShowValueLabel = true;
            this.bunifuRadialGauge_cpu.Size = new System.Drawing.Size(189, 126);
            this.bunifuRadialGauge_cpu.Suffix = "%";
            this.bunifuRadialGauge_cpu.TabIndex = 11;
            this.bunifuRadialGauge_cpu.Thickness = 30;
            this.bunifuRadialGauge_cpu.Value = 0;
            this.bunifuRadialGauge_cpu.ValueByTransition = 0;
            this.bunifuRadialGauge_cpu.ValueLabelColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge_cpu.WarningMark = 90;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.timer_update_Tick);
            // 
            // bunifuRadialGauge_ram
            // 
            this.bunifuRadialGauge_ram.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge_ram.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge_ram.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bunifuRadialGauge_ram.LighteningFactor = 70;
            this.bunifuRadialGauge_ram.Location = new System.Drawing.Point(10, 32);
            this.bunifuRadialGauge_ram.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuRadialGauge_ram.Maximum = 100;
            this.bunifuRadialGauge_ram.Minimum = 0;
            this.bunifuRadialGauge_ram.Name = "bunifuRadialGauge_ram";
            this.bunifuRadialGauge_ram.Prefix = "";
            this.bunifuRadialGauge_ram.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge_ram.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge_ram.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge_ram.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_ram.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_ram.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_ram.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_ram.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_ram.ProgressHighValueMark = 90;
            this.bunifuRadialGauge_ram.RangeEnd = 100;
            this.bunifuRadialGauge_ram.RangeLabelsColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge_ram.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuRadialGauge_ram.RangeStart = 0;
            this.bunifuRadialGauge_ram.ShowRangeLabels = true;
            this.bunifuRadialGauge_ram.ShowValueLabel = true;
            this.bunifuRadialGauge_ram.Size = new System.Drawing.Size(189, 126);
            this.bunifuRadialGauge_ram.Suffix = "%";
            this.bunifuRadialGauge_ram.TabIndex = 13;
            this.bunifuRadialGauge_ram.Thickness = 30;
            this.bunifuRadialGauge_ram.Value = 0;
            this.bunifuRadialGauge_ram.ValueByTransition = 0;
            this.bunifuRadialGauge_ram.ValueLabelColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge_ram.WarningMark = 90;
            // 
            // bunifuRadialGauge_gpu
            // 
            this.bunifuRadialGauge_gpu.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge_gpu.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge_gpu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge_gpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bunifuRadialGauge_gpu.LighteningFactor = 70;
            this.bunifuRadialGauge_gpu.Location = new System.Drawing.Point(10, 31);
            this.bunifuRadialGauge_gpu.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.bunifuRadialGauge_gpu.Maximum = 100;
            this.bunifuRadialGauge_gpu.Minimum = 0;
            this.bunifuRadialGauge_gpu.Name = "bunifuRadialGauge_gpu";
            this.bunifuRadialGauge_gpu.Prefix = "";
            this.bunifuRadialGauge_gpu.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge_gpu.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge_gpu.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge_gpu.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_gpu.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_gpu.ProgressColor2 = System.Drawing.Color.LimeGreen;
            this.bunifuRadialGauge_gpu.ProgressColorHigh = System.Drawing.Color.LimeGreen;
            this.bunifuRadialGauge_gpu.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge_gpu.ProgressHighValueMark = 95;
            this.bunifuRadialGauge_gpu.RangeEnd = 100;
            this.bunifuRadialGauge_gpu.RangeLabelsColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge_gpu.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuRadialGauge_gpu.RangeStart = 0;
            this.bunifuRadialGauge_gpu.ShowRangeLabels = true;
            this.bunifuRadialGauge_gpu.ShowValueLabel = true;
            this.bunifuRadialGauge_gpu.Size = new System.Drawing.Size(189, 126);
            this.bunifuRadialGauge_gpu.Suffix = "%";
            this.bunifuRadialGauge_gpu.TabIndex = 15;
            this.bunifuRadialGauge_gpu.Thickness = 30;
            this.bunifuRadialGauge_gpu.Value = 0;
            this.bunifuRadialGauge_gpu.ValueByTransition = 0;
            this.bunifuRadialGauge_gpu.ValueLabelColor = System.Drawing.Color.Black;
            this.bunifuRadialGauge_gpu.WarningMark = 95;
            // 
            // groupBox_GPU
            // 
            this.groupBox_GPU.Controls.Add(this.bunifuLabel1);
            this.groupBox_GPU.Controls.Add(this.bunifuRadialGauge_gpu);
            this.groupBox_GPU.Location = new System.Drawing.Point(12, 358);
            this.groupBox_GPU.Name = "groupBox_GPU";
            this.groupBox_GPU.Size = new System.Drawing.Size(209, 167);
            this.groupBox_GPU.TabIndex = 17;
            this.groupBox_GPU.TabStop = false;
            this.groupBox_GPU.Text = "groupBox1";
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.DarkRed;
            this.bunifuLabel1.Location = new System.Drawing.Point(50, 142);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(106, 15);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "Could be inaccurate";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox_CPU
            // 
            this.groupBox_CPU.Controls.Add(this.bunifuRadialGauge_cpu);
            this.groupBox_CPU.Location = new System.Drawing.Point(13, 12);
            this.groupBox_CPU.Name = "groupBox_CPU";
            this.groupBox_CPU.Size = new System.Drawing.Size(209, 167);
            this.groupBox_CPU.TabIndex = 18;
            this.groupBox_CPU.TabStop = false;
            this.groupBox_CPU.Text = "groupBox2";
            // 
            // groupBox_Ram
            // 
            this.groupBox_Ram.Controls.Add(this.bunifuRadialGauge_ram);
            this.groupBox_Ram.Location = new System.Drawing.Point(12, 185);
            this.groupBox_Ram.Name = "groupBox_Ram";
            this.groupBox_Ram.Size = new System.Drawing.Size(209, 167);
            this.groupBox_Ram.TabIndex = 18;
            this.groupBox_Ram.TabStop = false;
            this.groupBox_Ram.Text = "groupBox3";
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(56, 533);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(72, 15);
            this.bunifuLabel2.TabIndex = 20;
            this.bunifuLabel2.Text = "Always ontop";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MinimizeIcon
            // 
            this.MinimizeIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizeIcon.Icon")));
            this.MinimizeIcon.Text = "EZPCPM";
            this.MinimizeIcon.Visible = true;
            this.MinimizeIcon.BalloonTipClicked += new System.EventHandler(this.MinimizeIcon_BalloonTipClicked);
            this.MinimizeIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeIcon_MouseClick);
            this.MinimizeIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeIcon_MouseDoubleClick);
            // 
            // radContextMenu_notify
            // 
            this.radContextMenu_notify.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem_Show,
            this.radMenuItem_Close});
            // 
            // radMenuItem_Show
            // 
            this.radMenuItem_Show.Name = "radMenuItem_Show";
            this.radMenuItem_Show.Text = "Show";
            // 
            // radMenuItem_Close
            // 
            this.radMenuItem_Close.Name = "radMenuItem_Close";
            this.radMenuItem_Close.Text = "Close";
            // 
            // ToggleSwitch_ontop
            // 
            this.ToggleSwitch_ontop.Location = new System.Drawing.Point(13, 531);
            this.ToggleSwitch_ontop.Name = "ToggleSwitch_ontop";
            this.ToggleSwitch_ontop.Size = new System.Drawing.Size(37, 20);
            this.ToggleSwitch_ontop.TabIndex = 21;
            this.ToggleSwitch_ontop.ThemeName = "Crystal";
            this.ToggleSwitch_ontop.ValueChanged += new System.EventHandler(this.ToggleSwitch_ontop_ValueChanged);
            // 
            // Github_toast
            // 
            radToastNotification11.BindingData = null;
            radToastNotification11.DeliveryTime = new System.DateTimeOffset(1, 1, 1, 0, 0, 0, 0, System.TimeSpan.Parse("00:00:00"));
            radToastNotification11.Name = "ToastGeneric1";
            radToastNotification11.Tag = null;
            radToastNotification11.TemplateType = Telerik.RadToastNotificationManager.RadToastTemplateType.ToastGeneric;
            radToastNotification11.Xml = null;
            this.Github_toast.ToastNotifications.Add(radToastNotification11);
            // 
            // Github_notify
            // 
            this.Github_notify.BalloonTipTitle = "Update available!";
            this.Github_notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Github_notify.Icon")));
            this.Github_notify.Text = "EZPCPM";
            this.Github_notify.BalloonTipClicked += new System.EventHandler(this.Github_notify_BalloonTipClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(238, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToggleSwitch_ontop);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.groupBox_Ram);
            this.Controls.Add(this.groupBox_CPU);
            this.Controls.Add(this.groupBox_GPU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZPCPM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox_GPU.ResumeLayout(false);
            this.groupBox_GPU.PerformLayout();
            this.groupBox_CPU.ResumeLayout(false);
            this.groupBox_Ram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToggleSwitch_ontop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_update;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge_cpu;
        private System.Windows.Forms.Timer UpdateTimer;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge_ram;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge_gpu;
        private System.Windows.Forms.GroupBox groupBox_GPU;
        private System.Windows.Forms.GroupBox groupBox_CPU;
        private System.Windows.Forms.GroupBox groupBox_Ram;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.NotifyIcon MinimizeIcon;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu_notify;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_Show;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_Close;
        private Telerik.WinControls.UI.RadToggleSwitch ToggleSwitch_ontop;
        private Telerik.WinControls.UI.RadFormConverter radFormConverter1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadToastNotificationManager Github_toast;
        private System.Windows.Forms.NotifyIcon Github_notify;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Label label1;
    }
}

