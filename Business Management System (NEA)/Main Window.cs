using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Business_Management_System__NEA_
{
    public partial class StreamlineWindow : Form
    {
        public StreamlineWindow()
        {
            InitializeComponent();
        }

        LoadDatabase LDB = new LoadDatabase();
        FormOpener FO = new FormOpener();
        DatabaseConnection DBC = new DatabaseConnection();

        Dictionary<string, float> incomeData = new Dictionary<string, float>();
        Dictionary<string, float> expendData = new Dictionary<string, float>();

        private void TransactionsButton_Click(object sender, EventArgs e)
        {
            TransactionsGroupBox.Visible = true;
            EventGroupBox.Visible = false;
            ReportsGroupBox.Visible = false;
        }

        private void EventButton_Click(object sender, EventArgs e)
        {
            EventGroupBox.Visible = true;
            TransactionsGroupBox.Visible = false;
            ReportsGroupBox.Visible = false;
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            TransactionsGroupBox.Visible = false;
            EventGroupBox.Visible = false;
            ReportsGroupBox.Visible = true;
        }

        private void StreamlineWindow_Load(object sender, EventArgs e)
        {   // call storedLoad method from LoadDatabase class
            LDB.storedLoad("Income", IncomeData);
            LDB.storedLoad("Expenditure", ExpenditureData);
            LDB.storedLoad("Stock", StockData);
            LDB.storedLoad("Events", EventsData);

            DBC.getConnection();
            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database

                // INCOME CHART
                // select values from Date and Amount Recieved columns in Income table
                SQLiteCommand cmdI = new SQLiteCommand(@"SELECT Date, AmountRecievedin£ FROM Income", con);
                SQLiteDataReader SQLreadI = cmdI.ExecuteReader();
                Income Idata = new Income();
                
                while (SQLreadI.Read())
                {
                    Idata.Date = Convert.ToString(SQLreadI["Date"]); // store Date values in variable
                    Idata.AmountRecieved = Convert.ToInt32(SQLreadI["AmountRecievedin£"]); // store Amount Recieved values in variable
                    incomeData.Add(Idata.Date, Idata.AmountRecieved);

                };

                foreach (KeyValuePair<string, float> ID in incomeData)
                {   // ...add them as point in the chart
                    IncomeChart.Series["AmountRecieved"].Points.AddXY(ID.Key, ID.Value);
                }

                // EXPENDITURE CHART
                // select values from Date and Amount Recieved columns in Income table
                SQLiteCommand cmdE = new SQLiteCommand(@"SELECT Date, AmountSpentin£ FROM Expenditure", con);
                SQLiteDataReader SQLreadE = cmdE.ExecuteReader();
                Expenditure Edata = new Expenditure();

                while (SQLreadE.Read())
                {
                    Edata.Date = Convert.ToString(SQLreadE["Date"]); // store Date values in variable
                    Edata.AmountSpent = Convert.ToInt32(SQLreadE["AmountSpentin£"]); // store Amount Recieved values in variable
                    expendData.Add(Edata.Date, Edata.AmountSpent);
                };

                foreach (KeyValuePair<string, float> ED in expendData)
                {   // ...add them as point in the chart
                    ExpenditureChart.Series["AmountSpent"].Points.AddXY(ED.Key, ED.Value);
                }

                con.Close();
            }
        }

        private void IncomeAddButton_Click(object sender, EventArgs e)
        {
            Add_Income AI = new Add_Income();
            AI.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LDB.updatedLoad("Income", IncomeData); // calls updatedLoad function from LoadDatabase class
        }

        private void ExpenditureAdd_Click(object sender, EventArgs e)
        {
            Add_Expenditure AE = new Add_Expenditure();
            AE.Show();
        }

        private void ExpenditureRefresh_Click(object sender, EventArgs e)
        {
            LDB.updatedLoad("Expenditure", ExpenditureData); // calls updatedLoad function from LoadDatabase class
        }

        private void StockRefreshButton_Click(object sender, EventArgs e)
        {
            LDB.updatedLoad("Stock", StockData); // calls updatedLoad function from LoadDatabase class
        }

        private void AddStockButton_Click(object sender, EventArgs e)
        {
            Add_Stock AS = new Add_Stock();
            AS.Show();
        }

        private void SupplierButton_Click(object sender, EventArgs e)
        {
            Suppliers S = new Suppliers();
            S.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {            
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(FO.OpenLoginForm)); // create a new thread
            this.Close(); // close current form
            t.Start();  // start the thread
        }

        private void IncomeChartRefreshButton_Click(object sender, EventArgs e)
        {
            incomeData.Clear(); // clears the dictionary

            foreach (var series in IncomeChart.Series)
            {
                series.Points.Clear(); // removes each point in series
            }

            DBC.getConnVar("NEAdb.db");
            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // select values from Date and Amount Recieved columns in Income table
                SQLiteCommand cmdI = new SQLiteCommand(@"SELECT Date, AmountRecievedin£ FROM Income", con);
                SQLiteDataReader SQLreadI = cmdI.ExecuteReader();
                Income Idata = new Income(); // new object using income class

                while (SQLreadI.Read())
                {
                    Idata.Date = Convert.ToString(SQLreadI["Date"]); // store Date values in variable
                    Idata.AmountRecieved = Convert.ToInt32(SQLreadI["AmountRecievedin£"]); // store Amount Recieved values in variable
                    incomeData.Add(Idata.Date, Idata.AmountRecieved); // add values to dictionary

                };

                foreach (KeyValuePair<string, float> ID in incomeData)
                {   // ...add them as point in the chart
                    IncomeChart.Series["AmountRecieved"].Points.AddXY(ID.Key, ID.Value);
                }
                con.Close(); // close database
            }
        }

        private void ExpenditureChartRefreshButton_Click(object sender, EventArgs e)
        {
            expendData.Clear(); // clears the dictionary

            foreach (var series in ExpenditureChart.Series)
            {
                series.Points.Clear(); // removes each point in series
            }

            DBC.getConnVar("NEAdb.db");
            using (SQLiteConnection con = new SQLiteConnection(DBC.connectionString))
            {
                con.Open(); // open database
                // select values from Date and Amount Spent columns in Expenditure table
                SQLiteCommand cmdE = new SQLiteCommand(@"SELECT Date, AmountSpentin£ FROM Expenditure", con);
                SQLiteDataReader SQLreadE = cmdE.ExecuteReader();
                Expenditure Edata = new Expenditure(); // new object using Expenditure class

                while (SQLreadE.Read())
                {
                    Edata.Date = Convert.ToString(SQLreadE["Date"]); // store Date values in variable
                    Edata.AmountSpent = Convert.ToInt32(SQLreadE["AmountSpentin£"]); // store Amount Spent values in variable
                    expendData.Add(Edata.Date, Edata.AmountSpent); // adds values to dictionary
                };

                foreach (KeyValuePair<string, float> ED in expendData)
                {   // ...add them as point in the chart
                    ExpenditureChart.Series["AmountSpent"].Points.AddXY(ED.Key, ED.Value);
                }

                con.Close(); // close database
            }
        }

        private void RefreshEventButton_Click(object sender, EventArgs e)
        {
            LDB.updatedLoad("Events", EventsData); // calls updatedLoad function from LoadDatabase class
        }

        private void AEButton_Click(object sender, EventArgs e)
        {
            Add_Delete_Event ADE = new Add_Delete_Event();
            ADE.Show();
        }
    }
}

public class Income
{
    public string Date { get; set; }
    public float AmountRecieved { get; set; }
}

public class Expenditure
{
    public string Date { get; set; }
    public float AmountSpent { get; set; }
}