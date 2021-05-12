﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerShop
{
    public class Menu
    {
        public int MenuId { get ; set; }
        public string MenuName { get; set; }
        public decimal MenuPrice { get; set; }

        public override string ToString()
        {
            return MenuName + " Menu";
        }
    }
}
