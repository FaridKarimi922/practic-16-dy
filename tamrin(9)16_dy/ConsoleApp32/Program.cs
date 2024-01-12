namespace tamrin_9_16_dy
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
                catch (Exception exeption)
                {
                    ShowStar();
                    Console.WriteLine(exeption.Message);
                    ShowStar();

                }
            } while (true);

            static void Run()
            {

                var option = GetIntegerValid("1 - admin :\n2 - Personnel :\n3 - User : ");
                switch (option)
                {
                    case 1:
                        {
                            var optionAdmin = GetIntegerValid("1 - Personnel management :\n2 - Food management :\n3 - Manage orders : ");
                            switch (optionAdmin)
                            {
                                case 1:
                                    {
                                        var personnelManagement = GetIntegerValid("1 - Add New Personnel :\n2 - Delete personnel : \n3 - Show personnel :\n4 - show Customer");
                                        switch (personnelManagement)
                                        {
                                            case 1:
                                                {
                                                    var name = GetStringValid("Enter Name :");
                                                    var gender = GetStringValid("Enter gender  :");
                                                    var age = GetIntegerValid("enter age :");
                                                    var salary = GetIntegerValid("enter salary :");
                                                    var typeWork = GetIntegerValid("1 - kitchen 2 - salon ");

                                                    Resturan.AddPersonnel(name, gender, age, salary, typeWork);

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    var name = GetStringValid("enter name :");
                                                    Resturan.DeletePersonnel(name);


                                                    break;
                                                }
                                            case 3:
                                                {
                                                    foreach (var personnel in Resturan.GetListPersonnel())
                                                    {

                                                        Console.WriteLine($"name is = {personnel.Name} age is = {personnel.Age} salary is = {personnel.Salary} Type of Activity = {personnel.TypeWork}");

                                                    }


                                                    break;
                                                }

                                            





                                            default:
                                                Console.WriteLine("not valid!!!");
                                                break;
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        var FoodManagement = GetIntegerValid("1 - Add Food :\n2 - Add Beverages : \n4 - show Food and Beverages");
                                        switch (FoodManagement)
                                        {
                                            case 1:
                                                {
                                                    var nameFood = GetStringValid("enter name food :");
                                                    var price = GetIntegerValid("enter price :");
                                                    var timeGEtReady = GetIntegerValid("enter time of ready :");
                                                    var typeFood = GetIntegerValid("1 - Appetizer: 2 - MainCourse: 3 - Dessert:");

                                                    Resturan.AddFood(nameFood, price, timeGEtReady, typeFood);

                                                    break;
                                                }
                                            case 2:
                                                {
                                                    var nameBeverage = GetStringValid("enter name Beverage :");
                                                    var price = GetIntegerValid("enter price Beverage :");
                                                    Resturan.AddBeverage(nameBeverage, price);
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    ShowStar();
                                                    Console.WriteLine("food -");
                                                    foreach (var food in Resturan.GetListFood())
                                                    {
                                                        Console.WriteLine($"name = {food.Name} price = {food.Price} time of ready = {food.TimeGEtReady} min");
                                                    }
                                                    Console.WriteLine("-----------------");
                                                    Console.WriteLine("beverage -");
                                                    foreach (var beverage in Resturan.GetListBeverage())
                                                    {
                                                        Console.WriteLine($"name = {beverage.Name} price = {beverage.Price} toman ");
                                                    }
                                                    ShowStar();
                                                    break;
                                                }

                                            default:
                                                Console.WriteLine("not valid!!!");
                                                break;
                                        }


                                        break;
                                    }
                                case 3:
                                    {
                                        var orderManegment = GetIntegerValid("1 - Add Order : \n2 - online order : \n3 - show orders :");
                                        switch (orderManegment)
                                        {
                                            case 1:
                                                {

                                                    var typeOrder = GetIntegerValid("1 - food \n2 -food with beverage :");
                                                    if (typeOrder == 1)
                                                    {
                                                        var nameFood = GetStringValid("enter name food :");
                                                        Resturan.AddOrder(typeOrder, nameFood);
                                                    }
                                                    if (typeOrder == 2)
                                                    {
                                                        var nameFood = GetStringValid("enter name food :");
                                                        var nameBeverage = GetStringValid("enter Name beverage :");
                                                        Resturan.AddOrder(typeOrder, nameFood, nameBeverage);
                                                    }
                                                    break;
                                                }
                                           






                                            default:
                                                Console.WriteLine("not valid!!!");
                                                break;
                                        }
                                        break;
                                    }

                                default:
                                    break;
                            }















                            break;
                        }






                    default:
                        break;
                }










            }






















        }

        public static int GetIntegerValid(string message)
        {
            int value;
            bool stringValid;
            do
            {
                Console.WriteLine(message);
                stringValid = int.TryParse(Console.ReadLine(), out value);

            } while (!stringValid);
            return value;


        }
        public static string GetStringValid(string message)
        {
            string? value;
            do
            {
                Console.WriteLine(message);
                value = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(value) || value.Length < 2);

            return value;
        }
        public static void ShowStar()
        {
            Console.WriteLine("*********************************************");

        }

    }
}
