namespace GlobalMenu
{
    partial class Cadastro
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
            this.ID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.brn_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.mkt_DN = new System.Windows.Forms.MaskedTextBox();
            this.mkt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.mkt_CPFF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.White;
            this.ID.Location = new System.Drawing.Point(47, 44);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(44, 25);
            this.ID.TabIndex = 0;
            this.ID.Text = "CPF";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.White;
            this.Nome.Location = new System.Drawing.Point(40, 115);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(63, 25);
            this.Nome.TabIndex = 42;
            this.Nome.Text = "Nome";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.White;
            this.Telefone.Location = new System.Drawing.Point(28, 197);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(83, 25);
            this.Telefone.TabIndex = 43;
            this.Telefone.Text = "Telefone";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(36, 276);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(67, 25);
            this.Email.TabIndex = 44;
            this.Email.Text = "E-Mail";
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.Color.White;
            this.Cidade.Location = new System.Drawing.Point(40, 349);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(51, 25);
            this.Cidade.TabIndex = 45;
            this.Cidade.Text = "Data";
            this.Cidade.Click += new System.EventHandler(this.Cidade_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Nome.Location = new System.Drawing.Point(140, 111);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(279, 29);
            this.txt_Nome.TabIndex = 47;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_email.Location = new System.Drawing.Point(140, 272);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(279, 29);
            this.txt_email.TabIndex = 49;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Inserir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Inserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inserir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.ForeColor = System.Drawing.Color.White;
            this.btn_Inserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Inserir.ImageKey = "image (3).png";
            this.btn_Inserir.Location = new System.Drawing.Point(549, 44);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(146, 53);
            this.btn_Inserir.TabIndex = 52;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Consultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Consultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Consultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.ForeColor = System.Drawing.Color.White;
            this.btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultar.ImageKey = "image (3).png";
            this.btn_Consultar.Location = new System.Drawing.Point(549, 117);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(146, 53);
            this.btn_Consultar.TabIndex = 53;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.Color.White;
            this.btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alterar.ImageKey = "image (3).png";
            this.btn_Alterar.Location = new System.Drawing.Point(549, 191);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(146, 53);
            this.btn_Alterar.TabIndex = 54;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Excluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.ImageKey = "image (3).png";
            this.btn_Excluir.Location = new System.Drawing.Point(549, 262);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(146, 53);
            this.btn_Excluir.TabIndex = 55;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // brn_Voltar
            // 
            this.brn_Voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.brn_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.brn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.brn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.brn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_Voltar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Voltar.ForeColor = System.Drawing.Color.White;
            this.brn_Voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brn_Voltar.ImageKey = "image (3).png";
            this.brn_Voltar.Location = new System.Drawing.Point(549, 329);
            this.brn_Voltar.Name = "brn_Voltar";
            this.brn_Voltar.Size = new System.Drawing.Size(146, 53);
            this.brn_Voltar.TabIndex = 56;
            this.brn_Voltar.Text = "Voltar";
            this.brn_Voltar.UseVisualStyleBackColor = false;
            this.brn_Voltar.Click += new System.EventHandler(this.brn_Voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nascimento";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Telefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Telefone.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_Telefone.Location = new System.Drawing.Point(140, 198);
            this.txt_Telefone.Mask = "(99) 99999-9999";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(135, 29);
            this.txt_Telefone.TabIndex = 58;
            // 
            // mkt_DN
            // 
            this.mkt_DN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mkt_DN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkt_DN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mkt_DN.ForeColor = System.Drawing.SystemColors.Window;
            this.mkt_DN.Location = new System.Drawing.Point(140, 353);
            this.mkt_DN.Mask = "99/99/9999";
            this.mkt_DN.Name = "mkt_DN";
            this.mkt_DN.Size = new System.Drawing.Size(135, 29);
            this.mkt_DN.TabIndex = 59;
            // 
            // mkt_CPF
            // 
            this.mkt_CPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mkt_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkt_CPF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mkt_CPF.ForeColor = System.Drawing.SystemColors.Window;
            this.mkt_CPF.Location = new System.Drawing.Point(140, 44);
            this.mkt_CPF.Mask = "999.999.999-99";
            this.mkt_CPF.Name = "mkt_CPF";
            this.mkt_CPF.Size = new System.Drawing.Size(135, 29);
            this.mkt_CPF.TabIndex = 60;
            // 
            // mkt_CPFF
            // 
            this.mkt_CPFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mkt_CPFF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mkt_CPFF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mkt_CPFF.ForeColor = System.Drawing.SystemColors.Window;
            this.mkt_CPFF.Location = new System.Drawing.Point(140, 44);
            this.mkt_CPFF.Mask = "999.999.999-99";
            this.mkt_CPFF.Name = "mkt_CPFF";
            this.mkt_CPFF.Size = new System.Drawing.Size(135, 29);
            this.mkt_CPFF.TabIndex = 60;
            this.mkt_CPFF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(25)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mkt_CPFF);
            this.Controls.Add(this.mkt_CPF);
            this.Controls.Add(this.mkt_DN);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brn_Voltar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ID);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button brn_Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.MaskedTextBox mkt_DN;
        private System.Windows.Forms.MaskedTextBox mkt_CPF;
        private System.Windows.Forms.MaskedTextBox mkt_CPFF;
    }
}