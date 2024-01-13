using System.Diagnostics;
using System.Runtime;

namespace tamrin_6_16_dy
{
    public class SaleBook : IBook
    {
        public SaleBook(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;

        }
        public string Name { get; set; }
        public int Price { get;private set; }
        public int Count { get;private set; }



        public void SetCount(int count)
        {
            if (count > 100)
            {
                throw new Exception("count nemitone bishtar az 100 bashad!!!");
            }
        }

        public void SetPrice(int price)
        {
            if (price > 10000)
            {
                throw new Exception("price nemitone bishtar az 10000 bashad!!!");
            }
        }
    }
}
