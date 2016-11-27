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
    public partial class FrmProcedimentoFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        public model.Procedimento procedimento;
        private repositorio.ProcedimentoRepositorio procedimentoRepositorio;

        public FrmProcedimentoFormulario(Operacao op, model.SistemaHotelContext context, model.Procedimento procedimento)
        {
            _op = op;
            _context = context;
            this.procedimento = procedimento;
            procedimentoRepositorio = new repositorio.ProcedimentoRepositorio(_context);
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
                        procedimentoRepositorio.incluir(ref procedimento);
                        procedimentoRepositorio.salvar();
                        Close();
                        break;

                    case Operacao.Alteracao:
                        procedimentoRepositorio.alterar(procedimento);
                        procedimentoRepositorio.salvar();
                        Close();
                        break;

                    case Operacao.Exclusao:
                        procedimentoRepositorio.excluir(procedimento);
                        procedimentoRepositorio.salvar();
                        Close();
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
            Close();
        }

        private void FrmProcedimentoFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtDescricao.Enabled = true;

            txtID.Text = procedimento.id.ToString().Trim();
            txtDescricao.Text = procedimento.descricao;

            txtID.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {

                txtDescricao.Enabled = false;

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
            procedimento.id = int.Parse(txtID.Text);
            procedimento.descricao = txtDescricao.Text;
        }
    }
}
