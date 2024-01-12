using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_9_16_dy
{
    public abstract class Food : IFood
    {
        protected Food(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Price { get; private set; }
        public int TimeGEtReady { get; private set; }


        public virtual void SetPrice(int price)
        {
            Price = price;
        }
        public virtual void SetTimeGetReady(int timeGetReady)
        {
            TimeGEtReady = timeGetReady;
        }

    }
    public class Appetizer : Food ,IFood
    {
        public Appetizer(string name) : base(name)
        {
        }
       
        public override void SetTimeGetReady(int timeGetReady)
        {
            if (timeGetReady > 5)
            {
                throw new Exception("The appetizer cannot take more than 5 minutes");
            }
            base.SetTimeGetReady(timeGetReady);
        }

        public override void SetPrice(int price)
        {
            if (price < 25000)
            {
                throw new Exception("The price cannot be less than 25,000 toman");
            }
            base.SetPrice(price);
        }
    }
    public class MainCourse : Food, IFood
    {
        public MainCourse(string name) : base(name)
        {
        }
        public override void SetPrice(int price)
        {
            if (price < 150000)
            {
                throw new Exception("The price cannot be less than 150,000 toman");
            }
            base.SetPrice(price);
        }

        public override void SetTimeGetReady(int timeGetReady)
        {
            if (timeGetReady > 20)
            {
                throw new Exception("The appetizer cannot take more than 20 minutes");
            }
            base.SetTimeGetReady(timeGetReady);
        }
    }
    public class Dessert : Food, IFood
    {
        public Dessert(string name) : base(name)
        {
        }

        public override void SetPrice(int price)
        {
            if (price < 60000)
            {
                throw new Exception("The price cannot be less than 60,000 toman");
            }
            base.SetPrice(price);
        }
        public override void SetTimeGetReady(int timeGetReady)
        {
            if (timeGetReady > 10)
            {
                throw new Exception("The appetizer cannot take more than 10 minutes");
            }
            base.SetTimeGetReady(timeGetReady);
        }
    }
}
