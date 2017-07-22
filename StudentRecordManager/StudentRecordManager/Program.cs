using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace StudentRecordManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            StudentManager manager = new StudentManager();
            do
            {
                Console.WriteLine("****Enter Choice*****");
                Console.WriteLine("Enter 0 to add");
                Console.WriteLine("Enter 1 to view all");
                Console.WriteLine("Enter 2 to view particular record");
                Console.WriteLine("Enter 3 to update");
                Console.WriteLine("Enter 4 to change directory");
                Console.WriteLine("Enter 5 to exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        {
                            Student newStudent = InputStudentDetails();
                            Student response = manager.Add(newStudent);
                            if(response==null)
                            {
                                Console.WriteLine("\nSome error occured.\n");
                            }
                            else
                                Console.WriteLine("\nStudent record added successfully.\n");
                            break;
                        }
                    case "1":
                        {
                            List<Student> students = manager.GetAll();
                            DisplayStudents(students);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter first name ");
                            string firstName = Console.ReadLine().Trim();
                            Console.WriteLine("Enter last name ");
                            string lastName = Console.ReadLine().Trim();
                            Student student = manager.GetParticular(firstName + lastName);
                            if (student == null)
                            {
                                Console.WriteLine("\nRecord does not exist.\n\n");
                            }
                            else
                                DisplayParticular(student);
                            break;
                        }
                    case "3":
                        Student updateStudent = InputStudentDetails();
                        Student updatedStudent = manager.Update(updateStudent);
                       if(updatedStudent==null)
                        {
                            Console.WriteLine("Record does not exist.");
                        }
                        else
                        {
                            Console.WriteLine("\nRecord updated successfully.\n");
                            DisplayParticular(updatedStudent);
                        }
                        break;
                    case "4":
                        manager = new StudentManager();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != "5");
        }

        private static void DisplayStudents(List<Student> students)
        {
            foreach(Student student in students)
            {
                DisplayParticular(student);
            }
        }

        private static void DisplayParticular(Student student)
        {
            Console.WriteLine("Details of {0} {1} are:", student.FirstName, student.LastName);
            Console.WriteLine("Contact Number : {0}", student.MobileNo);
            Console.WriteLine("E-Mail id: {0}", student.EmailId);
            Console.WriteLine("Date of birth : {0}", student.DateOfBirth);
            Console.WriteLine("Course persuing : {0}", student.Course);
            Console.WriteLine("Mentor name: {0}", student.Mentor);
            Console.WriteLine("Emergency Contact : {0}", student.EmergencyContact);
            Console.WriteLine("\n");
        }

        private static Student InputStudentDetails()
        {
            Student student = new Student();
            Validator validate = new Validator();
            string tempMobileNo, tempEmail, tempDob, tempCourse, tempMentor, tempContactNo;
            Console.WriteLine("Enter student details: ");

            Console.Write("First Name:\t");
            student.FirstName = Console.ReadLine();

            Console.Write("Last Name:\t");
            student.LastName = Console.ReadLine();

            do
            {
                Console.Write("Mobile No\t");
                tempMobileNo = Console.ReadLine();
                if (validate.CheckMobileNo(tempMobileNo))
                {
                    student.MobileNo = tempMobileNo;
                    break;
                }
                else
                    Console.WriteLine("Invalid input");
            } while (true);

            do
            {
                Console.Write("Email id\t");
                tempEmail = Console.ReadLine();
                if (validate.CheckEmail(tempEmail) == true)
                {
                    student.EmailId = tempEmail;
                    break;
                }
                else
                    Console.WriteLine("Enter valid email-id");
            } while (true);
            do
            {
                Console.Write("Date of Birth:\t");
                tempDob = Console.ReadLine();
                if (validate.CheckDob(tempDob) == true)
                {
                    student.DateOfBirth = tempDob;
                    break;
                }
                else
                    Console.WriteLine("Enter valid date of birth");
            } while (true);
            do
            {
                Console.Write("Course Persuing:\t");
                tempCourse = Console.ReadLine();
                if (validate.CheckCourse(tempCourse) == true)
                {
                    student.Course = tempCourse;
                    break;
                }
                else
                    Console.WriteLine("Enter valid course");
            } while (true);
            do
            {
                Console.Write("Mentor Name:\t");
                tempMentor = Console.ReadLine();
                if (validate.CheckMentorName(tempMentor))
                {
                    student.Mentor = tempMentor;
                    break;
                }
                else
                    Console.WriteLine("Enter valid mentor name");
            } while (true);
            do
            {
                Console.Write("Emergency Contact No:\t");
                tempContactNo = Console.ReadLine();
                if (validate.CheckEmergencyContact(tempContactNo))
                {
                    student.EmergencyContact = tempContactNo;
                    break;
                }
                else
                    Console.WriteLine("Invalid");
            } while (true);
            return student;
        }

    }
}










