namespace tamrin__2__16_dy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
            var option = GetIntegerValid("1_ add employee\n2_ add manager");

                switch (option)
                {
                    case 1:
                        {
                            var name = GetStringValid("enter name employee :");
                            var iD = GetIntegerValid("enter ID employee :");
                            var salary = GetIntegerValid("enter salary employee :");
                            Company.AddEmployee(name, iD, salary);

                            break;
                        }
                    case 2:
                        {
                            var name = GetStringValid("enter name manager :");
                            var iD = GetIntegerValid("enter ID manager :");
                            var salary = GetIntegerValid("enter salary manager :");
                            var department = GetIntegerValid("enter department manager :");

                            Company.AddManager(name, iD, salary,department);

                            break;
                        }



                    default:
                        Console.WriteLine("not valid!!!");
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
