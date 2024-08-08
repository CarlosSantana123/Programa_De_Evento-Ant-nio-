using Npgsql;
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

        private void entrar_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (cpff.Text.Trim().Length == 14)
                {
                    
                    Conectar = new NpgsqlConnection(strCon);

                    Conectar.Open();

                 
                    strSQL = "SELECT * FROM Clientes WHERE (CPF =" + "'" + cpff.Text + "')";
   
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);


                    LerRegistro = ComandoSQL.ExecuteReader();


                    if (LerRegistro.Read())
                    {
                        MessageBox.Show("Usuário Invalido");
                    }
                    else
                    {
        
                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;
 
                        strSQL = "INSERT INTO clientes " +
                                 "(cpf, nome, telefone, email,dn) " +
                                 "VALUES (" +
                                 "'" + cpff.Text + "'," +
                                 "'" + noome.Text + "'," +
                                 "'" + telee.Text + "'," +
                                 "'" + repree.Text + "'," +
                                 "TO_DATE ('" + DNN.Text + "', 'DD/MM/YYYY'));";

                      
                        ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                        ComandoSQL.ExecuteNonQuery();                    
                  
                        Limpar();
                    }

                    LerRegistro.Close();
                    ComandoSQL.Dispose();
                    ComandoSQL.Transaction = null;

                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencha corretamente e tente novamente");
                }

                cpff.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Limpar()
        {
            noome.Clear();
            cnpjj.Clear();
            cpff.Clear();
            telee.Clear();
            repree.Clear();
            DNN.Clear();

            return;
        }

        private void Mskcnpjj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cadastro_de_Clientes_Load(object sender, EventArgs e)
        {
            criar_btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Tela_Inicial().Show();
            Hide();
        }
    }
}
