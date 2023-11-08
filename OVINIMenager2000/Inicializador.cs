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
    public partial class Inicializador : Form
    {
        public Inicializador()
        {
            InitializeComponent();
        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            cmbPlanetaOrigem.DataSource = BibliotecaOVNI.OVNI.PlanetasValidos;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Obter as Informações no Forms:

            int MaxTripulantes = (int)nudMaxTripulantes.Value;
            int MaxAbduzidos = (int)nudMaxAbduzido.Value;
            string PlanetaOrigem = cmbPlanetaOrigem.Text;

            // Iniciar o OVNI:
            BibliotecaOVNI.OVNI ovni = new BibliotecaOVNI.OVNI(MaxTripulantes, MaxAbduzidos, PlanetaOrigem);

            // Instanciar a Janela do Painel:

            Painel janela = new Painel(ovni);

            // Abrir a Janela:

            janela.ShowDialog();
        }
    }
}
