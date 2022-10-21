using EZPerformanceMonitor.Debug;
using EZPerformanceMonitor.Splash;
using Glumboi.Debug;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EZPerformanceMonitor
{
    internal static class Program
    {
        public static bool debug = Properties.Settings.Default.debugging;
        public static int debugLvl = Properties.Settings.Default.debuggingLevel;
        public static DebugConsole debugConsole = new DebugConsole(debugLvl, "EZPCPM Debug Console", debug, true);

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
