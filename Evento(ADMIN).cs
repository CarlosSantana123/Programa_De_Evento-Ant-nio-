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
    public partial class Evento_ADMIN_ : Form
    {
        public Evento_ADMIN_()
        {
            InitializeComponent();
        }

        //Declarar Classe de ConexÃ£o e suas variaveis publicas
        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=BANCO_TCC_ANTÔNIO";
        public string strSQL = "";

        public void LimparObjetos()
        {

            //Limpar Objetos do FormulÃ¡rio
            orcamentoAdmin_txtbox.Clear();
            localAdmin_txtbox.Clear();
            dataAdmin_txtbox.Clear();
            numAdmin_txtbox.Clear();
            tipo_eventoADMIN_txtbox.Clear();
            fornecedorAdmin_txtbox.Clear();
            nome_eventoAdmin_txtbox.Clear();
            horaAdmin_txtBox.Clear();
            atracaoAdmin_txtbox.Clear();

            return;

        }


        private void consultaAdmin_button_Click(object sender, EventArgs e)
        {
            //Consultar Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {
                if (nome_eventoAdmin_txtbox.Text.Trim().Length == 100)
                {
                    //Instanciar Objeto da Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Mondando a String (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "SELECT * FROM Eventos WHERE (Nome_evento =" + "'" + nome_eventoAdmin_txtbox.Text + "')";

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
                        orcamentoAdmin_txtbox.Text = LerRegistro.GetString(0);
                        localAdmin_txtbox.Text = LerRegistro.GetString(1);
                        dataAdmin_txtbox.Text = LerRegistro.GetDateTime(2).ToString("dd/MM/yyyy");
                        numAdmin_txtbox.Text = LerRegistro.GetString(3);
                        tipo_eventoADMIN_txtbox.Text = LerRegistro.GetString(4);
                        fornecedorAdmin_txtbox.Text = LerRegistro.GetString(5);
                        nome_eventoAdmin_txtbox.Text = LerRegistro.GetString(6);
                        horaAdmin_txtBox.Text = LerRegistro.GetString(7);
                        atracaoAdmin_txtbox.Text = LerRegistro.GetString(8);
                    }
                    else
                    {
                        MessageBox.Show("Nome " + nome_eventoAdmin_txtbox.Text + " NÃ£o Localizado!!!", "Sistema Informa");
                        nome_eventoAdmin_txtbox.Focus();
                    }

                    if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {

                        //Limpar Objetos do FormulÃ¡rio usando a funÃ§Ã£o
                        LimparObjetos();
                    }
                    else
                    {
                        //Habilitar (ativar) os botÃµes Alterar e Excluir, pois ao ler o formulario foram desabilitados
                        editarAdmin_button.Enabled = true;
                        deletarAdmin_button.Enabled = true;
                        //Desabilitar os botÃµes Inserir e Consultar
                        consultaAdmin_button.Enabled = false;
                        criarEventoAdmin_button.Enabled = false;
                        //Desabilitar o mkt_CPF, pois ele Ã© a informaÃ§Ã£o relativa a Chave Primaria
                        nome_eventoAdmin_txtbox.Enabled = false;
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
                nome_eventoAdmin_txtbox.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void criarEventoAdmin_button_Click(object sender, EventArgs e)
        {
            //Inserir Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {
                //Lembramos que estamos usando o Objeto para CPF (MaskTextBox),
                //quando usamos a propiedade Mask, invertemos o simbolo (,) por (.) e vice e versa
                //Analisando a consistencia (validaÃ§Ã£o) do Objeto "mkt_CNPJ",
                //onde nÃ£o pode ser menor que 18 caracteres (extraindo os espaÃ§os vazios)
                if (nome_eventoAdmin_txtbox.Text.Trim().Length == 100)
                {
                    //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Montando a variavel tipo String "strSQL" de Leitura de Dados (concatenando) com os objetos do FormulÃ¡rio
                    strSQL = "SELECT * FROM Eventos WHERE Nome_evento = '" + nome_eventoAdmin_txtbox + "'";

                    //MessageBox.Show(message, title, buttons)
                    //Mensagem para apresentar a String (strSQL)
                    MessageBox.Show(strSQL);

                    //Instanciando o Objeto de classe de Command (comando) para armazenar a InstruÃ§Ã£o / Clausulas SQL
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //Executando comando com resposta de Leitura de Registros (linha por Linha)
                    LerRegistro = ComandoSQL.ExecuteReader();

                    //Metodo Read(): Informe um "boolean" "True" (Existe Registro) e "False" (NÃ£o Existe Registro),
                    //Possibilita Ler o Proximo Regsitro de uma Tabela (Enquanto for True, Se existir registro)

                    if (LerRegistro.Read())
                    {
                        MessageBox.Show("Evento ja Existe!!!", "Sistema Informa");
                    }
                    else
                    {
                        //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;

                        //Podemos efetuar a validaÃ§Ã£o de todos os campos, antes de inserirmos o registro...
                        //Montando a variavel tipo String "strSQL" de InserÃ§Ã£o dos Dados (concatenando) com os objetos do FormulÃ¡rio 
                        strSQL = "INSERT INTO Eventos " +
                                 "(Orcamento, local, data_evento, n_pessoas, Tipo_evento, Fornecedor_representante, Nome_evento, hora, atracoes) " +
                                 "VALUES (" +
                                 "'" + orcamentoAdmin_txtbox.Text + "'," +
                                 "'" + localAdmin_txtbox.Text + "'," +
                                 "data_evento = TO_DATE ('" + dataAdmin_txtbox.Text + "', 'DD/MM/YYYY'), " +
                                 "'" + numAdmin_txtbox.Text + "'," +
                                 "'" + tipo_eventoADMIN_txtbox.Text + "'," +
                                 "'" + fornecedorAdmin_txtbox.Text + "'," +
                                 "'" + nome_eventoAdmin_txtbox.Text + "'," +
                                 "'" + horaAdmin_txtBox.Text + "'," +
                                 "'" + atracaoAdmin_txtbox.Text + "');";

                        //Mensagem para apresentar a String (strSQL)
                        MessageBox.Show(strSQL);

                        //Criar o Objeto com a classe de Command (comando) para armazenar a InstruÃ§Ã£o / Comando SQL
                        //comandoSQL jÃ¡ Ã© uma Classe NpgsqlCommand, portanto sÃ³ precisamos Instacia-lÃ¡
                        ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                        //Executando sem resposta
                        ComandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Registro Inserido com Sucesso...", "Sistema Informa");


                        //Limpar Objetos usando a funÃ§Ã£o 
                        LimparObjetos();
                    }

                    //Fechar ConexÃ£o
                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo Nome Do Evento!!!");
                }

                //Votar Cursor para o Objeto de Formulario
                nome_eventoAdmin_txtbox.Focus();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void orcamentoAdmin_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editarAdmin_button_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                Conectar = new NpgsqlConnection(strCon);

                //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                Conectar.Open();

                if (DialogResult.Yes == MessageBox.Show("Confirma AlteraÃ§Ã£o do Registro?", "Sistema Informa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2))
                {
                    //Mondando a String de Consulta (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "UPDATE Eventos SET " +
                                    "Orcamento = '" + orcamentoAdmin_txtbox.Text + "', " +
                                    "local = '" + localAdmin_txtbox.Text + "', " +
                                    "data_evento = TO_DATE('" + dataAdmin_txtbox.Text + "', 'DD/MM/YYYY', " +
                                    "n_pessoas = '" + numAdmin_txtbox.Text + "', " +
                                    "Tipo_evento = '" + tipo_eventoADMIN_txtbox.Text + "', " +
                                    "Fornecedor_representante = '" + fornecedorAdmin_txtbox.Text + "', " +
                                    "Nome_evento = '" + nome_eventoAdmin_txtbox.Text + "', " +
                                    "hora = '" + horaAdmin_txtBox.Text + "', " +
                                    "atracoes = '" + atracaoAdmin_txtbox + "', " +
                                    "WHERE (Nome_evento = '" + nome_eventoAdmin_txtbox.Text + "')";

                    //Mensagem para apresentar a String (strSQL)
                    MessageBox.Show(strSQL);

                    //comandoSQL jÃ¡ Ã© uma Classe OleDbCommand, portanto sÃ³ precisamos Instacia-lÃ¡
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //Executando sem resposta
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro Alterado com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("OperaÃ§Ã£o Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar FormulÃ¡rio (Dados)...", "Sistema Informa");

                //Limpar Objetos do FormulÃ¡rio
                LimparObjetos();

                //Desabilitar (desativar) os botÃµes Alterar e Excluir
                editarAdmin_button.Enabled = false;
                deletarAdmin_button.Enabled = false;
                //Habilitar os botÃµes Inserir e Consultar
                consultaAdmin_button.Enabled = true;
                criarEventoAdmin_button.Enabled = true;
                //Habilitar o mkt_CPF
                nome_eventoAdmin_txtbox.Enabled = true;

                //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                //Fechar ConexÃ£o
                Conectar.Close();

                //Votar Cursor para o Objeto de Formulario
                nome_eventoAdmin_txtbox.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void deletarAdmin_button_Click(object sender, EventArgs e)
        {
            //Excluir Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {

                //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                Conectar = new NpgsqlConnection(strCon);

                //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                Conectar.Open();


                //ConsistÃªncia para ExclusÃ£o 
                if (DialogResult.Yes == MessageBox.Show("Excluir Registro?", "Sistema Informa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2))
                {
                    //Mondando a String de Consulta (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "DELETE FROM clientes WHERE(Nome_evento = '" + nome_eventoAdmin_txtbox.Text + "')";
                    MessageBox.Show(strSQL);

                    //comandoSQL jÃ¡ Ã© uma Classe NpgsqlCommand, portanto sÃ³ precisamos Instacia-lÃ¡
                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    //Executando sem resposta
                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro ExcluÃ­do com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("OperaÃ§Ã£o Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar FormulÃ¡rio (Dados)...", "Sistema Informa");

                //Limpar Objetos do FormulÃ¡rio
                LimparObjetos();

                //Desabilitar (desativar) os botÃµes Alterar e Excluir
                editarAdmin_button.Enabled = false;
                deletarAdmin_button.Enabled = false;
                //Habilitar os botÃµes Inserir e Consultar
                consultaAdmin_button.Enabled = true;
                criarEventoAdmin_button.Enabled = true;
                //Habilitar o mkt_CPF
                nome_eventoAdmin_txtbox.Enabled = true;

                //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                //Fechar ConexÃ£o
                Conectar.Close();

                //Votar Cursor para o Objeto de Formulario
                nome_eventoAdmin_txtbox.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
