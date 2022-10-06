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
            this.cohortsTabPage = new System.Windows.Forms.TabPage();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteAssignedBtn = new System.Windows.Forms.Button();
            this.editAssignedBtn = new System.Windows.Forms.Button();
            this.assignProjectBtn = new System.Windows.Forms.Button();
            this.addCohortBtn = new System.Windows.Forms.Button();
            this.statusBtn = new System.Windows.Forms.Button();
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
            this.projectsTabPage = new System.Windows.Forms.TabPage();
            this.minTlBtn = new System.Windows.Forms.Button();
            this.deleteTLBtn = new System.Windows.Forms.Button();
            this.addTLBtn = new System.Windows.Forms.Button();
            this.createNewTLBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.teamleadersListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.projectsListBox = new System.Windows.Forms.ListBox();
            this.maxTlBtn = new System.Windows.Forms.Button();
            this.midTlBtn = new System.Windows.Forms.Button();
            this.allTlBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.refreshTL = new System.Windows.Forms.Button();
            this.cohortsTabPage.SuspendLayout();
            this.projectsTabPage.SuspendLayout();
            this.tabControl.SuspendLayout();
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
            // cohortsTabPage
            // 
            this.cohortsTabPage.Controls.Add(this.refreshBtn);
            this.cohortsTabPage.Controls.Add(this.label4);
            this.cohortsTabPage.Controls.Add(this.deleteAssignedBtn);
            this.cohortsTabPage.Controls.Add(this.editAssignedBtn);
            this.cohortsTabPage.Controls.Add(this.assignProjectBtn);
            this.cohortsTabPage.Controls.Add(this.addCohortBtn);
            this.cohortsTabPage.Controls.Add(this.statusBtn);
            this.cohortsTabPage.Controls.Add(this.deleteCohortBtn);
            this.cohortsTabPage.Controls.Add(this.completedList);
            this.cohortsTabPage.Controls.Add(this.inprogressList);
            this.cohortsTabPage.Controls.Add(this.label3);
            this.cohortsTabPage.Controls.Add(this.label2);
            this.cohortsTabPage.Controls.Add(this.startDate);
            this.cohortsTabPage.Controls.Add(this.cohortName);
            this.cohortsTabPage.Controls.Add(this.CohortDate);
            this.cohortsTabPage.Controls.Add(this.editCohortBtn);
            this.cohortsTabPage.Controls.Add(this.cohortListBox);
            this.cohortsTabPage.Location = new System.Drawing.Point(4, 34);
            this.cohortsTabPage.Name = "cohortsTabPage";
            this.cohortsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cohortsTabPage.Size = new System.Drawing.Size(1034, 586);
            this.cohortsTabPage.TabIndex = 1;
            this.cohortsTabPage.Text = "Cohorts      ";
            this.cohortsTabPage.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.Font = new System.Drawing.Font("Montserrat", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshBtn.Location = new System.Drawing.Point(905, 51);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(100, 31);
            this.refreshBtn.TabIndex = 9;
            this.refreshBtn.Text = "Refresh List";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
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
            this.assignProjectBtn.Location = new System.Drawing.Point(806, 270);
            this.assignProjectBtn.Name = "assignProjectBtn";
            this.assignProjectBtn.Size = new System.Drawing.Size(199, 34);
            this.assignProjectBtn.TabIndex = 7;
            this.assignProjectBtn.Text = "Assign Project";
            this.assignProjectBtn.UseVisualStyleBackColor = true;
            // 
            // addCohortBtn
            // 
            this.addCohortBtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addCohortBtn.Location = new System.Drawing.Point(24, 508);
            this.addCohortBtn.Name = "addCohortBtn";
            this.addCohortBtn.Size = new System.Drawing.Size(74, 34);
            this.addCohortBtn.TabIndex = 6;
            this.addCohortBtn.Text = "+ New";
            this.addCohortBtn.UseVisualStyleBackColor = true;
            this.addCohortBtn.Click += new System.EventHandler(this.addCohortBtn_Click);
            // 
            // statusBtn
            // 
            this.statusBtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusBtn.Location = new System.Drawing.Point(276, 508);
            this.statusBtn.Name = "statusBtn";
            this.statusBtn.Size = new System.Drawing.Size(106, 34);
            this.statusBtn.TabIndex = 5;
            this.statusBtn.Text = "Graduate";
            this.statusBtn.UseVisualStyleBackColor = true;
            this.statusBtn.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // deleteCohortBtn
            // 
            this.deleteCohortBtn.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCohortBtn.Location = new System.Drawing.Point(181, 508);
            this.deleteCohortBtn.Name = "deleteCohortBtn";
            this.deleteCohortBtn.Size = new System.Drawing.Size(89, 34);
            this.deleteCohortBtn.TabIndex = 5;
            this.deleteCohortBtn.Text = "Delete";
            this.deleteCohortBtn.UseVisualStyleBackColor = true;
            this.deleteCohortBtn.Click += new System.EventHandler(this.deleteCohortBtn_Click);
            // 
            // completedList
            // 
            this.completedList.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.inprogressList.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.editCohortBtn.Location = new System.Drawing.Point(104, 508);
            this.editCohortBtn.Name = "editCohortBtn";
            this.editCohortBtn.Size = new System.Drawing.Size(71, 34);
            this.editCohortBtn.TabIndex = 1;
            this.editCohortBtn.Text = "Edit ";
            this.editCohortBtn.UseVisualStyleBackColor = true;
            this.editCohortBtn.Click += new System.EventHandler(this.editCohortBtn_Click);
            // 
            // cohortListBox
            // 
            this.cohortListBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cohortListBox.FormattingEnabled = true;
            this.cohortListBox.ItemHeight = 25;
            this.cohortListBox.Location = new System.Drawing.Point(24, 73);
            this.cohortListBox.Name = "cohortListBox";
            this.cohortListBox.Size = new System.Drawing.Size(358, 429);
            this.cohortListBox.TabIndex = 0;
            this.cohortListBox.SelectedIndexChanged += new System.EventHandler(this.cohortListBox_SelectedIndexChanged);
            // 
            // projectsTabPage
            // 
            this.projectsTabPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectsTabPage.Controls.Add(this.refreshTL);
            this.projectsTabPage.Controls.Add(this.minTlBtn);
            this.projectsTabPage.Controls.Add(this.deleteTLBtn);
            this.projectsTabPage.Controls.Add(this.addTLBtn);
            this.projectsTabPage.Controls.Add(this.createNewTLBtn);
            this.projectsTabPage.Controls.Add(this.label7);
            this.projectsTabPage.Controls.Add(this.teamleadersListBox);
            this.projectsTabPage.Controls.Add(this.label6);
            this.projectsTabPage.Controls.Add(this.label5);
            this.projectsTabPage.Controls.Add(this.addBtn);
            this.projectsTabPage.Controls.Add(this.deleteBtn);
            this.projectsTabPage.Controls.Add(this.viewBtn);
            this.projectsTabPage.Controls.Add(this.projectsListBox);
            this.projectsTabPage.Controls.Add(this.maxTlBtn);
            this.projectsTabPage.Controls.Add(this.midTlBtn);
            this.projectsTabPage.Controls.Add(this.allTlBtn);
            this.projectsTabPage.Controls.Add(this.editBtn);
            this.projectsTabPage.Location = new System.Drawing.Point(4, 34);
            this.projectsTabPage.Name = "projectsTabPage";
            this.projectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.projectsTabPage.Size = new System.Drawing.Size(1034, 586);
            this.projectsTabPage.TabIndex = 0;
            this.projectsTabPage.Text = "Projects  & Teamleaders    ";
            this.projectsTabPage.Click += new System.EventHandler(this.projectsTabPage_Click);
            // 
            // minTlBtn
            // 
            this.minTlBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minTlBtn.Location = new System.Drawing.Point(611, 522);
            this.minTlBtn.Name = "minTlBtn";
            this.minTlBtn.Size = new System.Drawing.Size(69, 37);
            this.minTlBtn.TabIndex = 9;
            this.minTlBtn.Text = "None";
            this.minTlBtn.UseVisualStyleBackColor = true;
            // 
            // deleteTLBtn
            // 
            this.deleteTLBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteTLBtn.Location = new System.Drawing.Point(883, 405);
            this.deleteTLBtn.Name = "deleteTLBtn";
            this.deleteTLBtn.Size = new System.Drawing.Size(130, 54);
            this.deleteTLBtn.TabIndex = 9;
            this.deleteTLBtn.Text = "Delete Teamleader";
            this.deleteTLBtn.UseVisualStyleBackColor = true;
            // 
            // addTLBtn
            // 
            this.addTLBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addTLBtn.Location = new System.Drawing.Point(883, 173);
            this.addTLBtn.Name = "addTLBtn";
            this.addTLBtn.Size = new System.Drawing.Size(130, 54);
            this.addTLBtn.TabIndex = 9;
            this.addTLBtn.Text = "Add From Users";
            this.addTLBtn.UseVisualStyleBackColor = true;
            this.addTLBtn.Click += new System.EventHandler(this.addTLBtn_Click);
            // 
            // createNewTLBtn
            // 
            this.createNewTLBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTLBtn.Location = new System.Drawing.Point(883, 113);
            this.createNewTLBtn.Name = "createNewTLBtn";
            this.createNewTLBtn.Size = new System.Drawing.Size(130, 54);
            this.createNewTLBtn.TabIndex = 8;
            this.createNewTLBtn.Text = "Create New Teamleader";
            this.createNewTLBtn.UseVisualStyleBackColor = true;
            this.createNewTLBtn.Click += new System.EventHandler(this.createNewTLBtn_Click);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(611, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Filter teamleaders based on current assignments";
            // 
            // teamleadersListBox
            // 
            this.teamleadersListBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamleadersListBox.FormattingEnabled = true;
            this.teamleadersListBox.ItemHeight = 25;
            this.teamleadersListBox.Location = new System.Drawing.Point(611, 77);
            this.teamleadersListBox.Name = "teamleadersListBox";
            this.teamleadersListBox.Size = new System.Drawing.Size(266, 404);
            this.teamleadersListBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(611, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Teamleaders";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Project List";
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(437, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(135, 43);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "+ New Project";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(285, 494);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(137, 43);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete Project";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewBtn.Location = new System.Drawing.Point(153, 494);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(126, 43);
            this.viewBtn.TabIndex = 2;
            this.viewBtn.Text = "View Project";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // projectsListBox
            // 
            this.projectsListBox.AllowDrop = true;
            this.projectsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.projectsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectsListBox.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projectsListBox.FormattingEnabled = true;
            this.projectsListBox.ItemHeight = 25;
            this.projectsListBox.Location = new System.Drawing.Point(31, 77);
            this.projectsListBox.Name = "projectsListBox";
            this.projectsListBox.Size = new System.Drawing.Size(541, 402);
            this.projectsListBox.TabIndex = 1;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
            // 
            // maxTlBtn
            // 
            this.maxTlBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maxTlBtn.Location = new System.Drawing.Point(761, 522);
            this.maxTlBtn.Name = "maxTlBtn";
            this.maxTlBtn.Size = new System.Drawing.Size(69, 37);
            this.maxTlBtn.TabIndex = 0;
            this.maxTlBtn.Text = "4 - 5";
            this.maxTlBtn.UseVisualStyleBackColor = true;
            this.maxTlBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // midTlBtn
            // 
            this.midTlBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.midTlBtn.Location = new System.Drawing.Point(686, 522);
            this.midTlBtn.Name = "midTlBtn";
            this.midTlBtn.Size = new System.Drawing.Size(69, 37);
            this.midTlBtn.TabIndex = 0;
            this.midTlBtn.Text = "1 - 3";
            this.midTlBtn.UseVisualStyleBackColor = true;
            this.midTlBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // allTlBtn
            // 
            this.allTlBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allTlBtn.Location = new System.Drawing.Point(836, 522);
            this.allTlBtn.Name = "allTlBtn";
            this.allTlBtn.Size = new System.Drawing.Size(85, 37);
            this.allTlBtn.TabIndex = 0;
            this.allTlBtn.Text = "Select All";
            this.allTlBtn.UseVisualStyleBackColor = true;
            this.allTlBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(31, 494);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(116, 43);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit Project";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.projectsTabPage);
            this.tabControl.Controls.Add(this.cohortsTabPage);
            this.tabControl.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1042, 624);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.cohortTabPage_Selected);
            // 
            // refreshTL
            // 
            this.refreshTL.BackColor = System.Drawing.Color.White;
            this.refreshTL.Font = new System.Drawing.Font("Montserrat", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshTL.Location = new System.Drawing.Point(777, 24);
            this.refreshTL.Name = "refreshTL";
            this.refreshTL.Size = new System.Drawing.Size(100, 34);
            this.refreshTL.TabIndex = 10;
            this.refreshTL.Text = "Refresh List";
            this.refreshTL.UseVisualStyleBackColor = false;
            this.refreshTL.Click += new System.EventHandler(this.refreshTL_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1041, 698);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEPA PTS";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.cohortsTabPage.ResumeLayout(false);
            this.cohortsTabPage.PerformLayout();
            this.projectsTabPage.ResumeLayout(false);
            this.projectsTabPage.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabPage cohortsTabPage;
        private Button refreshBtn;
        private Label label4;
        private Button deleteAssignedBtn;
        private Button editAssignedBtn;
        private Button assignProjectBtn;
        private Button addCohortBtn;
        private Button statusBtn;
        private Button deleteCohortBtn;
        private ListBox completedList;
        private ListBox inprogressList;
        private Label label3;
        private Label label2;
        private Label startDate;
        private Label cohortName;
        private Label CohortDate;
        private Button editCohortBtn;
        private ListBox cohortListBox;
        private TabPage projectsTabPage;
        private Label label7;
        private ListBox teamleadersListBox;
        private Label label6;
        private Label label5;
        private Button addBtn;
        private Button deleteBtn;
        private Button viewBtn;
        private ListBox projectsListBox;
        private Button maxTlBtn;
        private Button midTlBtn;
        private Button allTlBtn;
        private Button editBtn;
        private TabControl tabControl;
        private Button createNewTLBtn;
        private Button minTlBtn;
        private Button deleteTLBtn;
        private Button addTLBtn;
        private Button refreshTL;
    }
}