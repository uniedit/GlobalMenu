﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GlobalMenu {
    public partial class WindowsApp : Form {
        public WindowsApp() {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            this.Hide();
            Paint painnnte = new Paint();
            painnnte.ShowDialog();
            painnnte = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            Notepad notepad = new Notepad();
            notepad.ShowDialog();
            notepad = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            Process.Start(@"calc.exe");
        }

        private void button1_Click(object sender, EventArgs e) {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = @"C:\";
            process.Start();
        }

        private void WindowsApp_Load(object sender, EventArgs e) {

        }


        private void pictureBox3_Click(object sender, EventArgs e) {

        }

        private void button5_Click_1(object sender, EventArgs e) {
            this.Close();
        }
    }
}
