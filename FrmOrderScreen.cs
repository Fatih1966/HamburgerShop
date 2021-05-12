using HamburgerShop.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerShop
{
    public partial class FrmOrderScreen : Form
    {

        public static List<Order> orders = new List<Order>(); // Needed for Reporting
        public static List<Order> currentOrder = new List<Order>(); // 
        OrderSum orderSum = new OrderSum();

        public static List<Menu> menusNew;

        public static List<Menu> menus = new List<Menu>()
        {
            new Menu { MenuName="Whooper" ,          MenuPrice=30,  MenuId=1},
            new Menu { MenuName="BigKing" ,          MenuPrice=35,  MenuId=2},
            new Menu { MenuName="King Chicken" ,     MenuPrice=28 , MenuId=3},
            new Menu { MenuName="McFish" ,           MenuPrice=40,  MenuId=4},
            new Menu { MenuName="Fenerbahce " ,  MenuPrice=55,  MenuId=5},
            new Menu { MenuName="Galatasaray " , MenuPrice=55,  MenuId=6},
            new Menu { MenuName="Besiktas " ,    MenuPrice=55,  MenuId=7}
        };

        public static List<Extra> extras = new List<Extra>()
        {
            new Extra{ ExtraName="Hardal",   ExtraPrice=2,ExtraId=1},
            new Extra{ ExtraName="Ketcap",   ExtraPrice=2,ExtraId=2},
            new Extra{ ExtraName="Mayonez",  ExtraPrice=2,ExtraId=3},
            new Extra{ ExtraName="Yeseillik",ExtraPrice=2,ExtraId=4},
            new Extra{ ExtraName="Sogan",    ExtraPrice=2,ExtraId=5}
        };

        
            public FrmOrderScreen()
            {
                InitializeComponent();
            }

        
        private void FrmOrderScreen_Load(object sender, EventArgs e)
        {
            cbEmployees.SelectedIndex = 0;


            foreach (var item in menus)
            {
                cbMenuler.Items.Add(item);
            }
    
            foreach (var extra in extras)
            {
                flpExtraMalzemeler.Controls.Add(new CheckBox() { Text = extra.ExtraName, Tag = extra });
            }

            cbMenuler.SelectedIndex = 0;
        }
        
        //Selected siparişleri newOrder'a ekliyor. newOrder'ı da currentOrder'a ekiyor.
        private void btnSiparisEkle_Click_1(object sender, EventArgs e)
        {
            Order newOrder = new Order();

            newOrder.OrderTakenBy = cbEmployees.SelectedItem.ToString();

            newOrder.OrderDate = DateTime.Now;

            newOrder.Menu = (Menu)cbMenuler.SelectedItem;

            if (rbKucuk.Checked)
                newOrder.SelectedSize = HamburgerShop.Size.Small;
            if (rbOrta.Checked)
                newOrder.SelectedSize = HamburgerShop.Size.Medium;
            if (rbBuyuk.Checked)
                newOrder.SelectedSize = HamburgerShop.Size.Large;

            newOrder.Quantity = (int)nmrAdet.Value;

            List<Extra> extras = new List<Extra>();
            foreach (CheckBox item in flpExtraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    extras.Add((Extra)item.Tag);
                }
            }

            newOrder.Extras = extras;

            //Bir order row'daki order'ın toplam maliyetini hesaplıyor.
            newOrder.Calculate();

            //Bu order'ın tüm değerleri ile currentOrder listesine eklenmesi.
            currentOrder.Add(newOrder);
 
            //Bu order'ın tüm değerleri ile geneli tutan orders listesine eklenmesi.
            orders.Add(newOrder);

            //listbox'a new order'ın ilave edilmesi.
            LstOrders.Items.Add(newOrder);

            CalculateAmount();
        }

        private void cbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btmSiparisTamamla_Click(object sender, EventArgs e)
        {
            string mesaj = "Toplam Siparis Ucreti:" + CalculateAmount().ToString() + " Satin Almayi Tamamlamak IStermisiniz";
            DialogResult dr = MessageBox.Show(mesaj, "Siparis Bilgisi ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                LstOrders.Items.Clear();
                CalculateAmount();

                MessageBox.Show("Siparis Tamamlandi");

                //Tools.Temizle(this.Controls);
                foreach (var item in currentOrder)
                {
                    orderSum.TotalSum += item.TotalAmount;
                    orderSum.MenuSum += item.MenusAmount;
                    orderSum.ExtraSum += item.ExtrasAmount;
                    orderSum.OrderDate = DateTime.Now;
                }

                using (var db = new MyDbContext())
                {

                    foreach (var item in currentOrder)
                    {
                        db.Orders.Add(item);  
                    };
                    db.OrderSums.Add(orderSum);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Siparis iptal Edildi");
            }
            currentOrder.Clear();
            orderSum.TotalSum = 0;
            orderSum.MenuSum = 0;
            orderSum.ExtraSum = 0;

        }

        //Complete Order'da listbox'daki tüm orderların toplamını hesaplayıp label'a yazıyor.
        private decimal CalculateAmount()
        {
            decimal totalAmount = 0;
            decimal menusAmount = 0;
            decimal extrasAmount = 0;

            foreach (Order order in LstOrders.Items)
            {
                totalAmount += order.TotalAmount;
                menusAmount += order.MenusAmount;
                extrasAmount += order.ExtrasAmount;
            }
            lbTotRev.Text = totalAmount.ToString();
            lbMenRev.Text = menusAmount.ToString();
            lbExRev.Text = extrasAmount.ToString();

            return totalAmount;
        }
    }
}
