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
    public partial class ManageTeams : Form
    {
        public ManageTeams()
        {
            InitializeComponent();
        }

        /**
         * This method defines 
         */
        private void btnAddTeams_Click(object sender, EventArgs e)
        {
            var next = new AddTeam();
            next.Show(this);
            this.Hide();
        }

        /**
         * This method defines 
         */
        private void btnViewEdit_Click(object sender, EventArgs e)
        {
            var next = new EditTeam();
            next.Show(this);
            this.Hide();
        }

        /**
         * This method defines 
         */
        private void ManageTeams_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to the main form?\n", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var main = new MainForm();
                main.Show();
            }
            else
                e.Cancel = true;
        }

        /**
         * This method defines 
         */
        private void HowToMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "If you would like to add a team or salesmen to a team press 'Add Teams'." +
                "\nIf you would like to edit or view team details press 'Edit/View Teams'.", "How To Use");
        }
    }
}
