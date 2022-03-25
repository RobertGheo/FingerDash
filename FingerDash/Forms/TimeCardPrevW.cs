using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FingerDash.Forms
{
    public partial class TimeCardPrevW : Form
    {
        public TimeCardPrevW()
        {
            InitializeComponent();
            CheckCurentTime();
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
                labelM1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-11).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-6).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-5).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-4).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-3).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-2).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-1).ToString("dddd, dd MMM");
            }
            if (tuesday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(-29).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-11).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-6).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-5).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-4).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-3).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-2).ToString("dddd, dd MMM");
            }
            if (wednesday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(-30).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-29).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-11).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-6).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-5).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-4).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-3).ToString("dddd, dd MMM");
            }
            if (thursday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(-31).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-30).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-29).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-11).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-6).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-5).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-4).ToString("dddd, dd MMM");
            }
            if (friday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(-32).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-31).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-30).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-29).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-11).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-6).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-5).ToString("dddd, dd MMM");
            }
            if (saturday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(-34).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-33).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-32).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-31).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-30).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-29).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-6).ToString("dddd, dd MMM");
            }
            if (sunday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(-34).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(-33).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(-32).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(-31).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(-30).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(-29).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(-28).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(-27).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(-26).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(-25).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(-24).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(-23).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(-22).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(-21).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(-20).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(-19).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(-18).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(-17).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(-16).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(-15).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(-14).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(-13).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(-12).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(-11).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(-10).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(-9).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(-8).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(-7).ToString("dddd, dd MMM");
            }
        }
    }
}
