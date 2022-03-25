
namespace FingerDash
{
    partial class Login
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
            this.user_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.btn_login = new FingerDash.ClassControls.RJButton();
            this.btn_close = new FingerDash.ClassControls.RJButton();
            this.btn_show = new FingerDash.ClassControls.RJButton();
            this.top_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton2 = new FingerDash.ClassControls.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rjButton1 = new FingerDash.ClassControls.RJButton();
            this.user_box = new FingerDash.ClassControls.RjTextBox();
            this.pass_box = new FingerDash.ClassControls.RjTextBox();
            this.timerLogPage = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.user_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.user_label.Location = new System.Drawing.Point(620, 223);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(106, 24);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "Employee ID";
            // 
            // pass_label
            // 
            this.pass_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pass_label.Location = new System.Drawing.Point(620, 275);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(106, 24);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_login.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btn_login.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_login.BorderRadius = 10;
            this.btn_login.BorderSize = 0;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_login.Location = new System.Drawing.Point(620, 344);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(225, 38);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_close.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btn_close.BackgroundImage = global::FingerDash.Properties.Resources.icons8_back_arrow_38;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_close.BorderRadius = 40;
            this.btn_close.BorderSize = 0;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(165)))), ((int)(((byte)(210)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(894, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_close.Size = new System.Drawing.Size(42, 42);
            this.btn_close.TabIndex = 5;
            this.btn_close.TextColor = System.Drawing.Color.Black;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_show
            // 
            this.btn_show.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_show.BackColor = System.Drawing.Color.White;
            this.btn_show.BackgroundColor = System.Drawing.Color.White;
            this.btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_show.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_show.BorderRadius = 24;
            this.btn_show.BorderSize = 0;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Image = global::FingerDash.Properties.Resources.look_20;
            this.btn_show.Location = new System.Drawing.Point(817, 296);
            this.btn_show.Margin = new System.Windows.Forms.Padding(0);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(24, 24);
            this.btn_show.TabIndex = 6;
            this.btn_show.TextColor = System.Drawing.Color.White;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.MouseLeave += new System.EventHandler(this.btn_show_MouseLeave);
            this.btn_show.MouseHover += new System.EventHandler(this.btn_show_MouseHover);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.top_panel.Controls.Add(this.pictureBox1);
            this.top_panel.Controls.Add(this.rjButton2);
            this.top_panel.Controls.Add(this.label6);
            this.top_panel.Controls.Add(this.label5);
            this.top_panel.Controls.Add(this.rjButton1);
            this.top_panel.Controls.Add(this.btn_close);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1080, 84);
            this.top_panel.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FingerDash.Properties.Resources.FingerDash_logos_84;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(56, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 84);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.rjButton2.BackgroundImage = global::FingerDash.Properties.Resources.icons8_user_38;
            this.rjButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleGreen;
            this.rjButton2.BorderRadius = 40;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(980, 13);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rjButton2.Size = new System.Drawing.Size(42, 42);
            this.rjButton2.TabIndex = 29;
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(897, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Back";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(957, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "My Account";
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.CadetBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleGreen;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1810, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(110, 45);
            this.rjButton1.TabIndex = 19;
            this.rjButton1.Text = "Login";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // user_box
            // 
            this.user_box.BackColor = System.Drawing.SystemColors.Window;
            this.user_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.user_box.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.user_box.BorderRadius = 10;
            this.user_box.BorderSize = 1;
            this.user_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_box.Location = new System.Drawing.Point(620, 242);
            this.user_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_box.MaxLength = 50;
            this.user_box.Multiline = false;
            this.user_box.Name = "user_box";
            this.user_box.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.user_box.PasswordChar = false;
            this.user_box.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.user_box.PlaceholderText = "";
            this.user_box.Size = new System.Drawing.Size(225, 32);
            this.user_box.TabIndex = 22;
            this.user_box.Texts = "";
            this.user_box.UnderlinedStyle = false;
            this.user_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_box_KeyDown);
            this.user_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_box_KeyPress);
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.SystemColors.Window;
            this.pass_box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(181)))), ((int)(((byte)(224)))));
            this.pass_box.BorderFocusColor = System.Drawing.Color.SeaGreen;
            this.pass_box.BorderRadius = 10;
            this.pass_box.BorderSize = 1;
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass_box.Location = new System.Drawing.Point(620, 293);
            this.pass_box.Margin = new System.Windows.Forms.Padding(4);
            this.pass_box.MaxLength = 50;
            this.pass_box.Multiline = false;
            this.pass_box.Name = "pass_box";
            this.pass_box.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pass_box.PasswordChar = true;
            this.pass_box.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.pass_box.PlaceholderText = "";
            this.pass_box.Size = new System.Drawing.Size(225, 32);
            this.pass_box.TabIndex = 23;
            this.pass_box.Texts = "";
            this.pass_box.UnderlinedStyle = false;
            // 
            // timerLogPage
            // 
            this.timerLogPage.Tick += new System.EventHandler(this.timerLogPage_Tick);
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
            this.label1.TabIndex = 24;
            this.label1.Text = "04:44";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.label3.TabIndex = 26;
            this.label3.Text = "Friday, 29 November";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label2.TabIndex = 25;
            this.label2.Text = "AM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(230, 307);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(300, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "____________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1080, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_box);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1080, 710);
            this.MinimumSize = new System.Drawing.Size(760, 460);
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label pass_label;
        private ClassControls.RJButton btn_login;
        private ClassControls.RJButton btn_close;
        private ClassControls.RJButton btn_show;
        private System.Windows.Forms.Panel top_panel;
        private ClassControls.RJButton rjButton1;
        private ClassControls.RjTextBox user_box;
        private ClassControls.RjTextBox pass_box;
        private System.Windows.Forms.Timer timerLogPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ClassControls.RJButton rjButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}