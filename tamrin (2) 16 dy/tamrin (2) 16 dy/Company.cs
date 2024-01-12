using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__2__16_dy
{
    public static class Company
    {
        private static List<Employee>_employees = new List<Employee>();
        private static List<Manager>_managers = new List<Manager>();
        public static void AddEmployee(string name,int iD,int salary)
        {
            Employee employee = new Employee(name);
            employee.SetiD(iD);
            employee.SetSalary(salary);
            _employees.Add (employee);
            employee.PrintDetiles();

        }
        public static void AddManager(string name, int iD, int salary,int department)
        {
            Manager manager = new Manager(name);
            manager.SetiD(iD);
            manager.SetSalary(salary);
            manager.SetDepartment(department);
            _employees.Add(manager);
            manager.PrintDetiles();
        }




    }
}
