namespace AdminUI
{
    partial class HomeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.projectsTabPage = new System.Windows.Forms.TabPage();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EditButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEPA PTS";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.projectsTabPage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1042, 528);
            this.tabControl.TabIndex = 1;
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectsTabPage.Controls.Add(this.projectsListBox);
            this.projectsTabPage.Controls.Add(this.button4);
            this.projectsTabPage.Controls.Add(this.EditButton);
            this.projectsTabPage.Controls.Add(this.assignButton);
            this.projectsTabPage.Controls.Add(this.button1);
            this.projectsTabPage.Location = new System.Drawing.Point(4, 34);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(1034, 490);
            this.projectsTabPage.TabIndex = 0;
            this.projectsTabPage.Text = "Projects      ";
            this.projectsTabPage.Click += new System.EventHandler(this.projectsTabPage_Click);
            // 
            // projectsListBox
            // 
            this.projectsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectsListBox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 25;
            this.projectsListBox.Location = new System.Drawing.Point(19, 34);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(777, 377);
            this.projectsListBox.TabIndex = 1;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
            // 
            // assignButton
            // 
            this.assignButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignButton.Location = new System.Drawing.Point(843, 77);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(154, 43);
            this.assignButton.TabIndex = 0;
            this.assignButton.Text = "Assign Project";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(19, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "+ New Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cohorts      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 468);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Teamleaders      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(843, 151);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(154, 43);
            this.EditButton.TabIndex = 0;
            this.EditButton.Text = "Edit Project";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(843, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Delete Project";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1041, 608);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.tabControl.ResumeLayout(false);
            this.projectsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tabControl;
        private TabPage projectsTabPage;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button button1;
        private Button assignButton;
        private ListBox projectsListBox;
        private Button button4;
        private Button EditButton;
    }
}