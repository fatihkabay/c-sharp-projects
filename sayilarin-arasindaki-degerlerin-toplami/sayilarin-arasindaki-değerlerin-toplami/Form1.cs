using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayilarin_arasindaki_değerlerin_toplami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            toplam = 0;
            for (int x = sayi1; x <= sayi2; x++) 
            {
                toplam = toplam + x;
                lblsonuc.Text = ("Sayıların Toplamı : " + toplam.ToString());
            }
        }
    }
}
