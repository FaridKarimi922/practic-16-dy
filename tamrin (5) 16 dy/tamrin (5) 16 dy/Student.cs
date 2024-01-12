using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__5__16_dy
{
    public class Student : IPerson
    {
        public Student(string name, int age, string field)
        {
            Name = name;
            Age = age;
            Field = field;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Field { get; set; }
        public bool AskforCourse(Course course)
        {
            if (course.StudentCount < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
