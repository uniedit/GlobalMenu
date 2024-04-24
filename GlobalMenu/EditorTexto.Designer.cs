namespace GlobalMenu
{
    partial class EditorTexto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorTexto));
            this.rtb_Texto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.quemSomosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.btn_Abrir = new System.Windows.Forms.ToolStripButton();
            this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Negrito = new System.Windows.Forms.ToolStripButton();
            this.btn_Italico = new System.Windows.Forms.ToolStripButton();
            this.btn_Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.btn_Fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Esquerda = new System.Windows.Forms.ToolStripButton();
            this.btn_Centro = new System.Windows.Forms.ToolStripButton();
            this.btn_Direita = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Texto
            // 
            this.rtb_Texto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.rtb_Texto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Texto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Texto.ForeColor = System.Drawing.Color.White;
            this.rtb_Texto.Location = new System.Drawing.Point(0, 51);
            this.rtb_Texto.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Texto.Name = "rtb_Texto";
            this.rtb_Texto.Size = new System.Drawing.Size(625, 320);
            this.rtb_Texto.TabIndex = 2;
            this.rtb_Texto.Text = "";
            this.rtb_Texto.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator4,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sistemaToolStripMenuItem.Text = "Arquivo";
            this.sistemaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "Novo";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(117, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.fornedoresToolStripMenuItem});
            this.consultaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.consultaToolStripMenuItem.Text = "Editar";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fToolStripMenuItem.Text = "Copiar";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "Colar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem3.Text = "Desfazer";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // fornedoresToolStripMenuItem
            // 
            this.fornedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fornedoresToolStripMenuItem.Name = "fornedoresToolStripMenuItem";
            this.fornedoresToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.fornedoresToolStripMenuItem.Text = "Refazer";
            this.fornedoresToolStripMenuItem.Click += new System.EventHandler(this.fornedoresToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.quemSomosToolStripMenuItem});
            this.infoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.infoToolStripMenuItem.Text = "Formatar";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem4.Text = "Negrito";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem5.Text = "Italico";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem6.Text = "Sublinhado";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // quemSomosToolStripMenuItem
            // 
            this.quemSomosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.quemSomosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quemSomosToolStripMenuItem.Name = "quemSomosToolStripMenuItem";
            this.quemSomosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.quemSomosToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Black;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo,
            this.btn_Abrir,
            this.btn_Salvar,
            this.toolStripSeparator1,
            this.btn_Copiar,
            this.btn_Colar,
            this.toolStripSeparator2,
            this.btn_Negrito,
            this.btn_Italico,
            this.btn_Sublinhado,
            this.btn_Fonte,
            this.toolStripSeparator3,
            this.btn_Esquerda,
            this.btn_Centro,
            this.btn_Direita});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(625, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_Novo
            // 
            this.btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Novo.Image")));
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(23, 20);
            this.btn_Novo.Text = "toolStripButton1";
            this.btn_Novo.ToolTipText = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Abrir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Abrir.Image")));
            this.btn_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(23, 20);
            this.btn_Abrir.Text = "toolStripButton2";
            this.btn_Abrir.ToolTipText = "Abrir";
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salvar.Image")));
            this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(23, 20);
            this.btn_Salvar.Text = "toolStripButton3";
            this.btn_Salvar.ToolTipText = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Copiar.Image")));
            this.btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(23, 20);
            this.btn_Copiar.Text = "toolStripButton4";
            this.btn_Copiar.ToolTipText = "Copiar";
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Colar
            // 
            this.btn_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Colar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Colar.Image")));
            this.btn_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Colar.Name = "btn_Colar";
            this.btn_Colar.Size = new System.Drawing.Size(23, 20);
            this.btn_Colar.Text = "toolStripButton10";
            this.btn_Colar.ToolTipText = "Colar";
            this.btn_Colar.Click += new System.EventHandler(this.btn_Colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // btn_Negrito
            // 
            this.btn_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Negrito.Image = ((System.Drawing.Image)(resources.GetObject("btn_Negrito.Image")));
            this.btn_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Negrito.Name = "btn_Negrito";
            this.btn_Negrito.Size = new System.Drawing.Size(23, 20);
            this.btn_Negrito.Text = "toolStripButton6";
            this.btn_Negrito.ToolTipText = "Negrito";
            this.btn_Negrito.Click += new System.EventHandler(this.btn_Negrito_Click);
            // 
            // btn_Italico
            // 
            this.btn_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italico.Image = ((System.Drawing.Image)(resources.GetObject("btn_Italico.Image")));
            this.btn_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italico.Name = "btn_Italico";
            this.btn_Italico.Size = new System.Drawing.Size(23, 20);
            this.btn_Italico.Text = "toolStripButton7";
            this.btn_Italico.ToolTipText = "Italico";
            this.btn_Italico.Click += new System.EventHandler(this.btn_Italico_Click);
            // 
            // btn_Sublinhado
            // 
            this.btn_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sublinhado.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sublinhado.Image")));
            this.btn_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sublinhado.Name = "btn_Sublinhado";
            this.btn_Sublinhado.Size = new System.Drawing.Size(23, 20);
            this.btn_Sublinhado.Text = "toolStripButton8";
            this.btn_Sublinhado.ToolTipText = "Sublinhado";
            this.btn_Sublinhado.Click += new System.EventHandler(this.btn_Sublinhado_Click);
            // 
            // btn_Fonte
            // 
            this.btn_Fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Fonte.Image = ((System.Drawing.Image)(resources.GetObject("btn_Fonte.Image")));
            this.btn_Fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Fonte.Name = "btn_Fonte";
            this.btn_Fonte.Size = new System.Drawing.Size(23, 20);
            this.btn_Fonte.Text = "toolStripButton9";
            this.btn_Fonte.ToolTipText = "Fonte";
            this.btn_Fonte.Click += new System.EventHandler(this.btn_Fonte_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // btn_Esquerda
            // 
            this.btn_Esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Esquerda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Esquerda.Image")));
            this.btn_Esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Esquerda.Name = "btn_Esquerda";
            this.btn_Esquerda.Size = new System.Drawing.Size(23, 20);
            this.btn_Esquerda.Text = "toolStripButton11";
            this.btn_Esquerda.ToolTipText = "Alinhar Esquerda";
            this.btn_Esquerda.Click += new System.EventHandler(this.btn_Esquerda_Click);
            // 
            // btn_Centro
            // 
            this.btn_Centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Centro.Image = ((System.Drawing.Image)(resources.GetObject("btn_Centro.Image")));
            this.btn_Centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Centro.Name = "btn_Centro";
            this.btn_Centro.Size = new System.Drawing.Size(23, 20);
            this.btn_Centro.Text = "toolStripButton12";
            this.btn_Centro.ToolTipText = "Alinhar Centro";
            this.btn_Centro.Click += new System.EventHandler(this.btn_Centro_Click);
            // 
            // btn_Direita
            // 
            this.btn_Direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Direita.Image = ((System.Drawing.Image)(resources.GetObject("btn_Direita.Image")));
            this.btn_Direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Direita.Name = "btn_Direita";
            this.btn_Direita.Size = new System.Drawing.Size(23, 20);
            this.btn_Direita.Text = "toolStripButton5";
            this.btn_Direita.ToolTipText = "Alinhar Direita";
            this.btn_Direita.Click += new System.EventHandler(this.btn_Direita_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // EditorTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(625, 368);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.rtb_Texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditorTexto";
            this.Text = "EditorTexto";
            this.Load += new System.EventHandler(this.EditorTexto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_Texto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quemSomosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripButton btn_Abrir;
        private System.Windows.Forms.ToolStripButton btn_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Copiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Negrito;
        private System.Windows.Forms.ToolStripButton btn_Italico;
        private System.Windows.Forms.ToolStripButton btn_Sublinhado;
        private System.Windows.Forms.ToolStripButton btn_Fonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Colar;
        private System.Windows.Forms.ToolStripButton btn_Esquerda;
        private System.Windows.Forms.ToolStripButton btn_Centro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Direita;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}