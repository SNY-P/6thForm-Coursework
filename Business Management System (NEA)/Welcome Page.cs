using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Business_Management_System__NEA_
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            FormOpener FO = new FormOpener();
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(FO.OpenStreamlineWindow));
            this.Close();
            t.Start();
        }

        private void Welcome_Page_Load(object sender, EventArgs e)
        {               
            // gets text from usernametextbox in the LoginForm
            string name = LoginForm.passingText;
            int id; // declaration
            string fullName; // declaration

            DatabaseConnection DBC = new DatabaseConnection();
            // get connection to updated database
            DBC.getConnVar("NEAdb.db");

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // select PK from LoginInfo where username = userinput
                SQLiteCommand cmd = new SQLiteCommand(string.Format(@"SELECT InfoID FROM LoginInfo WHERE Username='{0}'", name), con);
                SQLiteDataReader SQLread = cmd.ExecuteReader();

                if (SQLread.HasRows) // true if there are rows in table
                {
                    SQLread.Read(); // reads the row
                    id = SQLread.GetInt32(0); // stores PK of fullname
                    // close data reader
                    SQLread.Close();
                    // selects full name using stored PK value from earlier
                    SQLiteCommand cmdFN = new SQLiteCommand(string.Format(@"SELECT FullName FROM UserInfo WHERE InfoID={0}", id), con);
                    SQLiteDataReader sqlRead = cmd.ExecuteReader();

                    if (sqlRead.HasRows) // true is there are rows in table
                    {
                        sqlRead.Read(); // reads the rows
                        fullName = Convert.ToString(cmdFN.ExecuteScalar()); // stores full name
                        // edits the WelcomeLabel
                        WelcomeLabel.Text = string.Format("Welcome, {0}", fullName);
                    }

                    sqlRead.Close(); // close data reader
                    con.Close(); // close database
                }
            }
        }
    }
}
