using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin_7_16_dy
{
    public interface IProduct
    {
        public string Name { get; set; }
        void SetManufactureDate(DateTime manufactureDate);
        void SetExpirationDate(DateTime expirationDate);
        void SetNumber(int number);

    }
}
