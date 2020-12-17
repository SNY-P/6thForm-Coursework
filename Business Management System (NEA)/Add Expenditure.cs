using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Business_Management_System__NEA_
{
    public partial class Add_Expenditure : Form
    {
        public Add_Expenditure()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (DateTextBox.Text != string.Empty && AmountSpentTextBox.Text != string.Empty && PaymentMethodTextBox.Text != string.Empty && ToTextBox.Text != string.Empty)
            {
                DatabaseConnection DBC = new DatabaseConnection(); // new object using DatabaseConnection class
                DBC.getConnection(); // connect to database

                using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
                {
                    con.Open(); // open database
                                // add data into Expenditure table
                    SQLiteCommand cmd = new SQLiteCommand
                    {
                        CommandText = @"INSERT INTO Expenditure([Date], [AmountSpentin£], PaymentMethod, Description, ToWho)
                                     VALUES (@Date, @AmountSpentin£, @PaymentMethod, @Description, @ToWho)",
                        Connection = con
                    };
                    cmd.Parameters.AddWithValue("@Date", DateTextBox.Text);
                    cmd.Parameters.AddWithValue("@AmountSpentin£", AmountSpentTextBox.Text);
                    cmd.Parameters.AddWithValue("@PaymentMethod", PaymentMethodTextBox.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@ToWho", ToTextBox.Text);
                    cmd.ExecuteNonQuery();

                    con.Close(); // close database
                    MessageBox.Show("Data has been added"); // exception handling
                    this.Close(); // close current form
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
                            else if (textBox == AmountSpentTextBox)
                            {
                                MessageBox.Show("Enter the Amount Spent");
                            }
                            else if (textBox == PaymentMethodTextBox)
                            {
                                MessageBox.Show("Enter the Payment Method");
                            }
                            else if (textBox == ToTextBox)
                            {
                                MessageBox.Show("Enter who the payment was for");
                            }
                        }
                    }
                }
            }

        }
    }
}