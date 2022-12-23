namespace MyCalendar
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonNextMonth = new System.Windows.Forms.Button();
            this.ButtonLastMonth = new System.Windows.Forms.Button();
            this.LabelMonthYear = new System.Windows.Forms.Label();
            this.FlowLayoutPanelDays = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonNewEvent = new System.Windows.Forms.Button();
            this.ButtonToday = new System.Windows.Forms.Button();
            this.CheckBoxPastEvents = new System.Windows.Forms.CheckBox();
            this.ButtonTodaysSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlowLayoutPanelMain
            // 
            this.FlowLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanelMain.Location = new System.Drawing.Point(12, 89);
            this.FlowLayoutPanelMain.Name = "FlowLayoutPanelMain";
            this.FlowLayoutPanelMain.Size = new System.Drawing.Size(1133, 532);
            this.FlowLayoutPanelMain.TabIndex = 0;
            // 
            // ButtonNextMonth
            // 
            this.ButtonNextMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNextMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonNextMonth.Location = new System.Drawing.Point(908, 12);
            this.ButtonNextMonth.Name = "ButtonNextMonth";
            this.ButtonNextMonth.Size = new System.Drawing.Size(75, 33);
            this.ButtonNextMonth.TabIndex = 1;
            this.ButtonNextMonth.Text = ">>>";
            this.ButtonNextMonth.UseVisualStyleBackColor = true;
            this.ButtonNextMonth.Click += new System.EventHandler(this.ButtonNextMonth_Click);
            // 
            // ButtonLastMonth
            // 
            this.ButtonLastMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLastMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonLastMonth.Location = new System.Drawing.Point(746, 12);
            this.ButtonLastMonth.Name = "ButtonLastMonth";
            this.ButtonLastMonth.Size = new System.Drawing.Size(75, 33);
            this.ButtonLastMonth.TabIndex = 2;
            this.ButtonLastMonth.Text = "<<<";
            this.ButtonLastMonth.UseVisualStyleBackColor = true;
            this.ButtonLastMonth.Click += new System.EventHandler(this.ButtonLastMonth_Click);
            // 
            // LabelMonthYear
            // 
            this.LabelMonthYear.AutoSize = true;
            this.LabelMonthYear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMonthYear.Location = new System.Drawing.Point(12, 20);
            this.LabelMonthYear.Name = "LabelMonthYear";
            this.LabelMonthYear.Size = new System.Drawing.Size(128, 18);
            this.LabelMonthYear.TabIndex = 3;
            this.LabelMonthYear.Text = "January 2000";
            // 
            // FlowLayoutPanelDays
            // 
            this.FlowLayoutPanelDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanelDays.Location = new System.Drawing.Point(12, 51);
            this.FlowLayoutPanelDays.Name = "FlowLayoutPanelDays";
            this.FlowLayoutPanelDays.Size = new System.Drawing.Size(1133, 32);
            this.FlowLayoutPanelDays.TabIndex = 4;
            // 
            // ButtonNewEvent
            // 
            this.ButtonNewEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonNewEvent.Location = new System.Drawing.Point(989, 12);
            this.ButtonNewEvent.Name = "ButtonNewEvent";
            this.ButtonNewEvent.Size = new System.Drawing.Size(156, 33);
            this.ButtonNewEvent.TabIndex = 5;
            this.ButtonNewEvent.Text = "New Event";
            this.ButtonNewEvent.UseVisualStyleBackColor = true;
            this.ButtonNewEvent.Click += new System.EventHandler(this.ButtonNewEvent_Click);
            // 
            // ButtonToday
            // 
            this.ButtonToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonToday.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonToday.Location = new System.Drawing.Point(827, 12);
            this.ButtonToday.Name = "ButtonToday";
            this.ButtonToday.Size = new System.Drawing.Size(75, 33);
            this.ButtonToday.TabIndex = 6;
            this.ButtonToday.Text = "Today";
            this.ButtonToday.UseVisualStyleBackColor = true;
            this.ButtonToday.Click += new System.EventHandler(this.ButtonToday_Click);
            // 
            // CheckBoxPastEvents
            // 
            this.CheckBoxPastEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxPastEvents.AutoSize = true;
            this.CheckBoxPastEvents.Location = new System.Drawing.Point(613, 20);
            this.CheckBoxPastEvents.Name = "CheckBoxPastEvents";
            this.CheckBoxPastEvents.Size = new System.Drawing.Size(127, 21);
            this.CheckBoxPastEvents.TabIndex = 7;
            this.CheckBoxPastEvents.Text = "Show Past Events";
            this.CheckBoxPastEvents.UseVisualStyleBackColor = true;
            this.CheckBoxPastEvents.CheckedChanged += new System.EventHandler(this.CheckBoxPastEvents_CheckedChanged);
            // 
            // ButtonTodaysSchedule
            // 
            this.ButtonTodaysSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTodaysSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonTodaysSchedule.Location = new System.Drawing.Point(332, 12);
            this.ButtonTodaysSchedule.Name = "ButtonTodaysSchedule";
            this.ButtonTodaysSchedule.Size = new System.Drawing.Size(155, 33);
            this.ButtonTodaysSchedule.TabIndex = 8;
            this.ButtonTodaysSchedule.Text = "Todays Schedule";
            this.ButtonTodaysSchedule.UseVisualStyleBackColor = true;
            this.ButtonTodaysSchedule.Click += new System.EventHandler(this.ButtonTodaysSchedule_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 633);
            this.Controls.Add(this.ButtonTodaysSchedule);
            this.Controls.Add(this.CheckBoxPastEvents);
            this.Controls.Add(this.ButtonToday);
            this.Controls.Add(this.ButtonNewEvent);
            this.Controls.Add(this.FlowLayoutPanelDays);
            this.Controls.Add(this.LabelMonthYear);
            this.Controls.Add(this.ButtonLastMonth);
            this.Controls.Add(this.ButtonNextMonth);
            this.Controls.Add(this.FlowLayoutPanelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCalendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel FlowLayoutPanelMain;
        private Button ButtonNextMonth;
        private Button ButtonLastMonth;
        private Label LabelMonthYear;
        private FlowLayoutPanel FlowLayoutPanelDays;
        private Button ButtonNewEvent;
        private Button ButtonToday;
        private CheckBox CheckBoxPastEvents;
        private Button ButtonTodaysSchedule;
    }
}