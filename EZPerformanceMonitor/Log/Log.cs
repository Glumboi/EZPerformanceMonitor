using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using EZPerformanceMonitor.Core;

namespace EZPerformanceMonitor.Log
{
    public partial class Log : Form
    {
        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        public delegate void delUpdateUIListBox(string text);

        ThreadStart _t;
        Thread _ut;

        private ExtraFunctions _ex = new ExtraFunctions();
        public bool _count = false;
        private Control _cn;

        public Log()
        {
            InitializeComponent();
        }

        private void button_stoplog_Click(object sender, EventArgs e)
        {
            if (!_count)
            {
                _count = true;
                timer_checklogging.Start();
                Program.debugConsole.Info("Started logging the usages");
            }
            else
            {
                _count = false;
                Program.debugConsole.Info("Stopped logging the usages");
            }
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
            _count = false;
            Hide();
        }

        private void timer_checklogging_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_count)
            {
                StartLogging();
                timer_checklogging.Stop();
            }
        }

        private async void StartLogging()
        {
            await Task.Run(() =>
            {
                while (_count)
                {
                    UpdateLog();
                }
            });
        }

        private void UpdateLog()
        {
            List<int> usages = new SystemUsage().Usages();
            var _content = DateTime.Now.ToString("HH:mm:ss") + " - CPU: " + usages[0] + "% RAM: " + usages[1] +
                           "% GPU: " + usages[2] + "%";
            delUpdateUIListBox del = new delUpdateUIListBox(UpdateUIListBox);

            listBox1.BeginInvoke(del, _content);
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            Program.debugConsole.Info($"Updated the log of the usages: {_content}");
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Program.debugConsole.Info($"Cleared the log of the usages");
        }

        private void UpdateUIListBox(string _str)
        {
            listBox1.Items.Add(_str);
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            //Gets all items as string in the listbox and saves them to a .txt file called "log + currenttime.txt" 
            //with a save file dialog
            string _content = string.Empty;
            foreach (var item in listBox1.Items)
            {
                _content += item.ToString() + "\n";
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FileName = "log " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _ex.WriteToFile(_content, saveFileDialog1.FileName);
                Program.debugConsole.Info($"Successfully exported the usages log to a text file called: {saveFileDialog1.FileName}");
            }
        }

        private void Log_Load(object sender, EventArgs e)
        {
            Glumboi.UI.UIChanger.ChangeTitlebarToDark(Handle);
        }
    }
}