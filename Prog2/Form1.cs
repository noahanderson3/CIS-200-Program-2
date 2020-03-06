// Program 2
// CIS 200-01
// Due: 3/10/2018
// By: z8360

// File: Form1.cs
// This file creates a gui for the library class. it can add patrons and books, check uut items, return items,
//and list itesm, patrons, and checked items

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

    public partial class Form1 : Form
    {

        public Library _lib; //the library

        //precondition: none
        //Postcondition: the forms gui are prepared for display and default values added to library
       

        public Form1()
        {
            InitializeComponent();


            
            _lib = new Library();
            //insert default items
            _lib.AddLibraryBook("Fifty Shades of Grey", "Vintage Books", 2011, 5, "123abc", "	E. L. James");
            _lib.AddLibraryBook("Second Book", "Second Publisher", 2000, 5, "234bcd", "Second Author");
            _lib.AddLibraryMovie("The Terminator", "Orion Pictures", 1984, 10, "agh454", 107, "James Cameron", LibraryMovie.MediaType.VHS, LibraryMovie.MPAARatings.R);
            _lib.AddLibraryMovie("Terminator 2", "TriStar Pictures", 1991, 10, "adf234", 137, "James Cameron", LibraryMovie.MediaType.VHS, LibraryMovie.MPAARatings.R);
            _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            _lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            _lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9A", 16, 7);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9B", 16, 8);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
                "MA53 9C", 16, 9);
            _lib.AddLibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
                "MA21 5V", 1, 1);

            //insert default patrons
            _lib.AddPatron("John Name", "123efd");
            _lib.AddPatron("Jenny McName", "325dsfd");
            _lib.AddPatron("Moira Surname", "453pkl");
            _lib.AddPatron("Henry Namesmith", "634fdh");
            _lib.AddPatron("Shelly O'Name", "592ppp");
            _lib.AddPatron("Benjamin Nameson", "092hes");

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //precon: none
        //postcon: none
        private void openToolStripMenuItem_Click(object sender, EventArgs e) // file tab, about
        {
            string NL = Environment.NewLine;
            MessageBox.Show($"Z8360{NL}" + $"Program 2 {NL}" + "due: 3/7/2018");
        }

        //precon: none
        //postcon: program is closed
        private void closeToolStripMenuItem_Click(object sender, EventArgs e) // file tab, exit
        {
            Application.Exit();
        }

        //precon: none
        //postcon: new patron is added
        private void patronToolStripMenuItem_Click(object sender, EventArgs e) // insert tab, patron
        {
            patronForm pf = new patronForm(); // creates a form pf for adding patrons
            pf.ShowDialog(); // shows pf form
                             //MessageBox.Show($"{pf.ReturnPatName}  {pf.ReturnPatID}"); // test code
            if (pf.DialogResult == DialogResult.OK) // if you selected Checkout
            {
                _lib.AddPatron(pf.ReturnPatName, pf.ReturnPatID);
                MessageBox.Show($"New Patron Added");
            }
            else { MessageBox.Show($"Canceled"); } // if you pushed cancel or exited out it does nothing
          

        }

        //precon: none
        //postcon: list of patrons displayed in textbox
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)// report tab, patron list
        {
           
            outputBox.Text = $"Total Patrons: {_lib.GetPatronCount().ToString()}"; // shows total number of patrons
            outputBox.Text += Environment.NewLine;
            outputBox.Text += "List of Library Patrons :";
            outputBox.Text += Environment.NewLine + "--------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
            //^heading
            foreach (LibraryPatron patron in _lib.GetPatronsList())
            {
                outputBox.Text += String.Join(Environment.NewLine, patron.ToString()); // displays each patron as string to the output box
                outputBox.Text += Environment.NewLine +"--------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
                //^ sepporates
            }          
        }

        //precon: none
        //postcon: list of items displayed in textbox
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e) // report tab, item list
        {
            outputBox.Text = $"Total Items: {_lib.GetItemCount().ToString()}"; // shows total number of items
            outputBox.Text += Environment.NewLine;
            outputBox.Text += "List of Library Items :";
            outputBox.Text += Environment.NewLine + "--------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
            //^heading
            foreach (LibraryItem item in _lib.GetItemsList())
            {
                outputBox.Text += String.Join(Environment.NewLine, item.ToString());// displays each Item as string to the output box
                outputBox.Text += Environment.NewLine + "-------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

            }
        }

        //precon: none
        //postcon: list of checked out items displayed in textbox
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e) // report tab, checked out items list
        {
            outputBox.Text = $"Total Items Checked Out: {_lib.GetCheckedOutCount().ToString()}"; // shows total number of items
            outputBox.Text += Environment.NewLine;
            outputBox.Text += "List of Checked Out Items :";
            outputBox.Text += Environment.NewLine + "--------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
            //^ heading
            foreach (LibraryItem item in _lib.GetItemsList())
            {
                if (item.IsCheckedOut() == true) // only displays items where checkedout == true
                {
                    outputBox.Text += String.Join(Environment.NewLine, item.ToString());// displays each Item as string to the output box
                    outputBox.Text += Environment.NewLine + "-------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
                }
            }
        }

        //precon: none
        //postcon: item is checked out
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e) // item tab, checkout item
        {
            CheckoutForm cf = new CheckoutForm(_lib); // creates a form cf for checkout
            cf.ShowDialog(); // shows cf form
            // test code
            //string a = cf.ReturnCheckoutItem.ToString();
            //string b = cf.ReturnCheckoutPatron.ToString(); 
            //MessageBox.Show($"{a} {b}");

            if (cf.DialogResult == DialogResult.OK) // if you selected Checkout
            {
                _lib.CheckOut(cf.ReturnCheckoutItem, cf.ReturnCheckoutPatron);
                MessageBox.Show($"Item checked out");
            }
            else { MessageBox.Show($"Canceled"); } // if you pushed cancel or exited out it does nothing
        }

        //precon: none
        //postcon: item is returned to shelf
        private void returnToolStripMenuItem_Click(object sender, EventArgs e) // item tab , return item
        {

            ReturnForm rf = new ReturnForm(_lib); // creates a form rf for returns
            rf.ShowDialog(); // shows rf form

            if (rf.DialogResult == DialogResult.OK) // if you selected Checkout
            {
                _lib.ReturnToShelf(rf.ReturnReturnItem);
                MessageBox.Show($"Item returned");
            }
            else { MessageBox.Show($"Canceled"); } // if you pushed cancel or exited out it does nothing

        }

        //precon: none
        //postcon:new book is added
        private void bookToolStripMenuItem_Click(object sender, EventArgs e) // item tab, add book
        {
            BookForm bf = new BookForm(); // creates a form bf for adding books
            bf.ShowDialog(); // shows bf form

            if (bf.DialogResult == DialogResult.OK) // if you selected Checkout
            {
                _lib.AddLibraryBook(bf.ReturnTitle, bf.ReturnPublisher, bf.ReturnCR, bf.ReturnLP, bf.ReturnCN, bf.ReturnAuthor);
                MessageBox.Show($"Book Added");
            }
            else { MessageBox.Show($"Canceled"); } // if you pushed cancel or exited out it does nothing





        }
    }
}