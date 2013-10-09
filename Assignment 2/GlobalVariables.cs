using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    public class GlobalVariables
    {
        private static List<TeamDetails> _currentList = new List<TeamDetails>();
        private static string _savePath;

        public static List<TeamDetails> allSalesmenList//global list available across all forms
        {
            get { return _currentList; }
            set { _currentList = value; }
        }

        public static string savePath//string to set save path
        {
            get { return _savePath; }
            set { _savePath = value; }
        }

        public static TeamDetails currentSalesmanDetails { get; set; }       

    #region Region Arrays
        //these regions were obtained from the following website: http://geography.about.com/od/lists/a/officiallist.htm

        public static string[] MiddleEastNorthAfricaandGreaterArabia = { "Afghanistan","Algeria","Azerbaijan","Bahrain","Egypt","Iran","Iraq",
                                                                 "Israel","Jordan","Kuwait","Lebanon","Libya","Morocco","Oman","Pakistan",
                                                                 "Qatar","Saudi Arabia","Somalia","Syria","Tunisia","Turkey","United Arab Emirates",
                                                                 "Yemen"};
        public static string[] Asia = {"Brunei","Cambodia","China","India","Indonesia","Japan","Kazakhstan","North Korea","South Korea","Kyrgyzstan","Laos","Malaysia",
                                "Maldives","Mongolia","Myanmar","Nepal","Philippines","Singapore","Sri Lanka","Taiwan","Tajikistan","Thailand","Turkmenistan",
                                "Uzbekistan","Vietnam","Bangladesh",
                                "Bhutan"};
        public static string[] Europe = {"Albania","Andorra","Armenia","Austria","Belarus","Belgium","Bosnia and Herzegovina","Bulgaria","Croatia","Cyprus","Czech Republic",
                                  "Denmark","Estonia","Finland","France","Georgia","Germany","Greece","Hungary","Iceland","Ireland","Italy","Kosovo","Latvia",
                                  "Liechtenstein","Lithuania","Luxembourg","Macedonia","Malta","Moldova","Monaco","Montenegro","Netherlands","Norway","Poland",
                                  "Portugal","Romania","Russia","San Marino","Serbia","Slovakia","Slovenia","Spain","Sweden","Switzerland","Ukraine",
                                  "United Kingdom of Great Britain","Northern Ireland",
                                  "Vatican City" };
        public static string[] CentralAmericaAndTheCaribbean = {"Antigua and Barbuda","The Bahamas","Barbados","Belize","Costa Rica","Cuba","Dominica","Dominican Republic",
                                                         "El Salvador","Grenada","Guatemala","Haiti","Honduras","Jamaica","Nicaragua","Panama","Saint Kitts and Nevis",
                                                         "Saint Lucia","Saint Vincent and the Grenadines",
                                                         "Trinidad and Tobago" };        
        public static string[] AustraliaAndOceania = {"Australia","East Timor","Fiji","Kiribati","Marshall Islands","Federated States of Micronesia","Nauru","New Zealand",
                                               "Palau","Papua New Guinea","Samoa","Solomon Islands","Tonga","Tuvalu",
                                               "Vanuatu"};
        public static string[] SubSaharanAfrica = {"Angola","Benin","Botswana","Burkina Faso","Burundi","Cameroon","Cape Verde","Central African Republic","Chad","Comoros",
                                            "Republic of the Congo","Democratic Republic of the Congo","Cote d'Ivoire","Djibouti","Equatorial Guinea","Eritrea",
                                            "Ethiopia","Gabon","The Gambia","Ghana","Guinea","Guinea-Bissau","Kenya","Lesotho","Liberia","Madagascar",
                                            "Malawi","Mali", "Mauritania","Mauritius","Mozambique","Namibia","Niger","Nigeria","Rwanda",
                                            "Sao Tome and Principe","Senegal","Seychelles","Sierra Leone","South Africa","South Sudan","Sudan","Swaziland","Tanzania",
                                            "Togo","Uganda","Zambia","Zimbabwe"};
        public static string[] SouthAmerica = { "Argentina", "Bolivia", "Brazil", "Chile", "Colombia", "Ecuador", "Guyana", "Paraguay", "Peru", "Suriname", "Uruguay", "Venezuela" };
        public static string[] NorthAmerica = { "Canada", "Greenland", "Mexico", "United States of America" };
#endregion

    }
}
