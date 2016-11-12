using SistemaHotel.form.Produto;
using SistemaHotel.model;
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

namespace SistemaHotel.form.Orcamento
{
    public partial class FrmOrcamentoItem : Form
    {
        private Operacao _op;
        private model.Orcamento _orcamento;
        private model.Orcamento_item _orcamento_item;
        private model.SistemaHotelContext _context;
        private repositorio.Orcamento_itemRepositorio _orcamento_itemRepositorio;

        public FrmOrcamentoItem(Operacao op, model.SistemaHotelContext context, model.Orcamento orcamento, model.Orcamento_item orcamento_item)
        {
            InitializeComponent();
            this._op = op;
            this._context = context;
            this._orcamento = orcamento;
            this._orcamento_item = orcamento_item;
            this._orcamento_itemRepositorio = new repositorio.Orcamento_itemRepositorio(_context);

            Util.acertaTabOrder(this);
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtObservacao.Enabled = true;
            txtProduto_id.Enabled = true;
            txtProduto_descricao.Enabled = true;
            txtQuantidade.Enabled = true;
            txtQuantidade_comprada.Enabled = true;
            txtTotal.Enabled = true;
            txtValor.Enabled = true;

            txtID.Text = _orcamento_item.id.ToString().Trim();
            txtObservacao.Text = _orcamento_item.observacao;
            txtProduto_id.Text = _orcamento_item.edtProduto_id.ToString().Trim();

            if (_orcamento_item.produto != null)
                txtProduto_descricao.Text = _orcamento_item.produto.descricao;

            txtQuantidade.Text = _orcamento_item.quantidade.ToString().Trim();
            txtQuantidade_comprada.Text = _orcamento_item.quantidade_comprada.ToString().Trim();
            txtValor.Text = _orcamento_item.valor.ToString().Trim();
            txtTotal.Text = _orcamento_item.total.ToString().Trim();


            txtID.Enabled = false;
            txtProduto_descricao.Enabled = false;
            txtQuantidade_comprada.Enabled = false;
            txtTotal.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtObservacao.Enabled = false;
                txtProduto_id.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;

                btnPesquisaProduto.Enabled = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;
            }
        }
        private void preencheObjeto()
        {
            _orcamento_item.id = int.Parse(txtID.Text);
            _orcamento_item.observacao = txtObservacao.Text;
            _orcamento_item.orcamento_id = _orcamento.id;
            _orcamento_item.orcamento = _orcamento;

            _orcamento_item.quantidade = double.Parse(txtQuantidade.Text);
            _orcamento_item.quantidade_comprada = double.Parse(txtQuantidade_comprada.Text);
            _orcamento_item.valor = double.Parse(txtValor.Text);


            _orcamento_item.edtProduto_id = int.Parse(txtProduto_id.Text);
            if (_orcamento_item.edtProduto_id != 0)
                validaProduto();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _orcamento_itemRepositorio.incluir(ref _orcamento_item);
                        _orcamento_itemRepositorio.salvar();
                        _orcamento_item = new model.Orcamento_item();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _orcamento_itemRepositorio.alterar(_orcamento_item);
                        _orcamento_itemRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _orcamento_itemRepositorio.excluir(_orcamento_item);
                        _orcamento_itemRepositorio.salvar();
                        Dispose();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmOrcamentoItem_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoProcura procuraProduto = new FrmProdutoProcura();
            procuraProduto.ShowDialog();
            if (procuraProduto.produto != null)
            {
                _orcamento_item.edtProduto_id = procuraProduto.produto.id;
            }
            txtProduto_id.Text = _orcamento_item.edtProduto_id.ToString().Trim();
            txtProduto_id.Focus();
        }

        private void txtProduto_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtProduto_descricao.Text = string.Empty;
                validaProduto();
                if (_orcamento_item.produto != null)
                    txtProduto_descricao.Text = _orcamento_item.produto.descricao;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProduto_id.Focus();
            }
        }
        private void validaProduto()
        {
            if (string.IsNullOrEmpty(txtProduto_id.Text))
                txtProduto_id.Text = "0";

            _orcamento_item.produto = null;

            _orcamento_item.edtProduto_id = int.Parse(txtProduto_id.Text);
            if (_orcamento_item.edtProduto_id != 0)
            {
                _orcamento_item.produto = (new repositorio.ProdutoRepositorio(_context)).getProdutoporID(_orcamento_item.edtProduto_id);

                if (_orcamento_item.produto == null)
                {
                    throw new Exception("Produto não existe");
                }
            }
        }
        private void atualizaTotal()
        {
            _orcamento_item.quantidade = double.Parse(txtQuantidade.Text);
            _orcamento_item.valor = double.Parse(txtValor.Text);
            txtTotal.Text = _orcamento_item.total.ToString().Trim();
        }

        private void txtQuantidade_Validated(object sender, EventArgs e)
        {
            try
            {
                atualizaTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantidade.Focus();
            }

        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            try
            {
                atualizaTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Focus();
            }
        }
    }
}
