using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            double turkcedogru, matematikdogru, turkceyanlis, matematikyanlis, turkcenet, matematiknet;
            turkcedogru = Convert.ToDouble(txtturkcedogru.Text);
            turkceyanlis = Convert.ToDouble(txtturkceyanlis.Text);
            turkcenet = (turkcedogru - (turkceyanlis / 4)); 
            txtturkcenet.Text = turkcenet.ToString();
            matematikdogru = Convert.ToDouble(txtmatematikdogru.Text);
            matematikyanlis = Convert.ToDouble(txtmatematikyanlis.Text);
            matematiknet = matematiknet = (matematikdogru - (matematikyanlis / 4));
            txtmatematiknet.Text = matematiknet.ToString();

        }
    }
}
