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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.MenuName = txtMenuAdi.Text;
            m.MenuPrice = nmrFiyat.Value;
            m.MenuId = FrmOrderScreen.menus.Count + 1;
            FrmOrderScreen.menus.Add(m);

            txtMenuAdi.Text = "";
            nmrFiyat.Value = 1;

            MessageBox.Show("Added Sucessfully");

        }
    }
}
