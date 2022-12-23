namespace MyCalendar
{
    partial class FormEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxStartTime = new System.Windows.Forms.DateTimePicker();
            this.TextBoxStopTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxStopDate = new System.Windows.Forms.DateTimePicker();
            this.CheckBoxAllDay = new System.Windows.Forms.CheckBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(12, 29);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(460, 25);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Location = new System.Drawing.Point(12, 77);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.Size = new System.Drawing.Size(460, 132);
            this.TextBoxDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Event Description";
            // 
            // TextBoxStartDate
            // 
            this.TextBoxStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TextBoxStartDate.Location = new System.Drawing.Point(12, 232);
            this.TextBoxStartDate.Name = "TextBoxStartDate";
            this.TextBoxStartDate.Size = new System.Drawing.Size(117, 25);
            this.TextBoxStartDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start";
            // 
            // TextBoxStartTime
            // 
            this.TextBoxStartTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TextBoxStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TextBoxStartTime.Location = new System.Drawing.Point(135, 232);
            this.TextBoxStartTime.Name = "TextBoxStartTime";
            this.TextBoxStartTime.ShowUpDown = true;
            this.TextBoxStartTime.Size = new System.Drawing.Size(113, 25);
            this.TextBoxStartTime.TabIndex = 6;
            // 
            // TextBoxStopTime
            // 
            this.TextBoxStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TextBoxStopTime.Location = new System.Drawing.Point(135, 280);
            this.TextBoxStopTime.Name = "TextBoxStopTime";
            this.TextBoxStopTime.ShowUpDown = true;
            this.TextBoxStopTime.Size = new System.Drawing.Size(113, 25);
            this.TextBoxStopTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "End";
            // 
            // TextBoxStopDate
            // 
            this.TextBoxStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TextBoxStopDate.Location = new System.Drawing.Point(12, 280);
            this.TextBoxStopDate.Name = "TextBoxStopDate";
            this.TextBoxStopDate.Size = new System.Drawing.Size(117, 25);
            this.TextBoxStopDate.TabIndex = 7;
            // 
            // CheckBoxAllDay
            // 
            this.CheckBoxAllDay.AutoSize = true;
            this.CheckBoxAllDay.Location = new System.Drawing.Point(254, 236);
            this.CheckBoxAllDay.Name = "CheckBoxAllDay";
            this.CheckBoxAllDay.Size = new System.Drawing.Size(67, 21);
            this.CheckBoxAllDay.TabIndex = 10;
            this.CheckBoxAllDay.Text = "All Day";
            this.CheckBoxAllDay.UseVisualStyleBackColor = true;
            this.CheckBoxAllDay.CheckedChanged += new System.EventHandler(this.CheckBoxAllDay_CheckedChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(309, 342);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(121, 32);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(182, 342);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(121, 32);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(55, 342);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(121, 32);
            this.ButtonDelete.TabIndex = 13;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // FormEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.CheckBoxAllDay);
            this.Controls.Add(this.TextBoxStopTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxStopDate);
            this.Controls.Add(this.TextBoxStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxStartDate);
            this.Controls.Add(this.TextBoxDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 425);
            this.MinimumSize = new System.Drawing.Size(500, 425);
            this.Name = "FormEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyCalendar";
            this.Load += new System.EventHandler(this.FormEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TextBoxName;
        private TextBox TextBoxDescription;
        private Label label2;
        private DateTimePicker TextBoxStartDate;
        private Label label3;
        private DateTimePicker TextBoxStartTime;
        private DateTimePicker TextBoxStopTime;
        private Label label4;
        private DateTimePicker TextBoxStopDate;
        private CheckBox CheckBoxAllDay;
        private Button ButtonSave;
        private Button ButtonCancel;
        private Button ButtonDelete;
    }
}