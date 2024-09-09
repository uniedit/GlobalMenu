namespace GlobalMenu {
    partial class Periodos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_identificacao = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_ValorHora = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btn_ReiniciarCalculo = new System.Windows.Forms.Button();
            this.btn_Entrada = new System.Windows.Forms.Button();
            this.btn_Saida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PeriodoPadrao = new System.Windows.Forms.TextBox();
            this.txt_PeriodoMinutos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ValorPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mkt_Entrada = new System.Windows.Forms.MaskedTextBox();
            this.mkt_Saida = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbl_identificacao
            // 
            this.lbl_identificacao.AutoSize = true;
            this.lbl_identificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_identificacao.ForeColor = System.Drawing.Color.White;
            this.lbl_identificacao.Location = new System.Drawing.Point(39, 58);
            this.lbl_identificacao.Name = "lbl_identificacao";
            this.lbl_identificacao.Size = new System.Drawing.Size(100, 20);
            this.lbl_identificacao.TabIndex = 0;
            this.lbl_identificacao.Text = "Identificação";
            // 
            // txt_Id
            // 
            this.txt_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Id.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Id.Location = new System.Drawing.Point(43, 81);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(182, 29);
            this.txt_Id.TabIndex = 67;
            // 
            // txt_ValorHora
            // 
            this.txt_ValorHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_ValorHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_ValorHora.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_ValorHora.Location = new System.Drawing.Point(43, 177);
            this.txt_ValorHora.Name = "txt_ValorHora";
            this.txt_ValorHora.Size = new System.Drawing.Size(182, 29);
            this.txt_ValorHora.TabIndex = 69;
            this.txt_ValorHora.Text = "0,00";
            this.txt_ValorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.ForeColor = System.Drawing.Color.White;
            this.lbl_valor.Location = new System.Drawing.Point(39, 154);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(137, 20);
            this.lbl_valor.TabIndex = 68;
            this.lbl_valor.Text = "Valor por Hora R$";
            // 
            // btn_ReiniciarCalculo
            // 
            this.btn_ReiniciarCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_ReiniciarCalculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_ReiniciarCalculo.FlatAppearance.BorderSize = 0;
            this.btn_ReiniciarCalculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_ReiniciarCalculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_ReiniciarCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReiniciarCalculo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReiniciarCalculo.ForeColor = System.Drawing.Color.White;
            this.btn_ReiniciarCalculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ReiniciarCalculo.ImageKey = "image (3).png";
            this.btn_ReiniciarCalculo.Location = new System.Drawing.Point(43, 261);
            this.btn_ReiniciarCalculo.Name = "btn_ReiniciarCalculo";
            this.btn_ReiniciarCalculo.Size = new System.Drawing.Size(173, 75);
            this.btn_ReiniciarCalculo.TabIndex = 70;
            this.btn_ReiniciarCalculo.Text = "Reiniciar Calculo";
            this.btn_ReiniciarCalculo.UseVisualStyleBackColor = false;
            this.btn_ReiniciarCalculo.Click += new System.EventHandler(this.btn_ReiniciarCalculo_Click);
            // 
            // btn_Entrada
            // 
            this.btn_Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Entrada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Entrada.FlatAppearance.BorderSize = 0;
            this.btn_Entrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Entrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Entrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrada.ForeColor = System.Drawing.Color.White;
            this.btn_Entrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Entrada.ImageKey = "image (3).png";
            this.btn_Entrada.Location = new System.Drawing.Point(382, 40);
            this.btn_Entrada.Name = "btn_Entrada";
            this.btn_Entrada.Size = new System.Drawing.Size(146, 53);
            this.btn_Entrada.TabIndex = 71;
            this.btn_Entrada.Text = "Entrada";
            this.btn_Entrada.UseVisualStyleBackColor = false;
            this.btn_Entrada.Click += new System.EventHandler(this.btn_Entrada_Click);
            // 
            // btn_Saida
            // 
            this.btn_Saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Saida.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Saida.FlatAppearance.BorderSize = 0;
            this.btn_Saida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Saida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Saida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Saida.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Saida.ForeColor = System.Drawing.Color.White;
            this.btn_Saida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Saida.ImageKey = "image (3).png";
            this.btn_Saida.Location = new System.Drawing.Point(551, 40);
            this.btn_Saida.Name = "btn_Saida";
            this.btn_Saida.Size = new System.Drawing.Size(146, 53);
            this.btn_Saida.TabIndex = 72;
            this.btn_Saida.Text = "Saída";
            this.btn_Saida.UseVisualStyleBackColor = false;
            this.btn_Saida.Click += new System.EventHandler(this.btn_Saida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(378, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 75;
            this.label3.Text = "Período Padrão";
            // 
            // txt_PeriodoPadrao
            // 
            this.txt_PeriodoPadrao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_PeriodoPadrao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PeriodoPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_PeriodoPadrao.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_PeriodoPadrao.Location = new System.Drawing.Point(382, 220);
            this.txt_PeriodoPadrao.Name = "txt_PeriodoPadrao";
            this.txt_PeriodoPadrao.Size = new System.Drawing.Size(146, 29);
            this.txt_PeriodoPadrao.TabIndex = 76;
            // 
            // txt_PeriodoMinutos
            // 
            this.txt_PeriodoMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_PeriodoMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PeriodoMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_PeriodoMinutos.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_PeriodoMinutos.Location = new System.Drawing.Point(466, 307);
            this.txt_PeriodoMinutos.Name = "txt_PeriodoMinutos";
            this.txt_PeriodoMinutos.Size = new System.Drawing.Size(146, 29);
            this.txt_PeriodoMinutos.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(463, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Período em Minutos";
            // 
            // txt_ValorPagar
            // 
            this.txt_ValorPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_ValorPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_ValorPagar.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_ValorPagar.Location = new System.Drawing.Point(551, 220);
            this.txt_ValorPagar.Name = "txt_ValorPagar";
            this.txt_ValorPagar.Size = new System.Drawing.Size(146, 29);
            this.txt_ValorPagar.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(547, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Valor à Pagar >>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 20);
            this.label1.TabIndex = 81;
            this.label1.Text = "* O valor à Pagar será a Taxa de Utilização + Minutos utilizados... *";
            // 
            // mkt_Entrada
            // 
            this.mkt_Entrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mkt_Entrada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkt_Entrada.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.mkt_Entrada.ForeColor = System.Drawing.Color.White;
            this.mkt_Entrada.Location = new System.Drawing.Point(382, 123);
            this.mkt_Entrada.Mask = "99/99/9999 99:99";
            this.mkt_Entrada.Name = "mkt_Entrada";
            this.mkt_Entrada.Size = new System.Drawing.Size(146, 31);
            this.mkt_Entrada.TabIndex = 82;
            // 
            // mkt_Saida
            // 
            this.mkt_Saida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mkt_Saida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkt_Saida.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.mkt_Saida.ForeColor = System.Drawing.Color.White;
            this.mkt_Saida.Location = new System.Drawing.Point(551, 123);
            this.mkt_Saida.Mask = "99/99/9999 99:99";
            this.mkt_Saida.Name = "mkt_Saida";
            this.mkt_Saida.Size = new System.Drawing.Size(146, 31);
            this.mkt_Saida.TabIndex = 83;
            // 
            // Periodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mkt_Saida);
            this.Controls.Add(this.mkt_Entrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Saida);
            this.Controls.Add(this.btn_Entrada);
            this.Controls.Add(this.btn_ReiniciarCalculo);
            this.Controls.Add(this.txt_ValorHora);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_identificacao);
            this.Controls.Add(this.txt_ValorPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_PeriodoMinutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PeriodoPadrao);
            this.Controls.Add(this.label3);
            this.Name = "Periodos";
            this.Text = "Periodos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_identificacao;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_ValorHora;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_ReiniciarCalculo;
        private System.Windows.Forms.Button btn_Entrada;
        private System.Windows.Forms.Button btn_Saida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_PeriodoPadrao;
        private System.Windows.Forms.TextBox txt_PeriodoMinutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ValorPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mkt_Entrada;
        private System.Windows.Forms.MaskedTextBox mkt_Saida;
    }
}