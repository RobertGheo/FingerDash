using FingerDash.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerDash
{
    public partial class Login : Form
    {
        public static int LoggedInNumber;
        public static string LoggedInName;
        public Form RefToMainForm { get; set; }
        public Control InsertBox { get; set; }
        public Login()
        {
            InitializeComponent();
            timerLogPage.Start();
            user_box.Select();
            user_box.isFocused = true;
        }


        private void timerLogPage_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMMM");
        }


        // unviel password text
        //<<<<<
        private void btn_show_MouseHover(object sender, EventArgs e)
        {
            pass_box.PasswordChar = false;
        }
        // hide password text
        private void btn_show_MouseLeave(object sender, EventArgs e)
        {
            pass_box.PasswordChar = true;
        }
        //>>>>>

        private async void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_box.Texts.Trim()))
            {
                // Message box for clock in
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox2.Text = "Please insert your employee ID.";
                clockMessage.ShowDialog();
                user_box.Focus();
                user_box.Select();
                return;
            }
            if (string.IsNullOrEmpty(pass_box.Texts.Trim()))
            {
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox2.Text = "Please insert your password.";
                clockMessage.ShowDialog();
                pass_box.Select();
                pass_box.Focus();
                return;
            }
            else
            {
                try
                {
                    string queryString = "SELECT Employee_no, Employee_type, Employee_name, Employee_pass FROM UserLogin WHERE Employee_no = @E_no AND Employee_pass = @E_pass";
                    SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@E_no", int.Parse(user_box.Texts));
                    command.Parameters.AddWithValue("@E_pass", this.pass_box.Texts.Trim().ToString());
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    LoggedInNumber = reader.GetInt32(0);
                    LoggedInName = reader.GetString(2); //save Name and use for next forms
                    string userAccess1 = "Admin";
                    string userAccess2 = "Manager";
                    string userAccess3 = "Staff";
                    //string userType = reader["Employee_type"];  AND Emplote_type = @E_type
                    if (reader.HasRows & reader.GetString(1) == userAccess1)
                    {
                        MenuAdmin logAdmin = new MenuAdmin();
                        logAdmin.RefToLogin = this;
                        await Task.Delay(100);
                        logAdmin.Show();
                        await Task.Delay(400);
                        this.Hide();
                    }
                    else if (reader.HasRows & reader.GetString(1) == userAccess2)
                    {
                        MenuManager logManager = new MenuManager();
                        logManager.RefToLogin = this;
                        await Task.Delay(100);
                        logManager.Show();
                        await Task.Delay(400);
                        this.Hide();
                    }
                    else if (reader.HasRows & reader.GetString(1) == userAccess3)
                    {
                        MenuStaff logStaff = new MenuStaff();
                        logStaff.RefToLogin = this;
                        await Task.Delay(100);
                        logStaff.Show();
                        await Task.Delay(400);
                        this.Hide();
                    }

                    reader.Close();
                    connection.Close();
                    user_box.Texts = string.Empty;
                    pass_box.Texts = string.Empty;
                    user_box.Select();
                    user_box.Focus();
                }

                catch (Exception) //ex
                {
                    ClockAlertMess clockMessage = new ClockAlertMess();
                    clockMessage.labelBox1.Text = "Incorrect employee ID or password.";
                    clockMessage.labelBox2.Text = "If you forgot you employee ID or password, please speak with your manager.";
                    clockMessage.ShowDialog();
                    user_box.Focus();
                    user_box.Select();
                    user_box.Texts = string.Empty;
                    pass_box.Texts = string.Empty;
                    user_box.Focus();
                    user_box.Select();
                }
            }
        }
        private async void btn_close_Click(object sender, EventArgs e)
        {
            this.RefToMainForm.Show();
            this.InsertBox.Focus();
            await Task.Delay(300);
            this.Dispose();
        }

        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;
        private bool backSpace = false;
        // Handle the KeyDown event to determine the type of character entered into the control.
        private void user_box_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            nonNumberEntered = false;
            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
            if (e.KeyCode == Keys.Back)
            {
                backSpace = true;
            }
        }

        private void user_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox2.Text = "You pressed a non-alowed key!";
                clockMessage.ShowDialog();
            }
        }

    }
}
