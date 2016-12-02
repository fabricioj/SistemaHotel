namespace SistemaHotel.form.Perfil
{
    partial class FrmPerfilFormulario
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlCorpo = new System.Windows.Forms.Panel();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.cbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblExcluir = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.pnlCorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnConfirmar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoes.Location = new System.Drawing.Point(281, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(137, 134);
            this.pnlBotoes.TabIndex = 6;
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
            // pnlCorpo
            // 
            this.pnlCorpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCorpo.Controls.Add(this.lblSupervisor);
            this.pnlCorpo.Controls.Add(this.cbSupervisor);
            this.pnlCorpo.Controls.Add(this.lblExcluir);
            this.pnlCorpo.Controls.Add(this.txtNome);
            this.pnlCorpo.Controls.Add(this.lbNome);
            this.pnlCorpo.Controls.Add(this.txtID);
            this.pnlCorpo.Controls.Add(this.lbId);
            this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCorpo.Location = new System.Drawing.Point(0, 0);
            this.pnlCorpo.Name = "pnlCorpo";
            this.pnlCorpo.Size = new System.Drawing.Size(418, 134);
            this.pnlCorpo.TabIndex = 5;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(141, 32);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(57, 13);
            this.lblSupervisor.TabIndex = 29;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupervisor.FormattingEnabled = true;
            this.cbSupervisor.Location = new System.Drawing.Point(144, 48);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(121, 21);
            this.cbSupervisor.TabIndex = 28;
            // 
            // lblExcluir
            // 
            this.lblExcluir.AutoSize = true;
            this.lblExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcluir.ForeColor = System.Drawing.Color.Red;
            this.lblExcluir.Location = new System.Drawing.Point(12, 4);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(210, 17);
            this.lblExcluir.TabIndex = 27;
            this.lblExcluir.Text = "Confirma a deleção do registro?";
            this.lblExcluir.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 87);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Tag = "label1";
            this.lbNome.Text = "Nome";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 1;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 32);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Tag = "label1";
            this.lbId.Text = "ID";
            // 
            // FrmPerfilFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 134);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCorpo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPerfilFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.FrmPerfilFormulario_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlCorpo.ResumeLayout(false);
            this.pnlCorpo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pnlCorpo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lblExcluir;
        private System.Windows.Forms.ComboBox cbSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
    }
}