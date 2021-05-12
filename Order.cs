using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerShop
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderTakenBy { get; set; }
        public DateTime OrderDate { get; set; }

        public Menu Menu { get; set; }
        public Size SelectedSize { get; set; }
        public int Quantity { get; set; }
        public List<Extra> Extras { get; set; }
        public decimal  TotalAmount { get; set; }
        public decimal MenusAmount { get; set; }
        public decimal ExtrasAmount { get; set; }



        public override string ToString()
        {

            if (Extras.Count<1)
            {
                return $"{Menu} x {Quantity} {SelectedSize} size, Total : {TotalAmount}";
            }
            else
            {
                string extraMaterials = null;
                foreach (var item in Extras)
                {
                    extraMaterials += item.ExtraName + " ";
                }
                return $"{Menu} x {Quantity} {SelectedSize} size, Extra : {extraMaterials} Total : {TotalAmount}";
            }
        }

        public void Calculate()
        {

                TotalAmount = 0;
                MenusAmount = 0;
                ExtrasAmount = 0;

                MenusAmount += Menu.MenuPrice;
                switch (SelectedSize)
                {
                    case Size.Small:
                        MenusAmount = MenusAmount;
                        break;
                    case Size.Medium:
                        MenusAmount += MenusAmount * 0.1m;
                        break;
                    case Size.Large:
                        MenusAmount += MenusAmount * 0.2m;
                        break;
                    default:
                        break;
                }

            foreach (var item in Extras)
            {
                ExtrasAmount += item.ExtraPrice;
            }
            TotalAmount = MenusAmount + ExtrasAmount;
            MenusAmount = MenusAmount * Quantity;
            ExtrasAmount = ExtrasAmount * Quantity;
            TotalAmount = TotalAmount * Quantity;

        }


    }
}
