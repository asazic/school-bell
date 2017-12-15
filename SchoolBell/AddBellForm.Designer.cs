namespace SchoolBell
{
    partial class AddBellForm
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
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soundPathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timerNum = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.fullSoundRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm:ss";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(12, 30);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(236, 20);
            this.timePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bell Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sound File:";
            // 
            // soundPathTextBox
            // 
            this.soundPathTextBox.Location = new System.Drawing.Point(15, 92);
            this.soundPathTextBox.Name = "soundPathTextBox";
            this.soundPathTextBox.Size = new System.Drawing.Size(154, 20);
            this.soundPathTextBox.TabIndex = 3;
            this.soundPathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(172, 91);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(76, 21);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Controls.Add(this.label3);
            this.timerGroupBox.Controls.Add(this.timerNum);
            this.timerGroupBox.Controls.Add(this.radioButton2);
            this.timerGroupBox.Controls.Add(this.fullSoundRadioButton);
            this.timerGroupBox.Location = new System.Drawing.Point(13, 134);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(235, 117);
            this.timerGroupBox.TabIndex = 5;
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
            this.timerNum.Enabled = false;
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
            this.timerNum.ReadOnly = true;
            this.timerNum.Size = new System.Drawing.Size(69, 20);
            this.timerNum.TabIndex = 2;
            this.timerNum.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(170, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Stop sound file after x seconds";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // fullSoundRadioButton
            // 
            this.fullSoundRadioButton.AutoSize = true;
            this.fullSoundRadioButton.Checked = true;
            this.fullSoundRadioButton.Location = new System.Drawing.Point(7, 33);
            this.fullSoundRadioButton.Name = "fullSoundRadioButton";
            this.fullSoundRadioButton.Size = new System.Drawing.Size(108, 17);
            this.fullSoundRadioButton.TabIndex = 0;
            this.fullSoundRadioButton.TabStop = true;
            this.fullSoundRadioButton.Text = "PlayFullSoundFile";
            this.fullSoundRadioButton.UseVisualStyleBackColor = true;
            this.fullSoundRadioButton.CheckedChanged += new System.EventHandler(this.fullSoundRadioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add and Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add and Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 46);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddBellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 365);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timerGroupBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.soundPathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddBellForm";
            this.Text = "AddBellForm";
            this.timerGroupBox.ResumeLayout(false);
            this.timerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soundPathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox timerGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timerNum;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton fullSoundRadioButton;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}