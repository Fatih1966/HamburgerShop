using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerShop
{
    public interface IAuditEntity<T>
    {
        DateTime CreateTime { get; set; }
        T CreateUser { get; set; }
    }
}
