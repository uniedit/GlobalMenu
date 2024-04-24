namespace GlobalMenu
{
    partial class Fornecedores
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
            this.mkt_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.brn_Voltar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_NomeFantasia = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mkt_CNPJ
            // 
            this.mkt_CNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mkt_CNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkt_CNPJ.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mkt_CNPJ.ForeColor = System.Drawing.SystemColors.Window;
            this.mkt_CNPJ.Location = new System.Drawing.Point(224, 49);
            this.mkt_CNPJ.Mask = "00.000.000/0000-00";
            this.mkt_CNPJ.Name = "mkt_CNPJ";
            this.mkt_CNPJ.Size = new System.Drawing.Size(150, 29);
            this.mkt_CNPJ.TabIndex = 77;
            this.mkt_CNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkt_CNPJ_MaskInputRejected);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Telefone.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Telefone.Location = new System.Drawing.Point(224, 353);
            this.txt_Telefone.Mask = "(99) 99999-9999";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(150, 29);
            this.txt_Telefone.TabIndex = 74;
            // 
            // brn_Voltar
            // 
            this.brn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.brn_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.brn_Voltar.FlatAppearance.BorderSize = 0;
            this.brn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.brn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.brn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_Voltar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Voltar.ForeColor = System.Drawing.Color.White;
            this.brn_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brn_Voltar.ImageKey = "image (3).png";
            this.brn_Voltar.Location = new System.Drawing.Point(45, 338);
            this.brn_Voltar.Name = "brn_Voltar";
            this.brn_Voltar.Size = new System.Drawing.Size(146, 53);
            this.brn_Voltar.TabIndex = 72;
            this.brn_Voltar.Text = "Voltar";
            this.brn_Voltar.UseVisualStyleBackColor = false;
            this.brn_Voltar.Click += new System.EventHandler(this.brn_Voltar_Click_1);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.ImageKey = "image (3).png";
            this.btn_Excluir.Location = new System.Drawing.Point(45, 271);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(146, 53);
            this.btn_Excluir.TabIndex = 71;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click_1);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Alterar.Enabled = false;
            this.btn_Alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alterar.ImageKey = "image (3).png";
            this.btn_Alterar.Location = new System.Drawing.Point(45, 200);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(146, 53);
            this.btn_Alterar.TabIndex = 70;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click_1);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultar.ImageKey = "image (3).png";
            this.btn_Consultar.Location = new System.Drawing.Point(45, 126);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(146, 53);
            this.btn_Consultar.TabIndex = 69;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click_1);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Inserir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Inserir.FlatAppearance.BorderSize = 0;
            this.btn_Inserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btn_Inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inserir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.ForeColor = System.Drawing.Color.White;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inserir.ImageKey = "image (3).png";
            this.btn_Inserir.Location = new System.Drawing.Point(45, 53);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(146, 53);
            this.btn_Inserir.TabIndex = 68;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click_1);
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Email.Location = new System.Drawing.Point(224, 277);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(279, 29);
            this.txt_Email.TabIndex = 67;
            // 
            // txt_NomeFantasia
            // 
            this.txt_NomeFantasia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_NomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NomeFantasia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeFantasia.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_NomeFantasia.Location = new System.Drawing.Point(224, 201);
            this.txt_NomeFantasia.Name = "txt_NomeFantasia";
            this.txt_NomeFantasia.Size = new System.Drawing.Size(279, 29);
            this.txt_NomeFantasia.TabIndex = 66;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.Color.White;
            this.Cidade.Location = new System.Drawing.Point(82, 352);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(83, 25);
            this.Cidade.TabIndex = 65;
            this.Cidade.Text = "Telefone";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(90, 276);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(67, 25);
            this.Email.TabIndex = 64;
            this.Email.Text = "E-Mail";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.White;
            this.Telefone.Location = new System.Drawing.Point(55, 200);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(136, 25);
            this.Telefone.TabIndex = 63;
            this.Telefone.Text = "Nome Fantasia";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.White;
            this.Nome.Location = new System.Drawing.Point(64, 124);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(118, 25);
            this.Nome.TabIndex = 62;
            this.Nome.Text = "Razão Social";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(96, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(55, 25);
            this.ID.TabIndex = 61;
            this.ID.Text = "CNPJ";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // txt_RazaoSocial
            // 
            this.txt_RazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_RazaoSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RazaoSocial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RazaoSocial.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_RazaoSocial.Location = new System.Drawing.Point(224, 125);
            this.txt_RazaoSocial.Name = "txt_RazaoSocial";
            this.txt_RazaoSocial.Size = new System.Drawing.Size(279, 29);
            this.txt_RazaoSocial.TabIndex = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.brn_Voltar);
            this.panel1.Controls.Add(this.btn_Inserir);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Consultar);
            this.panel1.Controls.Add(this.btn_Alterar);
            this.panel1.Location = new System.Drawing.Point(569, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 457);
            this.panel1.TabIndex = 78;
            // 
            // Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mkt_CNPJ);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_RazaoSocial);
            this.Controls.Add(this.txt_NomeFantasia);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Name = "Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fornecedores";
            this.Load += new System.EventHandler(this.Fornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkt_CNPJ;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.Button brn_Voltar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_NomeFantasia;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_RazaoSocial;
        private System.Windows.Forms.Panel panel1;
    }
}