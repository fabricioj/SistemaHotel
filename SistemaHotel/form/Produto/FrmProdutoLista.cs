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
        private model.SistemaHotelContext _context;
        private repositorio.ProdutoRepositorio _produtoRepositorio;
        private model.Permissao _permissoes;

        public FrmProdutoLista( model.SistemaHotelContext context)
        {
            _context = context;
            _produtoRepositorio = new repositorio.ProdutoRepositorio(_context);
            InitializeComponent();            
            Util.acertaTabOrder(this);
        }

        private void atualizaLista()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Produto>(_produtoRepositorio.getProdutos(txtDescricao.Text)), null);
            gridRegistros.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void FrmProdutoLista_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, Name);
            if (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
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
                FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Insercao, _context, new model.Produto());
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
                    var produto = (model.Produto)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Alteracao, _context, produto);
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
                    var produto = (model.Produto)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Exclusao, _context, produto);
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
                var produto = (model.Produto)gridRegistros.CurrentRow.DataBoundItem;
                FrmProdutoFormulario formulario = new FrmProdutoFormulario(Operacao.Consulta, _context, produto);
                formulario.ShowDialog();
            }
            
        }
    }
}
