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
    public partial class FrmSolicitacaoLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.SolicitacaoRepositorio _solicitacaoRepositorio;
        private model.Permissao _permissoes;

        public FrmSolicitacaoLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _solicitacaoRepositorio = new repositorio.SolicitacaoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editInserir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                FrmSolicitacaoFormulario formulario = new FrmSolicitacaoFormulario(Operacao.Insercao, _context, new model.Solicitacao { usuario_solicitante_id = _usuarioLogado.id });
                formulario.ShowDialog();
                atualizaLista();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_permissoes.editAlterar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para alterar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var solicitacao = (model.Solicitacao)gridRegistros.CurrentRow.DataBoundItem;
                    if (solicitacao.data_visualizacao != null && solicitacao.data_visualizacao != DateTime.MinValue)
                    {
                        MessageBox.Show("Solicitação já visualizada pelo responsável", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        FrmSolicitacaoFormulario formulario = new FrmSolicitacaoFormulario(Operacao.Alteracao, _context, solicitacao);
                        formulario.ShowDialog();
                        atualizaLista();
                    }
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editExcluir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para excluir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var solicitacao = (model.Solicitacao)gridRegistros.CurrentRow.DataBoundItem;
                    FrmSolicitacaoFormulario formulario = new FrmSolicitacaoFormulario(Operacao.Exclusao, _context, solicitacao);
                    formulario.ShowDialog();
                    atualizaLista();
                }

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var solicitacao = (model.Solicitacao)gridRegistros.CurrentRow.DataBoundItem;
                FrmSolicitacaoFormulario formulario = new FrmSolicitacaoFormulario(Operacao.Consulta, _context, solicitacao);
                formulario.ShowDialog();
            }
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            using (var permissaoLista = new Permissao.FrmPermissaoLista(_context, _usuarioLogado, Name))
            {
                permissaoLista.ShowDialog();
            }
        }

        private void FrmSolicitacao_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
            if (_permissoes == null || (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO))
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }

            cbTipo.DataSource = EnumHelper.ToList(typeof(TipoSolicitacao));
            cbTipo.DisplayMember = "Value";
            cbTipo.ValueMember = "Key";

            cbTipo.SelectedItem = EnumHelper.SetValue(TipoSolicitacao.Nenhum);

            ckSomenteNVisualizadas.Checked = false;

            atualizaLista();
        }

        private void atualizaLista()
        {
            var tipo = (TipoSolicitacao)EnumHelper.GetValue(cbTipo.SelectedItem);
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Solicitacao>(_solicitacaoRepositorio.getSolicitacoes(ckSomenteNVisualizadas.Checked, tipo)), null);
            gridRegistros.Refresh();
        }

        private void toolVistarSolicitacao_Click(object sender, EventArgs e)
        {
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var solicitacao = (model.Solicitacao)gridRegistros.CurrentRow.DataBoundItem;
                Operacao op = Operacao.Alteracao;

                FrmSolicitacaoVisualizar formulario = new FrmSolicitacaoVisualizar(op, _usuarioLogado, _context, solicitacao);
                formulario.ShowDialog();
                atualizaLista();

            }
        }
    }
}
