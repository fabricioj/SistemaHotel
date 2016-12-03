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
    public partial class FrmPerfilLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.PerfilRepositorio _perfilRepositorio;

        private model.Permissao _permissoes;

        public FrmPerfilLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _perfilRepositorio = new repositorio.PerfilRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }
        private void atualizaLista()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Perfil>(_perfilRepositorio.getPerfis()), null);
            gridRegistros.Refresh();
        }

        private void FrmPerfilLista_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
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
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                FrmPerfilFormulario formulario = new FrmPerfilFormulario(Operacao.Insercao, _context, new model.Perfil());
                formulario.ShowDialog();
                atualizaLista();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_permissoes.editAlterar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else

                {
                    var perfil = (model.Perfil)gridRegistros.CurrentRow.DataBoundItem;
                    FrmPerfilFormulario formulario = new FrmPerfilFormulario(Operacao.Alteracao, _context, perfil);
                    formulario.ShowDialog();
                    atualizaLista();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editExcluir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para excluir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var perfil = (model.Perfil)gridRegistros.CurrentRow.DataBoundItem;
                    FrmPerfilFormulario formulario =  new FrmPerfilFormulario(Operacao.Exclusao, _context, perfil);
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
                var perfil = (model.Perfil)gridRegistros.CurrentRow.DataBoundItem;
                FrmPerfilFormulario formulario = new FrmPerfilFormulario(Operacao.Consulta, _context, perfil);
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
