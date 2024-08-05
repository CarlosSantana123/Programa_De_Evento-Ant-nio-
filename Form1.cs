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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Tela_Ajuda().Show();
        }

        private void entrar_button_Click(object sender, EventArgs e)
        {
            if(usuario_textbox.Text == "admin" && senha_textbox.Text == "123")
            {
                MessageBox.Show("FOI!");
            }
            else
            {
                MessageBox.Show("Erro! Usuário/Senha incorretos");
            }
        }
    }
}
