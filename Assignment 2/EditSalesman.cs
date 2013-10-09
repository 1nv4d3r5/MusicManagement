using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Xml.Serialization;
using System.IO;
using System.Drawing.Printing;

namespace Assignment_2
{
    public partial class EditSalesman : Form
    {
        
        private List<SalesmanDetails> salesmanList = new List<SalesmanDetails>();
        private TeamDetails editedSalesman = new TeamDetails();
        private bool passedValidation = false;
        private bool isTeamLeader = false;
        int changedSales = 0;
        string changedRegion = "";
        string firstCountry = "";
        private string teamName { get; set; }

        public EditSalesman()
        {
            InitializeComponent();
        }
        /**
          * This method defines what happens on form load
          */
        private void EditSalesman_Load(object sender, EventArgs e)
        {
            try
            {
                changedSales = GlobalVariables.currentSalesmanDetails.sales;
                changedRegion = GlobalVariables.currentSalesmanDetails.region;
                firstCountry = GlobalVariables.currentSalesmanDetails.country;
                StreamReader obgStrReader = new StreamReader("CountryComboList.txt");//available in assignment2/bin/debug
                string line = obgStrReader.ReadLine();
                while (line != null)
                {
                    countryCombobox.Items.Add(line);
                    line = obgStrReader.ReadLine();//adding items to como box
                }
                populateform();//populating form
                editedSalesman = GlobalVariables.currentSalesmanDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        /**
         * This method defines what happens to populate the form
         */
        private void populateform()
        {
            if (GlobalVariables.currentSalesmanDetails.teamLeader
                .Equals(GlobalVariables.currentSalesmanDetails.fullName))//checking if the person is a team leader
            {
                isTeamLeader = true;
                teamName = GlobalVariables.currentSalesmanDetails.teamName;
            }
            txtEmpID.Text = GlobalVariables.currentSalesmanDetails.employeeID.ToString();
            txtFirstName.Text = GlobalVariables.currentSalesmanDetails.firstName;
            txtSurname.Text = GlobalVariables.currentSalesmanDetails.surname;
            dateTimePicker1.Value = Convert.ToDateTime(GlobalVariables.currentSalesmanDetails.dateOfBirth);
            txtEmail.Text = GlobalVariables.currentSalesmanDetails.email;
            txtMobileNum.Text = GlobalVariables.currentSalesmanDetails.mobilePhoneNumber;
            txtOfficeNum.Text = GlobalVariables.currentSalesmanDetails.officeNumber;
            txtTotalSales.Text = GlobalVariables.currentSalesmanDetails.sales.ToString();
            txtStreetName1.Text = GlobalVariables.currentSalesmanDetails.streetNameAndNumber;
            txtStreetName2.Text = GlobalVariables.currentSalesmanDetails.streetNameAndNumber2;
            txtCity.Text = GlobalVariables.currentSalesmanDetails.city;
            countryCombobox.SelectedItem = GlobalVariables.currentSalesmanDetails.country;
            txtRegion.Text = GlobalVariables.currentSalesmanDetails.region;
        }
        /**
         * This method validates first name
         */
        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string name = txtFirstName.Text;
                if (string.IsNullOrEmpty(name))
                {
                    passedValidation = false;
                    txtFirstName.Focus();
                    errorProvider1.SetError(txtFirstName, "First Name cannot be empty");
                }
                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFirstName, ex.Message);
            }
        }
        /**
         *  This method validates surname
         */
        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string name = txtSurname.Text;
                if (string.IsNullOrEmpty(name))
                {
                    passedValidation = false;
                    txtSurname.Focus();
                    errorProvider1.SetError(txtSurname, "Surname cannot be empty");
                }
                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSurname, ex.Message);
            }
        }
        /**
         * This method validates email
         */
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string reg = @"^\w+([\.-_]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$";
                if (!string.IsNullOrEmpty(email))
                {
                    if (!Regex.IsMatch(email, reg))
                    {
                        passedValidation = false;
                        errorProvider1.SetError(txtEmail, "Enter email in format name@examle.com");
                        txtEmail.Focus();
                    }
                    else
                    {
                        passedValidation = true;
                        errorProvider1.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtEmail, ex.Message);
            }
        }
        /**
         * This method validates the date of birth
         */
        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value.Date >= DateTime.Now.AddYears(-18))//person cannot be younger than 18 years from current date
                {
                    passedValidation = false;
                    dateTimePicker1.Focus();
                    errorProvider1.SetError(dateTimePicker1, "Person cannot be under 18 years");
                }
                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dateTimePicker1, ex.Message);
            }
        }

        /**
         * This method validates city
         */

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string city = txtCity.Text;
                string reg = @"^[a-zA-Z]+$";//regex to test for only letters
                if (!Regex.IsMatch(city, reg))
                {
                    passedValidation = false;
                    txtCity.Focus();
                    errorProvider1.SetError(txtCity, "City must be letters only. e.g Perth");
                }
                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCity, ex.Message);
            }
        }
        /**
         * This method validates sales
         */
        private void txtTotalSales_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string sales = txtTotalSales.Text;
                string reg = @"^[0-9]+(\.[0-9][0-9])?$";
                if (!Regex.IsMatch(sales, reg))
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtTotalSales, "Sale must be in format d.dd eg:50.09");
                    txtTotalSales.Focus();
                }
                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTotalSales, ex.Message);
            }
        }
        /**
         * This method validates mobile number
         */
        private void txtMobileNum_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string number = txtMobileNum.Text;
                string reg = @"^((\+[0-9]{1,3})([\s\-]?[0-9]{3}){2}([\s\-]?[0-9]{3,4}))$";//phone number must be in format +xxx xxx xxx xxxx or +xx-xxx-xxx-xxxx 
                if (number.Length > 17)
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtMobileNum, "Number Cannot be longer than 15 digits");
                    txtMobileNum.Focus();
                }

                else if (!Regex.IsMatch(number, reg))
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtMobileNum, "Number must be in format phone number must be in format\n +xxx xxx xxx xxxx or +xx-xxx-xxx-xxxx e.g +254 123 123 123 or +61 812 235 2354");
                    txtMobileNum.Focus();
                }

                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMobileNum, ex.Message);
            }
        }
        /**
         * This method validates office number
         */
        private void txtOfficeNum_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string number = txtOfficeNum.Text;
                string reg = @"^((\+[0-9]{1,3})([\s\-]?[0-9]{3}){2}([\s\-]?[0-9]{3,4}))$";//phone number must be in format +xxx xxx xxx xxxx or +xx-xxx-xxx-xxxx 
                if (number.Length > 17)
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtOfficeNum, "Number Cannot be longer than 15 digits");
                    txtMobileNum.Focus();
                }

                else if (!Regex.IsMatch(number, reg))
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtOfficeNum, "Number must be in format phone number must be in format\n +xxx xxx xxx xxxx or +xx-xxx-xxx-xxxx e.g +254 123 123 123 or +61 812 235 2354");
                    txtMobileNum.Focus();
                }

                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtOfficeNum, ex.Message);
            }
        }

        /**
         * This method defines what happens when the country combo box value is changed 
         */
        private void countrybox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countryCombobox.SelectedItem.Equals("Select Country"))
            {
                txtRegion.Text = string.Empty;
            }
            if (GlobalVariables.MiddleEastNorthAfricaandGreaterArabia.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "Middle East, North Africa and Greater Arabia";
            }
            if (GlobalVariables.Asia.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "Asia";
            }
            if (GlobalVariables.Europe.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "Europe";
            }
            if (GlobalVariables.NorthAmerica.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "North America";
            }
            if (GlobalVariables.CentralAmericaAndTheCaribbean.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "Central America and the Caribbean";
            }
            if (GlobalVariables.SouthAmerica.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "South America";
            }
            if (GlobalVariables.AustraliaAndOceania.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "Australia and Oceania";
            }
            if (GlobalVariables.SubSaharanAfrica.Contains(countryCombobox.SelectedItem))
            {
                txtRegion.Text = "Sub-Saharan Africa";
            }
        }
        /**
         * This method difines what happens when the save changes button is pressed
         */
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtTotalSales.Text))
                    txtTotalSales.Text = "0";
                if (!string.IsNullOrEmpty(editedSalesman.teamName) && !changedRegion.Equals(txtRegion.Text))
                {
                    passedValidation = false;
                    MessageBox.Show("Cannot change region because user is in a team");
                    countryCombobox.SelectedItem = firstCountry;
                }
                else
                    passedValidation = true;
                if (passedValidation)
                {
                    MessageBox.Show("Changes will not be saved to the XML file. \nThis will have to done manually from the main from.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);//show message box
                    GlobalVariables.allSalesmenList.Remove(GlobalVariables.currentSalesmanDetails);
                    if (isTeamLeader)//check for team leader
                    {
                        foreach (var leaderEdit in GlobalVariables.allSalesmenList)
                        {
                            if (leaderEdit.teamName.Equals(teamName))
                            {
                                leaderEdit.teamLeader = this.txtFirstName.Text + " " + this.txtSurname.Text;
                            }
                        }
                    }
                    editedSalesman.employeeID = Convert.ToInt32(txtEmpID.Text);
                    editedSalesman.firstName = this.txtFirstName.Text;
                    editedSalesman.surname = this.txtSurname.Text;
                    editedSalesman.dateOfBirth = this.dateTimePicker1.Value.ToShortDateString();
                    editedSalesman.email = this.txtEmail.Text;
                    editedSalesman.mobilePhoneNumber = this.txtMobileNum.Text;
                    editedSalesman.officeNumber = this.txtOfficeNum.Text;
                    editedSalesman.sales = Convert.ToInt32(this.txtTotalSales.Text);
                    editedSalesman.streetNameAndNumber = this.txtStreetName1.Text;
                    editedSalesman.streetNameAndNumber2 = this.txtStreetName2.Text;
                    editedSalesman.city = this.txtCity.Text;
                    editedSalesman.country = countryCombobox.SelectedItem.ToString();
                    editedSalesman.region = this.txtRegion.Text;
                    //checking if salesman sales are changed
                    if (changedSales != Convert.ToInt32(this.txtTotalSales.Text))
                    {
                        foreach (var teamsales in GlobalVariables.allSalesmenList)
                        {
                            if (teamsales.teamName.Equals(editedSalesman.teamName))
                            {
                                //editing the team sales if the value has been changed
                                teamsales.teamSales = teamsales.teamSales - changedSales;
                                teamsales.teamSales = teamsales.teamSales + editedSalesman.sales;
                                editedSalesman.teamSales = teamsales.teamSales;
                            }
                        }
                    }
                    GlobalVariables.allSalesmenList.Add(editedSalesman);
                }
                else
                {
                    throw new Exception("Input must be valid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /**
         * This method validates the employee ID
         */
        private void txtEmpID_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string emp = txtEmpID.Text;
                string reg = @"^[0-9]+$";

                if (!Regex.IsMatch(emp, reg))
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtEmpID, "Employee ID must be a number");
                    txtEmpID.Focus();
                }

                else
                {
                    passedValidation = true;
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtTotalSales, ex.Message);
            }
        }
        /**
         * This method defines what happens when the delete salesman button is pressed
         */
        private void btnDeleteSalesman_Click(object sender, EventArgs e)
        {
            if (editedSalesman.teamLeader.Equals(editedSalesman.fullName))
            {
                errorProvider1.SetError(btnDeleteSalesman, "You cannot delete team leader");
            }
            else if (!string.IsNullOrEmpty(editedSalesman.teamName))
            {
                errorProvider1.SetError(btnDeleteSalesman, "You cannot delete " + editedSalesman.fullName +
                    " because they are part of a team. ");
            }
            else
                GlobalVariables.allSalesmenList.Remove(GlobalVariables.currentSalesmanDetails);
        }
        
        /**
         * This method defines what happens when the form is closed
         */

        private void EditSalesman_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit to previous form?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var owner = this.Owner;
                if (owner != null)
                {
                    owner.Show();
                }
            }
            else
                e.Cancel = true;
        }
        /**
         * This method defines what happens when the exit menu item is pressed
         */
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /**
         * This method defines what happens when the print button is pressed
         */
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print();
        }
        /**
         * This method defines the printing
         */
        private void print()
        {
            PrintDialog printDia = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            PrintPreviewDialog printPrev = new PrintPreviewDialog();
            printPrev.Document = printDoc;
            printDia.Document = printDoc;

            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            DialogResult result = printDia.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDoc.Print();
            }
        }
        /**
         * This method defines the printing event handeling
         */
        void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;
            Font fnt = new Font("Courier New", 12);
            float fontHeight = fnt.GetHeight();
            Brush brsh = new SolidBrush(Color.Black);
            int startingX = 10;
            int startingY = 10;
            int offSet = 40;
            string finalPrint;
            string _fullName = editedSalesman.fullName;
            string emailAdd = editedSalesman.email;
            string mobileNum = editedSalesman.mobilePhoneNumber;
            string officeNum = editedSalesman.officeNumber;
            string totalSales = editedSalesman.sales.ToString();
            string empID = editedSalesman.employeeID.ToString();
            string streetNameNum = editedSalesman.streetNameAndNumber;
            string streetNameNum2 = editedSalesman.streetNameAndNumber2;
            string cityName = editedSalesman.city;
            string countryName = editedSalesman.country;
            string DOB = editedSalesman.dateOfBirth;
            string _region = editedSalesman.region;

            graphic.DrawString(_fullName+" Report", new Font("Courier New", 18), brsh, startingX, startingY);
            finalPrint = "Employee ID: " + empID;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Full name: " + _fullName;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Date Of Birth: " + DOB;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;


            finalPrint = "Email: " + emailAdd;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Mobile phone: " + mobileNum;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Office Number: " + officeNum;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Sales: $" + totalSales;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Address: ";
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Street Name/Number: " + streetNameNum + ", " + streetNameNum2;
            graphic.DrawString(finalPrint, fnt, brsh, startingX + 15, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "City: " + cityName;
            graphic.DrawString(finalPrint, fnt, brsh, startingX + 15, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Country: " + countryName;
            graphic.DrawString(finalPrint, fnt, brsh, startingX + 15, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;

            finalPrint = "Region: " + _region;
            graphic.DrawString(finalPrint, fnt, brsh, startingX, startingY + offSet);
            offSet = offSet + (int)fontHeight + 5;
        }

        /**
         * This method defines the print preview button in the menu 
         */
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            PrintPreviewDialog printPrev = new PrintPreviewDialog();
            printPrev.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            printPrev.ShowDialog();            
        }

        /**
         * This method defines what happens when th how to use is clicked in the menu
         */
        private void HowToUseMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,"If want to edit the details, append the desired text boxes and click 'Save Changes'"
                + "\nTo print the users details, a print preview can be viewed under 'File-Print Preview' or printed directly from 'File-Print'"
                +"\nTo delete the current salesman click 'Delete Salesman'","How To Use");
        }
    }
}
