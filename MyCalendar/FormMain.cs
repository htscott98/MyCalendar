namespace MyCalendar
{
    public partial class FormMain : Form
    {
        public int Month;
        public int Year;


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            MyCalendar.Events o = new MyCalendar.Events();
            o.DisablePastEvents();

            CheckTodaysEvents();

            LabelMonthYear.Focus();

            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;

            BuildCalendar();
        }

        private void BuildCalendar()
        {
            try
            {
                DateTime date = new DateTime(Year, Month, 1);
                LabelMonthYear.Text = date.ToString("MMMM - yyyy");

                FlowLayoutPanelMain.Controls.Clear();
                FlowLayoutPanelDays.Controls.Clear();

                BuildDayLabels();
                BuildMonthDays();

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }
        }

        private void CheckTodaysEvents()
        {
            List<MyCalendar.Events> todaysEvents = MyCalendar.Events.GetListOfObjectsByDate(DateTime.Now.Date.ToString(), false);

            string message = "";

            if (todaysEvents.Count > 0)
            {
                message += "Todays Events:" + Environment.NewLine + Environment.NewLine;

                foreach (MyCalendar.Events events in todaysEvents)
                {
                    if (events.StartTime.TimeOfDay.ToString() == "00:00:00" && events.StopTime.TimeOfDay.ToString() == "23:59:59")
                    {
                        message += "Event: " + events.Name + Environment.NewLine + "Time: All Day" + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        message += "Event: " + events.Name + Environment.NewLine + "Time: " + events.StartTime.ToShortTimeString() + " - " + events.StopTime.ToShortTimeString() + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
            else
            {
                message = "No events scheduled for today.";
            }

            if (string.IsNullOrEmpty(message) == false)
            {
                GlobalCode.ShowMSGBox(message);
            }
        }

        private void BuildDayLabels()
        {
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            foreach (string day in daysOfWeek)
            {
                Label dayLabel = new Label();
                dayLabel.Text = day;
                dayLabel.Font = new Font(dayLabel.Font.Name, 12, FontStyle.Bold);
                dayLabel.Width = FlowLayoutPanelDays.Width / 7;
                dayLabel.Height = FlowLayoutPanelDays.Height;
                dayLabel.Padding = new Padding(0);
                dayLabel.Margin = new Padding(0);
                dayLabel.TextAlign = ContentAlignment.BottomCenter;

                FlowLayoutPanelDays.Controls.Add(dayLabel);
            }

        }

        private void BuildMonthDays()
        {
            var firstDayOfMonthInt = Convert.ToInt32(new DateTime(Year, Month, 1).DayOfWeek);
            var firstDayOfMonth = new DateTime(Year, Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1).Day;

            int x = 1;
            while (x <= firstDayOfMonthInt)
            {

                //building the blank days until the first day of the month
                FlowLayoutPanel blankDayPanel = new FlowLayoutPanel();
                blankDayPanel.Height = FlowLayoutPanelMain.Height / 5;
                blankDayPanel.Width = FlowLayoutPanelMain.Width / 7;
                blankDayPanel.Margin = new Padding(0);
                blankDayPanel.Padding = new Padding(0);
                blankDayPanel.BorderStyle = BorderStyle.FixedSingle;
                blankDayPanel.BackColor = Color.LightGray;
                FlowLayoutPanelMain.Controls.Add(blankDayPanel);

                x++;

            }

            x = 1;
            while (x <= lastDayOfMonth)
            {
                FlowLayoutPanel dayPanel = new FlowLayoutPanel();
                dayPanel.Height = FlowLayoutPanelMain.Height / 5;
                dayPanel.Width = FlowLayoutPanelMain.Width / 7;
                dayPanel.Margin = new Padding(0);
                dayPanel.Padding = new Padding(0);
                dayPanel.BorderStyle = BorderStyle.FixedSingle;

                dayPanel.Name = x.ToString();
                dayPanel.Click += DayPanel_Click;
                dayPanel.MouseEnter += DayPanel_MouseEnter;
                dayPanel.MouseLeave += DayPanel_MouseLeave;

                FlowLayoutPanelMain.Controls.Add(dayPanel);

                Label dateOfMonth = new Label();

                dateOfMonth.Name = Month.ToString() + "/" + x + "/" + Year.ToString();

                if (dateOfMonth.Name == DateTime.Now.Date.ToString("MM/dd/yyyy"))
                {
                    dateOfMonth.Text = x.ToString() + " - Today";
                }
                else
                {
                    dateOfMonth.Text = x.ToString();
                }

                dateOfMonth.Margin = new Padding(0, 0, 0, 10);
                dateOfMonth.Padding = new Padding(0);
                dateOfMonth.Width = dayPanel.Width;
                dateOfMonth.TextAlign = ContentAlignment.MiddleLeft;
                dateOfMonth.Font = new Font(dateOfMonth.Font.Name, 14, FontStyle.Bold);


                dateOfMonth.MouseEnter += DateOfMonth_MouseEnter;
                dateOfMonth.MouseLeave += DateOfMonth_MouseLeave;
                dateOfMonth.Click += DateOfMonth_Click;


                dayPanel.Controls.Add(dateOfMonth);


                List<Events> allEvents = new List<Events>();
                allEvents = MyCalendar.Events.GetListOfObjectsByDate(dateOfMonth.Name, CheckBoxPastEvents.Checked);

                foreach (Events dayEvent in allEvents)
                {
                    Label dayLabel = new Label();
                    dayLabel.Font = new Font(dayLabel.Font.Name, 12, FontStyle.Regular);

                    if (dayEvent.StartTime.TimeOfDay.ToString() == "00:00:00" && dayEvent.StopTime.TimeOfDay.ToString() == "23:59:59")
                    {
                        dayLabel.Text = "Event: " + dayEvent.Name + Environment.NewLine + "Time: All Day";
                    }
                    else
                    {
                        dayLabel.Text = "Event: " + dayEvent.Name + Environment.NewLine + "Time: " + dayEvent.StartTime.ToShortTimeString() + " - " + dayEvent.StopTime.ToShortTimeString();
                    }


                    dayLabel.Margin = new Padding(0);
                    dayLabel.Padding = new Padding(0);
                    dayLabel.Width = dayPanel.Width;
                    dayLabel.BorderStyle = BorderStyle.FixedSingle;
                    dayLabel.AutoSize = true;
                    dayLabel.MinimumSize = new Size(dayPanel.Width, 0);
                    dayLabel.Name = dayEvent.ID.ToString();

                    dayLabel.Click += DayLabel_Click;
                    dayLabel.MouseEnter += DayLabel_MouseEnter;
                    dayLabel.MouseLeave += DayLabel_MouseLeave;

                    dayPanel.Controls.Add(dayLabel);
                }

                x++;

            }



        }

        private void DayLabel_Click(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            FormEvent f = new FormEvent();
            f.newEvent = false;
            f.eventID = Convert.ToInt32(control.Name);
            f.ShowDialog();
            BuildCalendar();

        }

        private void DayPanel_Click(object? sender, EventArgs e)
        {
            Control control = sender as Control;

            FormEvent f = new FormEvent();
            f.newEvent = true;
            f.eventID = 0;
            f.Day = Convert.ToInt32(control.Name);
            f.Month = Month;
            f.Year = Year;
            f.ShowDialog();
            BuildCalendar();
        }

        private void DayLabel_MouseLeave(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.Transparent;
        }

        private void DayLabel_MouseEnter(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.DodgerBlue;
        }

        private void DateOfMonth_MouseEnter(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            Control parentControl = control.Parent;
            parentControl.BackColor = Color.DodgerBlue;
        }

        private void DayPanel_MouseEnter(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.DodgerBlue;
        }

        private void DayPanel_MouseLeave(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            control.BackColor = Color.Transparent;
        }

        private void DateOfMonth_Click(object? sender, EventArgs e)
        {
            Label label = sender as Label;

            FormEvent f = new FormEvent();
            f.newEvent = true;
            f.eventID = 0;
            f.Day = Convert.ToInt32(label.Text.Replace(" - Today", ""));
            f.Month = Month;
            f.Year = Year;
            f.ShowDialog();
            BuildCalendar();

        }

        private void DateOfMonth_MouseLeave(object? sender, EventArgs e)
        {
            Control control = sender as Control;
            Control parentControl = control.Parent;
            parentControl.BackColor = Color.Transparent;
        }

        private void ButtonNextMonth_Click(object sender, EventArgs e)
        {
            try
            {
                if (Month == 12)
                {
                    Year++;
                    Month = 1;
                }
                else
                {
                    Month++;
                }

                BuildCalendar();

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }
        }

        private void ButtonLastMonth_Click(object sender, EventArgs e)
        {
            try
            {
                if (Month == 1)
                {
                    Year--;
                    Month = 12;
                }
                else
                {
                    Month--;
                }

                BuildCalendar();

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }
        }

        private void ButtonNewEvent_Click(object sender, EventArgs e)
        {
            FormEvent f = new FormEvent();
            f.newEvent = true;
            f.eventID = 0;
            f.Day = 1;
            f.Month = Month;
            f.Year = Year;
            f.ShowDialog();
            BuildCalendar();
        }

        private void ButtonToday_Click(object sender, EventArgs e)
        {
            Month = DateTime.Now.Month;
            Year = DateTime.Now.Year;
            BuildCalendar();
        }

        private void CheckBoxPastEvents_CheckedChanged(object sender, EventArgs e)
        {
            BuildCalendar();
        }

        private void ButtonTodaysSchedule_Click(object sender, EventArgs e)
        {
            CheckTodaysEvents();
        }
    }
}