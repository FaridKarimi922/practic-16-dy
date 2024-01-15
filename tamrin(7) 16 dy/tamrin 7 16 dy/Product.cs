using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace tamrin_7_16_dy
{

    public class DairyProduct : IProduct
    {
        DateTime DateToday = DateTime.Today;
        public DairyProduct(string name, DateTime manufactureDate, DateTime expirationDate, int number)
        {
            Name = name;
            ManufactureDate = manufactureDate;
            ExpirationDate = expirationDate;
            Number = number;
        }
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int Number { get; set; }
        
        public void SetManufactureDate(DateTime manufactureDate)
        {
            if (manufactureDate < DateToday)
            {
                throw new Exception("tarikh tolid eshtebah ast");
            }
        }
        public void SetExpirationDate(DateTime expirationDate)
        {
            if (expirationDate > DateToday.AddDays(3))
            {
                throw new Exception("tarikh engheza Dairy Product eshtebah ast");
            }
        }

        public void SetNumber(int number)
        {
            if (number < 1 )
            {
                throw new Exception("The number cannot be less than 1");
            }
        }
    }
    public class DetergentProducts:IProduct
    {
        DateTime DateToday = DateTime.Today;
        public DetergentProducts(string name, DateTime manufactureDate, DateTime expirationDate, int number)
        {
            Name = name;
            ManufactureDate = manufactureDate;
            ExpirationDate = expirationDate;
            Number = number;
        }
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int Number { get; set; }

        public void SetManufactureDate(DateTime manufactureDate)
        {
            if (manufactureDate < DateToday.AddMonths(-3))
            {
                throw new Exception("tarikh tolid eshtebah ast");
            }
        }
        public void SetExpirationDate(DateTime expirationDate)
        {
            if (expirationDate > DateToday.AddYears(1))
            {
                throw new Exception("tarikh engheza eshtebah ast");
            }
        }
        public void SetNumber(int number)
        {
            if (number < 1)
            {
                throw new Exception("The number cannot be less than 1");
            }
        }

    }
    public class EdibleProducts :IProduct
    {
        DateTime DateToday = DateTime.Today;
        public EdibleProducts(string name, DateTime manufactureDate, DateTime expirationDate, int number)
        {
            Name = name;
            ManufactureDate = manufactureDate;
            ExpirationDate = expirationDate;
            Number = number;
        }
        public string Name { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int Number { get; set; }
        public void SetManufactureDate(DateTime manufactureDate)
        {
            if (manufactureDate < DateToday.AddMonths(-2))
            {
                throw new Exception("tarikh tolid eshtebah ast");
            }
        }
        public void SetExpirationDate(DateTime expirationDate)
        {
            if (expirationDate > DateToday.AddMonths(3))
            {
                throw new Exception("tarikh engheza eshtebah ast");
            }
        }
        public void SetNumber(int number)
        {
            if (number < 1)
            {
                throw new Exception("The number cannot be less than 1");
            }
        }

    }
}
