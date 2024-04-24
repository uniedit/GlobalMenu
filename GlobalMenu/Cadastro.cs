﻿using System;
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


namespace GlobalMenu
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public NpgsqlConnection Conectar;
        public NpgsqlCommand ComandoSQL;
        public NpgsqlDataReader LerRegistro;
        public string strCon = "Server=localhost;Port=5432;Username=postgres;password=root;Database=bancox";
        public string strSQL = "";

        

        private void btn_Inserir_Click(object sender, EventArgs e)
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
                if (mkt_CPFF.Text.Trim().Length == 14)
                {
                    //Criar e Estanciar Objeto a Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Montando a variavel tipo String "strSQL" de Leitura de Dados (concatenando) com os objetos do FormulÃ¡rio
                    strSQL = "SELECT * FROM clientes WHERE CPF = '" + mkt_CPFF.Text + "'";

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
                        MessageBox.Show("Cliente jÃ¡ Existe!!!", "Sistema Informa");
                    }
                    else
                    {
                        //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                        LerRegistro.Close();
                        ComandoSQL.Dispose();
                        ComandoSQL.Transaction = null;

                        //Podemos efetuar a validaÃ§Ã£o de todos os campos, antes de inserirmos o registro...
                        //Montando a variavel tipo String "strSQL" de InserÃ§Ã£o dos Dados (concatenando) com os objetos do FormulÃ¡rio 
                        strSQL = "INSERT INTO clientes " +
                                 "(cpf, nome, telefone, email,dn) " +
                                 "VALUES (" +
                                 "'" + mkt_CPFF.Text + "'," +
                                 "'" + txt_Nome.Text + "'," +
                                 "'" + txt_Telefone.Text + "'," +
                                 "'" + txt_email.Text + "'," +
                                 "TO_DATE ('" + mkt_DN.Text + "', 'DD/MM/YYYY'));";

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
                mkt_CPFF.Focus();


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            //Consultar Registro

            //Bloco try/catch serve para tratamento de exceÃ§Ãµes (possiveis falhas ou erros),
            //Tratamento de cÃ³digos que podem nÃ£o ser totalmente atendidos e gerarem alguma exceÃ§Ã£o/erro.
            try
            {
                if (mkt_CPFF.Text.Trim().Length == 14)
                {
                    //Instanciar Objeto da Classe de ConexÃ£o com o Danco de Dados 
                    Conectar = new NpgsqlConnection(strCon);

                    //Abrir Objeto de ConexÃ£o com Banco de Dados criada acima;
                    Conectar.Open();

                    //Mondando a String (concatenando) com os objetos do FormulÃ¡rio 
                    strSQL = "SELECT * FROM clientes WHERE (CPF =" + "'" + mkt_CPFF.Text + "')";

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
                        mkt_CPFF.Text = LerRegistro.GetString(0);
                        txt_Nome.Text = LerRegistro.GetString(1);
                        txt_Telefone.Text = LerRegistro.GetString(2);
                        txt_email.Text = LerRegistro.GetString(3);
                        mkt_DN.Text = LerRegistro.GetDateTime(4).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        MessageBox.Show("CPF " + mkt_CPFF.Text + " NÃ£o Localizado!!!", "Sistema Informa");
                        mkt_CPFF.Focus();
                    }

                    if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                    {

                        //Limpar Objetos do FormulÃ¡rio usando a funÃ§Ã£o
                        LimparObjetos();
                    }
                    else
                    {
                        btn_Alterar.Enabled = true;
                        btn_Excluir.Enabled = true;
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
                mkt_CPFF.Focus();

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void brn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Cidade_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
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
                    strSQL = "UPDATE clientes SET " +
                                    "nome = '" + txt_Nome.Text + "', " +
                                    "telefone = '" + txt_Telefone.Text + "', " +
                                    "email = '" + txt_email.Text + "', " +
                                    "dn = TO_DATE('" + mkt_DN.Text + "', 'DD/MM/YYYY') " +
                                    "WHERE (cpf = '" + mkt_CPFF.Text + "')";

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
                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                //Habilitar os botÃµes Inserir e Consultar
                btn_Consultar.Enabled = true;
                btn_Inserir.Enabled = true;
                //Habilitar o mkt_CPF
                mkt_CPFF.Enabled = true;

                //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                //Fechar ConexÃ£o
                Conectar.Close();

                //Votar Cursor para o Objeto de Formulario
                mkt_CPFF.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
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
                    strSQL = "DELETE FROM clientes WHERE(cpf = '" + mkt_CPFF.Text + "')";
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
                btn_Alterar.Enabled = false;
                btn_Excluir.Enabled = false;
                //Habilitar os botÃµes Inserir e Consultar
                btn_Consultar.Enabled = true;
                btn_Inserir.Enabled = true;
                //Habilitar o mkt_CPF
                mkt_CPFF.Enabled = true;

                //Fechar Classe DataReader e Dispose (limpar o Objeto) da Classe de ComandoSQL
                LerRegistro.Close();
                ComandoSQL.Dispose();
                ComandoSQL.Transaction = null;

                //Fechar ConexÃ£o
                Conectar.Close();

                //Votar Cursor para o Objeto de Formulario
                mkt_CPFF.Focus();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void LimparObjetos()
        {

            //Limpar Objetos do FormulÃ¡rio
            mkt_CPFF.Clear();
            txt_Nome.Clear();
            txt_Telefone.Clear();
            txt_email.Clear();
            mkt_DN.Clear();

            return;

        }
        private void frm_CADCLI_Load(object sender, EventArgs e)
        {
            //Desabilitando BotÃµes Alterar e Excluir
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
