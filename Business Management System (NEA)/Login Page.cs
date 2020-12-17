using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Business_Management_System__NEA_
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        DatabaseConnection DBC = new DatabaseConnection();
        FormOpener FO = new FormOpener();

        public static string passingText;

        private bool checkAccount(string username)
        {
            DBC.getConnection(); // connects to .db file
            DBC.createDatabase(); // if file is not there then creates new database

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open .db
                SQLiteCommand cmd = new SQLiteCommand
                {
                    CommandText = @"SELECT * FROM LoginInfo WHERE Username='" + username + "'", // SQL Query
                    Connection = con
                };

                SQLiteDataReader rd = cmd.ExecuteReader(); // reads data
                int count = 0;
                while (rd.Read())
                {
                    count++; // if data is there then increments
                }

                if (count == 1) // account is in database
                {
                    rd.Close(); // close data reader
                    con.Close(); // close database
                    return true;
                }
                else
                {   // Opens Error Form
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(FO.OpenError));
                    this.Close();
                    thread.Start();
                    return false;
                }
            }
        }

        private void correctInfo(string username, string password)
        {
            DBC.getConnection(); // calls getConnection function from DatabaseConnection class

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // select login information using the inputted parameters
                SQLiteCommand cmd = new SQLiteCommand
                {
                    CommandText = string.Format(@"SELECT * FROM LoginInfo WHERE Username='{0}' AND Password='{1}'", username, password),
                    Connection = con
                };

                int count = 0; // counter
                SQLiteDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    count++; // increment counter
                }

                if (count == 1)
                {
                    read.Close(); // close data reader
                    con.Close(); // close database
                    // Opens Welcome Form
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(FO.OpenWelcomeForm));
                    this.Close();
                    t.Start();
                }
                else
                {
                    read.Close(); // close data reader
                    con.Close(); // close database
                    // Opens Error Form
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(FO.OpenError));
                    this.Close();
                    thread.Start();
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            passingText = UsernameTextBox.Text;

            if (UsernameTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty) // both textboxes are not empty
            {
                if (checkAccount(UsernameTextBox.Text) == true) // account is in database then...
                {
                    if (UsernameTextBox.Text == "admin" && PasswordTextBox.Text == "password") // default data used
                    {
                        correctInfo("admin", "password"); // call correctInfo function
                    }
                    else
                    {
                        // Password Hash
                        byte[] encodedPassword = new UTF8Encoding().GetBytes(PasswordTextBox.Text);

                        byte[] hashp = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

                        string encodedp = BitConverter.ToString(hashp);
                        string encodep = encodedp.Replace("-", string.Empty);

                        correctInfo(UsernameTextBox.Text, encodep); // call correctInfo function
                    }
                }
            }
            else if (UsernameTextBox.Text != string.Empty && PasswordTextBox.Text == string.Empty) // password textbox is empty
            {
                MessageBox.Show("Enter Password");
            }
            else if (UsernameTextBox.Text == string.Empty && PasswordTextBox.Text != string.Empty) // username textbox is empty
            {
                MessageBox.Show("Enter Username");
            }
            else if (UsernameTextBox.Text == string.Empty && PasswordTextBox.Text == string.Empty) // both texboxes are empty
            {
                MessageBox.Show("Enter Username and Password");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm(); // new form object
            rf.ShowDialog(); // show form
        }
    }
}
