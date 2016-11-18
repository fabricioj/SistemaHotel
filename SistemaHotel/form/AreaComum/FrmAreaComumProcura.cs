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

namespace SistemaHotel.form.AreaComum
{
    public partial class FrmAreaComumProcura : Form
    {
        private repositorio.Area_comumRepositorio _area_comumRepositorio;
        public model.Area_comum area_comum;
        public FrmAreaComumProcura(model.SistemaHotelContext context)
        {
            this._area_comumRepositorio = new repositorio.Area_comumRepositorio(context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Area_comum>(_area_comumRepositorio.getArea_comuns(txtNome.Text)), null);
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
                this.area_comum = (model.Area_comum)gridRegistros.CurrentRow.DataBoundItem;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
