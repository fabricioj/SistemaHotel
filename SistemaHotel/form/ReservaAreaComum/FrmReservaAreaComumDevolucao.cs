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
    public partial class FrmReservaAreaComumDevolucao : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private model.Reserva_area_comum _reserva_area_comum;
        private repositorio.Reserva_area_comumRepositorio _reserva_area_comumRepositorio;

        public FrmReservaAreaComumDevolucao(Operacao op, model.SistemaHotelContext context, model.Usuario usuarioLogado, model.Reserva_area_comum reserva_area_comum)
        {
            _op = op;
            _context = context;
            _usuarioLogado = usuarioLogado;
            _reserva_area_comum = reserva_area_comum;
            _reserva_area_comumRepositorio = new repositorio.Reserva_area_comumRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                if (_op == Operacao.Alteracao) { 
                    _reserva_area_comumRepositorio.alterar(_reserva_area_comum);
                    _reserva_area_comumRepositorio.salvar();
                    Dispose();

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

        private void FrmReservaAreaComumDevolucao_Load(object sender, EventArgs e)
        {
            var permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
            if (permissoes.editEspecial != util.SimNao.SIM && permissoes.editSupervisor != util.SimNao.SIM)
            {
                MessageBox.Show("Usuário não tem permissão para devolver áreas comuns", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;

            txtID.Enabled = true;
            txtUsuario_solicitante_nome.Enabled = true;
            txtArea_comum_id.Enabled = true;
            txtArea_comum_nome.Enabled = true;
            txtData_inicio.Enabled = true;
            txtData_devolucao.Enabled = true;
            txtObservacao.Enabled = true;

            txtID.Text = _reserva_area_comum.id.ToString().Trim();
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
            txtObservacao.Text = _reserva_area_comum.observacao_devolucao;

            txtID.Enabled = false;
            txtUsuario_solicitante_nome.Enabled = false;
            txtArea_comum_id.Enabled = false;
            txtArea_comum_nome.Enabled = false;
            txtData_inicio.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {
                txtData_devolucao.Enabled = false;
                txtObservacao.Enabled     = false;
                if (_op == Operacao.Consulta)
                {
                    btnConfirmar.Enabled = false;
                }
            }
        }

        private void preencheObjeto() {
            _reserva_area_comum.data_devolucao       = txtData_devolucao.Value != DateTimePicker.MinimumDateTime ? txtData_devolucao.Value.Date : DateTime.MinValue;
            _reserva_area_comum.hora_devolucao       = txtData_devolucao.Value != DateTimePicker.MinimumDateTime ? txtData_devolucao.Value.TimeOfDay : DateTime.MinValue.TimeOfDay;
            _reserva_area_comum.observacao_devolucao = txtObservacao.Text;
        }
    }
}
