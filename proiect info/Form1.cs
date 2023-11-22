using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Form2 p2 = new Form2();
            this.Hide();
           p2.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 p3 = new Form3();
            this.Hide();
            p3.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form4 p4 = new Form4();
            this.Hide();
            p4.ShowDialog();
            this.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form5 p5 = new Form5();
            this.Hide();
            p5.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form6 p6 = new Form6();
            this.Hide();
            p6.ShowDialog();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form7 p7 = new Form7();
            this.Hide();
            p7.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form p8 = new Form8();
            this.Hide();
            p8.ShowDialog();
            this.Show();
        }
    }
}
