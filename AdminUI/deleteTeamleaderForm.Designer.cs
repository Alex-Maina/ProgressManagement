namespace AdminUI
{
    partial class deleteTeamleaderForm
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
            this.confirmMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.abortBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confirmMsg
            // 
            this.confirmMsg.AutoSize = true;
            this.confirmMsg.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmMsg.Location = new System.Drawing.Point(79, 75);
            this.confirmMsg.Name = "confirmMsg";
            this.confirmMsg.Size = new System.Drawing.Size(120, 25);
            this.confirmMsg.TabIndex = 0;
            this.confirmMsg.Text = "Teamleader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User will still be incharge of the assigned projects in progress.";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirmBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.Location = new System.Drawing.Point(70, 240);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(129, 46);
            this.confirmBtn.TabIndex = 1;
            this.confirmBtn.Text = "CONFIRM";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // abortBtn
            // 
            this.abortBtn.BackColor = System.Drawing.Color.IndianRed;
            this.abortBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abortBtn.Location = new System.Drawing.Point(224, 240);
            this.abortBtn.Name = "abortBtn";
            this.abortBtn.Size = new System.Drawing.Size(129, 46);
            this.abortBtn.TabIndex = 1;
            this.abortBtn.Text = "ABORT";
            this.abortBtn.UseVisualStyleBackColor = false;
            this.abortBtn.Click += new System.EventHandler(this.abortBtn_Click);
            // 
            // deleteTeamleaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 331);
            this.ControlBox = false;
            this.Controls.Add(this.abortBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmMsg);
            this.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "deleteTeamleaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Teamleader";
            this.Load += new System.EventHandler(this.deleteTeamleaderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label confirmMsg;
        private Label label1;
        private Button confirmBtn;
        private Button abortBtn;
    }
}