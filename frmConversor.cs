using System;
using System.Windows.Forms;

namespace MultiTarefas
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEntCelsius.Text != string.Empty)
                {
                    double C, fahrenheit;
                    C = double.Parse(txtEntCelsius.Text);

                    if (C <= 100 && C >= -273)
                    {
                        fahrenheit = C * 1.8 + 32;
                        fahrenheit = Math.Round(fahrenheit);
                        txtEntFahrenheit.Text = Convert.ToString(fahrenheit);
                    }
                    else
                    {
                        MessageBox.Show("Valor Invalido!", "Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {

                    double F, celsius;
                    F = double.Parse(txtEntFahrenheit.Text);

                    if (F <= 212 && F >= -459)
                    {
                        celsius = (F - 32) / 1.8;
                        celsius = Math.Round(celsius);
                        txtEntCelsius.Text = Convert.ToString(celsius);
                    }
                    else
                    {
                        MessageBox.Show("Valor Invalido!", "Tente Novamente!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEntCelsius.Clear();
            txtEntFahrenheit.Clear();
        }
    }
}
