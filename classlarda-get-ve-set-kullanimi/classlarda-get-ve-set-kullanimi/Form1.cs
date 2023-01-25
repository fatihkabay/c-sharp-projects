using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classlarda_get_ve_set_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            musteri m = new musteri();
            string adsoyad = Convert.ToString(txtadsoyad.Text);
            long tcno = Convert.ToInt64(txttc.Text);
            int odano = Convert.ToInt32(txtoda.Text);
            m.adsoyad = adsoyad;
            m.tcno = tcno;
            m.odano = odano;
            MessageBox.Show("Ad Soyad : " + adsoyad + " Tc No : " + tcno + " Oda No : " + odano);
        }
    }
}
class musteri
{
    private string Adsoyad;
    private long Tcno;
    private int Odano;
    public string adsoyad
    {
        get 
        {
            return adsoyad;
        }
        set
        {
            Adsoyad = value;
        }
    }
    public long tcno
    {
        get
        {
            return Tcno;
        }
        set
        {
            if (value.ToString().Length == 11)
            {
                Tcno = value;
            }
            else
            {
                MessageBox.Show("Hata! TC numaranızı 11 haneden az veya fazla girdiniz.");
            }
        }
    }
    public int odano
    {
        get
        {
            return Odano;
        }
        set
        {
            if (value > 0 && value <= 120)
            {
                Odano = value;
            }
            else
            {
                MessageBox.Show("Hata! oda sayısı 1-120 arasındadır.");
            }
        }
    }
}
