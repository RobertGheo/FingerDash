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
    public partial class StartApp : Form
    {
        Timer t1 = new Timer();
        public StartApp()
        {
            InitializeComponent();
            OpenApp();
            Opacity = 0;      //first the opacity is 0           
            t1.Interval = 15;  //we'll increase the opacity every 15ms (10ms with 0.02-0.05 is better)
            t1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity 
            t1.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed
            else
            {
                Opacity += 0.010;
                //btn_Back.PerformClick(); //Add button for current time
            }
        }
        private async void OpenApp()
        {
            MainForm mainForm = new MainForm();
            await Task.Delay(2500);
            mainForm.Show();
            await Task.Delay(500);
            this.Hide();
        }
    }
}
