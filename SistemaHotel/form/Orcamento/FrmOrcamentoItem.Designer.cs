namespace SistemaHotel.form.Orcamento
{
    partial class FrmOrcamentoItem
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
            this.lblExcluir = new System.Windows.Forms.Label();
            this.txtProduto_id = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtProduto_descricao = new System.Windows.Forms.TextBox();
            this.lblProduto_descricao = new System.Windows.Forms.Label();
            this.lblProduto_id = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade_comprada = new System.Windows.Forms.TextBox();
            this.lblQuantidade_comprada = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlInformacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.lblExcluir);
            this.pnlInformacoes.Controls.Add(this.txtProduto_id);
            this.pnlInformacoes.Controls.Add(this.btnPesquisaProduto);
            this.pnlInformacoes.Controls.Add(this.txtObservacao);
            this.pnlInformacoes.Controls.Add(this.lblObservacao);
            this.pnlInformacoes.Controls.Add(this.txtProduto_descricao);
            this.pnlInformacoes.Controls.Add(this.lblProduto_descricao);
            this.pnlInformacoes.Controls.Add(this.lblProduto_id);
            this.pnlInformacoes.Controls.Add(this.txtTotal);
            this.pnlInformacoes.Controls.Add(this.lblTotal);
            this.pnlInformacoes.Controls.Add(this.txtValor);
            this.pnlInformacoes.Controls.Add(this.lblValor);
            this.pnlInformacoes.Controls.Add(this.txtQuantidade_comprada);
            this.pnlInformacoes.Controls.Add(this.lblQuantidade_comprada);
            this.pnlInformacoes.Controls.Add(this.txtQuantidade);
            this.pnlInformacoes.Controls.Add(this.lblQuantidade);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(405, 349);
            this.pnlInformacoes.TabIndex = 8;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Red;
            this.lblExcluir.Location = new System.Drawing.Point(8, 4);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(210, 17);
            this.lblExcluir.TabIndex = 28;
            this.lblExcluir.Text = "Confirma a deleção do registro?";
            this.lblExcluir.Visible = false;
            // 
            // txtProduto_id
            // 
            this.txtProduto_id.Location = new System.Drawing.Point(11, 92);
            this.txtProduto_id.Mask = "00000";
            this.txtProduto_id.Name = "txtProduto_id";
            this.txtProduto_id.Size = new System.Drawing.Size(65, 20);
            this.txtProduto_id.TabIndex = 27;
            this.txtProduto_id.Validated += new System.EventHandler(this.txtProduto_id_Validated);
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Location = new System.Drawing.Point(80, 92);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaProduto.TabIndex = 26;
            this.btnPesquisaProduto.Text = "P";
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(11, 260);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(357, 46);
            this.txtObservacao.TabIndex = 25;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(8, 243);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 5;
            this.lblObservacao.Text = "Observação";
            // 
            // txtProduto_descricao
            // 
            this.txtProduto_descricao.Location = new System.Drawing.Point(109, 92);
            this.txtProduto_descricao.Name = "txtProduto_descricao";
            this.txtProduto_descricao.Size = new System.Drawing.Size(259, 20);
            this.txtProduto_descricao.TabIndex = 25;
            // 
            // lblProduto_descricao
            // 
            this.lblProduto_descricao.AutoSize = true;
            this.lblProduto_descricao.Location = new System.Drawing.Point(106, 75);
            this.lblProduto_descricao.Name = "lblProduto_descricao";
            this.lblProduto_descricao.Size = new System.Drawing.Size(55, 13);
            this.lblProduto_descricao.TabIndex = 5;
            this.lblProduto_descricao.Text = "Descrição";
            // 
            // lblProduto_id
            // 
            this.lblProduto_id.AutoSize = true;
            this.lblProduto_id.Location = new System.Drawing.Point(8, 75);
            this.lblProduto_id.Name = "lblProduto_id";
            this.lblProduto_id.Size = new System.Drawing.Size(44, 13);
            this.lblProduto_id.TabIndex = 5;
            this.lblProduto_id.Text = "Produto";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(292, 155);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTotal.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(289, 138);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(109, 155);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 20);
            this.txtValor.TabIndex = 19;
            this.txtValor.Validated += new System.EventHandler(this.txtValor_Validated);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(106, 138);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // txtQuantidade_comprada
            // 
            this.txtQuantidade_comprada.Location = new System.Drawing.Point(292, 213);
            this.txtQuantidade_comprada.Name = "txtQuantidade_comprada";
            this.txtQuantidade_comprada.Size = new System.Drawing.Size(76, 20);
            this.txtQuantidade_comprada.TabIndex = 19;
            // 
            // lblQuantidade_comprada
            // 
            this.lblQuantidade_comprada.AutoSize = true;
            this.lblQuantidade_comprada.Location = new System.Drawing.Point(289, 196);
            this.lblQuantidade_comprada.Name = "lblQuantidade_comprada";
            this.lblQuantidade_comprada.Size = new System.Drawing.Size(74, 13);
            this.lblQuantidade_comprada.TabIndex = 4;
            this.lblQuantidade_comprada.Text = "Qtd comprada";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(11, 155);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(60, 20);
            this.txtQuantidade.TabIndex = 19;
            this.txtQuantidade.Validated += new System.EventHandler(this.txtQuantidade_Validated);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(8, 138);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(11, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(8, 27);
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
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(405, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 349);
            this.pnlBotoes.TabIndex = 7;
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
            // FrmOrcamentoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 349);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrcamentoItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.Load += new System.EventHandler(this.FrmOrcamentoItem_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.TextBox txtProduto_descricao;
        private System.Windows.Forms.Label lblProduto_descricao;
        private System.Windows.Forms.Label lblProduto_id;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtQuantidade_comprada;
        private System.Windows.Forms.Label lblQuantidade_comprada;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.MaskedTextBox txtProduto_id;
        private System.Windows.Forms.Label lblExcluir;
    }
}