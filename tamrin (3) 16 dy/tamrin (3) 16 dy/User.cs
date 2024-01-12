using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin__3__16_dy
{
    public class User
    {
        private string _nationalCode;
        public User(string name, string nationalCode)
        {
            Name = name;
            NationalCode = nationalCode;
        }
        public String Name { get; set; }
        public string NationalCode
        {
            get
            {
                return _nationalCode;
            }
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("The national code cannot be less than 7 characters!!!");
                }
                _nationalCode = value;
            }
        }

    }
}
