namespace Business_Management_System__NEA_
{
    partial class Add_Expenditure
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
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.PaymentMethodTextBox = new System.Windows.Forms.TextBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.AmountSpentTextBox = new System.Windows.Forms.TextBox();
            this.AmountSpentLabel = new System.Windows.Forms.Label();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(12, 343);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(361, 58);
            this.AddButton.TabIndex = 21;
            this.AddButton.Text = "Add Details";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ToTextBox
            // 
            this.ToTextBox.Location = new System.Drawing.Point(12, 307);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(361, 20);
            this.ToTextBox.TabIndex = 20;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(12, 279);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(183, 25);
            this.ToLabel.TabIndex = 19;
            this.ToLabel.Text = "Who did you Pay? :";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 237);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(361, 20);
            this.DescriptionTextBox.TabIndex = 18;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 209);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(259, 25);
            this.DescriptionLabel.TabIndex = 17;
            this.DescriptionLabel.Text = "Add a Description (optional):";
            // 
            // PaymentMethodTextBox
            // 
            this.PaymentMethodTextBox.Location = new System.Drawing.Point(12, 172);
            this.PaymentMethodTextBox.Name = "PaymentMethodTextBox";
            this.PaymentMethodTextBox.Size = new System.Drawing.Size(361, 20);
            this.PaymentMethodTextBox.TabIndex = 16;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(12, 144);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(239, 25);
            this.PaymentMethodLabel.TabIndex = 15;
            this.PaymentMethodLabel.Text = "Add the Payment Method:";
            // 
            // AmountSpentTextBox
            // 
            this.AmountSpentTextBox.Location = new System.Drawing.Point(12, 105);
            this.AmountSpentTextBox.Name = "AmountSpentTextBox";
            this.AmountSpentTextBox.Size = new System.Drawing.Size(361, 20);
            this.AmountSpentTextBox.TabIndex = 14;
            // 
            // AmountSpentLabel
            // 
            this.AmountSpentLabel.AutoSize = true;
            this.AmountSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSpentLabel.Location = new System.Drawing.Point(12, 77);
            this.AmountSpentLabel.Name = "AmountSpentLabel";
            this.AmountSpentLabel.Size = new System.Drawing.Size(295, 25);
            this.AmountSpentLabel.TabIndex = 13;
            this.AmountSpentLabel.Text = "Add the Amount Spent (£00.00):";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(12, 42);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(361, 20);
            this.DateTextBox.TabIndex = 12;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 14);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(225, 25);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Add Date (dd/mm/yyyy):";
            // 
            // Add_Expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 418);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ToTextBox);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PaymentMethodTextBox);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.AmountSpentTextBox);
            this.Controls.Add(this.AmountSpentLabel);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.DateLabel);
            this.Name = "Add_Expenditure";
            this.Text = "Add Expenditure Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox PaymentMethodTextBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.TextBox AmountSpentTextBox;
        private System.Windows.Forms.Label AmountSpentLabel;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label DateLabel;
    }
}