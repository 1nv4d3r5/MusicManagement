using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Globalization;

namespace Assignment_2
{
    public partial class EditTeam : Form
    {
        IEnumerable<TeamDetails> viewList = new List<TeamDetails>();//IEnumerable list to hold team member details for printing
        
        private string selectedRegion
        {
            get { return SelectRegionComboBox.SelectedItem.ToString(); }//getting selected region from combo box
        }

        private string selectedTeam { get; set; } //getter and setter for selected team
        private string selectedLeadTeamMember { get; set; }
        private string selectedTeamMemberToRemove { get; set; }

        public EditTeam()
        {
            InitializeComponent();
        }

        /**
         * This method defines what occurs when the form loads
         */
        private void EditTeam_Load(object sender, EventArgs e)
        {
            SelectRegionComboBox.SelectedItem = "Select Region";
        }

        /**
         * This method defines what happens when the region combo box value is changed
         */
        private void SelectRegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTeamComboBox.Items.Clear(); //clear items in select team combo box
            SelectTeamComboBox.Items.Add("Select Team");//add select team to select team combo box
            SelectTeamComboBox.SelectedItem = "Select Team";//select 'Select Team' option
            foreach (TeamDetails sm in GlobalVariables.allSalesmenList)//go through every TeamDetails in the global list
            {
                if (sm.region.Equals(selectedRegion) && !sm.teamName.Equals(String.Empty))//if selected region is in the list
                {
                    if (!SelectTeamComboBox.Items.Contains(sm.teamName))//if the select team combo box doesn't have the team
                        SelectTeamComboBox.Items.Add(sm.teamName);//add team to selectTeam combo box
                }

            }
            if (SelectTeamComboBox.Items.Count == 1)//check if team is in a region
                errorProvider1.SetError(SelectRegionComboBox, "Select different Region");
            else
                errorProvider1.Dispose();//clear error provider
        }

        /**
         * This method defines what happens when the select team combo box value is changed
         */
        private void SelectTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTeam = SelectTeamComboBox.SelectedItem.ToString();//set selected team as selected item in team combo box
            //clear items from edit salesman list box and salesmen to remove list box
            EditSalesmanLeaderCheckedListBox.Items.Clear();
            SalesmenToRemoveCheckedListBox.Items.Clear();
            lblLeaderName.Text = "No Leader";//set default string
            foreach (var teamMem in GlobalVariables.allSalesmenList)
            {
                if (teamMem.region.Equals(selectedRegion) && teamMem.teamName.Equals(selectedTeam))//checking list for selected team and region
                {
                    EditSalesmanLeaderCheckedListBox.Items.Add(teamMem.fullName);//add team members to listbox
                    SalesmenToRemoveCheckedListBox.Items.Add(teamMem.fullName);//add team members to listbox
                    if (string.IsNullOrEmpty(teamMem.teamLeader))//if the team doesn't have a leader set set label as no team leader
                        lblLeaderName.Text = "No Team Leader";
                    else
                        lblLeaderName.Text = teamMem.teamLeader;//other wise set it as the leader name
                }
            }

        }

        /**
         * This method allows only one item to be checked in check list box
         */
        private void EditSalesmanLeaderCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedLeadTeamMember = (string)this.EditSalesmanLeaderCheckedListBox.Items[e.Index];
            //the code below was obtained from: http://stackoverflow.com/questions/5256967/how-to-check-only-one-item-in-checkedlistbox
            if (EditSalesmanLeaderCheckedListBox.CheckedItems.Count == 1)
            {
                bool isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                    e.NewValue = CheckState.Checked;
                else
                {
                    Int32 checkedItemIndex = EditSalesmanLeaderCheckedListBox.CheckedIndices[0];
                    EditSalesmanLeaderCheckedListBox.ItemCheck -= EditSalesmanLeaderCheckedListBox_ItemCheck;
                    EditSalesmanLeaderCheckedListBox.SetItemChecked(checkedItemIndex, false);
                    EditSalesmanLeaderCheckedListBox.ItemCheck += EditSalesmanLeaderCheckedListBox_ItemCheck;
                }
                return;
            }
        }

        /**
         * This method defines what happens when the edit leader button is pressed
         */
        private void btnEditLeader_Click(object sender, EventArgs e)
        {
            foreach (var leader in GlobalVariables.allSalesmenList)
            {
                if (leader.teamName.Equals(selectedTeam))//check if selected team is in list
                {
                    if (string.IsNullOrEmpty(leader.teamLeader))//check if team leader is already set
                    {
                        lblLeaderName.Text = selectedLeadTeamMember;
                        leader.teamLeader = selectedLeadTeamMember;
                    }
                    else
                    {
                        if (leader.teamLeader.Equals(selectedLeadTeamMember))//check if person is already the leader
                            errorProvider1.SetError(btnEditLeader, selectedLeadTeamMember + " is already the team leader");
                        else
                        {
                            errorProvider1.Dispose();
                            DialogResult result = MessageBox.Show(this, "Are you sure you want to change the leader?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);//ask user to confirm that they want to change leader
                            if (result == DialogResult.Yes)
                            {
                                lblLeaderName.Text = selectedLeadTeamMember;
                                leader.teamLeader = selectedLeadTeamMember;//setting team leader
                            }
                        }
                    }
                }
            }
        }

        /**
         * This method defines what happens when the remove from team button is pressed
         */
        private void btnRemoveFromTeam_Click(object sender, EventArgs e)
        {
            int teamSalesChanged=0;
            if (SalesmenToRemoveCheckedListBox.CheckedItems.Count == 0)
                errorProvider1.SetError(btnRemoveFromTeam, "Select member to remove from team");//check if member is selected
            else
            {
                foreach (var toDelete in SalesmenToRemoveCheckedListBox.CheckedItems)//removing selected member
                {
                    foreach (var team in GlobalVariables.allSalesmenList)//going through main list
                    {
                        if (team.teamLeader.Equals(toDelete))//check if selected person is team leader
                            errorProvider1.SetError(btnRemoveFromTeam, "You cannot remove a team leader.\nIf you want to, you have to change the leader");
                        else if (team.fullName.Equals(toDelete))
                        {
                            DialogResult result = MessageBox.Show(this, "Are you sure you want to remove the salesman?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);//confirming that the user wants to delete the salesmen
                            if (result == DialogResult.Yes)
                            {
                                
                                errorProvider1.Clear();
                                ViewinglistBox.DataSource = null;
                                teamSalesChanged = team.teamSales - team.sales;//removing the sales of removed salesman
                                team.teamName = String.Empty;//clearing team name from salesmen
                                team.teamLeader = String.Empty;//clearing team leader from salesmen
                            }
                        }
                    }
                }
                foreach (var teamSalesToChange in GlobalVariables.allSalesmenList)
                {
                    if (teamSalesToChange.teamName.Equals(selectedTeam))
                    {
                        teamSalesToChange.teamSales = teamSalesChanged;
                    }
                }
            }
        }

        /**
         * This method defines what happens when the delete team button is pressed
         */
        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            if (selectedTeam == "Select Team")
                errorProvider1.SetError(btnDeleteTeam, "Select team to delete");//set error if no team selected
            else
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to delete the team?", "Confirm",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);//confirm delete team
                if (result == DialogResult.Yes)
                {
                    foreach (var person in SalesmenToRemoveCheckedListBox.Items)//going through all selected items
                    {
                        foreach (var teamToDelete in GlobalVariables.allSalesmenList)//finding selected items in main list
                        {
                            if(person.Equals(teamToDelete.fullName))
                            {
                                teamToDelete.teamName = string.Empty;//clearing team name
                                teamToDelete.teamLeader = string.Empty;//clearing team leader
                                teamToDelete.teamSales = 0;//setting team sales to 0
                            }
                        }
                    }

                    SelectTeamComboBox.SelectedItem = "Select Team";//setting
                    //clearing listboxes
                    ViewinglistBox.DataSource = null;
                    SalesmenToRemoveCheckedListBox.Items.Clear();
                    EditSalesmanLeaderCheckedListBox.Items.Clear();
                }
            }
        }

        /**
         * This method defines what happens you double click a member in viewing list box
         */
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ViewinglistBox.Items.Count == 0)
                {
                    throw new Exception("No salesman has selected. \nPlease Select a team or region or search for team"); //check if items are in listbox
                }
                if (ViewinglistBox.SelectedIndex < 0)
                {
                    throw new Exception("Select a salesman");//check if person is clicked
                }
                else
                {
                    EditSalesman edit = new EditSalesman();
                    edit.Show(this);//show edit salesman form
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * This method defines what happens when the view list box's index is changed
         */
        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ViewinglistBox.SelectedIndex != -1)
                {
                    GlobalVariables.currentSalesmanDetails = ViewinglistBox.SelectedItem as TeamDetails;//set selected salesman as a globally available one
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * This method defines what happens when view members button is pressed
         */
        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            viewList =
                        from sm in GlobalVariables.allSalesmenList 
                        where sm.teamName.Equals(selectedTeam)                        
                        select sm;//select all members in list that are in the selected list
            if (selectedTeam == "Select Team")
                errorProvider1.SetError(btnViewMembers, "Select Team");//make user select user
            else
            {
                ViewinglistBox.DataSource = viewList.ToList();//populate viewing list box
                ViewinglistBox.DisplayMember = "fullName";//show only full name of person
            }
        }

        /**
         * This method defines what happens when the form closes
         */
        private void EditTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to team management?\n", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);//confirm close
            if (result == DialogResult.Yes)
            {
                ManageTeams team = new ManageTeams();
                team.Show();//show manage teams form
            }
            else
                e.Cancel = true;
        }

        /**
         * This method defines what happens when the team report button is clicked
         */
        private void btnTeamReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedTeam))//check if team is selected 
            {
                errorProvider1.SetError(btnTeamReport, "Select Team");
                SelectTeamComboBox.Focus();
            }
            else if (viewList.Count() == 0)//check if members are in listbox
                errorProvider1.SetError(btnTeamReport, "Please click 'View Members In Team");
            else
            {
                errorProvider1.Dispose();
                PrintDocument printDoc = new PrintDocument();
                PrintPreviewDialog printPrev = new PrintPreviewDialog();
                printPrev.Document = printDoc;
                printDoc.PrintPage += (sender1, ex) => printDoc_PrintPage(sender1, ex, selectedTeam);//passing arguments to method with event handler
                printPrev.ShowDialog();
            }
        }
        /**
         * This method defines the string to be printed in dollar format 
         */
        public static class Cultures
        {
            public static readonly CultureInfo Australia =
                CultureInfo.ReadOnly(new CultureInfo("en-AU"));
        }
        /**
         * This method defines how the document is printed/previewed
         */
        void printDoc_PrintPage(object sender, PrintPageEventArgs e, string setTeamName)
        {
            //the method outline was obtained from: http://www.youtube.com/watch?v=ToRXCw91r-c
            Graphics graphic = e.Graphics;
            Font fnt = new Font("Courier New", 12);
            float fontHeight = fnt.GetHeight();
            Brush brsh = new SolidBrush(Color.Black);
            int startingX = 10;
            int startingY = 10;
            int offSet = 40;
            int totalSales = 0;
            string teamLeader = "";

            graphic.DrawString("Team Report for " + setTeamName, new Font("Courier New", 18), brsh, startingX, startingY);//print team name
            offSet = offSet + (int)fontHeight + 10;
            graphic.DrawString("Team Member".PadRight(30) + "Sales", fnt, brsh, startingX, startingY + offSet);//sub title
            offSet = offSet + (int)fontHeight + 5;

            foreach (var team in viewList)
            {
                teamLeader = team.teamLeader;
                string teamMember = team.fullName.PadRight(30);
                string salesmanTotal = String.Format("{0}", team.sales.ToString("C", Cultures.Australia));
                string salesmanLine = teamMember + salesmanTotal;
                totalSales = team.teamSales;
                graphic.DrawString(salesmanLine, fnt, brsh, startingX, startingY + offSet);
                offSet = offSet + (int)fontHeight + 5;

            }
            offSet = offSet + 10;
            graphic.DrawString("Team Leader".PadRight(30) + teamLeader, fnt, brsh, startingY, startingY + offSet);//show team leader
            offSet = offSet + 20;
            graphic.DrawString("Total Sales".PadRight(30) + String.Format("{0}", totalSales.ToString("C",Cultures.Australia)), fnt, brsh, startingX, startingY + offSet);//show team sales

        }

        /**
         * This method defines what happens when the clear button is pressed
         */
        private void btnClear_Click(object sender, EventArgs e)
        {
            SearchListBox.Items.Clear();
            txtSalesSearch.Text = string.Empty;
            EditSalesmanLeaderCheckedListBox.Items.Clear();
            SalesmenToRemoveCheckedListBox.Items.Clear();
            ViewinglistBox.DataSource = null;
            SelectRegionComboBox.SelectedItem = "Select Region";
            SelectTeamComboBox.SelectedItem = "Select Team";
        }

        /**
         * This method defines what happens when the search button is pressed
         */
        private void btnSearchTeams_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Dispose();
                if (String.IsNullOrEmpty(txtSalesSearch.Text))
                {
                    errorProvider1.SetError(btnSearchTeams, "Enter Value");
                }
                else
                {
                    foreach (var salesOver in GlobalVariables.allSalesmenList)
                    {
                        if (salesOver.teamSales > Convert.ToInt32(txtSalesSearch.Text)//check if main list's team sales are over searched value
                            && !SearchListBox.Items.Contains(salesOver.teamName))
                        {
                            SearchListBox.Items.Add(salesOver.teamName.ToString());//add results to searchlistbox
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * This method defines what happens when the 'how to use' menu item is cliked
         */
        private void HowToMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Edit Team Leader follow steps 1.x"
                + "\nTo Delete Team/Team members follow steps 2.x"
                +"\nTo View Team Details Follow steps 3.x"
                + "\nTo Search Teams follow steps 4.x"
                +"\n1.1) Select Region"
                +"\n1.2) Select Team"
                + "\n1.3) Select New Leader"
                +"\n1.4) Click 'Edit Leader'"
                +"\n2.1) Continue from 1.2 To Delete Team click 'Delete team'"
                + "\n2.2) Continue from 1.2 To Delete Team member, select member and click 'Remove From Team'"
                + "\n3.1) Continue from 1.2 click 'View Members in Team' in the viewing details group"
                +"\n3.2) Click 'Team Report' to view and print its report"
                +"\n4.1) Enter Value to search for teams over that value"
                +"\n4.2) Click 'Search' to search teams over given value"
                +"\n4.3) To view team members, select team and press view members."
                +"\n4.4) To generate report click 'Team Report' in the viewing details group"
                +"\n4.5) To view all teams in the database click 'View All Teams'"
                ,"How To Use");
        }

        /**
         * This method defines what happens when the index changes on in the search listbox
         */
        private void SearchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchListBox.SelectedIndex == -1)
                MessageBox.Show("Select Team");
            else
            {
                selectedTeam = SearchListBox.SelectedItem.ToString();
                EditSalesmanLeaderCheckedListBox.Items.Clear();
                SalesmenToRemoveCheckedListBox.Items.Clear();
                lblLeaderName.Text = "No Leader";//set default string
                foreach (var teamMem in GlobalVariables.allSalesmenList)
                {
                    if (teamMem.teamName.Equals(selectedTeam))//checking list for selected team and region
                    {
                        EditSalesmanLeaderCheckedListBox.Items.Add(teamMem.fullName);//add team members to listbox
                        SalesmenToRemoveCheckedListBox.Items.Add(teamMem.fullName);//add team members to listbox
                        if (string.IsNullOrEmpty(teamMem.teamLeader))//if the team doesn't have a leader set set label as no team leader
                            lblLeaderName.Text = "No Team Leader";
                        else
                            lblLeaderName.Text = teamMem.teamLeader;//other wise set it as the leader name
                    }
                }
                viewList =
                            from sm in GlobalVariables.allSalesmenList
                            where sm.teamName.Equals(selectedTeam)
                            select sm;//select all members in list that are in the selected list
                
                ViewinglistBox.DataSource = viewList.ToList();//set data source of viewing listbox
                ViewinglistBox.DisplayMember = "fullName";//show full name in listbox

            }
        }

        private void btnViewTeams_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            foreach (var allTeams in GlobalVariables.allSalesmenList)
            {
                if (!string.IsNullOrEmpty(allTeams.teamName) && !SearchListBox.Items.Contains(allTeams.teamName))
                {
                    SearchListBox.Items.Add(allTeams.teamName);
                }
            }
            if (SearchListBox.Items.Count == 0)
                errorProvider1.SetError(btnViewTeams, "No Teams Available");
            else
                errorProvider1.Dispose();
        }

    }
}

