namespace SchoolBell
{
    partial class SchoolBell
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
            this.daySchedulerButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.deleteSchedulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daySchedulerButton
            // 
            this.daySchedulerButton.Location = new System.Drawing.Point(12, 18);
            this.daySchedulerButton.Name = "daySchedulerButton";
            this.daySchedulerButton.Size = new System.Drawing.Size(162, 39);
            this.daySchedulerButton.TabIndex = 2;
            this.daySchedulerButton.Text = "Day Scheduler";
            this.daySchedulerButton.UseVisualStyleBackColor = true;
            this.daySchedulerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(186, 18);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // deleteSchedulerButton
            // 
            this.deleteSchedulerButton.Location = new System.Drawing.Point(12, 63);
            this.deleteSchedulerButton.Name = "deleteSchedulerButton";
            this.deleteSchedulerButton.Size = new System.Drawing.Size(162, 39);
            this.deleteSchedulerButton.TabIndex = 4;
            this.deleteSchedulerButton.Text = "Disable scheduler";
            this.deleteSchedulerButton.UseVisualStyleBackColor = true;
            this.deleteSchedulerButton.Click += new System.EventHandler(this.deleteSchedulerButton_Click);
            // 
            // SchoolBell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 369);
            this.Controls.Add(this.deleteSchedulerButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.daySchedulerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SchoolBell";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button daySchedulerButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button deleteSchedulerButton;
    }
}

