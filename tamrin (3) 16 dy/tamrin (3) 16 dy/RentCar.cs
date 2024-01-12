using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__3__16_dy
{
    internal class RentCar
    {

        public RentCar(User user, Car car)
        {
            Cars = new List<Car>();
            Users = new List<User>();

        }

        public List<Car> Cars { get; set; }

        public List<User> Users { get; set; }
    }
}
