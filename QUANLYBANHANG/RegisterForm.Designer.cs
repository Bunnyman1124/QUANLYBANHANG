namespace QUANLYBANHANG
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.signupShowPassword = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tb_cpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btcancel = new System.Windows.Forms.Button();
            this.lbsignup = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 43);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("close.BackgroundImage")));
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(890, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(55, 43);
            this.close.TabIndex = 1;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.signupShowPassword);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btcancel);
            this.panel3.Controls.Add(this.lbsignup);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btlogin);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(203, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 649);
            this.panel3.TabIndex = 4;
            // 
            // signupShowPassword
            // 
            this.signupShowPassword.AutoSize = true;
            this.signupShowPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupShowPassword.ForeColor = System.Drawing.Color.Black;
            this.signupShowPassword.Location = new System.Drawing.Point(323, 444);
            this.signupShowPassword.Name = "signupShowPassword";
            this.signupShowPassword.Size = new System.Drawing.Size(120, 20);
            this.signupShowPassword.TabIndex = 18;
            this.signupShowPassword.Text = "Show Password";
            this.signupShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupShowPassword.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.tb_cpassword);
            this.panel5.Location = new System.Drawing.Point(117, 363);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(326, 58);
            this.panel5.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(50, 52);
            this.panel8.TabIndex = 6;
            // 
            // tb_cpassword
            // 
            this.tb_cpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cpassword.Location = new System.Drawing.Point(56, 12);
            this.tb_cpassword.Name = "tb_cpassword";
            this.tb_cpassword.Size = new System.Drawing.Size(264, 34);
            this.tb_cpassword.TabIndex = 4;
            this.tb_cpassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btcancel
            // 
            this.btcancel.BackColor = System.Drawing.Color.White;
            this.btcancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.ForeColor = System.Drawing.Color.Black;
            this.btcancel.Location = new System.Drawing.Point(117, 556);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(326, 49);
            this.btcancel.TabIndex = 15;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = false;
            // 
            // lbsignup
            // 
            this.lbsignup.AutoSize = true;
            this.lbsignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsignup.ForeColor = System.Drawing.Color.Black;
            this.lbsignup.Location = new System.Drawing.Point(210, 145);
            this.lbsignup.Name = "lbsignup";
            this.lbsignup.Size = new System.Drawing.Size(153, 28);
            this.lbsignup.TabIndex = 14;
            this.lbsignup.Text = "Admin Sign Up";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.tbpassword);
            this.panel6.Location = new System.Drawing.Point(117, 290);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(326, 58);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 52);
            this.panel7.TabIndex = 6;
            // 
            // tbpassword
            // 
            this.tbpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(56, 12);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(264, 34);
            this.tbpassword.TabIndex = 4;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tbusername);
            this.panel2.Location = new System.Drawing.Point(117, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 58);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(53, 52);
            this.panel4.TabIndex = 6;
            // 
            // tbusername
            // 
            this.tbusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.Location = new System.Drawing.Point(59, 12);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(261, 34);
            this.tbusername.TabIndex = 3;
            // 
            // btlogin
            // 
            this.btlogin.BackColor = System.Drawing.Color.Blue;
            this.btlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.ForeColor = System.Drawing.Color.Black;
            this.btlogin.Location = new System.Drawing.Point(117, 483);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(326, 49);
            this.btlogin.TabIndex = 5;
            this.btlogin.Text = "Sign in";
            this.btlogin.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(945, 774);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tb_cpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Label lbsignup;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.CheckBox signupShowPassword;
    }
}