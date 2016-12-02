namespace SistemaHotel
{
    partial class FrmSistemaHotel
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
            this.mnuSistema = new System.Windows.Forms.MenuStrip();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcedimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAreasComuns = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSolicitacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservasAreasComuns = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtividades = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOrcamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeContasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPerfis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrocaSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSistema
            // 
            this.mnuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastros,
            this.mnuMovimentos,
            this.gestãoDeContasToolStripMenuItem});
            this.mnuSistema.Location = new System.Drawing.Point(0, 0);
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(784, 24);
            this.mnuSistema.TabIndex = 0;
            this.mnuSistema.Text = "menuStrip1";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProdutos,
            this.toolStripSeparator1,
            this.mnuFornecedores,
            this.toolStripSeparator2,
            this.mnuFuncionarios,
            this.mnuProcedimentos,
            this.toolStripSeparator3,
            this.mnuAreasComuns});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.Size = new System.Drawing.Size(154, 22);
            this.mnuProdutos.Text = "Produtos";
            this.mnuProdutos.Click += new System.EventHandler(this.mnuProdutos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuFornecedores
            // 
            this.mnuFornecedores.Name = "mnuFornecedores";
            this.mnuFornecedores.Size = new System.Drawing.Size(154, 22);
            this.mnuFornecedores.Text = "Fornecedores";
            this.mnuFornecedores.Click += new System.EventHandler(this.mnuFornecedores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuFuncionarios
            // 
            this.mnuFuncionarios.Name = "mnuFuncionarios";
            this.mnuFuncionarios.Size = new System.Drawing.Size(154, 22);
            this.mnuFuncionarios.Text = "Funcionários";
            this.mnuFuncionarios.Click += new System.EventHandler(this.mnuFuncionarios_Click);
            // 
            // mnuProcedimentos
            // 
            this.mnuProcedimentos.Name = "mnuProcedimentos";
            this.mnuProcedimentos.Size = new System.Drawing.Size(154, 22);
            this.mnuProcedimentos.Text = "Procedimentos";
            this.mnuProcedimentos.Click += new System.EventHandler(this.mnuProcedimentos_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
            // 
            // mnuAreasComuns
            // 
            this.mnuAreasComuns.Name = "mnuAreasComuns";
            this.mnuAreasComuns.Size = new System.Drawing.Size(154, 22);
            this.mnuAreasComuns.Text = "Áreas comuns";
            this.mnuAreasComuns.Click += new System.EventHandler(this.mnuAreasComuns_Click);
            // 
            // mnuMovimentos
            // 
            this.mnuMovimentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSolicitacoes,
            this.mnuReservasAreasComuns,
            this.mnuAtividades,
            this.toolStripSeparator4,
            this.mnuOrcamentos});
            this.mnuMovimentos.Name = "mnuMovimentos";
            this.mnuMovimentos.Size = new System.Drawing.Size(86, 20);
            this.mnuMovimentos.Text = "Movimentos";
            // 
            // mnuSolicitacoes
            // 
            this.mnuSolicitacoes.Name = "mnuSolicitacoes";
            this.mnuSolicitacoes.Size = new System.Drawing.Size(211, 22);
            this.mnuSolicitacoes.Text = "Solicitações";
            this.mnuSolicitacoes.Click += new System.EventHandler(this.mnuSolicitacoes_Click);
            // 
            // mnuReservasAreasComuns
            // 
            this.mnuReservasAreasComuns.Name = "mnuReservasAreasComuns";
            this.mnuReservasAreasComuns.Size = new System.Drawing.Size(211, 22);
            this.mnuReservasAreasComuns.Text = "Reservas de áreas comuns";
            this.mnuReservasAreasComuns.Click += new System.EventHandler(this.mnuReservasAreasComuns_Click);
            // 
            // mnuAtividades
            // 
            this.mnuAtividades.Name = "mnuAtividades";
            this.mnuAtividades.Size = new System.Drawing.Size(211, 22);
            this.mnuAtividades.Text = "Atividades";
            this.mnuAtividades.Click += new System.EventHandler(this.mnuAtividades_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(208, 6);
            // 
            // mnuOrcamentos
            // 
            this.mnuOrcamentos.Name = "mnuOrcamentos";
            this.mnuOrcamentos.Size = new System.Drawing.Size(211, 22);
            this.mnuOrcamentos.Text = "Orçamentos";
            this.mnuOrcamentos.Click += new System.EventHandler(this.mnuOrcamentos_Click);
            // 
            // gestãoDeContasToolStripMenuItem
            // 
            this.gestãoDeContasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFuncionalidades,
            this.toolStripSeparator5,
            this.mnuPerfis,
            this.mnuUsuarios,
            this.toolStripSeparator6,
            this.mnuTrocaUsuario,
            this.mnuTrocaSenha});
            this.gestãoDeContasToolStripMenuItem.Name = "gestãoDeContasToolStripMenuItem";
            this.gestãoDeContasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestãoDeContasToolStripMenuItem.Text = "Gestão de contas";
            // 
            // mnuFuncionalidades
            // 
            this.mnuFuncionalidades.Name = "mnuFuncionalidades";
            this.mnuFuncionalidades.Size = new System.Drawing.Size(161, 22);
            this.mnuFuncionalidades.Text = "Funcionalidades";
            this.mnuFuncionalidades.Click += new System.EventHandler(this.mnuFuncionalidades_Click);
            // 
            // mnuPerfis
            // 
            this.mnuPerfis.Name = "mnuPerfis";
            this.mnuPerfis.Size = new System.Drawing.Size(161, 22);
            this.mnuPerfis.Text = "Perfis";
            this.mnuPerfis.Click += new System.EventHandler(this.mnuPerfis_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(161, 22);
            this.mnuUsuarios.Text = "Usuários";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(158, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(158, 6);
            // 
            // mnuTrocaUsuario
            // 
            this.mnuTrocaUsuario.Name = "mnuTrocaUsuario";
            this.mnuTrocaUsuario.Size = new System.Drawing.Size(161, 22);
            this.mnuTrocaUsuario.Text = "Troca de usuário";
            this.mnuTrocaUsuario.Click += new System.EventHandler(this.mnuTrocaUsuario_Click);
            // 
            // mnuTrocaSenha
            // 
            this.mnuTrocaSenha.Name = "mnuTrocaSenha";
            this.mnuTrocaSenha.Size = new System.Drawing.Size(161, 22);
            this.mnuTrocaSenha.Text = "Troca de senha";
            // 
            // FrmSistemaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mnuSistema);
            this.Name = "FrmSistemaHotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema hotel";
            this.Activated += new System.EventHandler(this.FrmSistemaHotel_Activated);
            this.Load += new System.EventHandler(this.FrmSistemaHotel_Load);
            this.mnuSistema.ResumeLayout(false);
            this.mnuSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem mnuOrcamentos;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuAreasComuns;
        private System.Windows.Forms.ToolStripMenuItem mnuSolicitacoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuReservasAreasComuns;
        private System.Windows.Forms.ToolStripMenuItem mnuProcedimentos;
        private System.Windows.Forms.ToolStripMenuItem mnuAtividades;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeContasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionalidades;
        private System.Windows.Forms.ToolStripMenuItem mnuPerfis;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuTrocaSenha;
    }
}

