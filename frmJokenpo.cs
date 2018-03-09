using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTarefas
{
    public partial class frmJokenpo : Form
    {
        enum Opcoes {Pedra, Papel, Tesoura};
        enum Resultado {Jogador, Cpu, Empate};
        Opcoes jogador = new Opcoes();
        Opcoes cpu = new Opcoes();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();

        public frmJokenpo()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Pedra;
            EscolhaJogador();
            EscolhaCpu();
            VerficarGanhador();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Papel;
            EscolhaJogador();
            EscolhaCpu();
            VerficarGanhador();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Tesoura;
            EscolhaJogador();
            EscolhaCpu();
            VerficarGanhador();
        }

        void EscolhaJogador()
        {
            switch (jogador)
            {
                case Opcoes.Pedra:
                    pbJogador.BackgroundImage = Image.FromFile("C:/Users/marco/Documents/PROGRAMAÇÃO/C#/MultiTarefas/imagens/pedra_jogador.png");
                    break;
                case Opcoes.Papel:
                    pbJogador.BackgroundImage = Image.FromFile("C:/Users/marco/Documents/PROGRAMAÇÃO/C#/MultiTarefas/imagens/papel_jogador.png");
                    break;
                case Opcoes.Tesoura:
                    pbJogador.BackgroundImage = Image.FromFile("C:/Users/marco/Documents/PROGRAMAÇÃO/C#/MultiTarefas/imagens/tesoura_jogador.png");
                    break;
            }
        }

        void EscolhaCpu()
        {
            int numero = rdm.Next(1, 4);

            if (numero == 1)
            {
                cpu = Opcoes.Pedra;
                pbCpu.BackgroundImage = Image.FromFile("C:/Users/marco/Documents/PROGRAMAÇÃO/C#/MultiTarefas/imagens/pedra_jogador.png");
            }
            else if (numero == 2)
            {
                cpu = Opcoes.Papel;
                pbCpu.BackgroundImage = Image.FromFile("C:/Users/marco/Documents/PROGRAMAÇÃO/C#/MultiTarefas/imagens/papel_jogador.png");
            }
            else if (numero == 3)
            {
                cpu = Opcoes.Tesoura;
                pbCpu.BackgroundImage = Image.FromFile("C:/Users/marco/Documents/PROGRAMAÇÃO/C#/MultiTarefas/imagens/tesoura_jogador.png");
            }
        }

        void VerficarGanhador()
        {
            switch (jogador)
            {
                case Opcoes.Pedra:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Cpu;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                case Opcoes.Papel:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Cpu;
                    break;

                case Opcoes.Tesoura:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Cpu;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }

            if (ganhador == Resultado.Jogador)
            {
                groupBox3.BackColor = Color.Green;
                lblJogador.Text = (int.Parse(lblJogador.Text) + 1).ToString();
            }
            else if(ganhador == Resultado.Cpu)
            {
                groupBox3.BackColor = Color.Red;
                lblCpu.Text = (int.Parse(lblCpu.Text) + 1).ToString();
            }
            else
            {
                groupBox3.BackColor = Color.WhiteSmoke;
            }

        }
    }
}
