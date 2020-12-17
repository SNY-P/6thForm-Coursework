using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Business_Management_System__NEA_
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }
                
        LoadDatabase LDB = new LoadDatabase();

        private void Suppliers_Load(object sender, EventArgs e)
        {
            LDB.storedLoad("Supplier", SupplierData); // load storedLoad function from LoadDatabase class
        }

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            DatabaseConnection DBC = new DatabaseConnection();
            DBC.getConnection();

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // insert data into Supplier table
                SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Supplier(Name, Address, ContactNumber) VALUES (@Name, @Address, @CN)", con);
                cmd.Parameters.AddWithValue("@Name", SupplierNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                cmd.Parameters.AddWithValue("@CN", ContactNumberTextBox.Text);
                cmd.ExecuteNonQuery();

                con.Close(); // close database
                MessageBox.Show("Data has been added"); // exception handling
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LDB.updatedLoad("Supplier", SupplierData); // call updatedLoad function from LoadDatabase class
        }
    }
}
