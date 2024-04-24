using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlobalMenu {
    public partial class MitsubaMenu : Form {
        public MitsubaMenu() {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }

        private void MitsubaMenu_Load(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            Process ChromeProcess = new Process();
            ChromeProcess.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            ChromeProcess.StartInfo.Arguments = "https://www.mensagensdebomdia.com.br/";
            ChromeProcess.Start();
            ChromeProcess.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e) {
            Process FirefoxProcess = new Process();
            FirefoxProcess.StartInfo.FileName = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            FirefoxProcess.StartInfo.Arguments = "https://www.mensagensdebomdia.com.br/";
            FirefoxProcess.Start();
            FirefoxProcess.WaitForExit();
        }
    }
}