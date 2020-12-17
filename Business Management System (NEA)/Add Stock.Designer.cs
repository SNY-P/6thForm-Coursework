namespace Business_Management_System__NEA_
{
    partial class Add_Stock
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
            this.AddButton = new System.Windows.Forms.Button();
            this.SupplierNameTextBox = new System.Windows.Forms.TextBox();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.AmountInStkTextBox = new System.Windows.Forms.TextBox();
            this.inStockLabel = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 301);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(328, 58);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add Details";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SupplierNameTextBox
            // 
            this.SupplierNameTextBox.Location = new System.Drawing.Point(12, 185);
            this.SupplierNameTextBox.Name = "SupplierNameTextBox";
            this.SupplierNameTextBox.Size = new System.Drawing.Size(238, 20);
            this.SupplierNameTextBox.TabIndex = 31;
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.Location = new System.Drawing.Point(12, 157);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(204, 25);
            this.SupplierNameLabel.TabIndex = 30;
            this.SupplierNameLabel.Text = "Who is the Supplier? :";
            // 
            // AmountInStkTextBox
            // 
            this.AmountInStkTextBox.Location = new System.Drawing.Point(12, 113);
            this.AmountInStkTextBox.Name = "AmountInStkTextBox";
            this.AmountInStkTextBox.Size = new System.Drawing.Size(328, 20);
            this.AmountInStkTextBox.TabIndex = 27;
            // 
            // inStockLabel
            // 
            this.inStockLabel.AutoSize = true;
            this.inStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inStockLabel.Location = new System.Drawing.Point(12, 85);
            this.inStockLabel.Name = "inStockLabel";
            this.inStockLabel.Size = new System.Drawing.Size(318, 25);
            this.inStockLabel.TabIndex = 26;
            this.inStockLabel.Text = "Add the Amount in Stock Currently:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(12, 42);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(328, 20);
            this.ItemNameTextBox.TabIndex = 23;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(12, 14);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(238, 25);
            this.ItemNameLabel.TabIndex = 22;
            this.ItemNameLabel.Text = "Add the Name of the Item:";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(12, 256);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(328, 20);
            this.DateTextBox.TabIndex = 34;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 228);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(160, 25);
            this.DateLabel.TabIndex = 33;
            this.DateLabel.Text = "The Date Today:";
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(256, 185);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(85, 20);
            this.NextButton.TabIndex = 35;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Add_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 380);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SupplierNameTextBox);
            this.Controls.Add(this.SupplierNameLabel);
            this.Controls.Add(this.AmountInStkTextBox);
            this.Controls.Add(this.inStockLabel);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.ItemNameLabel);
            this.Name = "Add_Stock";
            this.Text = "Add Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TextBox AmountInStkTextBox;
        private System.Windows.Forms.Label inStockLabel;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button NextButton;
        public System.Windows.Forms.TextBox SupplierNameTextBox;
    }
}