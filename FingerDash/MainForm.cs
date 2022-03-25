using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FingerDash.Forms;

namespace FingerDash
{
    public partial class MainForm : Form
    {
        int ibox;
        public MainForm()
        {
            InitializeComponent();
            timerTime.Start();
        }

        public void timerTime_Tick(object sender, EventArgs e)
        {
            //get current time and display on the app
            DateTime datetime = DateTime.Now;
            label1.Text = datetime.ToString("hh:mm");
            label2.Text = datetime.ToString("tt");
            label3.Text = datetime.ToString("dddd, dd MMMMM");
        }


        private async void btn_login_Click(object sender, EventArgs e)
        {
            Login logAccess = new Login();
            logAccess.RefToMainForm = this;
            logAccess.InsertBox = insertBox;
            insertBox.Text = "";
            clearInsertNo();
            await Task.Delay(100);
            logAccess.Show();
            await Task.Delay(400);
            this.Hide();
        }

        new Control ActiveControl;

        private void btn_nr1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ActiveControl.Focus();
            // recording each button number pressed for show button function
            string theText = insertBox.Text;
            if (theText.Length == 0)
            {
                SendKeys.Send(btn.Text);
            }
            if (theText.Length == 1)
            {
                insertBox.Text = "";
                SendKeys.Send(theText + btn.Text);
            }
            if (theText.Length == 2)
            {
                insertBox.Text = "";
                SendKeys.Send(theText + btn.Text);
            }
            if (theText.Length == 3)
            {
                insertBox.Text = "";
                SendKeys.Send(theText + btn.Text);
            }
            if (theText.Length == 4)
            {
                insertBox.Text = "";
                SendKeys.Send(theText + btn.Text);
            }
            if (theText.Length == 5)
            {
                insertBox.Text = "";
                SendKeys.Send(theText + btn.Text);
            }
            //displayPresKey();
            btn_nrBack.Enabled = true;  //enabel backspace button
        }

        public void insertBox_Enter(object sender, EventArgs e)
        {
            // use to reccord user imput number
            ActiveControl = (Control)sender;

        }

        // Boolean flag used to determine when a character other than a number is entered.
        private bool nonNumberEntered = false;
        private bool backSpace = false;

        // Handle the KeyDown event to determine the type of character entered into the control.
        private void insertBox_KeyDown(object sender, KeyEventArgs e)
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
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void insertBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (backSpace == true)
            {
                int i = insertBox.Text.Length;
                if (i == 1 & i < 5) displayNo1.Visible = false;
                if (i == 2 & i < 5) displayNo2.Visible = false;
                if (i == 3 & i < 5) displayNo3.Visible = false;
                if (i == 4 & i < 5) displayNo4.Visible = false;
                if (i == 5 & i < 6) displayNo5.Visible = false;
                backSpace = false;
            }
            else
            {
                displayPresKey();
            }
        }

        private void btn_nrDelete_Click(object sender, EventArgs e)
        {
            clearInsertNo();
            insertBox.Focus();
        }
        private void btn_nrBack_Click(object sender, EventArgs e)
        {
            backSpaceBtn();
            insertBox.Focus();
        }

        private void displayPresKey()
        {
            ibox = insertBox.Text.Length;
            if (ibox == 0) displayNo1.Visible = true;
            if (ibox == 1) displayNo2.Visible = true;
            if (ibox == 2) displayNo3.Visible = true;
            if (ibox == 3) displayNo4.Visible = true;
            if (ibox == 4) displayNo5.Visible = true;
        }

        private void backSpaceBtn()
        {
            int i = insertBox.Text.Length;
            if (i > 0)
            {
                insertBox.Text = insertBox.Text.Substring(0, i - 1);
            }
            if (i == 0) btn_nrBack.Enabled = false;
            if (i == 1) displayNo1.Visible = false;
            if (i == 2) displayNo2.Visible = false;
            if (i == 3) displayNo3.Visible = false;
            if (i == 4) displayNo4.Visible = false;
            if (i == 5) displayNo5.Visible = false;
        }

        private void clearInsertNo()
        {
            insertBox.Text = "";    //  insertBox.Clear(); 
            if (insertBox.Text.Length == 0)
            {
                displayNo1.Visible = false;
                displayNo2.Visible = false;
                displayNo3.Visible = false;
                displayNo4.Visible = false;
                displayNo5.Visible = false;
            }
        }

        private void btn_clockIn_Click(object sender, EventArgs e)
        {
            if (insertBox.Text.Length < 5)
            {
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox2.Text = "Employee ID is not complete, missing some digits.";
                clockMessage.ShowDialog();
                clearInsertNo();
                insertBox.Focus();
            }
            else
            {
                try
                {
                    // Part in checking if Employee is on company database
                    string queryString1 = "SELECT Employee_no, Employee_name FROM UserLogin WHERE Employee_no = @E_no";
                    SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                    SqlCommand command = new SqlCommand(queryString1, connection);
                    command.Parameters.AddWithValue("@E_no", int.Parse(insertBox.Text));
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    bool readerHasRows = reader.HasRows;
                    int userClockIN = int.Parse(insertBox.Text);
                    int userId = reader.GetInt32(0);

                    DateTime dateTime = DateTime.Now;
                    string userName1 = reader.GetString(1);
                    string dateDayName = dateTime.ToString("dddd");
                    string presentDay = dateTime.ToString("dd/MM/yyyy");
                    reader.Close();

                    //Part on checking if user is new employee, if not it will execute query to clock in
                    string queryString2 = "SELECT Employee_no, Employee_name, Clock_date, Current_day, ClockIn_date FROM ClockInOut WHERE Employee_no = @E_no AND Clock_date = @C_date";
                    SqlCommand command0 = new SqlCommand(queryString2, connection);
                    command0.Parameters.AddWithValue("@E_no", int.Parse(insertBox.Text));
                    command0.Parameters.AddWithValue("@C_date", dateTime.ToString("yyyy-MM-dd"));
                    SqlDataReader reader1 = command0.ExecuteReader();
                    reader1.Read();
                    bool readerHasRows1 = reader1.HasRows;

                    reader1.Close();
                    if (!readerHasRows1)
                    {
                        // setup values to get inserted in database ClockINOut table                    
                        string queryString3 = "INSERT INTO ClockInOut (Employee_no, Employee_name, Clock_date, Current_day, ClockIn_date) VALUES (@value1, @value2, @value3, @value4, @value5)";
                        SqlCommand command1 = new SqlCommand(queryString3, connection);
                        command1.Parameters.AddWithValue("@value1", int.Parse(insertBox.Text));
                        command1.Parameters.AddWithValue("@value2", userName1);
                        command1.Parameters.AddWithValue("@value3", dateTime.ToString("yyyy-MM-dd"));
                        command1.Parameters.AddWithValue("@value4", dateDayName);
                        command1.Parameters.AddWithValue("@value5", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        SqlDataReader reader2 = command1.ExecuteReader();
                        reader2.Read();
                        // Message box for clock in
                        ClockInOutMess clockMessage = new ClockInOutMess();
                        clockMessage.label1.Text = "Clock-In Confirmed";
                        clockMessage.label2.Text = userName1;
                        clockMessage.label3.Text = dateTime.ToString("hh:mm tt");
                        clockMessage.label4.Text = dateTime.ToString("dddd, dd MMMMM yyyy");
                        clockMessage.ShowDialog();

                        reader2.Close();

                    }
                    else
                    {
                        //Part to check if the employee is already clocked IN for the present day work
                        string queryString4 = "SELECT Employee_no, Employee_name, Clock_date, Current_day, ClockIn_date, ClockOut_date FROM ClockInOut WHERE Employee_no = @E_no1 AND Clock_date = @C_date1";
                        SqlCommand command4 = new SqlCommand(queryString4, connection);
                        command4.Parameters.AddWithValue("@E_no1", int.Parse(insertBox.Text));
                        command4.Parameters.AddWithValue("@C_date1", dateTime.ToString("yyyy-MM-dd"));
                        SqlDataReader reader4 = command4.ExecuteReader();

                        reader4.Read();
                        bool readerHasRows4 = reader4.HasRows;
                        string clockPresentDate = reader4.GetDateTime(2).ToString("dd/MM/yyyy");
                        bool alreadyClockIn = reader4.GetSqlDateTime(4).IsNull;
                        bool alreadyClockOut = reader4.GetSqlDateTime(5).IsNull;
                        reader4.Close();

                        if (readerHasRows4 & userId == userClockIN & clockPresentDate == presentDay & !alreadyClockIn)
                        {
                            ClockAlertMess clockMessage = new ClockAlertMess();
                            clockMessage.BackColor = Color.FromArgb(85, 129, 57);
                            clockMessage.roundBorderPanel1.BackgroundColor = Color.FromArgb(226, 239, 219);
                            clockMessage.roundBorderPanel1.BorderColor = Color.FromArgb(85, 129, 57);
                            clockMessage.labelBox1.BackColor = Color.FromArgb(226, 239, 219);
                            clockMessage.labelBox2.BackColor = Color.FromArgb(226, 239, 219);
                            clockMessage.labelBox2.Text = "Hi " + userName1 + ", you already Clocked In today.";
                            clockMessage.ShowDialog();

                        }

                        else if (readerHasRows4 & !alreadyClockOut)
                        {
                            ClockAlertMess clockMessage = new ClockAlertMess();
                            clockMessage.BackColor = Color.FromArgb(85, 129, 57);
                            clockMessage.roundBorderPanel1.BackgroundColor = Color.FromArgb(226, 239, 219);
                            clockMessage.roundBorderPanel1.BorderColor = Color.FromArgb(85, 129, 57);
                            clockMessage.labelBox1.BackColor = Color.FromArgb(226, 239, 219);
                            clockMessage.labelBox2.BackColor = Color.FromArgb(226, 239, 219);
                            clockMessage.labelBox2.Text = "Dear " + userName1 + ", please speak with your team manager to adjust your timecard, because you already Clocked Out today.";
                            clockMessage.ShowDialog();
                        }
                    }
                    connection.Close();
                    clearInsertNo();
                }
                catch (Exception)
                {
                    ClockAlertMess clockMessage = new ClockAlertMess();
                    clockMessage.labelBox2.Text = "No Employee found with this ID!";
                    clockMessage.ShowDialog();
                    clearInsertNo();
                }
                insertBox.Focus();
            }

        }

        private void btn_clockOut_Click(object sender, EventArgs e)
        {
            string userNameEp = "";
            if (insertBox.Text.Length < 5)
            {
                ClockAlertMess clockMessage = new ClockAlertMess();
                clockMessage.labelBox2.Text = "Employee ID is not complete, missing some digits.";
                clockMessage.ShowDialog();
                clearInsertNo();
                insertBox.Focus();
            }
            else
            {
                try
                {
                    // Part in checking if Employee is on company database
                    string queryString1 = "SELECT Employee_no, Employee_name FROM UserLogin WHERE Employee_no = @E_no";
                    SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                    SqlCommand command = new SqlCommand(queryString1, connection);
                    command.Parameters.AddWithValue("@E_no", int.Parse(insertBox.Text));
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    int userClockIN = int.Parse(insertBox.Text);
                    int userId = reader.GetInt32(0);

                    DateTime dateTime = DateTime.Now;
                    string userName1 = reader.GetString(1);
                    userNameEp = reader.GetString(1);
                    string presentDay = dateTime.ToString("dd/MM/yyyy");
                    reader.Close();

                    //Part on checking if user is new employee, if not it will execute query to clock OUT
                    string queryString2 = "SELECT Employee_no, Employee_name, Clock_date, Current_day, ClockOut_date FROM ClockInOut WHERE Employee_no = @E_no AND Clock_date = @C_date";
                    SqlCommand command0 = new SqlCommand(queryString2, connection);
                    command0.Parameters.AddWithValue("@E_no", int.Parse(insertBox.Text));
                    command0.Parameters.AddWithValue("@C_date", dateTime.ToString("yyyy-MM-dd"));
                    SqlDataReader reader1 = command0.ExecuteReader();
                    reader1.Read();

                    bool readerHasRows1 = reader1.HasRows;
                    bool alreadyClockedOut = reader1.GetSqlDateTime(4).IsNull;
                    reader1.Close();

                    if (readerHasRows1 && alreadyClockedOut)
                    {
                        // setup values to get inserted in database ClockINOut table                    
                        string queryString3 = "UPDATE ClockInOut SET ClockOut_date = @value1 WHERE Employee_no = @E_noOut AND Clock_date = @C_dateOut";
                        SqlCommand command1 = new SqlCommand(queryString3, connection);
                        command1.Parameters.AddWithValue("@value1", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        command1.Parameters.AddWithValue("@E_noOut", int.Parse(insertBox.Text));
                        command1.Parameters.AddWithValue("@C_dateOut", dateTime.ToString("yyyy-MM-dd"));

                        SqlDataReader reader2 = command1.ExecuteReader();
                        reader2.Read();

                        // Message box for clock in
                        ClockInOutMess clockMessage = new ClockInOutMess();
                        clockMessage.label1.Text = "Clock-Out Confirmed";
                        clockMessage.label2.Text = userName1;
                        clockMessage.label3.Text = dateTime.ToString("hh:mm tt");
                        clockMessage.label4.Text = dateTime.ToString("dddd, dd MMMMM yyyy");
                        clockMessage.ShowDialog();

                        reader2.Close();
                        clearInsertNo();
                    }
                    else
                    {
                        //Part to check if the employee is already clocked OUT for the present day work
                        string queryString4 = "SELECT Employee_no, Employee_name, Clock_date, Current_day, ClockOut_date FROM ClockInOut WHERE Employee_no = @E_no1 AND Clock_date = @C_date1";
                        SqlCommand command4 = new SqlCommand(queryString4, connection);
                        command4.Parameters.AddWithValue("@E_no1", int.Parse(insertBox.Text));
                        command4.Parameters.AddWithValue("@C_date1", dateTime.ToString("yyyy-MM-dd"));
                        SqlDataReader reader4 = command0.ExecuteReader();

                        reader4.Read();
                        bool readerHasRows4 = reader4.HasRows;
                        string clockPresentDate = reader4.GetDateTime(2).ToString("dd/MM/yyyy");
                        bool alreadyClockIn = reader4.GetSqlDateTime(4).IsNull;
                        reader4.Close();

                        if (readerHasRows4 & userId == userClockIN & clockPresentDate == presentDay & !alreadyClockIn)
                        {
                            ClockAlertMess clockMessage = new ClockAlertMess();
                            clockMessage.BackColor = Color.FromArgb(85, 129, 57);
                            clockMessage.roundBorderPanel1.BackgroundColor = Color.FromArgb(255, 246, 208);
                            clockMessage.roundBorderPanel1.BorderColor = Color.FromArgb(190, 142, 31);
                            clockMessage.labelBox1.BackColor = Color.FromArgb(255, 246, 208);
                            clockMessage.labelBox2.BackColor = Color.FromArgb(255, 246, 208);
                            clockMessage.labelBox2.Text = "Hi " + userName1 + ", you already Clocked Out today.";
                            clockMessage.ShowDialog();
                            clearInsertNo();
                        }
                    }
                    connection.Close();
                }
                catch (Exception)
                {
                    if (userNameEp == "")
                    {
                        ClockAlertMess clockMessageAlert = new ClockAlertMess();
                        clockMessageAlert.labelBox2.Text = "No Employee found with this ID ";
                        clockMessageAlert.ShowDialog();
                        clearInsertNo();
                    }
                    else
                    {
                        ClockAlertMess clockMessage = new ClockAlertMess();
                        clockMessage.labelBox1.Text = "You did not Clock In today.";
                        clockMessage.labelBox2.Text = "Dear " + userNameEp + ", please speak with your team manager to adjust your timecard.";
                        clockMessage.ShowDialog();

                        DateTime dateTime = DateTime.Now;
                        string dateDayName = dateTime.ToString("dddd");

                        // setup values to get inserted in database ClockINOut table                    
                        string queryString3 = "INSERT INTO ClockInOut (Employee_no, Employee_name, Clock_date, Current_day, ClockOut_date) VALUES (@value1, @value2, @value3, @value4, @value5)";
                        SqlConnection connection = new SqlConnection(DbConnection.getDbConnection());
                        SqlCommand command1 = new SqlCommand(queryString3, connection);
                        command1.Parameters.AddWithValue("@value1", int.Parse(insertBox.Text));
                        command1.Parameters.AddWithValue("@value2", userNameEp);
                        command1.Parameters.AddWithValue("@value3", dateTime.ToString("yyyy-MM-dd"));
                        command1.Parameters.AddWithValue("@value4", dateDayName);
                        command1.Parameters.AddWithValue("@value5", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                        connection.Open();
                        SqlDataReader readerX = command1.ExecuteReader();
                        readerX.Read();

                        // Message box for clock in
                        ClockInOutMess clockOutMessage = new ClockInOutMess();
                        clockOutMessage.label1.Text = "Clock-Out Confirmed";
                        clockOutMessage.label2.Text = userNameEp;
                        clockOutMessage.label3.Text = dateTime.ToString("hh:mm tt");
                        clockOutMessage.label4.Text = dateTime.ToString("dddd, dd MMMMM yyyy");
                        clockOutMessage.ShowDialog();

                        readerX.Close();
                        connection.Close();
                        clearInsertNo();
                    }

                }
                insertBox.Focus();
            }
        }

        private void btn_ShowNo_MouseHover(object sender, EventArgs e)
        {
            int i = insertBox.Text.Length;
            if (i == 1)
            {
                displayNo1.Text = insertBox.Text[0].ToString();
            }
            if (i == 2)
            {
                displayNo1.Text = insertBox.Text[0].ToString();
                displayNo2.Text = insertBox.Text[1].ToString();
            }
            if (i == 3)
            {
                displayNo1.Text = insertBox.Text[0].ToString();
                displayNo2.Text = insertBox.Text[1].ToString();
                displayNo3.Text = insertBox.Text[2].ToString();
            }
            if (i == 4)
            {
                displayNo1.Text = insertBox.Text[0].ToString();
                displayNo2.Text = insertBox.Text[1].ToString();
                displayNo3.Text = insertBox.Text[2].ToString();
                displayNo4.Text = insertBox.Text[3].ToString();
            }
            if (i == 5)
            {
                displayNo1.Text = insertBox.Text[0].ToString();
                displayNo2.Text = insertBox.Text[1].ToString();
                displayNo3.Text = insertBox.Text[2].ToString();
                displayNo4.Text = insertBox.Text[3].ToString();
                displayNo5.Text = insertBox.Text[4].ToString();
            }
        }

        private void btn_ShowNo_MouseLeave(object sender, EventArgs e)
        {
            displayNo1.Text = "";
            displayNo2.Text = "";
            displayNo3.Text = "";
            displayNo4.Text = "";
            displayNo5.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*  //Drag Main Frame
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }*/
    }
}
