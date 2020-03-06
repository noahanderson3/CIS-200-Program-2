// Program 2
// CIS 200-01
// Due: 3/10/2018
// By: z8360

// File: BookForm.cs
// this creates a form to be used for adding new book. it returns the valid parameters for a book
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class BookForm : Form
    {
        public string ReturnTitle { get; set; } // properties used to make book title public
        public string ReturnPublisher { get; set; } // properties used to make book publisher public
        public int ReturnCR { get; set; }  // properties used to make book copyright year public
        public int ReturnLP { get; set; }  // properties used to make book loan period public
        public string  ReturnCN{ get; set; } // properties used to make book call numbner public
        public string ReturnAuthor { get; set; } // properties used to make book author public


        public BookForm()
        {
            InitializeComponent();
        }

        // precon: everything has gone through validation
        // postcon: info regarding new book is set to public classes
        private void bookAcceptButton_Click(object sender, EventArgs e)// accept button accidently left named pat
        {
            if (ValidateChildren(ValidationConstraints.Enabled)) // if everything is validated
            {
                
                
                //sets values to publis properties
                this.ReturnTitle = bookTitleBox.Text;
                this.ReturnPublisher = bookPubBox.Text;
                this.ReturnCR = int.Parse(bookCRBox.Text);
                this.ReturnLP = int.Parse(bookLoanPBox.Text);
                this.ReturnCN = bookCNBox.Text;
                this.ReturnAuthor = bookAuthorBox.Text;

                this.DialogResult = DialogResult.OK; // sets the dialoge result to OK
                this.Close(); // closes checkout form

            }
            
        }

        // Precondition: book title has gopne through validation
        // Postcondition: book title is no longer not validated
        private void bookTitleBox_Validated(object sender, EventArgs e) // book title validated
        {
            errorProvider1.SetError(bookTitleBox, null);
        }

        // Precondition:  booktitlebox has been selected
        // Postcondition: book title is not null or white space
        private void bookTitleBox_Validating(object sender, CancelEventArgs e) // book title validating
        {
            if (string.IsNullOrWhiteSpace(bookTitleBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                bookTitleBox.Focus();
                errorProvider1.SetError(bookTitleBox, "Title is required");
            }
        }

        // Precondition:  bookpubbox is selected
        // Postcondition: book publisher is not null or white space
        private void bookPubBox_Validating(object sender, CancelEventArgs e) // boot publisher validating
        {
            if (string.IsNullOrWhiteSpace(bookPubBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                bookPubBox.Focus();
                errorProvider1.SetError(bookPubBox, "Publisher is required");
            }
        }

        // Precondition: book title has gone through validation
        // Postcondition: book title is no longer not validated
        private void bookPubBox_Validated(object sender, EventArgs e) // book publisher validated
        {
            errorProvider1.SetError(bookPubBox, null);
        }

        // Precondition:  bookcrbox is selected
        // Postcondition: copyright year is not null or white space or negative or not an integer
        private void bookCRBox_Validating(object sender, CancelEventArgs e) // book copyrighit year validating
        {
            int number; // used in try parse
            if (string.IsNullOrWhiteSpace(bookCRBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                bookCRBox.Focus();
                errorProvider1.SetError(bookCRBox, "Copyright Year is required");
            }
            else if (!int.TryParse(bookCRBox.Text, out number)) // cannot be a non- integer
            {
                e.Cancel = true;
                bookCRBox.Focus();
                errorProvider1.SetError(bookCRBox, "Copyright Year must be an integer");
            }
            else if (number < 0) // cannot be negative
            {
                e.Cancel = true;
                bookCRBox.Focus();
                errorProvider1.SetError(bookCRBox, "Copyright Year must be a positive number");
            }    
        }
        // Precondition: book copyright year has gone though validation
        // Postcondition: book copyright year is no longer not validated
        private void bookCRBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(bookCRBox, null);
        }

        // Precondition:  bookcrbox is selected
        // Postcondition: copyright year is not null or white space or negative or not an integer
        private void bookLoanPBox_Validating(object sender, CancelEventArgs e) // loan period validating
        {
            int number; // used in try parse
            if (string.IsNullOrWhiteSpace(bookLoanPBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                bookLoanPBox.Focus();
                errorProvider1.SetError(bookLoanPBox, "Loan period is required");
            }
            else if (!int.TryParse(bookLoanPBox.Text, out number)) // cannot be a non- integer
            {
                e.Cancel = true;
                bookLoanPBox.Focus();
                errorProvider1.SetError(bookLoanPBox, "Loan Period must be an integer");
            }
            else if (number < 0) // cannot be negative
            {
                e.Cancel = true;
                bookLoanPBox.Focus();
                errorProvider1.SetError(bookLoanPBox, "Loan Period must be a positive number");
            }
        }

        // Precondition: Loan period has gone though validation
        // Postcondition: book loan period is no longer not validated
        private void bookLoanPBox_Validated(object sender, EventArgs e) // loan period validated
        {
            errorProvider1.SetError(bookLoanPBox, null); 
        }

        // Precondition:  bookpubbox is selected
        // Postcondition: book publisher is not null or white space
        private void bookCNBox_Validating(object sender, CancelEventArgs e) // call number validation
        {
            if (string.IsNullOrWhiteSpace(bookCNBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                bookCNBox.Focus();
                errorProvider1.SetError(bookCNBox, "Call Number is required");
            }
        }

        // Precondition: call number has gone though validation
        // Postcondition:callnumber is no longer not validated
        private void bookCNBox_Validated(object sender, EventArgs e) // call number validated
        {
            errorProvider1.SetError(bookCNBox, null);
        }

        // Precondition:  book author box is selected
        // Postcondition: book author is not null or white space
        private void bookAuthorBox_Validating(object sender, CancelEventArgs e) // author validating
        {
            if (string.IsNullOrWhiteSpace(bookAuthorBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
               bookAuthorBox.Focus();
                errorProvider1.SetError(bookAuthorBox, "Author is required");
            }
        }

        // Precondition: author box has gone though validation
        // Postcondition: author is no longer not validated
        private void bookAuthorBox_Validated(object sender, EventArgs e) // author validated
        {
            errorProvider1.SetError(bookAuthorBox, null);
        }

        //pre: form is open
        //post: form closes, nopthing is sent
        private void bookCancelButton_Click(object sender, EventArgs e) // cancel button
        {
            this.Close();
        }
    }
}
