namespace Assignment_2
{
    partial class ManageTeams
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddTeams = new System.Windows.Forms.Button();
            this.btnViewEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
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
            // btnAddTeams
            // 
            this.btnAddTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeams.Location = new System.Drawing.Point(49, 58);
            this.btnAddTeams.Name = "btnAddTeams";
            this.btnAddTeams.Size = new System.Drawing.Size(178, 46);
            this.btnAddTeams.TabIndex = 40;
            this.btnAddTeams.Text = "Add Teams";
            this.btnAddTeams.UseVisualStyleBackColor = true;
            this.btnAddTeams.Click += new System.EventHandler(this.btnAddTeams_Click);
            // 
            // btnViewEdit
            // 
            this.btnViewEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEdit.Location = new System.Drawing.Point(49, 129);
            this.btnViewEdit.Name = "btnViewEdit";
            this.btnViewEdit.Size = new System.Drawing.Size(178, 47);
            this.btnViewEdit.TabIndex = 41;
            this.btnViewEdit.Text = "Edit / View Teams";
            this.btnViewEdit.UseVisualStyleBackColor = true;
            this.btnViewEdit.Click += new System.EventHandler(this.btnViewEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "Team Management";
            // 
            // ManageTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewEdit);
            this.Controls.Add(this.btnAddTeams);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManageTeams";
            this.Text = "Manage Teams";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageTeams_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem HowToMenuItem;
        private System.Windows.Forms.Button btnAddTeams;
        private System.Windows.Forms.Button btnViewEdit;
        private System.Windows.Forms.Label label1;
    }
}