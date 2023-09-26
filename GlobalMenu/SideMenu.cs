using Skeet;
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

namespace GlobalMenu {
    public partial class SideMenu : Form {
        public SideMenu() {
            InitializeComponent();
            customizeMenu();
        }

        private void customizeMenu() {
            panelSubMenuProjects.Visible = false;
            panelSubMenuWin.Visible = false;
        }

        private void hideSubMenu() {
            if (panelSubMenuWin.Visible == true) {
                panelSubMenuWin.Visible = false;
            }

            if (panelSubMenuProjects.Visible == true) {
                panelSubMenuProjects.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            } else {
                subMenu.Visible = false;
            }

        }


        private void bntProjetos_Click(object sender, EventArgs e) {
            showSubMenu(panelSubMenuProjects);
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e) {
            

        }

        private void button1_Click(object sender, EventArgs e) {
            SkeetCalculator skooto = new SkeetCalculator();
            skooto.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e) {
            hideSubMenu();
        }

        private void btnWinApps_Click(object sender, EventArgs e) {
            showSubMenu(panelSubMenuWin);
        }

        private void button6_Click(object sender, EventArgs e) {
            Process braveProcess = new Process();
            braveProcess.StartInfo.FileName = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
            braveProcess.StartInfo.Arguments = "https://www.tiktok.com/@am.mats/video/7276804838795562273?q=indo%20ali&t=1695770502823";
            braveProcess.Start();
            braveProcess.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e) {
            Notepad notepad = new Notepad();
            notepad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            Process.Start(@"calc.exe");
        }

        private void button2_Click(object sender, EventArgs e) {
            Paint painnnte = new Paint();
            painnnte.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e) {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.WorkingDirectory = @"C:\";
            process.Start();
        }

        private void button8_Click(object sender, EventArgs e) {
            this.Hide();
            Global menu = new Global();
            menu.ShowDialog();
            this.Show();
        }
    }
}
