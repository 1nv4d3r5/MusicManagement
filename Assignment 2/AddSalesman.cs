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

namespace Assignment_2
{
    public partial class AddSalesman : Form
    {
        List<TeamDetails> salesmanList = new List<TeamDetails>();
        private bool passedValidation = false;

        public AddSalesman()
        {
            InitializeComponent();
        }

        /**
         * This method defines what happens when the form loads          
         */
        private void AddSalesman_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader obgStrReader = new StreamReader("CountryComboList.txt");//available in assignment2/bin/debug
                string line = obgStrReader.ReadLine();
                while (line != null)
                {
                    countryCombobox.Items.Add(line);
                    line = obgStrReader.ReadLine();
                }
                countryCombobox.SelectedItem = "Select Country";
                salesmanList = GlobalVariables.allSalesmenList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
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
         * This method validates surname
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
         * This method validates date of birth
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
                }

                else if (!Regex.IsMatch(number, reg))
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtMobileNum, "Number must be in format phone number must be in format\n +xxx xxx xxx xxxx or +xx-xxx-xxx-xxxx e.g +254 123 123 123 or +61 812 235 2354");

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
                }

                else if (!Regex.IsMatch(number, reg))
                {
                    passedValidation = false;
                    errorProvider1.SetError(txtOfficeNum, "Number must be in format phone number must be in format\n +xxx xxx xxx xxxx or +xx-xxx-xxx-xxxx e.g +254 123 123 123 or +61 812 235 2354");
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
         * This method defines what happens when the country is chosen
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
         * This method defines what happens when the add salesman button is pressed
         */
        private void btnAddSalesman_Click(object sender, EventArgs e)
        {
            try
            {
                var val = new SearchAndValidation();
                if (string.IsNullOrEmpty(txtTotalSales.Text))
                {
                    txtTotalSales.Text = "0";
                }
                if (val.isSalesMan(salesmanList, Convert.ToInt32(txtEmpID.Text)))
                {
                    errorProvider1.SetError(txtEmpID, "Employee ID already exists");
                    txtEmpID.Focus();
                    passedValidation = false;
                }

                if (passedValidation)
                {
                    var currentDetail = new TeamDetails();
                    currentDetail.employeeID = Convert.ToInt32(txtEmpID.Text);
                    currentDetail.firstName = this.txtFirstName.Text;
                    currentDetail.surname = this.txtSurname.Text;
                    currentDetail.dateOfBirth = this.dateTimePicker1.Value.ToShortDateString();
                    currentDetail.email = this.txtEmail.Text;
                    currentDetail.mobilePhoneNumber = this.txtMobileNum.Text;
                    currentDetail.officeNumber = this.txtOfficeNum.Text;
                    currentDetail.sales = Convert.ToInt32(this.txtTotalSales.Text);
                    currentDetail.streetNameAndNumber = this.txtStreetName1.Text;
                    currentDetail.streetNameAndNumber2 = this.txtStreetName2.Text;
                    currentDetail.city = this.txtCity.Text;
                    currentDetail.country = countryCombobox.SelectedItem.ToString();
                    currentDetail.teamName = string.Empty;
                    currentDetail.teamLeader = string.Empty;
                    currentDetail.teamSales = 0;
                    currentDetail.region = this.txtRegion.Text;
                    GlobalVariables.allSalesmenList.Add(currentDetail);
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
         * This method validates employee id
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
         * This method clears the form
         */
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            this.txtEmpID.Text = string.Empty;
            this.txtFirstName.Text = string.Empty;
            this.txtSurname.Text = string.Empty;
            this.dateTimePicker1.Value = Convert.ToDateTime("01/01 /1980");
            this.txtEmail.Text = string.Empty;
            this.txtMobileNum.Text = string.Empty;
            this.txtOfficeNum.Text = string.Empty;
            this.txtTotalSales.Text = string.Empty;
            this.txtStreetName1.Text = string.Empty;
            this.txtStreetName2.Text = string.Empty;
            this.txtCity.Text = string.Empty;
            this.countryCombobox.SelectedItem = "Select Country";
            this.txtRegion.Text = string.Empty;
            errorProvider1.Clear();
        }

        /**
         * This method defines what happens when the exit option is pressed in the menu
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /**
         * This method defines what happens when the form is closing
         */
        private void AddSalesman_FormClosing(object sender, FormClosingEventArgs e)
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
         * This method defines what happens when the how to use option is pressed in the menu
         */
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Employee ID, First Name and Last Name must be filled out to add a salesman"
                + "\n1) Fill out desired fields"
                + "\n2) Click 'Add Salesman'"
                + "\n3) Repeat Steps 1 and 2 as many times as required"
                + "\nTo Clear the form press 'Clear Form'"
                + "\n\nTo edit salesman return to previous form and click 'Edit, Search Or View Salesman ' "
                , "How To Use");
        }
    }
}
