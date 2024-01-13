namespace tamrin_6_16_dy
{
    public class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {

                try
                {
                    Run();
                }
                catch (Exception exeption)
                {

                    ShowError(exeption.Message);

                }

            }


            static void Run()
            {
                var option = GetInt("1_Add Categori" +
                    "\n2_show categori " +
                    "\n3_show category with detiles" +
                    "\n4_Add Book" +
                    "\n5_Add book to Category" +
                    "\n6_delete book :" +
                    "\n9_add user");

                switch (option)
                {
                    case 1:
                        {
                            var name = GetString("enter name category:");
                            var capacity = GetInt("enter capacity :");

                            Librari.addCategori(name, capacity);

                            break;
                        }
                    case 2:
                        {
                            foreach (var categori in Librari.GetCategories())
                            {
                                var capacity = categori.Iteam.Count;
                                var remainingCapacity = categori.Iteam.Where(_ => _.Book == null).Count();

                                Console.WriteLine($"name is {categori.Name}\ncapacity is {categori.Iteam.Count}" +
                                    $"\nremaining capacity {remainingCapacity}");

                            }

                            break;
                        }
                    case 3:
                        {
                            foreach (var categori in Librari.GetCategories())
                            {
                                var capacity = categori.Iteam.Count;
                                var remainingCapacity = categori.Iteam.Where(_ => _.Book == null).Count();

                                Console.WriteLine($"name is {categori.Name}\ncapacity is {categori.Iteam.Count}" +
                                    $"\nremaining capacity {remainingCapacity}");

                                foreach (var item in categori.Iteam)
                                {
                                    var bookName = item.Book == null ? "null" : item.Book.Name;
                                    Console.WriteLine($"number is {item.Number} - book is {bookName} ");
                                }
                            }


                            break;
                        }
                    case 4:
                        {
                            var name = GetString("enter name book");
                            var price = GetInt("enter name price :");
                            var count = GetInt("enter name count :");

                            var type = GetInt("1 _Sale - 2 _ Rent");


                            Librari.AddBook(name, type, price, count);


                            break;
                        }
                    case 5:
                        {
                            var name = GetString("enter name book");
                            var category = GetString("enter categori :");
                            var number = GetInt("enter number :");

                            Librari.AddBookToCategory(name, category, number);


                            break;
                        }
                    case 6:
                        {
                            var bookName = GetString("enter name book");
                            var categoryName = GetString("enter name category :");
                            Librari.DeleteBook(bookName, categoryName);

                            break;
                        }
                    case 9:
                        {
                            var name = GetString("enter name");
                            Librari.AddUser(name);

                            break;
                        }






                    default:
                        break;
                }



            }



        }
        public static string GetString(string meesage)
        {
            string value;

            do
            {
                Console.WriteLine(meesage);
                value = Console.ReadLine()!;

            } while (string.IsNullOrWhiteSpace(value));

            return value;
        }
        public static int GetInt(string meesage)
        {
            int value;
            bool validInt;

            do
            {
                Console.WriteLine(meesage);
                validInt = int.TryParse(Console.ReadLine(), out value);



            } while (!validInt);

            return value;

        }
        static void ShowError(string erroe)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(erroe);
            Console.WriteLine("--------------------");


        }
    }
}
