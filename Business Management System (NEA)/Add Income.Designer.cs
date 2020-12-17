namespace Business_Management_System__NEA_
{
    partial class Add_Income
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
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.AmountRecievedTextBox = new System.Windows.Forms.TextBox();
            this.AmountRecievedLabel = new System.Windows.Forms.Label();
            this.PaymentMethodTextBox = new System.Windows.Forms.TextBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.FromLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 26);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(225, 25);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Add Date (dd/mm/yyyy):";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(12, 54);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(361, 20);
            this.DateTextBox.TabIndex = 1;
            // 
            // AmountRecievedTextBox
            // 
            this.AmountRecievedTextBox.Location = new System.Drawing.Point(12, 117);
            this.AmountRecievedTextBox.Name = "AmountRecievedTextBox";
            this.AmountRecievedTextBox.Size = new System.Drawing.Size(361, 20);
            this.AmountRecievedTextBox.TabIndex = 3;
            // 
            // AmountRecievedLabel
            // 
            this.AmountRecievedLabel.AutoSize = true;
            this.AmountRecievedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountRecievedLabel.Location = new System.Drawing.Point(12, 89);
            this.AmountRecievedLabel.Name = "AmountRecievedLabel";
            this.AmountRecievedLabel.Size = new System.Drawing.Size(324, 25);
            this.AmountRecievedLabel.TabIndex = 2;
            this.AmountRecievedLabel.Text = "Add the Amount Recieved (£00.00):";
            // 
            // PaymentMethodTextBox
            // 
            this.PaymentMethodTextBox.Location = new System.Drawing.Point(12, 184);
            this.PaymentMethodTextBox.Name = "PaymentMethodTextBox";
            this.PaymentMethodTextBox.Size = new System.Drawing.Size(361, 20);
            this.PaymentMethodTextBox.TabIndex = 5;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(12, 156);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(239, 25);
            this.PaymentMethodLabel.TabIndex = 4;
            this.PaymentMethodLabel.Text = "Add the Payment Method:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 249);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(361, 20);
            this.DescriptionTextBox.TabIndex = 7;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 221);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(259, 25);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Add a Description (optional):";
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(12, 319);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(361, 20);
            this.FromTextBox.TabIndex = 9;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(12, 291);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(152, 25);
            this.FromLabel.TabIndex = 8;
            this.FromLabel.Text = "Who is it from? :";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 355);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(361, 58);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add Details";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Add_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 425);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PaymentMethodTextBox);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.AmountRecievedTextBox);
            this.Controls.Add(this.AmountRecievedLabel);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DateLabel);
            this.Name = "Add_Income";
            this.Text = "Add Income Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox AmountRecievedTextBox;
        private System.Windows.Forms.Label AmountRecievedLabel;
        private System.Windows.Forms.TextBox PaymentMethodTextBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Button AddButton;
    }
}