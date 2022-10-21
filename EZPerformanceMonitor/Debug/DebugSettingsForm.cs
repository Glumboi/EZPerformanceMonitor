using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZPerformanceMonitor.Debug
{
    public partial class DebugSettingsForm : Form
    {
        public DebugSettingsForm()
        {
            InitializeComponent();
        }

        private void DebugSettingsForm_Load(object sender, EventArgs e)
        {
            Glumboi.UI.UIChanger.ChangeTitlebarToDark(Handle);
            Dropdown_LogLevel.SelectedIndex = Properties.Settings.Default.debuggingLevel;
            checkBox_DebugMode.Checked = Properties.Settings.Default.debugging;
        }

        private void checkBox_DebugMode_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            Properties.Settings.Default.debugging = checkBox_DebugMode.Checked;
        }

        private void DebugSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
            Hide();
            Properties.Settings.Default.debugging = checkBox_DebugMode.Checked;
            Properties.Settings.Default.debuggingLevel = Dropdown_LogLevel.SelectedIndex;
        }

        private void Dropdown_LogLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dropdownVal = Dropdown_LogLevel.SelectedIndex;
            if (dropdownVal < 2) Program.debugConsole.Warn($"Debug level has been set to: {dropdownVal}, some log messages might not appear after a restart!");
            Properties.Settings.Default.debuggingLevel = dropdownVal;
        }
    }
}
