using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_1__16_dy
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public static void GetFullName (string firstName, string lastName )
        {

            
            Console.WriteLine($"Hello {firstName} {lastName}");
        }


    }
}
