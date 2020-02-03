namespace Alarm501
{
    partial class AddEditAlarm_Form
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
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Set_Button = new System.Windows.Forms.Button();
            this.AlarmTime_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AlarmOn_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(43, 134);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(104, 52);
            this.Cancel_Button.TabIndex = 0;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Set_Button
            // 
            this.Set_Button.Location = new System.Drawing.Point(294, 134);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(104, 52);
            this.Set_Button.TabIndex = 1;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // AlarmTime_DateTimePicker
            // 
            this.AlarmTime_DateTimePicker.Location = new System.Drawing.Point(43, 80);
            this.AlarmTime_DateTimePicker.Name = "AlarmTime_DateTimePicker";
            this.AlarmTime_DateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.AlarmTime_DateTimePicker.TabIndex = 4;
            // 
            // AlarmOn_CheckBox
            // 
            this.AlarmOn_CheckBox.AutoSize = true;
            this.AlarmOn_CheckBox.Location = new System.Drawing.Point(294, 80);
            this.AlarmOn_CheckBox.Name = "AlarmOn_CheckBox";
            this.AlarmOn_CheckBox.Size = new System.Drawing.Size(49, 21);
            this.AlarmOn_CheckBox.TabIndex = 5;
            this.AlarmOn_CheckBox.Text = "On";
            this.AlarmOn_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AddEditAlarm_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 209);
            this.Controls.Add(this.AlarmOn_CheckBox);
            this.Controls.Add(this.AlarmTime_DateTimePicker);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Name = "AddEditAlarm_Form";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.DateTimePicker AlarmTime_DateTimePicker;
        private System.Windows.Forms.CheckBox AlarmOn_CheckBox;
    }
}