using SistemaHotel.form.Fornecedor;
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

namespace SistemaHotel.form.Orcamento
{
    public partial class FrmOrcamentoFormulario : Form
    {
        public model.Orcamento orcamento;
        private repositorio.OrcamentoRepositorio _orcamentoRepositorio;
        private Operacao _op;
        private model.SistemaHotelContext _context;

        public FrmOrcamentoFormulario(Operacao op, model.SistemaHotelContext context, model.Orcamento orcamento)
        {
            InitializeComponent();
            this.orcamento = orcamento;
            _op = op;
            _context = context;
            _orcamentoRepositorio = new repositorio.OrcamentoRepositorio(_context);
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
                        _orcamentoRepositorio.incluir(ref orcamento);
                        _orcamentoRepositorio.salvar();
                        Close();
                        break;

                    case Operacao.Alteracao:
                        _orcamentoRepositorio.alterar(orcamento);
                        _orcamentoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _orcamentoRepositorio.excluir(orcamento);
                        _orcamentoRepositorio.salvar();
                        Dispose();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void preencheObjeto()
        {
            orcamento.id = int.Parse(txtID.Text);
            orcamento.data_emissao = txtData_emissao.Value != DateTimePicker.MinimumDateTime? txtData_emissao.Value: DateTime.MinValue ;
            orcamento.data_confirmacao = txtData_confirmacao.Value != DateTimePicker.MinimumDateTime ? txtData_confirmacao.Value : DateTime.MinValue;

            orcamento.editFornecedor_id = int.Parse(txtFornecedor_id.Text);
            if (orcamento.editFornecedor_id != 0)
                
                validaFornecedor();

            orcamento.editAtividade_id = int.Parse(txtAtividade_id.Text);
        }

        private void preencheForm()
        {

            txtID.Enabled = true;
            txtData_emissao.Enabled = true;
            txtData_confirmacao.Enabled = true;
            txtFornecedor_id.Enabled = true;
            txtFornecedor_nome.Enabled = true;

            txtAtividade_id.Enabled = true;
            txtAtividade_nome.Enabled = true;

            txtID.Text = orcamento.id.ToString().Trim();
            txtData_emissao.Value = orcamento.data_emissao != null && orcamento.data_emissao != DateTime.MinValue? (DateTime)orcamento.data_emissao: DateTimePicker.MinimumDateTime;
            txtData_confirmacao.Value = orcamento.data_confirmacao != null && orcamento.data_confirmacao != DateTime.MinValue? (DateTime)orcamento.data_confirmacao : DateTimePicker.MinimumDateTime;
            txtFornecedor_id.Text = orcamento.editFornecedor_id.ToString().Trim();
            txtFornecedor_nome.Text = string.Empty;
            if (orcamento.fornecedor != null)
                txtFornecedor_nome.Text = orcamento.fornecedor.nome;
            txtAtividade_id.Text   = orcamento.editAtividade_id.ToString().Trim();
            txtAtividade_nome.Text = string.Empty;
            if (orcamento.atividade != null)
                txtAtividade_nome.Text = orcamento.atividade.nome;


            txtID.Enabled = false;
            txtData_confirmacao.Enabled = false;
            txtAtividade_nome.Enabled = false;
            txtFornecedor_nome.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtData_emissao.Enabled = false;
                txtFornecedor_id.Enabled = false;
                txtAtividade_id.Enabled = false;

                btnPesquisaFornecedor.Enabled = false;
                btnPesquisaAtividade.Enabled = false;

                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;

                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOrcamentoFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void txtFornecedor_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtFornecedor_nome.Text = string.Empty;

                orcamento.editFornecedor_id = int.Parse(txtFornecedor_id.Text);
                validaFornecedor();                
                if (orcamento.fornecedor != null)
                    txtFornecedor_nome.Text = orcamento.fornecedor.nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedor_id.Focus();
            }
        }

        private void validaFornecedor()
        {
            orcamento.fornecedor = null;
            if (orcamento.editFornecedor_id != 0)
            {
                orcamento.fornecedor = (new repositorio.FornecedorRepositorio(_context)).getFornecedorporID(orcamento.editFornecedor_id);
                if (orcamento.fornecedor == null)
                {
                    throw new Exception("Fornecedor não existe");
                }

            }

        }

        private void btnPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedorProcura procuraFornecedor = new FrmFornecedorProcura(_context);
            procuraFornecedor.ShowDialog();
            if (procuraFornecedor.fornecedor != null)
            {
                txtFornecedor_id.Text = procuraFornecedor.fornecedor.id.ToString().Trim();
            }
            txtFornecedor_id.Focus();
        }
    }
}
