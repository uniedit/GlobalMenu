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
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
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
            this.Hide();
            SkeetCalculator skooto = new SkeetCalculator();
            skooto.ShowDialog();
            this.Show();
        }

        private void button22_Click(object sender, EventArgs e) {
            hideSubMenu();
        }

        private void btnWinApps_Click(object sender, EventArgs e) {
            showSubMenu(panelSubMenuWin);
        }

        private void button6_Click(object sender, EventArgs e) {
            MenuStrip menustr = new MenuStrip();
            menustr.ShowDialog();
        }

        //  private void button6_Click(object sender, EventArgs e) {
        //      Process braveProcess = new Process();
        //      braveProcess.StartInfo.FileName = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
        //      braveProcess.StartInfo.Arguments = "https://www.tiktok.com/@am.mats/video/7276804838795562273?q=indo%20ali&t=1695770502823";
        //      braveProcess.Start();
        //      braveProcess.WaitForExit();
        //  }

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        public class CustomColorTable : ProfessionalColorTable {
            public override Color MenuStripGradientBegin => Color.FromArgb(0, 0, 0);
            public override Color MenuStripGradientEnd => Color.FromArgb(0, 0, 0);

            public override Color MenuItemPressedGradientBegin => Color.FromArgb(46, 46, 46);
            public override Color MenuItemPressedGradientMiddle => Color.FromArgb(46, 46, 46);
            public override Color MenuItemPressedGradientEnd => Color.FromArgb(46, 46, 46);

            public override Color MenuBorder => Color.FromArgb(0, 0, 0);

            public override Color MenuItemSelected => Color.FromArgb(61, 61, 61);
            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(61, 61, 61);
            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(61, 61, 61);
            public override Color MenuItemBorder => Color.FromArgb(112, 112, 112);

            public override Color ToolStripDropDownBackground => Color.FromArgb(46, 46, 46);

            public override Color ImageMarginGradientBegin => Color.FromArgb(46, 46, 46);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(46, 46, 46);
            public override Color ImageMarginGradientEnd => Color.FromArgb(46, 46, 46);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            var resp = MessageBox.Show("Quer Encerrar o Programa?", "Info Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes) {
                Environment.Exit(0);
            }
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            Cadastro conlt = new Cadastro();
            conlt.ShowDialog();
            this.Show();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Sei la");
        }

        int clickCount = 0;
        private void button7_Click(object sender, EventArgs e) {
            this.Hide();
            EditorTexto editor = new EditorTexto();
            editor.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            clickCount++;
            if (clickCount == 5) {
                Process FireFoxProcess = new Process();
                FireFoxProcess.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                FireFoxProcess.StartInfo.Arguments = "https://www.tiktok.com/@am.mats/video/7276804838795562273?q=indo%20ali&t=1695770502823";
                FireFoxProcess.Start();
                FireFoxProcess.WaitForExit();
                clickCount = 0;
            }
        }

        private void fornedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fornecedores forn = new Fornecedores();
            forn.ShowDialog();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount == 5)
            {
                MitsubaMenu mitsubauwu = new MitsubaMenu();
                mitsubauwu.ShowDialog();
                clickCount = 0;
            }
        }

        private void SideMenu_Load(object sender, EventArgs e) {
            button6.Enabled = false;
        }

        private void button9_Click_1(object sender, EventArgs e) {
            this.Hide();
            Periodos period = new Periodos();
            period.ShowDialog();
            this.Show();
        }

        private void button10_Click(object sender, EventArgs e) {
            this.Hide();
            WebBrowser web = new WebBrowser();
            web.ShowDialog();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e) {
            this.Hide();
            Semaforo semaforo = new Semaforo();
            semaforo.ShowDialog();
            this.Show();
        }
    }
}
