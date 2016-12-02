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

namespace SistemaHotel.form.Funcionalidade
{
    public partial class FrmFuncionalidadeProcura : Form
    {
        private repositorio.FuncionalidadeRepositorio _funcionalidadeRepositorio;
        public model.Funcionalidade funcionalidade;
        public FrmFuncionalidadeProcura(model.SistemaHotelContext context)
        {
            this._funcionalidadeRepositorio = new repositorio.FuncionalidadeRepositorio(context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Funcionalidade>(_funcionalidadeRepositorio.getFuncionalidades(txtNome.Text)), null);
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
                this.funcionalidade = (model.Funcionalidade)gridRegistros.CurrentRow.DataBoundItem;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
