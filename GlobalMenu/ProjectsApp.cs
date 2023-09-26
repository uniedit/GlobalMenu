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


    }
}
