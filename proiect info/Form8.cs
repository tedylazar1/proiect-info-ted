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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked && checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                    MessageBox.Show("Felicitari! Ai raspuns corect!");
            else
                    MessageBox.Show("Vai si amar, mai incearca!");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
