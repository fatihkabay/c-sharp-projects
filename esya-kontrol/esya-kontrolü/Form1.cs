using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esya_kontrolü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yazdirbtn_Click(object sender, EventArgs e)
        {
            if (checkbx1.Checked == true)
            {
                listBox1.Items.Add("Lambalar Açık");
                listBox1.ForeColor = Color.Green;
            }
            else
            {
                listBox1.Items.Add("Lambalar Kapalı");
                listBox1.ForeColor = Color.Red;
            }
            if (checkbx2.Checked == true)
            {
                listBox1.Items.Add("Kombi Açık");
                listBox1.ForeColor = Color.Green;
            }
            else
            {
                listBox1.Items.Add("Kombi Kapalı");
                listBox1.ForeColor = Color.Red;
            }
        }
    }
}
