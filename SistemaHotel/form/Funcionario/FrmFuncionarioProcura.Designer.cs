namespace SistemaHotel.form.Funcionario
{
    partial class FrmFuncionarioProcura
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.gridRegistros = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razao_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlCorpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnSelecionar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(473, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 305);
            this.pnlBotoes.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(3, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 36);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, 87);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 36);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(3, 45);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(126, 36);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "SELECIONAR";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // pnlCorpo
            // 
            this.pnlCorpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCorpo.Controls.Add(this.gridRegistros);
            this.pnlCorpo.Controls.Add(this.pnlFiltros);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Size = new System.Drawing.Size(473, 305);
            this.pnlCorpo.TabIndex = 13;
            // 
            // gridRegistros
            // 
            this.gridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.razao_social,
            this.telefone,
            this.email,
            this.cidade,
            this.estado});
            this.gridRegistros.Location = new System.Drawing.Point(10, 71);
            this.gridRegistros.Name = "gridRegistros";
            this.gridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRegistros.Size = new System.Drawing.Size(448, 221);
            this.gridRegistros.TabIndex = 16;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 300;
            // 
            // razao_social
            // 
            this.razao_social.DataPropertyName = "razao_social";
            this.razao_social.HeaderText = "Razão social";
            this.razao_social.Name = "razao_social";
            this.razao_social.Visible = false;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Visible = false;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Visible = false;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Controls.Add(this.txtNome);
            this.pnlFiltros.Controls.Add(this.lblNome);
            this.pnlFiltros.Location = new System.Drawing.Point(10, 8);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(448, 57);
            this.pnlFiltros.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(389, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // FrmFuncionarioProcura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 305);
            this.Controls.Add(this.pnlCorpo);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncionarioProcura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas de funcionários";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCorpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegistros)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Panel pnlCorpo;
        private System.Windows.Forms.DataGridView gridRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn razao_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}