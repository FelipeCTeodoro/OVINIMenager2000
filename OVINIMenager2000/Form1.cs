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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Inicializar o outro Form:

            Inicializador janela = new Inicializador();

            // Mostrar janela:

            janela.ShowDialog();

            // Fechar o Programa Todo:

            Application.Exit();
        }
    }
}
