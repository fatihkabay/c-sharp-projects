using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace kollesiyonlar_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList Sehirler = new ArrayList();
        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            Sehirler.Add(textBox1.Text);
        }

        private void listelebtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Sehirler.Count; i++)
            {
                listBox1.Items.Add(Sehirler[i]);
            }
        }
    }
}
