
// Program 2
// CIS 200-01
// Due: 3/10/2018
// By: z8360

// File: ReturnForm.cs
// this creates a form to be used for returning items. it returns item index.

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
    public partial class ReturnForm : Form
    {
        public int ReturnReturnItem { get; set; } // properties used to make checkout item index public

        //pre:
        //post: 
        public ReturnForm(Library _lib)
        {
            InitializeComponent();
            foreach (LibraryItem item in _lib.GetItemsList()) // displays item title and call number in itemcombobox
            {

                this.ReturnComboBox.Items.Add($"{item.Title} , {item.CallNumber}");
            }
        }

        //pre:form is open
        //post: form is closed
        private void CancelReturnButton_Click(object sender, EventArgs e) // cancel button
        {
            this.DialogResult = DialogResult.Cancel; // sets the dialoge result to Cancel
            this.Close(); // closes checkout form
        }

        
        //pre: select item
        //post: item info returned form closed
        private void ReturnButton_Click(object sender, EventArgs e) // Return accept button
        {
            if (ReturnComboBox.SelectedIndex < 0) // sees if they selected anything to check out
            {
                try // trys
                { throw new ArgumentOutOfRangeException(); } //throws
                catch (ArgumentOutOfRangeException) // catches
                {
                    MessageBox.Show("You did not select an item"); // warning
                }

            }
            else
            {
                int returnItemIndex = ReturnComboBox.SelectedIndex; // sets item index to index value selected in itemcombobox


                this.ReturnReturnItem = returnItemIndex; // uses checkout property to return itemindex
                this.DialogResult = DialogResult.OK; // sets the dialoge result to OK
                this.Close(); // closes checkout form
            }
        }
    }
}
