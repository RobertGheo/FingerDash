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
    public partial class MenuAdmin : Form
    {
        public Form RefToLogin { get; set; }
        public MenuAdmin()
        {
            InitializeComponent();
            timerAdmin.Start();
            label_EmployeeName.Text = Login.LoggedInName;
            user_logged.Text = "Welcome " + Login.LoggedInName + ".";
            textBoxId.Focus();
        }


        private void timerAdmin_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMMM");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string textGroup = textBoxGroup.Text;

            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxGroup.Text) || string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPass.Text))
            {
                // Message box for clock in
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox1.Text = "Wrong Format!";
                clockMessage.labelBox2.Text = "Please check if you have inserted correct all details."; // Please insert your employee ID.";
                clockMessage.ShowDialog();
                textBoxId.Text = string.Empty;
                textBoxGroup.Text = string.Empty;
                textBoxName.Text = string.Empty;
                textBoxPass.Text = string.Empty;
                textBoxId.Focus();
                textBoxId.Select();
                return;
            }

            else
            {
                try
                {
                    DateTime dateTime = DateTime.Now;
                    string queryString3 = "INSERT INTO UserLogin (Employee_no, Employee_type, Employee_name, Employee_pass, Created_date, Created_time, Added_by) " +
                                          "VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)";
                    SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                    SqlCommand command1 = new SqlCommand(queryString3, connection);
                    command1.Parameters.AddWithValue("@value1", int.Parse(textBoxId.Text));
                    command1.Parameters.AddWithValue("@value2", textGroup);
                    command1.Parameters.AddWithValue("@value3", textBoxName.Text);
                    command1.Parameters.AddWithValue("@value4", textBoxPass.Text);
                    command1.Parameters.AddWithValue("@value5", dateTime.ToString("dd MMMM yyyy"));  //dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    command1.Parameters.AddWithValue("@value6", dateTime.ToString("HH:mm"));
                    command1.Parameters.AddWithValue("@value7", Login.LoggedInNumber.ToString());

                    connection.Open();
                    SqlDataReader reader2 = command1.ExecuteReader();
                    reader2.Read();

                    // Message box for clock in
                    ClockAlertMess clockMessage = new ClockAlertMess();
                    clockMessage.BackColor = Color.FromArgb(85, 129, 57);
                    clockMessage.roundBorderPanel1.BackgroundColor = Color.FromArgb(226, 239, 219);
                    clockMessage.roundBorderPanel1.BorderColor = Color.FromArgb(85, 129, 57);
                    clockMessage.labelBox1.BackColor = Color.FromArgb(226, 239, 219);
                    clockMessage.labelBox2.BackColor = Color.FromArgb(226, 239, 219);
                    clockMessage.labelBox1.Text = "Employee added on the register.";
                    clockMessage.labelBox2.Text = "Employee with the ID " + textBoxId.Text + " and name " + textBoxName.Text + " has been registered in the " + textBoxGroup.Text + " group successful.";
                    clockMessage.ShowDialog();

                    reader2.Close();
                    connection.Close();

                    textBoxId.Text = string.Empty;
                    textBoxGroup.Text = string.Empty;
                    textBoxName.Text = string.Empty;
                    textBoxPass.Text = string.Empty;
                    textBoxId.Focus();
                    textBoxId.Select();
                }
                catch (Exception ex)
                {
                    ClockAlertMess clockMessage = new ClockAlertMess();
                    clockMessage.labelBox2.Text = "Not successful attempt: " + ex.Message;
                    clockMessage.ShowDialog();
                    textBoxId.Text = string.Empty;
                    textBoxGroup.Text = string.Empty;
                    textBoxName.Text = string.Empty;
                    textBoxPass.Text = string.Empty;
                    textBoxId.Focus();
                    textBoxId.Select();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDelete.Text))
            {
                // Message box for clock in
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox1.Text = "Wrong Format!";
                clockMessage.labelBox2.Text = "Please check if you have inserted the details correct."; // Please insert your employee ID.";
                clockMessage.ShowDialog();
                textBoxDelete.Text = string.Empty;
                textBoxDelete.Select();
                textBoxDelete.Focus();
                return;
            }
            else
            {
                try
                {
                    // Part in checking if Employee is on company database
                    string queryString1 = "SELECT Employee_no FROM UserLogin WHERE Employee_no = @E_no";
                    SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                    SqlCommand command = new SqlCommand(queryString1, connection);
                    command.Parameters.AddWithValue("@E_no", int.Parse(textBoxDelete.Text));
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    bool readerHasRows = reader.HasRows;
                    reader.Close();
                    if (!readerHasRows)
                    {
                        ClockAlertMess clockMessage = new ClockAlertMess();
                        clockMessage.labelBox2.Text = "This employee ID " + textBoxDelete.Text + " is not registered";
                        clockMessage.ShowDialog();

                        textBoxDelete.Text = string.Empty;
                        textBoxDelete.Focus();
                        textBoxDelete.Select();
                    }
                    else
                    {
                        DateTime dateTime = DateTime.Now;
                        string queryString3 = "DELETE FROM UserLogin WHERE Employee_no = @value1";
                        //SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                        SqlCommand command1 = new SqlCommand(queryString3, connection);
                        command1.Parameters.AddWithValue("@value1", int.Parse(textBoxDelete.Text));
                        //connection.Open();
                        SqlDataReader reader2 = command1.ExecuteReader();
                        reader2.Read();

                        // Message box for clock in
                        ClockAlertMess clockMessage = new ClockAlertMess();
                        clockMessage.roundBorderPanel1.BackgroundColor = Color.FromArgb(255, 246, 208);
                        clockMessage.roundBorderPanel1.BorderColor = Color.FromArgb(190, 142, 31, 1);
                        clockMessage.labelBox1.BackColor = Color.FromArgb(255, 246, 208);
                        clockMessage.labelBox2.BackColor = Color.FromArgb(255, 246, 208);
                        clockMessage.labelBox1.Text = "Delete action performed.";
                        clockMessage.labelBox2.Text = "Employee with the ID " + textBoxDelete.Text + " has been removed from login access, successful.";
                        clockMessage.ShowDialog();
                        reader2.Close();
                        connection.Close();

                        textBoxDelete.Text = string.Empty;
                        textBoxDelete.Focus();
                        textBoxDelete.Select();
                    }
                }
                catch (Exception ex)
                {
                    ClockAlertMess clockMessage = new ClockAlertMess();
                    clockMessage.labelBox2.Text = "Not successful attempt: " + ex.Message;
                    clockMessage.ShowDialog();
                    textBoxDelete.Text = string.Empty;
                    textBoxId.Focus();
                    textBoxId.Select();
                }
            }

        }
        private async void btnLogOut_Click(object sender, EventArgs e)
        {
            this.RefToLogin.Show();
            await Task.Delay(500);
            this.Dispose();
        }



        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;
        private bool backSpace = false;
        // Handle the KeyDown event to determine the type of character entered into the control.
        private void textBoxId_KeyDown(object sender, KeyEventArgs e)
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

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxDelete_KeyDown(object sender, KeyEventArgs e)
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

        private void textBoxDelete_KeyPress(object sender, KeyPressEventArgs e)
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
