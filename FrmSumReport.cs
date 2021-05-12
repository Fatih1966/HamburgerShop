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
    public partial class FrmSumReport : Form
    {

        MyDbContext db = new MyDbContext();
        public FrmSumReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from ord in db.OrderSums
                                        where ord.OrderDate >= dateTimePicker1.Value && ord.OrderDate <=dateTimePicker2.Value 
                                        select new
                                        {
                                            ord.Id,
                                            ord.OrderDate,
                                            ord.TotalSum,
                                            ord.MenuSum,
                                            ord.ExtraSum,
                                        }).ToList();
        }
    }
}
