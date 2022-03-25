using FingerDash.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerDash
{
    public partial class MenuManager : Form
    {
        public Form RefToLogin { get; set; }
        public MenuManager()
        {
            InitializeComponent();

            timerTimeM.Start();
            label_EmployeeName.Text = Login.LoggedInName;
            user_logged.Text = "Welcome " + Login.LoggedInName + ".";
        }


        private void timerTimeM_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMMM");
        }

        private async void btn_myRota_Click(object sender, EventArgs e)
        {
            EmployeeRota emploRota = new EmployeeRota();
            emploRota.RefToMenuStaff = this;
            await Task.Delay(100);
            emploRota.Show();
            await Task.Delay(1500);
            this.Hide();
        }

        private async void btn_myTimeSheet_Click(object sender, EventArgs e)
        {
            EmployeeTimeSheet employeeTime = new EmployeeTimeSheet();
            employeeTime.RefToMenuStaff = this;
            await Task.Delay(100);
            employeeTime.Show();
            await Task.Delay(1500);
            this.Hide();
        }

        private async void btn_myBalances_Click(object sender, EventArgs e)
        {
            EmployeeBalance employeeBalance = new EmployeeBalance();
            employeeBalance.RefToMenuStaff = this;
            await Task.Delay(100);
            employeeBalance.Show();
            await Task.Delay(1000);
            this.Hide();
        }

        private async void btnStaffRota_Click(object sender, EventArgs e)
        {
            StaffRota staffRota = new StaffRota();
            staffRota.RefToManagerMenu = this;
            await Task.Delay(100);
            staffRota.Show();
            await Task.Delay(1500);
            this.Hide();
        }

        private async void btnStaffTime_Click(object sender, EventArgs e)
        {
            StaffClockIns staffClockIns = new StaffClockIns();
            staffClockIns.RefToManagerMenu = this;
            await Task.Delay(100);
            staffClockIns.Show();
            await Task.Delay(1500);
            this.Hide();
        }

        private async void btnStaffBalance_Click(object sender, EventArgs e)
        {
            StaffBalance staffBalance = new StaffBalance();
            staffBalance.RefToManagerMenu = this;
            await Task.Delay(100);
            staffBalance.Show();
            await Task.Delay(1000);
            this.Hide();
        }

        private async void btn_logOut_Click(object sender, EventArgs e)
        {
            this.RefToLogin.Show();
            await Task.Delay(300);
            this.Dispose();
        }
    }
}
