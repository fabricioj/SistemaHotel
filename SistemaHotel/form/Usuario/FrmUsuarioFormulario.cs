using SistemaHotel.form.Morador;
using SistemaHotel.form.Perfil;
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

namespace SistemaHotel.form.Usuario
{
    public partial class FrmUsuarioFormulario : Form
    {
        private Operacao _op;
        private model.Usuario _usuario;
        private repositorio.UsuarioRepositorio _usuarioRepositorio;
        private model.SistemaHotelContext _context;

        public FrmUsuarioFormulario(Operacao op,   model.SistemaHotelContext context, model.Usuario usuario)
        {
            _op = op;
            _context = context;
            _usuario = usuario;
            _usuarioRepositorio = new repositorio.UsuarioRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }
        public void preencheForm()
        {
            txtID.Enabled                   = true;
            txtNome.Enabled                 = true;
            txtCpf.Enabled                  = true;
            txtTelefone.Enabled             = true;
            txtCelular.Enabled              = true;
            txtEmail.Enabled                = true;
            txtSenha.Enabled                = true;
            txtSenha_confirmacao.Enabled    = true;
            txtPerfil_nome.Enabled          = true;
            txtMorador_nome.Enabled         = true;

            btnPesquisaPerfil.Enabled       = true;
            btnPesquisaMorador.Enabled      = true;

            txtID.Text                      = _usuario.id.ToString().Trim();
            txtNome.Text                    = _usuario.nome;
            txtCpf.Text                     = _usuario.cpf;
            txtTelefone.Text                = _usuario.telefone;
            txtCelular.Text                 = _usuario.celular;
            txtEmail.Text                   = _usuario.email;
            txtSenha.Text                   = _usuario.senha;
            txtSenha_confirmacao.Text       = _usuario.senha;
            txtPerfil_id.Text               = _usuario.editPerfil_id.ToString().Trim();
            if (_usuario.perfil != null)
                txtPerfil_nome.Text         = _usuario.perfil.nome;
            txtMorador_id.Text               = _usuario.editMorador_id.ToString().Trim();
            if (_usuario.morador != null)
                txtMorador_nome.Text = _usuario.morador.nome;

            txtID.Enabled = false;
            txtPerfil_nome.Enabled = false;
            txtMorador_nome.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtNome.Enabled               = false;
                txtCpf.Enabled                = false;
                txtTelefone.Enabled           = false;
                txtCelular.Enabled            = false;
                txtEmail.Enabled              = false;
                txtSenha.Enabled              = false;
                txtSenha_confirmacao.Enabled  = false;
                txtPerfil_id.Enabled          = false;
                txtMorador_id.Enabled         = false;

                btnPesquisaPerfil.Enabled       = false;
                btnPesquisaMorador.Enabled      = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;    
            }          
                    

        }

        public void preenchObjeto() 
        {
            if (txtSenha.Text != txtSenha_confirmacao.Text)
                throw new Exception("Senha e confirmação de senha não conferem");

            _usuario.id = int.Parse(txtID.Text);

            var usuariotemp = _usuarioRepositorio.getUsuarioEmail(txtEmail.Text);
            if (usuariotemp != null && usuariotemp.id != _usuario.id)
                throw new Exception("Email já está sendo utilizado");
            
            _usuario.nome        = txtNome.Text;
            _usuario.cpf         = txtCpf.Text;
            _usuario.telefone    = txtTelefone.Text;
            _usuario.celular     = txtCelular.Text;
            _usuario.email       = txtEmail.Text;
            _usuario.senha       = txtSenha.Text;
            _usuario.editPerfil_id = int.Parse(txtPerfil_id.Text);
            _usuario.editMorador_id = int.Parse(txtMorador_id.Text);

            validaPerfil();
            validaMorador();
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preenchObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _usuarioRepositorio.incluir(_usuario);
                        _usuarioRepositorio.salvar();
                        _usuario = new model.Usuario();
                        preencheForm();
                        break;
                    case Operacao.Alteracao:
                        _usuarioRepositorio.alterar(_usuario);
                        _usuarioRepositorio.salvar();
                        Dispose();
                        break;
                    case Operacao.Exclusao:
                        _usuarioRepositorio.excluir(_usuario);
                        _usuarioRepositorio.salvar();
                        Dispose();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmUsuarioFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnPesquisaPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfilProcura procuraPerfil = new FrmPerfilProcura(_context);
            procuraPerfil.ShowDialog();

            if (procuraPerfil.perfil != null)
            { 
                txtPerfil_id.Text = procuraPerfil.perfil.id.ToString().Trim();
                procuraPerfil.Dispose();
            }
            txtPerfil_id.Focus();
        }

        private void btnPesquisaMorador_Click(object sender, EventArgs e)
        {
            FrmProcuraMorador procuraMorador = new FrmProcuraMorador(_context);
            procuraMorador.ShowDialog();
            if (procuraMorador.morador != null)
            { 
                txtMorador_id.Text = procuraMorador.morador.id.ToString().Trim();
                procuraMorador.Dispose();
            }
            txtMorador_id.Focus();
        }

        private void txtPerfil_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtPerfil_nome.Text = string.Empty;

                if (string.IsNullOrEmpty(txtPerfil_id.Text))
                    txtPerfil_id.Text = "0";

                _usuario.editPerfil_id = int.Parse(txtPerfil_id.Text);
                validaPerfil();
                if (_usuario.perfil != null)
                {
                    _usuario.editPerfil_id = _usuario.perfil.id;
                    txtPerfil_nome.Text = _usuario.perfil.nome;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPerfil_id.Focus();
            }
        }

        private void validaPerfil()
        {
            _usuario.perfil = null;
            if (_usuario.editPerfil_id != 0)
            {
                _usuario.perfil = (new repositorio.PerfilRepositorio(_context)).getPerfilporID(_usuario.editPerfil_id);

                if (_usuario.perfil == null)
                {
                    throw new Exception("Perfil não existe");
                }
            }
        }

        private void txtMorador_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtMorador_nome.Text = string.Empty;

                if (string.IsNullOrEmpty(txtMorador_id.Text))
                    txtMorador_id.Text = "0";

                _usuario.editMorador_id = int.Parse(txtMorador_id.Text);
                validaMorador();
                if (_usuario.morador != null)
                {
                    _usuario.editMorador_id = _usuario.morador.id;
                    txtMorador_nome.Text = _usuario.morador.nome;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMorador_id.Focus();
            }
        }

        private void validaMorador()
        {
            _usuario.morador = null;
            if (_usuario.editMorador_id != 0)
            {
                _usuario.morador = (new repositorio.MoradorRepositorio(_context)).getMoradorporID(_usuario.editMorador_id);

                if (_usuario.morador == null)
                {
                    throw new Exception("Morador não existe");
                }
            }
        }
    }
}
