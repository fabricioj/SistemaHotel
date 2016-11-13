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

namespace SistemaHotel.form.Funcionario
{
    public partial class FrmFuncionarioFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Funcionario _funcionario;
        private repositorio.FuncionarioRepositorio _funcionarioRepositorio;

        public FrmFuncionarioFormulario(Operacao op, model.SistemaHotelContext context, model.Funcionario funcionario)
        {
            _op = op;
            _context = context;
            _funcionario = funcionario;
            _funcionarioRepositorio = new repositorio.FuncionarioRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void FrmFuncionarioFormulario_Load(object sender, EventArgs e)
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
                        _funcionarioRepositorio.incluir(_funcionario);
                        _funcionarioRepositorio.salvar();
                        _funcionario = new model.Funcionario();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _funcionarioRepositorio.alterar(_funcionario);
                        _funcionarioRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _funcionarioRepositorio.excluir(_funcionario);
                        _funcionarioRepositorio.salvar();
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

        private void preencheForm() {
            cbEstado_civil.DataSource = util.EnumHelper.ToList(typeof(EstadoCivil));
            cbEstado_civil.DisplayMember = "Value";
            cbEstado_civil.ValueMember = "Key";

            txtID.Enabled               = true;
            txtNome.Enabled             = true;
            txtData_cadastro.Enabled    = true;

            txtEndereco.Enabled         = true;
            txtNumero.Enabled           = true;
            txtBairro.Enabled           = true;
            txtCep.Enabled              = true;
            txtCidade.Enabled           = true;
            txtUf.Enabled               = true;

            txtRG.Enabled               = true;
            txtCPF.Enabled              = true;
                                        
            txtEmail.Enabled            = true;
            txtTelefone.Enabled         = true;

            cbEstado_civil.Enabled      = true;
            txtNome_conjuge.Enabled     = true;
            txtNome_pai.Enabled         = true;
            txtNome_mae.Enabled         = true;
            txtNacionalidade.Enabled    = true;

            txtData_contratacao.Enabled = true;
            txtFuncao.Enabled           = true;

            txtID.Text                  = _funcionario.id.ToString().Trim();
            txtNome.Text 				= _funcionario.nome;
            txtData_cadastro.Value 		= _funcionario.data_cadastro != null && _funcionario.data_cadastro != DateTime.MinValue ? (DateTime)_funcionario.data_cadastro : DateTimePicker.MinimumDateTime;
										
            txtEndereco.Text 			= _funcionario.endereco;
            txtNumero.Text 				= _funcionario.numero;
            txtBairro.Text 				= _funcionario.bairro;
            txtCep.Text 				= _funcionario.cep;
            txtCidade.Text 				= _funcionario.cidade;
            txtUf.Text 					= _funcionario.estado;
										
            txtRG.Text 					= _funcionario.rg;
            txtCPF.Text 				= _funcionario.cpf;
										
            txtEmail.Text 				= _funcionario.email;
            txtTelefone.Text 			= _funcionario.telefone;
										
            cbEstado_civil.SelectedItem = EnumHelper.SetValue(_funcionario.editEstado_civil) ;
            txtNome_conjuge.Text 		= _funcionario.nome_conjuge;
            txtNome_pai.Text			= _funcionario.nome_pai;
            txtNome_mae.Text            = _funcionario.nome_mae;
            txtNacionalidade.Text 		= _funcionario.nacionalidade;

            txtData_contratacao.Value 	= _funcionario.data_contratacao != null && _funcionario.data_contratacao != DateTime.MinValue ? (DateTime)_funcionario.data_contratacao : DateTimePicker.MinimumDateTime;
            txtFuncao.Text 				= _funcionario.funcao;

            txtID.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {   
                txtNome.Enabled             = false;
                txtData_cadastro.Enabled    = false;

                txtEndereco.Enabled         = false;
                txtNumero.Enabled           = false;
                txtBairro.Enabled           = false;
                txtCep.Enabled              = false;
                txtCidade.Enabled           = false;
                txtUf.Enabled               = false;

                txtRG.Enabled               = false;
                txtCPF.Enabled              = false;
                                        
                txtEmail.Enabled            = false;
                txtTelefone.Enabled         = false;

                cbEstado_civil.Enabled      = false;
                txtNome_conjuge.Enabled     = false;
                txtNome_pai.Enabled         = false;
                txtNome_mae.Enabled         = false;
                txtNacionalidade.Enabled    = false;

                txtData_contratacao.Enabled = false;
                txtFuncao.Enabled           = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;
            }

        }
        private void preencheObjeto()
        {
            _funcionario.id					= int.Parse(txtID.Text);
            _funcionario.nome             = txtNome.Text;				
            _funcionario.data_cadastro    = txtData_cadastro.Value != DateTimePicker.MinimumDateTime? txtData_cadastro.Value: DateTime.MinValue;
            _funcionario.endereco         = txtEndereco.Text;
            _funcionario.numero           = txtNumero.Text;
            _funcionario.bairro           = txtBairro.Text;
            _funcionario.cep              = txtCep.Text;
            _funcionario.cidade           = txtCidade.Text;
            _funcionario.estado           = txtUf.Text;
            						
            _funcionario.rg               = txtRG.Text;
            _funcionario.cpf              = txtCPF.Text;
            _funcionario.email            = txtEmail.Text;
            _funcionario.telefone         = txtTelefone.Text;
			
            _funcionario.editEstado_civil = (EstadoCivil)EnumHelper.GetValue(cbEstado_civil.SelectedItem);
            _funcionario.nome_conjuge     = txtNome_conjuge.Text;
            _funcionario.nome_pai         = txtNome_pai.Text;
            _funcionario.nacionalidade    = txtNacionalidade.Text;

            _funcionario.data_contratacao = txtData_contratacao.Value != DateTimePicker.MinimumDateTime? txtData_contratacao.Value: DateTime.MinValue;
            _funcionario.funcao           = txtFuncao.Text;
        }

        
    }
}
