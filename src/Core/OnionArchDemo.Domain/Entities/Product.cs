using OnionArchDemo.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchDemo.Domain.Entities
{
    public class Product:BaseEntity
    {
        public String Name { get; set; }
        public decimal  Value { get; set; }

        public int Quentity { get; set; }
    }
}
