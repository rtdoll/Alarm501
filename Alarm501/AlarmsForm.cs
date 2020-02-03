using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Alarm501
{
    public partial class Alarms_Form : Form
    {
        public BindingList<string> alarms;//list of alarms to display
        private bool alarmCalled = false;//bool to tell whether alert for alarm has gone off
        public Alarms_Form()
        {
            InitializeComponent();
            alarms = new BindingList<string>();
            Alarm_ListBox.DataSource = this.alarms;
        }

        /// <summary>
        /// Call new form to add new alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, EventArgs e)
        {
            AddEditAlarm_Form addEditAlarm = new AddEditAlarm_Form(alarms, "", -1);
            addEditAlarm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alarm_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Edit_Button.Enabled = true;
        }

        /// <summary>
        /// Call form to edit selected alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Edit_Button.Enabled = false;
            AddEditAlarm_Form addEditAlarm = new AddEditAlarm_Form(alarms, Alarm_ListBox.SelectedItem.ToString(), Alarm_ListBox.SelectedIndex);
            addEditAlarm.Show();
        }

        /// <summary>
        /// every second check for alarm within list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alarm_Timer_Tick(object sender, EventArgs e)
        {
            foreach(string s in alarms)
            {
                List<string> alr = s.Split(' ').ToList<string>();
                if (!alarmCalled && s.Substring(1,7) == DateTime.Now.ToShortTimeString() && alr.Contains("On"))
                {
                    alarmCalled = true;
                    AlarmWait_Timer.Enabled = true;
                    AlarmWentOff();
                }
            }
        }

        /// <summary>
        /// Enable all buttons and change text when alarm goes off
        /// </summary>
        private void AlarmWentOff()
        {
            AlarmNotif_Label.Text = "An Alarm has gone off";
            Snooze_Button.Enabled = true;
            Stop_Button.Enabled = true;
            AlarmNotif_Label.Visible = true;
        }

        /// <summary>
        /// Disables buttons when snooze is clocked and calls snooze timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Snooze_Button_Click(object sender, EventArgs e)
        {
            Snooze_Button.Enabled = false;
            Stop_Button.Enabled = false;
            AlarmNotif_Label.Text = "Alarm has been snoozed";
            SnoozeAlarm();
        }

        /// <summary>
        /// Enable snooze timer
        /// </summary>
        private void SnoozeAlarm()
        {
            Snooze_Timer.Enabled = true;
        }

        /// <summary>
        /// Stops the alarm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Button_Click(object sender, EventArgs e)
        {
            Snooze_Button.Enabled = false;
            Stop_Button.Enabled = false;
            AlarmNotif_Label.Visible = false;
        }

        /// <summary>
        /// Timer so that the alarm does not go off repeatedly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlarmWait_Timer_Tick(object sender, EventArgs e)
        {
            AlarmWait_Timer.Enabled = false;
            alarmCalled = false;
        }

        /// <summary>
        /// Timer for when the alarm gets snoozed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Snooze_Timer_Tick(object sender, EventArgs e)
        {
            Snooze_Timer.Enabled = false;
            AlarmWentOff();
        }
    }
}
