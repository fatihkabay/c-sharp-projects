using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kazanan_belirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(txtsayi1.Text);
            sayi2 = Convert.ToInt32(txtsayi2.Text);
            if (sayi1 > sayi2)
            {
                lblsonuc.Text = "1. Takım Kazandı";
                ForeColor = Color.Blue;
            }
            else if (sayi1 < sayi2)
            {
                lblsonuc.Text = "2. Takım Kazandı";
                lblsonuc.ForeColor = Color.Blue;
            }
            else
            {
                lblsonuc.Text = "Hata Oluştu";
                lblsonuc.ForeColor = Color.Red;
            }
        }
    }
}
