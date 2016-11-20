namespace SistemaHotel.form.Solicitacao
{
    partial class FrmSolicitacaoFormulario
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
            this.txtData_emissao = new System.Windows.Forms.DateTimePicker();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.pnlReserva = new System.Windows.Forms.Panel();
            this.btnPesquisaAreaComum = new System.Windows.Forms.Button();
            this.txtArea_comum_nome = new System.Windows.Forms.TextBox();
            this.lblArea_comum_nome = new System.Windows.Forms.Label();
            this.txtArea_comum_id = new System.Windows.Forms.TextBox();
            this.lblArea_comum_id = new System.Windows.Forms.Label();
            this.txtData_fim = new System.Windows.Forms.DateTimePicker();
            this.txtData_inicio = new System.Windows.Forms.DateTimePicker();
            this.lblData_fim = new System.Windows.Forms.Label();
            this.lblData_inicio = new System.Windows.Forms.Label();
            this.pnlServico = new System.Windows.Forms.Panel();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.lblServico = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.lblData_emissao = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlInformacoes.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            this.pnlServico.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.txtData_emissao);
            this.pnlInformacoes.Controls.Add(this.txtObservacao);
            this.pnlInformacoes.Controls.Add(this.lblObservacao);
            this.pnlInformacoes.Controls.Add(this.pnlReserva);
            this.pnlInformacoes.Controls.Add(this.pnlServico);
            this.pnlInformacoes.Controls.Add(this.cbTipo);
            this.pnlInformacoes.Controls.Add(this.lblTipo);
            this.pnlInformacoes.Controls.Add(this.lblExcluir);
            this.pnlInformacoes.Controls.Add(this.lblData_emissao);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(356, 385);
            this.pnlInformacoes.TabIndex = 8;
            // 
            // txtData_emissao
            // 
            this.txtData_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_emissao.Location = new System.Drawing.Point(182, 41);
            this.txtData_emissao.Name = "txtData_emissao";
            this.txtData_emissao.Size = new System.Drawing.Size(82, 20);
            this.txtData_emissao.TabIndex = 36;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(6, 325);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(336, 46);
            this.txtObservacao.TabIndex = 35;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(3, 309);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 34;
            this.lblObservacao.Text = "Observação";
            // 
            // pnlReserva
            // 
            this.pnlReserva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReserva.Controls.Add(this.btnPesquisaAreaComum);
            this.pnlReserva.Controls.Add(this.txtArea_comum_nome);
            this.pnlReserva.Controls.Add(this.lblArea_comum_nome);
            this.pnlReserva.Controls.Add(this.txtArea_comum_id);
            this.pnlReserva.Controls.Add(this.lblArea_comum_id);
            this.pnlReserva.Controls.Add(this.txtData_fim);
            this.pnlReserva.Controls.Add(this.txtData_inicio);
            this.pnlReserva.Controls.Add(this.lblData_fim);
            this.pnlReserva.Controls.Add(this.lblData_inicio);
            this.pnlReserva.Location = new System.Drawing.Point(6, 179);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(336, 127);
            this.pnlReserva.TabIndex = 33;
            // 
            // btnPesquisaAreaComum
            // 
            this.btnPesquisaAreaComum.Location = new System.Drawing.Point(80, 37);
            this.btnPesquisaAreaComum.Name = "btnPesquisaAreaComum";
            this.btnPesquisaAreaComum.Size = new System.Drawing.Size(20, 20);
            this.btnPesquisaAreaComum.TabIndex = 31;
            this.btnPesquisaAreaComum.Text = "P";
            this.btnPesquisaAreaComum.UseVisualStyleBackColor = true;
            this.btnPesquisaAreaComum.Click += new System.EventHandler(this.btnPesquisaAreaComum_Click);
            // 
            // txtArea_comum_nome
            // 
            this.txtArea_comum_nome.Location = new System.Drawing.Point(114, 38);
            this.txtArea_comum_nome.Name = "txtArea_comum_nome";
            this.txtArea_comum_nome.Size = new System.Drawing.Size(208, 20);
            this.txtArea_comum_nome.TabIndex = 29;
            // 
            // lblArea_comum_nome
            // 
            this.lblArea_comum_nome.AutoSize = true;
            this.lblArea_comum_nome.Location = new System.Drawing.Point(111, 21);
            this.lblArea_comum_nome.Name = "lblArea_comum_nome";
            this.lblArea_comum_nome.Size = new System.Drawing.Size(35, 13);
            this.lblArea_comum_nome.TabIndex = 27;
            this.lblArea_comum_nome.Text = "Nome";
            // 
            // txtArea_comum_id
            // 
            this.txtArea_comum_id.Location = new System.Drawing.Point(11, 37);
            this.txtArea_comum_id.Name = "txtArea_comum_id";
            this.txtArea_comum_id.Size = new System.Drawing.Size(65, 20);
            this.txtArea_comum_id.TabIndex = 30;
            this.txtArea_comum_id.Validated += new System.EventHandler(this.txtArea_comum_id_Validated);
            // 
            // lblArea_comum_id
            // 
            this.lblArea_comum_id.AutoSize = true;
            this.lblArea_comum_id.Location = new System.Drawing.Point(8, 20);
            this.lblArea_comum_id.Name = "lblArea_comum_id";
            this.lblArea_comum_id.Size = new System.Drawing.Size(66, 13);
            this.lblArea_comum_id.TabIndex = 28;
            this.lblArea_comum_id.Text = "Área comum";
            // 
            // txtData_fim
            // 
            this.txtData_fim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtData_fim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_fim.Location = new System.Drawing.Point(174, 89);
            this.txtData_fim.Name = "txtData_fim";
            this.txtData_fim.Size = new System.Drawing.Size(148, 20);
            this.txtData_fim.TabIndex = 24;
            // 
            // txtData_inicio
            // 
            this.txtData_inicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtData_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtData_inicio.Location = new System.Drawing.Point(11, 89);
            this.txtData_inicio.Name = "txtData_inicio";
            this.txtData_inicio.Size = new System.Drawing.Size(148, 20);
            this.txtData_inicio.TabIndex = 24;
            // 
            // lblData_fim
            // 
            this.lblData_fim.AutoSize = true;
            this.lblData_fim.Location = new System.Drawing.Point(171, 72);
            this.lblData_fim.Name = "lblData_fim";
            this.lblData_fim.Size = new System.Drawing.Size(46, 13);
            this.lblData_fim.TabIndex = 22;
            this.lblData_fim.Text = "Data fim";
            // 
            // lblData_inicio
            // 
            this.lblData_inicio.AutoSize = true;
            this.lblData_inicio.Location = new System.Drawing.Point(8, 72);
            this.lblData_inicio.Name = "lblData_inicio";
            this.lblData_inicio.Size = new System.Drawing.Size(57, 13);
            this.lblData_inicio.TabIndex = 20;
            this.lblData_inicio.Text = "Data inicio";
            // 
            // pnlServico
            // 
            this.pnlServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlServico.Controls.Add(this.txtLocal);
            this.pnlServico.Controls.Add(this.lblLocal);
            this.pnlServico.Controls.Add(this.txtServico);
            this.pnlServico.Controls.Add(this.lblServico);
            this.pnlServico.Location = new System.Drawing.Point(6, 117);
            this.pnlServico.Name = "pnlServico";
            this.pnlServico.Size = new System.Drawing.Size(336, 56);
            this.pnlServico.TabIndex = 33;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(174, 23);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(148, 20);
            this.txtLocal.TabIndex = 23;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(171, 6);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 22;
            this.lblLocal.Text = "Local";
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(11, 23);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(148, 20);
            this.txtServico.TabIndex = 21;
            // 
            // lblServico
            // 
            this.lblServico.AutoSize = true;
            this.lblServico.Location = new System.Drawing.Point(8, 6);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(43, 13);
            this.lblServico.TabIndex = 20;
            this.lblServico.Text = "Serviço";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(6, 90);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(232, 21);
            this.cbTipo.TabIndex = 32;
            this.cbTipo.SelectionChangeCommitted += new System.EventHandler(this.cbTipo_SelectionChangeCommitted);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 74);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 31;
            this.lblTipo.Text = "Tipo";
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
            // lblData_emissao
            // 
            this.lblData_emissao.AutoSize = true;
            this.lblData_emissao.Location = new System.Drawing.Point(179, 27);
            this.lblData_emissao.Name = "lblData_emissao";
            this.lblData_emissao.Size = new System.Drawing.Size(59, 13);
            this.lblData_emissao.TabIndex = 4;
            this.lblData_emissao.Text = "Dt emissão";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 41);
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
            this.pnlBotoes.Location = new System.Drawing.Point(356, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 385);
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
            // FrmSolicitacaoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 385);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSolicitacaoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitação";
            this.Load += new System.EventHandler(this.FrmSolicitacaoFormulario_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            this.pnlServico.ResumeLayout(false);
            this.pnlServico.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.Panel pnlServico;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.DateTimePicker txtData_fim;
        private System.Windows.Forms.DateTimePicker txtData_inicio;
        private System.Windows.Forms.Label lblData_fim;
        private System.Windows.Forms.Label lblData_inicio;
        private System.Windows.Forms.Button btnPesquisaAreaComum;
        private System.Windows.Forms.TextBox txtArea_comum_nome;
        private System.Windows.Forms.Label lblArea_comum_nome;
        private System.Windows.Forms.TextBox txtArea_comum_id;
        private System.Windows.Forms.Label lblArea_comum_id;
        private System.Windows.Forms.Label lblData_emissao;
        private System.Windows.Forms.DateTimePicker txtData_emissao;
    }
}