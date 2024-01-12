using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__2__16_dy
{
    public static class Company
    {
        private static List<Employee> _employees = new List<Employee>();

        public static void AddEmployee(string name, int iD, int salary)
        {
            var isID = _employees.Any(_ => _.ID == iD);
            var isName =_employees.Any(_ => _.Name == name);
            if (isID || isName)
            {
                throw new Exception("This ID or Name has already been entered");
            }
            else
            {
                Employee employee = new Employee(name);
                employee.SetiD(iD);
                employee.SetSalary(salary);
                _employees.Add(employee);
                employee.PrintDetiles();
            }
        }
        public static void AddManager(string name, int iD, int salary, int department)
        {
            var isID = _employees.Any(_ => _.ID == iD);
            var isName = _employees.Any(_ => _.Name == name);
            if (isID || isName)
            {
                throw new Exception("This ID or Name has already been entered");
            }
            else
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
}
