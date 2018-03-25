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
        private static StaffModel tania = new StaffModel();
        //private StaffModel tania = new StaffModel("Tania", SecurePasswordHasher.Hash("1111"), false);
        private static StaffModel robert = new StaffModel();
        //private StaffModel robert = new StaffModel("Robert", SecurePasswordHasher.Hash("1111"), false);
        private StaffModel mary = new StaffModel("Mary", SecurePasswordHasher.Hash("1111"), false);
        private StaffModel jenny = new StaffModel("Jenny", SecurePasswordHasher.Hash("1111"), false);
        private StaffModel jeremy = new StaffModel("Jeremy", SecurePasswordHasher.Hash("1111"), false);
        private StaffModel phill = new StaffModel("Phill", SecurePasswordHasher.Hash("1111"), false);
        private StaffModel guest = new StaffModel("Guest", SecurePasswordHasher.Hash("1111"), false);
        private StaffModel admin = new StaffModel("Admin", SecurePasswordHasher.Hash("1111"), false);

        private static StaffModel staffModel = new StaffModel();

        public SelectUserForm()
        {
            InitializeComponent();
            //checkState();
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            IntPtr intPtr = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            EdgeGestureUtil.DisableEdgeGestures(intPtr, true);
        }

        //public void checkState()
        //{
        //    if(tania.state == false)
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
                //tania.state = lilo.state;

                //if logging in
                if (model.state == false)
                {
                    but.BackColor = Color.DodgerBlue;
                    but.ForeColor = Color.Ivory;
                    model.state = true;
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
                    model.state = false;
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {           
            staffModel = GlobalConfig.Connection.getStaffModel("Tania");
            validateStaff(button1, staffModel);
            
            
            //numPad.Show();


            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            robert = GlobalConfig.Connection.getStaffModel("Robert");

            NumPad numPad = new NumPad(robert);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (robert.state == false)
                {
                    button2.BackColor = Color.DodgerBlue;
                    button2.ForeColor = Color.Ivory;
                    robert.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(robert);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button2.BackColor = Color.White;
                    button2.ForeColor = Color.DodgerBlue;
                    robert.state = false;
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumPad numPad = new NumPad(mary);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (mary.state == false)
                {
                    button3.BackColor = Color.DodgerBlue;
                    button3.ForeColor = Color.Ivory;
                    mary.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(mary);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button3.BackColor = Color.White;
                    button3.ForeColor = Color.DodgerBlue;
                    mary.state = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumPad numPad = new NumPad(jenny);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (jenny.state == false)
                {
                    button4.BackColor = Color.DodgerBlue;
                    button4.ForeColor = Color.Ivory;
                    jenny.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(jenny);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button4.BackColor = Color.White;
                    button4.ForeColor = Color.DodgerBlue;
                    jenny.state = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumPad numPad = new NumPad(jeremy);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (jeremy.state == false)
                {
                    button5.BackColor = Color.DodgerBlue;
                    button5.ForeColor = Color.Ivory;
                    jeremy.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(jeremy);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button5.BackColor = Color.White;
                    button5.ForeColor = Color.DodgerBlue;
                    jeremy.state = false;
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            NumPad numPad = new NumPad(phill);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (phill.state == false)
                {
                    button6.BackColor = Color.DodgerBlue;
                    button6.ForeColor = Color.Ivory;
                    phill.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(phill);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button6.BackColor = Color.White;
                    button6.ForeColor = Color.DodgerBlue;
                    phill.state = false;
                }
            }
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            NumPad numPad = new NumPad(guest);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (guest.state == false)
                {
                    button7.BackColor = Color.DodgerBlue;
                    button7.ForeColor = Color.Ivory;
                    guest.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(guest);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button7.BackColor = Color.White;
                    button7.ForeColor = Color.DodgerBlue;
                    guest.state = false;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumPad numPad = new NumPad(admin);
            numPad.ShowDialog();


            this.passwordValid = numPad.passwordValid;
            if (passwordValid == true)
            {
                if (admin.state == false)
                {
                    button8.BackColor = Color.DodgerBlue;
                    button8.ForeColor = Color.Ivory;
                    admin.state = true;
                }
                else
                {
                    LogoutForm lo = new LogoutForm(admin);
                    this.TopMost = false;
                    lo.ShowDialog();
                    button8.BackColor = Color.White;
                    button8.ForeColor = Color.DodgerBlue;
                    admin.state = false;                  
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
