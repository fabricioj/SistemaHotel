namespace SistemaHotel.form.Procedimento
{
    partial class FrmProcedimentoPassoProduto
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtProduto_id = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisaProduto = new System.Windows.Forms.Button();
            this.txtProduto_descricao = new System.Windows.Forms.TextBox();
            this.lblProduto_descricao = new System.Windows.Forms.Label();
            this.lblProduto_id = new System.Windows.Forms.Label();
            this.txtQuantidade_utilizada = new System.Windows.Forms.TextBox();
            this.lblQuantidade_utilizada = new System.Windows.Forms.Label();
            this.pnlInformacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.txtProduto_id);
            this.pnlInformacoes.Controls.Add(this.btnPesquisaProduto);
            this.pnlInformacoes.Controls.Add(this.txtProduto_descricao);
            this.pnlInformacoes.Controls.Add(this.lblProduto_descricao);
            this.pnlInformacoes.Controls.Add(this.lblProduto_id);
            this.pnlInformacoes.Controls.Add(this.txtQuantidade_utilizada);
            this.pnlInformacoes.Controls.Add(this.lblQuantidade_utilizada);
            this.pnlInformacoes.Controls.Add(this.lblExcluir);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(447, 133);
            this.pnlInformacoes.TabIndex = 8;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Red;
            this.lblExcluir.Location = new System.Drawing.Point(3, 4);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(210, 17);
            this.lblExcluir.TabIndex = 29;
            this.lblExcluir.Text = "Confirma a deleção do registro?";
            this.lblExcluir.Visible = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 27);
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
            this.pnlBotoes.Location = new System.Drawing.Point(447, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 133);
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
            // txtProduto_id
            // 
            this.txtProduto_id.Location = new System.Drawing.Point(6, 98);
            this.txtProduto_id.Mask = "00000";
            this.txtProduto_id.Name = "txtProduto_id";
            this.txtProduto_id.Size = new System.Drawing.Size(65, 20);
            this.txtProduto_id.TabIndex = 36;
            this.txtProduto_id.Validated += new System.EventHandler(this.txtProduto_id_Validated);
            // 
            // btnPesquisaProduto
            // 
            this.btnPesquisaProduto.Location = new System.Drawing.Point(75, 98);
            this.btnPesquisaProduto.Name = "btnPesquisaProduto";
            this.btnPesquisaProduto.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaProduto.TabIndex = 35;
            this.btnPesquisaProduto.Text = "P";
            this.btnPesquisaProduto.UseVisualStyleBackColor = true;
            this.btnPesquisaProduto.Click += new System.EventHandler(this.btnPesquisaProduto_Click);
            // 
            // txtProduto_descricao
            // 
            this.txtProduto_descricao.Location = new System.Drawing.Point(104, 98);
            this.txtProduto_descricao.Name = "txtProduto_descricao";
            this.txtProduto_descricao.Size = new System.Drawing.Size(259, 20);
            this.txtProduto_descricao.TabIndex = 34;
            // 
            // lblProduto_descricao
            // 
            this.lblProduto_descricao.AutoSize = true;
            this.lblProduto_descricao.Location = new System.Drawing.Point(101, 81);
            this.lblProduto_descricao.Name = "lblProduto_descricao";
            this.lblProduto_descricao.Size = new System.Drawing.Size(55, 13);
            this.lblProduto_descricao.TabIndex = 31;
            this.lblProduto_descricao.Text = "Descrição";
            // 
            // lblProduto_id
            // 
            this.lblProduto_id.AutoSize = true;
            this.lblProduto_id.Location = new System.Drawing.Point(3, 81);
            this.lblProduto_id.Name = "lblProduto_id";
            this.lblProduto_id.Size = new System.Drawing.Size(44, 13);
            this.lblProduto_id.TabIndex = 32;
            this.lblProduto_id.Text = "Produto";
            // 
            // txtQuantidade_utilizada
            // 
            this.txtQuantidade_utilizada.Location = new System.Drawing.Point(369, 98);
            this.txtQuantidade_utilizada.Name = "txtQuantidade_utilizada";
            this.txtQuantidade_utilizada.Size = new System.Drawing.Size(60, 20);
            this.txtQuantidade_utilizada.TabIndex = 33;
            // 
            // lblQuantidade_utilizada
            // 
            this.lblQuantidade_utilizada.AutoSize = true;
            this.lblQuantidade_utilizada.Location = new System.Drawing.Point(366, 81);
            this.lblQuantidade_utilizada.Name = "lblQuantidade_utilizada";
            this.lblQuantidade_utilizada.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade_utilizada.TabIndex = 30;
            this.lblQuantidade_utilizada.Text = "Quantidade";
            // 
            // FrmProcedimentoPassoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 133);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcedimentoPassoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto utilizado";
            this.Load += new System.EventHandler(this.FrmProcedimentoPassoProduto_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox txtProduto_id;
        private System.Windows.Forms.Button btnPesquisaProduto;
        private System.Windows.Forms.TextBox txtProduto_descricao;
        private System.Windows.Forms.Label lblProduto_descricao;
        private System.Windows.Forms.Label lblProduto_id;
        private System.Windows.Forms.TextBox txtQuantidade_utilizada;
        private System.Windows.Forms.Label lblQuantidade_utilizada;
    }
}