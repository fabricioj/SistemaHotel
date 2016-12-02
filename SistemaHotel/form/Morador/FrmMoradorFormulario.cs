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

namespace SistemaHotel.form.Morador
{
    public partial class FrmMoradorFormulario : Form
    {
        private Operacao _op;
        private model.Morador _morador;
        private repositorio.MoradorRepositorio _moradorRepositorio;
        private model.SistemaHotelContext _context;
        public FrmMoradorFormulario(Operacao op, model.SistemaHotelContext context, model.Morador morador)
        {
            _op = op;
            _context = context;
            _morador = morador;
            _moradorRepositorio = new repositorio.MoradorRepositorio(_context);
            InitializeComponent();
          Util.acertaTabOrder(this);
        }

        private void preencheForm()
        {
            txtId.Enabled                    = true;
            txtNome.Enabled                  = true;
            txtRg.Enabled                = true;
            txtCelular.Enabled               =  true;
            txtTelefoneFixo.Enabled          = true;
            txtEmail.Enabled                 = true;
            txtEmpresa.Enabled               = true;
            txtTelefoneComercial.Enabled     = true;

            txtId.Text                  = _morador.id.ToString().Trim();
            txtNome.Text                = _morador.nome;
            txtRg.Text                  = _morador.rg;
            txtCelular.Text             = _morador.celular;
            txtTelefoneFixo.Text        = _morador.telefone_comercial;
            txtEmail.Text               = _morador.email;
            txtEmpresa.Text             = _morador.empresa;
            txtTelefoneComercial.Text   = _morador.telefone_comercial;

            txtId.Enabled = false;

            if (_op == Operacao.Consulta ||_op == Operacao.Exclusao)
            {
                txtNome.Enabled              = false;
                txtRg.Enabled                = false;
                txtCpf.Enabled               = false;
                txtCelular.Enabled           =  false;
                txtTelefoneFixo.Enabled      = false;
                txtEmail.Enabled             = false;
                txtEmpresa.Enabled           = false;
                txtTelefoneComercial.Enabled = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;
                if (_op == Operacao.Consulta)
                    btnConfirmar.Visible = true;
            }
        }
        private void preencheObjeto()
        {
            _morador.id                 = int.Parse(txtId.Text);
            _morador.nome               = txtNome.Text;
            _morador.rg                 = txtRg.Text;
            _morador.cpf                = txtCpf.Text;
            _morador.celular            = txtCelular.Text;
            _morador.telefone           = txtTelefoneFixo.Text;
            _morador.empresa            = txtEmpresa.Text;
            _morador.telefone_comercial      = txtTelefoneComercial.Text;
        }
       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _moradorRepositorio.incluir(_morador);
                        _moradorRepositorio.salvar();
                        _morador = new model.Morador();
                        preencheObjeto();
                        break;
                    case Operacao.Alteracao:
                        _moradorRepositorio.alterar(_morador);
                        _moradorRepositorio.salvar();
                        Dispose();
                        break;
                    case Operacao.Exclusao:
                        _moradorRepositorio.excluir(_morador);
                        _moradorRepositorio.salvar();
                        Dispose();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMoradorFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
