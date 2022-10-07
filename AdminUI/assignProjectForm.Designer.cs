namespace AdminUI
{
    partial class assignProjectForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.teamleaderComboBox = new System.Windows.Forms.ComboBox();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cohortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(561, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "Abort";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(432, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(303, 123);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(356, 33);
            this.projectComboBox.TabIndex = 9;
            // 
            // teamleaderComboBox
            // 
            this.teamleaderComboBox.FormattingEnabled = true;
            this.teamleaderComboBox.Location = new System.Drawing.Point(303, 190);
            this.teamleaderComboBox.Name = "teamleaderComboBox";
            this.teamleaderComboBox.Size = new System.Drawing.Size(356, 33);
            this.teamleaderComboBox.TabIndex = 10;
            // 
            // startDateBox
            // 
            this.startDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateBox.Location = new System.Drawing.Point(303, 259);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(356, 31);
            this.startDateBox.TabIndex = 8;
            this.startDateBox.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Set start date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select teamleader :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select project :";
            // 
            // cohortLabel
            // 
            this.cohortLabel.AutoSize = true;
            this.cohortLabel.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cohortLabel.Location = new System.Drawing.Point(104, 50);
            this.cohortLabel.Name = "cohortLabel";
            this.cohortLabel.Size = new System.Drawing.Size(128, 25);
            this.cohortLabel.TabIndex = 7;
            this.cohortLabel.Text = "Cohort Label";
            // 
            // assignProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 441);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.teamleaderComboBox);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cohortLabel);
            this.Name = "assignProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Project";
            this.Load += new System.EventHandler(this.assignProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox projectComboBox;
        private ComboBox teamleaderComboBox;
        private DateTimePicker startdate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label cohortLabel;
        private DateTimePicker startDateBox;
    }
}