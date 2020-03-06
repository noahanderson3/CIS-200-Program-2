
// Program 2
// CIS 200-01
// Due: 3/10/2018
// By: z8360

// File:CheckoutForm.cs
// this creates a form to be used for checking out items. returns item and patron indexes
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
  
    public partial class CheckoutForm : Form
    {
        public int ReturnCheckoutItem { get; set; } // properties used to make checkout item index public
        public int ReturnCheckoutPatron { get; set; } // properties used to make checkout item index public

        public CheckoutForm(Library _lib) // form for checkout that accepts a library parameter
        {
            InitializeComponent();            
            foreach (LibraryItem item in _lib.GetItemsList()) // displays item title and call number in itemcombobox
            {

                this.itemComboBox.Items.Add($"{item.Title} , {item.CallNumber}");
            }
            foreach (LibraryPatron patron in _lib.GetPatronsList()) // displays patron name and id in patroncombobox
            {

                this.PatronComboBox.Items.Add($"{patron.PatronName} , {patron.PatronID}");
            }
        }

        //pre: form is open
        //post: form closes and values returned
        private void CheckoutButton_Click(object sender, EventArgs e) // when checkout button is pressed
        {
            if (itemComboBox.SelectedIndex < 0 || PatronComboBox.SelectedIndex < 0) // sees if they selected anything to check out
            {
                try // trys
                { throw new ArgumentOutOfRangeException(); }
                catch(ArgumentOutOfRangeException) // catches
                {
                    MessageBox.Show("You must select both an Item and a Patron"); // warning
                }
            }
            else
            {
                int itemIndex = itemComboBox.SelectedIndex; // sets item index to index value selected in itemcombobox
                int patronIndex = PatronComboBox.SelectedIndex; // sets patron index to index value selected in patronombobox

                this.ReturnCheckoutItem = itemIndex; // uses checkout property to return itemindex
                this.ReturnCheckoutPatron = patronIndex; // uses checkout property to return patronindex
                this.DialogResult = DialogResult.OK; // sets the dialoge result to OK
                this.Close(); // closes checkout form
            }
        }
        //pre: form is open
        //post: form closes
        private void CancelButton_Click(object sender, EventArgs e) // when the cancel button is pressed
        {
            this.DialogResult = DialogResult.Cancel; // sets the dialoge result to Cancel
            this.Close(); // closes checkout form
        }
    }
}
