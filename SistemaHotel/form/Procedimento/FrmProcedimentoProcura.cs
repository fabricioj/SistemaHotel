using SistemaHotel.dao;
using SistemaHotel.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.form.Procedimento
{
    public partial class FrmProcedimentoProcura : Form
    {
        private repositorio.ProcedimentoRepositorio _procedimentoRepositorio;
        public model.Procedimento procedimento;
        public FrmProcedimentoProcura(model.SistemaHotelContext context)
        {
            this._procedimentoRepositorio = new repositorio.ProcedimentoRepositorio(context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Procedimento>(_procedimentoRepositorio.getProcedimentos(txtDescricao.Text)), null);
            gridRegistros.Refresh();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.procedimento = (model.Procedimento)gridRegistros.CurrentRow.DataBoundItem;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
