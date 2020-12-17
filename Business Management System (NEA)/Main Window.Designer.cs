namespace Business_Management_System__NEA_
{
    partial class StreamlineWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TransactionsButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.TransactionsGroupBox = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.IncomeData = new System.Windows.Forms.DataGridView();
            this.IncomeAddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ExpenditureRefresh = new System.Windows.Forms.Button();
            this.ExpenditureData = new System.Windows.Forms.DataGridView();
            this.ExpenditureAdd = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.StockRefreshButton = new System.Windows.Forms.Button();
            this.SupplierButton = new System.Windows.Forms.Button();
            this.StockData = new System.Windows.Forms.DataGridView();
            this.EventGroupBox = new System.Windows.Forms.GroupBox();
            this.EventsData = new System.Windows.Forms.DataGridView();
            this.RefreshEventButton = new System.Windows.Forms.Button();
            this.AEButton = new System.Windows.Forms.Button();
            this.ReportsGroupBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IncomeTab = new System.Windows.Forms.TabPage();
            this.IncomeChartRefreshButton = new System.Windows.Forms.Button();
            this.IncomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExpenditureTab = new System.Windows.Forms.TabPage();
            this.ExpenditureChartRefreshButton = new System.Windows.Forms.Button();
            this.ExpenditureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.EventButton = new System.Windows.Forms.Button();
            this.TransactionsGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockData)).BeginInit();
            this.EventGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventsData)).BeginInit();
            this.ReportsGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.IncomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).BeginInit();
            this.ExpenditureTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsButton
            // 
            this.TransactionsButton.Location = new System.Drawing.Point(12, 80);
            this.TransactionsButton.Name = "TransactionsButton";
            this.TransactionsButton.Size = new System.Drawing.Size(122, 62);
            this.TransactionsButton.TabIndex = 1;
            this.TransactionsButton.Text = "Transactions";
            this.TransactionsButton.UseVisualStyleBackColor = true;
            this.TransactionsButton.Click += new System.EventHandler(this.TransactionsButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(12, 148);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(122, 62);
            this.ReportsButton.TabIndex = 2;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // TransactionsGroupBox
            // 
            this.TransactionsGroupBox.Controls.Add(this.TabControl);
            this.TransactionsGroupBox.Location = new System.Drawing.Point(251, 12);
            this.TransactionsGroupBox.Name = "TransactionsGroupBox";
            this.TransactionsGroupBox.Size = new System.Drawing.Size(643, 426);
            this.TransactionsGroupBox.TabIndex = 0;
            this.TransactionsGroupBox.TabStop = false;
            this.TransactionsGroupBox.Text = "Transactions";
            this.TransactionsGroupBox.Visible = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(6, 19);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(631, 401);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RefreshButton);
            this.tabPage1.Controls.Add(this.IncomeData);
            this.tabPage1.Controls.Add(this.IncomeAddButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Income";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(495, 74);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(122, 62);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh Table";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // IncomeData
            // 
            this.IncomeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeData.Location = new System.Drawing.Point(6, 7);
            this.IncomeData.Name = "IncomeData";
            this.IncomeData.Size = new System.Drawing.Size(483, 362);
            this.IncomeData.TabIndex = 5;
            // 
            // IncomeAddButton
            // 
            this.IncomeAddButton.Location = new System.Drawing.Point(495, 6);
            this.IncomeAddButton.Name = "IncomeAddButton";
            this.IncomeAddButton.Size = new System.Drawing.Size(122, 62);
            this.IncomeAddButton.TabIndex = 4;
            this.IncomeAddButton.Text = "Add";
            this.IncomeAddButton.UseVisualStyleBackColor = true;
            this.IncomeAddButton.Click += new System.EventHandler(this.IncomeAddButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ExpenditureRefresh);
            this.tabPage2.Controls.Add(this.ExpenditureData);
            this.tabPage2.Controls.Add(this.ExpenditureAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expenditure";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ExpenditureRefresh
            // 
            this.ExpenditureRefresh.Location = new System.Drawing.Point(495, 74);
            this.ExpenditureRefresh.Name = "ExpenditureRefresh";
            this.ExpenditureRefresh.Size = new System.Drawing.Size(122, 62);
            this.ExpenditureRefresh.TabIndex = 9;
            this.ExpenditureRefresh.Text = "Refresh Table";
            this.ExpenditureRefresh.UseVisualStyleBackColor = true;
            this.ExpenditureRefresh.Click += new System.EventHandler(this.ExpenditureRefresh_Click);
            // 
            // ExpenditureData
            // 
            this.ExpenditureData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpenditureData.Location = new System.Drawing.Point(6, 7);
            this.ExpenditureData.Name = "ExpenditureData";
            this.ExpenditureData.Size = new System.Drawing.Size(483, 362);
            this.ExpenditureData.TabIndex = 8;
            // 
            // ExpenditureAdd
            // 
            this.ExpenditureAdd.Location = new System.Drawing.Point(495, 6);
            this.ExpenditureAdd.Name = "ExpenditureAdd";
            this.ExpenditureAdd.Size = new System.Drawing.Size(122, 62);
            this.ExpenditureAdd.TabIndex = 7;
            this.ExpenditureAdd.Text = "Add";
            this.ExpenditureAdd.UseVisualStyleBackColor = true;
            this.ExpenditureAdd.Click += new System.EventHandler(this.ExpenditureAdd_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.AddStockButton);
            this.tabPage3.Controls.Add(this.StockRefreshButton);
            this.tabPage3.Controls.Add(this.SupplierButton);
            this.tabPage3.Controls.Add(this.StockData);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(623, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stock";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AddStockButton
            // 
            this.AddStockButton.Location = new System.Drawing.Point(495, 7);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(122, 62);
            this.AddStockButton.TabIndex = 15;
            this.AddStockButton.Text = "Add Stock Data";
            this.AddStockButton.UseVisualStyleBackColor = true;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click);
            // 
            // StockRefreshButton
            // 
            this.StockRefreshButton.Location = new System.Drawing.Point(495, 143);
            this.StockRefreshButton.Name = "StockRefreshButton";
            this.StockRefreshButton.Size = new System.Drawing.Size(122, 62);
            this.StockRefreshButton.TabIndex = 14;
            this.StockRefreshButton.Text = "Refresh Table";
            this.StockRefreshButton.UseVisualStyleBackColor = true;
            this.StockRefreshButton.Click += new System.EventHandler(this.StockRefreshButton_Click);
            // 
            // SupplierButton
            // 
            this.SupplierButton.Location = new System.Drawing.Point(495, 75);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(122, 62);
            this.SupplierButton.TabIndex = 12;
            this.SupplierButton.Text = "Supplier Table";
            this.SupplierButton.UseVisualStyleBackColor = true;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // StockData
            // 
            this.StockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockData.Location = new System.Drawing.Point(6, 7);
            this.StockData.Name = "StockData";
            this.StockData.Size = new System.Drawing.Size(483, 362);
            this.StockData.TabIndex = 11;
            // 
            // EventGroupBox
            // 
            this.EventGroupBox.Controls.Add(this.EventsData);
            this.EventGroupBox.Controls.Add(this.RefreshEventButton);
            this.EventGroupBox.Controls.Add(this.AEButton);
            this.EventGroupBox.Location = new System.Drawing.Point(251, 12);
            this.EventGroupBox.Name = "EventGroupBox";
            this.EventGroupBox.Size = new System.Drawing.Size(643, 426);
            this.EventGroupBox.TabIndex = 0;
            this.EventGroupBox.TabStop = false;
            this.EventGroupBox.Text = "Events";
            // 
            // EventsData
            // 
            this.EventsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsData.Location = new System.Drawing.Point(9, 19);
            this.EventsData.Name = "EventsData";
            this.EventsData.Size = new System.Drawing.Size(490, 397);
            this.EventsData.TabIndex = 8;
            // 
            // RefreshEventButton
            // 
            this.RefreshEventButton.Location = new System.Drawing.Point(511, 87);
            this.RefreshEventButton.Name = "RefreshEventButton";
            this.RefreshEventButton.Size = new System.Drawing.Size(122, 62);
            this.RefreshEventButton.TabIndex = 7;
            this.RefreshEventButton.Text = "Refresh";
            this.RefreshEventButton.UseVisualStyleBackColor = true;
            this.RefreshEventButton.Click += new System.EventHandler(this.RefreshEventButton_Click);
            // 
            // AEButton
            // 
            this.AEButton.Location = new System.Drawing.Point(511, 19);
            this.AEButton.Name = "AEButton";
            this.AEButton.Size = new System.Drawing.Size(122, 62);
            this.AEButton.TabIndex = 6;
            this.AEButton.Text = "Add/Delete Event";
            this.AEButton.UseVisualStyleBackColor = true;
            this.AEButton.Click += new System.EventHandler(this.AEButton_Click);
            // 
            // ReportsGroupBox
            // 
            this.ReportsGroupBox.Controls.Add(this.tabControl1);
            this.ReportsGroupBox.Location = new System.Drawing.Point(251, 12);
            this.ReportsGroupBox.Name = "ReportsGroupBox";
            this.ReportsGroupBox.Size = new System.Drawing.Size(643, 426);
            this.ReportsGroupBox.TabIndex = 1;
            this.ReportsGroupBox.TabStop = false;
            this.ReportsGroupBox.Text = "Reports";
            this.ReportsGroupBox.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IncomeTab);
            this.tabControl1.Controls.Add(this.ExpenditureTab);
            this.tabControl1.Location = new System.Drawing.Point(10, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // IncomeTab
            // 
            this.IncomeTab.Controls.Add(this.IncomeChartRefreshButton);
            this.IncomeTab.Controls.Add(this.IncomeChart);
            this.IncomeTab.Location = new System.Drawing.Point(4, 22);
            this.IncomeTab.Name = "IncomeTab";
            this.IncomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.IncomeTab.Size = new System.Drawing.Size(619, 375);
            this.IncomeTab.TabIndex = 0;
            this.IncomeTab.Text = "Income";
            this.IncomeTab.UseVisualStyleBackColor = true;
            // 
            // IncomeChartRefreshButton
            // 
            this.IncomeChartRefreshButton.Location = new System.Drawing.Point(465, 269);
            this.IncomeChartRefreshButton.Name = "IncomeChartRefreshButton";
            this.IncomeChartRefreshButton.Size = new System.Drawing.Size(122, 62);
            this.IncomeChartRefreshButton.TabIndex = 5;
            this.IncomeChartRefreshButton.Text = "Refresh Chart";
            this.IncomeChartRefreshButton.UseVisualStyleBackColor = true;
            this.IncomeChartRefreshButton.Click += new System.EventHandler(this.IncomeChartRefreshButton_Click);
            // 
            // IncomeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.IncomeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.IncomeChart.Legends.Add(legend1);
            this.IncomeChart.Location = new System.Drawing.Point(6, 6);
            this.IncomeChart.Name = "IncomeChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "AmountRecieved";
            this.IncomeChart.Series.Add(series1);
            this.IncomeChart.Size = new System.Drawing.Size(607, 363);
            this.IncomeChart.TabIndex = 0;
            this.IncomeChart.Text = "Income Chart";
            // 
            // ExpenditureTab
            // 
            this.ExpenditureTab.Controls.Add(this.ExpenditureChartRefreshButton);
            this.ExpenditureTab.Controls.Add(this.ExpenditureChart);
            this.ExpenditureTab.Location = new System.Drawing.Point(4, 22);
            this.ExpenditureTab.Name = "ExpenditureTab";
            this.ExpenditureTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExpenditureTab.Size = new System.Drawing.Size(619, 375);
            this.ExpenditureTab.TabIndex = 1;
            this.ExpenditureTab.Text = "Expenditure";
            this.ExpenditureTab.UseVisualStyleBackColor = true;
            // 
            // ExpenditureChartRefreshButton
            // 
            this.ExpenditureChartRefreshButton.Location = new System.Drawing.Point(478, 269);
            this.ExpenditureChartRefreshButton.Name = "ExpenditureChartRefreshButton";
            this.ExpenditureChartRefreshButton.Size = new System.Drawing.Size(122, 62);
            this.ExpenditureChartRefreshButton.TabIndex = 7;
            this.ExpenditureChartRefreshButton.Text = "Refresh Chart";
            this.ExpenditureChartRefreshButton.UseVisualStyleBackColor = true;
            this.ExpenditureChartRefreshButton.Click += new System.EventHandler(this.ExpenditureChartRefreshButton_Click);
            // 
            // ExpenditureChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ExpenditureChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ExpenditureChart.Legends.Add(legend2);
            this.ExpenditureChart.Location = new System.Drawing.Point(6, 6);
            this.ExpenditureChart.Name = "ExpenditureChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "AmountSpent";
            this.ExpenditureChart.Series.Add(series2);
            this.ExpenditureChart.Size = new System.Drawing.Size(607, 363);
            this.ExpenditureChart.TabIndex = 6;
            this.ExpenditureChart.Text = "Expenditure Chart";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 396);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(227, 42);
            this.LogoutButton.TabIndex = 4;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 222);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // EventButton
            // 
            this.EventButton.Location = new System.Drawing.Point(12, 12);
            this.EventButton.Name = "EventButton";
            this.EventButton.Size = new System.Drawing.Size(122, 62);
            this.EventButton.TabIndex = 0;
            this.EventButton.Text = "Events";
            this.EventButton.UseVisualStyleBackColor = true;
            this.EventButton.Click += new System.EventHandler(this.EventButton_Click);
            // 
            // StreamlineWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.TransactionsButton);
            this.Controls.Add(this.EventButton);
            this.Controls.Add(this.EventGroupBox);
            this.Controls.Add(this.TransactionsGroupBox);
            this.Controls.Add(this.ReportsGroupBox);
            this.Name = "StreamlineWindow";
            this.Text = "Streamline";
            this.Load += new System.EventHandler(this.StreamlineWindow_Load);
            this.TransactionsGroupBox.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockData)).EndInit();
            this.EventGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventsData)).EndInit();
            this.ReportsGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.IncomeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeChart)).EndInit();
            this.ExpenditureTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenditureChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TransactionsButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.GroupBox TransactionsGroupBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox ReportsGroupBox;
        private System.Windows.Forms.GroupBox EventGroupBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView IncomeData;
        private System.Windows.Forms.Button IncomeAddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button ExpenditureRefresh;
        private System.Windows.Forms.DataGridView ExpenditureData;
        private System.Windows.Forms.Button ExpenditureAdd;
        private System.Windows.Forms.Button StockRefreshButton;
        private System.Windows.Forms.Button SupplierButton;
        private System.Windows.Forms.DataGridView StockData;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage IncomeTab;
        private System.Windows.Forms.Button IncomeChartRefreshButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeChart;
        private System.Windows.Forms.TabPage ExpenditureTab;
        private System.Windows.Forms.Button ExpenditureChartRefreshButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenditureChart;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button EventButton;
        private System.Windows.Forms.Button RefreshEventButton;
        private System.Windows.Forms.Button AEButton;
        private System.Windows.Forms.DataGridView EventsData;
    }
}