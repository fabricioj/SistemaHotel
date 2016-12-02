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
    public partial class FrmProcedimentoLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.ProcedimentoRepositorio _procedimentoRepositorio;
        private model.Permissao _permissoes;

        public FrmProcedimentoLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _procedimentoRepositorio = new repositorio.ProcedimentoRepositorio(_context);
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
                FrmProcedimentoFormulario formulario = new FrmProcedimentoFormulario(Operacao.Insercao, _context, new model.Procedimento());
                formulario.ShowDialog();
                if (formulario.procedimento.id != 0)
                {
                    FrmProcedimentoCorpo corpo = new FrmProcedimentoCorpo(Operacao.Insercao, _context, formulario.procedimento);
                    corpo.ShowDialog();
                    formulario.Dispose();
                }
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
                    var procedimento = (model.Procedimento)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProcedimentoCorpo formulario = new FrmProcedimentoCorpo(Operacao.Alteracao, _context, procedimento);
                    formulario.ShowDialog();
                    atualizaLista();
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
                    var procedimento = (model.Procedimento)gridRegistros.CurrentRow.DataBoundItem;
                    FrmProcedimentoFormulario formulario = new FrmProcedimentoFormulario(Operacao.Exclusao, _context, procedimento);
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
                var procedimento = (model.Procedimento)gridRegistros.CurrentRow.DataBoundItem;
                FrmProcedimentoCorpo formulario = new FrmProcedimentoCorpo(Operacao.Consulta, _context, procedimento);
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

        private void FrmProcedimento_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
            if (_permissoes == null || (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO))
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }
            atualizaLista();
            if (_permissoes.editSupervisor == util.SimNao.NAO)
            {
                btnPermissao.Visible = false;
            }
        }

        private void atualizaLista()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Procedimento>(_procedimentoRepositorio.getProcedimentos(txtDescricao.Text)), null);
            gridRegistros.Refresh();
        }
    }
}
