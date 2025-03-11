using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects_HT3
{
    internal class School
    {
        private string SchoolName;
        private string Location;
        private Student[] Stu;
        private int stuCount;


        public School(string schoolName, string location, int num)
        {
            SchoolName = schoolName;
            Location = location;
            Stu = new Student[num];
            stuCount = 0;
        }

        public void AddStu(Student stu)
        {
            Stu[stuCount] = stu;
            stuCount++;
            Console.WriteLine("Student Added Succesfully");
        }
        public Student[] getStu()
        {
            return Stu;
        }
        public string getSchName() {  return SchoolName; }
        public string getLocation() { return Location; }
        public void display()
        {
            for (int i = 0; i < stuCount; i++)
            {
                Console.WriteLine($"The Info of Student {i + 1} is: ");
                Stu[i].DisplayInfo();
            } 
        }
    }
}
