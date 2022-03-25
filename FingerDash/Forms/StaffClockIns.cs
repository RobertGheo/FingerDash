using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FingerDash.Forms
{
    public partial class StaffClockIns : Form
    {
        public Form RefToManagerMenu { get; set; }
        private Form activeForm;
        private bool showClockOut = false;
        private bool showClockIn = true;
        System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
        public StaffClockIns()
        {
            InitializeComponent();
            timerStaffC.Start();

            label_EmplyeeName.Text = Login.LoggedInName;
            Opacity = 0;      //first the opacity is 0           
            t1.Interval = 15;  //we'll increase the opacity every 15ms (10ms with 0.02-0.05 is better)
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();

        }
        private void StaffClockIns_Load(object sender, EventArgs e)
        {
            btnClockIns.PerformClick();
            btnCurrentWeekL.PerformClick();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
            {
                Opacity += 0.03;
            }
        }
        private void timerStaffC_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMM yyyy");

            label4.Width = label1.Width + label2.Width + label3.Width;
        }
        private async void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.Show();
            childForm.SendToBack();
            await Task.Delay(1000);
            childForm.BringToFront();
        }

        public static int intsender;
        private void btnCurrentWeekL_Click(object sender, EventArgs e)
        {
            if (showClockIn == true)
            {
                intsender = 0;
                OpenChildForm(new Forms.ZClockInStaff(), sender);
            }
            if (showClockOut == true)
            {
                intsender = 0;
                OpenChildForm(new Forms.ZClockOutStaff(), sender);
            }

            btnCurrentWeekL.Visible = false;
            btnCurrentWeekR.Visible = false;
            btnLeft.Visible = true;
            btnRight.Visible = true;
            label6.Visible = true;
        }
        private void btnCurrentWeekR_Click(object sender, EventArgs e)
        {
            if (showClockIn == true)
            {
                intsender = 0;
                OpenChildForm(new Forms.ZClockInStaff(), sender);
            }
            if (showClockOut == true)
            {
                intsender = 0;
                OpenChildForm(new Forms.ZClockOutStaff(), sender);
            }
            btnCurrentWeekR.Visible = false;
            btnCurrentWeekL.Visible = false;
            btnLeft.Visible = true;
            btnRight.Visible = true;
            label7.Visible = true;
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (showClockIn == true)
            {
                intsender = -7;
                OpenChildForm(new Forms.ZClockInStaff(), sender);
            }
            if (showClockOut == true)
            {
                intsender = -7;
                OpenChildForm(new Forms.ZClockOutStaff(), sender);
            }
            btnLeft.Visible = false;
            btnCurrentWeekR.Visible = true;
            btnRight.Visible = false;
            label7.Visible = false;
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (showClockIn == true)
            {
                intsender = 7;
                OpenChildForm(new Forms.ZClockInStaff(), sender);
            }

            if (showClockOut == true)
            {
                intsender = 7;
                OpenChildForm(new Forms.ZClockOutStaff(), sender);

            }
            btnRight.Visible = false;
            btnLeft.Visible = false;
            btnCurrentWeekL.Visible = true;
            label6.Visible = false;
        }


        private async void btn_Back_Click(object sender, EventArgs e)
        {
            this.RefToManagerMenu.Show();
            await Task.Delay(500);
            this.Dispose();
        }


        private void btnClockIns_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ZClockInStaff(), sender);

            showClockIn = true;
            showClockOut = false;
            btnClockOuts.Visible = true;
            btnClockIns.Visible = false;
        }
        private void btnClockOuts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ZClockOutStaff(), sender);

            showClockOut = true;
            showClockIn = false;
            btnClockIns.Visible = true;
            btnClockOuts.Visible = false;
        }
        /*
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            loadingGif.Visible = true;
            Thread.Sleep(2000);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingGif.Visible = true;
            MessageBox.Show(e.ToString());
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingGif.Visible = false;
        }*/
    }
}
