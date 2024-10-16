using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Programa_De_Evento__Antônio_
{
    public partial class Cadastro_de_Clientes : Form
    {
        public Cadastro_de_Clientes()
        {
            InitializeComponent();
        }

        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancoGabe";
        public string strSQL = "";

        private void LimparDados()
        {
            cnpjj.Clear();
            noome.Clear();
            DNN.Clear();
            repree.Clear();
            telee.Clear();
            senha_txtbox.Clear();
        }

        private void entrar_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnpjj.Text.Trim().Length == 18)
                {
                    Conectar = new NpgsqlConnection(strCon);

                    Conectar.Open();

                    //Mondando a String (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "SELECT * FROM clientes WHERE (CNPJ =" + "'" + cnpjj.Text + "')";


                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);


                    LerRegistro = ComandoSQL.ExecuteReader();


                    if (LerRegistro.Read())
                    {
                        MessageBox.Show("Cliente jÃ¡ Existe!!!", "Sistema Informa");
                    }
                    else
                    {
                        //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;


                        strSQL = "INSERT INTO clientes " +
                                 "(cnpj, nome, telefone, representante, data de nascimento, senha ) " +
                                 "VALUES (" +
                                 "'" + cnpjj.Text + "'," +
                                 "'" + noome.Text + "'," +
                                 "'" + DNN.Text + "'," +
                                 "'" + repree.Text + "'," +
                                 "'" + telee.Text + "'," +
                                 "'" + senha_txtbox.Text + "')";

                        ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                        ComandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Registro Inserido com Sucesso...");


                        LimparDados();
                    }

                    LerRegistro.Close();
                    ComandoSQL.Dispose();
                    ComandoSQL.Transaction = null;


                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo CNPJ!!!");
                }


                cnpjj.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        
        

    }

        private void Limpar()
        {
            
        }

        private void Mskcnpjj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cadastro_de_Clientes_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Tela_Inicial().Show();
            Hide();
        }

        private void DNN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void repree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
