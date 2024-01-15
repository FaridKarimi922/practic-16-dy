using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_7_16_dy
{
    public class Worker : IPerson
    {
        public Worker(string name, int salary)
        {
            Name = name;

            Salary = salary;
        }
        public string Name { get; set; }

        public int Salary { get; set; }

        public void SetSalary(int salary)
        {
            if (salary < 80000)
            {
                throw new Exception("The worker's salary cannot be less than 72000 toman");
            }
        }


    }
}
