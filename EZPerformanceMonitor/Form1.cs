using EZPerformanceMonitor.Core;
using EZPerformanceMonitor.Splash;
using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EZPerformanceMonitor
{
    public partial class Form1 : Form
    {
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        private readonly SystemUsage _usage = new SystemUsage();
        private readonly GetSpecs _specs = new GetSpecs();
        private readonly VersionControl _version = new VersionControl();
        private readonly SplashScreen _splash = new SplashScreen();
        private readonly ExtraFunctions _ext = new ExtraFunctions();
        private readonly Log.Log _log = new Log.Log();
        private bool _ontop;

        public Form1()
        {
            InitializeComponent();
        }

        private async Task<string> GetGithubVersionAsync()
        {
            //Get all releases from GitHub
            //Source: https://octokitnet.readthedocs.io/en/latest/getting-started/
            var client = new GitHubClient(new ProductHeaderValue("EZPCPM"));
            var releases = await client.Repository.Release.GetAll("Glumboi", "EZPerformanceMonitor");

            //Setup the versions
            var latestGitHubVersion = new Version(releases[0].TagName);

            return latestGitHubVersion.ToString();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();

            await Task.Run(() =>
            {
                while (Process.GetProcessesByName(Assembly.GetExecutingAssembly().GetName().Name).Length > 0)
                {
                    List<int> usages = _usage.Usages();
                    bunifuRadialGauge_cpu.Value = usages[0];
                    bunifuRadialGauge_ram.Value = usages[1];
                    bunifuRadialGauge_gpu.Value = usages[2];
                }
            });
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.ontop = _ontop;
            Properties.Settings.Default.Save();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();

            _ext.CloseAll();
        }
        
        private async Task GetSettings()
        {
            _ontop = Properties.Settings.Default.ontop;

            if (Properties.Settings.Default.ontop)
            {
                ToggleOnTop(true);
            }
            else
            {
                ToggleOnTop(false);
            }

            groupBox_CPU.Text = _specs.GetCpuName();
            groupBox_GPU.Text = _specs.GetGpuName();
            groupBox_Ram.Text = _specs.GetRamClock() + " (" + _specs.GetRamSize() + ")";

            if (await _version.CheckGitHubNewerVersion())
            {
                DialogResult _dlg = MessageBox.Show("There is a new version available!\n\n" +
                                                    "Do you want to download it now?\n\n" +
                                                    "Current Version: " +
                                                    Assembly.GetExecutingAssembly().GetName().Version + "\n" +
                                                    "New Version: " + await GetGithubVersionAsync(), "Update Available",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dlg == DialogResult.Yes)
                {
                    Process.Start("https://github.com/Glumboi/EZPerformanceMonitor/releases/");
                }
            }
        }

        private void ShowWindow()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if(_log.WindowState == FormWindowState.Minimized)
                {
                    _log.Show();
                }
                Show();
                WindowState = FormWindowState.Normal;
            }

            radContextMenu_notify.DropDown.Hide();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MinimizeIcon.BalloonTipTitle = "App minimized to tray";
            MinimizeIcon.BalloonTipText =
                "App successfully minimized to tray.\nDouble click on it to show the window again.";

            if (FormWindowState.Minimized == WindowState)
            {
                MinimizeIcon.Visible = true;
                MinimizeIcon.ShowBalloonTip(500);
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                MinimizeIcon.Visible = false;
            }
        }

        private void MinimizeIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void MinimizeIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                radContextMenu_notify.Show(Cursor.Position);
                radContextMenu_notify.Items[0].Click += ShowWindow_Event;
                radContextMenu_notify.Items[1].Click += CloseWindow_Event;
            }
            else
            {
                radContextMenu_notify.DropDown.Hide();
            }
        }

        private void CloseWindow_Event(object sender, EventArgs e)
        {
            radContextMenu_notify.DropDown.Hide();
            Close();
        }

        private void ShowWindow_Event(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void MinimizeIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowWindow();
        }

        private void ToggleOnTop(bool _tf )
        {
            _ontop = _tf;
            TopMost = _tf;
        }

        private void ToggleSwitch_ontop_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (ToggleSwitch_ontop.Checked)
            {
                ToggleOnTop(true);
            }
            else
            {
                ToggleOnTop(false);
            }
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (bunifuRadialGauge_cpu.Value == 0 && 
                bunifuRadialGauge_ram.Value == 0 &&
                bunifuRadialGauge_gpu.Value == 0)
            {
                Hide();
                _splash.Show();
            }
            else
            {
                Show();
                _splash.Hide();
                
                tick.Stop();
            }
        }
        
        private void ShowLogWindow()
        {
            _log._count = true;
            _log.Show();
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            ShowLogWindow();
        }
    }
}
