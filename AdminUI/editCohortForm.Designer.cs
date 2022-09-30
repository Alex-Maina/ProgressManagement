namespace AdminUI
{
    partial class editCohortForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editCohortBtn = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cohortLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(203, 204);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 34);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // editCohortBtn
            // 
            this.editCohortBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editCohortBtn.Location = new System.Drawing.Point(80, 204);
            this.editCohortBtn.Name = "editCohortBtn";
            this.editCohortBtn.Size = new System.Drawing.Size(112, 34);
            this.editCohortBtn.TabIndex = 9;
            this.editCohortBtn.Text = "Edit";
            this.editCohortBtn.UseVisualStyleBackColor = true;
            this.editCohortBtn.Click += new System.EventHandler(this.editCohortBtn_Click);
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(203, 113);
            this.startDate.MinDate = new System.DateTime(2022, 9, 28, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(185, 29);
            this.startDate.TabIndex = 8;
            this.startDate.Value = new System.DateTime(2022, 9, 30, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Date :";
            // 
            // cohortLabel
            // 
            this.cohortLabel.AutoSize = true;
            this.cohortLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cohortLabel.Location = new System.Drawing.Point(80, 55);
            this.cohortLabel.Name = "cohortLabel";
            this.cohortLabel.Size = new System.Drawing.Size(420, 25);
            this.cohortLabel.TabIndex = 6;
            this.cohortLabel.Text = "Provide a new start date for the new cohort";
            // 
            // editCohortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 290);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editCohortBtn);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cohortLabel);
            this.Name = "editCohortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Cohort";
            this.Load += new System.EventHandler(this.editCohortForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelBtn;
        private Button editCohortBtn;
        private DateTimePicker startDate;
        private Label label2;
        private Label cohortLabel;
    }
}