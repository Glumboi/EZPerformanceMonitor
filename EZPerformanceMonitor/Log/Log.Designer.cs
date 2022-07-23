using System.ComponentModel;

namespace EZPerformanceMonitor.Log
{
    partial class Log
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.timer_checklogging = new System.Timers.Timer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_stoplog = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timer_checklogging)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_checklogging
            // 
            this.timer_checklogging.Enabled = true;
            this.timer_checklogging.Interval = 1000D;
            this.timer_checklogging.SynchronizingObject = this;
            this.timer_checklogging.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_checklogging_Elapsed);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(618, 397);
            this.listBox1.TabIndex = 3;
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(506, 0);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(95, 23);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear list";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_stoplog
            // 
            this.button_stoplog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_stoplog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_stoplog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_stoplog.ForeColor = System.Drawing.Color.White;
            this.button_stoplog.Location = new System.Drawing.Point(299, 0);
            this.button_stoplog.Name = "button_stoplog";
            this.button_stoplog.Size = new System.Drawing.Size(201, 23);
            this.button_stoplog.TabIndex = 4;
            this.button_stoplog.Text = "Start/Stop logging";
            this.button_stoplog.UseVisualStyleBackColor = false;
            this.button_stoplog.Click += new System.EventHandler(this.button_stoplog_Click);
            // 
            // button_export
            // 
            this.button_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_export.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_export.ForeColor = System.Drawing.Color.White;
            this.button_export.Location = new System.Drawing.Point(300, 29);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(302, 23);
            this.button_export.TabIndex = 6;
            this.button_export.Text = "Export log to .txt file";
            this.button_export.UseVisualStyleBackColor = false;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(618, 397);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_stoplog);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(634, 436);
            this.Name = "Log";
            this.Text = "Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer_checklogging)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button_export;

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_stoplog;

        private System.Windows.Forms.ListBox listBox1;

        private System.Timers.Timer timer_checklogging;

        #endregion
    }
}