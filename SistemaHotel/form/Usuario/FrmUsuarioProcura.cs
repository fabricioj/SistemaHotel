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

namespace SistemaHotel.form.Usuario
{
    public partial class FrmUsuarioProcura : Form
    {
        private repositorio.UsuarioRepositorio _usuarioRepositorio;
        public model.Usuario usuario;
        public FrmUsuarioProcura(model.SistemaHotelContext context)
        {
            this._usuarioRepositorio = new repositorio.UsuarioRepositorio(context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Usuario>(_usuarioRepositorio.getUsuarios(txtNome.Text)), null);
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
                this.usuario = (model.Usuario)gridRegistros.CurrentRow.DataBoundItem;
            }
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
