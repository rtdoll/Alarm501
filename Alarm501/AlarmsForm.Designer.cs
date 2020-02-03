namespace Alarm501
{
    partial class Alarms_Form
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
            this.components = new System.ComponentModel.Container();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Snooze_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Alarm_ListBox = new System.Windows.Forms.ListBox();
            this.AlarmNotif_Label = new System.Windows.Forms.Label();
            this.Alarm_Timer = new System.Windows.Forms.Timer(this.components);
            this.Snooze_Timer = new System.Windows.Forms.Timer(this.components);
            this.AlarmWait_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Edit_Button
            // 
            this.Edit_Button.Enabled = false;
            this.Edit_Button.Location = new System.Drawing.Point(31, 30);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(93, 49);
            this.Edit_Button.TabIndex = 0;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(197, 30);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(93, 49);
            this.Add_Button.TabIndex = 1;
            this.Add_Button.Text = "+";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Snooze_Button
            // 
            this.Snooze_Button.Enabled = false;
            this.Snooze_Button.Location = new System.Drawing.Point(31, 367);
            this.Snooze_Button.Name = "Snooze_Button";
            this.Snooze_Button.Size = new System.Drawing.Size(93, 49);
            this.Snooze_Button.TabIndex = 2;
            this.Snooze_Button.Text = "Snooze";
            this.Snooze_Button.UseVisualStyleBackColor = true;
            this.Snooze_Button.Click += new System.EventHandler(this.Snooze_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Enabled = false;
            this.Stop_Button.Location = new System.Drawing.Point(197, 367);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(93, 49);
            this.Stop_Button.TabIndex = 3;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Alarm_ListBox
            // 
            this.Alarm_ListBox.FormattingEnabled = true;
            this.Alarm_ListBox.ItemHeight = 16;
            this.Alarm_ListBox.Location = new System.Drawing.Point(31, 104);
            this.Alarm_ListBox.Name = "Alarm_ListBox";
            this.Alarm_ListBox.ScrollAlwaysVisible = true;
            this.Alarm_ListBox.Size = new System.Drawing.Size(258, 212);
            this.Alarm_ListBox.TabIndex = 4;
            this.Alarm_ListBox.SelectedIndexChanged += new System.EventHandler(this.Alarm_ListBox_SelectedIndexChanged);
            // 
            // AlarmNotif_Label
            // 
            this.AlarmNotif_Label.AutoSize = true;
            this.AlarmNotif_Label.ForeColor = System.Drawing.Color.Red;
            this.AlarmNotif_Label.Location = new System.Drawing.Point(86, 335);
            this.AlarmNotif_Label.Name = "AlarmNotif_Label";
            this.AlarmNotif_Label.Size = new System.Drawing.Size(148, 17);
            this.AlarmNotif_Label.TabIndex = 5;
            this.AlarmNotif_Label.Text = "An Alarm has gone off";
            this.AlarmNotif_Label.Visible = false;
            // 
            // Alarm_Timer
            // 
            this.Alarm_Timer.Enabled = true;
            this.Alarm_Timer.Interval = 1000;
            this.Alarm_Timer.Tick += new System.EventHandler(this.Alarm_Timer_Tick);
            // 
            // Snooze_Timer
            // 
            this.Snooze_Timer.Interval = 30000;
            this.Snooze_Timer.Tick += new System.EventHandler(this.Snooze_Timer_Tick);
            // 
            // AlarmWait_Timer
            // 
            this.AlarmWait_Timer.Interval = 60000;
            this.AlarmWait_Timer.Tick += new System.EventHandler(this.AlarmWait_Timer_Tick);
            // 
            // Alarms_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.AlarmNotif_Label);
            this.Controls.Add(this.Alarm_ListBox);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Snooze_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Edit_Button);
            this.Name = "Alarms_Form";
            this.Text = "Alarm501";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Snooze_Button;
        private System.Windows.Forms.Button Stop_Button;
        public System.Windows.Forms.ListBox Alarm_ListBox;
        private System.Windows.Forms.Label AlarmNotif_Label;
        private System.Windows.Forms.Timer Alarm_Timer;
        private System.Windows.Forms.Timer Snooze_Timer;
        private System.Windows.Forms.Timer AlarmWait_Timer;
    }
}

