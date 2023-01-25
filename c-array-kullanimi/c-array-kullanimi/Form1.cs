using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_array_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kisiler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            kisiler[index] = textBox1.Text;
            notlar[index] = int.Parse(textBox2.Text);
            index++;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kisiler.Length; i++)
            {
                if (kisiler[i] != null)
                {
                    listBox1.Items.Add(kisiler[i] + "=>" + notlar[i]);
                }
            }
        }
    }
}

