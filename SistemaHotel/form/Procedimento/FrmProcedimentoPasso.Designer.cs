namespace SistemaHotel.form.Procedimento
{
    partial class FrmProcedimentoPasso
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
            this.lblOrdem = new System.Windows.Forms.Label();
            this.txtOrdem_execucao = new System.Windows.Forms.TextBox();
            this.lblDescrica_passo = new System.Windows.Forms.Label();
            this.txtDescricao_passo = new System.Windows.Forms.TextBox();
            this.pnlInformacoes.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacoes
            // 
            this.pnlInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlInformacoes.Controls.Add(this.lblExcluir);
            this.pnlInformacoes.Controls.Add(this.txtDescricao_passo);
            this.pnlInformacoes.Controls.Add(this.lblDescrica_passo);
            this.pnlInformacoes.Controls.Add(this.txtOrdem_execucao);
            this.pnlInformacoes.Controls.Add(this.lblOrdem);
            this.pnlInformacoes.Controls.Add(this.txtID);
            this.pnlInformacoes.Controls.Add(this.lblId);
            this.pnlInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformacoes.Location = new System.Drawing.Point(0, 0);
            this.pnlInformacoes.Name = "pnlInformacoes";
            this.pnlInformacoes.Size = new System.Drawing.Size(337, 201);
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
            this.pnlBotoes.Location = new System.Drawing.Point(337, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 201);
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
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Location = new System.Drawing.Point(136, 27);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(38, 13);
            this.lblOrdem.TabIndex = 4;
            this.lblOrdem.Text = "Ordem";
            // 
            // txtOrdem_execucao
            // 
            this.txtOrdem_execucao.Location = new System.Drawing.Point(139, 44);
            this.txtOrdem_execucao.Name = "txtOrdem_execucao";
            this.txtOrdem_execucao.Size = new System.Drawing.Size(60, 20);
            this.txtOrdem_execucao.TabIndex = 19;
            // 
            // lblDescrica_passo
            // 
            this.lblDescrica_passo.AutoSize = true;
            this.lblDescrica_passo.Location = new System.Drawing.Point(3, 76);
            this.lblDescrica_passo.Name = "lblDescrica_passo";
            this.lblDescrica_passo.Size = new System.Drawing.Size(86, 13);
            this.lblDescrica_passo.TabIndex = 4;
            this.lblDescrica_passo.Text = "Descrição passo";
            // 
            // txtDescricao_passo
            // 
            this.txtDescricao_passo.Location = new System.Drawing.Point(6, 93);
            this.txtDescricao_passo.Multiline = true;
            this.txtDescricao_passo.Name = "txtDescricao_passo";
            this.txtDescricao_passo.Size = new System.Drawing.Size(319, 101);
            this.txtDescricao_passo.TabIndex = 19;
            // 
            // FrmProcedimentoPasso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 201);
            this.Controls.Add(this.pnlInformacoes);
            this.Controls.Add(this.pnlBotoes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProcedimentoPasso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passo";
            this.Load += new System.EventHandler(this.FrmProcedimentoPasso_Load);
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
        private System.Windows.Forms.TextBox txtOrdem_execucao;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.TextBox txtDescricao_passo;
        private System.Windows.Forms.Label lblDescrica_passo;
    }
}