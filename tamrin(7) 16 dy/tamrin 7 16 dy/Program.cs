using System.Diagnostics;

namespace tamrin_7_16_dy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Store management");
            var option = GetIntegerValid("1_ add manager 2_add Worker 3_ add product 4 _add Customer");
            switch (option)
            {
                case 1:
                    {
                        var name = GetStringValid("enter name new manager :");
                        var salary = GetIntegerValid("enter salary manager :");
                        Store.AddManager(name, salary);

                        break;
                    }
                case 2:
                    {
                        var name = GetStringValid("enter name new worker :");
                        var salary = GetIntegerValid("enter salary worker :");
                        Store.AddWorker(name, salary);

                        break;
                    }
                case 3:
                    {




                        break;
                    }

                default:
                    break;
            }


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
