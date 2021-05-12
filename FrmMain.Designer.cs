
namespace HamburgerShop
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraMaterialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersDetailedInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderManagementToolStripMenuItem,
            this.productManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1313, 52);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderManagementToolStripMenuItem
            // 
            this.orderManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createOrderToolStripMenuItem,
            this.orderInformationToolStripMenuItem,
            this.ordersDetailedInformationToolStripMenuItem});
            this.orderManagementToolStripMenuItem.Name = "orderManagementToolStripMenuItem";
            this.orderManagementToolStripMenuItem.Size = new System.Drawing.Size(304, 48);
            this.orderManagementToolStripMenuItem.Text = "Order Management";
            // 
            // createOrderToolStripMenuItem
            // 
            this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
            this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(555, 54);
            this.createOrderToolStripMenuItem.Text = "Create Order";
            this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
            // 
            // orderInformationToolStripMenuItem
            // 
            this.orderInformationToolStripMenuItem.Name = "orderInformationToolStripMenuItem";
            this.orderInformationToolStripMenuItem.Size = new System.Drawing.Size(555, 54);
            this.orderInformationToolStripMenuItem.Text = "Order Information";
            this.orderInformationToolStripMenuItem.Click += new System.EventHandler(this.orderInformationToolStripMenuItem_Click);
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuToolStripMenuItem,
            this.extraMaterialsToolStripMenuItem});
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(331, 48);
            this.productManagementToolStripMenuItem.Text = "Product Management";
            // 
            // addMenuToolStripMenuItem
            // 
            this.addMenuToolStripMenuItem.Name = "addMenuToolStripMenuItem";
            this.addMenuToolStripMenuItem.Size = new System.Drawing.Size(376, 54);
            this.addMenuToolStripMenuItem.Text = "Add Menu";
            this.addMenuToolStripMenuItem.Click += new System.EventHandler(this.addMenuToolStripMenuItem_Click);
            // 
            // extraMaterialsToolStripMenuItem
            // 
            this.extraMaterialsToolStripMenuItem.Name = "extraMaterialsToolStripMenuItem";
            this.extraMaterialsToolStripMenuItem.Size = new System.Drawing.Size(376, 54);
            this.extraMaterialsToolStripMenuItem.Text = "Extra Materials";
            this.extraMaterialsToolStripMenuItem.Click += new System.EventHandler(this.extraMaterialsToolStripMenuItem_Click);
            // 
            // ordersDetailedInformationToolStripMenuItem
            // 
            this.ordersDetailedInformationToolStripMenuItem.Name = "ordersDetailedInformationToolStripMenuItem";
            this.ordersDetailedInformationToolStripMenuItem.Size = new System.Drawing.Size(555, 54);
            this.ordersDetailedInformationToolStripMenuItem.Text = "Orders Detailed Information";
            this.ordersDetailedInformationToolStripMenuItem.Click += new System.EventHandler(this.ordersDetailedInformationToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 748);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraMaterialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersDetailedInformationToolStripMenuItem;
    }
}