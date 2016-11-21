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

namespace SistemaHotel.form.ReservaAreaComum
{
    public partial class FrmReservaAreaComumFormulario : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Reserva_area_comum _reserva_area_comum;
        private repositorio.Reserva_area_comumRepositorio _reserva_area_comumRepositorio;

        public FrmReservaAreaComumFormulario(Operacao op, model.SistemaHotelContext context, model.Reserva_area_comum reserva_area_comum)
        {
            _op = op;
            _context = context;
            _reserva_area_comum = reserva_area_comum;
            _reserva_area_comumRepositorio = new repositorio.Reserva_area_comumRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        public FrmReservaAreaComumFormulario(Operacao op, model.Solicitacao solicitacao, model.SistemaHotelContext context, model.Reserva_area_comum reserva_area_comum)
        {
            _op = op;
            _context = context;
            _reserva_area_comum = reserva_area_comum;
            _reserva_area_comum.editSolicitacao_id = solicitacao.id;
            _reserva_area_comumRepositorio = new repositorio.Reserva_area_comumRepositorio(_context);
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
                        _reserva_area_comumRepositorio.incluir(ref _reserva_area_comum);
                        _reserva_area_comumRepositorio.salvar();
                        _reserva_area_comum = new model.Reserva_area_comum();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _reserva_area_comumRepositorio.alterar(_reserva_area_comum);
                        _reserva_area_comumRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _reserva_area_comumRepositorio.excluir(_reserva_area_comum);
                        _reserva_area_comumRepositorio.salvar();
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

        private void FrmReservaAreaComumFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtSolicitacao_id.Enabled = true;
            txtUsuario_solicitante_nome.Enabled = true;
            txtArea_comum_id.Enabled = true;
            txtArea_comum_nome.Enabled = true;
            txtData_inicio.Enabled = true;
            txtData_devolucao.Enabled = true;
            txtObservacao.Enabled = true;

            txtID.Text = _reserva_area_comum.id.ToString().Trim();
            txtSolicitacao_id.Text = _reserva_area_comum.editSolicitacao_id.ToString().Trim();
            if (_reserva_area_comum.solicitacao != null)
            {
                txtUsuario_solicitante_nome.Text = _reserva_area_comum.solicitacao.dspSolicitante_nome;
                txtArea_comum_id.Text = _reserva_area_comum.solicitacao.editArea_comum_id.ToString().Trim();
                txtArea_comum_nome.Text = _reserva_area_comum.solicitacao.area_comum.nome;
                txtData_inicio.Value = (_reserva_area_comum.solicitacao.data_inicio != null && _reserva_area_comum.solicitacao.data_inicio != DateTime.MinValue ? (DateTime)_reserva_area_comum.solicitacao.data_inicio : DateTimePicker.MinimumDateTime) +
                                                   (_reserva_area_comum.solicitacao.hora_inicio != null && _reserva_area_comum.solicitacao.hora_inicio != DateTime.MinValue.TimeOfDay ? (TimeSpan)_reserva_area_comum.solicitacao.hora_inicio : DateTimePicker.MinimumDateTime.TimeOfDay);
            }
            txtData_devolucao.Value = (_reserva_area_comum.data_devolucao != null && _reserva_area_comum.data_devolucao != DateTime.MinValue ? (DateTime)_reserva_area_comum.data_devolucao : DateTimePicker.MinimumDateTime) +
                                   (_reserva_area_comum.hora_devolucao != null && _reserva_area_comum.hora_devolucao != DateTime.MinValue.TimeOfDay ? (TimeSpan)_reserva_area_comum.hora_devolucao : DateTimePicker.MinimumDateTime.TimeOfDay);

            txtObservacao.Text = _reserva_area_comum.observacao;

            txtID.Enabled = false;
            txtUsuario_solicitante_nome.Enabled = false;
            txtArea_comum_id.Enabled = false;
            txtArea_comum_nome.Enabled = false;
            txtData_inicio.Enabled = false;


            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {

                txtSolicitacao_id.Enabled = false;
                txtData_devolucao.Enabled = false;
                txtObservacao.Enabled = false;

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
            _reserva_area_comum.id = int.Parse(txtID.Text);
            _reserva_area_comum.editSolicitacao_id = int.Parse(txtSolicitacao_id.Text);
            if (_reserva_area_comum.editSolicitacao_id != 0)
                validaSolicitacao();

            _reserva_area_comum.data_devolucao = txtData_devolucao.Value != DateTimePicker.MinimumDateTime ? txtData_devolucao.Value.Date : DateTime.MinValue;
            _reserva_area_comum.hora_devolucao = txtData_devolucao.Value != DateTimePicker.MinimumDateTime ? txtData_devolucao.Value.TimeOfDay : DateTime.MinValue.TimeOfDay;
            _reserva_area_comum.observacao = txtObservacao.Text;
        }

        private void txtSolicitacao_id_Validated(object sender, EventArgs e)
        {
            try
            {
                txtUsuario_solicitante_nome.Text = string.Empty;
                txtArea_comum_id.Text = string.Empty;
                txtArea_comum_nome.Text = string.Empty;
                txtData_inicio.Value = DateTimePicker.MinimumDateTime;

                _reserva_area_comum.editSolicitacao_id = int.Parse(txtSolicitacao_id.Text);

                validaSolicitacao();

                if (_reserva_area_comum.solicitacao != null)
                {
                    txtUsuario_solicitante_nome.Text = _reserva_area_comum.solicitacao.dspSolicitante_nome;
                    txtArea_comum_id.Text = _reserva_area_comum.solicitacao.editArea_comum_id.ToString().Trim();
                    txtArea_comum_nome.Text = _reserva_area_comum.solicitacao.area_comum.nome;
                    txtData_inicio.Value = (_reserva_area_comum.solicitacao.data_inicio != null && _reserva_area_comum.solicitacao.data_inicio != DateTime.MinValue ? (DateTime)_reserva_area_comum.solicitacao.data_inicio : DateTimePicker.MinimumDateTime) +
                                            (_reserva_area_comum.solicitacao.hora_inicio != null && _reserva_area_comum.solicitacao.hora_inicio != DateTime.MinValue.TimeOfDay ? (TimeSpan)_reserva_area_comum.solicitacao.hora_inicio : DateTimePicker.MinimumDateTime.TimeOfDay);
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
            _reserva_area_comum.solicitacao = null;
            if (_reserva_area_comum.editSolicitacao_id != 0)
            {
                _reserva_area_comum.solicitacao = (new repositorio.SolicitacaoRepositorio(_context)).getSolicitacaoporID(_reserva_area_comum.editSolicitacao_id);
                if (_reserva_area_comum.solicitacao == null)
                {
                    throw new Exception("Solicitação não existe");

                }
                else if (_reserva_area_comum.solicitacao.editTipo != TipoSolicitacao.Reserva)
                {
                    throw new Exception("Solicitação não é do tipo de reserva de área comum");
                }

            }
        }
    }
}
