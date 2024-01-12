using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_9_16_dy
{
    public abstract class Personnel
    {
        private string? _name;

        protected Personnel(string name, string gender, int age, int salary)
        {
            Name = name;
            Gender = gender;
            Age = age;

        }
        public string? Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name cannot be empty");
                }
                _name = value;
            }
        }
        public int TypeWork { get; set; }
        public string Gender { get; set; }
        public int Age { get; private set; }
        public int Salary { get; private set; }

        public virtual void SetAge(int age)
        {
            if (age < 0)
            {
                throw new Exception("Age cannot be less than 0");
            }
            Age = age;
        }
        public virtual void SetSalary(int salary)
        {
            if (salary < 0)
            {
                throw new Exception("salary cannot be less than 0");
            }
            Salary = salary;
        }



    }
    public class Personnelkitchen : Personnel
    {
        public Personnelkitchen(string name, string gender, int age, int salary ) : base(name, gender, age, salary)
        {

        }
       
        public override void SetAge(int age)
        {
            if (age < 25)
            {
                throw new Exception("Age personel kitchen cannot be less than 25");
            }
            base.SetAge(age);
        }
        public override void SetSalary(int salary)
        {
            if (salary < 10000)
            {
                throw new Exception("salary cannot be less than 10000");
            }
            base.SetSalary(salary);
        }

    }
    public class PersonnelSalon : Personnel
    {
        public PersonnelSalon(string name, string gender, int age, int salary) : base(name, gender, age, salary)
        {
        }
        public override void SetAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Age personel salon cannot be less than 18");
            }
            base.SetAge(age);
        }
        public override void SetSalary(int salary)
        {
            if (salary < 5000)
            {
                throw new Exception("salary cannot be less than 5000");
            }
            base.SetSalary(salary);
        }
    }
}
