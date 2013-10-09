using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    [Serializable]//allow write to XML and also read
    public class TeamDetails : SalesmanDetails
    {
        private string _teamName;
        private int _teamSales;
        private string  regionName;
        private string _teamLeader;

        public string teamName
        {
            get { return _teamName; } 
            set { _teamName = value; }
        }

        public int teamSales
        {
            get { return _teamSales; }
            set { _teamSales = value; }
        }

        public string region
        {
            get { return regionName; }
            set { regionName = value; }
        }

        public string teamLeader
        {
            get { return _teamLeader; }
            set { _teamLeader = value; }
        }
    }
}
