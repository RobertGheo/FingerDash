using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FingerDash.Forms
{
    public partial class ClockAlertMess : Form
    {
        public ClockAlertMess()
        {
            InitializeComponent();
        }

        private void btnOkClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
