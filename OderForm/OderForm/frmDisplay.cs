/*
 * Author: Kenneth Lamb
 * purpose: To search the datagrid holding the order details and custID and names
 * date: 04/01/2020
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OderForm
{
    public partial class frmDisplay : Form
    {
        //Setup connection settings
        OleDbConnection myConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\CIS 237\Project 1\OderForm\OderForm\BooksOrderForm.accdb");
        OleDbDataAdapter myAdapt;
        OleDbCommand myCommand;
        DataSet mySet;


        public frmDisplay()
        {
            InitializeComponent();
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {
            //Load in the query Select * from Customers to the data grid
            try
            {
                //Open connection
                myConn.Open();
                //Holds the query 
                string query;
                //Set the query
                query = "Select od.orderID, od.bookCode, od.numOrdered, od.totalPrice, o.custID, c.lastName, c.firstName " +
                    "From orderDetail od, orders o, customers c " +
                    "Where od.orderID = o.orderID and o.custID = c.custID";
                //Call Fill Table function
                FillTable(query);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close connection
                myConn.Close();
            }
        }

        //Pre: Hav a string query passed into the function
        //Post: Use the query that is passed in to fill in the data set and then use that data set to fill in the data grid.
        //Purpose: to fill the datagrid with the information from the query that is passed in.
        public void FillTable(string query)
        {
            //Here we create the command object that contains the string SQL command
            myCommand = new OleDbCommand(query, myConn);
            //Prepare the dataset to receive the results.
            mySet = new DataSet();

            //Use the adapter to create a new instance of the adapter and use the command 
            using (myAdapt = new OleDbDataAdapter(myCommand))
            {
                //Call the adapt fill function and use the dataset mySet
                myAdapt.Fill(mySet);
            }

            //Fill the data grid with mySet.Tables and start at [0]
            dgDisplay.DataSource = mySet.Tables[0];
        }// End FillTable


        private void txtSpecificBook_TextChanged(object sender, EventArgs e)
        {
            //Filter the rows of the data table where bookCode is like any of the text in the textbox txtSpecificBook
            (dgDisplay.DataSource as DataTable).DefaultView.RowFilter = string.Format("bookCode LIKE '%{0}%'", txtSpecificBook.Text);
        }

        private void txtSpecificCustomer_TextChanged(object sender, EventArgs e)
        {
            //Filter the rows of the data table where lastName is like any of the text in the textbox txtSpecificCustomer
            (dgDisplay.DataSource as DataTable).DefaultView.RowFilter = string.Format("lastName LIKE '%{0}%'", txtSpecificCustomer.Text);
        }

        private void radCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //Enable the customer texbox and disable the book text box
            txtSpecificCustomer.Visible = true;
            txtSpecificBook.Visible = false;

            //Clear the book text box and set focus to the customer text box
            txtSpecificBook.Clear();
            txtSpecificCustomer.Focus();

        }

        private void radBooks_CheckedChanged(object sender, EventArgs e)
        {
            //Set the customer text box to be disabled and enable the book text box
            txtSpecificCustomer.Visible = false;
            txtSpecificBook.Visible = true;

            //Clear the customer text box and set focus on the book text box
            txtSpecificCustomer.Clear();
            txtSpecificBook.Focus();
        }
    }
}
