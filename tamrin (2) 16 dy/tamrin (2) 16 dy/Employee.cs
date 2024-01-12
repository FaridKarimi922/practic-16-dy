using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__2__16_dy
{
    public class Employee
    {
        public Employee(string name )
        {
                Name = name;
        }
        public string Name { get; set; }
        public int ID { get; private set; }
        public int Salary { get; set; }
        public virtual void SetiD(int iD)
        {
            if (iD < 1)
            {
                throw new Exception("AD cannot be smaller than zero");
            }

            ID = iD;
        }
        public virtual void SetSalary(int salary)
        {
            if (salary < 1)
            {
                throw new Exception("salary cannot be smaller than zero");
            }

            Salary = salary;
        }
        public void PrintDetiles()
        {
            Console.WriteLine($"name is {Name} id is {ID} , salary is {Salary}");
        }
    }
}
