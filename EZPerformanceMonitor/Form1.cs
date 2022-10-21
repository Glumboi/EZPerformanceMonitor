using EZPerformanceMonitor.Core;
using EZPerformanceMonitor.Splash;
using Octokit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Glumboi.UI.Toast;
using Glumboi.UI;
using static EZPerformanceMonitor.Core.Temp;
using Bunifu.UI.WinForms;
using EZPerformanceMonitor.Debug;

namespace EZPerformanceMonitor
{
    public partial class Form1 : Form
    {
        public BunifuRadialGauge[] Gauges { get => GetRadialGauges(); }
        public List<int> Usages { get => USAGE.Usages(); }

        //Readonly variables used to get the usage and specs of a computer
        private readonly SystemUsage USAGE = new SystemUsage();
        private readonly GetSpecs SPECS = new GetSpecs();

        //Readonly variable to compare the apps github vesion to the local one
        private readonly VersionControl VERSION = new VersionControl();

        //Readonly Forms used in the app
        private readonly SplashScreen SPLASH = new SplashScreen();
        private readonly Log.Log LOG = new Log.Log();
        private readonly DebugSettingsForm DEBUGFORM = new DebugSettingsForm();

        //Readonly class to execute extra functions such as writing to a file
        private readonly ExtraFunctions EXT = new ExtraFunctions();

        //Variables used front-end
        private bool _ontop;

        private bool _reachedLimitRam = false;
        private bool _reachedLimitCPU = false;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(Handle); //Calls to my dll
        }

        private BunifuRadialGauge[] GetRadialGauges()
        {
            BunifuRadialGauge[] radialGauges = { bunifuRadialGauge_cpu, bunifuRadialGauge_ram, bunifuRadialGauge_gpu };

            return radialGauges;
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

        void InitHotkeys()
        {
            Program.debugConsole.Info("Hotkeys has been loaded");
            Hotkeys.LoadHotkeys(this);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0312 when m.WParam.ToInt32() == (int)Hotkeys.HotkeyIDs.HotkeyID:
                    DEBUGFORM.Show();
                    break;
            }

            base.WndProc(ref m);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            InitHotkeys();

            await GetSettings();

            //Updates the gauges as long as the process is running
            await Task.Run(() =>
            {
                UpdateUsages();
            });
        }

        private Task UpdateUsages()
        {
            while (Process.GetProcessesByName(Assembly.GetExecutingAssembly().GetName().Name).Length > 0)
            {
                Gauges[0].Value = Usages[0];
                Gauges[1].Value = Usages[1];
                Gauges[2].Value = Usages[2];

                label_cpuTemp.Invoke((MethodInvoker)delegate
                {
                    label_cpuTemp.Text = label_cpuTemp.Text = GetSystemInfo() + "°C";
                });
            }

            return Task.CompletedTask;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.ontop = _ontop;
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MinimizeIcon.Dispose();
            SaveSettings();
            EXT.CloseAll();
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

            groupBox_CPU.Text = SPECS.GetCpuName();
            groupBox_GPU.Text = SPECS.GetGpuName();
            groupBox_Ram.Text = SPECS.GetRamClock() + " (" + SPECS.GetRamSize() + ")";

            if (await VERSION.CheckGitHubNewerVersion())
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

            Program.debugConsole.Info("CPU of the system: " + SPECS.GetCpuName());
            Program.debugConsole.Info("GPU of the system: " + SPECS.GetGpuName());
            Program.debugConsole.Info("RAM size of the system: " + SPECS.GetRamSize());
        }

        private void ShowWindow()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                if (LOG.WindowState == FormWindowState.Minimized)
                {
                    LOG.Show();
                }
                Show();
                WindowState = FormWindowState.Normal;
            }

            radContextMenu_notify.DropDown.Hide();
        }

        //Checks if the Form is minimized or not and shows a notification if it is and hides the app
        private void Form1_Resize(object sender, EventArgs e)
        {
            string _toastTitle = "App minimized to tray";
            string _toastContent = "App successfully minimized to tray.\nDouble click on it to show the window again.";

            if (FormWindowState.Minimized == WindowState)
            {
                MinimizeIcon.Visible = true;
                ToastHandler.ShowToast(_toastContent, _toastTitle);
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

        private void ToggleOnTop(bool trueFalse)
        {
            _ontop = trueFalse;
            TopMost = trueFalse;;
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

        //Checks if all usages are 0 and if so, it shows a loading screen so the program doesn't look like its frozen
        private void OnTick(object sender, EventArgs e)
        {
            if (bunifuRadialGauge_cpu.Value == 0 &&
                bunifuRadialGauge_ram.Value == 0 &&
                bunifuRadialGauge_gpu.Value == 0)
            {
                Hide();
                SPLASH.Show();
            }
            else
            {
                Show();
                SPLASH.Hide();
                SPLASH.StopAnimation();

                tick.Stop();
                Program.debugConsole.Info("Splash/Loading screen is done");
            }
        }

        private void ShowLogWindow()
        {
            LOG._count = true; //Used to start-stop the log counting
            LOG.Show();
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            ShowLogWindow();
        }

        private void bunifuRadialGauge_ram_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRadialGauge.ValueChangedEventArgs e)
        {
            var compareRes = CheckUsageTooHigh.ComprareUsageToWarning(bunifuRadialGauge_ram.Value, bunifuRadialGauge_ram.WarningMark);

            if (!compareRes) _reachedLimitRam = false;

            if (_reachedLimitRam) return;

            if (compareRes)
            {
                string _toastTitle = "RAM Usage Warning";
                string _toastContent = "Your RAM usage is very high.\nPlease make sure you have enough RAM. And maybe close a couple things that drains it!";

                ToastHandler.ShowToast(_toastContent, _toastTitle);

                _reachedLimitRam = true;
            }
        }

        private void bunifuRadialGauge_cpu_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRadialGauge.ValueChangedEventArgs e)
        {
            var compareRes = CheckUsageTooHigh.ComprareUsageToWarning(bunifuRadialGauge_cpu.Value, bunifuRadialGauge_cpu.WarningMark);

            if (!compareRes) _reachedLimitCPU = false;

            if (_reachedLimitCPU) return;

            if (compareRes)
            {
                string _toastTitle = "CPU Usage Warning";
                string _toastContent = "Your CPU usage is very high.\nI recommend you to close some applications that drain your CPU.";

                ToastHandler.ShowToast(_toastContent, _toastTitle);

                _reachedLimitCPU = true;
            }
        }
    }
}
