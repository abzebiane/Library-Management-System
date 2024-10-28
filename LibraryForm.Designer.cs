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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ComboBox();
            this.lstMembers = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(4, 357);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(108, 23);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(171, 357);
            this.btnRemoveBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveBook.TabIndex = 1;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(395, 357);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(108, 23);
            this.btnAddMember.TabIndex = 2;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(567, 357);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(108, 23);
            this.btnRemoveMember.TabIndex = 3;
            this.btnRemoveMember.Text = "Remove Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(4, 410);
            this.btnBorrowBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(108, 23);
            this.btnBorrowBook.TabIndex = 4;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(171, 410);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(108, 23);
            this.btnReturnBook.TabIndex = 5;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.AccessibleName = "Books Available";
            this.lstBooks.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.lstBooks.DropDownHeight = 108;
            this.lstBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.IntegralHeight = false;
            this.lstBooks.Items.AddRange(new object[] {
            ""});
            this.lstBooks.Location = new System.Drawing.Point(9, 73);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(354, 21);
            this.lstBooks.TabIndex = 6;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // lstMembers
            // 
            this.lstMembers.DropDownHeight = 108;
            this.lstMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMembers.DropDownWidth = 156;
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.IntegralHeight = false;
            this.lstMembers.ItemHeight = 13;
            this.lstMembers.Location = new System.Drawing.Point(439, 73);
            this.lstMembers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(159, 21);
            this.lstMembers.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(88, 232);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(125, 20);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(88, 314);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(125, 20);
            this.txtISBN.TabIndex = 9;
            this.txtISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(88, 273);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(125, 20);
            this.txtAuthor.TabIndex = 10;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(498, 273);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "List of Available Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "List of Members";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Book Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Book Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Book ISBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Member Full Name:";
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(480, 229);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(94, 23);
            this.btnSummary.TabIndex = 18;
            this.btnSummary.Text = "Borrow Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 35);
            this.label7.TabIndex = 19;
            this.label7.Text = "CAZ LIBRARY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 473);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Library Management System - CAZ LIBRARY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.ComboBox lstBooks;
        private System.Windows.Forms.ComboBox lstMembers;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label label7;
    }
}

