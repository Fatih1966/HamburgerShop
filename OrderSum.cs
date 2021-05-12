using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerShop
{
    public class OrderSum
    {
        public int Id { get; set; }
        public decimal TotalSum { get; set; }
        public decimal MenuSum { get; set; }
        public decimal ExtraSum { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
