namespace EZPerformanceMonitor.Debug
{
    partial class DebugSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugSettingsForm));
            this.label_LogLevel = new System.Windows.Forms.Label();
            this.label_DebugMode = new System.Windows.Forms.Label();
            this.checkBox_DebugMode = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Dropdown_LogLevel = new Bunifu.UI.WinForms.BunifuDropdown();
            this.SuspendLayout();
            // 
            // label_LogLevel
            // 
            this.label_LogLevel.AutoSize = true;
            this.label_LogLevel.Location = new System.Drawing.Point(12, 9);
            this.label_LogLevel.Name = "label_LogLevel";
            this.label_LogLevel.Size = new System.Drawing.Size(50, 13);
            this.label_LogLevel.TabIndex = 3;
            this.label_LogLevel.Text = "Log level";
            // 
            // label_DebugMode
            // 
            this.label_DebugMode.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton;
            this.label_DebugMode.AutoSize = true;
            this.label_DebugMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_DebugMode.Location = new System.Drawing.Point(41, 74);
            this.label_DebugMode.Name = "label_DebugMode";
            this.label_DebugMode.Size = new System.Drawing.Size(68, 13);
            this.label_DebugMode.TabIndex = 5;
            this.label_DebugMode.Text = "Debug mode";
            // 
            // checkBox_DebugMode
            // 
            this.checkBox_DebugMode.AllowBindingControlAnimation = true;
            this.checkBox_DebugMode.AllowBindingControlColorChanges = false;
            this.checkBox_DebugMode.AllowBindingControlLocation = true;
            this.checkBox_DebugMode.AllowCheckBoxAnimation = false;
            this.checkBox_DebugMode.AllowCheckmarkAnimation = true;
            this.checkBox_DebugMode.AllowOnHoverStates = true;
            this.checkBox_DebugMode.AutoCheck = true;
            this.checkBox_DebugMode.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_DebugMode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_DebugMode.BackgroundImage")));
            this.checkBox_DebugMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.checkBox_DebugMode.BindingControl = this.label_DebugMode;
            this.checkBox_DebugMode.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.checkBox_DebugMode.BorderRadius = 13;
            this.checkBox_DebugMode.Checked = true;
            this.checkBox_DebugMode.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.checkBox_DebugMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_DebugMode.CustomCheckmarkImage = null;
            this.checkBox_DebugMode.Location = new System.Drawing.Point(12, 69);
            this.checkBox_DebugMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_DebugMode.MinimumSize = new System.Drawing.Size(16, 17);
            this.checkBox_DebugMode.Name = "checkBox_DebugMode";
            this.checkBox_DebugMode.OnCheck.BorderColor = System.Drawing.Color.White;
            this.checkBox_DebugMode.OnCheck.BorderRadius = 13;
            this.checkBox_DebugMode.OnCheck.BorderThickness = 2;
            this.checkBox_DebugMode.OnCheck.CheckBoxColor = System.Drawing.Color.Gray;
            this.checkBox_DebugMode.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.checkBox_DebugMode.OnCheck.CheckmarkThickness = 2;
            this.checkBox_DebugMode.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.checkBox_DebugMode.OnDisable.BorderRadius = 13;
            this.checkBox_DebugMode.OnDisable.BorderThickness = 2;
            this.checkBox_DebugMode.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBox_DebugMode.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.checkBox_DebugMode.OnDisable.CheckmarkThickness = 2;
            this.checkBox_DebugMode.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBox_DebugMode.OnHoverChecked.BorderRadius = 13;
            this.checkBox_DebugMode.OnHoverChecked.BorderThickness = 2;
            this.checkBox_DebugMode.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBox_DebugMode.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.checkBox_DebugMode.OnHoverChecked.CheckmarkThickness = 2;
            this.checkBox_DebugMode.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.checkBox_DebugMode.OnHoverUnchecked.BorderRadius = 13;
            this.checkBox_DebugMode.OnHoverUnchecked.BorderThickness = 1;
            this.checkBox_DebugMode.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBox_DebugMode.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.checkBox_DebugMode.OnUncheck.BorderRadius = 13;
            this.checkBox_DebugMode.OnUncheck.BorderThickness = 1;
            this.checkBox_DebugMode.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.checkBox_DebugMode.Size = new System.Drawing.Size(26, 26);
            this.checkBox_DebugMode.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.checkBox_DebugMode.TabIndex = 41;
            this.checkBox_DebugMode.ThreeState = false;
            this.checkBox_DebugMode.ToolTipText = null;
            // 
            // Dropdown_LogLevel
            // 
            this.Dropdown_LogLevel.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown_LogLevel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.BorderRadius = 1;
            this.Dropdown_LogLevel.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Dropdown_LogLevel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.DisabledForeColor = System.Drawing.Color.White;
            this.Dropdown_LogLevel.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.Dropdown_LogLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown_LogLevel.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.Dropdown_LogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown_LogLevel.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown_LogLevel.FillDropDown = true;
            this.Dropdown_LogLevel.FillIndicator = false;
            this.Dropdown_LogLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown_LogLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dropdown_LogLevel.ForeColor = System.Drawing.Color.White;
            this.Dropdown_LogLevel.FormattingEnabled = true;
            this.Dropdown_LogLevel.Icon = null;
            this.Dropdown_LogLevel.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown_LogLevel.IndicatorColor = System.Drawing.Color.Gray;
            this.Dropdown_LogLevel.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown_LogLevel.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Dropdown_LogLevel.ItemForeColor = System.Drawing.Color.White;
            this.Dropdown_LogLevel.ItemHeight = 26;
            this.Dropdown_LogLevel.ItemHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Dropdown_LogLevel.ItemHighLightForeColor = System.Drawing.Color.White;
            this.Dropdown_LogLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.Dropdown_LogLevel.ItemTopMargin = 3;
            this.Dropdown_LogLevel.Location = new System.Drawing.Point(12, 30);
            this.Dropdown_LogLevel.Name = "Dropdown_LogLevel";
            this.Dropdown_LogLevel.Size = new System.Drawing.Size(210, 32);
            this.Dropdown_LogLevel.TabIndex = 42;
            this.Dropdown_LogLevel.Text = null;
            this.Dropdown_LogLevel.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown_LogLevel.TextLeftMargin = 5;
            this.Dropdown_LogLevel.SelectedIndexChanged += new System.EventHandler(this.Dropdown_LogLevel_SelectedIndexChanged);
            // 
            // DebugSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(234, 106);
            this.Controls.Add(this.Dropdown_LogLevel);
            this.Controls.Add(this.checkBox_DebugMode);
            this.Controls.Add(this.label_DebugMode);
            this.Controls.Add(this.label_LogLevel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DebugSettingsForm";
            this.Text = "Debug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugSettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.DebugSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_LogLevel;
        private System.Windows.Forms.Label label_DebugMode;
        private Bunifu.UI.WinForms.BunifuCheckBox checkBox_DebugMode;
        private Bunifu.UI.WinForms.BunifuDropdown Dropdown_LogLevel;
    }
}