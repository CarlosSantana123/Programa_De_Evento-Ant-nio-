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
    public partial class MENUSTRIP_CLIENTE_ : Form
    {
        public MENUSTRIP_CLIENTE_()
        {
            InitializeComponent();
        }

        private void criarEventoNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void criarEventoNovoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Evento().Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Tela_Ajuda().Show();
        }

        private void consultarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new consultaClientesEventos().Show();
        }

        private void TelaInicioCLIENTE_button_Click(object sender, EventArgs e)
        {
            new Tela_Inicial().Show();
            Hide();
        }
    }
}
