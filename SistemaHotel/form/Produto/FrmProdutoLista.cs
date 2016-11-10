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

namespace SistemaHotel.form.Produto
{
    public partial class FrmProdutoLista : Form
    {
        private repositorio.ProdutoRepositorio _produtoRepositorio;
        private model.Permissao_old _permissoes;

        public FrmProdutoLista()
        {
            InitializeComponent();
            _produtoRepositorio = new repositorio.ProdutoRepositorio();
            Util.acertaTabOrder(this);
        }

        private void atualizaLista()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Produto>(_produtoRepositorio.getProdutos()), null);
            gridRegistros.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void FrmProdutoLista_Load(object sender, EventArgs e)
        {
            _permissoes = dao.PermissaoDao.getPermissaoFuncionalidadeNome(Name);
            if (_permissoes.consultar == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            atualizaLista();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.inserir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Insercao, _produtoRepositorio, new model.Produto());
                formulario.ShowDialog();
                atualizaLista();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_permissoes.alterar == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
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
                    var produto = (model.Produto)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Alteracao,  _produtoRepositorio, produto);
                    formulario.ShowDialog();
                    atualizaLista();
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.excluir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
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
                    var produto = (model.Produto)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Exclusao, _produtoRepositorio, produto);
                    formulario.ShowDialog();
                    atualizaLista();
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (_permissoes.excluir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
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
                    var produto = (model.Produto)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Exclusao, _produtoRepositorio, produto);
                    formulario.ShowDialog();
                }

            }
        }
    }
}
