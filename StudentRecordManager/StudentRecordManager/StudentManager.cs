using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace StudentRecordManager
{
    class StudentManager
    {
        DirectoryInfo directoryInfo;
        public StudentManager()
        {
            Console.Write("Enter the directory name:\t");
            string directoryName = Console.ReadLine();
            directoryInfo = new DirectoryInfo(@"D:\" + directoryName);
            if (directoryInfo.Exists)
                Console.WriteLine("Directory found...\n");
            else
            {
                directoryInfo.Create();
                Console.WriteLine("Directory created...\n");
            }
        }

        public Student Add(Student student)
        {
            FileInfo file = new FileInfo(string.Format("D:/{0}/{1}{2}.txt", directoryInfo.Name, student.FirstName, student.LastName));
            if (file.Exists == true)
            {
                Console.WriteLine("\nRecord already exists.\n\n");
                return null;
            }
            try
            {
                FileStream fs = new FileStream(string.Format("D:/{0}/{1}{2}.txt", directoryInfo.Name, student.FirstName, student.LastName), FileMode.CreateNew);
                string studentDetails = JsonConvert.SerializeObject(student);
                byte[] record = Encoding.UTF8.GetBytes(studentDetails);
                fs.Write(record, 0, record.Length);
                fs.Flush();
                fs.Dispose();
                return student;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                string studentDetails = File.ReadAllText($"{directoryInfo.FullName}/{file.Name}");
                Student student = JsonConvert.DeserializeObject<Student>(studentDetails);
                students.Add(student);
            }
            return students;
        }
        public Student GetParticular(string fileName)
        {
            FileInfo file = new FileInfo($"D:/{directoryInfo.Name}/{fileName}.txt");
            if (file.Exists == false)
            {
                return null;
            }
            string studentDetails = File.ReadAllText($"{directoryInfo.FullName}/{fileName}");
            Student student = JsonConvert.DeserializeObject<Student>(studentDetails);
            return student;
        }

        public Student Update(Student updateStudent)
        {
            Student student = GetParticular(updateStudent.FirstName + updateStudent.LastName);
            if (student == null)
                return null;
            FileInfo file = new FileInfo($"D:/{directoryInfo.Name}/{updateStudent.FirstName}{updateStudent.LastName}.txt");
            file.Delete();
            Add(updateStudent);
            return updateStudent;
        }
    }
}