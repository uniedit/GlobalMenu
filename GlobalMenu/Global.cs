﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace GlobalMenu {
    public partial class Global : Form {
        public Global() {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e) {
            this.Hide();
            ProjectsApp Projetos = new ProjectsApp();
            Projetos.ShowDialog();
            Projetos = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            var resp = MessageBox.Show("Quer Encerrar o Programa?", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes) {
                Environment.Exit(0);
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            WindowsApp WinApp = new WindowsApp();
            WinApp.ShowDialog();
            WinApp = null;
            this.Show();
        }

        

    }
}