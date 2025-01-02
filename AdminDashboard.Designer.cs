namespace LibraryManagementSystem
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewBook = new System.Windows.Forms.Button();
            this.updateBook = new System.Windows.Forms.Button();
            this.addBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.B_Title = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B_publication_y = new System.Windows.Forms.Label();
            this.B_edition = new System.Windows.Forms.Label();
            this.title_addBook = new System.Windows.Forms.Label();
            this.B_category = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.viewBooks = new System.Windows.Forms.Label();
            this.BookIDForView = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gobackbutton = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.B_ID = new System.Windows.Forms.Label();
            this.BookID_textBox = new System.Windows.Forms.TextBox();
            this.B_ISBN = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.DeleteBook = new System.Windows.Forms.Button();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.searchForBook = new System.Windows.Forms.Button();
            this.searchBookBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(176, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(98, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 34);
            this.label3.TabIndex = 17;
            this.label3.Text = "Library Management System";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(169, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Welcome to our ";
            // 
            // viewBook
            // 
            this.viewBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.viewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.viewBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.viewBook.Location = new System.Drawing.Point(12, 278);
            this.viewBook.Name = "viewBook";
            this.viewBook.Size = new System.Drawing.Size(152, 38);
            this.viewBook.TabIndex = 13;
            this.viewBook.Text = "View Books";
            this.viewBook.UseVisualStyleBackColor = false;
            this.viewBook.Click += new System.EventHandler(this.viewBook_Click);
            // 
            // updateBook
            // 
            this.updateBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.updateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.updateBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updateBook.Location = new System.Drawing.Point(11, 143);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(152, 40);
            this.updateBook.TabIndex = 14;
            this.updateBook.Text = "Update Book";
            this.updateBook.UseVisualStyleBackColor = false;
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // addBook
            // 
            this.addBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.addBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.addBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addBook.Location = new System.Drawing.Point(11, 99);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(152, 38);
            this.addBook.TabIndex = 15;
            this.addBook.Text = "Add Book";
            this.addBook.UseVisualStyleBackColor = false;
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(275, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(428, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 26);
            this.textBox5.TabIndex = 29;
            this.textBox5.Visible = false;
            // 
            // B_Title
            // 
            this.B_Title.AutoSize = true;
            this.B_Title.BackColor = System.Drawing.Color.Transparent;
            this.B_Title.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Title.ForeColor = System.Drawing.Color.SaddleBrown;
            this.B_Title.Location = new System.Drawing.Point(203, 156);
            this.B_Title.Name = "B_Title";
            this.B_Title.Size = new System.Drawing.Size(115, 22);
            this.B_Title.TabIndex = 28;
            this.B_Title.Text = "book Title: * ";
            this.B_Title.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(428, 253);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(119, 26);
            this.textBox4.TabIndex = 27;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(428, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 26);
            this.textBox3.TabIndex = 26;
            this.textBox3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(428, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 26);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // B_publication_y
            // 
            this.B_publication_y.AutoSize = true;
            this.B_publication_y.BackColor = System.Drawing.Color.Transparent;
            this.B_publication_y.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_publication_y.ForeColor = System.Drawing.Color.SaddleBrown;
            this.B_publication_y.Location = new System.Drawing.Point(203, 188);
            this.B_publication_y.Name = "B_publication_y";
            this.B_publication_y.Size = new System.Drawing.Size(157, 22);
            this.B_publication_y.TabIndex = 23;
            this.B_publication_y.Text = "Publication year:";
            this.B_publication_y.Visible = false;
            // 
            // B_edition
            // 
            this.B_edition.AutoSize = true;
            this.B_edition.BackColor = System.Drawing.Color.Transparent;
            this.B_edition.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_edition.ForeColor = System.Drawing.Color.SaddleBrown;
            this.B_edition.Location = new System.Drawing.Point(207, 257);
            this.B_edition.Name = "B_edition";
            this.B_edition.Size = new System.Drawing.Size(92, 22);
            this.B_edition.TabIndex = 21;
            this.B_edition.Text = "Eddition: ";
            this.B_edition.Visible = false;
            // 
            // title_addBook
            // 
            this.title_addBook.AutoSize = true;
            this.title_addBook.BackColor = System.Drawing.Color.Transparent;
            this.title_addBook.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_addBook.ForeColor = System.Drawing.Color.SaddleBrown;
            this.title_addBook.Location = new System.Drawing.Point(11, 101);
            this.title_addBook.Name = "title_addBook";
            this.title_addBook.Size = new System.Drawing.Size(114, 28);
            this.title_addBook.TabIndex = 30;
            this.title_addBook.Text = "Add Book";
            this.title_addBook.Visible = false;
            // 
            // B_category
            // 
            this.B_category.AutoSize = true;
            this.B_category.BackColor = System.Drawing.Color.Transparent;
            this.B_category.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_category.ForeColor = System.Drawing.Color.SaddleBrown;
            this.B_category.Location = new System.Drawing.Point(203, 224);
            this.B_category.Name = "B_category";
            this.B_category.Size = new System.Drawing.Size(96, 22);
            this.B_category.TabIndex = 31;
            this.B_category.Text = "Category: ";
            this.B_category.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(428, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 26);
            this.textBox2.TabIndex = 32;
            this.textBox2.Visible = false;
            // 
            // viewBooks
            // 
            this.viewBooks.AutoSize = true;
            this.viewBooks.BackColor = System.Drawing.Color.Transparent;
            this.viewBooks.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooks.ForeColor = System.Drawing.Color.SaddleBrown;
            this.viewBooks.Location = new System.Drawing.Point(11, 101);
            this.viewBooks.Name = "viewBooks";
            this.viewBooks.Size = new System.Drawing.Size(134, 28);
            this.viewBooks.TabIndex = 36;
            this.viewBooks.Text = "View Books";
            this.viewBooks.Visible = false;
            // 
            // BookIDForView
            // 
            this.BookIDForView.AutoSize = true;
            this.BookIDForView.BackColor = System.Drawing.Color.Transparent;
            this.BookIDForView.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDForView.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BookIDForView.Location = new System.Drawing.Point(11, 143);
            this.BookIDForView.Name = "BookIDForView";
            this.BookIDForView.Size = new System.Drawing.Size(102, 22);
            this.BookIDForView.TabIndex = 39;
            this.BookIDForView.Text = "Book ISBN:";
            this.BookIDForView.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(11, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Update Book";
            this.label2.Visible = false;
            // 
            // Gobackbutton
            // 
            this.Gobackbutton.BackColor = System.Drawing.Color.SaddleBrown;
            this.Gobackbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gobackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Gobackbutton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.Gobackbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Gobackbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Gobackbutton.Location = new System.Drawing.Point(11, 322);
            this.Gobackbutton.Name = "Gobackbutton";
            this.Gobackbutton.Size = new System.Drawing.Size(153, 38);
            this.Gobackbutton.TabIndex = 37;
            this.Gobackbutton.Text = "GO Back";
            this.Gobackbutton.UseVisualStyleBackColor = false;
            this.Gobackbutton.Visible = false;
            this.Gobackbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DimGray;
            this.add.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.SaddleBrown;
            this.add.Location = new System.Drawing.Point(428, 319);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 31);
            this.add.TabIndex = 41;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Visible = false;
            this.add.Click += new System.EventHandler(this.add_Click_1);
            // 
            // ID_textBox
            // 
            this.ID_textBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_textBox.Location = new System.Drawing.Point(428, 285);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(119, 26);
            this.ID_textBox.TabIndex = 33;
            this.ID_textBox.Visible = false;
            // 
            // B_ID
            // 
            this.B_ID.AutoSize = true;
            this.B_ID.BackColor = System.Drawing.Color.Transparent;
            this.B_ID.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.B_ID.Location = new System.Drawing.Point(203, 289);
            this.B_ID.Name = "B_ID";
            this.B_ID.Size = new System.Drawing.Size(136, 22);
            this.B_ID.TabIndex = 34;
            this.B_ID.Text = "Publisher ID:  *";
            this.B_ID.Visible = false;
            this.B_ID.Click += new System.EventHandler(this.B_ID_Click);
            // 
            // BookID_textBox
            // 
            this.BookID_textBox.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookID_textBox.Location = new System.Drawing.Point(11, 168);
            this.BookID_textBox.Name = "BookID_textBox";
            this.BookID_textBox.Size = new System.Drawing.Size(119, 26);
            this.BookID_textBox.TabIndex = 38;
            this.BookID_textBox.Visible = false;
            this.BookID_textBox.TextChanged += new System.EventHandler(this.BookID_textBox_TextChanged);
            // 
            // B_ISBN
            // 
            this.B_ISBN.AutoSize = true;
            this.B_ISBN.BackColor = System.Drawing.Color.Transparent;
            this.B_ISBN.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_ISBN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.B_ISBN.Location = new System.Drawing.Point(203, 124);
            this.B_ISBN.Name = "B_ISBN";
            this.B_ISBN.Size = new System.Drawing.Size(72, 22);
            this.B_ISBN.TabIndex = 19;
            this.B_ISBN.Text = "ISBN:  *";
            this.B_ISBN.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(428, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 31);
            this.button2.TabIndex = 42;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(176, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 262);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DimGray;
            this.delete.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.SaddleBrown;
            this.delete.Location = new System.Drawing.Point(12, 196);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 31);
            this.delete.TabIndex = 44;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Visible = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // DeleteBook
            // 
            this.DeleteBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.DeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteBook.Location = new System.Drawing.Point(11, 231);
            this.DeleteBook.Name = "DeleteBook";
            this.DeleteBook.Size = new System.Drawing.Size(152, 40);
            this.DeleteBook.TabIndex = 45;
            this.DeleteBook.Text = "Delete Book";
            this.DeleteBook.UseVisualStyleBackColor = false;
            this.DeleteBook.Click += new System.EventHandler(this.DeleteBook_Click);
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.Transparent;
            this.deleteLabel.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.deleteLabel.Location = new System.Drawing.Point(11, 101);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(139, 28);
            this.deleteLabel.TabIndex = 46;
            this.deleteLabel.Text = "Delete Book";
            this.deleteLabel.Visible = false;
            // 
            // searchForBook
            // 
            this.searchForBook.BackColor = System.Drawing.Color.SaddleBrown;
            this.searchForBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchForBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchForBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.searchForBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchForBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchForBook.Location = new System.Drawing.Point(10, 189);
            this.searchForBook.Name = "searchForBook";
            this.searchForBook.Size = new System.Drawing.Size(153, 38);
            this.searchForBook.TabIndex = 47;
            this.searchForBook.Text = "Search Book";
            this.searchForBook.UseVisualStyleBackColor = false;
            this.searchForBook.Click += new System.EventHandler(this.searchForBook_Click);
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.BackColor = System.Drawing.Color.DimGray;
            this.searchBookBtn.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.LIB_;
            this.searchBookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBookBtn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBookBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.searchBookBtn.Location = new System.Drawing.Point(10, 196);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(119, 31);
            this.searchBookBtn.TabIndex = 48;
            this.searchBookBtn.Text = "Search";
            this.searchBookBtn.UseVisualStyleBackColor = false;
            this.searchBookBtn.Visible = false;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(605, 380);
            this.Controls.Add(this.searchBookBtn);
            this.Controls.Add(this.searchForBook);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.DeleteBook);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookIDForView);
            this.Controls.Add(this.BookID_textBox);
            this.Controls.Add(this.Gobackbutton);
            this.Controls.Add(this.viewBooks);
            this.Controls.Add(this.B_ID);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.B_category);
            this.Controls.Add(this.title_addBook);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.B_Title);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B_publication_y);
            this.Controls.Add(this.B_edition);
            this.Controls.Add(this.B_ISBN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.viewBook);
            this.Controls.Add(this.updateBook);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.label1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewBook;
        private System.Windows.Forms.Button updateBook;
        private System.Windows.Forms.Button addBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label B_Title;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label B_publication_y;
        private System.Windows.Forms.Label B_edition;
        private System.Windows.Forms.Label title_addBook;
        private System.Windows.Forms.Label B_category;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label viewBooks;
        private System.Windows.Forms.Label BookIDForView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Gobackbutton;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label B_ID;
        private System.Windows.Forms.TextBox BookID_textBox;
        private System.Windows.Forms.Label B_ISBN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button DeleteBook;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button searchForBook;
        private System.Windows.Forms.Button searchBookBtn;
    }
}