namespace LibraryItems
{
    partial class BookForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookCRBox = new System.Windows.Forms.TextBox();
            this.bookCancelButton = new System.Windows.Forms.Button();
            this.bookAcceptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitleBox = new System.Windows.Forms.TextBox();
            this.bookPubBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bookLoanPBox = new System.Windows.Forms.TextBox();
            this.bookCNBox = new System.Windows.Forms.TextBox();
            this.bookAuthorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Enter Author Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Enter Call Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Enter Loan Period:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Enter Copyright Year:";
            // 
            // bookCRBox
            // 
            this.bookCRBox.Location = new System.Drawing.Point(41, 160);
            this.bookCRBox.Name = "bookCRBox";
            this.bookCRBox.Size = new System.Drawing.Size(419, 26);
            this.bookCRBox.TabIndex = 47;
            this.bookCRBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookCRBox_Validating);
            this.bookCRBox.Validated += new System.EventHandler(this.bookCRBox_Validated);
            // 
            // bookCancelButton
            // 
            this.bookCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bookCancelButton.Location = new System.Drawing.Point(272, 376);
            this.bookCancelButton.Name = "bookCancelButton";
            this.bookCancelButton.Size = new System.Drawing.Size(208, 72);
            this.bookCancelButton.TabIndex = 55;
            this.bookCancelButton.Text = "Cancel";
            this.bookCancelButton.UseVisualStyleBackColor = true;
            this.bookCancelButton.Click += new System.EventHandler(this.bookCancelButton_Click);
            // 
            // bookAcceptButton
            // 
            this.bookAcceptButton.Location = new System.Drawing.Point(20, 376);
            this.bookAcceptButton.Name = "bookAcceptButton";
            this.bookAcceptButton.Size = new System.Drawing.Size(208, 72);
            this.bookAcceptButton.TabIndex = 54;
            this.bookAcceptButton.Text = "Accept";
            this.bookAcceptButton.UseVisualStyleBackColor = true;
            this.bookAcceptButton.Click += new System.EventHandler(this.bookAcceptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Enter Publisher Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Enter Book Name:";
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(41, 40);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(419, 26);
            this.bookTitleBox.TabIndex = 41;
            this.bookTitleBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookTitleBox_Validating);
            this.bookTitleBox.Validated += new System.EventHandler(this.bookTitleBox_Validated);
            // 
            // bookPubBox
            // 
            this.bookPubBox.Location = new System.Drawing.Point(41, 100);
            this.bookPubBox.Name = "bookPubBox";
            this.bookPubBox.Size = new System.Drawing.Size(419, 26);
            this.bookPubBox.TabIndex = 42;
            this.bookPubBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookPubBox_Validating);
            this.bookPubBox.Validated += new System.EventHandler(this.bookPubBox_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bookLoanPBox
            // 
            this.bookLoanPBox.Location = new System.Drawing.Point(42, 215);
            this.bookLoanPBox.Name = "bookLoanPBox";
            this.bookLoanPBox.Size = new System.Drawing.Size(419, 26);
            this.bookLoanPBox.TabIndex = 51;
            this.bookLoanPBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookLoanPBox_Validating);
            this.bookLoanPBox.Validated += new System.EventHandler(this.bookLoanPBox_Validated);
            // 
            // bookCNBox
            // 
            this.bookCNBox.Location = new System.Drawing.Point(41, 273);
            this.bookCNBox.Name = "bookCNBox";
            this.bookCNBox.Size = new System.Drawing.Size(419, 26);
            this.bookCNBox.TabIndex = 52;
            this.bookCNBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookCNBox_Validating);
            this.bookCNBox.Validated += new System.EventHandler(this.bookCNBox_Validated);
            // 
            // bookAuthorBox
            // 
            this.bookAuthorBox.Location = new System.Drawing.Point(41, 331);
            this.bookAuthorBox.Name = "bookAuthorBox";
            this.bookAuthorBox.Size = new System.Drawing.Size(419, 26);
            this.bookAuthorBox.TabIndex = 53;
            this.bookAuthorBox.Validating += new System.ComponentModel.CancelEventHandler(this.bookAuthorBox_Validating);
            this.bookAuthorBox.Validated += new System.EventHandler(this.bookAuthorBox_Validated);
            // 
            // BookForm
            // 
            this.AcceptButton = this.bookAcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 470);
            this.Controls.Add(this.bookAuthorBox);
            this.Controls.Add(this.bookCNBox);
            this.Controls.Add(this.bookLoanPBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookCRBox);
            this.Controls.Add(this.bookCancelButton);
            this.Controls.Add(this.bookAcceptButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookTitleBox);
            this.Controls.Add(this.bookPubBox);
            this.Name = "BookForm";
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bookCRBox;
        private System.Windows.Forms.Button bookCancelButton;
        private System.Windows.Forms.Button bookAcceptButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitleBox;
        private System.Windows.Forms.TextBox bookPubBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox bookLoanPBox;
        private System.Windows.Forms.TextBox bookCNBox;
        private System.Windows.Forms.TextBox bookAuthorBox;
    }
}