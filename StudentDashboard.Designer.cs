namespace LibraryManagementSystem
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            this.browsBook = new System.Windows.Forms.Button();
            this.updateDetails = new System.Windows.Forms.Button();
            this.viewBookBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.S_IDforUpdate = new System.Windows.Forms.Label();
            this.S_ID_textBox = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.TextBox();
            this.SSN = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.S_city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.S_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.L_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.s_country = new System.Windows.Forms.TextBox();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.GoBackbtn = new System.Windows.Forms.Button();
            this.Viewbooks = new System.Windows.Forms.DataGridView();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new LibraryManagementSystem.libraryDataSet();
            this.bOOKTableAdapter = new LibraryManagementSystem.libraryDataSetTableAdapters.BOOKTableAdapter();
            this.bORROWTableAdapter = new LibraryManagementSystem.libraryDataSetTableAdapters.BORROWTableAdapter();
            this.tableAdapterManager = new LibraryManagementSystem.libraryDataSetTableAdapters.TableAdapterManager();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.viewBooksLbl = new System.Windows.Forms.Label();
            this.searchStudentBtn = new System.Windows.Forms.Button();
            this.BookISBN_txt = new System.Windows.Forms.TextBox();
            this.BookIDForView = new System.Windows.Forms.Label();
            this.browsBookLbl = new System.Windows.Forms.Label();
            this.SearchFotStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Viewbooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // browsBook
            // 
            this.browsBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.browsBook.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.browsBook, "browsBook");
            this.browsBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.browsBook.Name = "browsBook";
            this.browsBook.UseVisualStyleBackColor = false;
            this.browsBook.Click += new System.EventHandler(this.browsBook_Click);
            // 
            // updateDetails
            // 
            this.updateDetails.BackColor = System.Drawing.Color.SaddleBrown;
            this.updateDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.updateDetails, "updateDetails");
            this.updateDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateDetails.Name = "updateDetails";
            this.updateDetails.UseVisualStyleBackColor = false;
            this.updateDetails.Click += new System.EventHandler(this.updateDetails_Click);
            // 
            // viewBookBtn
            // 
            this.viewBookBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.viewBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.viewBookBtn, "viewBookBtn");
            this.viewBookBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewBookBtn.Name = "viewBookBtn";
            this.viewBookBtn.UseVisualStyleBackColor = false;
            this.viewBookBtn.Click += new System.EventHandler(this.viewBook_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Name = "label2";
            // 
            // S_IDforUpdate
            // 
            resources.ApplyResources(this.S_IDforUpdate, "S_IDforUpdate");
            this.S_IDforUpdate.BackColor = System.Drawing.Color.Transparent;
            this.S_IDforUpdate.ForeColor = System.Drawing.Color.SaddleBrown;
            this.S_IDforUpdate.Name = "S_IDforUpdate";
            // 
            // S_ID_textBox
            // 
            resources.ApplyResources(this.S_ID_textBox, "S_ID_textBox");
            this.S_ID_textBox.Name = "S_ID_textBox";
            this.S_ID_textBox.TextChanged += new System.EventHandler(this.S_ID_textBox_TextChanged);
            this.S_ID_textBox.Leave += new System.EventHandler(this.S_ID_textBox_Leave);
            // 
            // birthDate
            // 
            resources.ApplyResources(this.birthDate, "birthDate");
            this.birthDate.Name = "birthDate";
            // 
            // SSN
            // 
            resources.ApplyResources(this.SSN, "SSN");
            this.SSN.BackColor = System.Drawing.Color.Transparent;
            this.SSN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SSN.Name = "SSN";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Name = "label9";
            // 
            // S_city
            // 
            resources.ApplyResources(this.S_city, "S_city");
            this.S_city.Name = "S_city";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Name = "label7";
            // 
            // S_Email
            // 
            resources.ApplyResources(this.S_Email, "S_Email");
            this.S_Email.Name = "S_Email";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Name = "label6";
            // 
            // L_Name
            // 
            resources.ApplyResources(this.L_Name, "L_Name");
            this.L_Name.Name = "L_Name";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Name = "label5";
            // 
            // s_country
            // 
            resources.ApplyResources(this.s_country, "s_country");
            this.s_country.Name = "s_country";
            // 
            // F_Name
            // 
            resources.ApplyResources(this.F_Name, "F_Name");
            this.F_Name.Name = "F_Name";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Name = "label8";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Name = "label11";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DimGray;
            this.Update.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            resources.ApplyResources(this.Update, "Update");
            this.Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Update.Name = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // GoBackbtn
            // 
            this.GoBackbtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.GoBackbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.GoBackbtn, "GoBackbtn");
            this.GoBackbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GoBackbtn.Name = "GoBackbtn";
            this.GoBackbtn.UseVisualStyleBackColor = false;
            this.GoBackbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Viewbooks
            // 
            this.Viewbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.Viewbooks, "Viewbooks");
            this.Viewbooks.Name = "Viewbooks";
            this.Viewbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Viewbooks_CellContentClick);
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // bORROWTableAdapter
            // 
            this.bORROWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.A_PHONETableAdapter = null;
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.AUTHORTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKTableAdapter = null;
            this.tableAdapterManager.BORROWTableAdapter = this.bORROWTableAdapter;
            this.tableAdapterManager.COPYTableAdapter = null;
            this.tableAdapterManager.MAINTAINTableAdapter = null;
            this.tableAdapterManager.PHONETableAdapter = null;
            this.tableAdapterManager.PUBLISHERTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryManagementSystem.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WRITESTableAdapter = null;
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.BackColor = System.Drawing.Color.DimGray;
            this.searchBookBtn.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            resources.ApplyResources(this.searchBookBtn, "searchBookBtn");
            this.searchBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBookBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.UseVisualStyleBackColor = false;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // viewBooksLbl
            // 
            resources.ApplyResources(this.viewBooksLbl, "viewBooksLbl");
            this.viewBooksLbl.BackColor = System.Drawing.Color.Transparent;
            this.viewBooksLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.viewBooksLbl.Name = "viewBooksLbl";
            // 
            // searchStudentBtn
            // 
            this.searchStudentBtn.BackColor = System.Drawing.Color.DimGray;
            this.searchStudentBtn.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            resources.ApplyResources(this.searchStudentBtn, "searchStudentBtn");
            this.searchStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchStudentBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.searchStudentBtn.Name = "searchStudentBtn";
            this.searchStudentBtn.UseVisualStyleBackColor = false;
            this.searchStudentBtn.Click += new System.EventHandler(this.searchStudentBtn_Click);
            // 
            // BookISBN_txt
            // 
            resources.ApplyResources(this.BookISBN_txt, "BookISBN_txt");
            this.BookISBN_txt.Name = "BookISBN_txt";
            // 
            // BookIDForView
            // 
            resources.ApplyResources(this.BookIDForView, "BookIDForView");
            this.BookIDForView.BackColor = System.Drawing.Color.Transparent;
            this.BookIDForView.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookIDForView.Name = "BookIDForView";
            // 
            // browsBookLbl
            // 
            resources.ApplyResources(this.browsBookLbl, "browsBookLbl");
            this.browsBookLbl.BackColor = System.Drawing.Color.Transparent;
            this.browsBookLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.browsBookLbl.Name = "browsBookLbl";
            // 
            // SearchFotStudent
            // 
            this.SearchFotStudent.BackColor = System.Drawing.Color.SaddleBrown;
            this.SearchFotStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SearchFotStudent, "SearchFotStudent");
            this.SearchFotStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchFotStudent.Name = "SearchFotStudent";
            this.SearchFotStudent.UseVisualStyleBackColor = false;
            this.SearchFotStudent.Click += new System.EventHandler(this.SearchFotStudent_Click);
            // 
            // StudentDashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.SearchFotStudent);
            this.Controls.Add(this.browsBookLbl);
            this.Controls.Add(this.BookIDForView);
            this.Controls.Add(this.BookISBN_txt);
            this.Controls.Add(this.searchStudentBtn);
            this.Controls.Add(this.viewBooksLbl);
            this.Controls.Add(this.searchBookBtn);
            this.Controls.Add(this.Viewbooks);
            this.Controls.Add(this.GoBackbtn);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.S_city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.S_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_country);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.S_IDforUpdate);
            this.Controls.Add(this.S_ID_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewBookBtn);
            this.Controls.Add(this.updateDetails);
            this.Controls.Add(this.browsBook);
            this.Name = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Viewbooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browsBook;
        private System.Windows.Forms.Button updateDetails;
        private System.Windows.Forms.Button viewBookBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label S_IDforUpdate;
        private System.Windows.Forms.TextBox S_ID_textBox;
        private System.Windows.Forms.TextBox birthDate;
        private System.Windows.Forms.Label SSN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox S_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox S_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox L_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox s_country;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button GoBackbtn;
        private System.Windows.Forms.DataGridView Viewbooks;
        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private libraryDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private libraryDataSetTableAdapters.BORROWTableAdapter bORROWTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button searchBookBtn;
        private System.Windows.Forms.Label viewBooksLbl;
        private System.Windows.Forms.Button searchStudentBtn;
        private System.Windows.Forms.TextBox BookISBN_txt;
        private System.Windows.Forms.Label BookIDForView;
        private System.Windows.Forms.Label browsBookLbl;
        private System.Windows.Forms.Button SearchFotStudent;
    }
}