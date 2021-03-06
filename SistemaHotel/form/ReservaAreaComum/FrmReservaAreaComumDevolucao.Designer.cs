﻿namespace SistemaHotel.form.ReservaAreaComum
{
    partial class FrmReservaAreaComumDevolucao
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
            this.txtUsuario_solicitante_nome = new System.Windows.Forms.TextBox();
            this.lblUsuario_solicitante_nome = new System.Windows.Forms.Label();
            this.txtArea_comum_nome = new System.Windows.Forms.TextBox();
            this.lblArea_comum_nome = new System.Windows.Forms.Label();
            this.txtArea_comum_id = new System.Windows.Forms.TextBox();
            this.lblArea_comum_id = new System.Windows.Forms.Label();
            this.txtData_devolucao = new System.Windows.Forms.DateTimePicker();
            this.lblData_devolucao = new System.Windows.Forms.Label();
            this.txtData_inicio = new System.Windows.Forms.DateTimePicker();
            this.lblData_inicio = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.pnlInformacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.txtObservacao);
            this.pnlInformacoes.Controls.Add(this.lblObservacao);
            this.pnlInformacoes.Controls.Add(this.txtUsuario_solicitante_nome);
            this.pnlInformacoes.Controls.Add(this.lblUsuario_solicitante_nome);
            this.pnlInformacoes.Controls.Add(this.txtArea_comum_nome);
            this.pnlInformacoes.Controls.Add(this.lblArea_comum_nome);
            this.pnlInformacoes.Controls.Add(this.txtArea_comum_id);
            this.pnlInformacoes.Controls.Add(this.lblArea_comum_id);
            this.pnlInformacoes.Controls.Add(this.txtData_devolucao);
            this.pnlInformacoes.Controls.Add(this.lblData_devolucao);
            this.pnlInformacoes.Controls.Add(this.txtData_inicio);
            this.pnlInformacoes.Controls.Add(this.lblData_inicio);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(385, 229);
            this.pnlInformacoes.TabIndex = 8;
            // 
            // txtUsuario_solicitante_nome
            // 
            this.txtUsuario_solicitante_nome.Location = new System.Drawing.Point(99, 20);
            this.txtUsuario_solicitante_nome.Name = "txtUsuario_solicitante_nome";
            this.txtUsuario_solicitante_nome.Size = new System.Drawing.Size(265, 20);
            this.txtUsuario_solicitante_nome.TabIndex = 42;
            // 
            // lblUsuario_solicitante_nome
            // 
            this.lblUsuario_solicitante_nome.AutoSize = true;
            this.lblUsuario_solicitante_nome.Location = new System.Drawing.Point(96, 3);
            this.lblUsuario_solicitante_nome.Name = "lblUsuario_solicitante_nome";
            this.lblUsuario_solicitante_nome.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario_solicitante_nome.TabIndex = 39;
            this.lblUsuario_solicitante_nome.Text = "Solicitante";
            // 
            // txtArea_comum_nome
            // 
            this.txtArea_comum_nome.Location = new System.Drawing.Point(99, 74);
            this.txtArea_comum_nome.Name = "txtArea_comum_nome";
            this.txtArea_comum_nome.Size = new System.Drawing.Size(265, 20);
            this.txtArea_comum_nome.TabIndex = 47;
            // 
            // lblArea_comum_nome
            // 
            this.lblArea_comum_nome.AutoSize = true;
            this.lblArea_comum_nome.Location = new System.Drawing.Point(96, 58);
            this.lblArea_comum_nome.Name = "lblArea_comum_nome";
            this.lblArea_comum_nome.Size = new System.Drawing.Size(35, 13);
            this.lblArea_comum_nome.TabIndex = 45;
            this.lblArea_comum_nome.Text = "Nome";
            // 
            // txtArea_comum_id
            // 
            this.txtArea_comum_id.Location = new System.Drawing.Point(10, 74);
            this.txtArea_comum_id.Name = "txtArea_comum_id";
            this.txtArea_comum_id.Size = new System.Drawing.Size(65, 20);
            this.txtArea_comum_id.TabIndex = 48;
            // 
            // lblArea_comum_id
            // 
            this.lblArea_comum_id.AutoSize = true;
            this.lblArea_comum_id.Location = new System.Drawing.Point(7, 57);
            this.lblArea_comum_id.Name = "lblArea_comum_id";
            this.lblArea_comum_id.Size = new System.Drawing.Size(66, 13);
            this.lblArea_comum_id.TabIndex = 46;
            this.lblArea_comum_id.Text = "Área comum";
            // 
            // txtData_devolucao
            // 
            this.txtData_devolucao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtData_devolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_devolucao.Location = new System.Drawing.Point(216, 127);
            this.txtData_devolucao.Name = "txtData_devolucao";
            this.txtData_devolucao.Size = new System.Drawing.Size(148, 20);
            this.txtData_devolucao.TabIndex = 43;
            // 
            // lblData_devolucao
            // 
            this.lblData_devolucao.AutoSize = true;
            this.lblData_devolucao.Location = new System.Drawing.Point(213, 110);
            this.lblData_devolucao.Name = "lblData_devolucao";
            this.lblData_devolucao.Size = new System.Drawing.Size(83, 13);
            this.lblData_devolucao.TabIndex = 40;
            this.lblData_devolucao.Text = "Data devolução";
            // 
            // txtData_inicio
            // 
            this.txtData_inicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtData_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_inicio.Location = new System.Drawing.Point(10, 127);
            this.txtData_inicio.Name = "txtData_inicio";
            this.txtData_inicio.Size = new System.Drawing.Size(148, 20);
            this.txtData_inicio.TabIndex = 44;
            // 
            // lblData_inicio
            // 
            this.lblData_inicio.AutoSize = true;
            this.lblData_inicio.Location = new System.Drawing.Point(7, 110);
            this.lblData_inicio.Name = "lblData_inicio";
            this.lblData_inicio.Size = new System.Drawing.Size(57, 13);
            this.lblData_inicio.TabIndex = 41;
            this.lblData_inicio.Text = "Data inicio";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(10, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 3);
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
            this.pnlBotoes.Location = new System.Drawing.Point(385, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 229);
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
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(10, 173);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(354, 46);
            this.txtObservacao.TabIndex = 50;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(7, 157);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(118, 13);
            this.lblObservacao.TabIndex = 49;
            this.lblObservacao.Text = "Observação devolução";
            // 
            // FrmReservaAreaComumDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 229);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReservaAreaComumDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução de área comum";
            this.Load += new System.EventHandler(this.FrmReservaAreaComumDevolucao_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacoes;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtUsuario_solicitante_nome;
        private System.Windows.Forms.Label lblUsuario_solicitante_nome;
        private System.Windows.Forms.TextBox txtArea_comum_nome;
        private System.Windows.Forms.Label lblArea_comum_nome;
        private System.Windows.Forms.TextBox txtArea_comum_id;
        private System.Windows.Forms.Label lblArea_comum_id;
        private System.Windows.Forms.DateTimePicker txtData_devolucao;
        private System.Windows.Forms.Label lblData_devolucao;
        private System.Windows.Forms.DateTimePicker txtData_inicio;
        private System.Windows.Forms.Label lblData_inicio;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
    }
}