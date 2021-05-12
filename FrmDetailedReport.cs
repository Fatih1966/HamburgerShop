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
    public partial class FrmDetailedReport : Form
    {
        MyDbContext db = new MyDbContext();
        public FrmDetailedReport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from ord in db.Orders
                                        select new
                                        {
                                            ord.OrderId,
                                            ord.OrderDate,
                                            ord.OrderTakenBy,
                                            ord.Menu.MenuName,
                                            ord.SelectedSize,
                                            ord.Quantity,
                                            ord.TotalAmount,
                                            ord.MenusAmount,
                                            ord.ExtrasAmount,

                                        }).ToList();
        }
    }
}
