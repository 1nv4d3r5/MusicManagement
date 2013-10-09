namespace Assignment_2
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSalesman = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTeamManagement = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsMenuItem,
            this.saveMenuItem,
            this.openMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsMenuItem.Text = "Save As";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // btnAddSalesman
            // 
            this.btnAddSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalesman.Location = new System.Drawing.Point(62, 40);
            this.btnAddSalesman.Name = "btnAddSalesman";
            this.btnAddSalesman.Size = new System.Drawing.Size(297, 49);
            this.btnAddSalesman.TabIndex = 1;
            this.btnAddSalesman.Text = "Add Salesman";
            this.btnAddSalesman.UseVisualStyleBackColor = true;
            this.btnAddSalesman.Click += new System.EventHandler(this.btnAddSalesman_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(62, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(297, 48);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Edit, Search Or View Salesman ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTeamManagement
            // 
            this.btnTeamManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamManagement.Location = new System.Drawing.Point(62, 182);
            this.btnTeamManagement.Name = "btnTeamManagement";
            this.btnTeamManagement.Size = new System.Drawing.Size(297, 48);
            this.btnTeamManagement.TabIndex = 3;
            this.btnTeamManagement.Text = "Team Management";
            this.btnTeamManagement.UseVisualStyleBackColor = true;
            this.btnTeamManagement.Click += new System.EventHandler(this.btnTeamManagement_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.btnTeamManagement);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddSalesman);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sales-of-the-Century Personnel Management System ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.Button btnAddSalesman;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTeamManagement;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
    }
}

