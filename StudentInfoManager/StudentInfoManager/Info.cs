using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManager
{
    class Info
    {
        private string name;
        private string rollNo;
        private string age;
        private string className;
        private string university;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        public string University
        {
            get { return university; }
            set { university = value; }
        }

        public string GetStudentInfo()
        {
            string completeInfo = "Name:\t" + Name + " \nRoll No\t" + RollNo + "\nAge:\t" + Age + "\nClass:\t" + ClassName + "\nUniversity:\t" + University;
            return completeInfo;
        }
    }
}
