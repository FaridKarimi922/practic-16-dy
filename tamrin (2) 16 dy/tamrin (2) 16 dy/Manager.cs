using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__2__16_dy
{
    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }
        public int Department { get; private set; }
        public void SetDepartment(int department)
        {
            if (department < 0)
            {
                throw new Exception("The part number cannot be less than zero");
            }
            Department = department;
        }
        public override void SetiD(int iD)
        {
            base.SetiD(iD);
        }

        public override void SetSalary(int salary)
        {
            if (salary < 6000)
            {
                throw new Exception("salary cannot be smaller than 6000 toman");
            }
            base.SetSalary(salary);
        }
        public void PrintDetiles()
        {
            Console.WriteLine($"name is {Name} id is {ID} , salary is {Salary} department is {Department}");
        }
    }
}
