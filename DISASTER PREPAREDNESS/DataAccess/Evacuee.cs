using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS.DataAccess
{
    public class Evacuee
    {
        public int EvacueeID { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PurokNumber { get; set; }
        public int NumberOfFamilyMembers { get; set; }
        public string RoomName { get; set; }
        public string DisasteName { get; set; }
    }
}
