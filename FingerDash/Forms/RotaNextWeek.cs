using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FingerDash.Forms
{
    public partial class RotaNextWeek : Form
    {
        public RotaNextWeek()
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
                labelM1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(50).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(51).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(52).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(53).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(54).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(55).ToString("dddd, dd MMM");
            }
            if (tuesday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(27).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(50).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(51).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(52).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(53).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(54).ToString("dddd, dd MMM");
            }
            if (wednesday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(26).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(27).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(50).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(51).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(52).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(53).ToString("dddd, dd MMM");
            }
            if (thursday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(25).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(26).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(27).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(50).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(51).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(52).ToString("dddd, dd MMM");
            }
            if (friday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(24).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(25).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(26).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(27).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(50).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(51).ToString("dddd, dd MMM");
            }
            if (saturday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(23).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(24).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(25).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(26).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(27).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(50).ToString("dddd, dd MMM");
            }
            if (sunday == dateTime.ToString("dddd"))
            {
                labelM1.Text = dateTime.AddDays(22).ToString("dddd, dd MMM");
                labelT1.Text = dateTime.AddDays(23).ToString("dddd, dd MMM");
                labelW1.Text = dateTime.AddDays(24).ToString("dddd, dd MMM");
                labelTh1.Text = dateTime.AddDays(25).ToString("dddd, dd MMM");
                labelF1.Text = dateTime.AddDays(26).ToString("dddd, dd MMM");
                labelS1.Text = dateTime.AddDays(27).ToString("dddd, dd MMM");
                labelSu1.Text = dateTime.AddDays(28).ToString("dddd, dd MMM");
                labelM2.Text = dateTime.AddDays(29).ToString("dddd, dd MMM");
                labelT2.Text = dateTime.AddDays(30).ToString("dddd, dd MMM");
                labelW2.Text = dateTime.AddDays(31).ToString("dddd, dd MMM");
                labelTh2.Text = dateTime.AddDays(32).ToString("dddd, dd MMM");
                labelF2.Text = dateTime.AddDays(33).ToString("dddd, dd MMM");
                labelS2.Text = dateTime.AddDays(34).ToString("dddd, dd MMM");
                labelSu2.Text = dateTime.AddDays(35).ToString("dddd, dd MMM");
                labelM3.Text = dateTime.AddDays(36).ToString("dddd, dd MMM");
                labelT3.Text = dateTime.AddDays(37).ToString("dddd, dd MMM");
                labelW3.Text = dateTime.AddDays(38).ToString("dddd, dd MMM");
                labelTh3.Text = dateTime.AddDays(39).ToString("dddd, dd MMM");
                labelF3.Text = dateTime.AddDays(40).ToString("dddd, dd MMM");
                labelS3.Text = dateTime.AddDays(41).ToString("dddd, dd MMM");
                labelSu3.Text = dateTime.AddDays(42).ToString("dddd, dd MMM");
                labelM4.Text = dateTime.AddDays(43).ToString("dddd, dd MMM");
                labelT4.Text = dateTime.AddDays(44).ToString("dddd, dd MMM");
                labelW4.Text = dateTime.AddDays(45).ToString("dddd, dd MMM");
                labelTh4.Text = dateTime.AddDays(46).ToString("dddd, dd MMM");
                labelF4.Text = dateTime.AddDays(47).ToString("dddd, dd MMM");
                labelS4.Text = dateTime.AddDays(48).ToString("dddd, dd MMM");
                labelSu4.Text = dateTime.AddDays(49).ToString("dddd, dd MMM");
            }
        }
    }
}

