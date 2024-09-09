using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace GlobalMenu
{
    public partial class Semaforo : Form
    {
        public Semaforo()
        {
            InitializeComponent();
        }
        public Boolean Stop = false;
        public CancellationTokenSource ts_Sequencia = new CancellationTokenSource();
        

        private void btn_Vermelho_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.ForeColor = Color.Red;
            lbl_Amarelo.ForeColor = Color.White;
            lbl_Verde.ForeColor = Color.White;
            
        }

        private void btn_Amarelo_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.ForeColor = Color.White;
            lbl_Amarelo.ForeColor = Color.Yellow;
            lbl_Verde.ForeColor = Color.White;
            
        }

        private void btn_Verde_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.ForeColor = Color.White;
            lbl_Amarelo.ForeColor = Color.White;
            lbl_Verde.ForeColor = Color.Green;

        }

        private void btn_Automacao_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch(); //Medir Tempo
            int i = 0; //Intervalo
            int t = 0; //Transição - Repetições
            while (t < 3)
            {
                //Vermelho
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_Vermelho.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Amarelo
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100; i++)
                {
                    btn_Verde.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Verde
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_Amarelo.PerformClick();
                    lbl_Tempo.Text = i.ToString();
                    //MessageBox.Show(i.ToString());
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Inc 1 em t (Transição - Repetição)
                t++;
            }
        }

        private void nud_Tempo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void brn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_Sequencial_Click(object sender, EventArgs e)
        {
            try
            {
                while (Stop == false)
                {
                    btn_Vermelho.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 
                    btn_Verde.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 
                    btn_Amarelo.PerformClick();
                    await Task.Delay(3000, ts_Sequencia.Token); // 03 
                }
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Sequencial Cancelada!", "Atenção");
                //MessageBox.Show("Sequencial: "+ex.Message);
            }
            catch (Exception erroX)
            {
                MessageBox.Show("Erro:" + erroX.Message);
            }
        }   


        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Stop = true;
            ts_Sequencia.Cancel();
            //this.Close();
        }

        private void lbl_Amarelo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Verde_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Temporizador_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Tempo_Click(object sender, EventArgs e)
        {

        }
    }



}

