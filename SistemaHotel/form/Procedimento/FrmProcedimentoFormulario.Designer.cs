﻿namespace SistemaHotel.form.Procedimento
{
    partial class FrmProcedimentoFormulario
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pnlInformacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.txtDescricao);
            this.pnlInformacoes.Controls.Add(this.lblDescricao);
            this.pnlInformacoes.Controls.Add(this.lblExcluir);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(425, 130);
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
            this.pnlBotoes.Location = new System.Drawing.Point(425, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 130);
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
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 96);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(313, 20);
            this.txtDescricao.TabIndex = 31;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(3, 79);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 30;
            this.lblDescricao.Text = "Descrição";
            // 
            // FrmProcedimentoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 130);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcedimentoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedimento";
            this.Load += new System.EventHandler(this.FrmProcedimentoFormulario_Load);
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
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
    }
}