﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;

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
            Hide();
        }

        private void entrar_button_Click(object sender, EventArgs e)
        {
            if(usuario_textbox.Text == "admin" && senha_textbox.Text == "123")
            {
                MessageBox.Show("FOI!");
            }
            else
            {
                new MENUSTRIP_CLIENTE_().Show();
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cadastro_de_Clientes().Show();
            Hide();
        }

        private void usuario_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}