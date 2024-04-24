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
using Skeet;
using System.Windows.Forms.VisualStyles;

namespace GlobalMenu {
    public partial class ProjectsApp : Form {
        public ProjectsApp() {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            SkeetCalculator skeet = new SkeetCalculator();
            skeet.ShowDialog();
            skeet = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
          Fornecedores forn = new Fornecedores();
          forn.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            EditorTexto etext = new EditorTexto();
            etext.ShowDialog();
        }
    }
}
