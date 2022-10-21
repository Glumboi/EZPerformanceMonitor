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
            Telerik.RadToastNotificationManager.RadToastNotification radToastNotification1 = new Telerik.RadToastNotificationManager.RadToastNotification();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MinimizeIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.radContextMenu_notify = new Telerik.WinControls.UI.RadContextMenu(this.components);
            this.radMenuItem_Show = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem_Close = new Telerik.WinControls.UI.RadMenuItem();
            this.radFormConverter1 = new Telerik.WinControls.UI.RadFormConverter();
            this.Github_toast = new Telerik.WinControls.UI.RadToastNotificationManager(this.components);
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.ToggleSwitch_ontop = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.button_logwindow = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.groupBox_CPU = new System.Windows.Forms.GroupBox();
            this.label_cpuTemp = new System.Windows.Forms.Label();
            this.bunifuRadialGauge_cpu = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.groupBox_Ram = new System.Windows.Forms.GroupBox();
            this.bunifuRadialGauge_ram = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.groupBox_GPU = new System.Windows.Forms.GroupBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuRadialGauge_gpu = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            this.bunifuPanel1.SuspendLayout();
            this.groupBox_CPU.SuspendLayout();
            this.groupBox_Ram.SuspendLayout();
            this.groupBox_GPU.SuspendLayout();
            this.SuspendLayout();
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
            this.radContextMenu_notify.ThemeName = "CrystalDark";
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
            // Github_toast
            // 
            radToastNotification1.BindingData = null;
            radToastNotification1.DeliveryTime = new System.DateTimeOffset(1, 1, 1, 0, 0, 0, 0, System.TimeSpan.Parse("00:00:00"));
            radToastNotification1.Name = "ToastGeneric1";
            radToastNotification1.Tag = null;
            radToastNotification1.TemplateType = Telerik.RadToastNotificationManager.RadToastTemplateType.ToastGeneric;
            radToastNotification1.Xml = null;
            this.Github_toast.ToastNotifications.Add(radToastNotification1);
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Tick += new System.EventHandler(this.OnTick);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel2.Location = new System.Drawing.Point(55, 535);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(72, 15);
            this.bunifuLabel2.TabIndex = 26;
            this.bunifuLabel2.Text = "Always ontop";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.ToggleSwitch_ontop);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel1.Controls.Add(this.button_logwindow);
            this.bunifuPanel1.Controls.Add(this.groupBox_CPU);
            this.bunifuPanel1.Controls.Add(this.groupBox_Ram);
            this.bunifuPanel1.Controls.Add(this.groupBox_GPU);
            this.bunifuPanel1.Location = new System.Drawing.Point(-3, -2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = false;
            this.bunifuPanel1.Size = new System.Drawing.Size(240, 572);
            this.bunifuPanel1.TabIndex = 33;
            // 
            // ToggleSwitch_ontop
            // 
            this.ToggleSwitch_ontop.AllowBindingControlAnimation = true;
            this.ToggleSwitch_ontop.AllowBindingControlColorChanges = false;
            this.ToggleSwitch_ontop.AllowBindingControlLocation = true;
            this.ToggleSwitch_ontop.AllowCheckBoxAnimation = false;
            this.ToggleSwitch_ontop.AllowCheckmarkAnimation = true;
            this.ToggleSwitch_ontop.AllowOnHoverStates = true;
            this.ToggleSwitch_ontop.AutoCheck = true;
            this.ToggleSwitch_ontop.BackColor = System.Drawing.Color.Transparent;
            this.ToggleSwitch_ontop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToggleSwitch_ontop.BackgroundImage")));
            this.ToggleSwitch_ontop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ToggleSwitch_ontop.BindingControl = this.bunifuLabel3;
            this.ToggleSwitch_ontop.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ToggleSwitch_ontop.BorderRadius = 13;
            this.ToggleSwitch_ontop.Checked = true;
            this.ToggleSwitch_ontop.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.ToggleSwitch_ontop.Cursor = System.Windows.Forms.Cursors.Default;
            this.ToggleSwitch_ontop.CustomCheckmarkImage = null;
            this.ToggleSwitch_ontop.Location = new System.Drawing.Point(11, 527);
            this.ToggleSwitch_ontop.MinimumSize = new System.Drawing.Size(17, 17);
            this.ToggleSwitch_ontop.Name = "ToggleSwitch_ontop";
            this.ToggleSwitch_ontop.OnCheck.BorderColor = System.Drawing.Color.White;
            this.ToggleSwitch_ontop.OnCheck.BorderRadius = 13;
            this.ToggleSwitch_ontop.OnCheck.BorderThickness = 2;
            this.ToggleSwitch_ontop.OnCheck.CheckBoxColor = System.Drawing.Color.Gray;
            this.ToggleSwitch_ontop.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ToggleSwitch_ontop.OnCheck.CheckmarkThickness = 2;
            this.ToggleSwitch_ontop.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ToggleSwitch_ontop.OnDisable.BorderRadius = 13;
            this.ToggleSwitch_ontop.OnDisable.BorderThickness = 2;
            this.ToggleSwitch_ontop.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ToggleSwitch_ontop.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ToggleSwitch_ontop.OnDisable.CheckmarkThickness = 2;
            this.ToggleSwitch_ontop.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ToggleSwitch_ontop.OnHoverChecked.BorderRadius = 13;
            this.ToggleSwitch_ontop.OnHoverChecked.BorderThickness = 2;
            this.ToggleSwitch_ontop.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ToggleSwitch_ontop.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ToggleSwitch_ontop.OnHoverChecked.CheckmarkThickness = 2;
            this.ToggleSwitch_ontop.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ToggleSwitch_ontop.OnHoverUnchecked.BorderRadius = 13;
            this.ToggleSwitch_ontop.OnHoverUnchecked.BorderThickness = 1;
            this.ToggleSwitch_ontop.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ToggleSwitch_ontop.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.ToggleSwitch_ontop.OnUncheck.BorderRadius = 13;
            this.ToggleSwitch_ontop.OnUncheck.BorderThickness = 1;
            this.ToggleSwitch_ontop.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ToggleSwitch_ontop.Size = new System.Drawing.Size(25, 25);
            this.ToggleSwitch_ontop.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ToggleSwitch_ontop.TabIndex = 40;
            this.ToggleSwitch_ontop.ThreeState = false;
            this.ToggleSwitch_ontop.ToolTipText = null;
            this.ToggleSwitch_ontop.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.ToggleSwitch_ontop_ValueChanged);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(39, 532);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(72, 15);
            this.bunifuLabel3.TabIndex = 39;
            this.bunifuLabel3.Text = "Always ontop";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // button_logwindow
            // 
            this.button_logwindow.AllowAnimations = true;
            this.button_logwindow.AllowMouseEffects = true;
            this.button_logwindow.AllowToggling = false;
            this.button_logwindow.AnimationSpeed = 200;
            this.button_logwindow.AutoGenerateColors = false;
            this.button_logwindow.AutoRoundBorders = true;
            this.button_logwindow.AutoSizeLeftIcon = true;
            this.button_logwindow.AutoSizeRightIcon = true;
            this.button_logwindow.BackColor = System.Drawing.Color.Transparent;
            this.button_logwindow.BackColor1 = System.Drawing.Color.DimGray;
            this.button_logwindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logwindow.BackgroundImage")));
            this.button_logwindow.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_logwindow.ButtonText = "Show log";
            this.button_logwindow.ButtonTextMarginLeft = 0;
            this.button_logwindow.ColorContrastOnClick = 45;
            this.button_logwindow.ColorContrastOnHover = 45;
            this.button_logwindow.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.button_logwindow.CustomizableEdges = borderEdges1;
            this.button_logwindow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_logwindow.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_logwindow.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_logwindow.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_logwindow.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_logwindow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_logwindow.ForeColor = System.Drawing.Color.White;
            this.button_logwindow.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_logwindow.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_logwindow.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_logwindow.IconMarginLeft = 11;
            this.button_logwindow.IconPadding = 10;
            this.button_logwindow.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_logwindow.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_logwindow.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_logwindow.IconSize = 25;
            this.button_logwindow.IdleBorderColor = System.Drawing.Color.DimGray;
            this.button_logwindow.IdleBorderRadius = 27;
            this.button_logwindow.IdleBorderThickness = 1;
            this.button_logwindow.IdleFillColor = System.Drawing.Color.DimGray;
            this.button_logwindow.IdleIconLeftImage = null;
            this.button_logwindow.IdleIconRightImage = null;
            this.button_logwindow.IndicateFocus = false;
            this.button_logwindow.Location = new System.Drawing.Point(135, 526);
            this.button_logwindow.Name = "button_logwindow";
            this.button_logwindow.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_logwindow.OnDisabledState.BorderRadius = 1;
            this.button_logwindow.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_logwindow.OnDisabledState.BorderThickness = 1;
            this.button_logwindow.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_logwindow.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_logwindow.OnDisabledState.IconLeftImage = null;
            this.button_logwindow.OnDisabledState.IconRightImage = null;
            this.button_logwindow.onHoverState.BorderColor = System.Drawing.Color.Silver;
            this.button_logwindow.onHoverState.BorderRadius = 1;
            this.button_logwindow.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_logwindow.onHoverState.BorderThickness = 1;
            this.button_logwindow.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.button_logwindow.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_logwindow.onHoverState.IconLeftImage = null;
            this.button_logwindow.onHoverState.IconRightImage = null;
            this.button_logwindow.OnIdleState.BorderColor = System.Drawing.Color.DimGray;
            this.button_logwindow.OnIdleState.BorderRadius = 1;
            this.button_logwindow.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_logwindow.OnIdleState.BorderThickness = 1;
            this.button_logwindow.OnIdleState.FillColor = System.Drawing.Color.DimGray;
            this.button_logwindow.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_logwindow.OnIdleState.IconLeftImage = null;
            this.button_logwindow.OnIdleState.IconRightImage = null;
            this.button_logwindow.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_logwindow.OnPressedState.BorderRadius = 1;
            this.button_logwindow.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_logwindow.OnPressedState.BorderThickness = 1;
            this.button_logwindow.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_logwindow.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_logwindow.OnPressedState.IconLeftImage = null;
            this.button_logwindow.OnPressedState.IconRightImage = null;
            this.button_logwindow.Size = new System.Drawing.Size(85, 29);
            this.button_logwindow.TabIndex = 38;
            this.button_logwindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_logwindow.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_logwindow.TextMarginLeft = 0;
            this.button_logwindow.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_logwindow.UseDefaultRadiusAndThickness = true;
            this.button_logwindow.Click += new System.EventHandler(this.button_log_Click);
            // 
            // groupBox_CPU
            // 
            this.groupBox_CPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox_CPU.Controls.Add(this.label_cpuTemp);
            this.groupBox_CPU.Controls.Add(this.bunifuRadialGauge_cpu);
            this.groupBox_CPU.ForeColor = System.Drawing.Color.White;
            this.groupBox_CPU.Location = new System.Drawing.Point(11, 7);
            this.groupBox_CPU.Name = "groupBox_CPU";
            this.groupBox_CPU.Size = new System.Drawing.Size(209, 167);
            this.groupBox_CPU.TabIndex = 36;
            this.groupBox_CPU.TabStop = false;
            this.groupBox_CPU.Text = "groupBox2";
            // 
            // label_cpuTemp
            // 
            this.label_cpuTemp.Location = new System.Drawing.Point(48, 136);
            this.label_cpuTemp.Name = "label_cpuTemp";
            this.label_cpuTemp.Size = new System.Drawing.Size(118, 13);
            this.label_cpuTemp.TabIndex = 12;
            this.label_cpuTemp.Text = "CPU Package: 51°C";
            // 
            // bunifuRadialGauge_cpu
            // 
            this.bunifuRadialGauge_cpu.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge_cpu.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge_cpu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge_cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bunifuRadialGauge_cpu.LighteningFactor = 70;
            this.bunifuRadialGauge_cpu.Location = new System.Drawing.Point(5, 23);
            this.bunifuRadialGauge_cpu.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuRadialGauge_cpu.Maximum = 100;
            this.bunifuRadialGauge_cpu.Minimum = 0;
            this.bunifuRadialGauge_cpu.Name = "bunifuRadialGauge_cpu";
            this.bunifuRadialGauge_cpu.Prefix = "";
            this.bunifuRadialGauge_cpu.ProgressBackColor = System.Drawing.Color.Gray;
            this.bunifuRadialGauge_cpu.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuRadialGauge_cpu.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge_cpu.ProgressColor = System.Drawing.Color.White;
            this.bunifuRadialGauge_cpu.ProgressColor1 = System.Drawing.Color.White;
            this.bunifuRadialGauge_cpu.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_cpu.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_cpu.ProgressColorLow = System.Drawing.Color.White;
            this.bunifuRadialGauge_cpu.ProgressHighValueMark = 90;
            this.bunifuRadialGauge_cpu.RangeEnd = 100;
            this.bunifuRadialGauge_cpu.RangeLabelsColor = System.Drawing.Color.White;
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
            this.bunifuRadialGauge_cpu.ValueLabelColor = System.Drawing.Color.White;
            this.bunifuRadialGauge_cpu.WarningMark = 90;
            this.bunifuRadialGauge_cpu.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadialGauge.ValueChangedEventArgs>(this.bunifuRadialGauge_cpu_ValueChanged);
            // 
            // groupBox_Ram
            // 
            this.groupBox_Ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox_Ram.Controls.Add(this.bunifuRadialGauge_ram);
            this.groupBox_Ram.ForeColor = System.Drawing.Color.White;
            this.groupBox_Ram.Location = new System.Drawing.Point(10, 180);
            this.groupBox_Ram.Name = "groupBox_Ram";
            this.groupBox_Ram.Size = new System.Drawing.Size(209, 167);
            this.groupBox_Ram.TabIndex = 35;
            this.groupBox_Ram.TabStop = false;
            this.groupBox_Ram.Text = "groupBox3";
            // 
            // bunifuRadialGauge_ram
            // 
            this.bunifuRadialGauge_ram.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge_ram.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge_ram.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bunifuRadialGauge_ram.LighteningFactor = 70;
            this.bunifuRadialGauge_ram.Location = new System.Drawing.Point(5, 32);
            this.bunifuRadialGauge_ram.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuRadialGauge_ram.Maximum = 100;
            this.bunifuRadialGauge_ram.Minimum = 0;
            this.bunifuRadialGauge_ram.Name = "bunifuRadialGauge_ram";
            this.bunifuRadialGauge_ram.Prefix = "";
            this.bunifuRadialGauge_ram.ProgressBackColor = System.Drawing.Color.Gray;
            this.bunifuRadialGauge_ram.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuRadialGauge_ram.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge_ram.ProgressColor = System.Drawing.Color.White;
            this.bunifuRadialGauge_ram.ProgressColor1 = System.Drawing.Color.White;
            this.bunifuRadialGauge_ram.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_ram.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge_ram.ProgressColorLow = System.Drawing.Color.White;
            this.bunifuRadialGauge_ram.ProgressHighValueMark = 90;
            this.bunifuRadialGauge_ram.RangeEnd = 100;
            this.bunifuRadialGauge_ram.RangeLabelsColor = System.Drawing.Color.White;
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
            this.bunifuRadialGauge_ram.ValueLabelColor = System.Drawing.Color.White;
            this.bunifuRadialGauge_ram.WarningMark = 90;
            this.bunifuRadialGauge_ram.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadialGauge.ValueChangedEventArgs>(this.bunifuRadialGauge_ram_ValueChanged);
            // 
            // groupBox_GPU
            // 
            this.groupBox_GPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.groupBox_GPU.Controls.Add(this.bunifuLabel1);
            this.groupBox_GPU.Controls.Add(this.bunifuRadialGauge_gpu);
            this.groupBox_GPU.ForeColor = System.Drawing.Color.White;
            this.groupBox_GPU.Location = new System.Drawing.Point(10, 353);
            this.groupBox_GPU.Name = "groupBox_GPU";
            this.groupBox_GPU.Size = new System.Drawing.Size(209, 167);
            this.groupBox_GPU.TabIndex = 34;
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
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuLabel1.Location = new System.Drawing.Point(50, 142);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(106, 15);
            this.bunifuLabel1.TabIndex = 16;
            this.bunifuLabel1.Text = "Could be inaccurate";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuRadialGauge_gpu
            // 
            this.bunifuRadialGauge_gpu.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge_gpu.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge_gpu.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge_gpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bunifuRadialGauge_gpu.LighteningFactor = 70;
            this.bunifuRadialGauge_gpu.Location = new System.Drawing.Point(7, 23);
            this.bunifuRadialGauge_gpu.Margin = new System.Windows.Forms.Padding(7);
            this.bunifuRadialGauge_gpu.Maximum = 100;
            this.bunifuRadialGauge_gpu.Minimum = 0;
            this.bunifuRadialGauge_gpu.Name = "bunifuRadialGauge_gpu";
            this.bunifuRadialGauge_gpu.Prefix = "";
            this.bunifuRadialGauge_gpu.ProgressBackColor = System.Drawing.Color.Gray;
            this.bunifuRadialGauge_gpu.ProgressBgColor = System.Drawing.Color.Gray;
            this.bunifuRadialGauge_gpu.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge_gpu.ProgressColor = System.Drawing.Color.White;
            this.bunifuRadialGauge_gpu.ProgressColor1 = System.Drawing.Color.White;
            this.bunifuRadialGauge_gpu.ProgressColor2 = System.Drawing.Color.LimeGreen;
            this.bunifuRadialGauge_gpu.ProgressColorHigh = System.Drawing.Color.LimeGreen;
            this.bunifuRadialGauge_gpu.ProgressColorLow = System.Drawing.Color.White;
            this.bunifuRadialGauge_gpu.ProgressHighValueMark = 95;
            this.bunifuRadialGauge_gpu.RangeEnd = 100;
            this.bunifuRadialGauge_gpu.RangeLabelsColor = System.Drawing.Color.White;
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
            this.bunifuRadialGauge_gpu.ValueLabelColor = System.Drawing.Color.White;
            this.bunifuRadialGauge_gpu.WarningMark = 95;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(225, 562);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZPCPM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.groupBox_CPU.ResumeLayout(false);
            this.groupBox_Ram.ResumeLayout(false);
            this.groupBox_GPU.ResumeLayout(false);
            this.groupBox_GPU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_update;
        private System.Windows.Forms.NotifyIcon MinimizeIcon;
        private Telerik.WinControls.UI.RadContextMenu radContextMenu_notify;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_Show;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem_Close;
        private Telerik.WinControls.UI.RadFormConverter radFormConverter1;
        private Telerik.WinControls.UI.RadToastNotificationManager Github_toast;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private System.Windows.Forms.Timer tick;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_logwindow;
        private System.Windows.Forms.GroupBox groupBox_CPU;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge_cpu;
        private System.Windows.Forms.GroupBox groupBox_Ram;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge_ram;
        private System.Windows.Forms.GroupBox groupBox_GPU;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge_gpu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuCheckBox ToggleSwitch_ontop;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private System.Windows.Forms.Label label_cpuTemp;
    }
}

