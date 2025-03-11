using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects_HT3
{
    internal class Teacher
    {
        private int TeachID;
        private string Tname;
        private string Subject;

        public Teacher(int teachID, string tname,string subject)
        {
            TeachID = teachID;
            Tname = tname;
            Subject = subject;
        }

        public void AssignGrade(Student x1,int grades)
        {
            x1.setgrade(grades);
        }
        
        public int getTeachID()
        {
            return TeachID;
        }
        public string getTname()
        {
            return Tname;
        }
        public string getsubject()
        {
            return Subject;
        }
    }
}
