using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__5__16_dy
{
    public static class Collage
    {
        private static List<Student> _students = new List<Student>();
        private static List<Teacher> _techers = new List<Teacher>();
        private static List<Course> _courses = new List<Course>();

        public static void AddStudent(string name, int age, string field)
        {
            var isName = _students.Any(_ => _.Name == name);
            if (!isName)
            {
                Student student = new Student(name, age, field);
                _students.Add(student);
                student.printDetiles();
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
                teacher.printDetiles();
            }
            else
            {
                Console.WriteLine("This name has already been entered");
            }
        }

        public static void AddCourse(string name, string nameTeacher, int unit, int studentCount)
        {
            var findTeacher = _techers.Find(_ => _.Name == nameTeacher)!;
            var isteacher = _techers.Any(_ => _.Name == nameTeacher);
            if (isteacher)
            {
                Course course = new Course(name);
                course.SetTeacher(findTeacher);
                course.SetUnit(unit);
                course.SetStudentCount(studentCount);
                _courses.Add(course);
            }
            else
            {
                Console.WriteLine("teacher not added");
            }

        }
        public static void AdddStudentToCourse(string nameStudent, string NameCourse)
        {
            var findStudent = _students.Find(_ => _.Name == nameStudent)!;
            var findcourse = _courses.Find(_ => _.Name == NameCourse)!;
            var isstudent = _students.Any(_ => _.Name == nameStudent);
            var isCourse = _courses.Any(_ => _.Name == NameCourse);

            if (isstudent && isCourse)
            {
                if (findStudent.AskforCourse(findcourse))
                {
                    findcourse.AddStudent(findStudent);
                }
            }
            else
            {
                Console.WriteLine("student or course not added");
            }


        }
    }
}
