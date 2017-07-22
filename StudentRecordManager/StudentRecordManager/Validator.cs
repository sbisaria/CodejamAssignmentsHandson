using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StudentRecordManager
{
    public class Validator
    {
        public bool CheckEmail(string email)
        {
           return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
        public bool CheckMobileNo(string mobileNo)
        {
            return Regex.IsMatch(mobileNo, @"[0-9X]{10}",RegexOptions.Singleline);
        }
        public bool CheckEmergencyContact(string emergencyContact)
        {
            return Regex.IsMatch(emergencyContact, @"[0-9]{10}", RegexOptions.Singleline);
        }
        public bool CheckMentorName(string mentor)
        {
            return Regex.IsMatch(mentor, ".+", RegexOptions.Singleline);
        }
        public bool CheckDob(string dob)
        {
            return Regex.IsMatch(dob, "^[0-3]?[0-9].[0-3]?[0-9].(?:[0-9]{2})?[0-9]{2}$", RegexOptions.Singleline);
        }
        public bool CheckCourse(string course)
        {
            return Regex.IsMatch(course, ".+", RegexOptions.Singleline);
        }
    }
}
