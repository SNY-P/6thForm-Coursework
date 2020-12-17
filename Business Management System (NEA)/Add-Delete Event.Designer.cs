namespace Business_Management_System__NEA_
{
    partial class Add_Delete_Event
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
            this.AddMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddDetailsTextBox = new System.Windows.Forms.TextBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.AddEventTextBox = new System.Windows.Forms.TextBox();
            this.AmountSpentLabel = new System.Windows.Forms.Label();
            this.AddDateTextBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AddEventGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteEvent = new System.Windows.Forms.GroupBox();
            this.DeleteMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteDateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeleteEventTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEventGroupBox.SuspendLayout();
            this.DeleteEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddMonthCalendar
            // 
            this.AddMonthCalendar.Location = new System.Drawing.Point(46, 25);
            this.AddMonthCalendar.Name = "AddMonthCalendar";
            this.AddMonthCalendar.TabIndex = 0;
            this.AddMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AddMonthCalendar_DateChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(46, 402);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(227, 58);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Add Event";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddDetailsTextBox
            // 
            this.AddDetailsTextBox.Location = new System.Drawing.Point(6, 365);
            this.AddDetailsTextBox.Name = "AddDetailsTextBox";
            this.AddDetailsTextBox.Size = new System.Drawing.Size(305, 20);
            this.AddDetailsTextBox.TabIndex = 27;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(6, 337);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(199, 25);
            this.PaymentMethodLabel.TabIndex = 26;
            this.PaymentMethodLabel.Text = "Add the Event Details";
            // 
            // AddEventTextBox
            // 
            this.AddEventTextBox.Location = new System.Drawing.Point(6, 298);
            this.AddEventTextBox.Name = "AddEventTextBox";
            this.AddEventTextBox.Size = new System.Drawing.Size(305, 20);
            this.AddEventTextBox.TabIndex = 25;
            // 
            // AmountSpentLabel
            // 
            this.AmountSpentLabel.AutoSize = true;
            this.AmountSpentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSpentLabel.Location = new System.Drawing.Point(6, 270);
            this.AmountSpentLabel.Name = "AmountSpentLabel";
            this.AmountSpentLabel.Size = new System.Drawing.Size(160, 25);
            this.AmountSpentLabel.TabIndex = 24;
            this.AmountSpentLabel.Text = "Add Event Name";
            // 
            // AddDateTextBox
            // 
            this.AddDateTextBox.Location = new System.Drawing.Point(6, 235);
            this.AddDateTextBox.Name = "AddDateTextBox";
            this.AddDateTextBox.Size = new System.Drawing.Size(305, 20);
            this.AddDateTextBox.TabIndex = 23;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(4, 207);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(312, 25);
            this.DateLabel.TabIndex = 22;
            this.DateLabel.Text = "Select Date using Calendar Above";
            // 
            // AddEventGroupBox
            // 
            this.AddEventGroupBox.Controls.Add(this.AddMonthCalendar);
            this.AddEventGroupBox.Controls.Add(this.AddButton);
            this.AddEventGroupBox.Controls.Add(this.DateLabel);
            this.AddEventGroupBox.Controls.Add(this.AddDetailsTextBox);
            this.AddEventGroupBox.Controls.Add(this.AddDateTextBox);
            this.AddEventGroupBox.Controls.Add(this.PaymentMethodLabel);
            this.AddEventGroupBox.Controls.Add(this.AmountSpentLabel);
            this.AddEventGroupBox.Controls.Add(this.AddEventTextBox);
            this.AddEventGroupBox.Location = new System.Drawing.Point(12, 19);
            this.AddEventGroupBox.Name = "AddEventGroupBox";
            this.AddEventGroupBox.Size = new System.Drawing.Size(322, 477);
            this.AddEventGroupBox.TabIndex = 29;
            this.AddEventGroupBox.TabStop = false;
            this.AddEventGroupBox.Text = "Add Event";
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Controls.Add(this.label1);
            this.DeleteEvent.Controls.Add(this.DeleteMonthCalendar);
            this.DeleteEvent.Controls.Add(this.DeleteButton);
            this.DeleteEvent.Controls.Add(this.DeleteDateTextBox);
            this.DeleteEvent.Controls.Add(this.label3);
            this.DeleteEvent.Controls.Add(this.DeleteEventTextBox);
            this.DeleteEvent.Location = new System.Drawing.Point(351, 19);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(322, 477);
            this.DeleteEvent.TabIndex = 30;
            this.DeleteEvent.TabStop = false;
            this.DeleteEvent.Text = "Delete Event";
            // 
            // DeleteMonthCalendar
            // 
            this.DeleteMonthCalendar.Location = new System.Drawing.Point(46, 25);
            this.DeleteMonthCalendar.Name = "DeleteMonthCalendar";
            this.DeleteMonthCalendar.TabIndex = 0;
            this.DeleteMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DeleteMonthCalendar_DateChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(46, 341);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(227, 58);
            this.DeleteButton.TabIndex = 28;
            this.DeleteButton.Text = "Delete Event";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteDateTextBox
            // 
            this.DeleteDateTextBox.Location = new System.Drawing.Point(9, 235);
            this.DeleteDateTextBox.Name = "DeleteDateTextBox";
            this.DeleteDateTextBox.Size = new System.Drawing.Size(307, 20);
            this.DeleteDateTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Enter Event Name";
            // 
            // DeleteEventTextBox
            // 
            this.DeleteEventTextBox.Location = new System.Drawing.Point(9, 298);
            this.DeleteEventTextBox.Name = "DeleteEventTextBox";
            this.DeleteEventTextBox.Size = new System.Drawing.Size(307, 20);
            this.DeleteEventTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select Date using Calendar Above";
            // 
            // Add_Delete_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 508);
            this.Controls.Add(this.DeleteEvent);
            this.Controls.Add(this.AddEventGroupBox);
            this.Name = "Add_Delete_Event";
            this.Text = "Add/Delete Event";
            this.AddEventGroupBox.ResumeLayout(false);
            this.AddEventGroupBox.PerformLayout();
            this.DeleteEvent.ResumeLayout(false);
            this.DeleteEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar AddMonthCalendar;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddDetailsTextBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.TextBox AddEventTextBox;
        private System.Windows.Forms.Label AmountSpentLabel;
        private System.Windows.Forms.TextBox AddDateTextBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.GroupBox AddEventGroupBox;
        private System.Windows.Forms.GroupBox DeleteEvent;
        private System.Windows.Forms.MonthCalendar DeleteMonthCalendar;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DeleteDateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DeleteEventTextBox;
        private System.Windows.Forms.Label label1;
    }
}