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
    public partial class FrmExtra : Form
    {
        public FrmExtra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Extra extra = new Extra();
            extra.ExtraName = txtName.Text;
            extra.ExtraPrice = nmrPrice.Value;
            extra.ExtraId =FrmOrderScreen.extras.Count + 1;
            FrmOrderScreen.extras.Add(extra);

            txtName.Text = "";
            nmrPrice.Value = 1;

            MessageBox.Show("Added Sucessfully");
        }
    }
}
