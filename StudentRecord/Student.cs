using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecord
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public string Grade { get; set; }


        public Student()
        {
            Name = "";
            Age = 0;
            Sex = "Male";
            Grade = "first";
        }
        public string StudentProfile()
        {
            string profile = "";
            profile = $"{Name} is the student of {Grade} grade \r\n";

            if (Sex.Equals("Mae=le"))
            {
                profile += "He ";
            }
            else
            {
                profile += "She ";
            }

            profile += $" is {Age.ToString()} old. \r\n";
            return profile;
        }
    }

}
