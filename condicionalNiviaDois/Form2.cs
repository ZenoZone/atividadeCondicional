using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace condicionalNiviaDois
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            double valor, i, j;

            valor = Convert.ToDouble(txtvalor.Text);
            i = 1;
            j = 1;

            while (i != 0)
            {
                i = valor - j;
                
                j++;
            }
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnfor_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
