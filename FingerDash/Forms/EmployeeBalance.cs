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
    public partial class EmployeeBalance : Form
    {
        public Form RefToMenuStaff { get; set; }
        Timer t1 = new Timer();
        public EmployeeBalance()
        {
            InitializeComponent();
            timerBalance.Start();
            label_EmplyeeName.Text = Login.LoggedInName;

            Opacity = 0;      //first the opacity is 0           
            t1.Interval = 15;  //we'll increase the opacity every 15ms (10ms with 0.02-0.05 is better)
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
            CalculateOn();
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
        private void CalculateOn()
        {
            DateTime dateTime = DateTime.Now;
            labelCalcOn.Text = dateTime.ToString("dd MMMM yyyy");
        }

        private void timerBalance_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMM yyyy");

            label4.Width = label1.Width + label2.Width + label3.Width;
        }

        private async void btn_Back_Click(object sender, EventArgs e)
        {
            this.RefToMenuStaff.Show();
            await Task.Delay(500);
            this.Dispose();
        }
    }
}
