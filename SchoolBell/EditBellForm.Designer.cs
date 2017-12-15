namespace SchoolBell
{
    partial class EditBellForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerNum = new System.Windows.Forms.NumericUpDown();
            this.stopSoundRadioButton = new System.Windows.Forms.RadioButton();
            this.fullSoundRadioButton = new System.Windows.Forms.RadioButton();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 16;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Controls.Add(this.label3);
            this.timerGroupBox.Controls.Add(this.timerNum);
            this.timerGroupBox.Controls.Add(this.stopSoundRadioButton);
            this.timerGroupBox.Controls.Add(this.fullSoundRadioButton);
            this.timerGroupBox.Location = new System.Drawing.Point(15, 144);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(235, 117);
            this.timerGroupBox.TabIndex = 14;
            this.timerGroupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "(9 - 6000 seconds)";
            // 
            // timerNum
            // 
            this.timerNum.Location = new System.Drawing.Point(7, 79);
            this.timerNum.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.timerNum.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.timerNum.Name = "timerNum";
            this.timerNum.Size = new System.Drawing.Size(69, 20);
            this.timerNum.TabIndex = 2;
            this.timerNum.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // stopSoundRadioButton
            // 
            this.stopSoundRadioButton.AutoSize = true;
            this.stopSoundRadioButton.Location = new System.Drawing.Point(7, 56);
            this.stopSoundRadioButton.Name = "stopSoundRadioButton";
            this.stopSoundRadioButton.Size = new System.Drawing.Size(170, 17);
            this.stopSoundRadioButton.TabIndex = 1;
            this.stopSoundRadioButton.TabStop = true;
            this.stopSoundRadioButton.Text = "Stop sound file after x seconds";
            this.stopSoundRadioButton.UseVisualStyleBackColor = true;
            this.stopSoundRadioButton.CheckedChanged += new System.EventHandler(this.stopSoundRadioButton_CheckedChanged);
            // 
            // fullSoundRadioButton
            // 
            this.fullSoundRadioButton.AutoSize = true;
            this.fullSoundRadioButton.Location = new System.Drawing.Point(7, 33);
            this.fullSoundRadioButton.Name = "fullSoundRadioButton";
            this.fullSoundRadioButton.Size = new System.Drawing.Size(108, 17);
            this.fullSoundRadioButton.TabIndex = 0;
            this.fullSoundRadioButton.TabStop = true;
            this.fullSoundRadioButton.Text = "PlayFullSoundFile";
            this.fullSoundRadioButton.UseVisualStyleBackColor = true;
            this.fullSoundRadioButton.CheckedChanged += new System.EventHandler(this.fullSoundRadioButton_CheckedChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(174, 101);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(76, 21);
            this.browseButton.TabIndex = 13;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(17, 102);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(154, 20);
            this.pathTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sound File:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bell Time:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // EditBellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 372);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.timerGroupBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditBellForm";
            this.Text = "EditBellForm";
            this.timerGroupBox.ResumeLayout(false);
            this.timerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox timerGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timerNum;
        private System.Windows.Forms.RadioButton stopSoundRadioButton;
        private System.Windows.Forms.RadioButton fullSoundRadioButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}