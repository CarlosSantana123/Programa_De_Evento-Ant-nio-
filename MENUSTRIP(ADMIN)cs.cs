using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_De_Evento__Antônio_
{
    public partial class MENUSTRIP_ADMIN_ : Form
    {
        public MENUSTRIP_ADMIN_()
        {
            InitializeComponent();
        }

        private void gerenciarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Evento_ADMIN_().Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Fornecedores_USUÁRIO().Show();
        }

        private void clientesUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consul().Show();
        }

        private void TelaInicio_button_Click(object sender, EventArgs e)
        {
            new Tela_Inicial().Show();
            Hide();
        }
    }
}
