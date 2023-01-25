using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            sayi s = new sayi();
            label1.Text = s.buyukolansayiyibul(a, b).ToString();
        }
    }
}
class sayi
{
    public int buyukolansayiyibul(int sayi1, int sayi2)
    {
        int sonuc;
        if (sayi1 < sayi2)
        {
            sonuc = sayi2; 
        }
        else
        {
            sonuc = sayi1;
        }
        return sonuc;
    }
}
