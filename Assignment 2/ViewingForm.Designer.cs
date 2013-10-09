namespace Assignment_2
{
    partial class ViewingForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOver1m = new System.Windows.Forms.Button();
            this.regionCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearchOverValue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(375, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 264);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(52, 382);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.AutoSize = true;
            this.btnSearchName.Location = new System.Drawing.Point(11, 319);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(82, 23);
            this.btnSearchName.TabIndex = 5;
            this.btnSearchName.Text = "Search Name";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(55, 293);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(238, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOver1m
            // 
            this.btnOver1m.AutoSize = true;
            this.btnOver1m.Location = new System.Drawing.Point(133, 382);
            this.btnOver1m.Name = "btnOver1m";
            this.btnOver1m.Size = new System.Drawing.Size(93, 23);
            this.btnOver1m.TabIndex = 9;
            this.btnOver1m.Text = "Sales Over $1M";
            this.btnOver1m.UseVisualStyleBackColor = true;
            this.btnOver1m.Click += new System.EventHandler(this.btnOver1m_Click);
            // 
            // regionCombobox
            // 
            this.regionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionCombobox.FormattingEnabled = true;
            this.regionCombobox.Items.AddRange(new object[] {
            "Select Region",
            "Asia",
            "Australia and Oceania",
            "Central America and the Caribbean",
            "Europe",
            "Middle East, North Africa and Greater Arabia",
            "North America",
            "South America",
            "Sub-Saharan Africa"});
            this.regionCombobox.Location = new System.Drawing.Point(107, 355);
            this.regionCombobox.Name = "regionCombobox";
            this.regionCombobox.Size = new System.Drawing.Size(212, 21);
            this.regionCombobox.TabIndex = 10;
            this.regionCombobox.SelectedIndexChanged += new System.EventHandler(this.regionCombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Search by Region:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSearchOverValue
            // 
            this.btnSearchOverValue.AutoSize = true;
            this.btnSearchOverValue.Location = new System.Drawing.Point(99, 319);
            this.btnSearchOverValue.Name = "btnSearchOverValue";
            this.btnSearchOverValue.Size = new System.Drawing.Size(107, 23);
            this.btnSearchOverValue.TabIndex = 12;
            this.btnSearchOverValue.Text = "Search Value Over";
            this.btnSearchOverValue.UseVisualStyleBackColor = true;
            this.btnSearchOverValue.Click += new System.EventHandler(this.btnSearchOverValue_Click);
            // 
            // ViewingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 421);
            this.Controls.Add(this.btnSearchOverValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regionCombobox);
            this.Controls.Add(this.btnOver1m);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewingForm";
            this.Text = "Viewing Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewingForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewingForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOver1m;
        private System.Windows.Forms.ComboBox regionCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSearchOverValue;
    }
}