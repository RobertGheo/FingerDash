
namespace FingerDash
{
    partial class MenuStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_TimeS = new System.Windows.Forms.Timer(this.components);
            this.user_logged = new System.Windows.Forms.Label();
            this.top_panelS = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.btn_logOut = new FingerDash.ClassControls.RJButton();
            this.btn_login = new FingerDash.ClassControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_myRota = new FingerDash.ClassControls.RJButton();
            this.btn_myTimeSheet = new FingerDash.ClassControls.RJButton();
            this.btn_myBalances = new FingerDash.ClassControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.top_panelS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_TimeS
            // 
            this.timer_TimeS.Tick += new System.EventHandler(this.timer_TimeS_Tick);
            // 
            // user_logged
            // 
            this.user_logged.AutoSize = true;
            this.user_logged.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_logged.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.user_logged.Location = new System.Drawing.Point(230, 336);
            this.user_logged.Name = "user_logged";
            this.user_logged.Size = new System.Drawing.Size(140, 25);
            this.user_logged.TabIndex = 3;
            this.user_logged.Text = "User Logged In";
            this.user_logged.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // top_panelS
            // 
            this.top_panelS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.top_panelS.Controls.Add(this.pictureBox1);
            this.top_panelS.Controls.Add(this.label_EmployeeName);
            this.top_panelS.Controls.Add(this.btn_logOut);
            this.top_panelS.Controls.Add(this.btn_login);
            this.top_panelS.Controls.Add(this.label6);
            this.top_panelS.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panelS.Location = new System.Drawing.Point(0, 0);
            this.top_panelS.Name = "top_panelS";
            this.top_panelS.Size = new System.Drawing.Size(1080, 84);
            this.top_panelS.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FingerDash.Properties.Resources.FingerDash_logos_84;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(56, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 84);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EmployeeName.Location = new System.Drawing.Point(939, 55);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(130, 19);
            this.label_EmployeeName.TabIndex = 29;
            this.label_EmployeeName.Text = "My Account";
            this.label_EmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logOut
            // 
            this.btn_logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_logOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_logOut.BackgroundImage = global::FingerDash.Properties.Resources.Logout_BTN;
            this.btn_logOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logOut.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_logOut.BorderRadius = 14;
            this.btn_logOut.BorderSize = 0;
            this.btn_logOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_logOut.FlatAppearance.BorderSize = 0;
            this.btn_logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logOut.ForeColor = System.Drawing.Color.Black;
            this.btn_logOut.Location = new System.Drawing.Point(894, 13);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(42, 42);
            this.btn_logOut.TabIndex = 28;
            this.btn_logOut.TextColor = System.Drawing.Color.Black;
            this.btn_logOut.UseVisualStyleBackColor = false;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_login.BackgroundImage = global::FingerDash.Properties.Resources.icons8_user_38;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_login.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_login.BorderRadius = 42;
            this.btn_login.BorderSize = 0;
            this.btn_login.Enabled = false;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(980, 13);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(42, 42);
            this.btn_login.TabIndex = 28;
            this.btn_login.TextColor = System.Drawing.Color.White;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(891, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Logout";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_myRota
            // 
            this.btn_myRota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myRota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myRota.BackgroundImage = global::FingerDash.Properties.Resources.Rota_BTN;
            this.btn_myRota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_myRota.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myRota.BorderRadius = 70;
            this.btn_myRota.BorderSize = 0;
            this.btn_myRota.FlatAppearance.BorderSize = 0;
            this.btn_myRota.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_myRota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myRota.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_myRota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_myRota.Location = new System.Drawing.Point(569, 205);
            this.btn_myRota.Margin = new System.Windows.Forms.Padding(0);
            this.btn_myRota.Name = "btn_myRota";
            this.btn_myRota.Size = new System.Drawing.Size(70, 70);
            this.btn_myRota.TabIndex = 23;
            this.btn_myRota.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_myRota.UseVisualStyleBackColor = false;
            this.btn_myRota.Click += new System.EventHandler(this.btn_myRota_Click);
            // 
            // btn_myTimeSheet
            // 
            this.btn_myTimeSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myTimeSheet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myTimeSheet.BackgroundImage = global::FingerDash.Properties.Resources.Timesheet_BTN;
            this.btn_myTimeSheet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_myTimeSheet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.btn_myTimeSheet.BorderRadius = 70;
            this.btn_myTimeSheet.BorderSize = 0;
            this.btn_myTimeSheet.FlatAppearance.BorderSize = 0;
            this.btn_myTimeSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_myTimeSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myTimeSheet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_myTimeSheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_myTimeSheet.Location = new System.Drawing.Point(689, 205);
            this.btn_myTimeSheet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_myTimeSheet.Name = "btn_myTimeSheet";
            this.btn_myTimeSheet.Size = new System.Drawing.Size(70, 70);
            this.btn_myTimeSheet.TabIndex = 24;
            this.btn_myTimeSheet.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_myTimeSheet.UseVisualStyleBackColor = false;
            this.btn_myTimeSheet.Click += new System.EventHandler(this.btn_myTimeSheet_Click);
            // 
            // btn_myBalances
            // 
            this.btn_myBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myBalances.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_myBalances.BackgroundImage = global::FingerDash.Properties.Resources.Balance_BTN;
            this.btn_myBalances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_myBalances.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(252)))));
            this.btn_myBalances.BorderRadius = 70;
            this.btn_myBalances.BorderSize = 0;
            this.btn_myBalances.FlatAppearance.BorderSize = 0;
            this.btn_myBalances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_myBalances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_myBalances.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_myBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_myBalances.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_myBalances.Location = new System.Drawing.Point(809, 205);
            this.btn_myBalances.Margin = new System.Windows.Forms.Padding(0);
            this.btn_myBalances.Name = "btn_myBalances";
            this.btn_myBalances.Size = new System.Drawing.Size(70, 70);
            this.btn_myBalances.TabIndex = 25;
            this.btn_myBalances.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_myBalances.UseVisualStyleBackColor = false;
            this.btn_myBalances.Click += new System.EventHandler(this.btn_myBalances_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(475, 264);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(60, 37);
            this.label2.TabIndex = 34;
            this.label2.Text = "AM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(280, 303);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Friday, 29 November";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(209, 190);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(295, 128);
            this.label1.TabIndex = 33;
            this.label1.Text = "04:44";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.Enabled = false;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(230, 307);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(300, 28);
            this.label4.TabIndex = 36;
            this.label4.Text = "____________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(574, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "MY ROTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(675, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "MY TIMESHEET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(796, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "MY BALANCES";
            // 
            // MenuStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1080, 710);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_myBalances);
            this.Controls.Add(this.btn_myTimeSheet);
            this.Controls.Add(this.btn_myRota);
            this.Controls.Add(this.top_panelS);
            this.Controls.Add(this.user_logged);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1080, 710);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "MenuStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Menu";
            this.top_panelS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_TimeS;
        private System.Windows.Forms.Label user_logged;
        private System.Windows.Forms.Panel top_panelS;
        private ClassControls.RJButton btn_myRota;
        private ClassControls.RJButton btn_myTimeSheet;
        private ClassControls.RJButton btn_myBalances;
        private System.Windows.Forms.Label label6;
        private ClassControls.RJButton btn_logOut;
        private System.Windows.Forms.Label label_EmployeeName;
        private ClassControls.RJButton btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}