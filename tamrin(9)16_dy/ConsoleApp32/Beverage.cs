using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_9_16_dy
{
    public class Beverage : IEatable
    {
        private int _price;
        public Beverage(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 10000)
                {
                    throw new Exception("The price of a drink cannot be less than 10,000 Tomans");
                }
                _price = value;
            }
        }

    }
}
