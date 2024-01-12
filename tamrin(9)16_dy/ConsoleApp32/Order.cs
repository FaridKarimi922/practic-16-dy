using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_9_16_dy
{
    internal class Order
    {
        public Order(Food food)
        {
            foods =new List<Food>();
           
        }
        public Order(Food food , Beverage beverage)
        {
            foods = new List<Food>();
            beverages = new List<Beverage>();
        }

        public List<Food> foods { get; set; }
        public List<Beverage> beverages { get; set; }
    }
}
