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
    public partial class FrmUsuarioLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.UsuarioRepositorio _usuarioRepositorio;

        private model.Permissao _permissoes;

        public FrmUsuarioLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _usuarioRepositorio = new repositorio.UsuarioRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }
        public void atualizaLista() {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Usuario>(_usuarioRepositorio.getUsuarios(txtNome.Text)), null);
            gridRegistros.Refresh();
        }

        private void FrmUsuarioLista_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context,_usuarioLogado, Name);
            if (_permissoes == null || (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO))
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }
            atualizaLista();
          
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editInserir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir outro usuario ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmUsuarioFormulario formulario = new FrmUsuarioFormulario(Operacao.Insercao, _context, new model.Usuario());
                formulario.ShowDialog();
                atualizaLista();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_permissoes.editAlterar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuario não tem permissão para alterar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    var usuario = (model.Usuario)gridRegistros.CurrentRow.DataBoundItem;
                    FrmUsuarioFormulario formulario = new FrmUsuarioFormulario(Operacao.Alteracao, _context, usuario);
                    formulario.ShowDialog();
                    atualizaLista();
             
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editExcluir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para excluir outro usuario", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var usuario = (model.Usuario)gridRegistros.CurrentRow.DataBoundItem;
                    FrmUsuarioFormulario formulario = new FrmUsuarioFormulario(Operacao.Exclusao, _context, usuario);
                    formulario.ShowDialog();
                    atualizaLista();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var usuario = (model.Usuario)gridRegistros.CurrentRow.DataBoundItem;
                FrmUsuarioFormulario formulario = new FrmUsuarioFormulario(Operacao.Consulta, _context, usuario);
                formulario.ShowDialog();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            using (var permissaoLista = new Permissao.FrmPermissaoLista(_context, _usuarioLogado, Name))
            {
                permissaoLista.ShowDialog();
            }
        }
    }
}
