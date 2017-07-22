using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManager
{
   public class Student
    {
        Validator validator = new Validator();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string DateOfBirth { get; set; }
        public string Course { get; set; }
        public string Mentor { get; set; }
        public string EmergencyContact { get; set; }
    }
}
