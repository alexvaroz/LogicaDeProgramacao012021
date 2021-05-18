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
    public partial class Frm_filho : Form
    {
        public Frm_filho()
        {
            InitializeComponent();
            label1.Text = "O formulário 2 foi carregado!!!";
        }

        public Frm_filho(string mensagem)
        {
            InitializeComponent();
            label1.Text = mensagem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
