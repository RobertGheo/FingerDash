using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerDash.Forms
{

    public partial class StaffRota : Form
    {
        public Form RefToManagerMenu { get; set; }
        private Form activeForm;
        Timer t1 = new Timer();
        public StaffRota()
        {
            InitializeComponent();
            timerStaffR.Start();
            label_EmployeeName.Text = Login.LoggedInName;

            Opacity = 0;      //first the opacity is 0           
            t1.Interval = 15;  //we'll increase the opacity every 15ms (10ms with 0.02-0.05 is better)
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }

        private void StaffRota_Load(object sender, EventArgs e)
        {
            btnCurrentWeekL.PerformClick();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
            {
                Opacity += 0.02;
            }
        }
        private void timerStaffR_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMM yyyy");

            label4.Width = label1.Width + label2.Width + label3.Width;
        }

        private void OpenChildForm(Form childForm, object btnSender)
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
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnCurrentWeekL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RotaCurrentW(), sender);
            btnCurrentWeekL.Visible = false;
            btnCurrentWeekR.Visible = false;
            btnLeft.Visible = true;
            btnRight.Visible = true;
            label6.Visible = true;
        }

        private void btnCurrentWeekR_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RotaCurrentW(), sender);
            btnCurrentWeekR.Visible = false;
            btnCurrentWeekL.Visible = false;
            btnLeft.Visible = true;
            btnRight.Visible = true;
            label7.Visible = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RotaPrevWeek(), sender);
            btnLeft.Visible = false;
            btnCurrentWeekR.Visible = true;
            btnRight.Visible = false;
            label7.Visible = false;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RotaNextWeek(), sender);
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

    }
}
