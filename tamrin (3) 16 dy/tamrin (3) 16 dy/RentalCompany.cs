using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__3__16_dy
{
    internal class RentalCompany
    {
        private static List<Car> _cars = new List<Car>();
        private static List<User> _users = new List<User>();
        private static List<RentCar> _rents = new List<RentCar>();


        public static void AddCar(string name, int speed, int model, int type)
        {
            if (type == 1)
            {
                IranianCar iranianCar = new IranianCar(name, speed, model);
                iranianCar.SetSpeed(speed);
                iranianCar.SetModel(model);
                _cars.Add(iranianCar);
               
                
               
            }
            if (type == 2)
            {
                ForeignCar foreignCar = new ForeignCar(name, speed, model);
                foreignCar.SetSpeed(speed);
                foreignCar.SetModel(model);
                _cars.Add(foreignCar);

            }
        }
        public static List<Car> GetCars()
        {
            return _cars;
        }
        public static void AddUser(string name,string nationalCode)
        {
            User user = new User(name, nationalCode);
            _users.Add(user);



        }
        public static void RentCar (string userName ,string carName )
        {
            var existUser = _users.Any(_ => _.Name == userName);
            var existCar = _cars.Any(_ => _.Name == carName);
            if (existUser && existCar)
            {
                var findUser = _users.Find(_ => _.Name == userName)!;
                var findCar = _cars.Find(_ => _.Name == carName)!;
                RentCar rent = new RentCar(findUser, findCar);

                _rents.Add(rent);


            }
            else
            {
                throw new Exception("User or machine not found!!!");
            }


        }
        public static List<RentCar> GetRent()
        {
            return _rents;
        }
        public static List<User> GetUSer()
        {
            return _users;
        }
    }
}
