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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabControl.Size = new System.Drawing.Size(1042, 531);
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
            this.projectsTabPage.Size = new System.Drawing.Size(1034, 493);
            this.projectsTabPage.TabIndex = 0;
            this.projectsTabPage.Text = "Projects      ";
            this.projectsTabPage.Click += new System.EventHandler(this.projectsTabPage_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(848, 340);
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
            this.deleteBtn.Location = new System.Drawing.Point(848, 190);
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
            this.viewBtn.Location = new System.Drawing.Point(848, 47);
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
            this.projectsListBox.Size = new System.Drawing.Size(682, 350);
            this.projectsListBox.TabIndex = 1;
            this.projectsListBox.SelectedIndexChanged += new System.EventHandler(this.projectsListBox_SelectedIndexChanged);
            // 
            // editBtn
            // 
            this.editBtn.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editBtn.Location = new System.Drawing.Point(848, 122);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(154, 43);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Edit Project";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cohorts      ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 493);
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
            this.ClientSize = new System.Drawing.Size(1041, 576);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEPA PTS";
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
        private ListBox projectsListBox;
        private Button editBtn;
        private Button viewBtn;
        private Button deleteBtn;
        private Button addBtn;
    }
}