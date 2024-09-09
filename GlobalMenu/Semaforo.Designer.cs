namespace GlobalMenu
{
    partial class Semaforo
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
            this.btn_Vermelho = new System.Windows.Forms.Button();
            this.btn_Amarelo = new System.Windows.Forms.Button();
            this.btn_Verde = new System.Windows.Forms.Button();
            this.btn_Automacao = new System.Windows.Forms.Button();
            this.btn_Sequencial = new System.Windows.Forms.Button();
            this.brn_Sair = new System.Windows.Forms.Button();
            this.lbl_Vermelho = new System.Windows.Forms.Label();
            this.lbl_Amarelo = new System.Windows.Forms.Label();
            this.lbl_Verde = new System.Windows.Forms.Label();
            this.nud_Tempo = new System.Windows.Forms.NumericUpDown();
            this.lbl_Temporizador = new System.Windows.Forms.Label();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.btn_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tempo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Vermelho
            // 
            this.btn_Vermelho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Vermelho.BackColor = System.Drawing.Color.Red;
            this.btn_Vermelho.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Vermelho.FlatAppearance.BorderSize = 0;
            this.btn_Vermelho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Vermelho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Vermelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vermelho.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vermelho.ForeColor = System.Drawing.Color.Black;
            this.btn_Vermelho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Vermelho.ImageKey = "image (3).png";
            this.btn_Vermelho.Location = new System.Drawing.Point(52, 52);
            this.btn_Vermelho.Name = "btn_Vermelho";
            this.btn_Vermelho.Size = new System.Drawing.Size(146, 53);
            this.btn_Vermelho.TabIndex = 69;
            this.btn_Vermelho.Text = "Vermelho";
            this.btn_Vermelho.UseVisualStyleBackColor = false;
            this.btn_Vermelho.Click += new System.EventHandler(this.btn_Vermelho_Click);
            // 
            // btn_Amarelo
            // 
            this.btn_Amarelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Amarelo.BackColor = System.Drawing.Color.Yellow;
            this.btn_Amarelo.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_Amarelo.FlatAppearance.BorderSize = 0;
            this.btn_Amarelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_Amarelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_Amarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Amarelo.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Amarelo.ForeColor = System.Drawing.Color.Black;
            this.btn_Amarelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Amarelo.ImageKey = "image (3).png";
            this.btn_Amarelo.Location = new System.Drawing.Point(52, 192);
            this.btn_Amarelo.Name = "btn_Amarelo";
            this.btn_Amarelo.Size = new System.Drawing.Size(146, 53);
            this.btn_Amarelo.TabIndex = 70;
            this.btn_Amarelo.Text = "Amarelo";
            this.btn_Amarelo.UseVisualStyleBackColor = false;
            this.btn_Amarelo.Click += new System.EventHandler(this.btn_Amarelo_Click);
            // 
            // btn_Verde
            // 
            this.btn_Verde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Verde.BackColor = System.Drawing.Color.Lime;
            this.btn_Verde.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Verde.FlatAppearance.BorderSize = 0;
            this.btn_Verde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.btn_Verde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_Verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verde.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Verde.ForeColor = System.Drawing.Color.Black;
            this.btn_Verde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Verde.ImageKey = "image (3).png";
            this.btn_Verde.Location = new System.Drawing.Point(52, 332);
            this.btn_Verde.Name = "btn_Verde";
            this.btn_Verde.Size = new System.Drawing.Size(146, 53);
            this.btn_Verde.TabIndex = 71;
            this.btn_Verde.Text = "Verde";
            this.btn_Verde.UseVisualStyleBackColor = false;
            this.btn_Verde.Click += new System.EventHandler(this.btn_Verde_Click);
            // 
            // btn_Automacao
            // 
            this.btn_Automacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Automacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Automacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Automacao.FlatAppearance.BorderSize = 0;
            this.btn_Automacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.btn_Automacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Automacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Automacao.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Automacao.ForeColor = System.Drawing.Color.White;
            this.btn_Automacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Automacao.ImageKey = "image (3).png";
            this.btn_Automacao.Location = new System.Drawing.Point(523, 12);
            this.btn_Automacao.Name = "btn_Automacao";
            this.btn_Automacao.Size = new System.Drawing.Size(146, 32);
            this.btn_Automacao.TabIndex = 72;
            this.btn_Automacao.Text = "Automação";
            this.btn_Automacao.UseVisualStyleBackColor = false;
            this.btn_Automacao.Click += new System.EventHandler(this.btn_Automacao_Click);
            // 
            // btn_Sequencial
            // 
            this.btn_Sequencial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sequencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Sequencial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Sequencial.FlatAppearance.BorderSize = 0;
            this.btn_Sequencial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Sequencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Sequencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sequencial.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sequencial.ForeColor = System.Drawing.Color.White;
            this.btn_Sequencial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sequencial.ImageKey = "image (3).png";
            this.btn_Sequencial.Location = new System.Drawing.Point(523, 64);
            this.btn_Sequencial.Name = "btn_Sequencial";
            this.btn_Sequencial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Sequencial.Size = new System.Drawing.Size(146, 32);
            this.btn_Sequencial.TabIndex = 73;
            this.btn_Sequencial.Text = "Sequencial";
            this.btn_Sequencial.UseVisualStyleBackColor = false;
            this.btn_Sequencial.Click += new System.EventHandler(this.btn_Sequencial_Click);
            // 
            // brn_Sair
            // 
            this.brn_Sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brn_Sair.BackColor = System.Drawing.Color.Red;
            this.brn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.brn_Sair.FlatAppearance.BorderSize = 0;
            this.brn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.brn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_Sair.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Sair.ForeColor = System.Drawing.Color.White;
            this.brn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brn_Sair.ImageKey = "image (3).png";
            this.brn_Sair.Location = new System.Drawing.Point(600, 407);
            this.brn_Sair.Name = "brn_Sair";
            this.brn_Sair.Size = new System.Drawing.Size(69, 31);
            this.brn_Sair.TabIndex = 74;
            this.brn_Sair.Text = "Sair";
            this.brn_Sair.UseVisualStyleBackColor = false;
            this.brn_Sair.Click += new System.EventHandler(this.brn_Sair_Click);
            // 
            // lbl_Vermelho
            // 
            this.lbl_Vermelho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Vermelho.AutoSize = true;
            this.lbl_Vermelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.lbl_Vermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vermelho.ForeColor = System.Drawing.Color.White;
            this.lbl_Vermelho.Location = new System.Drawing.Point(277, 52);
            this.lbl_Vermelho.Name = "lbl_Vermelho";
            this.lbl_Vermelho.Size = new System.Drawing.Size(75, 53);
            this.lbl_Vermelho.TabIndex = 75;
            this.lbl_Vermelho.Text = "⚫";
            this.lbl_Vermelho.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Amarelo
            // 
            this.lbl_Amarelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Amarelo.AutoSize = true;
            this.lbl_Amarelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.lbl_Amarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amarelo.ForeColor = System.Drawing.Color.White;
            this.lbl_Amarelo.Location = new System.Drawing.Point(277, 192);
            this.lbl_Amarelo.Name = "lbl_Amarelo";
            this.lbl_Amarelo.Size = new System.Drawing.Size(75, 53);
            this.lbl_Amarelo.TabIndex = 76;
            this.lbl_Amarelo.Text = "⚫";
            this.lbl_Amarelo.Click += new System.EventHandler(this.lbl_Amarelo_Click);
            // 
            // lbl_Verde
            // 
            this.lbl_Verde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Verde.AutoSize = true;
            this.lbl_Verde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.lbl_Verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Verde.ForeColor = System.Drawing.Color.White;
            this.lbl_Verde.Location = new System.Drawing.Point(277, 332);
            this.lbl_Verde.Name = "lbl_Verde";
            this.lbl_Verde.Size = new System.Drawing.Size(75, 53);
            this.lbl_Verde.TabIndex = 77;
            this.lbl_Verde.Text = "⚫";
            this.lbl_Verde.Click += new System.EventHandler(this.lbl_Verde_Click);
            // 
            // nud_Tempo
            // 
            this.nud_Tempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_Tempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.nud_Tempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nud_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Tempo.ForeColor = System.Drawing.Color.White;
            this.nud_Tempo.Location = new System.Drawing.Point(523, 171);
            this.nud_Tempo.Name = "nud_Tempo";
            this.nud_Tempo.Size = new System.Drawing.Size(146, 22);
            this.nud_Tempo.TabIndex = 78;
            this.nud_Tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Tempo.ValueChanged += new System.EventHandler(this.nud_Tempo_ValueChanged);
            // 
            // lbl_Temporizador
            // 
            this.lbl_Temporizador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Temporizador.AutoSize = true;
            this.lbl_Temporizador.Font = new System.Drawing.Font("JetBrains Mono", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Temporizador.ForeColor = System.Drawing.Color.White;
            this.lbl_Temporizador.Location = new System.Drawing.Point(544, 196);
            this.lbl_Temporizador.Name = "lbl_Temporizador";
            this.lbl_Temporizador.Size = new System.Drawing.Size(104, 18);
            this.lbl_Temporizador.TabIndex = 79;
            this.lbl_Temporizador.Text = "Temporizador";
            this.lbl_Temporizador.Click += new System.EventHandler(this.lbl_Temporizador_Click);
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.lbl_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.ForeColor = System.Drawing.Color.White;
            this.lbl_Tempo.Location = new System.Drawing.Point(497, 17);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(20, 22);
            this.lbl_Tempo.TabIndex = 80;
            this.lbl_Tempo.Text = "0";
            this.lbl_Tempo.Click += new System.EventHandler(this.lbl_Tempo_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Stop.BackColor = System.Drawing.Color.Red;
            this.btn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Stop.FlatAppearance.BorderSize = 0;
            this.btn_Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stop.ImageKey = "image (3).png";
            this.btn_Stop.Location = new System.Drawing.Point(600, 370);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(69, 31);
            this.btn_Stop.TabIndex = 81;
            this.btn_Stop.Text = "Parar";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Semaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.lbl_Tempo);
            this.Controls.Add(this.lbl_Temporizador);
            this.Controls.Add(this.nud_Tempo);
            this.Controls.Add(this.lbl_Verde);
            this.Controls.Add(this.lbl_Amarelo);
            this.Controls.Add(this.lbl_Vermelho);
            this.Controls.Add(this.brn_Sair);
            this.Controls.Add(this.btn_Sequencial);
            this.Controls.Add(this.btn_Automacao);
            this.Controls.Add(this.btn_Verde);
            this.Controls.Add(this.btn_Vermelho);
            this.Controls.Add(this.btn_Amarelo);
            this.Name = "Semaforo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequencial";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Tempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Vermelho;
        private System.Windows.Forms.Button btn_Amarelo;
        private System.Windows.Forms.Button btn_Verde;
        private System.Windows.Forms.Button btn_Automacao;
        private System.Windows.Forms.Button btn_Sequencial;
        private System.Windows.Forms.Button brn_Sair;
        private System.Windows.Forms.Label lbl_Vermelho;
        private System.Windows.Forms.Label lbl_Amarelo;
        private System.Windows.Forms.Label lbl_Verde;
        private System.Windows.Forms.NumericUpDown nud_Tempo;
        private System.Windows.Forms.Label lbl_Temporizador;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Button btn_Stop;
    }
}