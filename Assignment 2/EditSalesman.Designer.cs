namespace Assignment_2
{
    partial class EditSalesman
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMobileNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOfficeNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetName2 = new System.Windows.Forms.TextBox();
            this.txtStreetName1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.countryCombobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToUseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeleteSalesman = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Salesman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(159, 87);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(159, 113);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(203, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Validating += new System.ComponentModel.CancelEventHandler(this.txtSurname_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date Of Birth";
            // 
            // txtMobileNum
            // 
            this.txtMobileNum.Location = new System.Drawing.Point(158, 192);
            this.txtMobileNum.Name = "txtMobileNum";
            this.txtMobileNum.Size = new System.Drawing.Size(203, 20);
            this.txtMobileNum.TabIndex = 4;
            this.txtMobileNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtMobileNum_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mobile Phone Number";
            // 
            // txtOfficeNum
            // 
            this.txtOfficeNum.Location = new System.Drawing.Point(158, 218);
            this.txtOfficeNum.Name = "txtOfficeNum";
            this.txtOfficeNum.Size = new System.Drawing.Size(203, 20);
            this.txtOfficeNum.TabIndex = 5;
            this.txtOfficeNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtOfficeNum_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Office Number";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(203, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email Address";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 139);
            this.dateTimePicker1.MaxDate = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(1980, 1, 1, 9, 37, 0, 0);
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(158, 244);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(203, 20);
            this.txtTotalSales.TabIndex = 6;
            this.txtTotalSales.Validating += new System.ComponentModel.CancelEventHandler(this.txtTotalSales_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Total Sales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Street Name/Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Country";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(139, 71);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(203, 20);
            this.txtCity.TabIndex = 9;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // txtStreetName2
            // 
            this.txtStreetName2.Location = new System.Drawing.Point(139, 45);
            this.txtStreetName2.Name = "txtStreetName2";
            this.txtStreetName2.Size = new System.Drawing.Size(203, 20);
            this.txtStreetName2.TabIndex = 8;
            // 
            // txtStreetName1
            // 
            this.txtStreetName1.Location = new System.Drawing.Point(139, 19);
            this.txtStreetName1.Name = "txtStreetName1";
            this.txtStreetName1.Size = new System.Drawing.Size(203, 20);
            this.txtStreetName1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegion);
            this.groupBox1.Controls.Add(this.countryCombobox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtStreetName1);
            this.groupBox1.Controls.Add(this.txtStreetName2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Location = new System.Drawing.Point(10, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(140, 124);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.ReadOnly = true;
            this.txtRegion.Size = new System.Drawing.Size(233, 20);
            this.txtRegion.TabIndex = 38;
            // 
            // countryCombobox
            // 
            this.countryCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombobox.FormattingEnabled = true;
            this.countryCombobox.Items.AddRange(new object[] {
            "Select Country"});
            this.countryCombobox.Location = new System.Drawing.Point(140, 97);
            this.countryCombobox.Name = "countryCombobox";
            this.countryCombobox.Size = new System.Drawing.Size(233, 21);
            this.countryCombobox.TabIndex = 10;
            this.countryCombobox.SelectedIndexChanged += new System.EventHandler(this.countrybox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Region";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.AutoSize = true;
            this.btnSaveChanges.Location = new System.Drawing.Point(13, 426);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(87, 23);
            this.btnSaveChanges.TabIndex = 12;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "$";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.exitMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printToolStripMenuItem.Text = "Print Details";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToUseMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem5.Text = "About";
            // 
            // HowToUseMenuItem
            // 
            this.HowToUseMenuItem.Name = "HowToUseMenuItem";
            this.HowToUseMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HowToUseMenuItem.Size = new System.Drawing.Size(157, 22);
            this.HowToUseMenuItem.Text = "How To Use";
            this.HowToUseMenuItem.Click += new System.EventHandler(this.HowToUseMenuItem_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(159, 61);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(203, 20);
            this.txtEmpID.TabIndex = 0;
            this.txtEmpID.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmpID_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Employee ID";
            // 
            // btnDeleteSalesman
            // 
            this.btnDeleteSalesman.AutoSize = true;
            this.btnDeleteSalesman.Location = new System.Drawing.Point(107, 425);
            this.btnDeleteSalesman.Name = "btnDeleteSalesman";
            this.btnDeleteSalesman.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteSalesman.TabIndex = 42;
            this.btnDeleteSalesman.Text = "Delete Salesman";
            this.btnDeleteSalesman.UseVisualStyleBackColor = true;
            this.btnDeleteSalesman.Click += new System.EventHandler(this.btnDeleteSalesman_Click);
            // 
            // EditSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 455);
            this.Controls.Add(this.btnDeleteSalesman);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOfficeNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMobileNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditSalesman";
            this.Text = "Edit Salesman";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSalesman_FormClosing);
            this.Load += new System.EventHandler(this.EditSalesman_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMobileNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOfficeNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetName2;
        private System.Windows.Forms.TextBox txtStreetName1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox countryCombobox;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem HowToUseMenuItem;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDeleteSalesman;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    }
}