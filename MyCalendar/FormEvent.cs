using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalendar
{
    public partial class FormEvent : Form
    {
        public bool newEvent;
        public int eventID;
        public int Month;
        public int Year;
        public int Day;

        public FormEvent()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            try
            {
                if (newEvent == true)
                {
                    TextBoxStartDate.Text = Month + "/" + Day + "/" + Year;
                    TextBoxStopDate.Text = Month + "/" + Day + "/" + Year;
                    ButtonDelete.Enabled = false;
                }
                else
                {
                    if (eventID == 0)
                    {
                        this.Close();
                    }

                    MyCalendar.Events o = MyCalendar.Events.GetObjectByID(eventID.ToString());

                    if (o == null || o.ID == 0)
                    {
                        this.Close();
                    }

                    ButtonDelete.Enabled = true;
                    TextBoxName.Text = o.Name;
                    TextBoxDescription.Text = o.Description;
                    TextBoxStartDate.Text = o.StartTime.Date.ToString();
                    TextBoxStartDate.Enabled = false;
                    TextBoxStartTime.Text = o.StartTime.TimeOfDay.ToString();
                    TextBoxStopDate.Text = o.StopTime.Date.ToString();
                    TextBoxStopDate.Enabled = false;
                    TextBoxStopTime.Text = o.StopTime.TimeOfDay.ToString();
                    CheckBoxAllDay.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }
        }

        private void CheckBoxAllDay_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAllDay.Checked == true)
            {
                TextBoxStartTime.Text = "12:00:00 AM";
                TextBoxStopDate.Enabled = false;
                TextBoxStopTime.Enabled = false;
                TextBoxStopDate.Text = TextBoxStartDate.Text;
                TextBoxStopTime.Text = "11:59:59 PM";
            }
            else
            {
                TextBoxStopDate.Enabled = true;
                TextBoxStopTime.Enabled = true;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxName.Text == "" || TextBoxStartDate.Text == "" ||
                    TextBoxStartTime.Text == "" || TextBoxStopDate.Text == "" || TextBoxStopTime.Text == "")
                {
                    GlobalCode.ShowMSGBox("Verify that all required fields are complete.", MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToDateTime(TextBoxStopDate.Text) < Convert.ToDateTime(TextBoxStartDate.Text))
                {
                    GlobalCode.ShowMSGBox("Verify that the stop date is greater than the start date", MessageBoxIcon.Warning);
                    return;
                }

                if (TextBoxStartDate.Text == TextBoxStopDate.Text)
                {
                    if (Convert.ToDateTime(TextBoxStopTime.Text) < Convert.ToDateTime(TextBoxStartTime.Text))
                    {
                        GlobalCode.ShowMSGBox("Verify that the stop time is greater than the start time.", MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (newEvent == true)
                {



                    if (Convert.ToDateTime(TextBoxStartDate.Text) != Convert.ToDateTime(TextBoxStopDate.Text))
                    {
                        var startDate = Convert.ToDateTime(TextBoxStartDate.Text).Date;
                        var stopDate = Convert.ToDateTime(TextBoxStopDate.Text).Date;

                        int daysAdded = 0;
                        while (startDate <= stopDate)
                        {
                            if (daysAdded == 0)
                            {
                                Events o = new Events();
                                o.Name = TextBoxName.Text;
                                o.Description = TextBoxDescription.Text;
                                o.StartTime = Convert.ToDateTime(Convert.ToDateTime(TextBoxStartDate.Text).Date.AddDays(daysAdded).ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(TextBoxStartTime.Text).TimeOfDay.ToString());
                                o.StopTime = Convert.ToDateTime(TextBoxStartDate.Text.ToString() + " 11:59:59 PM");
                                o.PastEvent = false;
                                o.InsertRecord();
                            }

                            if (daysAdded > 0 && startDate < stopDate)
                            {
                                Events o = new Events();
                                o.Name = TextBoxName.Text;
                                o.Description = TextBoxDescription.Text;
                                o.StartTime = Convert.ToDateTime(Convert.ToDateTime(startDate).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("12:00:00 AM").TimeOfDay.ToString());
                                o.StopTime = Convert.ToDateTime(Convert.ToDateTime(startDate).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("11:59:59 PM").TimeOfDay.ToString());
                                o.PastEvent = false;
                                o.InsertRecord();
                            }

                            if (daysAdded > 0 && startDate == stopDate)
                            {
                                Events o = new Events();
                                o.Name = TextBoxName.Text;
                                o.Description = TextBoxDescription.Text;
                                o.StartTime = Convert.ToDateTime(Convert.ToDateTime(stopDate).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime("12:00:00 AM").TimeOfDay.ToString());
                                o.StopTime = Convert.ToDateTime(Convert.ToDateTime(stopDate).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(TextBoxStopTime.Text).TimeOfDay.ToString());
                                o.PastEvent = false;
                                o.InsertRecord();
                            }

                            daysAdded++;
                            startDate = startDate.AddDays(1);

                        }



                        this.Close();

                    }
                    else
                    {
                        Events o = new Events();
                        o.Name = TextBoxName.Text;
                        o.Description = TextBoxDescription.Text;
                        o.StartTime = Convert.ToDateTime(Convert.ToDateTime(TextBoxStartDate.Text).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(TextBoxStartTime.Text).TimeOfDay.ToString());
                        o.StopTime = Convert.ToDateTime(Convert.ToDateTime(TextBoxStopDate.Text).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(TextBoxStopTime.Text).TimeOfDay.ToString());
                        o.PastEvent = false;

                        if (o.InsertRecord() == true)
                        {
                            this.Close();
                        }

                    }
                }
                else
                {
                    Events o = new Events();
                    o.ID = eventID;
                    o.Name = TextBoxName.Text;
                    o.Description = TextBoxDescription.Text;
                    o.StartTime = Convert.ToDateTime(Convert.ToDateTime(TextBoxStartDate.Text).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(TextBoxStartTime.Text).TimeOfDay.ToString());
                    o.StopTime = Convert.ToDateTime(Convert.ToDateTime(TextBoxStopDate.Text).Date.ToString("MM/dd/yyyy") + " " + Convert.ToDateTime(TextBoxStopTime.Text).TimeOfDay.ToString());
                    o.PastEvent = false;

                    if (o.UpdateRecord() == true)
                    {
                        this.Close();
                    }
                }


            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalCode.ShowMSGBox("Are you sure you wish to delete this event?", MessageBoxIcon.Question, MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                if (eventID == 0)
                {
                    this.Close();
                }

                MyCalendar.Events o = new MyCalendar.Events();
                o.ID = eventID;

                if (o.DeleteRecord() == true)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                GlobalCode.ExceptionHandler(ex);
            }
        }
    }
}
