using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Assignment_2
{
    public partial class ViewingForm : Form
    {
        List<TeamDetails> salesmanList = new List<TeamDetails>();

        private string toSearch
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        private string selectedRegion
        {
            get { return regionCombobox.SelectedItem.ToString(); }
        }
        
        public ViewingForm()
        {
            InitializeComponent();
        }
        /**
         * This method defines the form loading
         */
        private void ViewingForm_Load(object sender, EventArgs e)
        {
            salesmanList = GlobalVariables.allSalesmenList;
            regionCombobox.SelectedItem = "Select Region";
        }
        /**
         * This method defines what happens when the view all button is clicked
         */
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBox1.DataSource = null;
                this.listBox1.DataSource = salesmanList;
                this.listBox1.DisplayMember = "fullName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /**
         * This method defines what happens when the search name button is clicked
         */
        private void btnSearchName_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesmanList.Count == 0)
                {
                    throw new Exception("Database does not contain any salesmen.");
                }
                if (string.IsNullOrEmpty(toSearch))
                {
                    throw new Exception("Please enter a salesman to search");
                }
                else
                {
                    var editList = 
                        from sm in GlobalVariables.allSalesmenList
                        where sm.fullName.ToLower().Contains(toSearch.ToLower())
                        select sm;
                    listBox1.DataSource = editList.ToList();
                    this.listBox1.DisplayMember = "fullName";
                    if (editList.Count() == 0)
                    {
                        throw new Exception("No Salesman found");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * This method defines what happens when the selected value is changed in the listbox
         */
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    GlobalVariables.currentSalesmanDetails = listBox1.SelectedItem as TeamDetails;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * This method defines what happens when the form closes
         */
        private void ViewingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                DialogResult result = MessageBox.Show("Do you really want to exit to main form?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    MainForm x = new MainForm();
                    x.Show();
                }
                else
                    e.Cancel = true;
        }

        /**
         * This method defines the clear form button
         */
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listBox1.DataSource = null;
            regionCombobox.SelectedItem = "Select Region";
            toSearch = string.Empty;

        }

        /**
         * This method defines what happens when exit is pressed in the menu
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * This method defines what happens when the sales over $1m is pressed
         */
        private void btnOver1m_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesmanList.Count == 0)
                {
                    throw new Exception("Database does not contain any salesmen.");
                }
                else
                {
                    errorProvider1.Dispose();
                    var over1mList =
                        from sm in GlobalVariables.allSalesmenList
                        where sm.sales >= 1000000
                        select sm;
                    listBox1.DataSource = over1mList.ToList();
                    this.listBox1.DisplayMember = "fullName";
                    if (over1mList.Count() == 0)
                    {
                        throw new Exception("No Salesman found with sales over $1M");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the listbox is doubleclicked
         */
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count == 0)
                {
                    throw new Exception("No salesman has selected. \nPlease search for salesman or click 'View All'");
                }
                else
                {
                    var edit = new EditSalesman();
                    edit.Show(this);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the region is changed
         */
        private void regionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                toSearch = string.Empty;
                listBox1.DataSource = null;
                var regionList =
                            from sm in GlobalVariables.allSalesmenList
                            where sm.region.Equals(selectedRegion)
                            select sm;

                if (regionCombobox.Focused && regionCombobox.SelectedIndex==0)
                {
                    errorProvider1.Clear();
                }
                else if (regionCombobox.Focused && regionList.Count() == 0)
                {
                    errorProvider1.SetError(regionCombobox, "No salesmen in " + selectedRegion);
                }
                else
                    errorProvider1.Clear();
                listBox1.DataSource = regionList.ToList();
                this.listBox1.DisplayMember = "fullName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * This method defines what happens when the search value over is pressed
         */
        private void btnSearchOverValue_Click(object sender, EventArgs e)
        {
            try
            {
                if (salesmanList.Count == 0)
                {
                    throw new Exception("Database does not contain any salesmen.");
                }
                if (string.IsNullOrEmpty(toSearch))
                {
                    throw new Exception("Please enter a salesman to search");
                }
                else
                {
                    var overValueList =
                        from sm in GlobalVariables.allSalesmenList
                        where sm.sales>=Convert.ToInt32(toSearch)
                        select sm;
                    listBox1.DataSource = overValueList.ToList();
                    this.listBox1.DisplayMember = "fullName";
                    if (overValueList.Count() == 0)
                    {
                        throw new Exception("No Salesman found with sales over $"+toSearch);
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input must be in numbers");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the how to use button is pressed in the menu
         */
        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "1) To View all salesmen in database Press 'View All'"
                + "\n2) To View Salesmen in a specific region select the region via the combo box"
                + "\n3) To search for salesmen over $1m click 'Sales over $1M'"
                + "\n4) To search for salesmen with a given string, enter string in text box and click 'Search Name'"
                + "\n5) To search for salesmen with sales over a certain value, enter value in text box and click 'Search Over Value'"
                +"\n6) The form can be cleared by pressing 'Clear Form'"
                , "How To Use");
        }
    }
}