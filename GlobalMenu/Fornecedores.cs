using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalMenu
{
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }

        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancox";
        public string strSQL = "";

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void brn_Voltar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {

        }

        private void brn_Voltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Excluir_Click_1(object sender, EventArgs e)
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
                    strSQL = "DELETE FROM fornecedores WHERE(cnpj = '" + mkt_CNPJ.Text + "')";
                    MessageBox.Show(strSQL);

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro Excluido com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("Operação Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar Formulario (Dados)...", "Sistema Informa");

                LimparObjetos();

                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Consultar.Enabled = true;
                btn_Inserir.Enabled = true;
                mkt_CNPJ.Enabled = true;

                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                Conectar.Close();

                mkt_CNPJ.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void btn_Alterar_Click_1(object sender, EventArgs e)
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
                                    "razaosocial = '" + txt_RazaoSocial.Text + "', " +
                                    "nomesocial = '" + txt_NomeFantasia.Text + "', " +
                                    "email = '" + txt_Email.Text + "', " +
                                    "telefone = '" + txt_Telefone.Text + "' " +
                                    "WHERE (cnpj = '" + mkt_CNPJ.Text + "')";

                    MessageBox.Show(strSQL);

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    ComandoSQL.ExecuteNonQuery();
                    MessageBox.Show("Registro Alterado com Sucesso...", "Sistema Informa");
                }
                else
                {
                    MessageBox.Show("Operacão Cancelada!!!", "Sistema Informa");
                }

                MessageBox.Show("Limpar Formulario (Dados)...", "Sistema Informa");

                LimparObjetos();

                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                btn_Consultar.Enabled = true;
                btn_Inserir.Enabled = true;
                mkt_CNPJ.Enabled = true;

                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                Conectar.Close();

                mkt_CNPJ.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Consultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (mkt_CNPJ.Text.Trim().Length == 18)
                {
                    Conectar = new NpgsqlConnection(strCon);

                    Conectar.Open();

                    strSQL = "SELECT * FROM fornecedores WHERE (CNPJ =" + "'" + mkt_CNPJ.Text + "')";

                    MessageBox.Show(strSQL);

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

               
                    LerRegistro = ComandoSQL.ExecuteReader();


                    if (LerRegistro.Read())
                    {
                        mkt_CNPJ.Text = LerRegistro.GetString(0);
                        txt_RazaoSocial.Text = LerRegistro.GetString(1);
                        txt_NomeFantasia.Text = LerRegistro.GetString(2);
                        txt_Email.Text = LerRegistro.GetString(3);
                        txt_Telefone.Text = LerRegistro.GetString(4);

                        if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                        {

                            LimparObjetos();
                        }
                        else
                        {
                            btn_Alterar.Enabled = true;
                            btn_Excluir.Enabled = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("CNPJ " + mkt_CNPJ.Text + " Não Localizado!!!", "Sistema Informa");
                        mkt_CNPJ.Focus();
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

                mkt_CNPJ.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Inserir_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (mkt_CNPJ.Text.Trim().Length == 18)
                {
                    Conectar = new NpgsqlConnection(strCon);


                    Conectar.Open();

                    strSQL = "SELECT * FROM fornecedores WHERE CNPJ = '" + mkt_CNPJ.Text + "'";

                    MessageBox.Show(strSQL);

                    ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                    LerRegistro = ComandoSQL.ExecuteReader();


                    if (LerRegistro.Read())
                    {
                        MessageBox.Show("Cliente já Existe!!!", "Sistema Informa");
                    }
                    else
                    {
                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;

                        strSQL = "INSERT INTO fornecedores " +
                                 "(cnpj, razaosocial, nomesocial, email, telefone) " +
                                 "VALUES (" +
                                 "'" + mkt_CNPJ.Text + "'," +
                                 "'" + txt_RazaoSocial.Text + "'," +
                                 "'" + txt_NomeFantasia.Text + "'," +
                                 "'" + txt_Email.Text + "'," +
                                 "'" + txt_Telefone.Text + "')";

                       

                        MessageBox.Show(strSQL);

                        ComandoSQL = new NpgsqlCommand(strSQL, Conectar);

                        ComandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Registro Inserido com Sucesso...", "Sistema Informa");


                        LimparObjetos();
                    }

                    Conectar.Close();

                }
                else
                {
                    MessageBox.Show("Preencher corretamente pelo menos o campo CNPJ!!!");
                }

                mkt_CNPJ.Focus();
            

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
}


        public void LimparObjetos()
        {

            mkt_CNPJ.Clear();
            txt_RazaoSocial.Clear();
            txt_NomeFantasia.Clear();
            txt_Email.Clear();
            txt_Telefone.Clear();

            return;

        }
        

        private void mkt_CNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
