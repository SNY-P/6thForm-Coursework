using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;

namespace Business_Management_System__NEA_
{
    public partial class Add_Stock : Form
    {
        public Add_Stock()
        {
            InitializeComponent();
            DBValues();
        }

        DatabaseConnection DBC = new DatabaseConnection();
        public List<string> List = new List<string>(); // new public string list

        IEnumerator<string> myEnumerator = null;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemNameTextBox.Text != string.Empty && AmountInStkTextBox.Text != string.Empty && SupplierNameTextBox.Text != string.Empty && DateTextBox.Text != string.Empty)
            {
                DBC.getConnection();

                using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
                {
                    con.Open(); // open database
                                // select supplierID using inputted supplier name
                    SQLiteCommand cmdSup = new SQLiteCommand(string.Format(@"SELECT SupplierID FROM Supplier WHERE Name='{0}'", SupplierNameTextBox.Text), con);
                    SQLiteDataReader reader = cmdSup.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        int sID = reader.GetInt32(0); // store PK value
                        reader.Close(); // close data reader
                                        // insert data into Stock table
                        SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Stock(ItemName, AmountInStock, DataLastUpdated, SupplierID) VALUES (@Name, @AIS, @DLU, @S)", con);
                        cmd.Parameters.AddWithValue("@Name", ItemNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@AIS", AmountInStkTextBox.Text);
                        cmd.Parameters.AddWithValue("@DLU", DateTextBox.Text);
                        cmd.Parameters.AddWithValue("@S", sID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Data has been added"); // exception handling
                    }
                    else // if supplier name inputted is not in Supplier table then shows following message and sends user to add upplier info
                    {
                        MessageBox.Show("Supplier doesn't exist. Please input the supplier details before adding stock data.");
                        Suppliers sup = new Suppliers();
                        this.Close(); // close form
                        sup.Show(); // show supplier form
                    }

                    con.Close(); // close database
                }
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (textBox.Text == string.Empty)
                        {
                            if (textBox == ItemNameTextBox)
                            {
                                MessageBox.Show("Enter Item Name");
                            }
                            else if (textBox == AmountInStkTextBox)
                            {
                                MessageBox.Show("Enter the Amount in Stock");
                            }
                            else if (textBox == SupplierNameTextBox)
                            {
                                MessageBox.Show("Enter the name of the Supplier");
                            }
                            else if (textBox == DateTextBox)
                            {
                                MessageBox.Show("Enter the date");
                            }
                        }
                    }
                }
            }            
        }
                
        public void DBValues()
        {
            DBC.getConnection(); // connect to database

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database

                SQLiteCommand cmdCount = new SQLiteCommand(@"SELECT COUNT(*) FROM Supplier", con); // get number of rows in Supplier table
                int RecordCount = Convert.ToInt32(cmdCount.ExecuteScalar()) ;// store the number of rows

                for (int i = 1; i <= RecordCount; i++) // iterates through each record, adds the value the value to the list 
                {
                    SQLiteCommand cmd = new SQLiteCommand(string.Format(@"SELECT Name FROM Supplier WHERE SupplierID='{0}'", i), con);
                    List.Add((string)cmd.ExecuteScalar()); // adds each value to list
                }

                List.Sort(); // sorts list alphabetically
                
                con.Close(); // close database
            }
        }
        
        public string GetNextItemToDisplay(List<string> strList)
        {               
            if (myEnumerator == null) // not started
            {
                myEnumerator = strList.GetEnumerator(); // get enumerator
            }
            // get the next element (or if we haven't fetched anything yet: get the first element)            
            while (myEnumerator.MoveNext())
            {   // There is a next string. It is in Current:
                return myEnumerator.Current;
            }
            
            return null; // no strings left, return null
        }

        public void RestartEnumeration()
        {
            myEnumerator = null;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // this checks to see if a null value is in the list, if it is then it will be removed.
            var temp = new List<string>();
            foreach (var s in List)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    temp.Add(s);
                }
            }
            List = temp.ToList();

            string nextItemToDisplay = GetNextItemToDisplay(List);

            if (nextItemToDisplay != null)
            {
                SupplierNameTextBox.Text = nextItemToDisplay;
            }
            else
            {
                RestartEnumeration();
            }            
        }
    }
}