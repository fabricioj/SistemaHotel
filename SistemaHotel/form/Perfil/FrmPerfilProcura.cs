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

namespace SistemaHotel.form.Perfil
{
    public partial class FrmPerfilProcura : Form
    {
        private repositorio.PerfilRepositorio perfilRepositorio;
        public model.Perfil perfil;


        public FrmPerfilProcura(model.SistemaHotelContext context)
        {
            this.perfilRepositorio = new repositorio.PerfilRepositorio(context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }
   

        private void FrmPerfilProcura_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Perfil>(perfilRepositorio.getPerfis(txtNome.Text)), null);
            gridRegistros.Refresh();

        }


        public model.SistemaHotelContext context { get; set; }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                perfil = (model.Perfil)gridRegistros.CurrentRow.DataBoundItem;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
