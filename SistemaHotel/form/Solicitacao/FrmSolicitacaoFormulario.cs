using SistemaHotel.form.AreaComum;
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

namespace SistemaHotel.form.Solicitacao
{
    public partial class FrmSolicitacaoFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Solicitacao _solicitacao;
        private repositorio.SolicitacaoRepositorio _solicitacaoRepositorio;

        public FrmSolicitacaoFormulario(Operacao op, model.SistemaHotelContext context, model.Solicitacao _solicitacao)
        {
            this._op = op;
            this._context = context;
            this._solicitacao = _solicitacao;
            this._solicitacaoRepositorio = new repositorio.SolicitacaoRepositorio(_context);
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
                        _solicitacaoRepositorio.incluir(_solicitacao);
                        _solicitacaoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Alteracao:
                        _solicitacaoRepositorio.alterar(_solicitacao);
                        _solicitacaoRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _solicitacaoRepositorio.excluir(_solicitacao);
                        _solicitacaoRepositorio.salvar();
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
            Close();
        }

        private void FrmSolicitacaoFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
            validaTipo();
        }

        private void preencheForm()
        {
            cbTipo.DataSource = EnumHelper.ToList(typeof(TipoSolicitacao));
            cbTipo.DisplayMember = "Value";
            cbTipo.ValueMember = "Key";

            txtID.Enabled = true;
            txtData_emissao.Enabled = true;
            cbTipo.Enabled = true;
            txtServico.Enabled = true;
            txtLocal.Enabled = true;
            txtArea_comum_id.Enabled = true;
            txtArea_comum_nome.Enabled = true;
            txtData_inicio.Enabled = true;
            txtData_fim.Enabled = true;
            btnPesquisaAreaComum.Enabled = true;

            txtID.Text = _solicitacao.id.ToString().Trim();
            txtData_emissao.Value = _solicitacao.data_emissao != null && _solicitacao.data_emissao != DateTime.MinValue ? (DateTime)_solicitacao.data_emissao : DateTimePicker.MinimumDateTime;
            

            cbTipo.SelectedItem = EnumHelper.SetValue(_solicitacao.editTipo);

            txtServico.Text = _solicitacao.servico;
            txtLocal.Text = _solicitacao.local;

            txtArea_comum_id.Text = _solicitacao.editArea_comum_id.ToString().Trim();
            if (_solicitacao.area_comum != null)
                txtArea_comum_nome.Text = _solicitacao.area_comum.nome;

            txtData_inicio.Value = (_solicitacao.data_inicio != null && _solicitacao.data_inicio != DateTime.MinValue ? (DateTime)_solicitacao.data_inicio : DateTimePicker.MinimumDateTime) + 
                                   (_solicitacao.hora_inicio != null && _solicitacao.hora_inicio != DateTime.MinValue.TimeOfDay ? (TimeSpan)_solicitacao.hora_inicio : DateTimePicker.MinimumDateTime.TimeOfDay);

            txtData_fim.Value = (_solicitacao.data_fim != null && _solicitacao.data_fim != DateTime.MinValue ? (DateTime)_solicitacao.data_fim : DateTimePicker.MinimumDateTime) +
                                   (_solicitacao.hora_fim != null && _solicitacao.hora_fim != DateTime.MinValue.TimeOfDay ? (TimeSpan)_solicitacao.hora_fim : DateTimePicker.MinimumDateTime.TimeOfDay);


            txtObservacao.Text = _solicitacao.observacao;


            txtID.Enabled = false;
            txtArea_comum_nome.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {

                txtData_emissao.Enabled = false;
                cbTipo.Enabled = false;
                txtServico.Enabled = false;
                txtLocal.Enabled = false;
                txtArea_comum_id.Enabled = false;
                txtData_inicio.Enabled = false;
                txtData_fim.Enabled = false;
                txtObservacao.Enabled = false;
                btnPesquisaAreaComum.Enabled = false;

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
            _solicitacao.id = int.Parse(txtID.Text);
            _solicitacao.data_emissao  = txtData_emissao.Value != DateTimePicker.MinimumDateTime ? txtData_emissao.Value : DateTime.MinValue;

            _solicitacao.editTipo = (TipoSolicitacao)EnumHelper.GetValue(cbTipo.SelectedItem);

            _solicitacao.servico = txtServico.Text;
            _solicitacao.local = txtLocal.Text;

            _solicitacao.editArea_comum_id = int.Parse(txtArea_comum_id.Text);
            if (_solicitacao.editArea_comum_id != 0)
                validaAreaComum();

            _solicitacao.data_inicio = txtData_inicio.Value != DateTimePicker.MinimumDateTime ? txtData_inicio.Value.Date : DateTime.MinValue;
            _solicitacao.hora_inicio = txtData_inicio.Value != DateTimePicker.MinimumDateTime ? txtData_inicio.Value.TimeOfDay : DateTime.MinValue.TimeOfDay;
            _solicitacao.data_fim    = txtData_fim.Value != DateTimePicker.MinimumDateTime ? txtData_fim.Value.Date : DateTime.MinValue;
            _solicitacao.hora_fim    = txtData_fim.Value != DateTimePicker.MinimumDateTime ? txtData_fim.Value.TimeOfDay : DateTime.MinValue.TimeOfDay;

            _solicitacao.observacao = txtObservacao.Text;

        }

        private void validaAreaComum()
        {
            _solicitacao.area_comum = null;
            if (_solicitacao.editArea_comum_id != 0)
            {
                _solicitacao.area_comum = (new repositorio.Area_comumRepositorio(_context)).getArea_comumporID(_solicitacao.editArea_comum_id);
                if (_solicitacao.area_comum == null)
                {
                    throw new Exception("Área comum não existe");
                }

            }
        }

        private void txtArea_comum_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtArea_comum_nome.Text = string.Empty;
                _solicitacao.editArea_comum_id = int.Parse(txtArea_comum_id.Text);

                validaAreaComum();

                if (_solicitacao.area_comum != null)
                    txtArea_comum_nome.Text = _solicitacao.area_comum.nome;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtArea_comum_id.Focus();
            }
        }

        private void validaTipo()
        {
            pnlServico.Enabled = false;
            pnlReserva.Enabled = false;

            _solicitacao.editTipo = (TipoSolicitacao)EnumHelper.GetValue(cbTipo.SelectedItem);

            if (_solicitacao.editTipo == TipoSolicitacao.Servico)
            {
                pnlServico.Enabled = true;

            }
            else if (_solicitacao.editTipo == TipoSolicitacao.Reserva)
            {
                pnlReserva.Enabled = true;
            }
        }

        private void cbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            validaTipo();
        }

        private void btnPesquisaAreaComum_Click(object sender, EventArgs e)
        {
            FrmAreaComumProcura procuraFornecedor = new FrmAreaComumProcura(_context);
            procuraFornecedor.ShowDialog();
            if (procuraFornecedor.area_comum != null)
            {
                txtArea_comum_id.Text = procuraFornecedor.area_comum.id.ToString().Trim();
                procuraFornecedor.Dispose();
            }
            txtArea_comum_id.Focus();
        }
    }
}
