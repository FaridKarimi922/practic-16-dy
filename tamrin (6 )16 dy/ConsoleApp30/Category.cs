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
}
