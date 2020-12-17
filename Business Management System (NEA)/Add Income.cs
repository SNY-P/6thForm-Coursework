using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Business_Management_System__NEA_
{
    public partial class Add_Income : Form
    {
        public Add_Income()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DateTextBox.Text != string.Empty && AmountRecievedTextBox.Text != string.Empty && PaymentMethodTextBox.Text != string.Empty && 
                FromTextBox.Text != string.Empty)
            {
                DatabaseConnection DBC = new DatabaseConnection(); // new object using DatabaseConnection class
                DBC.getConnection(); // connect to database

                using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
                {
                    con.Open(); // open database
                                // insert data in Income table
                    SQLiteCommand cmd = new SQLiteCommand
                    {
                        CommandText = @"INSERT INTO Income([Date], [AmountRecievedin£], PaymentMethod, Description, FromWho)
                                     VALUES (@Date, @AmountRecievedin£, @PaymentMethod, @Description, @FromWho)",
                        Connection = con
                    };
                    cmd.Parameters.AddWithValue("@Date", DateTextBox.Text);
                    cmd.Parameters.AddWithValue("@AmountRecievedin£", AmountRecievedTextBox.Text);
                    cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethodTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@FromWho", FromTextBox.Text);
                    cmd.ExecuteNonQuery();

                    con.Close(); // close database
                    MessageBox.Show("Data has been added"); // exception handling
                    this.Close(); // close form
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
                            if (textBox == DateTextBox)
                            {
                                MessageBox.Show("Enter Date");
                            }
                            else if (textBox == AmountRecievedTextBox)
                            {
                                MessageBox.Show("Enter the Amount Recieved");
                            }
                            else if (textBox == PaymentMethodTextBox)
                            {
                                MessageBox.Show("Enter the Payment Method");
                            }
                            else if (textBox == FromTextBox)
                            {
                                MessageBox.Show("Enter who the payment was from");
                            }
                        }
                    }
                }
            }
        }
    }
}
