using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoManager
{
    class InputOutput
    {
        Info info;
        public InputOutput()
        {
            info = new Info();
        }

        public void GetInput()
        {
            Console.WriteLine("Name: ");
            info.Name = Console.ReadLine();

            Console.WriteLine("Roll No: ");
            info.RollNo = Console.ReadLine();

            Console.WriteLine("Age: ");
            info.Age = Console.ReadLine();

            Console.WriteLine("Class: ");
            info.ClassName = Console.ReadLine();

            Console.WriteLine("University: ");
            info.University = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Student Full Information: ");
            Console.WriteLine(info.GetStudentInfo());
        }
    }
}
