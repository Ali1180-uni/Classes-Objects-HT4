using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects_HT3
{
    internal class Student
    {
        private int StuID;
        private string name;
        private int[] grade;
        private int gradecount;

        public Student(int stuID, string name)
        {
            StuID = stuID;
            this.name = name;
            grade = new int[5];
            gradecount = 0;

        }

        public void setgrade(int grade)
        {
            if (gradecount < 5)
            {
                this.grade[gradecount] = grade;
                gradecount++;
            }
            else
            {
                Console.WriteLine("Grade limit reached for this student.");
            }
        }

        public double CalAvg()
        {
            if(gradecount == 0) return 0;
            int sum = 0;
            for(int i = 0;i<gradecount;i++)
            {
                sum += grade[i];
            }
            return sum/gradecount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {StuID}, Name: {name}");
        }
        public string getname()
        {
            return name;
        }
    }
}
