using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Assignment_2
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        /**
         * This method defines what happens when the add salesman button is clicked
         */
        private void btnAddSalesman_Click(object sender, EventArgs e)
        {
            AddSalesman addSales = new AddSalesman();
            addSales.Show(this);//show add salesman form
            this.Hide();
        }

        /**
         * This method defines what happens when the edit,search or view salesman button is clicked
         */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.allSalesmenList.Count == 0)
            {
                MessageBox.Show(this,"There are no salesmen in the database.\nPlease add salesmen or open a file.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);//check for open file
            }
            else
            {
                var manage = new ViewingForm();
                manage.Show(this);//show edit/view/search form
                this.Hide();
            }
            
        }
        /**
         * This method defines what happens when the form is closed
         */
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?\nChanges will not be saved", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
                e.Cancel = true;
        }

        /**
         * This method defines what happens when the exit button is clicked in the menu
         */

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * This method defines what happens when the 'Save As' button is clicked in the menu
         */
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileAs = new SaveFileDialog();
                if (GlobalVariables.allSalesmenList.Count == 0)
                    throw new Exception("Nothing to save");
                else
                {
                    saveFileAs.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    saveFileAs.RestoreDirectory = true;
                    saveFileAs.Filter = "eXtensible Markup Language File(*.xml)|*.xml";
                    saveFileAs.Title = "Save As";
                    saveFileAs.CheckPathExists = true;
                    saveFileAs.ShowDialog();
                    string dir = saveFileAs.FileName;
                    using (var sw = new StreamWriter(saveFileAs.FileName))
                    {
                        XmlSerializer seralizer = new XmlSerializer(typeof(List<TeamDetails>));
                        seralizer.Serialize(sw, GlobalVariables.allSalesmenList);
                    }
                    GlobalVariables.savePath = saveFileAs.FileName;
                    MessageBox.Show("Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the 'o button is clicked in the menu
         */
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFile.Filter = "eXtensible Markup Language File(*.xml)|*.xml";
                openFile.Title = "Open";
                openFile.CheckFileExists = true;
                openFile.CheckPathExists = true;
                openFile.ShowDialog();
                XmlSerializer seralizer = new XmlSerializer(typeof(List<TeamDetails>));
                using (TextReader reader = new StreamReader(openFile.FileName))
                {
                    if (new FileInfo(openFile.FileName).Length == 0)
                    {
                        throw new Exception("File is empty. Nothing to open");
                    }
                    GlobalVariables.allSalesmenList = (List<TeamDetails>)seralizer.Deserialize(reader);
                }
                GlobalVariables.savePath = openFile.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the team management button is clicked
         */
        private void btnTeamManagement_Click(object sender, EventArgs e)
        {
            if (GlobalVariables.allSalesmenList.Count == 0)
            {
                MessageBox.Show(this, "There are no salesmen in the database.\nPlease add salesmen or open a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//check if file's been opened
            else
            {
                var manage = new ManageTeams();
                manage.Show(this);
                this.Hide();
            }
        }
        /**
         * This method defines what happens when the 'save' button is clicked in the menu
         */
        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(GlobalVariables.savePath))
                {
                    SaveFileDialog saveFile = new SaveFileDialog();
                    if (GlobalVariables.allSalesmenList.Count == 0)
                        throw new Exception("Nothing to save");
                    else
                    {
                        saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        saveFile.RestoreDirectory = true;
                        saveFile.Filter = "eXtensible Markup Language File(*.xml)|*.xml";
                        saveFile.Title = "Save";
                        saveFile.CheckPathExists = true;
                        saveFile.ShowDialog();
                        string dir = saveFile.FileName;
                        using (var sw = new StreamWriter(saveFile.FileName))
                        {
                            XmlSerializer seralizer = new XmlSerializer(typeof(List<TeamDetails>));
                            seralizer.Serialize(sw, GlobalVariables.allSalesmenList);
                        }
                        GlobalVariables.savePath = saveFile.FileName;
                        MessageBox.Show("Saved");
                    }
                }
                else
                {
                    using (var sw = new StreamWriter(GlobalVariables.savePath))
                    {
                        XmlSerializer seralizer = new XmlSerializer(typeof(List<TeamDetails>));
                        seralizer.Serialize(sw, GlobalVariables.allSalesmenList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method defines what happens when the 'how to use' button is clicked in the menu
         */
        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "File (if available) must be opened before doing anything"
                + "\nTo add salesmen click 'Add Salesman'"
                + "\nTo Edit,View & Search Salesmen click 'Edit, Search Or View Salesman'"
                + "\nTo Manage Teams click 'Team Management'"
                +"\nTo Open a File press CTRL+O or under Menu-File"
                + "\nTo Save File press CTRL+S or under Menu-File"
                + "\nTo Save File As press CTRL+SHIFT+S or under Menu-File"
                , "How to use");
        }  
    }
}
