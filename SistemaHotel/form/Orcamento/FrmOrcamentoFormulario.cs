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
        public model.Orcamento_old orcamento;
        private dao.OrcamentoDao _orcamentoDao;
        private Operacao _op;
        private model.Fornecedor_old _fornecedor;

        public FrmOrcamentoFormulario()
        {
            InitializeComponent();
            orcamento = new model.Orcamento_old();
            _orcamentoDao = new dao.OrcamentoDao();
            _op = Operacao.Insercao;
            _fornecedor = new model.Fornecedor_old();
            Util.acertaTabOrder(this);
        }

        public FrmOrcamentoFormulario(Operacao op, model.Orcamento_old orcamento)
        {
            InitializeComponent();
            this.orcamento = orcamento;
            _op = op;
            _orcamentoDao = new dao.OrcamentoDao();
            _fornecedor = new model.Fornecedor_old();
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
                        _orcamentoDao.incluir(ref orcamento);
                        Close();
                        break;

                    case Operacao.Alteracao:
                        _orcamentoDao.alterar(orcamento);
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _orcamentoDao.excluir(orcamento);
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
            orcamento.data_emissao = DateTime.Parse(txtData_emissao.Text);
            orcamento.data_confirmacao = DateTime.Parse(txtData_confirmacao.Text);
            orcamento.fornecedor_id = int.Parse(txtFornecedor_id.Text);
            //orcamento.atividade_id = int.parse(txtAtividade_id.text);
        }

        private void preencheForm()
        {

            txtID.Enabled = true;
            txtData_emissao.Enabled = true;
            txtData_confirmacao.Enabled = true;
            txtData_confirmacao.Enabled = true;
            txtFornecedor_id.Enabled = true;
            txtFornecedor_nome.Enabled = true;

            //txtAtividade_id.Enabled = true;
            //txtAtividade_nome.Enabled = true;

            txtID.Text = orcamento.id.ToString().Trim();
            txtData_emissao.Text = orcamento.data_emissao.ToString();
            txtData_confirmacao.Text = orcamento.data_confirmacao.ToString();
            txtFornecedor_id.Text = orcamento.fornecedor_id.ToString().Trim();
            if (orcamento.fornecedor != null)
                txtFornecedor_nome.Text = orcamento.fornecedor.nome;
            //txtAtividade_id.Text   = orcamento.atividade.id.ToString();
            //txtAtividade_nome.Text = orcamento.atividade.nome;


            txtID.Enabled = false;
            txtData_confirmacao.Enabled = false;
            txtAtividade_nome.Enabled = false;
            txtFornecedor_nome.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtData_emissao.Enabled = false;
                txtFornecedor_id.Enabled = false;
                //txtAtividade_id.Enabled = false;

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
                atualizaFornecedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedor_id.Focus();
            }
        }

        private void atualizaFornecedor()
        {
            txtFornecedor_nome.Text = string.Empty;
            if (orcamento.fornecedor_id != 0)
            {
                orcamento.fornecedor = (new dao.FornecedorDao()).getFornecedorporID(orcamento.fornecedor_id);
                if (orcamento.fornecedor == null)
                {
                    throw new Exception("Fornecedor não existe");
                }
                else
                {
                    txtFornecedor_nome.Text = orcamento.fornecedor.nome;
                }

            }

        }

        private void btnPesquisaFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedorProcura procuraFornecedor = new FrmFornecedorProcura();
            procuraFornecedor.ShowDialog();
            if (procuraFornecedor.fornecedor != null)
            {
                orcamento.fornecedor_id = procuraFornecedor.fornecedor.id;
            }
            txtFornecedor_id.Focus();
        }
    }
}
