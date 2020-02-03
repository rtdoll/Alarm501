using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class AddEditAlarm_Form : Form
    {
        private string alarm;
        private BindingList<string> alarms_form_list;
        private List<string> check = new List<string>();
        private int selectedIndex;

        public AddEditAlarm_Form(BindingList<string> alarms_form_list, string currentAlarm, int selectedIndex)
        {
            InitializeComponent();
            AlarmTime_DateTimePicker.Format = DateTimePickerFormat.Custom;
            AlarmTime_DateTimePicker.CustomFormat = "hh:mm tt"; //format for date time picker
            AlarmTime_DateTimePicker.ShowUpDown = true;
            this.alarms_form_list = alarms_form_list;
            this.selectedIndex = selectedIndex;

            if (currentAlarm != "") //if its a previously created alarm
            {
                alarm = currentAlarm;
                check = currentAlarm.Split(' ').ToList<string>();//split parts of alarm string to see if it is on or off
                check.Add(check[0] + " " + check[1]);
                AlarmTime_DateTimePicker.Text = check[0] + " " + check[1];
                if (check.Contains("On"))
                {
                    AlarmOn_CheckBox.Checked = true;
                }
            }
            
        }

        /// <summary>
        /// Update and or create alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Set_Button_Click(object sender, EventArgs e)
        {
            //if list contains anything, ie there is a alarm selected
            if (check.Any())
            {
                if (AlarmOn_CheckBox.Checked)
                    alarms_form_list[selectedIndex] = AlarmTime_DateTimePicker.Text + " On";
                else
                    alarms_form_list[selectedIndex] = AlarmTime_DateTimePicker.Text + " Off";
            }
            else
            {
                if (AlarmOn_CheckBox.Checked)
                    AddCurrentTime(" On");
                else
                    AddCurrentTime(" Off");
            }
            this.Close();
        }

        /// <summary>
        /// Add the current along with on or off to alarm list
        /// </summary>
        /// <param name="OnOrOff"></param>
        private void AddCurrentTime(string OnOrOff)
        {
            string format = AlarmTime_DateTimePicker.Text;
            string[] time = format.Split(':');
            this.alarm = time[0] + ":" + time[1] + OnOrOff;
            this.alarms_form_list.Add(this.alarm);
        }

       
    }
}
