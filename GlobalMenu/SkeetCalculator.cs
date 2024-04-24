using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Skeet {
    public partial class SkeetCalculator : Form {
        public SkeetCalculator() {
            InitializeComponent();
        }

        double num1;
        double num2;
        string option;
        double result;


        private void skeetButton1_Load(object sender, EventArgs e) {

        }

        private void skeetSlider1_Load(object sender, EventArgs e) {

        }

        private void shadowLabel1_Click(object sender, EventArgs e) {

        }

        private void skeetButton2_Load(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button19_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + ",";
        }

        private void skeetCheckbox1_Load(object sender, EventArgs e) {

        }

        private void button12_Click(object sender, EventArgs e) {
            option = "+";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e) {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void txtTotal_Click(object sender, EventArgs e) {

        }

        private void btnMin_Click(object sender, EventArgs e) {
                    option = "-";
                    num1 = double.Parse(txtTotal.Text);
                    txtTotal.Clear();
        }

        private void btnMultiple_Click(object sender, EventArgs e) {
            option = "*";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e) {
            option = "/";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void button20_Click(object sender, EventArgs e) {
            option = "√";
            num1 = double.Parse(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e) {
            try {
                num2 = double.Parse(txtTotal.Text);

                if (option.Equals("+"))
                    result = num1 + num2;

                if (option.Equals("-")) 
                    result = num1 - num2;
                
                if (option.Equals("*"))
                    result = num1 * num2;

                if (option.Equals("/"))
                    result = num1 / num2;

                if (option.Equals("√"))
                    result = Math.Sqrt(num1);

                txtTotal.Text = result + "";
            } catch (Exception exErro) {
                MessageBox.Show("Aviso: " + exErro.Message, "Window Box");
                txtTotal.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button1_Click_1(object sender, EventArgs e) {

            option = "+/-";
            num1 = double.Parse(txtTotal.Text);

            if (result < 0) {
                result = Math.Abs(result);
            } else if (num1 > 0) {
                double dobro;
                dobro = num1 + num1;
                result = num1 - dobro;
            } else {
                double dobro;
                dobro = result + result;
                result = result - dobro;
            }
            txtTotal.Text = result + "";
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void skeetGroupBox1_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }
    }
}
