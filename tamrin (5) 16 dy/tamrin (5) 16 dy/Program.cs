using System.Threading.Channels;

namespace tamrin__5__16_dy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var option = GetIntegerValid("1 _ add student \n2 _ add teacher \n3 _ add course \n4_ add student to course ");
                switch (option)
                {
                    case 1:
                        {
                            var name = GetStringValid("Enter Name student :");
                            var age = GetIntegerValid("Enter age student :");
                            var field = GetStringValid("Enter feild student :");

                            Collage.AddStudent(name, age, field);

                            break;
                        }
                    case 2:
                        {
                            var name = GetStringValid("Enter Name teacher :");
                            var age = GetIntegerValid("Enter age teacher :");
                            var course = GetStringValid("Enter course teacher :");
                            Collage.AddTeacher(name, age, course);

                            break;
                        }
                    case 3:
                        {
                            var nameCourse = GetStringValid("enter name Course :");
                            var nameTeacher = GetStringValid("enter name teacher :");
                            var unit = GetIntegerValid("enter unit course :");
                            var studentCount = GetIntegerValid("enter student count course :");

                            Collage.AddCourse(nameCourse, nameTeacher, unit, studentCount);

                            break;
                        }
                    case 4:
                        {
                            var nameStudent = GetStringValid("enter name student :");
                            var nameCourse = GetStringValid("enter name Course :");
                            Collage.AdddStudentToCourse(nameStudent, nameCourse);


                            break;
                        }


                    default:
                        Console.WriteLine("not valid !!!");
                        break;
                }





            } while (true);
           
        }
        public static int GetIntegerValid(string message)
        {
            int value;
            bool integerValid;
            do
            {
                Console.WriteLine(message);
                integerValid = int.TryParse(Console.ReadLine(), out value);



            } while (!integerValid);
            return value;
        }
        public static string GetStringValid(string message)
        {
            string? value;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(value));
            return value;
        }
    }
}
