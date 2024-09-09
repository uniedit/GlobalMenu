using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalMenu {
    public partial class Periodos : Form {
        public Periodos() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //desabilitando periodo de Saída
            mkt_Saida.Enabled = false;
            //desabiltando botão de Saída
            btn_Saida.Enabled = false;
        }

        private void btn_Entrada_Click(object sender, EventArgs e) {
            //Entrada
            mkt_Entrada.Text = DateTime.Now.ToString();
            mkt_Entrada.Enabled = false;
            btn_Entrada.Enabled = false;
            //Saida
            mkt_Saida.Enabled = true;
            btn_Saida.Enabled = true;
        }

        

        private void mkt_Entrada_TextChanged(object sender, EventArgs e) {

        }

        private void mkt_Saida_TextChanged(object sender, EventArgs e) {

        }

        private void btn_Saida_Click(object sender, EventArgs e) {
            // Saída
            mkt_Saida.Text = DateTime.Now.ToString();
            // TimeSpan: Representa um intervalo de tempo (System.Runtime.dll)
            TimeSpan periodo = DateTime.Parse(mkt_Saida.Text) -
            DateTime.Parse(mkt_Entrada.Text);
            txt_PeriodoPadrao.Text = periodo.ToString();
            if (txt_ValorHora.Text == string.Empty) {
                MessageBox.Show("Favor Informar o Valor por Hora!",
                "Atenção");
                txt_ValorHora.Text = "0,00";
                txt_ValorHora.Focus();
            } else {
                /*
                Utilizando "var", possibilta declara uma variavel, 
                que se adapta à informação instanciada:
                var nomeDoAluno = "Informação alfanúmerica"; // A 
                váriavel será do tipo string, pois recebe um dado do 
                tipo string
                var idade = 18; // A váriavel será do tipo int pois 
                recebe um dado do tipo int
                var estaVivo = true; // A váriavel será do tipo 
                boolean, pois recebe um dado do tipo boolean
                Observação se usarmos:
                var idade;
                idade=18; // Vai apresentar "erro", pois ao declarar
                a variavel o compilador não conseguirá identificar o 
                seu tipo
                */
                var minutos = periodo.TotalMinutes;
                txt_PeriodoMinutos.Text = minutos.ToString();
                var valorHora = double.Parse(txt_ValorHora.Text);
                var valorApagar = (1 + (minutos / 60)) * valorHora;
                txt_ValorPagar.Text = valorApagar.ToString("C2");
            }
        }

        private void btn_ReiniciarCalculo_Click(object sender, EventArgs e) {
            //Desabilitando periodo de Saída
            btn_Saida.Enabled = false;
            mkt_Saida.Enabled = false;
            //Habiltar periodo de Entrada
            btn_Entrada.Enabled = true;
            mkt_Entrada.Enabled = true;
            //Limpar Caixas Textos
            txt_Id.Text = "";
            txt_ValorHora.Text = "0,00";
            txt_PeriodoPadrao.Text = "";
            txt_PeriodoMinutos.Text = "";
            txt_ValorPagar.Text = "";
            //Limpar Periodo de Entrada e Saída
            mkt_Entrada.Text = "";
            mkt_Saida.Text = "";
            //Retornar cursor à Identificação
            txt_Id.Focus();
        }
    }
}
