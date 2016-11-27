namespace SistemaHotel.form.Procedimento
{
    partial class FrmProcedimentoCorpo
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.tabAbas = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tabPassos = new System.Windows.Forms.TabPage();
            this.pnlProdutos_utilizados = new System.Windows.Forms.GroupBox();
            this.gridProdutos_utilizados = new System.Windows.Forms.DataGridView();
            this.gridPassos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_passo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordem_execucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotoes.SuspendLayout();
            this.pnlCorpo.SuspendLayout();
            this.tabAbas.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabPassos.SuspendLayout();
            this.pnlProdutos_utilizados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos_utilizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPassos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(482, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 306);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(4, 46);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 36);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(4, 214);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 36);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(4, 172);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 36);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(4, 130);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 36);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(4, 88);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(126, 36);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 36);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // pnlCorpo
            // 
            this.pnlCorpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCorpo.Controls.Add(this.tabAbas);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Size = new System.Drawing.Size(482, 306);
            this.pnlCorpo.TabIndex = 8;
            // 
            // tabAbas
            // 
            this.tabAbas.Controls.Add(this.tabPrincipal);
            this.tabAbas.Controls.Add(this.tabPassos);
            this.tabAbas.Location = new System.Drawing.Point(15, 11);
            this.tabAbas.Name = "tabAbas";
            this.tabAbas.SelectedIndex = 0;
            this.tabAbas.Size = new System.Drawing.Size(459, 288);
            this.tabAbas.TabIndex = 12;
            this.tabAbas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabAbas_Selected);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.txtDescricao);
            this.tabPrincipal.Controls.Add(this.lblDescricao);
            this.tabPrincipal.Controls.Add(this.txtID);
            this.tabPrincipal.Controls.Add(this.lblId);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(451, 262);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(14, 114);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(313, 20);
            this.txtDescricao.TabIndex = 35;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(11, 97);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 34;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(14, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 33;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "ID";
            // 
            // tabPassos
            // 
            this.tabPassos.Controls.Add(this.pnlProdutos_utilizados);
            this.tabPassos.Controls.Add(this.gridPassos);
            this.tabPassos.Location = new System.Drawing.Point(4, 22);
            this.tabPassos.Name = "tabPassos";
            this.tabPassos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPassos.Size = new System.Drawing.Size(451, 262);
            this.tabPassos.TabIndex = 1;
            this.tabPassos.Text = "Passos";
            this.tabPassos.UseVisualStyleBackColor = true;
            // 
            // pnlProdutos_utilizados
            // 
            this.pnlProdutos_utilizados.Controls.Add(this.gridProdutos_utilizados);
            this.pnlProdutos_utilizados.Location = new System.Drawing.Point(6, 124);
            this.pnlProdutos_utilizados.Name = "pnlProdutos_utilizados";
            this.pnlProdutos_utilizados.Size = new System.Drawing.Size(433, 132);
            this.pnlProdutos_utilizados.TabIndex = 13;
            this.pnlProdutos_utilizados.TabStop = false;
            this.pnlProdutos_utilizados.Text = "Produtos utilizados no passo";
            // 
            // gridProdutos_utilizados
            // 
            this.gridProdutos_utilizados.AllowUserToAddRows = false;
            this.gridProdutos_utilizados.AllowUserToDeleteRows = false;
            this.gridProdutos_utilizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdutos_utilizados.Location = new System.Drawing.Point(6, 19);
            this.gridProdutos_utilizados.Name = "gridProdutos_utilizados";
            this.gridProdutos_utilizados.ReadOnly = true;
            this.gridProdutos_utilizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdutos_utilizados.Size = new System.Drawing.Size(421, 107);
            this.gridProdutos_utilizados.TabIndex = 13;
            this.gridProdutos_utilizados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdutos_utilizados_CellClick);
            // 
            // gridPassos
            // 
            this.gridPassos.AllowUserToAddRows = false;
            this.gridPassos.AllowUserToDeleteRows = false;
            this.gridPassos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPassos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao_passo,
            this.ordem_execucao});
            this.gridPassos.Location = new System.Drawing.Point(12, 13);
            this.gridPassos.Name = "gridPassos";
            this.gridPassos.ReadOnly = true;
            this.gridPassos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPassos.Size = new System.Drawing.Size(427, 106);
            this.gridPassos.TabIndex = 12;
            this.gridPassos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPassos_CellClick);
            this.gridPassos.SelectionChanged += new System.EventHandler(this.gridPassos_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // descricao_passo
            // 
            this.descricao_passo.DataPropertyName = "descricao_passo";
            this.descricao_passo.HeaderText = "Descrição do passo";
            this.descricao_passo.Name = "descricao_passo";
            this.descricao_passo.ReadOnly = true;
            this.descricao_passo.Width = 200;
            // 
            // ordem_execucao
            // 
            this.ordem_execucao.DataPropertyName = "ordem_execucao";
            this.ordem_execucao.HeaderText = "Ordem execução";
            this.ordem_execucao.Name = "ordem_execucao";
            this.ordem_execucao.ReadOnly = true;
            // 
            // FrmProcedimentoCorpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 306);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCorpo);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcedimentoCorpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedimento";
            this.Load += new System.EventHandler(this.FrmProcedimento_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCorpo.ResumeLayout(false);
            this.tabAbas.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.tabPassos.ResumeLayout(false);
            this.pnlProdutos_utilizados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProdutos_utilizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPassos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pnlCorpo;
        private System.Windows.Forms.TabControl tabAbas;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabPassos;
        private System.Windows.Forms.GroupBox pnlProdutos_utilizados;
        private System.Windows.Forms.DataGridView gridProdutos_utilizados;
        private System.Windows.Forms.DataGridView gridPassos;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_passo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordem_execucao;
    }
}