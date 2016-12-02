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

namespace SistemaHotel.form.Morador
{
    public partial class FrmProcuraMorador : Form
    {
        private repositorio.MoradorRepositorio _moradorRepositorio;
        public model.Morador morador;


        public FrmProcuraMorador(model.SistemaHotelContext context)
        {
            this._moradorRepositorio = new repositorio.MoradorRepositorio (context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }        

        private void FrmProcuraMorador_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gridRegistros.DataSource =  new BindingSource(new BindingList<model.Morador>(_moradorRepositorio.getMoradores(txtNome.Text)),null);
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
                this.morador = (model.Morador)gridRegistros.CurrentRow.DataBoundItem;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
