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
            double idade, salario, result;
            string nome, sexo;

            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtsalario.Text);
            nome = Convert.ToString(txtnome.Text);
            sexo = Convert.ToString(txtsexo.Text);

            if (sexo != "Masculino" || sexo != "Feminino")
            {
                txtnome.Clear();
                txtsexo.Clear();
                txtidade.Clear();
                txtsalario.Clear();
                txtapnome.Text = "Coloque apenas Masculino ou Feminino";
            }
            else if (sexo == "Masculino" && idade >= 30)
            {
                txtapnome.Text = nome;
                result = salario + 100;
            }
            else if (sexo == "Masculino" && idade < 30)
            {
                txtapnome.Text = nome;
                result = salario + 80;
            }
            else if (sexo == "Feminino" && idade >= 30)
            {
                txtapnome.Text = nome;
                result = salario + 200;
            }
            else if (sexo == "Feminino" && idade < 30)
            {
                txtapnome.Text = nome;
                result = salario + 50;
            }
            txtresultado.Text = result.ToString();
        }
    }
}
