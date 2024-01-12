using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_9_16_dy
{
    public class Resturan
    {
        private static List<Personnel> _personnel = new List<Personnel>();
        private static List<Food> _foods = new List<Food>();
        private static List<Beverage> _beverages = new List<Beverage>();
        private static List<Order> _orders = new List<Order>();

        public static void AddPersonnel(string name, string gender, int age, int salary, int type)
        {
            var existPersonannel = _personnel.Any(_ => _.Name == name);
            if (existPersonannel)
            {
                ;
                throw new Exception("This personnel has already entered");

            }
            else
            {
                if (type == 1)
                {
                    Personnelkitchen personnelkitchen = new Personnelkitchen(name, gender, age, salary);
                    personnelkitchen.SetAge(age);
                    personnelkitchen.SetSalary(salary);
                    _personnel.Add(personnelkitchen);
                }
                if (type == 2)
                {
                    PersonnelSalon personnelSalon = new PersonnelSalon(name, gender, age, salary);
                    personnelSalon.SetAge(age);
                    personnelSalon.SetSalary(salary);
                    _personnel.Add(personnelSalon);
                }
            }

        }
        public static void DeletePersonnel(string name)
        {
            var existPersonannel = _personnel.Any(_ => _.Name == name);
            if (!existPersonannel)
            {
                throw new Exception("This personnel has already not entered");
            }
            if (existPersonannel)
            {
                var findPersonnel = _personnel.Find(_ => _.Name == name)!;
                _personnel.Remove(findPersonnel);
            }
        }

        public static List<Personnel> GetListPersonnel()
        {
            return _personnel;

        }
        public static void AddFood(string name, int price, int timeGEtReady, int typeFood)
        {
            switch (typeFood)
            {
                case 1:
                    {
                        Appetizer appetizer = new Appetizer(name);
                        appetizer.SetPrice(price);
                        appetizer.SetTimeGetReady(timeGEtReady);
                        _foods.Add(appetizer);
                        break;
                    }
                case 2:
                    {
                        MainCourse mainCourse = new MainCourse(name);
                        mainCourse.SetPrice(price);
                        mainCourse.SetTimeGetReady(timeGEtReady);
                        _foods.Add(mainCourse);
                        break;
                    }
                case 3:
                    {
                        Dessert dessert = new Dessert(name);
                        dessert.SetPrice(price);
                        dessert.SetTimeGetReady(timeGEtReady);
                        _foods.Add(dessert);
                        break;
                    }

                default:
                    Console.WriteLine("number not valid!!!");
                    break;
            }




        }
        public static void AddBeverage(string name, int price)
        {
            Beverage beverage = new Beverage(name, price);
            _beverages.Add(beverage);

        }
        public static List<Food> GetListFood()
        {
            return _foods;
        }
        public static List<Beverage> GetListBeverage()
        {
            return _beverages;
        }

        public static void AddOrder(int type, string namefood, string namebeverage)
        {
            var isFood = _foods.Any(_ => _.Name == namefood);
            var isBeverage = _beverages.Any(_ => _.Name == namebeverage);
            if (isFood && isBeverage)
            {
                var findFood = _foods.Find(_ => _.Name == namefood)!;
                var findBeverage = _beverages.Find(_ => _.Name == namebeverage)!;
                Order order = new Order(findFood, findBeverage);
                _orders.Add(order);
            }
            else
            {
                throw new Exception("food and beverage Does not exist");
            }

        }
        public static void AddOrder(int type, string namefood)
        {
            var isFood = _foods.Any(_ => _.Name == namefood);
            if (isFood)
            {
                var findFood = _foods.Find(_ => _.Name == namefood)!;
                Order order = new Order(findFood);
                _orders.Add(order);
            }
            else
            {
                throw new Exception("food Does not exist");
            }
        }



    }
}
