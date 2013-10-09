using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class SearchAndValidation
    {
        public bool isSalesMan(List<TeamDetails> listName, int ID)
        {
            foreach (TeamDetails dets in listName)
            {
                if (ID == dets.employeeID)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isEdited(SalesmanDetails person1, SalesmanDetails person2)
        {
            if (person1 == person2)
            {
                return true;
            }
            return false;
        }
    }
}
