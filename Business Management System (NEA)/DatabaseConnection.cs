using System.IO;
using System.Data.SQLite;
using System.Reflection;

namespace Business_Management_System__NEA_
{
    public class DatabaseConnection
    {
        public string connectionString { get; set; }
        
        public virtual void getConnection()
        {
            string connection = @"DataSource=NEAdb.db; Version=3"; // connection to .db file
            connectionString = connection;
        }

        public void getConnVar(string source)
        {
            string executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string dbLocation = Path.Combine(executableLocation, source);
            string connection = @"DataSource='" + dbLocation + "'; Version=3";
            connectionString = connection;
        }

        public void createDatabase()
        {
            if (!File.Exists("NEA.db"))  // checks if .db file doesn't exists
            {
                File.Create("NEA.db"); // create .db file

                getConnection();
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open(); // opens .db file
                    SQLiteCommand cmd1 = new SQLiteCommand // create UserInfo table
                    {
                        CommandText = @"CREATE TABLE UserInfo (InfoID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, FullName TEXT NOT NULL)",
                        Connection = con
                    };
                    cmd1.ExecuteNonQuery();

                    SQLiteCommand cmd2 = new SQLiteCommand // create LoginInfo table
                    {
                        CommandText = @"CREATE TABLE LoginInfo (LoginID INTERGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
                                                                Username TEXT NOT NULL,
                                                                Password TEXT NOT NULL
                                                                InfoID INTEGER UNIQUE
                                                                FOREIGN KEY(InfoID) REFERENCES UserInfo(InfoID))",
                        Connection = con
                    };
                    cmd2.ExecuteNonQuery();

                    SQLiteCommand cmd3 = new SQLiteCommand // create Income table
                    {
                        CommandText = @"CREATE TABLE Income (IncomeID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, 
                                                             Date TEXT NOT NULL,
	                                                         AmountRecievedin£ REAL NOT NULL,
	                                                         PaymentMethod TEXT NOT NULL,
	                                                         Description TEXT,
	                                                         FromWho TEXT NOT NULL)",
                        Connection = con
                    };
                    cmd3.ExecuteNonQuery();

                    SQLiteCommand cmd4 = new SQLiteCommand // create Expenditure table
                    {
                        CommandText = @"CREATE TABLE Expenditure (ExpenditureID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                                              Date TEXT NOT NULL,
	                                                              AmountSpentin£ REAL NOT NULL,
	                                                              PaymentMethod TEXT NOT NULL,
	                                                              Description TEXT,
	                                                              ToWho TEXT NOT NULL)",
                        Connection = con
                    };
                    cmd4.ExecuteNonQuery();

                    SQLiteCommand cmd5 = new SQLiteCommand // create Supplier table
                    {
                        CommandText = @"CREATE TABLE Supplier (SupplierID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                                           Name TEXT NOT NULL UNIQUE,
	                                                           Address TEXT NOT NULL UNIQUE,
	                                                           ContactNumber INTEGER NOT NULL UNIQUE)",
                        Connection = con
                    };
                    cmd5.ExecuteNonQuery();

                    SQLiteCommand cmd6 = new SQLiteCommand // create Stock table
                    {
                        CommandText = @"CREATE TABLE Stock (StockID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                                        ItemName TEXT NOT NULL,
	                                                        AmountInStock INTEGER NOT NULL,
	                                                        DataLastUpdated	TEXT NOT NULL,
	                                                        SupplierID INTEGER,
	                                                        FOREIGN KEY(SupplierID) REFERENCES Supplier(SupplierID))",
                        Connection = con
                    };
                    cmd6.ExecuteNonQuery();

                    SQLiteCommand cmd7 = new SQLiteCommand // create Events table
                    {
                        CommandText = @"CREATE TABLE Events (EventID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	                                                         EventName TEXT NOT NULL,
	                                                         EventDate TEXT NOT NULL,
	                                                         Details TEXT NOT NULL)",
                        Connection = con
                    };
                    cmd7.ExecuteNonQuery();

                    con.Close(); // close database
                }
            }
            else // if file exist then nothing would happen
            {
                return;
            }
        }
    }
}
