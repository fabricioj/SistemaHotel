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

namespace SistemaHotel.form.UsuarioLogin
{
    public partial class FrmUsuarioLogin : Form
    {
        private model.SistemaHotelContext _context;
        public model.Usuario usuario;
        private repositorio.UsuarioRepositorio _usuarioRepositorio;

        public FrmUsuarioLogin(model.SistemaHotelContext context)
        {
            _context = context;
            _usuarioRepositorio = new repositorio.UsuarioRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                Close();
                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuarioLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void preencheObjeto() {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
                throw new Exception("Email e senha são obrigatórios");

            usuario = _usuarioRepositorio.getUsuarioEmailSenha(txtEmail.Text, txtSenha.Text);

            if (usuario == null)
                throw new Exception("Email e/ou senha inválidos");
        }
    }
}
