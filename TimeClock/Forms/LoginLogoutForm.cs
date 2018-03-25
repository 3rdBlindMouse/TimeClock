using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeClock.Models;

namespace TimeClock.Forms
{
    public partial class LoginLogoutForm : Form
    {
        StaffModel sm = new StaffModel();
        Timer timer1 = new Timer();

        Timer timer2 = new Timer();
        Stopwatch sw = new Stopwatch();

        internal bool state = false;



        public LoginLogoutForm(StaffModel model)
        {
            InitializeComponent();
            this.TopMost = true;

            staffLabel.Text = model.name;

            // Clock display
            this.label1.Text = DateTime.Now.ToString();
            timer1.Tick += new EventHandler(timer1_Tick);
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;

            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = 1000;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            sw.Start();
            timer2.Start();
            this.Hide();
            state = true;
            sm.state = state;
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                string currentTime = string.Empty;
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds);
                StopWatch.Text = currentTime;
            }
        }

        private void sw_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString();
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            //sw.Start();
            //timer2.Start();
            this.Hide();
            state = false;
            sm.state = state;
        }
    }
}
