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

namespace GlobalMenu {
    public partial class Consulta : Form {
        public Consulta() {
            InitializeComponent();
        }

        private void frm_Contatos_Load(object sender, EventArgs e) {
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
        }

        private void LimparDados() {
            txt_ID.Clear();
            txt_Nome.Clear();
            txt_Telefone.Clear();
            txt_Email.Clear();
            txt_Cidade.Clear();
            txt_UF.Clear();
        }


        private void btn_Inserir_Click(object sender, EventArgs e) {
            //Inicio Inserir
            string strCon = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\autologon\source\repos\ServerDB\Base.mdb";

            try {
                if (txt_Nome.Text != string.Empty) {
                    OleDbConnection conectar = new OleDbConnection(strCon);
                    conectar.Open();

                    string strSQL = "SELECT * FROM Contatos WHERE (Nome =" + "'" + txt_Nome.Text + "')";

                    OleDbCommand comandoSQL = new OleDbCommand(strSQL, conectar);
                    DbDataReader lerRegistro = comandoSQL.ExecuteReader();

                    if (lerRegistro.Read()) {
                        MessageBox.Show("Contato (Nome) jÃ¡ Existe!!!", "Sistema Informa");
                    } else {
                        strSQL = "INSERT INTO Contatos (Nome,Telefone,email,Cidade,UF) " +
                                  "VALUES (" +
                                  "'" + txt_Nome.Text + "'," +
                                  "'" + txt_Telefone.Text + "'," +
                                  "'" + txt_Email.Text + "'," +
                                  "'" + txt_Cidade.Text + "'," +
                                  "'" + txt_UF.Text + "')";
                        comandoSQL = new OleDbCommand(strSQL, conectar);
                        comandoSQL.ExecuteNonQuery();
                        MessageBox.Show("Registro Inserido com Sucesso...", "Sistema Informa");

                        LimparDados();
                    }
                    conectar.Close();
                } else {
                    MessageBox.Show("Preencher pelo menos o campo NOME!!!");
                }
                txt_Nome.Focus();
            } catch (Exception erro) {
                MessageBox.Show(erro.Message);
            }
        }

        private void txt_Email_TextChanged(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void btn_Consultar_Click(object sender, EventArgs e) {
            string strCon = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\Users\autologon\source\repos\ServerDB\Base.mdb";

            try {

                if (txt_ID.Text != string.Empty) {
                    OleDbConnection conectar = new OleDbConnection(strCon);
                    conectar.Open();

                    string strSQL = "SELECT * FROM Contatos WHERE (ID =" + txt_ID.Text + ")";

                    OleDbCommand comandoSQL = new OleDbCommand(strSQL, conectar);
                    DbDataReader lerRegistro = comandoSQL.ExecuteReader();

                    if (lerRegistro.Read()) {
                        txt_Nome.Text = lerRegistro.GetString(1);
                        txt_Telefone.Text = lerRegistro.GetString(2);
                        txt_Email.Text = lerRegistro.GetString(3);
                        txt_Cidade.Text = lerRegistro.GetString(4);
                        txt_UF.Text = lerRegistro.GetString(5);

                        if (DialogResult.No == MessageBox.Show("Deseja Editar Registro?", "Sistema Informa",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2)) {
                            LimparDados();
                        } else {
                            btn_Excluir.Enabled = true;
                            btn_Alterar.Enabled = true;
                            txt_ID.Enabled = false;
                        }
                    } else {
                        MessageBox.Show("Identificador " + txt_ID.Text + " NÃ£o Localizado!!!", "Sistema Informa");
                        txt_ID.Focus();
                    }
                    conectar.Close();
                } else {
                    MessageBox.Show("Preencher o campo Identificador (ID)!!!");
                }
                txt_ID.Focus();

            } catch (Exception erro) {
                MessageBox.Show(erro.Message);
            }
        }

        private void brn_Voltar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
