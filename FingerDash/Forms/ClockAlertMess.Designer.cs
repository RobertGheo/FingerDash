
namespace FingerDash.Forms
{
    partial class ClockAlertMess
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
            this.roundBorderPanel1 = new FingerDash.ClassControls.RoundBorderPanel();
            this.labelBox2 = new System.Windows.Forms.TextBox();
            this.labelBox1 = new System.Windows.Forms.TextBox();
            this.btnOkClose = new FingerDash.ClassControls.RJButton();
            this.roundBorderPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundBorderPanel1
            // 
            this.roundBorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.roundBorderPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.roundBorderPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(64)))), ((int)(((byte)(67)))));
            this.roundBorderPanel1.BorderRadius = 0;
            this.roundBorderPanel1.BorderSize = 2;
            this.roundBorderPanel1.Controls.Add(this.labelBox2);
            this.roundBorderPanel1.Controls.Add(this.labelBox1);
            this.roundBorderPanel1.Controls.Add(this.btnOkClose);
            this.roundBorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundBorderPanel1.ForeColor = System.Drawing.Color.White;
            this.roundBorderPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundBorderPanel1.Name = "roundBorderPanel1";
            this.roundBorderPanel1.Size = new System.Drawing.Size(460, 280);
            this.roundBorderPanel1.TabIndex = 2;
            this.roundBorderPanel1.TextColor = System.Drawing.Color.White;
            // 
            // labelBox2
            // 
            this.labelBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.labelBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelBox2.Enabled = false;
            this.labelBox2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.labelBox2.Location = new System.Drawing.Point(45, 100);
            this.labelBox2.Multiline = true;
            this.labelBox2.Name = "labelBox2";
            this.labelBox2.ReadOnly = true;
            this.labelBox2.Size = new System.Drawing.Size(370, 98);
            this.labelBox2.TabIndex = 10;
            this.labelBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBox1
            // 
            this.labelBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(232)))));
            this.labelBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelBox1.Enabled = false;
            this.labelBox1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Pixel);
            this.labelBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.labelBox1.Location = new System.Drawing.Point(45, 28);
            this.labelBox1.Multiline = true;
            this.labelBox1.Name = "labelBox1";
            this.labelBox1.ReadOnly = true;
            this.labelBox1.Size = new System.Drawing.Size(370, 64);
            this.labelBox1.TabIndex = 9;
            this.labelBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOkClose
            // 
            this.btnOkClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnOkClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.btnOkClose.BorderColor = System.Drawing.Color.Orchid;
            this.btnOkClose.BorderRadius = 10;
            this.btnOkClose.BorderSize = 0;
            this.btnOkClose.FlatAppearance.BorderSize = 0;
            this.btnOkClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btnOkClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkClose.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOkClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnOkClose.Location = new System.Drawing.Point(180, 211);
            this.btnOkClose.Name = "btnOkClose";
            this.btnOkClose.Size = new System.Drawing.Size(102, 48);
            this.btnOkClose.TabIndex = 0;
            this.btnOkClose.Text = "OK";
            this.btnOkClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnOkClose.UseVisualStyleBackColor = false;
            this.btnOkClose.Click += new System.EventHandler(this.btnOkClose_Click);
            // 
            // ClockAlertMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 280);
            this.Controls.Add(this.roundBorderPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClockAlertMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClockAlertMess";
            this.roundBorderPanel1.ResumeLayout(false);
            this.roundBorderPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public ClassControls.RJButton btnOkClose;
        public System.Windows.Forms.TextBox labelBox1;
        public System.Windows.Forms.TextBox labelBox2;
        public ClassControls.RoundBorderPanel roundBorderPanel1;
    }
}