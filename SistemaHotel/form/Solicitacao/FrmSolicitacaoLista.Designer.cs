namespace SistemaHotel.form.Solicitacao
{
    partial class FrmSolicitacaoLista
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(430, 85);
            this.pnlFiltros.TabIndex = 0;
            // 
            // gridRegistros
            // 
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Location = new System.Drawing.Point(12, 103);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.Size = new System.Drawing.Size(430, 261);
            this.gridRegistros.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(465, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(142, 352);
            this.pnlBotoes.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(8, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 36);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(8, 49);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(126, 36);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(8, 91);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 36);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(8, 133);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 36);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(8, 175);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 36);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FrmSolicitacaoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 376);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.gridRegistros);
            this.Controls.Add(this.pnlFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSolicitacaoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitacões";
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.DataGridView gridRegistros;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;

    }
}