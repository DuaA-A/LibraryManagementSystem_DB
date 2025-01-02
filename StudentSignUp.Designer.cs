namespace LibraryManagementSystem
{
    partial class StudentSignUp
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
            this.L_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.s_country = new System.Windows.Forms.TextBox();
            this.S_ID = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.A_dashboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.S_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.libraryDataSet1 = new LibraryManagementSystem.libraryDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.S_city = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.Label();
            this.S_SSN = new System.Windows.Forms.TextBox();
            this.P_NO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.lloginID = new System.Windows.Forms.Label();
            this.loginId = new System.Windows.Forms.TextBox();
            this.loginPass = new System.Windows.Forms.Label();
            this.LGpass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            this.L_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.Location = new System.Drawing.Point(200, 83);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(119, 26);
            this.L_Name.TabIndex = 28;
            this.L_Name.TextChanged += new System.EventHandler(this.L_Name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Last Name:  ";
            // 
            // s_country
            // 
            this.s_country.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_country.Location = new System.Drawing.Point(200, 213);
            this.s_country.Name = "s_country";
            this.s_country.Size = new System.Drawing.Size(119, 26);
            this.s_country.TabIndex = 26;
            this.s_country.TextChanged += new System.EventHandler(this.s_country_TextChanged);
            // 
            // S_ID
            // 
            this.S_ID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_ID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.S_ID.Location = new System.Drawing.Point(200, 147);
            this.S_ID.Name = "S_ID";
            this.S_ID.Size = new System.Drawing.Size(119, 26);
            this.S_ID.TabIndex = 25;
            this.S_ID.Click += new System.EventHandler(this.S_ID_Click);
            this.S_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.S_ID_MouseClick);
            this.S_ID.TextChanged += new System.EventHandler(this.S_SSN_TextChanged);
            this.S_ID.Leave += new System.EventHandler(this.S_ID_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(200, 341);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(119, 26);
            this.password.TabIndex = 24;
            this.password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_MouseClick);
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // F_Name
            // 
            this.F_Name.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Name.Location = new System.Drawing.Point(200, 52);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(119, 26);
            this.F_Name.TabIndex = 23;
            this.F_Name.TextChanged += new System.EventHandler(this.F_Name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(16, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(17, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password: *";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ID.Location = new System.Drawing.Point(17, 147);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(50, 22);
            this.ID.TabIndex = 20;
            this.ID.Text = "ID: * ";
            this.ID.Click += new System.EventHandler(this.label1_Click);
            // 
            // A_dashboard
            // 
            this.A_dashboard.BackColor = System.Drawing.Color.White;
            this.A_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.A_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.A_dashboard.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_dashboard.ForeColor = System.Drawing.Color.SaddleBrown;
            this.A_dashboard.Location = new System.Drawing.Point(200, 405);
            this.A_dashboard.Name = "A_dashboard";
            this.A_dashboard.Size = new System.Drawing.Size(119, 31);
            this.A_dashboard.TabIndex = 19;
            this.A_dashboard.Text = "Sign UP";
            this.A_dashboard.UseVisualStyleBackColor = false;
            this.A_dashboard.Click += new System.EventHandler(this.A_dashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "First Name: *";
            // 
            // S_Email
            // 
            this.S_Email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Email.Location = new System.Drawing.Point(200, 277);
            this.S_Email.Name = "S_Email";
            this.S_Email.Size = new System.Drawing.Size(119, 26);
            this.S_Email.TabIndex = 30;
            this.S_Email.TextChanged += new System.EventHandler(this.S_Email_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(16, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Country: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(17, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "Birth Date: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "libraryDataSet";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(16, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 22);
            this.label9.TabIndex = 38;
            this.label9.Text = "City: ";
            // 
            // S_city
            // 
            this.S_city.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_city.Location = new System.Drawing.Point(200, 245);
            this.S_city.Name = "S_city";
            this.S_city.Size = new System.Drawing.Size(119, 26);
            this.S_city.TabIndex = 37;
            this.S_city.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 34);
            this.label10.TabIndex = 39;
            this.label10.Text = "Get Started: ";
            // 
            // SSN
            // 
            this.SSN.AutoSize = true;
            this.SSN.BackColor = System.Drawing.Color.Transparent;
            this.SSN.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SSN.Location = new System.Drawing.Point(16, 179);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(56, 22);
            this.SSN.TabIndex = 40;
            this.SSN.Text = "SSN:  ";
            // 
            // S_SSN
            // 
            this.S_SSN.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_SSN.Location = new System.Drawing.Point(200, 179);
            this.S_SSN.Name = "S_SSN";
            this.S_SSN.Size = new System.Drawing.Size(119, 26);
            this.S_SSN.TabIndex = 41;
            // 
            // P_NO
            // 
            this.P_NO.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_NO.Location = new System.Drawing.Point(200, 309);
            this.P_NO.Name = "P_NO";
            this.P_NO.Size = new System.Drawing.Size(119, 26);
            this.P_NO.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(17, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Phone Number: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(208, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Like:A@1111";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 45;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label11.Location = new System.Drawing.Point(208, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "MM-DD-YYYY";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(71, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 17);
            this.label12.TabIndex = 47;
            this.label12.Text = "Have an account ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.SaddleBrown;
            this.login.Location = new System.Drawing.Point(200, 405);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 31);
            this.login.TabIndex = 48;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Visible = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // lloginID
            // 
            this.lloginID.AutoSize = true;
            this.lloginID.BackColor = System.Drawing.Color.Transparent;
            this.lloginID.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lloginID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lloginID.Location = new System.Drawing.Point(17, 172);
            this.lloginID.Name = "lloginID";
            this.lloginID.Size = new System.Drawing.Size(64, 28);
            this.lloginID.TabIndex = 49;
            this.lloginID.Text = "ID: * ";
            this.lloginID.Visible = false;
            // 
            // loginId
            // 
            this.loginId.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginId.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginId.Location = new System.Drawing.Point(160, 172);
            this.loginId.Name = "loginId";
            this.loginId.Size = new System.Drawing.Size(159, 26);
            this.loginId.TabIndex = 50;
            this.loginId.Visible = false;
            // 
            // loginPass
            // 
            this.loginPass.AutoSize = true;
            this.loginPass.BackColor = System.Drawing.Color.Transparent;
            this.loginPass.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.loginPass.Location = new System.Drawing.Point(15, 235);
            this.loginPass.Name = "loginPass";
            this.loginPass.Size = new System.Drawing.Size(110, 22);
            this.loginPass.TabIndex = 51;
            this.loginPass.Text = "Password: *";
            this.loginPass.Visible = false;
            // 
            // LGpass
            // 
            this.LGpass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGpass.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LGpass.Location = new System.Drawing.Point(160, 231);
            this.LGpass.Name = "LGpass";
            this.LGpass.PasswordChar = '*';
            this.LGpass.Size = new System.Drawing.Size(159, 26);
            this.LGpass.TabIndex = 52;
            this.LGpass.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(217, 373);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // StudentSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(342, 444);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LGpass);
            this.Controls.Add(this.loginPass);
            this.Controls.Add(this.loginId);
            this.Controls.Add(this.lloginID);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_NO);
            this.Controls.Add(this.S_SSN);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.S_city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.S_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_country);
            this.Controls.Add(this.S_ID);
            this.Controls.Add(this.password);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.A_dashboard);
            this.Controls.Add(this.label3);
            this.Name = "StudentSignUp";
            this.Text = "StudentSignUp";
            this.Load += new System.EventHandler(this.StudentSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox L_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox s_country;
        private System.Windows.Forms.TextBox S_ID;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button A_dashboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox S_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private libraryDataSet libraryDataSet1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox S_city;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label SSN;
        private System.Windows.Forms.TextBox S_SSN;
        private System.Windows.Forms.TextBox P_NO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label lloginID;
        private System.Windows.Forms.TextBox loginId;
        private System.Windows.Forms.Label loginPass;
        private System.Windows.Forms.TextBox LGpass;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}