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
    public partial class FrmProcedimentoPasso : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Procedimento _procedimento;
        private model.Procedimento_passo _procedimento_passo;
        private repositorio.Procedimento_passoRepositorio _procedimento_passoRepositorio;

        public FrmProcedimentoPasso(Operacao op, model.SistemaHotelContext context, model.Procedimento procedimento, model.Procedimento_passo procedimento_passo)
        {
            _op = op;
            _context = context;
            _procedimento = procedimento;
            _procedimento_passo = procedimento_passo;
            _procedimento_passoRepositorio = new repositorio.Procedimento_passoRepositorio(_context);
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
                        _procedimento_passoRepositorio.incluir(ref _procedimento_passo);
                        _procedimento_passoRepositorio.salvar();
                        _procedimento_passo = new model.Procedimento_passo();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _procedimento_passoRepositorio.alterar(_procedimento_passo);
                        _procedimento_passoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _procedimento_passoRepositorio.excluir(_procedimento_passo);
                        _procedimento_passoRepositorio.salvar();
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

        private void FrmProcedimentoPasso_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtOrdem_execucao.Enabled = true;
            txtDescricao_passo.Enabled = true;

            txtID.Text = _procedimento_passo.id.ToString().Trim();
            txtOrdem_execucao.Text = _procedimento_passo.ordem_execucao.ToString().Trim();
            txtDescricao_passo.Text = _procedimento_passo.descricao_passo;

            txtID.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {

                txtOrdem_execucao.Enabled = false;
                txtDescricao_passo.Enabled = false;

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
            _procedimento_passo.id = int.Parse(txtID.Text);
            _procedimento_passo.procedimento = _procedimento;
            _procedimento_passo.procedimento_id = _procedimento.id;
            _procedimento_passo.ordem_execucao = int.Parse(txtOrdem_execucao.Text);
            _procedimento_passo.descricao_passo = txtDescricao_passo.Text;
        }
    }
}
