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
    public partial class FrmProdutoFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Produto _produto;
        private repositorio.ProdutoRepositorio _produtoRepositorio;

        public FrmProdutoFormulario(Operacao op, model.SistemaHotelContext context, model.Produto produto)
        {
            
            _op = op;
            _context = context;
            _produtoRepositorio = new repositorio.ProdutoRepositorio(_context);
            _produto = produto;

            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void preencheForm()
        {
            cbControla_estoque.DataSource = util.EnumHelper.ToList(typeof(SimNao));
            cbControla_estoque.DisplayMember = "Value";
            cbControla_estoque.ValueMember = "Key";

            txtID.Enabled = true;
            txtDescricao.Enabled = true;
            cbControla_estoque.Enabled = true;
            txtQuantidade.Enabled = true;

            txtID.Text = _produto.id.ToString().Trim();
            txtDescricao.Text = _produto.descricao;
            cbControla_estoque.SelectedItem = util.EnumHelper.SetValue(_produto.editControla_estoque);
            txtQuantidade.Text = _produto.quantidade.ToString();

            txtID.Enabled = false;
            txtQuantidade.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtDescricao.Enabled = false;
                cbControla_estoque.Enabled = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;

            }
        }
        private void preencheObjeto()
        {
            _produto.id =int.Parse(txtID.Text);
            _produto.descricao = txtDescricao.Text;
            _produto.editControla_estoque = (SimNao)util.EnumHelper.GetValue(cbControla_estoque.SelectedItem);
            _produto.quantidade = double.Parse(txtQuantidade.Text);
        }

        private void FrmProdutoFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _produtoRepositorio.incluir(ref _produto);
                        _produtoRepositorio.salvar();
                        _produto = new model.Produto();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _produtoRepositorio.alterar(_produto);
                        _produtoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _produtoRepositorio.excluir(_produto);
                        _produtoRepositorio.salvar();
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
    }
}
