using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Business_Management_System__NEA_
{
    class LoadDatabase
    {
        DatabaseConnection DBC = new DatabaseConnection();

        public void storedLoad(string tableName, DataGridView DGVname)
        {
            DBC.getConnection();
            
            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database

                try
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT * FROM {tableName}", con);
                    System.Data.DataSet ds = new System.Data.DataSet();

                    da.Fill(ds);
                    DGVname.DataSource = ds.Tables[0];
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close(); // close database
            }
        }

        public void updatedLoad(string tableName, DataGridView DGVname)
        {
            // connects to the .db that is updated with new data
            DBC.getConnVar("NEAdb.db");
            
            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database

                try
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter($"SELECT * FROM {tableName}", con);
                    System.Data.DataSet ds = new System.Data.DataSet();

                    da.Fill(ds);
                    DGVname.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close(); // close database
            }
        }
    }
}


