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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmOrderScreen());
        }

        public void ChildForm(Form _childForm)
        {
            this.Height = _childForm.Height + 200;
            this.Width = _childForm.Width + 200;
            bool status = false; // child ekranin durumunu kontrol icin 

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    status = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }

            if (status == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void addMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmMenu());
        }

        private void extraMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmExtra());
        }

        private void orderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmSumReport());
        }

        private void ordersDetailedInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new FrmDetailedReport());
        }
    }
}
