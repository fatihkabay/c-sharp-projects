using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_uygulamasi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            int notlar = int.Parse(textBox2.Text);
            listBox1.Items.Add("Ad Soyad : " + adsoyad + "=>" + " Notlar : " + notlar);
        }
        int[] notlar = new int[5];
        private void Eny_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length;i++)
            {
                if(notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i]; 
                }
            }
            label3.Text = enyuksek.ToString();
        }

        private void End_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < endusuk)
                {
                    endusuk = notlar[i];
                }
            }
            label4.Text = endusuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            label5.Text = ortalama.ToString();
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
