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

namespace SistemaHotel.form.Permissao
{
    public partial class FrmPermissaoLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.PermissaoRepositorio _permissaoRepositorio;
        private model.Permissao _permissoes;

        public FrmPermissaoLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _permissaoRepositorio = new repositorio.PermissaoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editInserir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Insercao, _context, new model.Permissao());
                formulario.ShowDialog();
                atualizaLista();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_permissoes.editAlterar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para alterar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var permissao = (model.Permissao)gridRegistros.CurrentRow.DataBoundItem;
                    FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Alteracao, _context, permissao);
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
            else
            {

                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var permissao = (model.Permissao)gridRegistros.CurrentRow.DataBoundItem;
                    FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Exclusao, _context, permissao);
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
            else
            {
                var permissao = (model.Permissao)gridRegistros.CurrentRow.DataBoundItem;
                FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Consulta, _context, permissao);
                formulario.ShowDialog();
            }
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {

        }

        private void FrmPermissao_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
            if (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            atualizaLista();
            if (_permissoes.editSupervisor == util.SimNao.NAO)
            {
                btnPermissao.Visible = false;
            }
        }

        private void atualizaLista()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Permissao>(_permissaoRepositorio.getPermissoes()), null);
            gridRegistros.Refresh();
        }
    }
}
