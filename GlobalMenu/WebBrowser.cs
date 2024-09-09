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
    public partial class WebBrowser : Form {
        public WebBrowser() {
            InitializeComponent();

            webBrowser1.Width = this.Width - 50;
            webBrowser1.Height = this.Height - 125;
        }

        public void WebBrowser_Resize() {
            webBrowser1.Width = this.Width - 50;
            webBrowser1.Height = this.Height - 125;
        }

        public void WebBrowser_FormClosed() {
            webBrowser1.Dispose();
        }


        private void btn_Entrada_Click(object sender, EventArgs e) {
            try {
                Uri abrirUrl = new Uri(txt_URL.Text);
                webBrowser1.Url = abrirUrl;
            } catch (Exception erroURL) {
                MessageBox.Show("Ops!:" + erroURL.Message, "Nosso Navegador");
                MessageBox.Show("Não esqueça de colocar o endereço completo...", "Nosso Navegador");
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e) {
            webBrowser1.GoBack();
        }

        private void btn_Avancar_Click(object sender, EventArgs e) {
            webBrowser1.GoForward();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }

        private void WebBrowser_Load(object sender, EventArgs e) {

        }
    }
}
