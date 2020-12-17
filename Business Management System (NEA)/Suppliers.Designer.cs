namespace Business_Management_System__NEA_
{
    partial class Suppliers
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
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.SupplierData = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.AmountSpentLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierData)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.Location = new System.Drawing.Point(501, 252);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(139, 62);
            this.AddSupplierButton.TabIndex = 18;
            this.AddSupplierButton.Text = "Add Supplier Details";
            this.AddSupplierButton.UseVisualStyleBackColor = true;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // SupplierData
            // 
            this.SupplierData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierData.Location = new System.Drawing.Point(12, 12);
            this.SupplierData.Name = "SupplierData";
            this.SupplierData.Size = new System.Drawing.Size(483, 302);
            this.SupplierData.TabIndex = 17;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(640, 252);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(139, 62);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh Table";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ContactNumberTextBox
            // 
            this.ContactNumberTextBox.Location = new System.Drawing.Point(501, 211);
            this.ContactNumberTextBox.Name = "ContactNumberTextBox";
            this.ContactNumberTextBox.Size = new System.Drawing.Size(277, 20);
            this.ContactNumberTextBox.TabIndex = 25;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(501, 183);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(278, 25);
            this.DescriptionLabel.TabIndex = 24;
            this.DescriptionLabel.Text = "Add Supplier Contact Number:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(501, 146);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(277, 20);
            this.AddressTextBox.TabIndex = 23;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(501, 118);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(209, 25);
            this.PaymentMethodLabel.TabIndex = 22;
            this.PaymentMethodLabel.Text = "Add Supplier Address:";
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Location = new System.Drawing.Point(501, 79);
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(277, 20);
            this.SupplierNameTextBox.TabIndex = 21;
            // 
            // AmountSpentLabel
            // 
            this.AmountSpentLabel.AutoSize = true;
            this.AmountSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSpentLabel.Location = new System.Drawing.Point(501, 51);
            this.AmountSpentLabel.Name = "AmountSpentLabel";
            this.AmountSpentLabel.Size = new System.Drawing.Size(188, 25);
            this.AmountSpentLabel.TabIndex = 20;
            this.AmountSpentLabel.Text = "Add Supplier Name:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(501, 12);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(226, 25);
            this.DateLabel.TabIndex = 19;
            this.DateLabel.Text = "Add Supplier Information";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 325);
            this.Controls.Add(this.ContactNumberTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.SupplierNameTextBox);
            this.Controls.Add(this.AmountSpentLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddSupplierButton);
            this.Controls.Add(this.SupplierData);
            this.Controls.Add(this.RefreshButton);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.DataGridView SupplierData;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox ContactNumberTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.TextBox SupplierNameTextBox;
        private System.Windows.Forms.Label AmountSpentLabel;
        private System.Windows.Forms.Label DateLabel;
    }
}