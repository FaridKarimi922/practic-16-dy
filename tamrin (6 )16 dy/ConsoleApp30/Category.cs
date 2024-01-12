using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_6_16_dy
{
    public class Category : ICategory
    {
        public Category(string name, int capacity)
        {
            Name = name;
            Iteam = new List<CategoryIteam>();
            for (int i = 1; i <= capacity; i++)
            {
                Iteam.Add(new CategoryIteam(i));

            }


        }
        public string Name { get; set; }
        public List<CategoryIteam> Iteam { get; set; }
    }
    public class CategoryIteam
    {
        public CategoryIteam(int number)
        {
            Number = number;
        }
        public int Number { get; set; }
        public Book? book { get; set; }

    }
    public abstract class Book : IBook
    {
        protected Book(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Price { get; private set; }
        public int Count { get; private set; }

        public virtual void AddPrice(int price)
        {
            if (price < 0)
            {
                throw new Exception("price nemitone kamtar az 0 bashad!!!");
            }
            Price = price;

        }
        public virtual void AddCount(int count)
        {
            if (count < 0)
            {
                throw new Exception("count nemitone kamtar az 0 bashad!!!");
            }
            Count = count;
        }


    }
    public class SaleBook : Book, IBook
    {
        public SaleBook(string name):base (name)
        {
                

        }
        public override void AddPrice(int price)
        {
            if (price > 10000)
            {
                throw new Exception("price nemitone bishtar az 10000 bashad!!!");
            }
            base.AddPrice(price);

        }
        public override void AddCount(int count)
        {
            if (count > 100)
            {
                throw new Exception("count nemitone bishtar az 100 bashad!!!");
            }
            base.AddCount(count);

        }
    }
    public class RentBook : Book, IBook
    {
        public RentBook(string name ):base (name)
        {


        }
        public override void AddPrice(int price)
        {
            if (price > 500)
            {
                throw new Exception("price nemitone bishtar az 500 bashad!!!");
            }
            base.AddPrice(price);

        }
        public override void AddCount(int count)
        {
            if (count > 200)
            {
                throw new Exception("count nemitone bishtar az 200 bashad!!!");
            }
            base.AddCount(count);

        }
    }
}
