using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace Programa_De_Evento__Antônio_
{
    public partial class consultaClientesEventos : Form
    {
        public consultaClientesEventos()
        {
            InitializeComponent();
        }

        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancox";
        public string strSQL = "";

        public void LimparObjetos()
        {

            //Limpar Objetos do FormulÃ¡rio
            cpf_ADMIN_txtbox.Clear();
            nome_ADMIN_txtbox.Clear();
            telefone_ADMIN_txtbox.Clear();
            representante_ADMIN_txtbox.Clear();
            data_ADMIN_txtbox.Clear();
            senha_txtbox.Clear();

            return;

        }

        private void consultarCONSULCLIENTES_button_Click(object sender, EventArgs e)
        {
            //Consultar Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {
                if (nomeEventoCONSULCLIENTES_txtbox.Text.Trim().Length == 100)
                {
                    //Instanciar Objeto da Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Mondando a String (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "SELECT * FROM Eventos WHERE (Nome_Evento =" + "'" + nomeEventoCONSULCLIENTES_txtbox.Text + "')";

                    //Mensagem para apresentar a String (strSQL)
                    MessageBox.Show(strSQL);

                    //Instanciando o Objeto da classe de Command (comando) para armazenar a InstruÃ§Ã£o / Clausulas SQL
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //OleDbDataReader rs = new OleDbDataReader(comandoSQL); 
                    //Executando sem resposta
                    //comandoSQL.ExecuteNonQuery();

                    LerRegistro = ComandoSQL.ExecuteReader();

                    //Metodo Read(): Informe um "boolean" "True" (exite Registro) e "False" (NÃ£o Existe Registro),
                    //Possibilita Ler o Proximo Regsitro de uma Tabela (Enquanto for True, Se existir registro)

                    if (LerRegistro.Read())
                    {
                        //Populando Objetos do Form com Dados do Registro (lerRegistro)
                        orcamentoCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(0);
                        localCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(1);
                        dataCONSULCLIENTES_txtbox.Text = LerRegistro.GetDateTime(2).ToString("dd/MM/yyyy");
                        numeroPessoasCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(3);
                        fornecedorCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(4);
                        nomeEventoCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(5);
                        horaCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(6);
                        AtracaoCONSULCLIENTES_txtbox.Text = LerRegistro.GetString(7);
                    }
                    else
                    {
                        MessageBox.Show("Nome_Evento " + nomeEventoCONSULCLIENTES_txtbox.Text + " NÃ£o Localizado!!!", "Sistema Informa");
                        orcamentoCONSULCLIENTES_txtbox.Focus();
                    }

                    if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {

                        //Limpar Objetos do FormulÃ¡rio usando a funÃ§Ã£o
                        LimparObjetos();
                    }
                    else
                    {
               
                    }


                    //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                    LerRegistro.Close();
                    ComandoSQL.Dispose();
                    ComandoSQL.Transaction = null;

                    //Fechar ConexÃ£o
                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo CPF!!!");
                }

                //Votar Cursor para o Objeto de Formulario
                orcamentoCONSULCLIENTES_txtbox.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
