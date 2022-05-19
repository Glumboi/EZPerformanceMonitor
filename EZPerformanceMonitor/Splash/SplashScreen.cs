using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZPerformanceMonitor.Core;
using Telerik.WinControls;

namespace EZPerformanceMonitor.Splash
{
    public partial class SplashScreen : System.Windows.Forms.Form
    {
        ExtraFunctions _ext = new ExtraFunctions();
        
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            radWaitingBar1.StartWaiting();
        }

        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;
            
            if (me.Button == MouseButtons.Right)
            {
                dragging = false;
                return;
            }
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ext.CloseAll();
        }
    }
}
