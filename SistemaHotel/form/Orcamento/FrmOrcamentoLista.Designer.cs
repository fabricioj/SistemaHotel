﻿namespace SistemaHotel.form.Orcamento
{
    partial class FrmOrcamentoLista
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
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtFornecedor_nome = new System.Windows.Forms.TextBox();
            this.lblFornecedor_nome = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnPermissao = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAtividade_nome = new System.Windows.Forms.Label();
            this.txtAtividade_nome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridRegistros
            // 
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Location = new System.Drawing.Point(12, 76);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.Size = new System.Drawing.Size(448, 221);
            this.gridRegistros.TabIndex = 9;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Controls.Add(this.txtAtividade_nome);
            this.pnlFiltros.Controls.Add(this.lblAtividade_nome);
            this.pnlFiltros.Controls.Add(this.txtFornecedor_nome);
            this.pnlFiltros.Controls.Add(this.lblFornecedor_nome);
            this.pnlFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(448, 57);
            this.pnlFiltros.TabIndex = 8;
            // 
            // txtFornecedor_nome
            // 
            this.txtFornecedor_nome.Location = new System.Drawing.Point(3, 26);
            this.txtFornecedor_nome.Name = "txtFornecedor_nome";
            this.txtFornecedor_nome.Size = new System.Drawing.Size(207, 20);
            this.txtFornecedor_nome.TabIndex = 5;
            // 
            // lblFornecedor_nome
            // 
            this.lblFornecedor_nome.AutoSize = true;
            this.lblFornecedor_nome.Location = new System.Drawing.Point(0, 10);
            this.lblFornecedor_nome.Name = "lblFornecedor_nome";
            this.lblFornecedor_nome.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor_nome.TabIndex = 4;
            this.lblFornecedor_nome.Text = "Fornecedor";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnPermissao);
            this.pnlBotoes.Controls.Add(this.btnConsultar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnInserir);
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Location = new System.Drawing.Point(470, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 285);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnPermissao
            // 
            this.btnPermissao.Location = new System.Drawing.Point(4, 214);
            this.btnPermissao.Name = "btnPermissao";
            this.btnPermissao.Size = new System.Drawing.Size(126, 36);
            this.btnPermissao.TabIndex = 1;
            this.btnPermissao.Text = "PERMISSÃO";
            this.btnPermissao.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(4, 172);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(126, 36);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(4, 130);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 36);
            this.btnExcluir.TabIndex = 0;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(4, 88);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 36);
            this.btnAlterar.TabIndex = 0;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(4, 46);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(126, 36);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 36);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblAtividade_nome
            // 
            this.lblAtividade_nome.AutoSize = true;
            this.lblAtividade_nome.Location = new System.Drawing.Point(222, 10);
            this.lblAtividade_nome.Name = "lblAtividade_nome";
            this.lblAtividade_nome.Size = new System.Drawing.Size(51, 13);
            this.lblAtividade_nome.TabIndex = 4;
            this.lblAtividade_nome.Text = "Atividade";
            // 
            // txtAtividade_nome
            // 
            this.txtAtividade_nome.Location = new System.Drawing.Point(225, 26);
            this.txtAtividade_nome.Name = "txtAtividade_nome";
            this.txtAtividade_nome.Size = new System.Drawing.Size(207, 20);
            this.txtAtividade_nome.TabIndex = 5;
            // 
            // FrmOrcamentoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 307);
            this.Controls.Add(this.gridRegistros);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrcamentoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamentos";
            this.Load += new System.EventHandler(this.FrmOrcamentoLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridRegistros;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnPermissao;
        private System.Windows.Forms.TextBox txtFornecedor_nome;
        private System.Windows.Forms.Label lblFornecedor_nome;
        private System.Windows.Forms.TextBox txtAtividade_nome;
        private System.Windows.Forms.Label lblAtividade_nome;
    }
}