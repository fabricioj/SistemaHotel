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

        public FrmOrcamentoFormulario()
        {
            InitializeComponent();
            orcamento = new model.Orcamento();
            _orcamentoRepositorio = new repositorio.OrcamentoRepositorio();
            _op = Operacao.Insercao;
            Util.acertaTabOrder(this);
        }

        public FrmOrcamentoFormulario(Operacao op, repositorio.OrcamentoRepositorio orcamentoRepositorio, model.Orcamento orcamento)
        {
            InitializeComponent();
            this.orcamento = orcamento;
            _op = op;
            _orcamentoRepositorio = orcamentoRepositorio;
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
            orcamento.data_emissao = txtData_emissao.Value;
            orcamento.data_confirmacao = txtData_confirmacao.Value;

            orcamento.fornecedor_id = int.Parse(txtFornecedor_id.Text);
            if (orcamento.fornecedor_id == 0)
                orcamento.fornecedor_id = null;
            else
                valdaFornecedor();

            orcamento.atividade_id = int.Parse(txtAtividade_id.Text);
            if (orcamento.atividade_id == 0)
                orcamento.atividade_id = null;
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
            //txtData_emissao.Value = orcamento.data_emissao != null?(DateTime)orcamento.data_emissao: DateTime.MinValue;
            //txtData_confirmacao.Value = orcamento.data_confirmacao != null ? (DateTime)orcamento.data_confirmacao : DateTime.MinValue;
            txtFornecedor_id.Text = orcamento.fornecedor_id.ToString().Trim();
            if (orcamento.fornecedor != null)
                txtFornecedor_nome.Text = orcamento.fornecedor.nome;
            txtAtividade_id.Text   = orcamento.atividade_id.ToString().Trim();
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
                orcamento.fornecedor_id = int.Parse(txtFornecedor_id.Text);
                valdaFornecedor();
                if (orcamento.fornecedor != null)
                    txtFornecedor_nome.Text = orcamento.fornecedor.nome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedor_id.Focus();
            }
        }

        private void valdaFornecedor()
        {
            txtFornecedor_nome.Text = string.Empty;
            if (orcamento.fornecedor_id != 0)
            {
                orcamento.fornecedor = (new repositorio.FornecedorRepositorio()).getFornecedorporID((int)orcamento.fornecedor_id);
                if (orcamento.fornecedor == null)
                {
                    throw new Exception("Fornecedor não existe");
                }

            }

        }

        private void btnPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedorProcura procuraFornecedor = new FrmFornecedorProcura();
            procuraFornecedor.ShowDialog();
            if (procuraFornecedor.fornecedor != null)
            {
                txtFornecedor_id.Text = procuraFornecedor.fornecedor.id.ToString().Trim();
            }
            txtFornecedor_id.Focus();
        }
    }
}
