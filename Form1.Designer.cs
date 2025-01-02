namespace LibraryManagementSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminSignUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(191, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to our ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(125, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System";
            // 
            // AdminSignUp
            // 
            this.AdminSignUp.BackColor = System.Drawing.Color.White;
            this.AdminSignUp.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.AdminSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminSignUp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AdminSignUp.Location = new System.Drawing.Point(199, 152);
            this.AdminSignUp.Name = "AdminSignUp";
            this.AdminSignUp.Size = new System.Drawing.Size(80, 31);
            this.AdminSignUp.TabIndex = 3;
            this.AdminSignUp.Text = "Admin";
            this.AdminSignUp.UseVisualStyleBackColor = false;
            this.AdminSignUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(263, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign Up:";
            // 
            // StudentSignUp
            // 
            this.StudentSignUp.BackColor = System.Drawing.Color.DimGray;
            this.StudentSignUp.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.StudentSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentSignUp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentSignUp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.StudentSignUp.Location = new System.Drawing.Point(331, 152);
            this.StudentSignUp.Name = "StudentSignUp";
            this.StudentSignUp.Size = new System.Drawing.Size(86, 31);
            this.StudentSignUp.TabIndex = 5;
            this.StudentSignUp.Text = "Student";
            this.StudentSignUp.UseVisualStyleBackColor = false;
            this.StudentSignUp.Click += new System.EventHandler(this.StudentDashboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(640, 359);
            this.Controls.Add(this.StudentSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminSignUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AdminSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StudentSignUp;
    }
}

