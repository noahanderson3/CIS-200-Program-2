// Program 2
// CIS 200-01
// Due: 3/10/2018
// By: z8360

// File: patronForm.cs
// this creates a form to be used for adding new patron. it returns the valid parameters for a book
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
    public partial class patronForm : Form
    {
        public string ReturnPatName { get; set; } // properties used to make Patron name
        public string ReturnPatID { get; set; } // properties used to make Patron id

        public patronForm()
        {
            InitializeComponent();
            
        }

        // Precondition:  patron name is null or white space
        // Postcondition: patron name is not null or white space
        private void ReturnButton_Click(object sender, EventArgs e) // accept button
        {

            if (ValidateChildren(ValidationConstraints.Enabled)) // if everything is valid
            {
                string patName = patronNameBox.Text; // sets item index to index value selected in itemcombobox
                string patID = patronIDBox.Text; // sets patron index to index value selected in patronombobox

                this.ReturnPatName = patName; // uses checkout property to return itemindex
                this.ReturnPatID = patID; // uses checkout property to return patronindex
                this.DialogResult = DialogResult.OK; // sets the dialoge result to OK
                this.Close(); // closes checkout form
            }
            else{
               
            }

        }
        // Precondition:  none
        // Postcondition: patron form is closed
        private void patCancelButton_Click(object sender, EventArgs e) // cancel button
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Precondition:  patron name is null or white space
        // Postcondition: patron name is not null or white space
        private void patronNameBox_Validating(object sender, CancelEventArgs e) // validation for patron name
        {
            if (string.IsNullOrWhiteSpace(patronNameBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                patronNameBox.Focus();
                errorProvider1.SetError(patronNameBox, "Name is required");
            }
            
        }
        // Precondition: is validated
        // Postcondition: no set error
        private void patronNameBox_Validated(object sender, EventArgs e) // patron name validated
        {
           errorProvider1.SetError(patronNameBox, null);
        }

        // Precondition: id box is selected 
        // Postcondition: id is not null or white space
        private void patronIDBox_Validating(object sender, CancelEventArgs e) // patron id validation
        {
            if (string.IsNullOrWhiteSpace(patronIDBox.Text)) // cannot be null or white space
            {
                e.Cancel = true;
                patronIDBox.Focus();
                errorProvider1.SetError(patronIDBox, "ID is required");
            }
           
        }
        // Precondition: is validated
        // Postcondition: no seterror
        private void patronIDBox_Validated(object sender, EventArgs e) // patron id validated
        {
            errorProvider1.SetError(patronIDBox, null);
        }
    }
}
