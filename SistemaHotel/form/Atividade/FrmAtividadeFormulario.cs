using SistemaHotel.form.Funcionario;
using SistemaHotel.form.Procedimento;
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

namespace SistemaHotel.form.Atividade
{
    public partial class FrmAtividadeFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Atividade _atividade;
        private repositorio.AtividadeRepositorio _atividadeRepositorio;

        public FrmAtividadeFormulario(Operacao op, model.SistemaHotelContext context, model.Atividade atividade)
        {
            _op = op;
            _context = context;
            _atividade = atividade;
            _atividadeRepositorio = new repositorio.AtividadeRepositorio(_context);
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
                        _atividade.data_cadastro = DateTime.Now;
                        _atividadeRepositorio.incluir(ref _atividade);
                        _atividadeRepositorio.salvar();
                        _atividade = new model.Atividade();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _atividadeRepositorio.alterar(_atividade);
                        _atividadeRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _atividadeRepositorio.excluir(_atividade);
                        _atividadeRepositorio.salvar();
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

        private void FrmAtividadeFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            cbGerar_orcamento.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbGerar_orcamento.DisplayMember = "Value";
            cbGerar_orcamento.ValueMember = "Key";

            txtID.Enabled = true;
            txtData_cadastro.Enabled = true;
            cbGerar_orcamento.Enabled = true;
            txtNome.Enabled = true;
            txtProcedimento_id.Enabled = true;
            txtProcedimento_descricao.Enabled = true;
            txtFuncionario_id.Enabled = true;
            txtFuncionario_nome.Enabled = true;
            pnlConfirmacao.Enabled = true;

            txtID.Text = _atividade.id.ToString().Trim();
            txtData_cadastro.Value = _atividade.data_cadastro != null && _atividade.data_cadastro != DateTime.MinValue ? (DateTime)_atividade.data_cadastro : DateTimePicker.MinimumDateTime;
            cbGerar_orcamento.SelectedItem = EnumHelper.SetValue(_atividade.editGerar_orcamento);
            txtNome.Text = _atividade.nome;

            txtSolicitacao_id.Text = _atividade.editSolicitacao_id.ToString().Trim();
            txtSolicitacao_solicitante.Text = _atividade.dspSolicitacao_solicitante;

            txtProcedimento_id.Text = _atividade.editProcedimento_id.ToString().Trim();
            if (_atividade.procedimento != null)
                txtProcedimento_descricao.Text = _atividade.procedimento.descricao;

            txtFuncionario_id.Text = _atividade.editFuncionario_id.ToString().Trim();
            if (_atividade.funcionario != null)
                txtFuncionario_nome.Text = _atividade.funcionario.nome;

            txtData_confirmacao.Value = _atividade.data_confirmacao != null && _atividade.data_confirmacao != DateTime.MinValue ? (DateTime)_atividade.data_confirmacao : DateTimePicker.MinimumDateTime;

            txtUsuario_id.Text = _atividade.editUsuario_confirmacao_id.ToString().Trim();
            if (_atividade.usuario_confirmacao != null)
                txtUsuario_nome.Text = _atividade.usuario_confirmacao.nome;

            txtID.Enabled = false;
            txtData_cadastro.Enabled = false;
            txtSolicitacao_solicitante.Enabled = false;
            txtProcedimento_descricao.Enabled = false;
            txtFuncionario_nome.Enabled = false;
            pnlConfirmacao.Enabled = false;


            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {
                txtID.Enabled = false;
                txtData_cadastro.Enabled = false;
                cbGerar_orcamento.Enabled = false;
                txtNome.Enabled = false;
                txtProcedimento_id.Enabled = false;
                txtFuncionario_id.Enabled = false;
                btnPesquisaProcedimento.Enabled = false;
                btnPesquisarFuncionario.Enabled = false;

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
            _atividade.id = int.Parse(txtID.Text);
            _atividade.data_cadastro = txtData_cadastro.Value != DateTimePicker.MinimumDateTime ? txtData_cadastro.Value : DateTime.MinValue;
            _atividade.editGerar_orcamento = (SimNao)EnumHelper.GetValue(cbGerar_orcamento.SelectedItem);
            _atividade.nome = txtNome.Text;
            _atividade.editSolicitacao_id = int.Parse(txtSolicitacao_id.Text);
            _atividade.editProcedimento_id = int.Parse(txtProcedimento_id.Text);
            _atividade.editFuncionario_id = int.Parse(txtFuncionario_id.Text);
            _atividade.data_confirmacao = txtData_confirmacao.Value != DateTimePicker.MinimumDateTime ? txtData_confirmacao.Value : DateTime.MinValue;
            _atividade.editUsuario_confirmacao_id = int.Parse(txtUsuario_id.Text);
            _atividade.observacao_confirmacao = txtObservacao_confirmacao.Text;

            validaSolicitacao();
            validaProcedimento();
            validaFuncionario();
            
        }

        private void btnPesquisaProcedimento_Click(object sender, EventArgs e)
        {
            FrmProcedimentoProcura procuraProcedimento = new FrmProcedimentoProcura(_context);
            procuraProcedimento.ShowDialog();
            if (procuraProcedimento.procedimento != null)
            {
                _atividade.editProcedimento_id = procuraProcedimento.procedimento.id;
            }
            txtProcedimento_id.Text = _atividade.editProcedimento_id.ToString().Trim();
            txtProcedimento_id.Focus();
        }

        private void btnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarioProcura procuraFuncionario = new FrmFuncionarioProcura(_context);
            procuraFuncionario.ShowDialog();
            if (procuraFuncionario.funcionario != null)
            {
                _atividade.editFuncionario_id = procuraFuncionario.funcionario.id;
            }
            txtFuncionario_id.Text = _atividade.editFuncionario_id.ToString().Trim();
            txtFuncionario_id.Focus();
        }

        private void txtSolicitacao_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtSolicitacao_solicitante.Text = string.Empty;

                if (string.IsNullOrEmpty(txtSolicitacao_id.Text))
                    txtSolicitacao_id.Text = "0";

                _atividade.editSolicitacao_id = int.Parse(txtSolicitacao_id.Text);
                validaSolicitacao();
                if (_atividade.solicitacao != null)
                {
                    _atividade.editSolicitacao_id = _atividade.solicitacao.id;
                    txtSolicitacao_solicitante.Text = _atividade.solicitacao.dspSolicitante_nome;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSolicitacao_id.Focus();
            }
        }

        private void validaSolicitacao()
        {
            _atividade.solicitacao = null;
            if (_atividade.editSolicitacao_id != 0)
            {
                _atividade.solicitacao = (new repositorio.SolicitacaoRepositorio(_context)).getSolicitacaoporID(_atividade.editSolicitacao_id);

                if (_atividade.solicitacao == null)
                {
                    throw new Exception("Solicitação não existe");
                }
            }
        }

        private void txtProcedimento_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtProcedimento_descricao.Text = string.Empty;

                if (string.IsNullOrEmpty(txtProcedimento_id.Text))
                    txtProcedimento_id.Text = "0";

                _atividade.editProcedimento_id = int.Parse(txtProcedimento_id.Text);
                validaProcedimento();
                if (_atividade.procedimento != null)
                {
                    _atividade.editProcedimento_id = _atividade.procedimento.id;
                    txtProcedimento_descricao.Text = _atividade.procedimento.descricao;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProcedimento_id.Focus();
            }
        }

        private void validaProcedimento()
        {
            _atividade.procedimento = null;
            if (_atividade.editProcedimento_id != 0)
            {
                _atividade.procedimento = (new repositorio.ProcedimentoRepositorio(_context)).getProcedimentoporID(_atividade.editProcedimento_id);

                if (_atividade.procedimento == null)
                {
                    throw new Exception("Procedimento não existe");
                }
            }
        }

        private void txtFuncionario_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtFuncionario_nome.Text = string.Empty;

                if (string.IsNullOrEmpty(txtFuncionario_id.Text))
                    txtFuncionario_id.Text = "0";

                _atividade.editFuncionario_id = int.Parse(txtFuncionario_id.Text);
                validaFuncionario();
                if (_atividade.funcionario != null)
                {
                    _atividade.editFuncionario_id = _atividade.funcionario.id;
                    txtFuncionario_nome.Text = _atividade.funcionario.nome;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFuncionario_id.Focus();
            }
        }

        private void validaFuncionario()
        {
            _atividade.funcionario = null;
            if (_atividade.editFuncionario_id != 0)
            {
                _atividade.funcionario = (new repositorio.FuncionarioRepositorio(_context)).getFuncionarioporID(_atividade.editFuncionario_id);

                if (_atividade.funcionario == null)
                {
                    throw new Exception("Funcionário não existe");
                }
            }
        }
    }
}
