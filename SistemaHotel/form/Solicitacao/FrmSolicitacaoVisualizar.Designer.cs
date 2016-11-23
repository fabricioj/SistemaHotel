namespace SistemaHotel.form.Solicitacao
{
    partial class FrmSolicitacaoVisualizar
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
            this.pnlResultado = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtData_visualizacao = new System.Windows.Forms.DateTimePicker();
            this.lblData_visualizacao = new System.Windows.Forms.Label();
            this.cbResultado_visualizacao = new System.Windows.Forms.ComboBox();
            this.lblResultado_visualizacao = new System.Windows.Forms.Label();
            this.pnlReserva = new System.Windows.Forms.Panel();
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
            this.txtUsuario_solicitante_nome = new System.Windows.Forms.TextBox();
            this.lblUsuario_solicitante_nome = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnPermissao = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlInformacoes.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.pnlReserva.SuspendLayout();
            this.pnlServico.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.pnlResultado);
            this.pnlInformacoes.Controls.Add(this.pnlReserva);
            this.pnlInformacoes.Controls.Add(this.pnlServico);
            this.pnlInformacoes.Controls.Add(this.txtUsuario_solicitante_nome);
            this.pnlInformacoes.Controls.Add(this.lblUsuario_solicitante_nome);
            this.pnlInformacoes.Controls.Add(this.cbTipo);
            this.pnlInformacoes.Controls.Add(this.lblTipo);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(362, 447);
            this.pnlInformacoes.TabIndex = 10;
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.txtObservacao);
            this.pnlResultado.Controls.Add(this.lblObservacao);
            this.pnlResultado.Controls.Add(this.txtData_visualizacao);
            this.pnlResultado.Controls.Add(this.lblData_visualizacao);
            this.pnlResultado.Controls.Add(this.cbResultado_visualizacao);
            this.pnlResultado.Controls.Add(this.lblResultado_visualizacao);
            this.pnlResultado.Location = new System.Drawing.Point(6, 297);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(343, 139);
            this.pnlResultado.TabIndex = 50;
            this.pnlResultado.TabStop = false;
            this.pnlResultado.Text = "Visualização";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(6, 84);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(323, 46);
            this.txtObservacao.TabIndex = 49;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Location = new System.Drawing.Point(3, 68);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(65, 13);
            this.lblObservacao.TabIndex = 48;
            this.lblObservacao.Text = "Observação";
            // 
            // txtData_visualizacao
            // 
            this.txtData_visualizacao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtData_visualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData_visualizacao.Location = new System.Drawing.Point(6, 36);
            this.txtData_visualizacao.Name = "txtData_visualizacao";
            this.txtData_visualizacao.Size = new System.Drawing.Size(148, 20);
            this.txtData_visualizacao.TabIndex = 24;
            // 
            // lblData_visualizacao
            // 
            this.lblData_visualizacao.AutoSize = true;
            this.lblData_visualizacao.Location = new System.Drawing.Point(3, 19);
            this.lblData_visualizacao.Name = "lblData_visualizacao";
            this.lblData_visualizacao.Size = new System.Drawing.Size(30, 13);
            this.lblData_visualizacao.TabIndex = 20;
            this.lblData_visualizacao.Text = "Data";
            // 
            // cbResultado_visualizacao
            // 
            this.cbResultado_visualizacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResultado_visualizacao.FormattingEnabled = true;
            this.cbResultado_visualizacao.Location = new System.Drawing.Point(165, 35);
            this.cbResultado_visualizacao.Name = "cbResultado_visualizacao";
            this.cbResultado_visualizacao.Size = new System.Drawing.Size(164, 21);
            this.cbResultado_visualizacao.TabIndex = 47;
            // 
            // lblResultado_visualizacao
            // 
            this.lblResultado_visualizacao.AutoSize = true;
            this.lblResultado_visualizacao.Location = new System.Drawing.Point(162, 19);
            this.lblResultado_visualizacao.Name = "lblResultado_visualizacao";
            this.lblResultado_visualizacao.Size = new System.Drawing.Size(55, 13);
            this.lblResultado_visualizacao.TabIndex = 46;
            this.lblResultado_visualizacao.Text = "Resultado";
            // 
            // pnlReserva
            // 
            this.pnlReserva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlReserva.Controls.Add(this.txtArea_comum_nome);
            this.pnlReserva.Controls.Add(this.lblArea_comum_nome);
            this.pnlReserva.Controls.Add(this.txtArea_comum_id);
            this.pnlReserva.Controls.Add(this.lblArea_comum_id);
            this.pnlReserva.Controls.Add(this.txtData_fim);
            this.pnlReserva.Controls.Add(this.txtData_inicio);
            this.pnlReserva.Controls.Add(this.lblData_fim);
            this.pnlReserva.Controls.Add(this.lblData_inicio);
            this.pnlReserva.Location = new System.Drawing.Point(6, 163);
            this.pnlReserva.Name = "pnlReserva";
            this.pnlReserva.Size = new System.Drawing.Size(336, 127);
            this.pnlReserva.TabIndex = 48;
            // 
            // txtArea_comum_nome
            // 
            this.txtArea_comum_nome.Location = new System.Drawing.Point(82, 38);
            this.txtArea_comum_nome.Name = "txtArea_comum_nome";
            this.txtArea_comum_nome.Size = new System.Drawing.Size(240, 20);
            this.txtArea_comum_nome.TabIndex = 29;
            // 
            // lblArea_comum_nome
            // 
            this.lblArea_comum_nome.AutoSize = true;
            this.lblArea_comum_nome.Location = new System.Drawing.Point(79, 20);
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
            this.pnlServico.Location = new System.Drawing.Point(6, 101);
            this.pnlServico.Name = "pnlServico";
            this.pnlServico.Size = new System.Drawing.Size(336, 56);
            this.pnlServico.TabIndex = 49;
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
            // txtUsuario_solicitante_nome
            // 
            this.txtUsuario_solicitante_nome.Location = new System.Drawing.Point(77, 28);
            this.txtUsuario_solicitante_nome.Name = "txtUsuario_solicitante_nome";
            this.txtUsuario_solicitante_nome.Size = new System.Drawing.Size(265, 20);
            this.txtUsuario_solicitante_nome.TabIndex = 21;
            // 
            // lblUsuario_solicitante_nome
            // 
            this.lblUsuario_solicitante_nome.AutoSize = true;
            this.lblUsuario_solicitante_nome.Location = new System.Drawing.Point(74, 11);
            this.lblUsuario_solicitante_nome.Name = "lblUsuario_solicitante_nome";
            this.lblUsuario_solicitante_nome.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario_solicitante_nome.TabIndex = 20;
            this.lblUsuario_solicitante_nome.Text = "Solicitante";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(6, 75);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(232, 21);
            this.cbTipo.TabIndex = 47;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 59);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 46;
            this.lblTipo.Text = "Tipo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnPermissao);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(362, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 447);
            this.pnlBotoes.TabIndex = 9;
            // 
            // btnPermissao
            // 
            this.btnPermissao.Location = new System.Drawing.Point(4, 88);
            this.btnPermissao.Name = "btnPermissao";
            this.btnPermissao.Size = new System.Drawing.Size(126, 36);
            this.btnPermissao.TabIndex = 1;
            this.btnPermissao.Text = "PERMISSÃO";
            this.btnPermissao.UseVisualStyleBackColor = true;
            this.btnPermissao.Click += new System.EventHandler(this.btnPermissao_Click);
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
            // FrmSolicitacaoVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSolicitacaoVisualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar solicitação";
            this.Load += new System.EventHandler(this.FrmSolicitacaoVisualizar_Load);
            this.pnlInformacoes.ResumeLayout(false);
            this.pnlInformacoes.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.pnlReserva.ResumeLayout(false);
            this.pnlReserva.PerformLayout();
            this.pnlServico.ResumeLayout(false);
            this.pnlServico.PerformLayout();
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
        private System.Windows.Forms.Button btnPermissao;
        private System.Windows.Forms.Panel pnlReserva;
        private System.Windows.Forms.TextBox txtArea_comum_nome;
        private System.Windows.Forms.Label lblArea_comum_nome;
        private System.Windows.Forms.TextBox txtArea_comum_id;
        private System.Windows.Forms.Label lblArea_comum_id;
        private System.Windows.Forms.DateTimePicker txtData_fim;
        private System.Windows.Forms.DateTimePicker txtData_inicio;
        private System.Windows.Forms.Label lblData_fim;
        private System.Windows.Forms.Label lblData_inicio;
        private System.Windows.Forms.Panel pnlServico;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox pnlResultado;
        private System.Windows.Forms.DateTimePicker txtData_visualizacao;
        private System.Windows.Forms.Label lblData_visualizacao;
        private System.Windows.Forms.ComboBox cbResultado_visualizacao;
        private System.Windows.Forms.Label lblResultado_visualizacao;
        private System.Windows.Forms.TextBox txtUsuario_solicitante_nome;
        private System.Windows.Forms.Label lblUsuario_solicitante_nome;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
    }
}