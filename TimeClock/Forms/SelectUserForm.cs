using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using TimeClock.Forms;
using TimeClock;
using TimeClock.Models;
using System.Collections.Generic;

namespace TimeClock
{
    public partial class SelectUserForm : Form
    {
        private bool passwordValid = false;

        private static StaffModel staffModel = new StaffModel();

        public SelectUserForm()
        {
            InitializeComponent();
            //checkloggedIn();
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowloggedIn = FormWindowloggedIn.Maximized;
            IntPtr intPtr = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            EdgeGestureUtil.DisableEdgeGestures(intPtr, true);
        }

        //public void checkloggedIn()
        //{
        //    if(tania.loggedIn == false)
        //    {
        //        button1.BackColor = Color.Beige;
        //    }
        //}


        //Set event handler
        private void SelectUserForm_Load(object sender, EventArgs e)
        {
            SystemEvents.DisplaySettingsChanged +=
                new EventHandler(displaySettingsChanged);
        }
        // Event handler for the system's DisplaySettingsChanged event.
        // Detect and then compare the height and width of the screen.
        private void displaySettingsChanged(object sender, EventArgs e)
        {
            Rectangle theScreenRect = Screen.GetBounds(this);

            if (theScreenRect.Height > theScreenRect.Width)
            {
                //Run the application in portrait, as in:
                MessageBox.Show("Run in portrait.");
            }
            else
            {
                //Run the application in landscape, as in:
                MessageBox.Show("Run in landscape.");
            }
        }

      private void validateStaff(Button but, StaffModel model)
        {
            NumPad numPad = new NumPad(model);
            numPad.ShowDialog();
            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                //LoginLogoutForm lilo = new LoginLogoutForm(tania);
                //lilo.ShowDialog();
                //tania.loggedIn = lilo.loggedIn;

                //if logging in
                if (model.loggedIn == false)
                {
                    but.BackColor = Color.DodgerBlue;
                    but.ForeColor = Color.Ivory;
                    model.loggedIn = true;
                    GlobalConfig.Connection.Login(model);
                }
                else
                //logging out
                {
                    LogoutForm lo = new LogoutForm(model);
                    this.TopMost = false;
                    lo.ShowDialog();
                    but.BackColor = Color.White;
                    but.ForeColor = Color.DodgerBlue;
                    model.loggedIn = false;
                    GlobalConfig.Connection.Logout(model);
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {           
            staffModel = GlobalConfig.Connection.getStaffModel("Tania");
            
            validateStaff(button1, staffModel);
            
           


            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Robert");

            validateStaff(button2, staffModel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Mary");
            validateStaff(button3, staffModel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Jenny");
            validateStaff(button4, staffModel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Jeremy");
            validateStaff(button5, staffModel);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Phill");
            validateStaff(button6, staffModel);
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Guest");
            validateStaff(button7, staffModel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            staffModel = GlobalConfig.Connection.getStaffModel("Admin");
            validateStaff(button8, staffModel);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
