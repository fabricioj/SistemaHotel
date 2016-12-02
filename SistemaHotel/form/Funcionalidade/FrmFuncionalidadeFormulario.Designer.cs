namespace SistemaHotel.form.Funcionalidade
{
    partial class FrmFuncionalidadeFormulario
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
            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.lblTipoFuncionalidade = new System.Windows.Forms.Label();
            this.cb_TipoFuncionalidade = new System.Windows.Forms.ComboBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.txtNomeTela = new System.Windows.Forms.TextBox();
            this.lbNomeTela = new System.Windows.Forms.Label();
            this.txtNomeFuncionalidade = new System.Windows.Forms.TextBox();
            this.lbNomeFuncionalidade = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCorpo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCorpo
            // 
            this.pnlCorpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCorpo.Controls.Add(this.lblTipoFuncionalidade);
            this.pnlCorpo.Controls.Add(this.cb_TipoFuncionalidade);
            this.pnlCorpo.Controls.Add(this.lblExcluir);
            this.pnlCorpo.Controls.Add(this.txtNomeTela);
            this.pnlCorpo.Controls.Add(this.lbNomeTela);
            this.pnlCorpo.Controls.Add(this.txtNomeFuncionalidade);
            this.pnlCorpo.Controls.Add(this.lbNomeFuncionalidade);
            this.pnlCorpo.Controls.Add(this.txtID);
            this.pnlCorpo.Controls.Add(this.lbId);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Size = new System.Drawing.Size(478, 186);
            this.pnlCorpo.TabIndex = 2;
            // 
            // lblTipoFuncionalidade
            // 
            this.lblTipoFuncionalidade.AutoSize = true;
            this.lblTipoFuncionalidade.Location = new System.Drawing.Point(184, 30);
            this.lblTipoFuncionalidade.Name = "lblTipoFuncionalidade";
            this.lblTipoFuncionalidade.Size = new System.Drawing.Size(31, 13);
            this.lblTipoFuncionalidade.TabIndex = 29;
            this.lblTipoFuncionalidade.Text = "Tipo ";
            // 
            // cb_TipoFuncionalidade
            // 
            this.cb_TipoFuncionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoFuncionalidade.FormattingEnabled = true;
            this.cb_TipoFuncionalidade.Location = new System.Drawing.Point(187, 46);
            this.cb_TipoFuncionalidade.Name = "cb_TipoFuncionalidade";
            this.cb_TipoFuncionalidade.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoFuncionalidade.TabIndex = 28;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Red;
            this.lblExcluir.Location = new System.Drawing.Point(15, 4);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(210, 17);
            this.lblExcluir.TabIndex = 27;
            this.lblExcluir.Text = "Confirma a deleção do registro?";
            this.lblExcluir.Visible = false;
            // 
            // txtNomeTela
            // 
            this.txtNomeTela.Location = new System.Drawing.Point(18, 142);
            this.txtNomeTela.Name = "txtNomeTela";
            this.txtNomeTela.Size = new System.Drawing.Size(290, 20);
            this.txtNomeTela.TabIndex = 4;
            // 
            // lbNomeTela
            // 
            this.lbNomeTela.AutoSize = true;
            this.lbNomeTela.Location = new System.Drawing.Point(15, 126);
            this.lbNomeTela.Name = "lbNomeTela";
            this.lbNomeTela.Size = new System.Drawing.Size(59, 13);
            this.lbNomeTela.TabIndex = 0;
            this.lbNomeTela.Text = "Nome Tela";
            // 
            // txtNomeFuncionalidade
            // 
            this.txtNomeFuncionalidade.Location = new System.Drawing.Point(18, 95);
            this.txtNomeFuncionalidade.Name = "txtNomeFuncionalidade";
            this.txtNomeFuncionalidade.Size = new System.Drawing.Size(290, 20);
            this.txtNomeFuncionalidade.TabIndex = 3;
            // 
            // lbNomeFuncionalidade
            // 
            this.lbNomeFuncionalidade.AutoSize = true;
            this.lbNomeFuncionalidade.Location = new System.Drawing.Point(15, 79);
            this.lbNomeFuncionalidade.Name = "lbNomeFuncionalidade";
            this.lbNomeFuncionalidade.Size = new System.Drawing.Size(35, 13);
            this.lbNomeFuncionalidade.TabIndex = 2;
            this.lbNomeFuncionalidade.Text = "Nome";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(15, 30);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(341, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 186);
            this.pnlBotoes.TabIndex = 5;
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
            // FrmFuncionalidadeFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 186);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCorpo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncionalidadeFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionalidade";
            this.Load += new System.EventHandler(this.FrmFuncionalidadeFormulario_Load);
            this.pnlCorpo.ResumeLayout(false);
            this.pnlCorpo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCorpo;
        private System.Windows.Forms.TextBox txtNomeTela;
        private System.Windows.Forms.Label lbNomeTela;
        private System.Windows.Forms.TextBox txtNomeFuncionalidade;
        private System.Windows.Forms.Label lbNomeFuncionalidade;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.Label lblTipoFuncionalidade;
        private System.Windows.Forms.ComboBox cb_TipoFuncionalidade;
    }
}