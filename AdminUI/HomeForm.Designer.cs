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
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteAssignedBtn = new System.Windows.Forms.Button();
            this.editAssignedBtn = new System.Windows.Forms.Button();
            this.assignProjectBtn = new System.Windows.Forms.Button();
            this.addCohortBtn = new System.Windows.Forms.Button();
            this.deleteCohortBtn = new System.Windows.Forms.Button();
            this.completedList = new System.Windows.Forms.ListBox();
            this.inprogressList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.Label();
            this.cohortName = new System.Windows.Forms.Label();
            this.CohortDate = new System.Windows.Forms.Label();
            this.editCohortBtn = new System.Windows.Forms.Button();
            this.cohortListBox = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.projectsTabPage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1042, 608);
            this.tabControl.TabIndex = 1;
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectsTabPage.Controls.Add(this.addBtn);
            this.projectsTabPage.Controls.Add(this.deleteBtn);
            this.projectsTabPage.Controls.Add(this.viewBtn);
            this.projectsTabPage.Controls.Add(this.projectsListBox);
            this.projectsTabPage.Controls.Add(this.editBtn);
            this.projectsTabPage.Location = new System.Drawing.Point(4, 34);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(1034, 570);
            this.projectsTabPage.TabIndex = 0;
            this.projectsTabPage.Text = "Projects      ";
            this.projectsTabPage.Click += new System.EventHandler(this.projectsTabPage_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(820, 376);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(149, 43);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "+ New Project";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(820, 226);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(154, 43);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete Project";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.Location = new System.Drawing.Point(820, 83);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(154, 48);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "View Project";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // projectsListBox
            // 
            this.projectsListBox.AllowDrop = true;
            this.projectsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.projectsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectsListBox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 25;
            this.projectsListBox.Location = new System.Drawing.Point(31, 34);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(682, 500);
            this.projectsListBox.TabIndex = 1;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(820, 158);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(154, 43);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit Project";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.deleteAssignedBtn);
            this.tabPage2.Controls.Add(this.editAssignedBtn);
            this.tabPage2.Controls.Add(this.assignProjectBtn);
            this.tabPage2.Controls.Add(this.addCohortBtn);
            this.tabPage2.Controls.Add(this.deleteCohortBtn);
            this.tabPage2.Controls.Add(this.completedList);
            this.tabPage2.Controls.Add(this.inprogressList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.startDate);
            this.tabPage2.Controls.Add(this.cohortName);
            this.tabPage2.Controls.Add(this.CohortDate);
            this.tabPage2.Controls.Add(this.editCohortBtn);
            this.tabPage2.Controls.Add(this.cohortListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cohorts      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cohorts Inprogress";
            // 
            // deleteAssignedBtn
            // 
            this.deleteAssignedBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteAssignedBtn.Location = new System.Drawing.Point(548, 270);
            this.deleteAssignedBtn.Name = "deleteAssignedBtn";
            this.deleteAssignedBtn.Size = new System.Drawing.Size(144, 34);
            this.deleteAssignedBtn.TabIndex = 7;
            this.deleteAssignedBtn.Text = "Delete Project";
            this.deleteAssignedBtn.UseVisualStyleBackColor = true;
            // 
            // editAssignedBtn
            // 
            this.editAssignedBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editAssignedBtn.Location = new System.Drawing.Point(417, 270);
            this.editAssignedBtn.Name = "editAssignedBtn";
            this.editAssignedBtn.Size = new System.Drawing.Size(124, 34);
            this.editAssignedBtn.TabIndex = 7;
            this.editAssignedBtn.Text = "View Project";
            this.editAssignedBtn.UseVisualStyleBackColor = true;
            this.editAssignedBtn.Click += new System.EventHandler(this.editAssignedBtn_Click);
            // 
            // assignProjectBtn
            // 
            this.assignProjectBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignProjectBtn.Location = new System.Drawing.Point(861, 270);
            this.assignProjectBtn.Name = "assignProjectBtn";
            this.assignProjectBtn.Size = new System.Drawing.Size(144, 34);
            this.assignProjectBtn.TabIndex = 7;
            this.assignProjectBtn.Text = "Assign Project";
            this.assignProjectBtn.UseVisualStyleBackColor = true;
            // 
            // addCohortBtn
            // 
            this.addCohortBtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCohortBtn.Location = new System.Drawing.Point(24, 508);
            this.addCohortBtn.Name = "addCohortBtn";
            this.addCohortBtn.Size = new System.Drawing.Size(104, 34);
            this.addCohortBtn.TabIndex = 6;
            this.addCohortBtn.Text = "+ New";
            this.addCohortBtn.UseVisualStyleBackColor = true;
            this.addCohortBtn.Click += new System.EventHandler(this.addCohortBtn_Click);
            // 
            // deleteCohortBtn
            // 
            this.deleteCohortBtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCohortBtn.Location = new System.Drawing.Point(274, 508);
            this.deleteCohortBtn.Name = "deleteCohortBtn";
            this.deleteCohortBtn.Size = new System.Drawing.Size(108, 34);
            this.deleteCohortBtn.TabIndex = 5;
            this.deleteCohortBtn.Text = "Delete";
            this.deleteCohortBtn.UseVisualStyleBackColor = true;
            // 
            // completedList
            // 
            this.completedList.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.completedList.FormattingEnabled = true;
            this.completedList.ItemHeight = 25;
            this.completedList.Location = new System.Drawing.Point(417, 363);
            this.completedList.Name = "completedList";
            this.completedList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.completedList.Size = new System.Drawing.Size(588, 179);
            this.completedList.TabIndex = 4;
            // 
            // inprogressList
            // 
            this.inprogressList.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inprogressList.FormattingEnabled = true;
            this.inprogressList.ItemHeight = 25;
            this.inprogressList.Location = new System.Drawing.Point(417, 85);
            this.inprogressList.Name = "inprogressList";
            this.inprogressList.Size = new System.Drawing.Size(588, 179);
            this.inprogressList.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Projects Inprogress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Projects Completed";
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startDate.Location = new System.Drawing.Point(806, 23);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(56, 25);
            this.startDate.TabIndex = 2;
            this.startDate.Text = "Date";
            // 
            // cohortName
            // 
            this.cohortName.AutoSize = true;
            this.cohortName.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cohortName.Location = new System.Drawing.Point(417, 23);
            this.cohortName.Name = "cohortName";
            this.cohortName.Size = new System.Drawing.Size(73, 25);
            this.cohortName.TabIndex = 2;
            this.cohortName.Text = "Cohort";
            // 
            // CohortDate
            // 
            this.CohortDate.AutoSize = true;
            this.CohortDate.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CohortDate.Location = new System.Drawing.Point(687, 23);
            this.CohortDate.Name = "CohortDate";
            this.CohortDate.Size = new System.Drawing.Size(113, 25);
            this.CohortDate.TabIndex = 2;
            this.CohortDate.Text = "Start Date :";
            // 
            // editCohortBtn
            // 
            this.editCohortBtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editCohortBtn.Location = new System.Drawing.Point(155, 508);
            this.editCohortBtn.Name = "editCohortBtn";
            this.editCohortBtn.Size = new System.Drawing.Size(95, 34);
            this.editCohortBtn.TabIndex = 1;
            this.editCohortBtn.Text = "Edit ";
            this.editCohortBtn.UseVisualStyleBackColor = true;
            this.editCohortBtn.Click += new System.EventHandler(this.editCohortBtn_Click);
            // 
            // cohortListBox
            // 
            this.cohortListBox.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cohortListBox.FormattingEnabled = true;
            this.cohortListBox.ItemHeight = 25;
            this.cohortListBox.Location = new System.Drawing.Point(24, 73);
            this.cohortListBox.Name = "cohortListBox";
            this.cohortListBox.Size = new System.Drawing.Size(358, 429);
            this.cohortListBox.TabIndex = 0;
            this.cohortListBox.SelectedIndexChanged += new System.EventHandler(this.cohortListBox_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 570);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Teamleaders      ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1041, 685);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEPA PTS";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.tabControl.ResumeLayout(false);
            this.projectsTabPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tabControl;
        private TabPage projectsTabPage;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private ListBox projectsListBox;
        private Button editBtn;
        private Button viewBtn;
        private Button deleteBtn;
        private Button addBtn;
        private Button deleteAssignedBtn;
        private Button editAssignedBtn;
        private Button assignProjectBtn;
        private Button addCohortBtn;
        private Button deleteCohortBtn;
        private ListBox completedList;
        private ListBox inprogressList;
        private Label label3;
        private Label label2;
        private Label startDate;
        private Label CohortDate;
        private Button editCohortBtn;
        private ListBox cohortListBox;
        private Label label4;
        private Label cohortName;
    }
}