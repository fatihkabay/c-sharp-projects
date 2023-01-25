using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double miktar, sayi;
            bool arttir, azalt;
            miktar = Convert.ToDouble(txtmiktar.Text);
            sayi = Convert.ToDouble(txtsayi.Text);
            arttir = radiobtn1.Checked;
            azalt = radiobtn2.Checked;
            if (arttir == true)
            {
                sayi += miktar;
            }
            else if (azalt == true)
            {
                sayi -= miktar;
            }
            txtsayi.Text = sayi.ToString();
            sayi = miktar;
        }
    }
}
