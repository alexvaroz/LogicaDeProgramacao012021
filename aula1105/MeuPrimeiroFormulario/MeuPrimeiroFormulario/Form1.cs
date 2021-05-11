using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnConfirmar.Text = rnd.Next(0, 100).ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá mundo!!! Por que você quer cancelar??");
        }
    }
}
