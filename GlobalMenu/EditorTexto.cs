using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GlobalMenu {
    public partial class EditorTexto : Form {
        StreamReader leitura = null;
        public EditorTexto() {
            InitializeComponent();
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
            toolStrip1.Renderer = new MySR();
        }


        private void Novo() {
            rtb_Texto.Clear();
            rtb_Texto.Focus();
        }

        private void Abrir() {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\User\Documents";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "*.TXT |.txt|Todos Arquivos (.)|*.*"; ;
            try {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK) {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(arquivo);
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.rtb_Texto.Text = "";
                    string linha = sr.ReadLine();
                    while (linha != null) {
                        this.rtb_Texto.Text += linha + "\n";
                        linha = sr.ReadLine();
                    }
                    sr.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro ao Abrir : " + ex.Message,
                "Sistema Informa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void Salvar() {
            try {
                if (this.saveFileDialog1.ShowDialog() ==
                DialogResult.OK) {
                    FileStream arquivo = new FileStream
                    (saveFileDialog1.FileName, FileMode.OpenOrCreate,
                    FileAccess.Write);
                    StreamWriter sw = new StreamWriter(arquivo);
                    sw.Flush();
                    sw.BaseStream.Seek(0, SeekOrigin.Begin);
                    sw.Write(this.rtb_Texto.Text);
                    sw.Flush();
                    sw.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro ao Salvar : " +
                ex.Message, "Sistema Informa", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                        }
        }

        private void Copiar() {
            if (rtb_Texto.SelectionLength > 0) {
                rtb_Texto.Copy();
            }
        }

        private void Colar() {
            rtb_Texto.Paste();
        }

        private void Negrito() {
            string nomeFonte = rtb_Texto.SelectionFont.Name;
            float tamanhoFonte = rtb_Texto.SelectionFont.Size;
            bool resp;
            resp = rtb_Texto.SelectionFont.Bold;
            if (resp == false) {
                rtb_Texto.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Bold);
            } else {
                rtb_Texto.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Regular);
            }
        }

        private void Italico() {
            string nomeFonte = rtb_Texto.SelectionFont.Name;
            float tamanhoFonte = rtb_Texto.SelectionFont.Size;
            bool resp;
            resp = rtb_Texto.SelectionFont.Italic;
            if (resp == false) {
                rtb_Texto.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Italic);
            } else {
                rtb_Texto.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Regular);
            }
        }

        private void Sublinhar() {
            string nomeFonte = rtb_Texto.SelectionFont.Name;
            float tamanhoFonte = rtb_Texto.SelectionFont.Size;
            bool resp;
            resp = rtb_Texto.SelectionFont.Underline;
            if (resp == false) {
                rtb_Texto.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Underline);
            } else {
                rtb_Texto.SelectionFont = new Font(nomeFonte, tamanhoFonte, FontStyle.Regular);
            }
        }

        private void Esquerda() {
            rtb_Texto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Centralizado() {
            rtb_Texto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Direita() {
            rtb_Texto.SelectionAlignment = HorizontalAlignment.Right;
        }



        private void EditorTexto_Load(object sender, EventArgs e) {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e) {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e) {

        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

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

        public class MySR : ToolStripSystemRenderer {
            public MySR() { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) {
                if (e.ToolStrip.GetType() == typeof(ToolStrip)) {

                } else {
                    base.OnRenderToolStripBorder(e);
                }
            }
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void toolStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            Novo();
        }

        private void btn_Fonte_Click(object sender, EventArgs e) {
            FontDialog fonte = new FontDialog();
            if (fonte.ShowDialog() == DialogResult.OK) {
                rtb_Texto.Font = fonte.Font;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            Novo();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            Abrir();
        }

        private void btn_Abrir_Click(object sender, EventArgs e) {
            Abrir();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e) {
            Salvar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e) {
            Salvar();
        }

        private void btn_Copiar_Click(object sender, EventArgs e) {
            Copiar();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e) {
            Copiar();
        }

        private void btn_Colar_Click(object sender, EventArgs e) {
            Colar();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            Colar();
        }

        private void btn_Negrito_Click(object sender, EventArgs e) {
            Negrito();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e) {
            Negrito();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e) {
            Italico();
        }

        private void btn_Italico_Click(object sender, EventArgs e) {
            Italico();
        }

        private void btn_Sublinhado_Click(object sender, EventArgs e) {
            Sublinhar();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e) {
            Sublinhar();
        }

        private void btn_Esquerda_Click(object sender, EventArgs e) {
            Esquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e) {
            Esquerda();
        }

        private void btn_Centro_Click(object sender, EventArgs e) {
            Centralizado();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e) {
            Centralizado();
        }

        private void btn_Direita_Click(object sender, EventArgs e) {
            Direita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e) {
            Direita();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e) {
            rtb_Texto.Undo();
        }

        private void fornedoresToolStripMenuItem_Click(object sender, EventArgs e) {
            rtb_Texto.Redo();
        }
    }
}
