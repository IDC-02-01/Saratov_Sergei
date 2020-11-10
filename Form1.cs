using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazinciks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Magazin m = new Magazin();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tovar t = new Tovar();
            t.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Postavhik p = new Postavhik();
            p.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adress adr = new Adress();
            adr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Skald s = new Skald();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nakladnaya nk = new Nakladnaya();
            nk.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Otchet o = new Otchet();
            o.ShowDialog();
        }
    }
}
