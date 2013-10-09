using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class AddTeam : Form
    {
        private int counterOfTeams = 1;

        private string selectedRegion
        {
            get { return regionComboBox.SelectedItem.ToString(); }//getting the selected region from the combobox
        }
        private string selectedTeam { get; set; }
        private string selectedMember { get; set; }
        

        public AddTeam()
        {
            InitializeComponent();
        }
        /**
         * This method defines what happens when the form is loaded
         */
        private void TeamManagement_Load(object sender, EventArgs e)
        {
            this.regionComboBox.SelectedItem = "Select Region";
        }
        /**
         * This method defines what happens when the exit menu is pressed
         */
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * This method defines what happens when the region is changed
         */
        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                teamNameCheckedListBox.Items.Clear();
                counterOfTeams = 1;
                foreach (TeamDetails dets in GlobalVariables.allSalesmenList)
                {
                    if (dets.region.Equals(regionComboBox.SelectedItem.ToString()) 
                        && !string.IsNullOrEmpty(dets.teamName) 
                        &&  !teamNameCheckedListBox.Items.Contains(dets.teamName))//checking if team is in a selected region and adding it to team check box
                    {
                        teamNameCheckedListBox.Items.Add(dets.teamName);
                        counterOfTeams++;
                    }
                }
                salesmancheckedListBox.DataSource = null;
                var regionList =
                            from sm in GlobalVariables.allSalesmenList
                            where sm.region.Equals(selectedRegion)
                            select sm;
                if (this.regionComboBox.SelectedIndex == 0)
                    errorProvider1.SetError(regionComboBox, "Please Select Region");
                if (regionList.Count()==0)
                    errorProvider1.SetError(regionComboBox, "No Salesman in this region");
                else
                {
                    errorProvider1.Clear();
                    salesmancheckedListBox.DataSource = regionList.ToList();
                    this.salesmancheckedListBox.DisplayMember = "fullName";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the add team button is pressed
         */
        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (selectedRegion.Equals("Select Region"))
            {
                errorProvider1.SetError(btnAddTeam, "Select Team");
            }
            
            else
            {
                errorProvider1.Clear();
                string teamName = regionComboBox.SelectedItem.ToString() + " " + counterOfTeams;
                if (!teamNameCheckedListBox.Items.Contains(teamName))
                {
                    teamNameCheckedListBox.Items.Add(teamName);
                    counterOfTeams++;
                }
                else
                    counterOfTeams += 1;
                
            }
        }

        /**
         * This method defines what happens when the team name is selected
         */
        private void teamNamecheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedTeam = (string)this.teamNameCheckedListBox.Items[e.Index];           
            //the code below was obtained from: http://stackoverflow.com/questions/5256967/how-to-check-only-one-item-in-checkedlistbox
            if (teamNameCheckedListBox.CheckedItems.Count == 1)
            {
                bool isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                    teamMemberCheckedListBox.Items.Clear();
                }
                else
                {
                    Int32 checkedItemIndex = teamNameCheckedListBox.CheckedIndices[0];
                    teamNameCheckedListBox.ItemCheck -= teamNamecheckedListBox_ItemCheck;
                    teamNameCheckedListBox.SetItemChecked(checkedItemIndex, false);
                    teamNameCheckedListBox.ItemCheck += teamNamecheckedListBox_ItemCheck;
                }
                return;
            }
        }

        /**
         * This method defines what happens when the user clicks add to team
         */
        private void btnAddToTeam_Click(object sender, EventArgs e)
        {
            int teamSales = 0;
            if (salesmancheckedListBox.Items.Count == 0)
                errorProvider1.SetError(btnAddToTeam, "Please select a different region");
            else if (salesmancheckedListBox.CheckedItems.Count == 0)
                errorProvider1.SetError(btnAddToTeam, "Please select a Salesman");
            else
                errorProvider1.Clear();
            foreach (TeamDetails x in GlobalVariables.allSalesmenList)
            {
                if (x.teamName.Equals(selectedTeam))
                {
                    teamSales = x.teamSales;
                }
            }
            foreach (TeamDetails sale in salesmancheckedListBox.CheckedItems)
            {
                    teamSales = teamSales + sale.sales;
            }
            foreach (TeamDetails toAdd in salesmancheckedListBox.CheckedItems)
            {
                if (teamNameCheckedListBox.Items.Count == 0)
                    errorProvider1.SetError(btnAddToTeam, "Please add a team");
                else if (teamNameCheckedListBox.CheckedItems.Count == 0)
                    errorProvider1.SetError(btnAddToTeam, "Please select a Team");
                else if (!toAdd.teamName.Equals(String.Empty))
                    errorProvider1.SetError(btnAddToTeam, toAdd.fullName + " is already in team " + toAdd.teamName);
                else
                {
                    errorProvider1.Clear();
                    toAdd.teamName = selectedTeam;
                    toAdd.teamSales = teamSales;
                }
            }
        }
        /**
         * This method defines what happens when the set leader button is pressed
         */
        private void btnSetLeader_Click(object sender, EventArgs e)
        {
            if (teamMemberCheckedListBox.CheckedItems.Count == 0)
                errorProvider1.SetError(btnSetLeader, "Select Leader");
            else
            {
                foreach (TeamDetails detail in GlobalVariables.allSalesmenList)
                {
                    if (detail.teamName.Equals(selectedTeam))
                    {
                        if (!String.IsNullOrEmpty(detail.teamLeader))
                            errorProvider1.SetError(btnSetLeader, "Team already has leader");
                        else
                        {
                            errorProvider1.Clear();
                            detail.teamLeader = selectedMember;
                        }
                    }
                }
            }
        }

        /**
         * This method defines what happens when the view team member button is pressed
         */
        private void btnViewTeamMember_Click(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
            teamMemberCheckedListBox.Items.Clear();
            foreach (var team in GlobalVariables.allSalesmenList)
            {
                if (team.teamName.Equals(selectedTeam))
                {
                    teamMemberCheckedListBox.Items.Add(team.fullName);
                }
            }
        }
        /**
         * This method only allows one team member to be checked
         */
        private void teamMemberCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedMember = (string)this.teamMemberCheckedListBox.Items[e.Index];
            //the code below was obtained from: http://stackoverflow.com/questions/5256967/how-to-check-only-one-item-in-checkedlistbox
            if (teamMemberCheckedListBox.CheckedItems.Count == 1)
            {
                bool isCheckedItemBeingUnchecked = (e.CurrentValue == CheckState.Checked);
                if (isCheckedItemBeingUnchecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    Int32 checkedItemIndex = teamMemberCheckedListBox.CheckedIndices[0];
                    teamMemberCheckedListBox.ItemCheck -= teamMemberCheckedListBox_ItemCheck;
                    teamMemberCheckedListBox.SetItemChecked(checkedItemIndex, false);
                    teamMemberCheckedListBox.ItemCheck += teamMemberCheckedListBox_ItemCheck;
                }
                return;
            }
        }
        /**
         * This method defines what happens when the form is closed
         */
        private void AddTeam_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to team management?\n", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                ManageTeams team = new ManageTeams();
                team.Show();
            }
            else
                e.Cancel = true;
        }
        /**
         * This method defines what happens when the how to use button is pressed in the menu
         */
        private void HowToMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"1) Select Region." +
                "\n2) Select team or create new team." +
                "\n2a) Select Team if new team was created." +
                "\n3) Select Salesmen to add to team." +
                "\n4) Press 'View Team Members'." +
                "\n5) Select a salesman under 'Team Members'." +
                "\n6) Press 'Set Leader'." +
                "\n\n If you want to change the team leader please return to previous form and click 'Edit/View Teams'.","How To Use");
        }     
    }
}
