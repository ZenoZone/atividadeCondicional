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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double idade, salario, abono, result;
            string nome, sexo;

            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtsalario.Text);
            nome = Convert.ToString(txtnome.Text);
            sexo = Convert.ToString(txtsexo.Text);
  

            if (sexo == "Masculino" && idade >= 30)
            {
                txtapnome.Text = nome;
                abono = 100;
                result = salario + abono;
                txtresultado.Text = result.ToString();
                txtabono.Text = abono.ToString();
            }
            else if (sexo == "Masculino" && idade < 30)
            {
                txtapnome.Text = nome;
                abono = 80;
                result = salario + abono;
                txtresultado.Text = result.ToString();
                txtabono.Text = abono.ToString();
            }
            else if (sexo == "Feminino" && idade >= 30)
            {
                txtapnome.Text = nome;
                abono = 200;
                result = salario + abono;
                txtresultado.Text = result.ToString();
                txtabono.Text = abono.ToString();
            }
            else if (sexo == "Feminino" && idade < 30)
            {
                txtapnome.Text = nome;
                abono = 50;
                result = salario + abono;
                txtresultado.Text = result.ToString();
                txtabono.Text = abono.ToString();
            }
            
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtapnome.Clear();
            txtidade.Clear();  
            txtresultado.Clear();
            txtnome.Clear();
            txtsalario.Clear();
            txtsexo.Clear();
            txtnome.Focus();
        }
    }
}
