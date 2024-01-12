using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__5__16_dy
{
    public class Collage
    {
        private static List<Student> _students = new List<Student>();
        private static List<Teacher> _techers = new List<Teacher>();
        private static List<Course> _courses = new List<Course>();

        public static void AddStudent(string name ,int age ,string field)
        {
            var isName = _students.Any(_ => _.Name == name);
            if (!isName)
            {
                Student student = new Student(name, age, field);
                _students.Add(student);
            }
            else
            {
                Console.WriteLine("This name has already been entered");
            }
        }
        public static void AddTeacher(string name, int age, string course)
        {
            var isName = _techers.Any(_ => _.Name == name);
            if (!isName)
            {
                Teacher teacher = new Teacher(name, age, course);
                _techers.Add(teacher);
            }
            else
            {
                Console.WriteLine("This name has already been entered");
            }
        }

        public static void AddCourse(string name, string nameTeacher, int unit, int studentCount)
        {
            Course course = new Course(name);
            var findTeacher = _techers.Find(_ => _.Name == nameTeacher)!;
            course.SetTeacher(findTeacher);
            course.SetUnit(unit);
            course.SetStudentCount(studentCount);
            _courses.Add(course);
          
        }
        public static void AdddStudentToCourse(string nameStudent ,string NameCourse)
        {
            var findStudent = _students.Find(_ => _.Name == nameStudent)!;
            var findcourse = _courses.Find(_ => _.Name == NameCourse)!;

            if (findStudent.AskforCourse(findcourse))
            {
                findcourse.AddStudent(findStudent);
            }


        }
    }
}
