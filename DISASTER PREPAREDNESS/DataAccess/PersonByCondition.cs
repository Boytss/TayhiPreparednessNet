using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class PersonByCondition
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string HeadOfFamily { get; set; }
        public string Condition { get; set; }
        public string PurokNumber { get; set; }
        public string DisasterName { get; set; }
    }
}
