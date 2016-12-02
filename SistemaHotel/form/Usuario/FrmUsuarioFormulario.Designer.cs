namespace SistemaHotel.form.Usuarios
{
    partial class FrmUsuarioFormulario
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
            this.pnlInformacoes = new System.Windows.Forms.Panel();
            this.txtMorador_id = new System.Windows.Forms.MaskedTextBox();
            this.txtPerfil_id = new System.Windows.Forms.MaskedTextBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.btnPesquisaMorador = new System.Windows.Forms.Button();
            this.btnPesquisaPerfil = new System.Windows.Forms.Button();
            this.lblmorador_id = new System.Windows.Forms.Label();
            this.lblPerfil_id = new System.Windows.Forms.Label();
            this.txtSenha_confirmacao = new System.Windows.Forms.TextBox();
            this.lblSenha_confirmacao = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtMorador_nome = new System.Windows.Forms.TextBox();
            this.txtPerfil_nome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlInformacoes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.txtMorador_id);
            this.pnlInformacoes.Controls.Add(this.txtPerfil_id);
            this.pnlInformacoes.Controls.Add(this.lblExcluir);
            this.pnlInformacoes.Controls.Add(this.btnPesquisaMorador);
            this.pnlInformacoes.Controls.Add(this.btnPesquisaPerfil);
            this.pnlInformacoes.Controls.Add(this.lblmorador_id);
            this.pnlInformacoes.Controls.Add(this.lblPerfil_id);
            this.pnlInformacoes.Controls.Add(this.txtSenha_confirmacao);
            this.pnlInformacoes.Controls.Add(this.lblSenha_confirmacao);
            this.pnlInformacoes.Controls.Add(this.txtSenha);
            this.pnlInformacoes.Controls.Add(this.lblSenha);
            this.pnlInformacoes.Controls.Add(this.txtMorador_nome);
            this.pnlInformacoes.Controls.Add(this.txtPerfil_nome);
            this.pnlInformacoes.Controls.Add(this.txtEmail);
            this.pnlInformacoes.Controls.Add(this.lblEmail);
            this.pnlInformacoes.Controls.Add(this.txtCelular);
            this.pnlInformacoes.Controls.Add(this.lblCelular);
            this.pnlInformacoes.Controls.Add(this.txtTelefone);
            this.pnlInformacoes.Controls.Add(this.lblTelefone);
            this.pnlInformacoes.Controls.Add(this.txtCpf);
            this.pnlInformacoes.Controls.Add(this.lblCpf);
            this.pnlInformacoes.Controls.Add(this.txtNome);
            this.pnlInformacoes.Controls.Add(this.lblNome);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(509, 418);
            this.pnlInformacoes.TabIndex = 2;
            // 
            // txtMorador_id
            // 
            this.txtMorador_id.Location = new System.Drawing.Point(6, 380);
            this.txtMorador_id.Mask = "00000";
            this.txtMorador_id.Name = "txtMorador_id";
            this.txtMorador_id.Size = new System.Drawing.Size(65, 20);
            this.txtMorador_id.TabIndex = 42;
            this.txtMorador_id.Validated += new System.EventHandler(this.txtMorador_id_Validated);
            // 
            // txtPerfil_id
            // 
            this.txtPerfil_id.Location = new System.Drawing.Point(6, 332);
            this.txtPerfil_id.Mask = "00000";
            this.txtPerfil_id.Name = "txtPerfil_id";
            this.txtPerfil_id.Size = new System.Drawing.Size(65, 20);
            this.txtPerfil_id.TabIndex = 42;
            this.txtPerfil_id.Validated += new System.EventHandler(this.txtPerfil_id_Validated);
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Red;
            this.lblExcluir.Location = new System.Drawing.Point(3, 7);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(210, 17);
            this.lblExcluir.TabIndex = 34;
            this.lblExcluir.Text = "Confirma a deleção do registro?";
            this.lblExcluir.Visible = false;
            // 
            // btnPesquisaMorador
            // 
            this.btnPesquisaMorador.Location = new System.Drawing.Point(79, 380);
            this.btnPesquisaMorador.Name = "btnPesquisaMorador";
            this.btnPesquisaMorador.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaMorador.TabIndex = 33;
            this.btnPesquisaMorador.Text = "P";
            this.btnPesquisaMorador.UseVisualStyleBackColor = true;
            this.btnPesquisaMorador.Click += new System.EventHandler(this.btnPesquisaMorador_Click);
            // 
            // btnPesquisaPerfil
            // 
            this.btnPesquisaPerfil.Location = new System.Drawing.Point(79, 332);
            this.btnPesquisaPerfil.Name = "btnPesquisaPerfil";
            this.btnPesquisaPerfil.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaPerfil.TabIndex = 32;
            this.btnPesquisaPerfil.Text = "P";
            this.btnPesquisaPerfil.UseVisualStyleBackColor = true;
            this.btnPesquisaPerfil.Click += new System.EventHandler(this.btnPesquisaPerfil_Click);
            // 
            // lblmorador_id
            // 
            this.lblmorador_id.AutoSize = true;
            this.lblmorador_id.Location = new System.Drawing.Point(3, 363);
            this.lblmorador_id.Name = "lblmorador_id";
            this.lblmorador_id.Size = new System.Drawing.Size(46, 13);
            this.lblmorador_id.TabIndex = 29;
            this.lblmorador_id.Text = "Morador";
            // 
            // lblPerfil_id
            // 
            this.lblPerfil_id.AutoSize = true;
            this.lblPerfil_id.Location = new System.Drawing.Point(3, 316);
            this.lblPerfil_id.Name = "lblPerfil_id";
            this.lblPerfil_id.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil_id.TabIndex = 28;
            this.lblPerfil_id.Text = "Perfil";
            // 
            // txtSenha_confirmacao
            // 
            this.txtSenha_confirmacao.Location = new System.Drawing.Point(181, 286);
            this.txtSenha_confirmacao.Name = "txtSenha_confirmacao";
            this.txtSenha_confirmacao.PasswordChar = '*';
            this.txtSenha_confirmacao.Size = new System.Drawing.Size(172, 20);
            this.txtSenha_confirmacao.TabIndex = 13;
            // 
            // lblSenha_confirmacao
            // 
            this.lblSenha_confirmacao.AutoSize = true;
            this.lblSenha_confirmacao.Location = new System.Drawing.Point(178, 270);
            this.lblSenha_confirmacao.Name = "lblSenha_confirmacao";
            this.lblSenha_confirmacao.Size = new System.Drawing.Size(98, 13);
            this.lblSenha_confirmacao.TabIndex = 12;
            this.lblSenha_confirmacao.Tag = "";
            this.lblSenha_confirmacao.Text = "Confirmação senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(6, 286);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(168, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(3, 270);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 12;
            this.lblSenha.Tag = "";
            this.lblSenha.Text = "Senha";
            // 
            // txtMorador_nome
            // 
            this.txtMorador_nome.Location = new System.Drawing.Point(105, 380);
            this.txtMorador_nome.Name = "txtMorador_nome";
            this.txtMorador_nome.Size = new System.Drawing.Size(247, 20);
            this.txtMorador_nome.TabIndex = 11;
            // 
            // txtPerfil_nome
            // 
            this.txtPerfil_nome.Location = new System.Drawing.Point(105, 332);
            this.txtPerfil_nome.Name = "txtPerfil_nome";
            this.txtPerfil_nome.Size = new System.Drawing.Size(247, 20);
            this.txtPerfil_nome.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 235);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(346, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Tag = "";
            this.lblEmail.Text = "Email";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(180, 187);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(172, 20);
            this.txtCelular.TabIndex = 9;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(177, 171);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 8;
            this.lblCelular.Tag = "";
            this.lblCelular.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 187);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(168, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(3, 171);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Tag = "";
            this.lblTelefone.Text = "Telefone";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(6, 138);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(158, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(3, 122);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Tag = "";
            this.lblCpf.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 94);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(346, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 79);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Tag = "";
            this.lblNome.Text = "Nome";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 31);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "";
            this.lblId.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(377, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 418);
            this.panel1.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, 46);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 36);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 36);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmUsuarioFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.FrmUsuarioFormulario_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblmorador_id;
        private System.Windows.Forms.Label lblPerfil_id;
        private System.Windows.Forms.Button btnPesquisaMorador;
        private System.Windows.Forms.Button btnPesquisaPerfil;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.TextBox txtMorador_nome;
        private System.Windows.Forms.TextBox txtPerfil_nome;
        private System.Windows.Forms.TextBox txtSenha_confirmacao;
        private System.Windows.Forms.Label lblSenha_confirmacao;
        private System.Windows.Forms.MaskedTextBox txtMorador_id;
        private System.Windows.Forms.MaskedTextBox txtPerfil_id;
    }
}