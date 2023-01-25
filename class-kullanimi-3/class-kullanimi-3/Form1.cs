using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_kullanimi_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            string ad, soyad, egitimdurumu, askerlikdurumu;
            ad = Convert.ToString(txtbox1.Text);
            soyad = Convert.ToString(txtbox2.Text);
            egitimdurumu = Convert.ToString(cmbbox1.Text);
            int yas = Convert.ToInt32(txtbox3.Text);
            bool yapildi, yapilmadi;
            yapildi = Convert.ToBoolean(radiobtn1.Checked);
            yapilmadi = Convert.ToBoolean(radiobtn2.Checked);
            if (radiobtn1.Checked == true)
            {
                 askerlikdurumu = "Askerlik Yapılmıştır.";
            }
            else
            {
                askerlikdurumu = "Askerlik Yapılmamıştır.";
            }
                kisibilgileri k = new kisibilgileri(ad, soyad, egitimdurumu, yas, askerlikdurumu);
                lblsonuc.Text = k.bilgileriyazdir().ToString();
        }
    }
}
class kisibilgileri
{
    string ad, soyad, egitimdurumu, askerlikdurumu;
    int yas;
    public kisibilgileri(string ad, string soyad, string egitimdurumu, int yas, string askerlikdurumu)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.egitimdurumu = egitimdurumu;
        this.yas = yas;
        this.askerlikdurumu = askerlikdurumu;
    }
    public string bilgileriyazdir()
    {
         string yazdir ="Adınız : " + ad +  "Soyadınız : " + soyad + "Yaşınız : " + yas + "Eğitim Durumu : " + egitimdurumu + "Askerlik : " + askerlikdurumu;
         return yazdir;
    }
}
