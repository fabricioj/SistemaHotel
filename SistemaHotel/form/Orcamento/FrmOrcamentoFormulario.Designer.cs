namespace SistemaHotel.form.Orcamento
{
    partial class FrmOrcamentoFormulario
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
            this.btnPesquisaFornecedor = new System.Windows.Forms.Button();
            this.btnPesquisaAtividade = new System.Windows.Forms.Button();
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtData_confirmacao = new System.Windows.Forms.DateTimePicker();
            this.txtData_emissao = new System.Windows.Forms.DateTimePicker();
            this.pnlInformacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.txtData_emissao);
            this.pnlInformacoes.Controls.Add(this.txtData_confirmacao);
            this.pnlInformacoes.Controls.Add(this.btnPesquisaFornecedor);
            this.pnlInformacoes.Controls.Add(this.btnPesquisaAtividade);
            this.pnlInformacoes.Controls.Add(this.txtFornecedor_nome);
            this.pnlInformacoes.Controls.Add(this.lblFornecedor_nome);
            this.pnlInformacoes.Controls.Add(this.txtAtividade_nome);
            this.pnlInformacoes.Controls.Add(this.txtFornecedor_id);
            this.pnlInformacoes.Controls.Add(this.lblAtividade_nome);
            this.pnlInformacoes.Controls.Add(this.lblFornecedor_id);
            this.pnlInformacoes.Controls.Add(this.txtAtividade_id);
            this.pnlInformacoes.Controls.Add(this.lblAtidade_id);
            this.pnlInformacoes.Controls.Add(this.lblData_confirmacao);
            this.pnlInformacoes.Controls.Add(this.lblData_emissao);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Location = new System.Drawing.Point(12, 12);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(397, 177);
            this.pnlInformacoes.TabIndex = 6;
            // 
            // btnPesquisaFornecedor
            // 
            this.btnPesquisaFornecedor.Location = new System.Drawing.Point(78, 71);
            this.btnPesquisaFornecedor.Name = "btnPesquisaFornecedor";
            this.btnPesquisaFornecedor.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaFornecedor.TabIndex = 26;
            this.btnPesquisaFornecedor.Text = "P";
            this.btnPesquisaFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisaFornecedor.Click += new System.EventHandler(this.btnPesquisaFornecedor_Click);
            // 
            // btnPesquisaAtividade
            // 
            this.btnPesquisaAtividade.Location = new System.Drawing.Point(78, 120);
            this.btnPesquisaAtividade.Name = "btnPesquisaAtividade";
            this.btnPesquisaAtividade.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaAtividade.TabIndex = 26;
            this.btnPesquisaAtividade.Text = "P";
            this.btnPesquisaAtividade.UseVisualStyleBackColor = true;
            // 
            // txtFornecedor_nome
            // 
            this.txtFornecedor_nome.Location = new System.Drawing.Point(107, 71);
            this.txtFornecedor_nome.Name = "txtFornecedor_nome";
            this.txtFornecedor_nome.Size = new System.Drawing.Size(259, 20);
            this.txtFornecedor_nome.TabIndex = 25;
            // 
            // lblFornecedor_nome
            // 
            this.lblFornecedor_nome.AutoSize = true;
            this.lblFornecedor_nome.Location = new System.Drawing.Point(104, 54);
            this.lblFornecedor_nome.Name = "lblFornecedor_nome";
            this.lblFornecedor_nome.Size = new System.Drawing.Size(35, 13);
            this.lblFornecedor_nome.TabIndex = 5;
            this.lblFornecedor_nome.Text = "Nome";
            // 
            // txtAtividade_nome
            // 
            this.txtAtividade_nome.Location = new System.Drawing.Point(107, 120);
            this.txtAtividade_nome.Name = "txtAtividade_nome";
            this.txtAtividade_nome.Size = new System.Drawing.Size(259, 20);
            this.txtAtividade_nome.TabIndex = 25;
            // 
            // txtFornecedor_id
            // 
            this.txtFornecedor_id.Location = new System.Drawing.Point(9, 71);
            this.txtFornecedor_id.Name = "txtFornecedor_id";
            this.txtFornecedor_id.Size = new System.Drawing.Size(65, 20);
            this.txtFornecedor_id.TabIndex = 25;
            this.txtFornecedor_id.Validated += new System.EventHandler(this.txtFornecedor_id_Validated);
            // 
            // lblAtividade_nome
            // 
            this.lblAtividade_nome.AutoSize = true;
            this.lblAtividade_nome.Location = new System.Drawing.Point(104, 103);
            this.lblAtividade_nome.Name = "lblAtividade_nome";
            this.lblAtividade_nome.Size = new System.Drawing.Size(35, 13);
            this.lblAtividade_nome.TabIndex = 5;
            this.lblAtividade_nome.Text = "Nome";
            // 
            // lblFornecedor_id
            // 
            this.lblFornecedor_id.AutoSize = true;
            this.lblFornecedor_id.Location = new System.Drawing.Point(6, 54);
            this.lblFornecedor_id.Name = "lblFornecedor_id";
            this.lblFornecedor_id.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor_id.TabIndex = 5;
            this.lblFornecedor_id.Text = "Fornecedor";
            // 
            // txtAtividade_id
            // 
            this.txtAtividade_id.Location = new System.Drawing.Point(9, 120);
            this.txtAtividade_id.Name = "txtAtividade_id";
            this.txtAtividade_id.Size = new System.Drawing.Size(65, 20);
            this.txtAtividade_id.TabIndex = 25;
            // 
            // lblAtidade_id
            // 
            this.lblAtidade_id.AutoSize = true;
            this.lblAtidade_id.Location = new System.Drawing.Point(6, 103);
            this.lblAtidade_id.Name = "lblAtidade_id";
            this.lblAtidade_id.Size = new System.Drawing.Size(51, 13);
            this.lblAtidade_id.TabIndex = 5;
            this.lblAtidade_id.Text = "Atividade";
            // 
            // lblData_confirmacao
            // 
            this.lblData_confirmacao.AutoSize = true;
            this.lblData_confirmacao.Location = new System.Drawing.Point(205, 6);
            this.lblData_confirmacao.Name = "lblData_confirmacao";
            this.lblData_confirmacao.Size = new System.Drawing.Size(79, 13);
            this.lblData_confirmacao.TabIndex = 4;
            this.lblData_confirmacao.Text = "Dt confirmação";
            // 
            // lblData_emissao
            // 
            this.lblData_emissao.AutoSize = true;
            this.lblData_emissao.Location = new System.Drawing.Point(104, 6);
            this.lblData_emissao.Name = "lblData_emissao";
            this.lblData_emissao.Size = new System.Drawing.Size(59, 13);
            this.lblData_emissao.TabIndex = 4;
            this.lblData_emissao.Text = "Dt emissão";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(9, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Location = new System.Drawing.Point(415, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 177);
            this.pnlBotoes.TabIndex = 5;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(4, 46);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 36);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
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
            // txtData_confirmacao
            // 
            this.txtData_confirmacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_confirmacao.Location = new System.Drawing.Point(208, 23);
            this.txtData_confirmacao.Name = "txtData_confirmacao";
            this.txtData_confirmacao.Size = new System.Drawing.Size(82, 20);
            this.txtData_confirmacao.TabIndex = 27;
            // 
            // txtData_emissao
            // 
            this.txtData_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_emissao.Location = new System.Drawing.Point(107, 23);
            this.txtData_emissao.Name = "txtData_emissao";
            this.txtData_emissao.Size = new System.Drawing.Size(82, 20);
            this.txtData_emissao.TabIndex = 27;
            // 
            // FrmOrcamentoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 201);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrcamentoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.FrmOrcamentoFormulario_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.TextBox txtAtividade_id;
        private System.Windows.Forms.Label lblAtidade_id;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblData_confirmacao;
        private System.Windows.Forms.Label lblData_emissao;
        private System.Windows.Forms.Button btnPesquisaAtividade;
        private System.Windows.Forms.TextBox txtAtividade_nome;
        private System.Windows.Forms.Label lblAtividade_nome;
        private System.Windows.Forms.Button btnPesquisaFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor_nome;
        private System.Windows.Forms.Label lblFornecedor_nome;
        private System.Windows.Forms.TextBox txtFornecedor_id;
        private System.Windows.Forms.Label lblFornecedor_id;
        private System.Windows.Forms.DateTimePicker txtData_emissao;
        private System.Windows.Forms.DateTimePicker txtData_confirmacao;
    }
}