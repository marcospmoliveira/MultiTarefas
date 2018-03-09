using System;
using System.Windows.Forms;

namespace MultiTarefas
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcularFe_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            String resultado = "";

            try
            {
                peso = double.Parse(txtPeso.Text);
                altura = double.Parse(txtAltura.Text);
                
                if (peso < 5 || peso > 300 || altura < 0.5 || altura > 2.50)
                {
                    MessageBox.Show("Dados Inválidos, certifique-se de usar virgula para separar as medidas!", "Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPeso.Text = "";
                    txtAltura.Text = "";
                    txtResultado.Text = "";
                }
                else
                {
                    imc = (peso / (altura * altura));
                    imc = Math.Round(imc, 2);

                    if (imc < 16)
                    {
                        resultado = "Magreza grave";
                    }
                    if (imc >= 16 && imc < 17)
                    {
                        resultado = "Magreza moderada";
                    }
                    if (imc >= 17 && imc < 18.5)
                    {
                        resultado = "Magreza leve";
                    }
                    if (imc >= 18.5 && imc < 25)
                    {
                        resultado = "Saudável";
                    }
                    if (imc >= 25 && imc < 30)
                    {
                        resultado = "Sobrepeso";
                    }
                    if (imc >= 30 && imc < 35)
                    {
                        resultado = "Obesidade Grau I";
                    }
                    if (imc >= 35 && imc < 40)
                    {
                        resultado = "Obesidade Grau II";
                    }
                    if (imc >= 40)
                    {
                        resultado = "Obesidade Grau III";
                    }

                    txtResultado.Text = ("Seu IMC: " + Convert.ToString(imc)+ " Status " + resultado);
                }
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtResultado.Clear();
            txtPeso.Focus();
        }
    }
}
