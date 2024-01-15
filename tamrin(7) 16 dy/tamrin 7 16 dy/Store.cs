using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_7_16_dy
{
    public static class Store
    {
        private static List<Manager> _managers = new List<Manager>();
        private static List<Worker> _workers = new List<Worker>();
        private static List<IProduct> _products = new List<IProduct>();

        public static void AddManager(string name, int salary)
        {
            Manager manager = new Manager(name, salary);

            manager.SetSalary(salary);
            _managers.Add(manager);

        }
        public static void AddWorker(string name, int salary)
        {
            Worker worker = new Worker(name, salary);
            worker.SetSalary(salary);
            _workers.Add(worker);
        }














    }
}
