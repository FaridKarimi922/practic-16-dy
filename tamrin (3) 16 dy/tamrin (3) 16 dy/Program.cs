using System.Security.Cryptography.X509Certificates;

namespace tamrin__3__16_dy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

                try
                {
                    Run();
                }
                catch (Exception exception)
                {

                    Console.WriteLine(exception.Message);
                }
            } while (true);


            static void Run()
            {

                var option = GetIntegerValid("1_ Add Car\n2_ Show Cars\n3_ Add User\n4_ Rent Car");
                switch (option)
                {
                    case 1:
                        {
                            var typeCAr = GetIntegerValid("1 - Iranian Car \n2 - Foreign Car");
                            var name = GetStringValid("Enter Car Name : ");
                            var speed = GetIntegerValid("Enter Car Speed :");
                            var model = GetIntegerValid("Enter Car Model :");

                            RentalCompany.AddCar(name, speed, model, typeCAr);


                            break;

                        }
                    case 2:
                        {
                            foreach (var item in RentalCompany.GetCars())
                            {

                                Console.WriteLine($"name = {item.Name} speed = {item.Speed} model = {item.Model}");
                            }

                            break;
                        }
                    case 3:
                        {
                            var name = GetStringValid("Enter User Name :");
                            var nationalCode = GetStringValid("Enter National Code : (More than 7 characters)");
                            RentalCompany.AddUser(name, nationalCode);

                            break;
                        }
                    case 4:
                        {
                            var userName = GetStringValid("Enter User Name :");
                            var carName = GetStringValid("Enter Car Name :");
                            RentalCompany.RentCar(userName, carName);



                            break;
                        }
                    case 5:
                        {
                            foreach (var rent in RentalCompany.GetRent())
                            {
                                foreach (var car in RentalCompany.GetCars())
                                {
                                    foreach (var user in RentalCompany.GetUSer())
                                    {
                                        Console.WriteLine($"name is {car.Name} rent {user.Name}");
                                    }
                                }
                            }


                            break;
                        }
                    default:
                        Console.WriteLine("not valid!!!");
                        break;
                }
            }





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
        public static int GetIntegerValid(string message)
        {
            int value;
            bool validInteger;
            do
            {
                Console.WriteLine(message);
                validInteger = int.TryParse(Console.ReadLine(), out value);

            } while (!validInteger);

            return value;
        }
    }
}
