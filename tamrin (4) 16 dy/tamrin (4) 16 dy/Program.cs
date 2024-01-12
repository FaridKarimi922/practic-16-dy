namespace tamrin__4__16_dy
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
          
            }while (true);
            static void Run()
            {
                var option = GetIntegerValid("1_Add Charecter :\n2_show Charecters :\n3_atack :");
                switch (option)
                {
                    case 1:
                        {
                            var Type = GetIntegerValid("1_Add Hiro :\n2_Add Enemy :\n3_Add Npc :");
                            var name = GetStringValid("Enter Charecters Name :");
                            var power = GetIntegerValid("Enter Charecters Power :");
                            var speed = GetIntegerValid("Enter Charecters Speed :");
                            var health = GetIntegerValid("Enter Charecters Health :");
                           
                            Game.AddCharecter(Type, name, power, speed, health);


                            break;
                        }
                    case 2:
                        {
                           
                            foreach (var charecter  in Game.GetCharecters())
                            {

                                var type = charecter.GetType().Name;
                                Console.WriteLine($"{type} \nName ={charecter.Name} speed = {charecter.Speed}" +
                                    $" power = {charecter.Power} health = {charecter.Health}");
                               
                            }

                            break;
                        }
                    case 3:
                        {
                            var nameAtacker = GetStringValid("enter name atacker :");
                            var nameDefender = GetStringValid("enter name defender :");

                            Game.attack(nameAtacker, nameDefender);

                            break;
                        }





                    default:
                        Console.WriteLine("not valid!!!");
                        break;
                }
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
