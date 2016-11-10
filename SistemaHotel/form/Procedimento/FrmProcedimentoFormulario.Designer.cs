namespace SistemaHotel.form.Procedimento
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
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblAtributo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.informações = new System.Windows.Forms.Panel();
            this.pnlFiltros.SuspendLayout();
            this.informações.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFiltros.Controls.Add(this.txtDescricao);
            this.pnlFiltros.Controls.Add(this.lblAtributo);
            this.pnlFiltros.Controls.Add(this.txtID);
            this.pnlFiltros.Controls.Add(this.lblId);
            this.pnlFiltros.Location = new System.Drawing.Point(12, 12);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(426, 281);
            this.pnlFiltros.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(9, 69);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(442, 205);
            this.txtDescricao.TabIndex = 25;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblAtributo
            // 
            this.lblAtributo.AutoSize = true;
            this.lblAtributo.Location = new System.Drawing.Point(6, 52);
            this.lblAtributo.Name = "lblAtributo";
            this.lblAtributo.Size = new System.Drawing.Size(58, 13);
            this.lblAtributo.TabIndex = 5;
            this.lblAtributo.Text = "Descrição ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(9, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 19;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, 55);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 36);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(3, 9);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 36);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // informações
            // 
            this.informações.Controls.Add(this.btnFechar);
            this.informações.Controls.Add(this.btnConfirmar);
            this.informações.Location = new System.Drawing.Point(461, 12);
            this.informações.Name = "informações";
            this.informações.Size = new System.Drawing.Size(134, 281);
            this.informações.TabIndex = 8;
            // 
            // FrmProcedimentoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 305);
            this.Controls.Add(this.pnlFiltros);
            this.Controls.Add(this.informações);
            this.Name = "FrmProcedimentoFormulario";
            this.Text = "FrmProcedimentoFormulario";
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            this.informações.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblAtributo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel informações;

    }
}