using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EZPerformanceMonitor.Core;
using Glumboi.UI;
using Transitions;

namespace EZPerformanceMonitor.Splash
{
    public partial class SplashScreen : System.Windows.Forms.Form
    {
        ExtraFunctions ext = new ExtraFunctions();
        AnimateText textAnimator;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Used for roudned corners source:https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        
        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AnimateControls()
        {
            //Animates the waiting bar
            Transition transition1 = new Transition(new TransitionType_EaseInEaseOut(1000));

            transition1.add(radWaitingBar1, "Top", 22);
            transition1.add(label1, "Top", 95);

            transition1.run();

            //Animates the label
            string[] stringsForAnimation = {
                "Loading",
                "Loading.",
                "Loading..",
                "Loading..."
            };

            textAnimator = new AnimateText(label1, stringsForAnimation, 300);
            textAnimator.Run();
        }

        public void StopAnimation()
        {   
            textAnimator.Stop();
        }
        
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            AnimateControls();
            radWaitingBar1.StartWaiting();
        }

        private void SplashScreen_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;
            
            if (me.Button == MouseButtons.Right)
            {
                dragging = false;
                
                radContextMenu1.Show(this, new Point(me.X, me.Y));
                radContextMenu1.Items[0].Click += radContextMenu1_Click;
                
                return;
            }
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = Location;
        }

        private void radContextMenu1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SplashScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void SplashScreen_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void SplashScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            ext.CloseAll();
        }
    }
}
