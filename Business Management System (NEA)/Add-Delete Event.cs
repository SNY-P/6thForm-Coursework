using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Business_Management_System__NEA_
{
    public partial class Add_Delete_Event : Form
    {
        public Add_Delete_Event()
        {
            InitializeComponent();
        }

        DatabaseConnection DBC = new DatabaseConnection();

        private void AddMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            AddDateTextBox.Text = AddMonthCalendar.SelectionStart.ToString(); // changes text to selected date
        }

        private void DeleteMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DeleteDateTextBox.Text = DeleteMonthCalendar.SelectionStart.ToString(); // changes text to selected date
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DBC.getConnection(); // call getConnection function from DatabaseConnection class

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // insert data into Events table
                SQLiteCommand cmd = new SQLiteCommand(@"INSERT INTO Events(EventName, EventDate, Details) VALUES (@EN, @ED, @EDetails)", con);
                cmd.Parameters.AddWithValue("@EN", AddEventTextBox.Text);
                cmd.Parameters.AddWithValue("@ED", AddDateTextBox.Text);
                cmd.Parameters.AddWithValue("@EDetails", AddDetailsTextBox.Text);
                cmd.ExecuteNonQuery();

                con.Close(); // close database
                MessageBox.Show("Event has been added");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DBC.getConnection(); // call getConnection function from DatabaseConnection class

            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database

                SQLiteCommand cmdCheck = new SQLiteCommand(@"SELECT EventDate, EventName FROM Events WHERE EventDate=@d AND EventName=@e", con);
                cmdCheck.Parameters.AddWithValue("@d", DeleteDateTextBox.Text);
                cmdCheck.Parameters.AddWithValue("@e", DeleteEventTextBox.Text);

                SQLiteDataReader rd = cmdCheck.ExecuteReader();

                int i = 0;
                while (rd.Read())
                {
                    i++; // date & name is in table, i will increment
                }

                if (i == 0) // date & name is not stored in database
                {
                    MessageBox.Show("That event is not in the table. Please select a valid date and/or event name.");
                }
                else // date & name is stored in database
                {
                    // delete data from Events table
                    SQLiteCommand cmd = new SQLiteCommand(@"DELETE FROM Events WHERE EventDate=@dte AND EventName=@EN", con);
                    cmd.Parameters.AddWithValue("@dte", DeleteDateTextBox.Text);
                    cmd.Parameters.AddWithValue("@EN", DeleteEventTextBox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Event has been deleted");
                }
                              
                con.Close(); // close database
            }
        }
    }
}
