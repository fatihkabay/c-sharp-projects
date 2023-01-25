using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_kullanimi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2;
            sayi1 = Convert.ToSingle(txtbox1.Text);
            sayi2 = Convert.ToSingle(txtbox2.Text);
            sayibulucu sb = new sayibulucu();
            lblsonuc.Text = "Büyük Olan Sayı : " + sb.buyuksayiyibul(sayi1, sayi2).ToString();

        }
    }
}
class sayibulucu
{
     float sonuc;
    public float buyuksayiyibul(float sayi1, float sayi2)
    {
        float sonuc;
        if (sayi1 > sayi2)
        {
            sonuc = sayi1;
        }
        else
        {
            sonuc = sayi2;
        }
        return sonuc;
    }

}
