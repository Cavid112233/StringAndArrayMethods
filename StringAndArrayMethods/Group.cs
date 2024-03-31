using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndArrayMethods
{
    internal class Group
    {
        public string No { get; }
        public List<Student> Students { get; }
        public int StudentLimit { get; }

        public Group(string no, int studentLimit)
        {
            No = no;
            Students = new List<Student>();
            StudentLimit = studentLimit;
        }

        public void AddStudent(Student student)
        {
            if (Students.Count < StudentLimit)
            {
                Students.Add(student);
                Console.WriteLine($"{student.FullName} bu qrupa elave olundu.");
            }
            else
            {
                Console.WriteLine("Artig telebe daxil etmek olmur!");
            }
        }
    }
}
