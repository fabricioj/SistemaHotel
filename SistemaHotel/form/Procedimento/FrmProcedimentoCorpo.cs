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

namespace SistemaHotel.form.Procedimento
{
    public partial class FrmProcedimentoCorpo : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Procedimento _procedimento;
        private repositorio.Procedimento_passoRepositorio _procedimento_passoRepositorio;
        private repositorio.Procedimento_passo_produtoRepositorio _procedimento_passo_produtoRepositorio;
        private string gridSelecionado = "PASSO";

        public FrmProcedimentoCorpo(Operacao op, model.SistemaHotelContext context, model.Procedimento procedimento)
        {
            _op = op;
            _context = context;
            _procedimento = procedimento;
            _procedimento_passoRepositorio = new repositorio.Procedimento_passoRepositorio(_context);
            _procedimento_passo_produtoRepositorio = new repositorio.Procedimento_passo_produtoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 1) //Passos
            {
                if (gridSelecionado == "PRODUTO")
                {// Produto
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum passo selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                        FrmProcedimentoPassoProduto produto = new FrmProcedimentoPassoProduto(Operacao.Insercao, _context, passo, new model.Procedimento_passo_produto());
                        produto.ShowDialog();
                    }

                }
                else
                {// Passo

                    FrmProcedimentoPasso passo_procedimento = new FrmProcedimentoPasso(Operacao.Insercao, _context, _procedimento, new model.Procedimento_passo());
                    passo_procedimento.ShowDialog();

                }
            }
            preencheForm();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 0) //Principal
            {
                FrmProcedimentoFormulario formulario = new FrmProcedimentoFormulario(Operacao.Alteracao, _context, _procedimento);
                formulario.ShowDialog();
            }
            else
            {
                if (gridSelecionado == "PRODUTO") // Produto
                {
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum passo selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        model.Procedimento_passo passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;

                        if (gridProdutos_utilizados.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo_produto)gridProdutos_utilizados.CurrentRow.DataBoundItem).id == 0)
                            MessageBox.Show("Nenhum registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            var produto_utilizado = (model.Procedimento_passo_produto)gridProdutos_utilizados.CurrentRow.DataBoundItem;
                            FrmProcedimentoPassoProduto produto = new FrmProcedimentoPassoProduto(Operacao.Alteracao, _context, passo, produto_utilizado);
                            produto.ShowDialog();
                        }
                    }

                }
                else // Passo
                {
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                        FrmProcedimentoPasso passo_procedimento = new FrmProcedimentoPasso(Operacao.Alteracao, _context, _procedimento, passo);
                        passo_procedimento.ShowDialog();
                    }
                }

            }
            preencheForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 1) //Passos
            {
                if (gridSelecionado == "PRODUTO") // Produto
                {
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum passo selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (gridProdutos_utilizados.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo_produto)gridProdutos_utilizados.CurrentRow.DataBoundItem).id == 0)
                        {
                            MessageBox.Show("Nenhum registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                            var produto_utilizado = (model.Procedimento_passo_produto)gridProdutos_utilizados.CurrentRow.DataBoundItem;
                            FrmProcedimentoPassoProduto produto = new FrmProcedimentoPassoProduto(Operacao.Exclusao, _context, passo, produto_utilizado);
                            produto.ShowDialog();

                        }
                    }

                }
                else // Passo
                {
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                        FrmProcedimentoPasso passo_procedimento = new FrmProcedimentoPasso(Operacao.Exclusao, _context, _procedimento, passo);
                        passo_procedimento.ShowDialog();
                    }
                }
            }
            preencheForm();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 0) //Principal
            {
                FrmProcedimentoFormulario formulario = new FrmProcedimentoFormulario(Operacao.Consulta, _context, _procedimento);
                formulario.ShowDialog();
            }
            else
            {
                if (gridSelecionado == "PRODUTO") // Produto
                {
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum passo selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (gridProdutos_utilizados.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo_produto)gridProdutos_utilizados.CurrentRow.DataBoundItem).id == 0)
                        {
                            MessageBox.Show("Nenhum registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            model.Procedimento_passo passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                            var produto_utilizado = (model.Procedimento_passo_produto)gridProdutos_utilizados.CurrentRow.DataBoundItem;

                            FrmProcedimentoPassoProduto produto = new FrmProcedimentoPassoProduto(Operacao.Consulta, _context, passo, produto_utilizado);
                            produto.ShowDialog();

                        }
                    }

                }
                else // Passo
                {
                    if (gridPassos.CurrentRow.DataBoundItem == null || ((model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem).id == 0)
                        MessageBox.Show("Nenhum registro selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                        FrmProcedimentoPasso passo_procedimento = new FrmProcedimentoPasso(Operacao.Consulta, _context, _procedimento, passo);
                        passo_procedimento.ShowDialog();
                    }
                }

            }
        }

        private void FrmProcedimento_Load(object sender, EventArgs e)
        {
            preencheForm();
            tabAbas.SelectedIndex = 1;
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtDescricao.Enabled = true;

            txtID.Text = _procedimento.id.ToString().Trim();
            txtDescricao.Text = _procedimento.descricao;

            //Aba passos
            var list = _procedimento_passoRepositorio.getProcedimento_passos(_procedimento.id);
            if (list.Count == 0)
                list.Add(new model.Procedimento_passo());
            gridPassos.DataSource = new BindingSource(new BindingList<model.Procedimento_passo>(list), null);
            gridPassos.Refresh();

            selecionaPasso();

            txtID.Enabled = false;
            txtDescricao.Enabled = false;

            btnConfirmar.Enabled = true;
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            if (_op == Operacao.Consulta)
            {

                btnConfirmar.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else
            {
                btnFechar.Enabled = false;
            }

            carregaAbas();
        }

        private void carregaAbas()
        {
            if (_op != Operacao.Consulta)
            {
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                if (tabAbas.SelectedIndex == 0) // Principal
                {
                    btnInserir.Enabled = false;
                    btnExcluir.Enabled = false;
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tabAbas_Selected(object sender, TabControlEventArgs e)
        {
            carregaAbas();
        }

        private void gridPassos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selecionaPasso();
            gridSelecionado = "PASSO";
        }
        private void gridProdutos_utilizados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridSelecionado = "PRODUTO";
        }

        private void selecionaPasso()
        {
            if (gridPassos.CurrentRow != null && gridPassos.CurrentRow.DataBoundItem != null)
            {
                var passo = (model.Procedimento_passo)gridPassos.CurrentRow.DataBoundItem;
                var list = _procedimento_passo_produtoRepositorio.getProcedimento_passo_produtos(passo.id);
                if (list.Count == 0)
                    list.Add(new model.Procedimento_passo_produto());
                gridProdutos_utilizados.DataSource = new BindingSource(new BindingList<model.Procedimento_passo_produto>(list), null);
                gridProdutos_utilizados.Refresh();
            }
        }

        private void gridPassos_SelectionChanged(object sender, EventArgs e)
        {
            selecionaPasso();
        }
    }
}
