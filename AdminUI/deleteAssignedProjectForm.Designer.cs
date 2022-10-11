namespace AdminUI
{
    partial class deleteAssignedProjectForm
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
            this.unassignBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.cancelBtn.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelBtn.Location = new System.Drawing.Point(55, 124);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(165, 42);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "No, abort";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // unassignBtn
            // 
            this.unassignBtn.BackColor = System.Drawing.Color.IndianRed;
            this.unassignBtn.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unassignBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.unassignBtn.Location = new System.Drawing.Point(244, 124);
            this.unassignBtn.Name = "unassignBtn";
            this.unassignBtn.Size = new System.Drawing.Size(165, 42);
            this.unassignBtn.TabIndex = 6;
            this.unassignBtn.Text = "Yes, Unassign";
            this.unassignBtn.UseVisualStyleBackColor = false;
            this.unassignBtn.Click += new System.EventHandler(this.unassignBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(244, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 25);
            this.nameLabel.TabIndex = 5;
            // 
            // projectLabel
            // 
            this.projectLabel.AutoSize = true;
            this.projectLabel.Location = new System.Drawing.Point(55, 45);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(265, 25);
            this.projectLabel.TabIndex = 4;
            this.projectLabel.Text = "Are you sure you want to delete";
            // 
            // deleteAssignedProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 228);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.unassignBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.projectLabel);
            this.Name = "deleteAssignedProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "deleteAssignedProjectForm";
            this.Load += new System.EventHandler(this.deleteAssignedProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelBtn;
        private Button unassignBtn;
        private Label nameLabel;
        private Label projectLabel;
    }
}