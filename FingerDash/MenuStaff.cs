using FingerDash.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerDash
{
    public partial class MenuStaff : Form
    {
        public Form RefToLogin { get; set; }
        public MenuStaff()
        {
            InitializeComponent();
            timer_TimeS.Start();
            label_EmployeeName.Text = Login.LoggedInName;
            user_logged.Text = "Welcome " + Login.LoggedInName + ".";
        }

        private void timer_TimeS_Tick(object sender, EventArgs e)
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
            await Task.Delay(200);
            emploRota.Show();
            await Task.Delay(1500);
            this.Hide();
        }


        private async void btn_myTimeSheet_Click(object sender, EventArgs e)
        {
            EmployeeTimeSheet employeeTime = new EmployeeTimeSheet();
            employeeTime.RefToMenuStaff = this;
            await Task.Delay(200);
            employeeTime.Show();
            await Task.Delay(1500);
            this.Hide();
        }

        private async void btn_myBalances_Click(object sender, EventArgs e)
        {
            EmployeeBalance employeeBalance = new EmployeeBalance();
            employeeBalance.RefToMenuStaff = this;
            await Task.Delay(200);
            employeeBalance.Show();
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
