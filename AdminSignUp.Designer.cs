namespace LibraryManagementSystem
{
    partial class AdminSignUp
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
            this.A_dashboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.Password_TXB = new System.Windows.Forms.TextBox();
            this.email_TXB = new System.Windows.Forms.TextBox();
            this.Phone_TXB = new System.Windows.Forms.TextBox();
            this.Lname_TXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.A_ID = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.LGpass = new System.Windows.Forms.TextBox();
            this.loginPass = new System.Windows.Forms.Label();
            this.loginId = new System.Windows.Forms.TextBox();
            this.lloginID = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A_dashboard
            // 
            this.A_dashboard.BackColor = System.Drawing.Color.White;
            this.A_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.A_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A_dashboard.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_dashboard.ForeColor = System.Drawing.Color.SaddleBrown;
            this.A_dashboard.Location = new System.Drawing.Point(161, 286);
            this.A_dashboard.Name = "A_dashboard";
            this.A_dashboard.Size = new System.Drawing.Size(119, 31);
            this.A_dashboard.TabIndex = 8;
            this.A_dashboard.Text = "RIGESTER";
            this.A_dashboard.UseVisualStyleBackColor = false;
            this.A_dashboard.Click += new System.EventHandler(this.StudentDashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name: *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phone: *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password: *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.name_textBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(161, 66);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(119, 26);
            this.name_textBox.TabIndex = 12;
            this.name_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_TXB
            // 
            this.Password_TXB.BackColor = System.Drawing.SystemColors.Window;
            this.Password_TXB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TXB.Location = new System.Drawing.Point(161, 232);
            this.Password_TXB.Name = "Password_TXB";
            this.Password_TXB.PasswordChar = '*';
            this.Password_TXB.Size = new System.Drawing.Size(119, 26);
            this.Password_TXB.TabIndex = 13;
            this.Password_TXB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // email_TXB
            // 
            this.email_TXB.BackColor = System.Drawing.SystemColors.Window;
            this.email_TXB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_TXB.Location = new System.Drawing.Point(161, 163);
            this.email_TXB.Name = "email_TXB";
            this.email_TXB.PasswordChar = '*';
            this.email_TXB.Size = new System.Drawing.Size(119, 26);
            this.email_TXB.TabIndex = 14;
            this.email_TXB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Phone_TXB
            // 
            this.Phone_TXB.BackColor = System.Drawing.SystemColors.Window;
            this.Phone_TXB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_TXB.Location = new System.Drawing.Point(161, 197);
            this.Phone_TXB.Name = "Phone_TXB";
            this.Phone_TXB.Size = new System.Drawing.Size(119, 26);
            this.Phone_TXB.TabIndex = 15;
            this.Phone_TXB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Lname_TXB
            // 
            this.Lname_TXB.BackColor = System.Drawing.SystemColors.Window;
            this.Lname_TXB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname_TXB.Location = new System.Drawing.Point(161, 98);
            this.Lname_TXB.Name = "Lname_TXB";
            this.Lname_TXB.Size = new System.Drawing.Size(119, 26);
            this.Lname_TXB.TabIndex = 17;
            this.Lname_TXB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Last Name: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(5, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 34);
            this.label6.TabIndex = 18;
            this.label6.Text = "Get Started: ";
            // 
            // A_ID
            // 
            this.A_ID.AutoSize = true;
            this.A_ID.BackColor = System.Drawing.Color.Transparent;
            this.A_ID.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_ID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.A_ID.Location = new System.Drawing.Point(12, 134);
            this.A_ID.Name = "A_ID";
            this.A_ID.Size = new System.Drawing.Size(46, 22);
            this.A_ID.TabIndex = 19;
            this.A_ID.Text = "ID: *";
            // 
            // ID_textBox
            // 
            this.ID_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.ID_textBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_textBox.Location = new System.Drawing.Point(161, 130);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(119, 26);
            this.ID_textBox.TabIndex = 20;
            // 
            // LGpass
            // 
            this.LGpass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGpass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LGpass.Location = new System.Drawing.Point(126, 162);
            this.LGpass.Name = "LGpass";
            this.LGpass.PasswordChar = '*';
            this.LGpass.Size = new System.Drawing.Size(159, 26);
            this.LGpass.TabIndex = 59;
            this.LGpass.Visible = false;
            // 
            // loginPass
            // 
            this.loginPass.AutoSize = true;
            this.loginPass.BackColor = System.Drawing.Color.Transparent;
            this.loginPass.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginPass.Location = new System.Drawing.Point(7, 167);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(110, 22);
            this.loginPass.TabIndex = 58;
            this.loginPass.Text = "Password: *";
            this.loginPass.Visible = false;
            // 
            // loginId
            // 
            this.loginId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginId.Location = new System.Drawing.Point(126, 115);
            this.loginId.Name = "loginId";
            this.loginId.Size = new System.Drawing.Size(159, 26);
            this.loginId.TabIndex = 57;
            this.loginId.Visible = false;
            // 
            // lloginID
            // 
            this.lloginID.AutoSize = true;
            this.lloginID.BackColor = System.Drawing.Color.Transparent;
            this.lloginID.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lloginID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lloginID.Location = new System.Drawing.Point(11, 115);
            this.lloginID.Name = "lloginID";
            this.lloginID.Size = new System.Drawing.Size(64, 28);
            this.lloginID.TabIndex = 56;
            this.lloginID.Text = "ID: * ";
            this.lloginID.Visible = false;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.SaddleBrown;
            this.login.Location = new System.Drawing.Point(161, 284);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 31);
            this.login.TabIndex = 55;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Visible = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(32, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Have an account ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // AdminSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 332);
            this.Controls.Add(this.LGpass);
            this.Controls.Add(this.loginPass);
            this.Controls.Add(this.loginId);
            this.Controls.Add(this.lloginID);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.A_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Lname_TXB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone_TXB);
            this.Controls.Add(this.email_TXB);
            this.Controls.Add(this.Password_TXB);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A_dashboard);
            this.Controls.Add(this.label3);
            this.Name = "AdminSignUp";
            this.Text = "AdminSignUp";
            this.Load += new System.EventHandler(this.AdminSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A_dashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox Password_TXB;
        private System.Windows.Forms.TextBox email_TXB;
        private System.Windows.Forms.TextBox Phone_TXB;
        private System.Windows.Forms.TextBox Lname_TXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label A_ID;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.TextBox LGpass;
        private System.Windows.Forms.Label loginPass;
        private System.Windows.Forms.TextBox loginId;
        private System.Windows.Forms.Label lloginID;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label12;
    }
}