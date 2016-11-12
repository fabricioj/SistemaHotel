namespace SistemaHotel.form.Orcamento
{
    partial class FrmOrcamentoCorpo
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tabAbas = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.txtFornecedor_nome = new System.Windows.Forms.TextBox();
            this.lblFornecedor_nome = new System.Windows.Forms.Label();
            this.txtAtividade_nome = new System.Windows.Forms.TextBox();
            this.txtFornecedor_id = new System.Windows.Forms.TextBox();
            this.lblAtividade_nome = new System.Windows.Forms.Label();
            this.lblFornecedor_id = new System.Windows.Forms.Label();
            this.txtAtividade_id = new System.Windows.Forms.TextBox();
            this.lblAtidade_id = new System.Windows.Forms.Label();
            this.lblData_confirmacao = new System.Windows.Forms.Label();
            this.lblData_emissao = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tabItens = new System.Windows.Forms.TabPage();
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.txtData_emissao = new System.Windows.Forms.DateTimePicker();
            this.txtData_confirmacao = new System.Windows.Forms.DateTimePicker();
            this.pnlBotoes.SuspendLayout();
            this.tabAbas.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlBotoes.Location = new System.Drawing.Point(456, 13);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 270);
            this.pnlBotoes.TabIndex = 8;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, 45);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 36);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(126, 36);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(4, 213);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 36);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(4, 171);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 36);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(4, 129);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 36);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(4, 87);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(126, 36);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tabAbas
            // 
            this.tabAbas.Controls.Add(this.tabPrincipal);
            this.tabAbas.Controls.Add(this.tabItens);
            this.tabAbas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabAbas.Location = new System.Drawing.Point(13, 13);
            this.tabAbas.Name = "tabAbas";
            this.tabAbas.SelectedIndex = 0;
            this.tabAbas.Size = new System.Drawing.Size(437, 268);
            this.tabAbas.TabIndex = 9;
            this.tabAbas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabAbas_Selected);
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.txtData_emissao);
            this.tabPrincipal.Controls.Add(this.txtData_confirmacao);
            this.tabPrincipal.Controls.Add(this.txtFornecedor_nome);
            this.tabPrincipal.Controls.Add(this.lblFornecedor_nome);
            this.tabPrincipal.Controls.Add(this.txtAtividade_nome);
            this.tabPrincipal.Controls.Add(this.txtFornecedor_id);
            this.tabPrincipal.Controls.Add(this.lblAtividade_nome);
            this.tabPrincipal.Controls.Add(this.lblFornecedor_id);
            this.tabPrincipal.Controls.Add(this.txtAtividade_id);
            this.tabPrincipal.Controls.Add(this.lblAtidade_id);
            this.tabPrincipal.Controls.Add(this.lblData_confirmacao);
            this.tabPrincipal.Controls.Add(this.lblData_emissao);
            this.tabPrincipal.Controls.Add(this.txtID);
            this.tabPrincipal.Controls.Add(this.lblId);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(429, 242);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // txtFornecedor_nome
            // 
            this.txtFornecedor_nome.Location = new System.Drawing.Point(117, 83);
            this.txtFornecedor_nome.Name = "txtFornecedor_nome";
            this.txtFornecedor_nome.Size = new System.Drawing.Size(259, 20);
            this.txtFornecedor_nome.TabIndex = 36;
            // 
            // lblFornecedor_nome
            // 
            this.lblFornecedor_nome.AutoSize = true;
            this.lblFornecedor_nome.Location = new System.Drawing.Point(114, 66);
            this.lblFornecedor_nome.Name = "lblFornecedor_nome";
            this.lblFornecedor_nome.Size = new System.Drawing.Size(35, 13);
            this.lblFornecedor_nome.TabIndex = 29;
            this.lblFornecedor_nome.Text = "Nome";
            // 
            // txtAtividade_nome
            // 
            this.txtAtividade_nome.Location = new System.Drawing.Point(117, 132);
            this.txtAtividade_nome.Name = "txtAtividade_nome";
            this.txtAtividade_nome.Size = new System.Drawing.Size(259, 20);
            this.txtAtividade_nome.TabIndex = 37;
            // 
            // txtFornecedor_id
            // 
            this.txtFornecedor_id.Location = new System.Drawing.Point(19, 83);
            this.txtFornecedor_id.Name = "txtFornecedor_id";
            this.txtFornecedor_id.Size = new System.Drawing.Size(65, 20);
            this.txtFornecedor_id.TabIndex = 38;
            // 
            // lblAtividade_nome
            // 
            this.lblAtividade_nome.AutoSize = true;
            this.lblAtividade_nome.Location = new System.Drawing.Point(114, 115);
            this.lblAtividade_nome.Name = "lblAtividade_nome";
            this.lblAtividade_nome.Size = new System.Drawing.Size(35, 13);
            this.lblAtividade_nome.TabIndex = 30;
            this.lblAtividade_nome.Text = "Nome";
            // 
            // lblFornecedor_id
            // 
            this.lblFornecedor_id.AutoSize = true;
            this.lblFornecedor_id.Location = new System.Drawing.Point(16, 66);
            this.lblFornecedor_id.Name = "lblFornecedor_id";
            this.lblFornecedor_id.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor_id.TabIndex = 31;
            this.lblFornecedor_id.Text = "Fornecedor";
            // 
            // txtAtividade_id
            // 
            this.txtAtividade_id.Location = new System.Drawing.Point(19, 132);
            this.txtAtividade_id.Name = "txtAtividade_id";
            this.txtAtividade_id.Size = new System.Drawing.Size(65, 20);
            this.txtAtividade_id.TabIndex = 39;
            // 
            // lblAtidade_id
            // 
            this.lblAtidade_id.AutoSize = true;
            this.lblAtidade_id.Location = new System.Drawing.Point(16, 115);
            this.lblAtidade_id.Name = "lblAtidade_id";
            this.lblAtidade_id.Size = new System.Drawing.Size(51, 13);
            this.lblAtidade_id.TabIndex = 32;
            this.lblAtidade_id.Text = "Atividade";
            // 
            // lblData_confirmacao
            // 
            this.lblData_confirmacao.AutoSize = true;
            this.lblData_confirmacao.Location = new System.Drawing.Point(215, 18);
            this.lblData_confirmacao.Name = "lblData_confirmacao";
            this.lblData_confirmacao.Size = new System.Drawing.Size(79, 13);
            this.lblData_confirmacao.TabIndex = 26;
            this.lblData_confirmacao.Text = "Dt confirmação";
            // 
            // lblData_emissao
            // 
            this.lblData_emissao.AutoSize = true;
            this.lblData_emissao.Location = new System.Drawing.Point(114, 18);
            this.lblData_emissao.Name = "lblData_emissao";
            this.lblData_emissao.Size = new System.Drawing.Size(59, 13);
            this.lblData_emissao.TabIndex = 27;
            this.lblData_emissao.Text = "Dt emissão";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(19, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 35;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 28;
            this.lblId.Text = "ID";
            // 
            // tabItens
            // 
            this.tabItens.Controls.Add(this.gridItens);
            this.tabItens.Location = new System.Drawing.Point(4, 22);
            this.tabItens.Name = "tabItens";
            this.tabItens.Padding = new System.Windows.Forms.Padding(3);
            this.tabItens.Size = new System.Drawing.Size(429, 242);
            this.tabItens.TabIndex = 1;
            this.tabItens.Text = "Itens";
            this.tabItens.UseVisualStyleBackColor = true;
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
            this.gridItens.AllowUserToOrderColumns = true;
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Location = new System.Drawing.Point(7, 7);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.Size = new System.Drawing.Size(416, 229);
            this.gridItens.TabIndex = 0;
            // 
            // txtData_emissao
            // 
            this.txtData_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_emissao.Location = new System.Drawing.Point(117, 35);
            this.txtData_emissao.Name = "txtData_emissao";
            this.txtData_emissao.Size = new System.Drawing.Size(82, 20);
            this.txtData_emissao.TabIndex = 40;
            // 
            // txtData_confirmacao
            // 
            this.txtData_confirmacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_confirmacao.Location = new System.Drawing.Point(218, 35);
            this.txtData_confirmacao.Name = "txtData_confirmacao";
            this.txtData_confirmacao.Size = new System.Drawing.Size(82, 20);
            this.txtData_confirmacao.TabIndex = 41;
            // 
            // FrmOrcamentoCorpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 293);
            this.ControlBox = false;
            this.Controls.Add(this.tabAbas);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrcamentoCorpo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.FrmOrcamentoCorpo_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.tabAbas.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.tabItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TabControl tabAbas;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabItens;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.TextBox txtFornecedor_nome;
        private System.Windows.Forms.Label lblFornecedor_nome;
        private System.Windows.Forms.TextBox txtAtividade_nome;
        private System.Windows.Forms.TextBox txtFornecedor_id;
        private System.Windows.Forms.Label lblAtividade_nome;
        private System.Windows.Forms.Label lblFornecedor_id;
        private System.Windows.Forms.TextBox txtAtividade_id;
        private System.Windows.Forms.Label lblAtidade_id;
        private System.Windows.Forms.Label lblData_confirmacao;
        private System.Windows.Forms.Label lblData_emissao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker txtData_emissao;
        private System.Windows.Forms.DateTimePicker txtData_confirmacao;
    }
}