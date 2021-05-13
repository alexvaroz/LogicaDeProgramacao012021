using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvinheSePuderV2
{
    public partial class Form1 : Form
    {
        bool numeroFoiSorteado = false;
        int numSorteado;
        int numeroTentativas;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            numSorteado = rnd.Next(0, 100);
            btnSortear.Enabled = false;
            btnTentar.Enabled = true;
            txtEntrada.Enabled = true;
            numeroTentativas = 3;
        }

        private void btnTentar_Click(object sender, EventArgs e)
        {
            int valorChute = int.Parse(txtEntrada.Text);
            lsbTentativas.Items.Add(valorChute);
            if (numSorteado == valorChute)
            {
                MessageBox.Show("Parabéns você acertou!!!!");
            }
            else
            {
                numeroTentativas--;
                MessageBox.Show("Você errou...");
            }
            VerificarNumeroTentativas();
            txtEntrada.Clear();
        }

        private void VerificarNumeroTentativas()
        {
            if (numeroTentativas == 0)
            {
                MessageBox.Show("Acabaram suas chances... Fim de jogo...");
                btnTentar.Enabled = false;
            }
        }
    }
}
