using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExperimentosComForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "1";
            btnNum2.Text = "1";
            btnNum3.Text = "1";
            btnNum4.Text = "1";
            btnNum5.Text = "1";
            btnNum6.Text = "1";
            lblNome.Text = "Você clicou na tecla 1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "2";
            btnNum2.Text = "2";
            btnNum3.Text = "2";
            btnNum4.Text = "2";
            btnNum5.Text = "2";
            btnNum6.Text = "2";
            lblNome.Text = "Você clicou na tecla 2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "3";
            btnNum2.Text = "3";
            btnNum3.Text = "3";
            btnNum4.Text = "3";
            btnNum5.Text = "3";
            btnNum6.Text = "3";
            lblNome.Text = "Você clicou na tecla 3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "4";
            btnNum2.Text = "4";
            btnNum3.Text = "4";
            btnNum4.Text = "4";
            btnNum5.Text = "4";
            btnNum6.Text = "4";
            lblNome.Text = "Você clicou na tecla 4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "5";
            btnNum2.Text = "5";
            btnNum3.Text = "5";
            btnNum4.Text = "5";
            btnNum5.Text = "5";
            btnNum6.Text = "5";
            lblNome.Text = "Você clicou na tecla 5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "6";
            btnNum2.Text = "6";
            btnNum3.Text = "6";
            btnNum4.Text = "6";
            btnNum5.Text = "6";
            btnNum6.Text = "6";
            lblNome.Text = "Você clicou na tecla 6";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnNum1.Text = "1";
            btnNum2.Text = "2";
            btnNum3.Text = "3";
            btnNum4.Text = "4";
            btnNum5.Text = "5";
            btnNum6.Text = "6";
            lblNome.Text = "Você clicou na tecla Reset";
        }
    }
}
