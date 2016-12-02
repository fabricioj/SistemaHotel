﻿namespace SistemaHotel.form.Permissao
{
    partial class FrmPermissaoLista
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
            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtFuncionalidade_id = new System.Windows.Forms.MaskedTextBox();
            this.txtFuncionalidade_nome_funcionalidade = new System.Windows.Forms.TextBox();
            this.lblFuncionalidade_nome_funcionalidade = new System.Windows.Forms.Label();
            this.lblFuncionalidade_id = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlCorpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            this.pnlFiltros.SuspendLayout();
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
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(482, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 305);
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
            // pnlCorpo
            // 
            this.pnlCorpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCorpo.Controls.Add(this.gridRegistros);
            this.pnlCorpo.Controls.Add(this.pnlFiltros);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Size = new System.Drawing.Size(482, 305);
            this.pnlCorpo.TabIndex = 8;
            // 
            // gridRegistros
            // 
            this.gridRegistros.AllowUserToAddRows = false;
            this.gridRegistros.AllowUserToDeleteRows = false;
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Location = new System.Drawing.Point(15, 72);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.ReadOnly = true;
            this.gridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegistros.Size = new System.Drawing.Size(448, 221);
            this.gridRegistros.TabIndex = 11;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Controls.Add(this.txtFuncionalidade_id);
            this.pnlFiltros.Controls.Add(this.txtFuncionalidade_nome_funcionalidade);
            this.pnlFiltros.Controls.Add(this.lblFuncionalidade_nome_funcionalidade);
            this.pnlFiltros.Controls.Add(this.lblFuncionalidade_id);
            this.pnlFiltros.Location = new System.Drawing.Point(15, 8);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(448, 57);
            this.pnlFiltros.TabIndex = 10;
            // 
            // txtFuncionalidade_id
            // 
            this.txtFuncionalidade_id.Location = new System.Drawing.Point(3, 25);
            this.txtFuncionalidade_id.Mask = "00000";
            this.txtFuncionalidade_id.Name = "txtFuncionalidade_id";
            this.txtFuncionalidade_id.Size = new System.Drawing.Size(65, 20);
            this.txtFuncionalidade_id.TabIndex = 50;
            // 
            // txtFuncionalidade_nome_funcionalidade
            // 
            this.txtFuncionalidade_nome_funcionalidade.Location = new System.Drawing.Point(101, 25);
            this.txtFuncionalidade_nome_funcionalidade.Name = "txtFuncionalidade_nome_funcionalidade";
            this.txtFuncionalidade_nome_funcionalidade.Size = new System.Drawing.Size(224, 20);
            this.txtFuncionalidade_nome_funcionalidade.TabIndex = 49;
            // 
            // lblFuncionalidade_nome_funcionalidade
            // 
            this.lblFuncionalidade_nome_funcionalidade.AutoSize = true;
            this.lblFuncionalidade_nome_funcionalidade.Location = new System.Drawing.Point(98, 8);
            this.lblFuncionalidade_nome_funcionalidade.Name = "lblFuncionalidade_nome_funcionalidade";
            this.lblFuncionalidade_nome_funcionalidade.Size = new System.Drawing.Size(122, 13);
            this.lblFuncionalidade_nome_funcionalidade.TabIndex = 47;
            this.lblFuncionalidade_nome_funcionalidade.Text = "Nome da funcionalidade";
            // 
            // lblFuncionalidade_id
            // 
            this.lblFuncionalidade_id.AutoSize = true;
            this.lblFuncionalidade_id.Location = new System.Drawing.Point(0, 8);
            this.lblFuncionalidade_id.Name = "lblFuncionalidade_id";
            this.lblFuncionalidade_id.Size = new System.Drawing.Size(79, 13);
            this.lblFuncionalidade_id.TabIndex = 48;
            this.lblFuncionalidade_id.Text = "Funcionalidade";
            // 
            // FrmPermissaoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 305);
            this.Controls.Add(this.pnlCorpo);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPermissaoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissões";
            this.Load += new System.EventHandler(this.FrmPermissao_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCorpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnPermissao;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlCorpo;
        private System.Windows.Forms.DataGridView gridRegistros;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.MaskedTextBox txtFuncionalidade_id;
        private System.Windows.Forms.TextBox txtFuncionalidade_nome_funcionalidade;
        private System.Windows.Forms.Label lblFuncionalidade_nome_funcionalidade;
        private System.Windows.Forms.Label lblFuncionalidade_id;
    }
}