using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimli_fiyatlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int fiyat;
            double indirimlifiyat;
            fiyat = Convert.ToInt32(txtfiyat.Text);
            indirimlifiyat = fiyat - fiyat * 0.10;
            lblsonuc.Text = "İndrimli Fiyatı : " + indirimlifiyat.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int fiyat;
            double indirimlifiyat;
            fiyat = Convert.ToInt32(txtfiyat.Text);
            indirimlifiyat = fiyat - fiyat * 0.25;
            lblsonuc.Text = "İndrimli Fiyatı : " + indirimlifiyat.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int fiyat;
            double indirimlifiyat;
            fiyat = Convert.ToInt32(txtfiyat.Text);
            indirimlifiyat = fiyat - fiyat * 0.50;
            lblsonuc.Text = "İndrimli Fiyatı : " + indirimlifiyat.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int fiyat;
            double indirimlifiyat;
            fiyat = Convert.ToInt32(txtfiyat.Text);
            indirimlifiyat = fiyat - fiyat * 0.75;
            lblsonuc.Text = "İndrimli Fiyatı : " + indirimlifiyat.ToString();
        }
    }
}
