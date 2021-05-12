
namespace HamburgerShop
{
    partial class FrmOrderScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.flpExtraMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.btmSiparisTamamla = new System.Windows.Forms.Button();
            this.lbMenRev = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMenusRevenue = new System.Windows.Forms.Label();
            this.LstOrders = new System.Windows.Forms.ListBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.lbTotalRevenue = new System.Windows.Forms.Label();
            this.lbTotRev = new System.Windows.Forms.Label();
            this.lbExRev = new System.Windows.Forms.Label();
            this.lbExtrasRevenue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBuyuk);
            this.groupBox1.Controls.Add(this.rbOrta);
            this.groupBox1.Controls.Add(this.rbKucuk);
            this.groupBox1.Location = new System.Drawing.Point(160, 457);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(592, 116);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Size";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(309, 51);
            this.rbBuyuk.Margin = new System.Windows.Forms.Padding(5);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(125, 36);
            this.rbBuyuk.TabIndex = 6;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Large";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(174, 51);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(5);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(153, 36);
            this.rbOrta.TabIndex = 5;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Medium";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(11, 51);
            this.rbKucuk.Margin = new System.Windows.Forms.Padding(5);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(124, 36);
            this.rbKucuk.TabIndex = 4;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Small";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // flpExtraMalzemeler
            // 
            this.flpExtraMalzemeler.Location = new System.Drawing.Point(160, 640);
            this.flpExtraMalzemeler.Margin = new System.Windows.Forms.Padding(5);
            this.flpExtraMalzemeler.Name = "flpExtraMalzemeler";
            this.flpExtraMalzemeler.Size = new System.Drawing.Size(592, 212);
            this.flpExtraMalzemeler.TabIndex = 36;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(258, 877);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(5);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(494, 38);
            this.nmrAdet.TabIndex = 35;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btmSiparisTamamla
            // 
            this.btmSiparisTamamla.Location = new System.Drawing.Point(1597, 917);
            this.btmSiparisTamamla.Margin = new System.Windows.Forms.Padding(5);
            this.btmSiparisTamamla.Name = "btmSiparisTamamla";
            this.btmSiparisTamamla.Size = new System.Drawing.Size(430, 56);
            this.btmSiparisTamamla.TabIndex = 34;
            this.btmSiparisTamamla.Text = "Complete Order";
            this.btmSiparisTamamla.UseVisualStyleBackColor = true;
            this.btmSiparisTamamla.Click += new System.EventHandler(this.btmSiparisTamamla_Click);
            // 
            // lbMenRev
            // 
            this.lbMenRev.AutoSize = true;
            this.lbMenRev.Location = new System.Drawing.Point(1174, 908);
            this.lbMenRev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMenRev.Name = "lbMenRev";
            this.lbMenRev.Size = new System.Drawing.Size(71, 32);
            this.lbMenRev.TabIndex = 30;
            this.lbMenRev.Text = "0 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 604);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Extra Materials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 877);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Quantity :";
            // 
            // lbMenusRevenue
            // 
            this.lbMenusRevenue.AutoSize = true;
            this.lbMenusRevenue.Location = new System.Drawing.Point(797, 908);
            this.lbMenusRevenue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMenusRevenue.Name = "lbMenusRevenue";
            this.lbMenusRevenue.Size = new System.Drawing.Size(221, 32);
            this.lbMenusRevenue.TabIndex = 33;
            this.lbMenusRevenue.Text = "Menus Revenue";
            // 
            // LstOrders
            // 
            this.LstOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstOrders.FormattingEnabled = true;
            this.LstOrders.ItemHeight = 31;
            this.LstOrders.Location = new System.Drawing.Point(781, 90);
            this.LstOrders.Margin = new System.Windows.Forms.Padding(5);
            this.LstOrders.Name = "LstOrders";
            this.LstOrders.Size = new System.Drawing.Size(1236, 748);
            this.LstOrders.TabIndex = 29;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(153, 930);
            this.btnSiparisEkle.Margin = new System.Windows.Forms.Padding(5);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(599, 57);
            this.btnSiparisEkle.TabIndex = 28;
            this.btnSiparisEkle.Text = "Add Order";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click_1);
            // 
            // cbMenuler
            // 
            this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(153, 390);
            this.cbMenuler.Margin = new System.Windows.Forms.Padding(5);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(596, 39);
            this.cbMenuler.TabIndex = 27;
            this.cbMenuler.SelectedIndexChanged += new System.EventHandler(this.cbMenuler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select Manu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Items.AddRange(new object[] {
            "Fatih Kulac",
            "Canan Emrem",
            "Hasan Huseyin"});
            this.cbEmployees.Location = new System.Drawing.Point(1668, 12);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(349, 39);
            this.cbEmployees.TabIndex = 37;
            // 
            // lbTotalRevenue
            // 
            this.lbTotalRevenue.AutoSize = true;
            this.lbTotalRevenue.Location = new System.Drawing.Point(797, 862);
            this.lbTotalRevenue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTotalRevenue.Name = "lbTotalRevenue";
            this.lbTotalRevenue.Size = new System.Drawing.Size(200, 32);
            this.lbTotalRevenue.TabIndex = 33;
            this.lbTotalRevenue.Text = "Total Revenue";
            // 
            // lbTotRev
            // 
            this.lbTotRev.AutoSize = true;
            this.lbTotRev.Location = new System.Drawing.Point(1174, 862);
            this.lbTotRev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTotRev.Name = "lbTotRev";
            this.lbTotRev.Size = new System.Drawing.Size(71, 32);
            this.lbTotRev.TabIndex = 30;
            this.lbTotRev.Text = "0 TL";
            // 
            // lbExRev
            // 
            this.lbExRev.AutoSize = true;
            this.lbExRev.Location = new System.Drawing.Point(1174, 955);
            this.lbExRev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbExRev.Name = "lbExRev";
            this.lbExRev.Size = new System.Drawing.Size(71, 32);
            this.lbExRev.TabIndex = 38;
            this.lbExRev.Text = "0 TL";
            // 
            // lbExtrasRevenue
            // 
            this.lbExtrasRevenue.AutoSize = true;
            this.lbExtrasRevenue.Location = new System.Drawing.Point(797, 955);
            this.lbExtrasRevenue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbExtrasRevenue.Name = "lbExtrasRevenue";
            this.lbExtrasRevenue.Size = new System.Drawing.Size(216, 32);
            this.lbExtrasRevenue.TabIndex = 39;
            this.lbExtrasRevenue.Text = "Extras Revenue";
            // 
            // FrmOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2172, 1076);
            this.Controls.Add(this.lbExRev);
            this.Controls.Add(this.lbExtrasRevenue);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpExtraMalzemeler);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.btmSiparisTamamla);
            this.Controls.Add(this.lbTotRev);
            this.Controls.Add(this.lbMenRev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTotalRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMenusRevenue);
            this.Controls.Add(this.LstOrders);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmOrderScreen";
            this.Text = "FrmOrderScreen";
            this.Load += new System.EventHandler(this.FrmOrderScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzemeler;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Button btmSiparisTamamla;
        private System.Windows.Forms.Label lbMenRev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMenusRevenue;
        private System.Windows.Forms.ListBox LstOrders;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.Label lbTotalRevenue;
        private System.Windows.Forms.Label lbTotRev;
        private System.Windows.Forms.Label lbExRev;
        private System.Windows.Forms.Label lbExtrasRevenue;
    }
}