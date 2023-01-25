using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekmi_çiftmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            float sayi = Convert.ToSingle(txtsayi.Text);
            if (sayi % 2 == 0)
            {
                lblsonuc.Text = "Sayı Çifttir";
            }
            else
            {
                lblsonuc.Text = "Sayı Tektir";
            }
        }
    }
}
