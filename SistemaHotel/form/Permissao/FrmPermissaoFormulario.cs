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

namespace SistemaHotel.form.Permissao
{
    public partial class FrmPermissaoFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Permissao _permissao;
        private repositorio.PermissaoRepositorio _permissaoRepositorio;
        private model.Funcionalidade _funcionalidadeEntrada;
        private string _funcionalidade_nome_tela;

        public FrmPermissaoFormulario(Operacao op, model.SistemaHotelContext context, model.Permissao permissao)
        {
            _op = op;
            _context = context;
            _funcionalidade_nome_tela = string.Empty;
            _permissao = permissao;
            _permissaoRepositorio = new repositorio.PermissaoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        public FrmPermissaoFormulario(Operacao op, model.SistemaHotelContext context, string funcionalidade_nome_tela, model.Permissao permissao)
        {
            _op = op;
            _context = context;
            _funcionalidade_nome_tela = funcionalidade_nome_tela;
            _permissao = permissao;
            //_funcionalidadeEntrada = (new repositorio.FuncionalidadeRepositorio(_context)).getFuncionalidadeporNome_tela(_funcionalidade_nome_tela);
            _permissao.funcionalidade = _funcionalidadeEntrada;
            _permissao.editFuncionalidade_id = _permissao.funcionalidade.id;

            _permissaoRepositorio = new repositorio.PermissaoRepositorio(_context);
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
                        _permissaoRepositorio.incluir(_permissao);
                        _permissaoRepositorio.salvar();
                        _permissao = new model.Permissao();
                        _permissao.funcionalidade = _funcionalidadeEntrada;
                        _permissao.editFuncionalidade_id = _permissao.funcionalidade != null ? _permissao.funcionalidade.id : 0;
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _permissaoRepositorio.alterar(_permissao);
                        _permissaoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _permissaoRepositorio.excluir(_permissao);
                        _permissaoRepositorio.salvar();
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

        private void FrmPermissaoFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            cbInserir.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbInserir.DisplayMember = "Value";
            cbInserir.ValueMember = "Key";

            cbAlterar.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbAlterar.DisplayMember = "Value";
            cbAlterar.ValueMember = "Key";

            cbExcluir.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbExcluir.DisplayMember = "Value";
            cbExcluir.ValueMember = "Key";

            cbConsultar.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbConsultar.DisplayMember = "Value";
            cbConsultar.ValueMember = "Key";

            cbEspecial.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbEspecial.DisplayMember = "Value";
            cbEspecial.ValueMember = "Key";

            txtID.Enabled = true;

            txtID.Text = _permissao.id.ToString().Trim();
            txtFuncionalidade_id.Text = _permissao.editFuncionalidade_id.ToString().Trim();
            if (_permissao.funcionalidade != null)
                txtFuncionalidade_nome_funcionalidade.Text = _permissao.funcionalidade.nome_funcionalidade;

            txtPerfil_id.Text = _permissao.editPerfil_id.ToString().Trim();
            if (_permissao.perfil != null)
                txtPerfil_nome.Text = _permissao.perfil.nome;

            txtUsuario_id.Text = _permissao.editUsuario_id.ToString().Trim();
            if (_permissao.usuario != null)
                txtUsuario_nome.Text = _permissao.usuario.nome;

            cbInserir.SelectedItem = EnumHelper.SetValue(_permissao.editInserir);
            cbAlterar.SelectedItem = EnumHelper.SetValue(_permissao.editAlterar);
            cbExcluir.SelectedItem = EnumHelper.SetValue(_permissao.editExcluir);
            cbConsultar.SelectedItem = EnumHelper.SetValue(_permissao.editConsultar);
            cbEspecial.SelectedItem = EnumHelper.SetValue(_permissao.editEspecial);

            verificaPermissoes();

            txtID.Enabled = false;
            txtFuncionalidade_nome_funcionalidade.Enabled = false;
            txtPerfil_nome.Enabled = false;
            txtUsuario_nome.Enabled = false;

            if (_funcionalidade_nome_tela != string.Empty) {
                txtFuncionalidade_id.Enabled = false;
                txtFuncionalidade_nome_funcionalidade.Enabled = false;
                btnPesquisarFuncionalidade.Enabled = false;
            }

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                cbInserir.Enabled = false;
                cbAlterar.Enabled = false;
                cbExcluir.Enabled = false;
                cbConsultar.Enabled = false;
                cbEspecial.Enabled = false;

                btnPesquisarFuncionalidade.Enabled = false;
                btnPesquisarPerfil.Enabled = false;
                btnPesquisarUsuario.Enabled = false;

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

        private void preencheObjeto()
        {
            _permissao.id = int.Parse(txtID.Text);
            _permissao.editFuncionalidade_id = int.Parse(txtFuncionalidade_id.Text);
            _permissao.editPerfil_id = int.Parse(txtPerfil_id.Text);
            _permissao.editUsuario_id = int.Parse(txtUsuario_id.Text);
            _permissao.editInserir = (SimNao)EnumHelper.GetValue(cbInserir.SelectedItem);
            _permissao.editAlterar = (SimNao)EnumHelper.GetValue(cbAlterar.SelectedItem);
            _permissao.editExcluir = (SimNao)EnumHelper.GetValue(cbExcluir.SelectedItem);
            _permissao.editConsultar = (SimNao)EnumHelper.GetValue(cbConsultar.SelectedItem);
            _permissao.editEspecial = (SimNao)EnumHelper.GetValue(cbEspecial.SelectedItem);
        }

        private void btnPesquisarFuncionalidade_Click(object sender, EventArgs e)
        {
            //FrmFuncionalidadeProcura procuraFuncionalidade = new FrmFuncionalidadeProcura(_context);
            //procuraFuncionalidade.ShowDialog();
            //if (procuraFuncionalidade.funcionalidade != null)
            //{
            //    _permissao.editFuncionalidade_id = procuraFuncionalidade.funcionalidade.id;
            //}
            //txtFuncionalidade_id.Text = _permissao.editFuncionalidade_id.ToString().Trim();
            //txtFuncionalidade_id.Focus();
        }

        private void btnPesquisarPerfil_Click(object sender, EventArgs e)
        {
            //FrmPerfilProcura procuraPerfil = new FrmPerfilProcura(_context);
            //procuraPerfil.ShowDialog();
            //if (procuraPerfil.perfil != null)
            //{
            //    _permissao.editPerfil_id = procuraPerfil.perfil.id;
            //}
            //txtPerfil_id.Text = _permissao.editPerfil_id.ToString().Trim();
            //txtPerfil_id.Focus();
        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            //FrmUsuarioProcura procuraUsuario = new FrmUsuarioProcura(_context);
            //procuraUsuario.ShowDialog();
            //if (procuraUsuario.usuario != null)
            //{
            //    _permissao.editUsuario_id = procuraUsuario.usuario.id;
            //}
            //txtUsuario_id.Text = _permissao.editUsuario_id.ToString().Trim();
            //txtUsuario_id.Focus();
        }

        private void txtFuncionalidade_id_Validated(object sender, EventArgs e)
        {
            //try
            //{
            //    txtFuncionalidade_nome_funcionalidade.Text = string.Empty;

            //    if (string.IsNullOrEmpty(txtFuncionalidade_id.Text))
            //        txtFuncionalidade_id.Text = "0";

            //    _permissao.editFuncionalidade_id = int.Parse(txtFuncionalidade_id.Text);
            //    validaFuncionalidade();
            //    if (_permissao.funcionalidade != null)
            //    {
            //        _permissao.editFuncionalidade_id = _permissao.funcionalidade.id;
            //        txtFuncionalidade_nome_funcionalidade.Text = _permissao.funcionalidade.nome_funcionalidade;

            //        verificaPermissoes();
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtFuncionalidade_id.Focus();
            //}
        }

        private void validaFuncionalidade()
        {
            //_permissao.funcionalidade = null;
            //if (_permissao.editFuncionalidade_id != 0)
            //{
            //    _permissao.funcionalidade = (new repositorio.FuncionalidadeRepositorio(_context)).getFuncionalidadeporID(_permissao.editFuncionalidade_id);

            //    if (_permissao.funcionalidade == null)
            //    {
            //        throw new Exception("Funcionalidade não existe");
            //    }
            //}
        }

        private void txtPerfil_id_Validated(object sender, EventArgs e)
        {
            //try
            //{
            //    txtPerfil_nome.Text = string.Empty;

            //    if (string.IsNullOrEmpty(txtPerfil_id.Text))
            //        txtPerfil_id.Text = "0";

            //    _permissao.editPerfil_id = int.Parse(txtPerfil_id.Text);
            //    validaPerfil();
            //    if (_permissao.perfil != null)
            //    {
            //        _permissao.editPerfil_id = _permissao.perfil.id;
            //        txtPerfil_nome.Text = _permissao.perfil.nome;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtPerfil_id.Focus();
            //}
        }

        public void validaPerfil()
        {
            //_permissao.perfil = null;
            //if (_permissao.editPerfil_id != 0)
            //{
            //    _permissao.perfil = (new repositorio.PerfilRepositorio(_context)).getPerfilporID(_permissao.editPerfil_id);

            //    if (_permissao.perfil == null)
            //    {
            //        throw new Exception("Perfil não existe");
            //    }
            //}
        }

        private void txtUsuario_id_Validated(object sender, EventArgs e)
        {
            //try
            //{
            //    txtUsuario_nome.Text = string.Empty;

            //    if (string.IsNullOrEmpty(txtUsuario_id.Text))
            //        txtUsuario_id.Text = "0";

            //    _permissao.editUsuario_id = int.Parse(txtUsuario_id.Text);
            //    validaUsuario();
            //    if (_permissao.usuario != null)
            //    {
            //        _permissao.editUsuario_id = _permissao.usuario.id;
            //        txtUsuario_nome.Text = _permissao.usuario.nome;
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtUsuario_id.Focus();
            //}
        }

        private void validaUsuario()
        {
            //_permissao.usuario = null;
            //if (_permissao.editUsuario_id != 0)
            //{
            //    _permissao.usuario = (new repositorio.UsuarioRepositorio(_context)).getUsuarioporID(_permissao.editUsuario_id);

            //    if (_permissao.usuario == null)
            //    {
            //        throw new Exception("Usuário não existe");
            //    }
            //}
        }

        public void verificaPermissoes()
        {
            if (_permissao.funcionalidade.editTipo == TipoFuncionalidade.Especial)
            {
                lblInserir.Visible = false;
                lblAlterar.Visible = false;
                lblExcluir_edit.Visible = false;
                lblConsultar.Visible = false;
                cbInserir.Visible = false;
                cbAlterar.Visible = false;
                cbExcluir.Visible = false;
                cbConsultar.Visible = false;

                if (_op != Operacao.Consulta && _op != Operacao.Exclusao) { 
                    cbInserir.SelectedItem = EnumHelper.SetValue(SimNao.NAO);
                    cbAlterar.SelectedItem = EnumHelper.SetValue(SimNao.NAO);
                    cbExcluir.SelectedItem = EnumHelper.SetValue(SimNao.NAO);
                    cbConsultar.SelectedItem = EnumHelper.SetValue(SimNao.NAO);
                }

                lblEspecial.Visible = true;
                cbEspecial.Visible = true;


            }
            else
            {
                lblInserir.Visible = true;
                lblAlterar.Visible = true;
                lblExcluir_edit.Visible = true;
                lblConsultar.Visible = true;
                cbInserir.Visible = true;
                cbAlterar.Visible = true;
                cbExcluir.Visible = true;
                cbConsultar.Visible = true;
                if (_op != Operacao.Consulta && _op != Operacao.Exclusao)
                {
                    cbEspecial.SelectedItem = EnumHelper.SetValue(SimNao.NAO);
                }
                lblEspecial.Visible = false;
                cbEspecial.Visible = false;
            }
        }
    }
}
