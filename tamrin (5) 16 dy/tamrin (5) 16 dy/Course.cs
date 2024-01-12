using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__5__16_dy
{
    public class Course : ICourse
    {
        public Course(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public Teacher Teacher { get; private set; }
        public int Unit { get; private set; }
        public int StudentCount { get; set; }
        public List<Student> students { get; private set; }
        public void AddStudent(Student st)
        {
            students.Add(st);
            StudentCount++;
            Console.WriteLine($"student {st.Name} is added seccesfuly");
        }
        public void SetUnit(int unit)
        {
            if (unit < 1)
            {
                throw new Exception("The number of units cannot be less than 1");
            }
            Unit = unit;
        }
        public void SetStudentCount(int studentCount)
        {
            if (StudentCount < 0)
            {
                throw new Exception("The number of StudentCount cannot be less than 0");
            }
            StudentCount = studentCount;
        }
        public void SetTeacher(Teacher teacher)
        {

            Teacher = teacher;
        }
    }
}

