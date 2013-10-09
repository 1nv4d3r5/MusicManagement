namespace Assignment_2
{
    partial class AddTeam
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
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salesmancheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teamNameCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.teamMemberCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetLeader = new System.Windows.Forms.Button();
            this.btnViewTeamMember = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 38;
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
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
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
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "Select Region",
            "Asia",
            "Australia and Oceania",
            "Central America and the Caribbean",
            "Europe",
            "Middle East, North Africa and Greater Arabia",
            "North America",
            "South America",
            "Sub-Saharan Africa"});
            this.regionComboBox.Location = new System.Drawing.Point(150, 71);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(222, 21);
            this.regionComboBox.TabIndex = 39;
            this.regionComboBox.SelectedIndexChanged += new System.EventHandler(this.regionComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 40;
            this.label1.Text = "Add Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Select Region To Manage";
            // 
            // salesmancheckedListBox
            // 
            this.salesmancheckedListBox.FormattingEnabled = true;
            this.salesmancheckedListBox.Location = new System.Drawing.Point(14, 144);
            this.salesmancheckedListBox.Name = "salesmancheckedListBox";
            this.salesmancheckedListBox.Size = new System.Drawing.Size(178, 199);
            this.salesmancheckedListBox.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Salesmen";
            // 
            // teamNameCheckedListBox
            // 
            this.teamNameCheckedListBox.FormattingEnabled = true;
            this.teamNameCheckedListBox.Location = new System.Drawing.Point(209, 144);
            this.teamNameCheckedListBox.Name = "teamNameCheckedListBox";
            this.teamNameCheckedListBox.Size = new System.Drawing.Size(178, 199);
            this.teamNameCheckedListBox.TabIndex = 44;
            this.teamNameCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.teamNamecheckedListBox_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Team Name";
            // 
            // btnAddToTeam
            // 
            this.btnAddToTeam.AutoSize = true;
            this.btnAddToTeam.Location = new System.Drawing.Point(12, 349);
            this.btnAddToTeam.Name = "btnAddToTeam";
            this.btnAddToTeam.Size = new System.Drawing.Size(131, 23);
            this.btnAddToTeam.TabIndex = 48;
            this.btnAddToTeam.Text = "Add Salesman To Team";
            this.btnAddToTeam.UseVisualStyleBackColor = true;
            this.btnAddToTeam.Click += new System.EventHandler(this.btnAddToTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(198, 102);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(120, 23);
            this.btnAddTeam.TabIndex = 49;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // teamMemberCheckedListBox
            // 
            this.teamMemberCheckedListBox.FormattingEnabled = true;
            this.teamMemberCheckedListBox.Location = new System.Drawing.Point(404, 144);
            this.teamMemberCheckedListBox.Name = "teamMemberCheckedListBox";
            this.teamMemberCheckedListBox.Size = new System.Drawing.Size(178, 199);
            this.teamMemberCheckedListBox.TabIndex = 50;
            this.teamMemberCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.teamMemberCheckedListBox_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Team Members";
            // 
            // btnSetLeader
            // 
            this.btnSetLeader.AutoSize = true;
            this.btnSetLeader.Location = new System.Drawing.Point(404, 349);
            this.btnSetLeader.Name = "btnSetLeader";
            this.btnSetLeader.Size = new System.Drawing.Size(75, 23);
            this.btnSetLeader.TabIndex = 52;
            this.btnSetLeader.Text = "Set Leader";
            this.btnSetLeader.UseVisualStyleBackColor = true;
            this.btnSetLeader.Click += new System.EventHandler(this.btnSetLeader_Click);
            // 
            // btnViewTeamMember
            // 
            this.btnViewTeamMember.AutoSize = true;
            this.btnViewTeamMember.Location = new System.Drawing.Point(209, 349);
            this.btnViewTeamMember.Name = "btnViewTeamMember";
            this.btnViewTeamMember.Size = new System.Drawing.Size(116, 23);
            this.btnViewTeamMember.TabIndex = 53;
            this.btnViewTeamMember.Text = "View Team Members";
            this.btnViewTeamMember.UseVisualStyleBackColor = true;
            this.btnViewTeamMember.Click += new System.EventHandler(this.btnViewTeamMember_Click);
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 375);
            this.Controls.Add(this.btnViewTeamMember);
            this.Controls.Add(this.btnSetLeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teamMemberCheckedListBox);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnAddToTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamNameCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salesmancheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddTeam";
            this.Text = "Add Team";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTeam_FormClosing);
            this.Load += new System.EventHandler(this.TeamManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem HowToMenuItem;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox salesmancheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox teamNameCheckedListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox teamMemberCheckedListBox;
        private System.Windows.Forms.Button btnSetLeader;
        private System.Windows.Forms.Button btnViewTeamMember;
    }
}