using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosFinal
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            lbl_JogosDigitais.Visible = false;
            lbl_EngenhariaSoftware.Visible = false;
        }

        private void ckb_SelecaoJogosDigitais_CheckedChanged(object sender, EventArgs e)
        {
            lbl_JogosDigitais.Visible = true;
            if (ckb_SelecaoJogosDigitais.Checked == true)
            {
                lbl_JogosDigitais.Text = "Você escolheu receber notificações sobre Jogos Digitais";
            } else
            {
                lbl_JogosDigitais.Text = "Você escolheu NÃO receber notificações sobre Jogos Digitais";
            }
        }

        private void ckb_EngSoftware_CheckedChanged(object sender, EventArgs e)
        {
            lbl_EngenhariaSoftware.Visible = true;
            if (ckb_EngSoftware.Checked == true)
            {
                lbl_EngenhariaSoftware.Text = "Você escolheu receber notificações sobre Engenharia de Software";
            }
            else
            {
                lbl_EngenhariaSoftware.Text = "Você escolheu NÃO receber notificações sobre Engenharia de Software";
            }
        }

        private void jogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_filho form2 = new Frm_filho("Será carregado o form 2!!!");
            form2.MdiParent = this;
            form2.Show();
        }

        private void limparSeleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ckb_EngSoftware.Checked = false;
            ckb_SelecaoJogosDigitais.Checked = false;
        }
    }
}
