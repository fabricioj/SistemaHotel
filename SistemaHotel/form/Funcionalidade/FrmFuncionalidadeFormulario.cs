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

namespace SistemaHotel.form.Funcionalidade
{
    public partial class FrmFuncionalidadeFormulario : Form
    {
        private Operacao _op;
        private model.Funcionalidade _funcionalidade;

        private repositorio.FuncionalidadeRepositorio _funcionalidadeRepositorio;
        private model.SistemaHotelContext _context;

        public FrmFuncionalidadeFormulario(Operacao op, model.SistemaHotelContext context, model.Funcionalidade funcionalidade)
        {
            _op = op ; 
            _context = context ;
            _funcionalidade = funcionalidade;
            _funcionalidadeRepositorio = new repositorio.FuncionalidadeRepositorio(_context);

            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void preencherForm() {
            cb_TipoFuncionalidade.DataSource = EnumHelper.ToList(typeof(TipoFuncionalidade));
            cb_TipoFuncionalidade.DisplayMember = "Value";
            cb_TipoFuncionalidade.ValueMember = "key";

            txtID.Enabled                 = true;
            cb_TipoFuncionalidade.Enabled = true;
            txtNomeFuncionalidade.Enabled = true;
            txtNomeTela.Enabled           = true;

            txtID.Text                    = _funcionalidade.id.ToString().Trim();
            cb_TipoFuncionalidade.SelectedItem = EnumHelper.SetValue(_funcionalidade.editTipo);
            txtNomeFuncionalidade.Text    = _funcionalidade.nome_funcionalidade;
            txtNomeTela.Text              = _funcionalidade.nome_tela;

            txtID.Enabled = false;
            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtNomeFuncionalidade.Enabled    = false;
                txtNomeTela.Enabled              = false;
                cb_TipoFuncionalidade.Enabled    = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Visible = true;
            }

        }
        private void preencheObjeto()
        {

            _funcionalidade.id                    = int.Parse(txtID.Text);
            _funcionalidade.editTipo = (TipoFuncionalidade) EnumHelper.GetValue(cb_TipoFuncionalidade.SelectedItem);
            _funcionalidade.nome_funcionalidade   = txtNomeFuncionalidade.Text;
            _funcionalidade.nome_tela             = txtNomeTela.Text;

        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                { 
                    case Operacao.Insercao:
                        _funcionalidadeRepositorio.incluir(_funcionalidade);
                        _funcionalidadeRepositorio.salvar();
                        _funcionalidade = new model.Funcionalidade();
                        preencherForm();
                        break;
                    case Operacao.Alteracao:
                        _funcionalidadeRepositorio.alterar(_funcionalidade);
                        _funcionalidadeRepositorio.salvar();
                        Dispose();
                        break;
                    case Operacao.Exclusao:                        
                        _funcionalidadeRepositorio.excluir(_funcionalidade);
                        _funcionalidadeRepositorio.salvar();
                        Dispose();
                        break;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFuncionalidadeFormulario_Load(object sender, EventArgs e)
        {
                preencherForm();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
