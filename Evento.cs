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
    public partial class Evento : Form
    {
        public Evento()
        {
            InitializeComponent();
        }

        //Declarar Classe de ConexÃ£o e suas variaveis publicas
        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancox";
        public string strSQL = "";

        public void LimparObjetos()
        {

            //Limpar Objetos do FormulÃ¡rio
            orcamento_txtbox.Clear();
            local_txtbox.Clear();
            data_txtbox.Clear();
            numeroPessoas_txtbox.Clear();
            tipoEventoCLIENTE_txtbox.Clear();
            fornecedor_txtbox.Clear();
            nomeEvento_txtbox.Clear();
            hora_txtbox.Clear();
            Atracao_txtbox.Clear();

            return;

        }

        private void criarEvento_button_Click(object sender, EventArgs e)
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
                if (nomeEvento_txtbox.Text.Trim().Length == 100)
                {
                    //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Montando a variavel tipo String "strSQL" de Leitura de Dados (concatenando) com os objetos do FormulÃ¡rio
                    strSQL = "SELECT * FROM Eventos WHERE Nome_evento = '" + nomeEvento_txtbox.Text + "'";

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
                                 "'" + orcamento_txtbox.Text + "'," +
                                 "'" + local_txtbox.Text + "'," +
                                 "data_evento = TO_DATE ('" + data_txtbox.Text + "', 'DD/MM/YYYY'), " +
                                 "'" + numeroPessoas_txtbox.Text + "'," +
                                 "'" + tipoEventoCLIENTE_txtbox.Text + "'," +
                                 "'" + fornecedor_txtbox.Text + "'," +
                                 "'" + nomeEvento_txtbox.Text + "'," +
                                 "'" + hora_txtbox.Text + "'," +
                                 "'" + Atracao_txtbox.Text + "');";

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
                    MessageBox.Show("Preencher corretamente pelo menos o campo CNPJ!!!");
                }

                //Votar Cursor para o Objeto de Formulario
                nomeEvento_txtbox.Focus();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
