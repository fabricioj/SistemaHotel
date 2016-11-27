using SistemaHotel.form.Produto;
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
    public partial class FrmProcedimentoPassoProduto : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Procedimento_passo _procedimento_passo;
        private model.Procedimento_passo_produto _procedimento_passo_produto;
        private repositorio.Procedimento_passo_produtoRepositorio _procedimento_passo_produtoRepositorio;

        public FrmProcedimentoPassoProduto(Operacao op, model.SistemaHotelContext context, model.Procedimento_passo procedimento_passo, model.Procedimento_passo_produto procedimento_passo_produto)
        {
            _op = op;
            _context = context;
            _procedimento_passo = procedimento_passo;
            _procedimento_passo_produto = procedimento_passo_produto;
            _procedimento_passo_produtoRepositorio = new repositorio.Procedimento_passo_produtoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _procedimento_passo_produtoRepositorio.incluir(ref _procedimento_passo_produto);
                        _procedimento_passo_produtoRepositorio.salvar();
                        _procedimento_passo_produto = new model.Procedimento_passo_produto();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _procedimento_passo_produtoRepositorio.alterar(_procedimento_passo_produto);
                        _procedimento_passo_produtoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _procedimento_passo_produtoRepositorio.excluir(_procedimento_passo_produto);
                        _procedimento_passo_produtoRepositorio.salvar();
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

        private void FrmProcedimentoPassoProduto_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtProduto_id.Enabled = true;
            txtProduto_descricao.Enabled = true;
            txtQuantidade_utilizada.Enabled = true;
            btnPesquisaProduto.Enabled = true;


            txtID.Text = _procedimento_passo_produto.id.ToString().Trim();
            txtProduto_id.Text = _procedimento_passo_produto.editProduto_id.ToString().Trim();
            txtProduto_descricao.Text = string.Empty;
            if (_procedimento_passo_produto.produto != null)
                txtProduto_descricao.Text = _procedimento_passo_produto.produto.descricao;
            txtQuantidade_utilizada.Text = _procedimento_passo_produto.quantidade_utilizada.ToString().Trim();

            txtID.Enabled = false;
            txtProduto_descricao.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {
                txtProduto_id.Enabled = false;
                txtProduto_descricao.Enabled = false;
                txtQuantidade_utilizada.Enabled = false;
                btnPesquisaProduto.Enabled = false;


                if (_op == Operacao.Exclusao)
                {
                    lblExcluir.Visible = true;
                }

                if (_op == Operacao.Consulta)
                {
                    btnConfirmar.Enabled = false;
                }
            }
        }

        private void preencheObjeto() {
            _procedimento_passo_produto.id = int.Parse(txtID.Text);
            _procedimento_passo_produto.procedimento_passo_id = _procedimento_passo.id;
            _procedimento_passo_produto.procedimento_passo = _procedimento_passo;
            _procedimento_passo_produto.quantidade_utilizada = double.Parse(txtQuantidade_utilizada.Text);

            _procedimento_passo_produto.editProduto_id = int.Parse(txtProduto_id.Text);
            validaProduto();
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoProcura procuraProduto = new FrmProdutoProcura();
            procuraProduto.ShowDialog();
            if (procuraProduto.produto != null)
            {
                _procedimento_passo_produto.editProduto_id = procuraProduto.produto.id;
            }
            txtProduto_id.Text = _procedimento_passo_produto.editProduto_id.ToString().Trim();
            txtProduto_id.Focus();
        }

        private void txtProduto_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtProduto_descricao.Text = string.Empty;

                if (string.IsNullOrEmpty(txtProduto_id.Text))
                    txtProduto_id.Text = "0";

                _procedimento_passo_produto.editProduto_id = int.Parse(txtProduto_id.Text);
                validaProduto();
                if (_procedimento_passo_produto.produto != null) {
                    _procedimento_passo_produto.editProduto_id = _procedimento_passo_produto.produto.id;
                    txtProduto_descricao.Text = _procedimento_passo_produto.produto.descricao;
                }          
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProduto_id.Focus();
            }
        }
        private void validaProduto()
        {
           _procedimento_passo_produto.produto = null;
            if (_procedimento_passo_produto.editProduto_id != 0)
            {
                _procedimento_passo_produto.produto = (new repositorio.ProdutoRepositorio(_context)).getProdutoporID(_procedimento_passo_produto.editProduto_id);

                if (_procedimento_passo_produto.produto == null)
                {
                    throw new Exception("Produto não existe");
                }
            }
        }
    }
}
