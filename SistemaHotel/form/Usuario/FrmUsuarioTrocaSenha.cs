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
    public partial class FrmUsuarioTrocaSenha : Form
    {
        private Operacao _op;
        private model.Usuario _usuario;
        private repositorio.UsuarioRepositorio _usuarioRepositorio;
        private model.SistemaHotelContext _context;

        public FrmUsuarioTrocaSenha(model.SistemaHotelContext context, model.Usuario usuario)
        {
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
            txtEmail.Enabled                = true;
            txtSenha.Enabled                = true;

            txtID.Text                      = _usuario.id.ToString().Trim();
            txtNome.Text                    = _usuario.nome;
            txtEmail.Text                   = _usuario.email;

            txtID.Enabled                   = false;
            txtNome.Enabled                 = false;
            txtEmail.Enabled                = false;                    

        }

        public void preenchObjeto() 
        {
            _usuario = _usuarioRepositorio.getUsuarioporID(_usuario.id);

            if (_usuario.senha != txtSenha_atual.Text)
                throw new Exception("Senha atual não confere com a senha do usuário logado");

            if (txtSenha.Text != txtSenha_confirmacao.Text)
                throw new Exception("Senha e confirmação de nova senha não conferem");           

            _usuario.senha       = txtSenha.Text;
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preenchObjeto();
                _usuarioRepositorio.alterar(_usuario);
                _usuarioRepositorio.salvar();
                Dispose();
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmUsuarioTrocaSenha_Load(object sender, EventArgs e)
        {
            preencheForm();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
