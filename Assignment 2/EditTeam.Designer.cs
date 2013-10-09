namespace Assignment_2
{
    partial class EditTeam
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectRegionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.EditSalesmanLeaderCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditLeader = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblLeaderName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnRemoveFromTeam = new System.Windows.Forms.Button();
            this.SalesmenToRemoveCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTeamReport = new System.Windows.Forms.Button();
            this.btnViewMembers = new System.Windows.Forms.Button();
            this.ViewinglistBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.btnSearchTeams = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalesSearch = new System.Windows.Forms.TextBox();
            this.btnViewTeams = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem5.Text = "About";
            // 
            // HowToMenuItem
            // 
            this.HowToMenuItem.Name = "HowToMenuItem";
            this.HowToMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HowToMenuItem.Size = new System.Drawing.Size(157, 22);
            this.HowToMenuItem.Text = "How To Use";
            this.HowToMenuItem.Click += new System.EventHandler(this.HowToMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Edit Team";
            // 
            // SelectRegionComboBox
            // 
            this.SelectRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRegionComboBox.FormattingEnabled = true;
            this.SelectRegionComboBox.Items.AddRange(new object[] {
            "Select Region",
            "Asia",
            "Australia and Oceania",
            "Central America and the Caribbean",
            "Europe",
            "Middle East, North Africa and Greater Arabia",
            "North America",
            "South America",
            "Sub-Saharan Africa"});
            this.SelectRegionComboBox.Location = new System.Drawing.Point(92, 58);
            this.SelectRegionComboBox.Name = "SelectRegionComboBox";
            this.SelectRegionComboBox.Size = new System.Drawing.Size(207, 21);
            this.SelectRegionComboBox.TabIndex = 0;
            this.SelectRegionComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectRegionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Select Region";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Select Team";
            // 
            // SelectTeamComboBox
            // 
            this.SelectTeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTeamComboBox.FormattingEnabled = true;
            this.SelectTeamComboBox.Location = new System.Drawing.Point(92, 87);
            this.SelectTeamComboBox.Name = "SelectTeamComboBox";
            this.SelectTeamComboBox.Size = new System.Drawing.Size(207, 21);
            this.SelectTeamComboBox.TabIndex = 1;
            this.SelectTeamComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectTeamComboBox_SelectedIndexChanged);
            // 
            // EditSalesmanLeaderCheckedListBox
            // 
            this.EditSalesmanLeaderCheckedListBox.FormattingEnabled = true;
            this.EditSalesmanLeaderCheckedListBox.Location = new System.Drawing.Point(6, 66);
            this.EditSalesmanLeaderCheckedListBox.Name = "EditSalesmanLeaderCheckedListBox";
            this.EditSalesmanLeaderCheckedListBox.Size = new System.Drawing.Size(149, 154);
            this.EditSalesmanLeaderCheckedListBox.TabIndex = 46;
            this.EditSalesmanLeaderCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EditSalesmanLeaderCheckedListBox_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Select Leader";
            // 
            // btnEditLeader
            // 
            this.btnEditLeader.Location = new System.Drawing.Point(6, 226);
            this.btnEditLeader.Name = "btnEditLeader";
            this.btnEditLeader.Size = new System.Drawing.Size(75, 23);
            this.btnEditLeader.TabIndex = 2;
            this.btnEditLeader.Text = "Edit Leader";
            this.btnEditLeader.UseVisualStyleBackColor = true;
            this.btnEditLeader.Click += new System.EventHandler(this.btnEditLeader_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Current Leader: ";
            // 
            // lblLeaderName
            // 
            this.lblLeaderName.AutoSize = true;
            this.lblLeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderName.Location = new System.Drawing.Point(3, 50);
            this.lblLeaderName.Name = "lblLeaderName";
            this.lblLeaderName.Size = new System.Drawing.Size(57, 13);
            this.lblLeaderName.TabIndex = 50;
            this.lblLeaderName.Text = "No Leader";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditSalesmanLeaderCheckedListBox);
            this.groupBox1.Controls.Add(this.lblLeaderName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEditLeader);
            this.groupBox1.Location = new System.Drawing.Point(14, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 259);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Leader";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteTeam);
            this.groupBox2.Controls.Add(this.btnRemoveFromTeam);
            this.groupBox2.Controls.Add(this.SalesmenToRemoveCheckedListBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(182, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 259);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Salesman";
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.AutoSize = true;
            this.btnDeleteTeam.Location = new System.Drawing.Point(9, 223);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(78, 23);
            this.btnDeleteTeam.TabIndex = 3;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnRemoveFromTeam
            // 
            this.btnRemoveFromTeam.AutoSize = true;
            this.btnRemoveFromTeam.Location = new System.Drawing.Point(9, 194);
            this.btnRemoveFromTeam.Name = "btnRemoveFromTeam";
            this.btnRemoveFromTeam.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveFromTeam.TabIndex = 2;
            this.btnRemoveFromTeam.Text = "Remove From Team";
            this.btnRemoveFromTeam.UseVisualStyleBackColor = true;
            this.btnRemoveFromTeam.Click += new System.EventHandler(this.btnRemoveFromTeam_Click);
            // 
            // SalesmenToRemoveCheckedListBox
            // 
            this.SalesmenToRemoveCheckedListBox.FormattingEnabled = true;
            this.SalesmenToRemoveCheckedListBox.Location = new System.Drawing.Point(9, 34);
            this.SalesmenToRemoveCheckedListBox.Name = "SalesmenToRemoveCheckedListBox";
            this.SalesmenToRemoveCheckedListBox.Size = new System.Drawing.Size(149, 154);
            this.SalesmenToRemoveCheckedListBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Slect Salesmen to Remove";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTeamReport);
            this.groupBox3.Controls.Add(this.btnViewMembers);
            this.groupBox3.Controls.Add(this.ViewinglistBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(356, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 287);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Viewing Details";
            // 
            // btnTeamReport
            // 
            this.btnTeamReport.AutoSize = true;
            this.btnTeamReport.Location = new System.Drawing.Point(10, 259);
            this.btnTeamReport.Name = "btnTeamReport";
            this.btnTeamReport.Size = new System.Drawing.Size(79, 23);
            this.btnTeamReport.TabIndex = 3;
            this.btnTeamReport.Text = "Team Report";
            this.btnTeamReport.UseVisualStyleBackColor = true;
            this.btnTeamReport.Click += new System.EventHandler(this.btnTeamReport_Click);
            // 
            // btnViewMembers
            // 
            this.btnViewMembers.AutoSize = true;
            this.btnViewMembers.Location = new System.Drawing.Point(10, 229);
            this.btnViewMembers.Name = "btnViewMembers";
            this.btnViewMembers.Size = new System.Drawing.Size(128, 23);
            this.btnViewMembers.TabIndex = 2;
            this.btnViewMembers.Text = "View Members In Team";
            this.btnViewMembers.UseVisualStyleBackColor = true;
            this.btnViewMembers.Click += new System.EventHandler(this.btnViewMembers_Click);
            // 
            // ViewinglistBox
            // 
            this.ViewinglistBox.FormattingEnabled = true;
            this.ViewinglistBox.Location = new System.Drawing.Point(10, 37);
            this.ViewinglistBox.Name = "ViewinglistBox";
            this.ViewinglistBox.Size = new System.Drawing.Size(139, 186);
            this.ViewinglistBox.TabIndex = 1;
            this.ViewinglistBox.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.ViewinglistBox.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select Salesman To Edit";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 377);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnViewTeams);
            this.groupBox4.Controls.Add(this.SearchListBox);
            this.groupBox4.Controls.Add(this.btnSearchTeams);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSalesSearch);
            this.groupBox4.Location = new System.Drawing.Point(518, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 287);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Searching";
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.Location = new System.Drawing.Point(9, 20);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(166, 173);
            this.SearchListBox.TabIndex = 4;
            this.SearchListBox.SelectedIndexChanged += new System.EventHandler(this.SearchListBox_SelectedIndexChanged);
            // 
            // btnSearchTeams
            // 
            this.btnSearchTeams.Location = new System.Drawing.Point(100, 223);
            this.btnSearchTeams.Name = "btnSearchTeams";
            this.btnSearchTeams.Size = new System.Drawing.Size(75, 23);
            this.btnSearchTeams.TabIndex = 3;
            this.btnSearchTeams.Text = "Search";
            this.btnSearchTeams.UseVisualStyleBackColor = true;
            this.btnSearchTeams.Click += new System.EventHandler(this.btnSearchTeams_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Search Sales";
            // 
            // txtSalesSearch
            // 
            this.txtSalesSearch.Location = new System.Drawing.Point(75, 199);
            this.txtSalesSearch.Name = "txtSalesSearch";
            this.txtSalesSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSalesSearch.TabIndex = 1;
            // 
            // btnViewTeams
            // 
            this.btnViewTeams.AutoSize = true;
            this.btnViewTeams.Location = new System.Drawing.Point(86, 252);
            this.btnViewTeams.Name = "btnViewTeams";
            this.btnViewTeams.Size = new System.Drawing.Size(89, 23);
            this.btnViewTeams.TabIndex = 5;
            this.btnViewTeams.Text = "View All Teams";
            this.btnViewTeams.UseVisualStyleBackColor = true;
            this.btnViewTeams.Click += new System.EventHandler(this.btnViewTeams_Click);
            // 
            // EditTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 413);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectTeamComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectRegionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "EditTeam";
            this.Text = "Edit Team";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTeam_FormClosing);
            this.Load += new System.EventHandler(this.EditTeam_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem HowToMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectRegionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectTeamComboBox;
        private System.Windows.Forms.CheckedListBox EditSalesmanLeaderCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditLeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblLeaderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveFromTeam;
        private System.Windows.Forms.CheckedListBox SalesmenToRemoveCheckedListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ViewinglistBox;
        private System.Windows.Forms.Button btnViewMembers;
        private System.Windows.Forms.Button btnTeamReport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearchTeams;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalesSearch;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.Button btnViewTeams;
    }
}