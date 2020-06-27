using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gram;
            if(Funt.Checked)
            {
                gram = int.Parse(tBox1.Text);
                double funt = gram * 454;
                tBox2.Text = funt.ToString();
            }
            if (Pud.Checked)
            {
                gram = int.Parse(tBox1.Text);
                double pud = gram * 16380;
                tBox2.Text = pud.ToString();
            }
            if (Unc.Checked)
            {
                gram = int.Parse(tBox1.Text);
                double unc = gram * 28.35;
                tBox2.Text = unc.ToString();
            }
            if (Drhm.Checked)
            {
                gram = int.Parse(tBox1.Text);
                double drahm = gram * 1.772;
                tBox2.Text = drahm.ToString();
            }
            if (Gran.Checked)
            {
                gram = int.Parse(tBox1.Text);
                double grn = gram * 0.0648;
                tBox2.Text = grn.ToString();
            }
        }

        private void tBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
