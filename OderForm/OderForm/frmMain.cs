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
using System.Web;
using OderForm;

namespace OderForm
{
    public partial class frmMain : Form
    {

        //Setup the settings for the connection
        OleDbConnection myConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\CIS 237\Project 1\OderForm\OderForm\BooksOrderForm.accdb");
        OleDbDataAdapter myAdapt;
        OleDbCommand myCommand;

        public decimal decOrderTotal = 0.0m;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            //Fill the books combo box
            try
            {
                //Open Connection
                myConn.Open();

                //Call the FillBooksCombo method
                FillBooksCombo();
                //Call the FillCustomersCombo Method
                FillCustomersCombo();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                myConn.Close();
            }
        }

        //Fill methods---------------------------------------------------------------------------
        //Fill the combo box with the BooksID and the Book Title of the books table
        //Pre: none
        //Post: Fills the combo box with the bookCode and the title from the books table
        //Purpose: To fill the combo box books
        public void FillBooksCombo()
        {
            cmbCustomers.Items.Clear();
            //Reload Combo Box
            //Fill the combo box
            myCommand = new OleDbCommand("Select bookCode, title from books", myConn);
            OleDbDataReader myReader = null;

            //Execute myCommand to the reader
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                //Associative array
                cmbBooks.Items.Add(myReader["bookCode"].ToString() + " " + myReader["title"].ToString());
            }
        }//End FillBooksCombo

        //Fill the combo box customers 
        //Pre: none
        //Post: Fills the combo box with the last first and how many orders a customer has
        //Purpose: To fill the combo box customers
        public void FillCustomersCombo()
        {
            cmbCustomers.Items.Clear();
            //Reload Combo Box
            //Fill the combo box
            myCommand = new OleDbCommand("Select custID, lastName, firstName from customers", myConn);
            OleDbDataReader myReader = null;

            //Execute myCommand to the reader
            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                //Associative array
                cmbCustomers.Items.Add(myReader["custID"].ToString() + " " + myReader["lastName"].ToString() + ", " + myReader["firstName"].ToString());
            }
        }//End FillCustomersCombo


        //Buttons--------------------------------------------------------------------------------------------
        //Customer Buttons--------------------------------
        //New button
        private void btnNew_Click(object sender, EventArgs e)
        {
            //Enable all of the text fields in grpCustomers
            txtFistName.Enabled = true;
            txtLastName.Enabled = true;
            txtAddress.Enabled = true;
            txtCity.Enabled = true;
            cmbState.Enabled = true;
            txtZip.Enabled = true;
            //Set the focus to the firstName text box
            txtFistName.Focus();
            //Enable the cancel button
            btnCancel.Enabled = true;
            //Set customers combo box to be nothing
            cmbCustomers.Text = "";
            //Clear all text fields in grpCustomers if their is info filled in
            txtLastName.Clear();
            txtFistName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            cmbState.Text = "";
            txtZip.Clear();

        }//End btnNew
        //Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Set the text fields in the grpCustomers box to be disabled
            txtFistName.Enabled = false;
            txtLastName.Enabled = false;
            txtAddress.Enabled = false;
            txtCity.Enabled = false;
            cmbState.Enabled = false;
            txtZip.Enabled = false;
            //Disable the cancel button
            btnCancel.Enabled = false;
            //Set the combo box Customers to equal nothing
            cmbCustomers.Text = "";
            //Clear out the text fields on the form
            txtLastName.Clear();
            txtFistName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            cmbState.Text = "";
            txtZip.Clear();
        }//End btnCancel

        //Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Try Catch statement to save the information of the new customer into the Customers table
            try
            {
                //Open the connection
                myConn.Open();

                //If none of the boxes are blank you will move onto the next try catch otherwise throw an error.
                if (txtFistName.Text == "" && txtLastName.Text == "" && txtAddress.Text == "" && txtCity.Text == "" && cmbState.SelectedIndex == -1 && txtZip.Text == "")
                {
                    MessageBox.Show("Error you must input all fields to add a new record", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    //Command-------------------------------- -
                        myCommand = new OleDbCommand("INSERT INTO customers (lastName, firstName, address, city, state, zipCode) VALUES" +
                            "('" + txtLastName.Text + "', '" + txtFistName.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" +
                            cmbState.Text + "', '" + txtZip.Text + "' )", myConn);

                        //Adapter-------------------------------- -
                        //setting the command to the adapter
                        myAdapt = new OleDbDataAdapter(myCommand);
                        //Execute the command to the database
                        myAdapt.SelectCommand.ExecuteNonQuery();

                        //Call the FillCombo method.
                        FillCustomersCombo();
                   
                }


            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close the connection
                myConn.Close();
            }

            //Clear all the boxes on the form
            txtLastName.Clear();
            txtFistName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            cmbState.Text = "";
            txtZip.Clear();
        }//End btnSave

        //Order Buttons-------------------------------------------------
        //Place order Button
        private void btnPlacetheOrder_Click(object sender, EventArgs e)
        {
            //Set an instance of dialogresult to display a message asking if they really want to place this order
            DialogResult dglResult = MessageBox.Show("Are you sure you want to place this order?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //If Yes is clicked then do the code below
            if (dglResult == DialogResult.Yes)
            {
                //Set the variable strID to the text inside of the selected customer combo box
                string strID = cmbCustomers.Text.Trim();
                //Get the index of the position of first Space in the text
                int pos = strID.IndexOf(" ");
                //Grab the letters starting at position 0 and going until the integer of position that was grabbed above.
                strID = strID.Substring(0, pos);

                //create your reader
                OleDbDataReader myReader = null;

                //Variables to hold parts of the string
                string bookName = ""; //Holds the book Name to remove it from the string
                string bookCode = ""; //Holds the bookCode
                int numOrdered = 0; //This will hold the number ordered
                decimal bookTotal = 0.0m; //This will hold the calculated total of the book ordered
                int orderID = 0; //This will hold the orderID 
                int onHand = 0; //This will grab the number onHand from the books table
                bool notInteger = true;//Boolean to know if the string has found an integer

                //Try Catch to insert the order into the orders table and order detail table
                try
                {
                    //Open the connection
                    myConn.Open();

                    //Insert into the orders table
                    //Command--------------------------------
                    myCommand = new OleDbCommand("INSERT INTO orders (custID, orderDate) VALUES" + "('" + strID + "'" + ",'" + System.DateTime.Now.ToString() + "')", myConn);
                    //setting the command to the adapter
                    myAdapt = new OleDbDataAdapter(myCommand);
                    //Execute the command to the database
                    myAdapt.SelectCommand.ExecuteNonQuery();
                    //End Command--------------------------------

                    //Select top 1 order of the orders table to get last record inputted
                    myCommand = new OleDbCommand("Select top 1 orderID, OrderDate from orders order by orderID desc", myConn);
                    //Set myReader to execute the command
                    myReader = myCommand.ExecuteReader();
                    //End Command-----------------------------

                    //Loop through all of the data from the selection above to display the orderNumber and orderDate
                    while (myReader.Read())
                    {
                        //Fill in the labels at the top of the page with 
                        lblOrderNum.Text = myReader[0].ToString();
                        lblDate.Text = myReader[1].ToString();
                    }

                    //Loop through the listOrder Items located in the list box on the bottom of the form
                    foreach (object p in listOrders.Items)
                    {
                        //Grab the string of the item
                        string index = p.ToString();
                        //Grab the position of the first space in the string
                        int position = index.IndexOf(" ");
                        //Set the book code to the first group of characters before the first space
                        bookCode = index.Substring(0, position);
                        //Remove all characters including the space up to the first space in the string
                        index = index.Remove(0, position + 1);

                        //While integer is true loop through the code below to remove the book title and grab the amount Ordered
                        while (notInteger)
                        {
                            //Get the position of the next space
                            position = index.IndexOf(" ");
                            //Set bookName to equal the substring of index grabbing all characters to the space and the space itself
                            bookName = index.Substring(0, position + 1);

                            //Try catch to convert to integer
                            try
                            {
                                //Try to convert the next string of characters to numOrdered
                                numOrdered = Convert.ToInt32(index.Substring(0, position));
                                //set Integer to false;
                                notInteger = false;
                                //remove the converted integer and the space after it
                                index = index.Remove(0, position + 1);
                            }
                            catch //If the string cannot convert go here
                            {
                                //Set index equal to the index removing up to the postition + 1 to include the space
                                index = index.Remove(0, position + 1);
                                //Set the integer to true;
                                notInteger = true;
                            }
                        }//End While

                        //Set notInteger back to true
                        notInteger = true;

                        //Grab the last of the string from the listOrders and set it to the book total
                        bookTotal = Convert.ToDecimal(index);

                        //New Commend to select the last record input into the orders table-----------------------------------------
                        myCommand = new OleDbCommand("(Select top 1 orderID, OrderDate from orders order by orderID desc)", myConn);
                        myReader = myCommand.ExecuteReader();
                        //End command-------------------------------------------

                        //Loop through all of the data from the selection above
                        while (myReader.Read())
                        {
                            //Grab the orderID
                            orderID = Convert.ToInt32(myReader[0].ToString());
                        }

                        //Insert command to insert the order into the order detail table
                        myCommand = new OleDbCommand("INSERT INTO orderDetail (orderID, bookCode, numOrdered, totalPrice) VALUES"
                            + "('" + orderID + "','" + bookCode + "' , '" + numOrdered + "' , '" + bookTotal + "')", myConn);
                        //Adapter-------------------------------- -
                        //setting the command to the adapter
                        myAdapt = new OleDbDataAdapter(myCommand);
                        //Execute the command to the database
                        myAdapt.SelectCommand.ExecuteNonQuery();
                        //End Command---------------------------------------------------------------------
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    //Close the connection
                    myConn.Close();
                }  
            }
            else
            {

            }
        }//End PlaceOder

        //CancelOrder Button
        //Closes the form
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            //Variables to hold parts of the string
            string bookName = "";
            
            int numOrdered = 0;
            bool notInteger = true;
            int onHand = 0;
            OleDbDataReader myReader = null;
            string strID = "";
            
            

            DialogResult result = MessageBox.Show("Are you sure you would like to cancel this order?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(result == DialogResult.Yes)
            {
                //Use this try statement to remove all of the books from the order and add them back into the database
                try
                {
                    myConn.Open();
                    //Loop through the listOrder Items
                    foreach (object p in listOrders.Items)
                    {
                        //Grab the string of the item
                        string index = p.ToString();
                        //Grab the position of the first space in the string
                        int position = index.IndexOf(" ");
                        //Set the book code to the first group of characters before the first space
                        strID = index.Substring(0, position);
                        //Remove all characters including the space up to the first space in the string
                        index = index.Remove(0, position + 1);

                        //While integer is true loop through the code below to remove the book title and grab the amount Ordered
                        while (notInteger)
                        {
                            //Get the position of the next space
                            position = index.IndexOf(" ");
                            //Set bookName to equal the substring of index grabbing all characters to the space and the space itself
                            bookName = index.Substring(0, position + 1);

                            //Try catch to convert to integer
                            try
                            {
                                //Try to convert the next string of characters to numOrdered
                                numOrdered = Convert.ToInt32(index.Substring(0, position));
                                //set Integer to false;
                                notInteger = false;
                                //remove the converted integer and the space after it
                                index = index.Remove(0, position + 1);
                            }
                            catch //If the string cannot convert go here
                            {
                                //Set index equal to the index removing up to the postition + 1 to include the space
                                index = index.Remove(0, position + 1);
                                //Set the integer to true;
                                notInteger = true;
                            }
                        }//End While

                        //Get the amount on hand
                        myCommand = new OleDbCommand("Select * from books where bookCode = '" + strID + "'", myConn);
                        //Set myReader to execute the command
                        myReader = myCommand.ExecuteReader();
                        //Loop through all of the data
                        while (myReader.Read())
                        {
                            //Grab the onHand number from the selection
                            onHand = Convert.ToInt32(myReader[4]);
                        }

                        //Get the amount on hand and add the books back to the table
                        myCommand = new OleDbCommand("update books set onHand = '" + (onHand + numOrdered) + "' where bookCode = '" + strID + "'", myConn);
                        //Adapter-------------------------------- -
                        //setting the command to the adapter
                        myAdapt = new OleDbDataAdapter(myCommand);
                        //Execute the command to the database
                        myAdapt.SelectCommand.ExecuteNonQuery();
                        //End Command----------------------------------------------------------------------------
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    //Close the connection
                    myConn.Close();
                }
                Application.Exit();
            }
            else
            {

            }
        }//End btnCancelOrder

        //Display button
        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            //Set a new instance of the frmDisplay form
            frmDisplay display = new frmDisplay();
            //Show the form
            display.Show();
        }//End btnDisplayInfo

        //-------------------------------------------------------------------
        //Cart buttons
        //Add to cart Button
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            //Variables
            int onHand = 0; //Holds the amount onHand
            OleDbDataReader myReader = null; //Data reader
                        

            if (cmbBooks.SelectedIndex < 0 && numQuantity.Value < 0) //If nothing is selected for either throw error
            {
                MessageBox.Show("Please make a book and quantity selection in order to add to the cart");
            }
            else
            {
                //Set the strID to equal the combo books text that is selected
                string strID = cmbBooks.Text.Trim();
                //Get the index of the position of Space in the text
                int pos = strID.IndexOf(" ");
                //Grab the letters starting at position 0 and going until the integer of position that was grabbed above.
                strID = strID.Substring(0, pos);

                //Try catch to search for the amount on hand
                try
                {
                    myConn.Open();
                    //Get the amount on hand
                    //Command
                    myCommand = new OleDbCommand("Select * from books where bookCode = '" + strID + "'", myConn);
                    //Set myReader to execute the command
                    myReader = myCommand.ExecuteReader();
                    //End command--------------------------------------------------

                    //Loop through all of the data
                    while (myReader.Read())
                    {
                        //Grab the amount onHand
                        onHand = Convert.ToInt32(myReader[4]);
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    //Close the connection
                    myConn.Close();
                }
                
                //If the numQuantity selected is greater than the amount on hand throw error
                if(numQuantity.Value > onHand)
                {
                    MessageBox.Show("There are not enough books for this order please try again. There are only " + onHand + " of this book.");
                    //set selection to -1
                    cmbBooks.SelectedIndex = -1;
                    //set numQuantity to 0
                    numQuantity.Value = 0;
                    //clear out the total text
                    txtTotal.Clear();
                }
                else
                {
                    //Try catch to update the books onHand in the books table
                    try
                    {
                        myConn.Open();
                        //Get the amount on hand
                        myCommand = new OleDbCommand("update books set onHand = '" + (onHand - numQuantity.Value) + "' where bookCode = '" + strID + "'", myConn);
                        //setting the command to the adapter
                        myAdapt = new OleDbDataAdapter(myCommand);
                        //Execute the command to the database
                        myAdapt.SelectCommand.ExecuteNonQuery();
                        //End Command-----------------------------------------------------------------------

                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        //Close the connection
                        myConn.Close();
                    }

                    //Add the book and its amount ordered to the list box
                    listOrders.Items.Add(cmbBooks.SelectedItem + " " + numQuantity.Value.ToString() + " " + txtTotal.Text);
                    //Set equal to the total in the txttotal text box and converting it to decimal
                    decOrderTotal = decOrderTotal + Convert.ToDecimal(txtTotal.Text);
                    //Set the orderTotal text box to equal decOrderTotal
                    txtOrderTotal.Text = decOrderTotal.ToString();

                    //Clear the grpProducts
                    //Set combo box books to -1
                    cmbBooks.SelectedIndex = -1;
                    //set numQuantity to 0
                    numQuantity.Value = 0;
                    //Set txtTotal to clear
                    txtTotal.Clear();
                }
                
            }

        }//End btnAddToCart

        //Remove from the cart button
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            //Variables
            int onHand = 0; //Hold amount onHand
            OleDbDataReader myReader = null; //Reader
            int numOrdered = 0; //Hold numOrdered
            string bookName = ""; //Hold the book name
            string strID = ""; //Hold the strID
            bool notInteger = true; //it it is not an integer
            string index = ""; //Hold the string called index

            //Set index to equal the selected item in the list box
            index = listOrders.SelectedItem.ToString();

            //Grab the position of the first space in the string
            int position = index.IndexOf(" ");
            //Set the book code to the first group of characters before the first space
            strID = index.Substring(0, position);
            //Remove all characters including the space up to the first space in the string
            index = index.Remove(0, position + 1);

            //While integer is true loop through the code below to remove the book title and grab the amount Ordered
            while (notInteger)
            {
                //Get the position of the next space
                position = index.IndexOf(" ");
                //Set bookName to equal the substring of index grabbing all characters to the space and the space itself
                bookName = index.Substring(0, position + 1);

                //Try catch to convert to integer
                try
                {
                    //Try to convert the next string of characters to numOrdered
                    numOrdered = Convert.ToInt32(index.Substring(0, position));
                    //set Integer to false;
                    notInteger = false;
                    //remove the converted integer and the space after it
                    index = index.Remove(0, position + 1);
                }
                catch //If the string cannot convert go here
                {
                    //Set index equal to the index removing up to the postition + 1 to include the space
                    index = index.Remove(0, position + 1);
                    //Set the integer to true;
                    notInteger = true;
                }
            }//End While

            //Try a connection to grab the onHand number in the books table
            try
            {
                myConn.Open();
                //Get the amount on hand
                myCommand = new OleDbCommand("Select * from books where bookCode = '" + strID + "'", myConn);
                //Set myReader to execute the command
                myReader = myCommand.ExecuteReader();
                //End Command---------------------------------------------------------------------

                //Loop through all of the data
                while (myReader.Read())
                {
                    //Hold on hand number
                    onHand = Convert.ToInt32(myReader[4]);
                }

                //Get the amount on hand and add the books back to the table
                myCommand = new OleDbCommand("update books set onHand = '" + (onHand + numOrdered) + "' where bookCode = '" + strID + "'", myConn);
                //setting the command to the adapter
                myAdapt = new OleDbDataAdapter(myCommand);
                //Execute the command to the database
                myAdapt.SelectCommand.ExecuteNonQuery();
                //End Command-----------------------------------------------------------------------
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close the connection
                myConn.Close();
            }
            //remove the selected item from the list box
            listOrders.Items.Remove(listOrders.SelectedItem);
        }
        //-------------------------------------------------------------------------

        //Selection of Customers 
        //Fill out form!!!
        //Load the data into the text fields from the combo box Customers from the table
        //Depending on the selection of the combo box Customers
        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String Operations
            string strID = cmbCustomers.Text.Trim();
            //String------------------------------------------------------------------------------------------------
            //Get the index of the position of Space in the text
            int pos = strID.IndexOf(" ");
            //Grab the letters starting at position 0 and going until the integer of position that was grabbed above.
            strID = strID.Substring(0, pos);
            int custID = 0;

            OleDbDataReader myReader = null;

            try
            {
                //Open Connection
                myConn.Open();

                custID = Convert.ToInt32(strID);
                //Fill out the command you want
                myCommand = new OleDbCommand("select * from customers where custID = " + custID , myConn);

                //Set myReader to execute the command
                myReader = myCommand.ExecuteReader();

                //Loop through all of the data starting with 1 because the custID is 0
                while (myReader.Read())
                {
                    //Set the text fields in grpCustomers to equal the data that was searched above
                    //using myReader
                    txtFistName.Text = myReader[1].ToString();
                    txtLastName.Text = myReader[2].ToString();
                    txtAddress.Text = myReader[3].ToString();
                    txtCity.Text = myReader[4].ToString();
                    cmbState.Text = myReader[5].ToString();
                    txtZip.Text = myReader[6].ToString();
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Close Connection
                myConn.Close();
            }
        }//End cmbCustomers selection change

        //Having both of these update will make it so that if either the combo box is changed or the NumValue is changed will update the total----------------------------
        private void cmbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the value of numQuantity to 0
            numQuantity.Value = 0;
            //If the cmbBooks.selected index == -1 do nothing!
            if (cmbBooks.SelectedIndex == -1)
            {

            }
            else
            {
                //If the index of the cmbCustomers is less than 0 throw error
                if (cmbCustomers.SelectedIndex < 0)
                {
                    //Set the text in the combo box equal to nothing
                    cmbBooks.SelectedIndex = -1;
                    MessageBox.Show("Please make a customer selection before selecting a product.");

                }
                else
                {
                    //Set strID to the text in the combo box books
                    string strID = cmbBooks.Text.Trim();
                    //Get the index of the position of Space in the text
                    int pos = strID.IndexOf(" ");
                    //Grab the letters starting at position 0 and going until the integer of position that was grabbed above.
                    strID = strID.Substring(0, pos);

                    OleDbDataReader myReader = null; //set myReader

                    //decimal to hold the total
                    decimal decTotal = 0.0m;
                    //decimal to hold the quantity
                    decimal decQuantity = 0.0m;
                    //Convert the numQuantity value to decimal and set it to decQuantity
                    decQuantity = Convert.ToDecimal(numQuantity.Value);

                    //Try catch to select the book that is selected in cmbBooks
                    try
                    {
                        //Open the connection
                        myConn.Open();

                        //Command-----------------------------------------------------------
                        myCommand = new OleDbCommand("Select price from books where bookCode = '" + strID + "'", myConn);
                        //Set myReader to execute the command
                        myReader = myCommand.ExecuteReader();
                        //End Command-------------------------------------------------------

                        //Loop through all of the data
                        while (myReader.Read())
                        {
                            //Grab the decTotal from the books table
                            decTotal = Convert.ToDecimal(myReader[0]);
                            //set the total from the total of the book * the quantity ordered to be set to txtTotal
                            txtTotal.Text = (decTotal * decQuantity).ToString();
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        //Close the connection
                        myConn.Close();
                    }
                }
            }
        }//End cmbBooks selection changed

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            //if cmbBooks.selectedIndex == -1 do nothing!
           if(cmbBooks.SelectedIndex == -1)
            {

            }
           else
            {
                //if cmbBooks.selectedIndex is less than 0 throw error
                if (cmbBooks.SelectedIndex < 0)
                {
                    MessageBox.Show("Please make a book selection first.");
                }
                else
                {
                    //Set the str equal to the cmbBooks text
                    string strID = cmbBooks.Text.Trim();
                    //Get the index of the position of Space in the text
                    int pos = strID.IndexOf(" ");
                    //Grab the letters starting at position 0 and going until the integer of position that was grabbed above.
                    strID = strID.Substring(0, pos);

                    OleDbDataReader myReader = null; //Reader

                    //Variables for decimals
                    decimal decTotal = 0.0m;
                    decimal decQuantity = 0.0m;
                    //Convert the numQuantity to decimal and set to decQuantity
                    decQuantity = Convert.ToDecimal(numQuantity.Value);

                    //Try catch to select the book that is selected in cmbBooks
                    try
                    {
                        //Open the connection
                        myConn.Open();

                        //Command-----------------------------------------------------------
                        myCommand = new OleDbCommand("Select price from books where bookCode = '" + strID + "'", myConn);
                        //Set myReader to execute the command
                        myReader = myCommand.ExecuteReader();
                        //End Command-------------------------------------------------------

                        //Loop through all of the data
                        while (myReader.Read())
                        {
                            //Grab the decTotal from the books table
                            decTotal = Convert.ToDecimal(myReader[0]);
                            //set the total from the total of the book * the quantity ordered to be set to txtTotal
                            txtTotal.Text = (decTotal * decQuantity).ToString();
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        //Close the connection
                        myConn.Close();
                    }
                }
            }
            
            

        }//End numQuantity value change
    }
}
