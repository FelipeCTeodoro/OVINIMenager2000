using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OVINIMenager2000
{
    public partial class Painel : Form
    {
        //Objetos Globais:
        BibliotecaOVNI.OVNI ovni;
        public Painel(BibliotecaOVNI.OVNI ovni)
        {
            InitializeComponent();
            this.ovni= ovni;
            AtualizarDados();
            cmbPlanetas.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        // Método para Atualizar os Dados:

        public void AtualizarDados()
        {
            lblAbduzidos.Text = "Abduzidos: " + ovni.QtdAbduzidos;
            lblTripulantes.Text = "Tripulantes; " + ovni.QtdTripulantes;
            lblSituacao.Text = "Situação: " + (ovni.Situacao ? "Ligado" : "Desligado");
            lblPlaneta.Text = "Planeta: " + ovni.PlanetaAtual;

            // Ativar os botões de acordo com o estado da nave:

            btnLigar.Enabled = ! ovni.Situacao;
              
            btnDesligar.Enabled  = ovni.Situacao;
            btnAddTripulante.Enabled = ovni.Situacao;
            btnRemoverTripulante.Enabled = ovni.Situacao;
            btnAbduzir.Enabled = ovni.Situacao;
            btnDezabduzir.Enabled = ovni.Situacao;
            btnRetornarAoOrigem.Enabled = ovni.Situacao;
            cmbPlanetas.Enabled = ovni.Situacao;
            btnMudar.Enabled = ovni.Situacao;



        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void btnAddTripulante_Click(object sender, EventArgs e)
        {
            if(ovni.AdicionarTripulante() == false)
            {
                MessageBox.Show(" Limite máximo de Tripulantes Atingido! ");
            }
            AtualizarDados();
        }



        private void btnLigar_Click(object sender, EventArgs e)
        {
            if(ovni.Ligar()==false)
            {
                MessageBox.Show("A Nave já Está Ligada!");
            }
            AtualizarDados();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar() == false)
            {
                MessageBox.Show("A Nave já Está Desligada!");
            }
            AtualizarDados();
        }

        private void btnRemoverTripulante_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante() == false)
            {
                MessageBox.Show(" Limite máximo de Tripulantes Removidos! ");
            }
            AtualizarDados();
        }

        private void btnAbduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir() == false)
            {
                MessageBox.Show(" Limite máximo de Abduzidos Atingido! ");
            }
            AtualizarDados();
        }

        private void btnDezabduzir_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir() == false)
            {
                MessageBox.Show(" Limite máximo de Dezabduzidos Atingido! ");
            }
            AtualizarDados();
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            if(ovni.MudarPlaneta(cmbPlanetas.Text) == false )
            {
                MessageBox.Show("Impossível Mudar para o Mesmo Planeta! ");
            }
            AtualizarDados();
        }

        private void btnRetornarAoOrigem_Click(object sender, EventArgs e)
        {
            if(ovni.RetornarAoPlanetaDeOrigem() == false )
            {
                MessageBox.Show("Impossível Mudar para o Mesmo Planeta! ");
            }
            AtualizarDados();
        }
    }
}
