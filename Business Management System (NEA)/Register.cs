using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Business_Management_System__NEA_
{
    public partial class RegisterForm : Form
    {
        DatabaseConnection DBC = new DatabaseConnection();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void AddFullName(string FN)
        {         
            DBC.getConnection(); // connects to database file

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // insert full name into table UserInfo
                SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO UserInfo(FullName) VALUES (@Full)", con);
                cmd.Parameters.AddWithValue("@Full", FN);
                cmd.ExecuteNonQuery();
                con.Close(); // close database
            }
        }

        private void AddLoginInfo(string username, string password, string fullname)
        {
            DBC.getConnection(); // connects to database file
            // calls AddFullName function
            AddFullName(txtBoxFullName.Text);

            int ID = 0;

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // select Primary Key value from UserInfo table
                SQLiteCommand cmdS = new SQLiteCommand(string.Format(@"SELECT InfoID FROM UserInfo WHERE FullName='{0}'", fullname), con);
                SQLiteDataReader SQLread = cmdS.ExecuteReader();

                if (SQLread.HasRows)
                {
                    SQLread.Read();
                    ID = SQLread.GetInt32(0); // store PK value from UserInfo table
                    // insert new username and password into LoginInfo table
                    SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO LoginInfo(Username, Password, InfoID) VALUES (@username, @password, @info)", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@info", ID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created!"); // exception handling
                    // close current form
                    this.Close();
                }

                con.Close(); // close database
            }
        }

        private void checkLoginInfo(string username, string password)
        {
            DBC.createDatabase();
            DBC.getConnection();
            
            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database

                try
                {   // select username from LoginInfo
                    SQLiteCommand cmd = new SQLiteCommand(@"SELECT * FROM LoginInfo WHERE Username ='" + username + "'", con);

                    int count = 0; // counter
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        count++; // increment counter
                    }

                    if (count == 0) // account does not exist
                    {
                        // Password Hash
                        byte[] encodedPassword = new UTF8Encoding().GetBytes(password);

                        byte[] hashp = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

                        string encodedp = BitConverter.ToString(hashp);
                        string encodep = encodedp.Replace("-", string.Empty);
                        // call AddLoginInfo Function
                        AddLoginInfo(username, encodep, txtBoxFullName.Text);
                    }
                    else if (count == 1) // account does exist
                    {
                        MessageBox.Show("Account already exists", "Try Again"); // exception handling
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close(); // close database
            }
        } 

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (txtBoxUsername.Text != string.Empty && txtBoxPassword.Text != string.Empty && txtBoxFullName.Text != string.Empty)
            {
                checkLoginInfo(txtBoxUsername.Text, txtBoxPassword.Text); // calls checkLoginInfo function
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
                            if (textBox == txtBoxUsername)
                            {
                                MessageBox.Show("Enter Username");
                            }
                            else if (textBox == txtBoxPassword)
                            {
                                MessageBox.Show("Enter Password");
                            }
                            else if (textBox == txtBoxFullName)
                            {
                                MessageBox.Show("Enter Full Name");
                            }
                        }
                    }
                }
            }
        }
    }
}
