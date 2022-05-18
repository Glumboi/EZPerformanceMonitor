using EZPerformanceMonitor.Core;
using EZPerformanceMonitor.Splash;
using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace EZPerformanceMonitor
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        SystemUsage _usage = new SystemUsage();
        GetSpecs _specs = new GetSpecs();
        GetTemp _temp = new GetTemp();
        VersionControl _version = new VersionControl();
        SplashScreen _splash = new SplashScreen();
        Internet _in = new Internet();
        private bool _ontop;
        private string GetGithubVersion;

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
                    List<int> _usages = _usage.Usages();
                    bunifuRadialGauge_cpu.Value = _usages[0];
                    bunifuRadialGauge_ram.Value = _usages[1];
                    bunifuRadialGauge_gpu.Value = _usages[2];
                }
            });
        }

        //Saves the app settings
        private void SaveSettings()
        {
            Properties.Settings.Default.ontop = _ontop;
            Properties.Settings.Default.Save();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();

            _splash.Close();
        }

        //Gets the app settings
        private async Task GetSettings()
        {
            _ontop = Properties.Settings.Default.ontop;

            if (Properties.Settings.Default.ontop)
            {
                this.TopMost = true;
                ToggleSwitch_ontop.Value = true;
            }
            else
            {
                this.TopMost = false;
                ToggleSwitch_ontop.Value = false;
            }
            
            groupBox_CPU.Text = _specs.GetCpuName();
            groupBox_GPU.Text = _specs.GetGpuName();
            groupBox_Ram.Text = _specs.GetRamClock() + " (" + _specs.GetRamSize() + ")";
            
            if (await _version.CheckGitHubNewerVersion())
            {
                DialogResult _dlg = MessageBox.Show("There is a new version available!\n\n" + 
                                                    "Do you want to download it now?\n\n"+
                                                    "Current Version: " + Assembly.GetExecutingAssembly().GetName().Version + "\n" + 
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
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            radContextMenu_notify.DropDown.Hide();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MinimizeIcon.BalloonTipTitle = "App minimized to tray";
            MinimizeIcon.BalloonTipText = "App successfully minimized to tray.\nDouble click on it to show the window again.";

            if (FormWindowState.Minimized == this.WindowState)
            {
                MinimizeIcon.Visible = true;
                MinimizeIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
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
            //Checks if rigthclicked and creates a context menu

            if (e.Button == MouseButtons.Right)
            {
                /*ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Show");
                contextMenu.Items.Add("Exit");
                //contextMenu.Show(Cursor.Position);
                contextMenu.ItemClicked += ContextMenu_ItemClicked;*/
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

        private void ToggleSwitch_ontop_ValueChanged(object sender, EventArgs e)
        {
            if (ToggleSwitch_ontop.Value)
            {
                _ontop = true;
                this.TopMost = true;
            }
            else
            {
                _ontop = false;
                this.TopMost = false;
            }
        }

        private void Github_notify_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Glumboi/EZAutoclicker/releases/tag/3.0.0");
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            if (bunifuRadialGauge_cpu.Value == 0 && bunifuRadialGauge_ram.Value == 0 && bunifuRadialGauge_gpu.Value == 0)
            {
                this.Hide();
                _splash.Show();
            }
            else
            {
                this.Show();
                _splash.Hide();

                tick.Stop();
            }
        }
    }
}
