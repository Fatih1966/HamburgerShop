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

            var orderSum = (from sales in db.OrderSums
                            where sales.OrderDate >= dateTimePicker1.Value && sales.OrderDate <= dateTimePicker2.Value
                            select sales.TotalSum).Sum();
            textBox1.Text = orderSum.ToString();

            var MenSum = (from menusales in db.OrderSums
                            where menusales.OrderDate >= dateTimePicker1.Value && menusales.OrderDate <= dateTimePicker2.Value
                            select menusales.MenuSum).Sum();
            textBox2.Text = MenSum.ToString();

            var ExtraSum = (from extrasales in db.OrderSums
                          where extrasales.OrderDate >= dateTimePicker1.Value && extrasales.OrderDate <= dateTimePicker2.Value
                          select extrasales.ExtraSum).Sum();

            textBox3.Text = ExtraSum.ToString();
        }
    }
}
