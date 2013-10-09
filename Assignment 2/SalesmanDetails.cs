using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    [Serializable]//allow write to XML and also read

    /**
     *This entire class defines the setters and getters for their respective strings 
     */
    public class SalesmanDetails
    {
        private string fName, lName, emailAdd, mobileNum, officeNum;
        private int totalSales;
        private int empID;
        private string streetNameNum,streetNameNum2, cityName, countryName;
        private string DOB;

        public SalesmanDetails() { }

        public string fullName
        {
            get { return fName + " " + surname; }            
        }

        public int employeeID
        {
            get { return empID; }
            set { empID = value; }
        }
        public string firstName
        {
            get { return fName; }
            set { fName=value; }
        }

        public string surname
        {
            get { return lName; }
            set { lName=value; }
        }

        public string email
        {
            get { return emailAdd; }
            set { emailAdd=value; }
        }

        public string dateOfBirth
        {
            get { return DOB; }
            set { DOB=value; }
        }

        public string streetNameAndNumber
        {
            get { return streetNameNum; }
            set { streetNameNum= value; }
        }
        public string streetNameAndNumber2
        {
            get { return streetNameNum2; }
            set { streetNameNum2 = value; }
        }

        public string city
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string country
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public int sales
        {
            get { return totalSales; }
            set { totalSales = value; }
        }

        public string mobilePhoneNumber
        {
            get { return mobileNum; }
            set { mobileNum = value; }
        }

        public string officeNumber
        {
            get { return officeNum; }
            set { officeNum = value; }
        }
    }
}
