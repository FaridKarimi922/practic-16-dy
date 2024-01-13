using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__5__16_dy
{
    public class Teacher :IPerson
    {
        public Teacher(string name,int age,string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public void printDetiles()
        {
            Console.WriteLine("new teacher add ");
        }
    }
}
 