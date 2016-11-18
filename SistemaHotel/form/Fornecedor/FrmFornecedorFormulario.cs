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

namespace SistemaHotel.form.Fornecedor
{
    public partial class FrmFornecedorFormulario : Form
    {
        private Operacao _op;
        private model.Fornecedor _fornecedor;
        private repositorio.FornecedorRepositorio _fornecedorRepositorio;
        private model.SistemaHotelContext _context;

        public FrmFornecedorFormulario(Operacao op, model.SistemaHotelContext context, model.Fornecedor fornecedor)
        {
            _op = op;
            _context = context;
            _fornecedor = fornecedor;
            _fornecedorRepositorio = new repositorio.FornecedorRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void preencheForm() {
            txtID.Enabled           = true;
            txtNome.Enabled         = true;
            txtRazaoSocial.Enabled  = true;
            txtEmail.Enabled        = true;
            txtCNPJ.Enabled         = true;
            txtTelefone.Enabled     = true;
            txtEndereco.Enabled     = true;
            txtNumero.Enabled       = true;
            txtBairro.Enabled       = true;
            txtCep.Enabled          = true;
            txtCidade.Enabled       = true;
            txtUf.Enabled           = true;

            txtID.Text          = _fornecedor.id.ToString().Trim();
            txtNome.Text        = _fornecedor.nome;
            txtRazaoSocial.Text = _fornecedor.razao_social;
            txtEmail.Text       = _fornecedor.email;
            txtCNPJ.Text        = _fornecedor.cnpj;
            txtTelefone.Text    = _fornecedor.telefone;
            txtEndereco.Text    = _fornecedor.endereco;
            txtNumero.Text      = _fornecedor.numero;
            txtBairro.Text      = _fornecedor.bairro;
            txtCep.Text         = _fornecedor.cep;
            txtCidade.Text      = _fornecedor.cidade;
            txtUf.Text          = _fornecedor.estado;

            txtID.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {   
                txtNome.Enabled         = false;
                txtRazaoSocial.Enabled  = false;
                txtEmail.Enabled        = false;
                txtCNPJ.Enabled         = false;
                txtTelefone.Enabled     = false;
                txtEndereco.Enabled     = false;
                txtNumero.Enabled       = false;
                txtBairro.Enabled       = false;
                txtCep.Enabled          = false;
                txtCidade.Enabled       = false;
                txtUf.Enabled           = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;
            }
        }
        private void preencheObjeto() {
            _fornecedor.id =int.Parse(txtID.Text);
            _fornecedor.nome         = txtNome.Text       ;
            _fornecedor.email        = txtEmail.Text      ;
            _fornecedor.razao_social = txtRazaoSocial.Text;
            _fornecedor.cnpj         = txtCNPJ.Text       ;
            _fornecedor.telefone     = txtTelefone.Text   ;
            _fornecedor.endereco     = txtEndereco.Text   ;
            _fornecedor.numero       = txtNumero.Text     ;
            _fornecedor.bairro       = txtBairro.Text     ;
            _fornecedor.cep          = txtCep.Text        ;
            _fornecedor.cidade       = txtCidade.Text     ;
            _fornecedor.estado       = txtUf.Text         ;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _fornecedorRepositorio.incluir(_fornecedor);
                        _fornecedorRepositorio.salvar();
                        _fornecedor = new model.Fornecedor();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _fornecedorRepositorio.alterar(_fornecedor);
                        _fornecedorRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _fornecedorRepositorio.excluir(_fornecedor);
                        _fornecedorRepositorio.salvar();
                        Dispose();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmFornecedorFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
