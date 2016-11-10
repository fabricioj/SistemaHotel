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
            this.lbId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lbServico = new System.Windows.Forms.Label();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(27, 9);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(18, 13);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "ID";
            this.lbId.Click += new System.EventHandler(this.lbId_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(50, 20);
            this.txtID.TabIndex = 1;
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Location = new System.Drawing.Point(351, 9);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(41, 13);
            this.lbLocal.TabIndex = 2;
            this.lbLocal.Text = "LOCAL";
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(354, 25);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(253, 20);
            this.txtLocal.TabIndex = 3;
            // 
            // lbServico
            // 
            this.lbServico.AutoSize = true;
            this.lbServico.Location = new System.Drawing.Point(100, 10);
            this.lbServico.Name = "lbServico";
            this.lbServico.Size = new System.Drawing.Size(54, 13);
            this.lbServico.TabIndex = 4;
            this.lbServico.Text = "SERVIÇO";
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Location = new System.Drawing.Point(27, 59);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(80, 13);
            this.lbObservacao.TabIndex = 6;
            this.lbObservacao.Text = "OBSERVAÇÃO";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(30, 75);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(229, 45);
            this.txtObservacao.TabIndex = 7;
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(104, 26);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(214, 20);
            this.txtServico.TabIndex = 8;
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(275, 75);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(71, 13);
            this.lbDataInicio.TabIndex = 9;
            this.lbDataInicio.Text = "DATA INÍCIO";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(278, 94);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(88, 20);
            this.txtDataInicio.TabIndex = 10;
            // 
            // FrmSolicitacaoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 305);
            this.Controls.Add(this.txtDataInicio);
            this.Controls.Add(this.lbDataInicio);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.lbServico);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lbLocal);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSolicitacaoFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitacões";
            this.Load += new System.EventHandler(this.FrmSolicitacaoFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lbServico;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.TextBox txtDataInicio;
    }
}