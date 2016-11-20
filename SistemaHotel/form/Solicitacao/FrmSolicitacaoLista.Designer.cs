﻿namespace SistemaHotel.form.Solicitacao
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnPermissao = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.toolOpcoes = new System.Windows.Forms.ToolStrip();
            this.toolVistarSolicitacao = new System.Windows.Forms.ToolStripButton();
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.pnlBotoes.SuspendLayout();
            this.toolOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            this.SuspendLayout();
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
            this.pnlBotoes.Location = new System.Drawing.Point(472, 12);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 320);
            this.pnlBotoes.TabIndex = 7;
            // 
            // btnPermissao
            // 
            this.btnPermissao.Location = new System.Drawing.Point(4, 214);
            this.btnPermissao.Name = "btnPermissao";
            this.btnPermissao.Size = new System.Drawing.Size(126, 36);
            this.btnPermissao.TabIndex = 0;
            this.btnPermissao.Text = "PERMISSÃO";
            this.btnPermissao.UseVisualStyleBackColor = true;
            this.btnPermissao.Click += new System.EventHandler(this.btnPermissao_Click);
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
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Location = new System.Drawing.Point(12, 38);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(448, 67);
            this.pnlFiltros.TabIndex = 12;
            // 
            // toolOpcoes
            // 
            this.toolOpcoes.Dock = System.Windows.Forms.DockStyle.None;
            this.toolOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolVistarSolicitacao});
            this.toolOpcoes.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolOpcoes.Location = new System.Drawing.Point(12, 12);
            this.toolOpcoes.Name = "toolOpcoes";
            this.toolOpcoes.Size = new System.Drawing.Size(147, 23);
            this.toolOpcoes.TabIndex = 14;
            this.toolOpcoes.Text = "Opções";
            // 
            // toolVistarSolicitacao
            // 
            this.toolVistarSolicitacao.Image = global::SistemaHotel.Properties.Resources.certo;
            this.toolVistarSolicitacao.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.toolVistarSolicitacao.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolVistarSolicitacao.Name = "toolVistarSolicitacao";
            this.toolVistarSolicitacao.Size = new System.Drawing.Size(115, 20);
            this.toolVistarSolicitacao.Text = "Vistar solicitação";
            this.toolVistarSolicitacao.Click += new System.EventHandler(this.toolVistarSolicitacao_Click);
            // 
            // gridRegistros
            // 
            this.gridRegistros.AllowUserToAddRows = false;
            this.gridRegistros.AllowUserToDeleteRows = false;
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Location = new System.Drawing.Point(12, 111);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegistros.Size = new System.Drawing.Size(448, 221);
            this.gridRegistros.TabIndex = 15;
            // 
            // FrmSolicitacaoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 344);
            this.Controls.Add(this.gridRegistros);
            this.Controls.Add(this.toolOpcoes);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSolicitacaoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitações";
            this.Load += new System.EventHandler(this.FrmSolicitacao_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.toolOpcoes.ResumeLayout(false);
            this.toolOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnPermissao;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.ToolStrip toolOpcoes;
        private System.Windows.Forms.ToolStripButton toolVistarSolicitacao;
        private System.Windows.Forms.DataGridView gridRegistros;
    }
}