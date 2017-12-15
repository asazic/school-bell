namespace SchoolBell
{
    partial class DayScheduler
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
            this.bellListView = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sound = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBellButton = new System.Windows.Forms.Button();
            this.editBellButton = new System.Windows.Forms.Button();
            this.deleteBellButton = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bellListView
            // 
            this.bellListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Sound});
            this.bellListView.Location = new System.Drawing.Point(12, 12);
            this.bellListView.Name = "bellListView";
            this.bellListView.Size = new System.Drawing.Size(272, 354);
            this.bellListView.TabIndex = 0;
            this.bellListView.UseCompatibleStateImageBehavior = false;
            this.bellListView.View = System.Windows.Forms.View.Details;
            this.bellListView.SelectedIndexChanged += new System.EventHandler(this.bellListView_SelectedIndexChanged);
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 100;
            // 
            // Sound
            // 
            this.Sound.Text = "Sound";
            this.Sound.Width = 150;
            // 
            // addBellButton
            // 
            this.addBellButton.Location = new System.Drawing.Point(290, 75);
            this.addBellButton.Name = "addBellButton";
            this.addBellButton.Size = new System.Drawing.Size(115, 50);
            this.addBellButton.TabIndex = 1;
            this.addBellButton.Text = "Add Bell";
            this.addBellButton.UseVisualStyleBackColor = true;
            this.addBellButton.Click += new System.EventHandler(this.addBellButton_Click);
            // 
            // editBellButton
            // 
            this.editBellButton.Location = new System.Drawing.Point(290, 131);
            this.editBellButton.Name = "editBellButton";
            this.editBellButton.Size = new System.Drawing.Size(115, 50);
            this.editBellButton.TabIndex = 2;
            this.editBellButton.Text = "Edit Bell";
            this.editBellButton.UseVisualStyleBackColor = true;
            this.editBellButton.Click += new System.EventHandler(this.editBellButton_Click);
            // 
            // deleteBellButton
            // 
            this.deleteBellButton.Location = new System.Drawing.Point(290, 187);
            this.deleteBellButton.Name = "deleteBellButton";
            this.deleteBellButton.Size = new System.Drawing.Size(115, 50);
            this.deleteBellButton.TabIndex = 3;
            this.deleteBellButton.Text = "Delete Bell";
            this.deleteBellButton.UseVisualStyleBackColor = true;
            this.deleteBellButton.Click += new System.EventHandler(this.deleteBellButton_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(290, 313);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(115, 50);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DayScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 375);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.deleteBellButton);
            this.Controls.Add(this.editBellButton);
            this.Controls.Add(this.addBellButton);
            this.Controls.Add(this.bellListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DayScheduler";
            this.Text = "DaySchedulerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bellListView;
        private System.Windows.Forms.Button addBellButton;
        private System.Windows.Forms.Button editBellButton;
        private System.Windows.Forms.Button deleteBellButton;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Sound;
        private System.Windows.Forms.Button buttonClose;
    }
}