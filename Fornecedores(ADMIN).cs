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
    public partial class Fornecedores_USUÁRIO : Form
    {
        public Fornecedores_USUÁRIO()
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
            cnpjFORN_txtbox.Clear();
            representanteFORN_txtbox.Clear();
            cepFORN_txtbox.Clear();
            emialFORN_txtbox.Clear();
            empresaFORN_txtbox.Clear();
            razaosocialFORN_txtbox.Clear();
        }

        private void btn_alterarFORN_Click(object sender, EventArgs e)
        {
            try
            {

                Conectar = new NpgsqlConnection(strCon);
                Conectar.Open();

                if (DialogResult.Yes == MessageBox.Show("Confirma Alteração do Registro?", "Sistema Informa",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2))
                {
                    strSQL = "UPDATE fornecedores SET " +
                                    "representante = '" + representanteFORN_txtbox.Text + "', " +
                                    "cep = '" + cepFORN_txtbox.Text + "', " +
                                    "telefone = '" + masktel.Text + "', " +
                                    "email = '" + emialFORN_txtbox.Text + "'," +
                                    "empresa = '" + empresaFORN_txtbox.Text + "'," +
                                    "razao_social = '" + razaosocialFORN_txtbox.Text + "' " +
                                    "WHERE (cnpj = '" + cnpjFORN_txtbox.Text + "')";

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro Alterado com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar Formulário (Dados)...", "Sistema Informa");

                LimparDados();

                btn_alterarFORN.Enabled = false;
                btn_excluirFORN.Enabled = false;
                btn_consulFORN.Enabled = true;
                btn_inserirFORN.Enabled = true;
                cnpjFORN_txtbox.Enabled = true;


                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                Conectar.Close();


                cnpjFORN_txtbox.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btn_inserirFORN_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnpjFORN_txtbox.Text.Trim().Length == 18)
                {
                    Conectar = new NpgsqlConnection(strCon);
                    Conectar.Open();

                    strSQL = "SELECT * FROM fornecedores WHERE (CNPJ =" + "'" + cnpjFORN_txtbox.Text + "')";


                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    LerRegistro = ComandoSQL.ExecuteReader();

                    if (LerRegistro.Read())
                    {
                        MessageBox.Show("Cliente jÃ¡ Existe!!!", "Sistema Informa");
                    }
                    else
                    {

                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;

                        strSQL = "INSERT INTO fornecedores " +
                                 "(cnpj, representante, cep, telefone, email, empresa, razao_social) " +
                                 "VALUES (" +
                                 "'" + cnpjFORN_txtbox.Text + "'," +
                                 "'" + cepFORN_txtbox.Text + "'," +
                                 "'" + masktel.Text + "'," +
                                 "'" + emialFORN_txtbox.Text + "'," +
                                 "'" + empresaFORN_txtbox.Text + "'," +
                                 "'" + razaosocialFORN_txtbox.Text + "')";

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
                    MessageBox.Show("Preencher corretamente pelo menos o campo CPF!!!");
                }


                cnpjFORN_txtbox.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_consulFORN_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnpjFORN_txtbox.Text.Trim().Length == 18)
                {
                    Conectar = new NpgsqlConnection(strCon);
                    Conectar.Open();
                    strSQL = "SELECT * FROM fornecedores WHERE (CNPJ =" + "'" + cnpjFORN_txtbox.Text + "')";

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    LerRegistro = ComandoSQL.ExecuteReader();

                    if (LerRegistro.Read())
                    {
                        cnpjFORN_txtbox.Text = LerRegistro.GetString(0);
                        cepFORN_txtbox.Text = LerRegistro.GetString(1);
                        masktel.Text = LerRegistro.GetString(2);
                        emialFORN_txtbox.Text = LerRegistro.GetString(3);
                        empresaFORN_txtbox.Text = LerRegistro.GetString(4);
                        razaosocialFORN_txtbox.Text = LerRegistro.GetString(5);
                    }
                    else
                    {
                        MessageBox.Show("CPF " + cnpjFORN_txtbox.Text + " NÃ£o Localizado!!!", "Sistema Informa");
                        cnpjFORN_txtbox.Focus();
                    }

                    if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {
                        LimparDados();
                    }
                    else
                    {
                        btn_alterarFORN.Enabled = true;
                        btn_excluirFORN.Enabled = true;
                        btn_consulFORN.Enabled = false;
                        btn_inserirFORN.Enabled = false;
                        cnpjFORN_txtbox.Enabled = false;
                    }

                    LerRegistro.Close();
                    ComandoSQL.Dispose();
                    ComandoSQL.Transaction = null;

                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo CPF!!!");
                }

                cnpjFORN_txtbox.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btn_excluirFORN_Click(object sender, EventArgs e)
        {
            try
            {

                Conectar = new NpgsqlConnection(strCon);

                Conectar.Open();

                if (DialogResult.Yes == MessageBox.Show("Excluir Registro?", "Sistema Informa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question,
                                                   MessageBoxDefaultButton.Button2))
                {
                    strSQL = "DELETE FROM Fornecedores WHERE(CNPJ = '" + cnpjFORN_txtbox.Text + "')";
                    MessageBox.Show(strSQL);

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro Excluí­do com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada!!!");
                }

                MessageBox.Show("Limpar Formulário (Dados)...");

                LimparDados();

                btn_alterarFORN.Enabled = false;
                btn_excluirFORN.Enabled = false;
                btn_consulFORN.Enabled = true;
                btn_inserirFORN.Enabled = true;
                cnpjFORN_txtbox.Enabled = true;

                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                Conectar.Close();

                cnpjFORN_txtbox.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_voltarFORN_Click(object sender, EventArgs e)
        {
            new Tela_Inicial().Show();
            Close();
        }
    }
}
    
    
    

