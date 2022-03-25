using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FingerDash.Forms
{
    public partial class ZClockOutStaff : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        int N = StaffClockIns.intsender; //get the week status
        public ZClockOutStaff()
        {
            InitializeComponent();
            bw.DoWork += Bw_DoWork;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();

            CheckCurentTime();
        }
        public void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            loadingGif.Visible = true;
        }
        public void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingGif.Visible = false;
        }


        private void CheckCurentTime()
        {
            DateTime dateTime = DateTime.Now;
            string monday = "Monday";
            string tuesday = "Tuesday";
            string wednesday = "Wednesday";
            string thursday = "Thursday";
            string friday = "Friday";
            string saturday = "Saturday";
            string sunday = "Sunday";

            if (monday == dateTime.ToString("dddd"))
            {
                labelDate1.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N + 1).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N + 2).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N + 3).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N + 4).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N + 5).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 6).ToString("ddd, dd MMM");
            }
            if (tuesday == dateTime.ToString("dddd"))
            {
                labelDate1.Text = dateTime.AddDays(N - 1).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N + 1).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N + 2).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N + 3).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N + 4).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 5).ToString("ddd, dd MMM");
            }
            if (wednesday == dateTime.ToString("dddd"))
            {
                labelDate1.Text = dateTime.AddDays(N - 2).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N - 1).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N + 1).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N + 2).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N + 3).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 4).ToString("ddd, dd MMM");
            }
            if (thursday == dateTime.ToString("dddd"))
            {
                labelDate1.Text = dateTime.AddDays(N - 3).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N - 2).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N - 1).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N + 2).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N + 3).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 4).ToString("ddd, dd MMM");
            }
            if (friday == dateTime.ToString("dddd"))
            {

                labelDate1.Text = dateTime.AddDays(N - 4).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N - 3).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N - 2).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N - 1).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N + 1).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 2).ToString("ddd, dd MMM");
            }
            if (saturday == dateTime.ToString("dddd"))
            {
                labelDate1.Text = dateTime.AddDays(N - 5).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N - 4).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N - 3).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N - 2).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N - 1).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 1).ToString("ddd, dd MMM");
            }
            if (sunday == dateTime.ToString("dddd"))
            {
                labelDate1.Text = dateTime.AddDays(N - 6).ToString("ddd, dd MMM");
                labelDate2.Text = dateTime.AddDays(N - 5).ToString("ddd, dd MMM");
                labelDate3.Text = dateTime.AddDays(N - 4).ToString("ddd, dd MMM");
                labelDate4.Text = dateTime.AddDays(N - 3).ToString("ddd, dd MMM");
                labelDate5.Text = dateTime.AddDays(N - 2).ToString("ddd, dd MMM");
                labelDate6.Text = dateTime.AddDays(N - 1).ToString("ddd, dd MMM");
                labelDate7.Text = dateTime.AddDays(N + 0).ToString("ddd, dd MMM");
            }
        }




        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBoxV1.Visible = true;
            checkBox1.Visible = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBoxV2.Visible = true;
            checkBox2.Visible = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBoxV3.Visible = true;
            checkBox3.Visible = false;
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            checkBoxV4.Visible = true;
            checkBox4.Visible = false;
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            checkBoxV5.Visible = true;
            checkBox5.Visible = false;
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            checkBoxV6.Visible = true;
            checkBox6.Visible = false;
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            checkBoxV7.Visible = true;
            checkBox7.Visible = false;
        }

        private void checkBoxV1_Click(object sender, EventArgs e)
        {
            checkBoxX1.Visible = true;
            checkBoxV1.Visible = false;
        }

        private void checkBoxV2_Click(object sender, EventArgs e)
        {
            checkBoxX2.Visible = true;
            checkBoxV2.Visible = false;
        }

        private void checkBoxV3_Click(object sender, EventArgs e)
        {
            checkBoxX3.Visible = true;
            checkBoxV3.Visible = false;
        }

        private void checkBoxV4_Click(object sender, EventArgs e)
        {
            checkBoxX4.Visible = true;
            checkBoxV4.Visible = false;
        }

        private void checkBoxV5_Click(object sender, EventArgs e)
        {
            checkBoxX5.Visible = true;
            checkBoxV5.Visible = false;
        }

        private void checkBoxV6_Click(object sender, EventArgs e)
        {
            checkBoxX6.Visible = true;
            checkBoxV6.Visible = false;
        }

        private void checkBoxV7_Click(object sender, EventArgs e)
        {
            checkBoxX7.Visible = true;
            checkBoxV7.Visible = false;
        }

        private void checkBoxX1_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = true;
            checkBoxX1.Visible = false;
        }

        private void checkBoxX2_Click(object sender, EventArgs e)
        {
            checkBox2.Visible = true;
            checkBoxX2.Visible = false;
        }

        private void checkBoxX3_Click(object sender, EventArgs e)
        {
            checkBox3.Visible = true;
            checkBoxX3.Visible = false;
        }

        private void checkBoxX4_Click(object sender, EventArgs e)
        {
            checkBox4.Visible = true;
            checkBoxX4.Visible = false;
        }

        private void checkBoxX5_Click(object sender, EventArgs e)
        {
            checkBox5.Visible = true;
            checkBoxX5.Visible = false;
        }

        private void checkBoxX6_Click(object sender, EventArgs e)
        {
            checkBox6.Visible = true;
            checkBoxX6.Visible = false;
        }

        private void checkBoxX7_Click(object sender, EventArgs e)
        {
            checkBox7.Visible = true;
            checkBoxX7.Visible = false;
        }
    }
}
