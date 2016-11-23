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
    public partial class FrmSolicitacaoVisualizar : Form
    {
        private Operacao _op;
        private model.SistemaHotelContext _context;
        private model.Solicitacao _solicitacao;
        private repositorio.SolicitacaoRepositorio _solicitacaoRepositorio;

        public FrmSolicitacaoVisualizar(Operacao op, model.Usuario usuarioLogado, model.SistemaHotelContext context, model.Solicitacao _solicitacao)
        {
            this._op = op;
            this._context = context;
            this._solicitacao = _solicitacao;
            this._solicitacao.editUsuario_visualizacao_id = usuarioLogado.id;
            this._solicitacaoRepositorio = new repositorio.SolicitacaoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();

                if (_op == Operacao.Alteracao)
                {
                    int id = _solicitacaoRepositorio.gravaVisualizacao(_solicitacao);
                    if (_solicitacao.editTipo == TipoSolicitacao.Reserva)
                    {
                        if (id != 0)
                        {
                            var reserva = new repositorio.Reserva_area_comumRepositorio(_context).getReserva_area_comumporID(id);
                            var formulario = new ReservaAreaComum.FrmReservaAreaComumFormulario(Operacao.Alteracao, _context, reserva);
                            formulario.ShowDialog();
                        }
                    }
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

        private void btnPermissao_Click(object sender, EventArgs e)
        {

        }

        private void FrmSolicitacaoVisualizar_Load(object sender, EventArgs e)
        {
            var permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, Name);
            if (permissoes.editEspecial != util.SimNao.SIM && permissoes.editSupervisor != util.SimNao.SIM)
            {
                Dispose();
            }
            if (_solicitacao.data_visualizacao == null || _solicitacao.data_visualizacao == DateTime.MinValue)
                _solicitacao.data_visualizacao = DateTime.Now;
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;
            txtUsuario_solicitante_nome.Enabled = true;
            cbTipo.Enabled = true;
            txtServico.Enabled = true;
            txtLocal.Enabled = true;
            txtArea_comum_id.Enabled = true;
            txtArea_comum_nome.Enabled = true;
            txtData_inicio.Enabled = true;
            txtData_fim.Enabled = true;

            cbTipo.DataSource = EnumHelper.ToList(typeof(TipoSolicitacao));
            cbTipo.DisplayMember = "Value";
            cbTipo.ValueMember = "Key";

            cbResultado_visualizacao.DataSource = EnumHelper.ToList(typeof(TipoResultadoSolicitacao));
            cbResultado_visualizacao.DisplayMember = "Value";
            cbResultado_visualizacao.ValueMember = "Key";

            txtID.Text = _solicitacao.id.ToString().Trim();

            txtUsuario_solicitante_nome.Text = _solicitacao.dspSolicitante_nome;

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

            txtData_visualizacao.Value = _solicitacao.data_visualizacao != null && _solicitacao.data_visualizacao != DateTime.MinValue ? (DateTime)_solicitacao.data_visualizacao : DateTimePicker.MinimumDateTime;
            cbResultado_visualizacao.SelectedItem = EnumHelper.SetValue(_solicitacao.editResultado_visualizacao);
            txtObservacao.Text = _solicitacao.observacao_visualizacao;

            txtID.Enabled = false;
            txtUsuario_solicitante_nome.Enabled = false;
            cbTipo.Enabled = false;
            txtServico.Enabled = false;
            txtLocal.Enabled = false;
            txtArea_comum_id.Enabled = false;
            txtArea_comum_nome.Enabled = false;
            txtData_inicio.Enabled = false;
            txtData_fim.Enabled = false;

            if (_op == Operacao.Consulta)
            {
                txtData_visualizacao.Enabled = false;
                cbResultado_visualizacao.Enabled = false;
                txtObservacao.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void preencheObjeto()
        {
            _solicitacao.data_visualizacao = txtData_visualizacao.Value != DateTimePicker.MinimumDateTime ? txtData_visualizacao.Value.Date : DateTime.MinValue;
            _solicitacao.editResultado_visualizacao = (TipoResultadoSolicitacao)EnumHelper.GetValue(cbResultado_visualizacao.SelectedItem);
            _solicitacao.observacao_visualizacao = txtObservacao.Text;

        }

    }
}
