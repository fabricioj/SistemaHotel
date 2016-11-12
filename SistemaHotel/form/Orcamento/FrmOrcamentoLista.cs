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
    public partial class FrmOrcamentoLista : Form
    {
        private model.SistemaHotelContext _context;
        private repositorio.OrcamentoRepositorio _orcamentoRepositorio;
        private model.Permissao_old _permissoes;

        public FrmOrcamentoLista(model.SistemaHotelContext context)
        {
            _context = context;
            _orcamentoRepositorio = new repositorio.OrcamentoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void FrmOrcamentoLista_Load(object sender, EventArgs e)
        {
            _permissoes = dao.PermissaoDao.getPermissaoFuncionalidadeNome(Name);
            if (_permissoes.consultar == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            atualizaLista();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.inserir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Insercao, _context, new model.Orcamento());
                formulario.ShowDialog();
                if (formulario.orcamento.id != 0)
                {
                    FrmOrcamentoCorpo corpo = new FrmOrcamentoCorpo(Operacao.Insercao, _context, formulario.orcamento);
                    corpo.ShowDialog();
                }
                formulario.Dispose();
                atualizaLista();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (_permissoes.alterar == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
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
                    var orcamento = (model.Orcamento)gridRegistros.CurrentRow.DataBoundItem;
                    FrmOrcamentoCorpo corpo = new FrmOrcamentoCorpo(Operacao.Alteracao, _context, orcamento);
                    corpo.ShowDialog();
                    atualizaLista();
                }

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.excluir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
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
                    var orcamento = (model.Orcamento)gridRegistros.CurrentRow.DataBoundItem;
                    FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Exclusao, _context, orcamento);
                    formulario.ShowDialog();
                    formulario.Dispose();
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
                var orcamento = (model.Orcamento)gridRegistros.CurrentRow.DataBoundItem;
                FrmOrcamentoCorpo corpo = new FrmOrcamentoCorpo(Operacao.Consulta, _context, orcamento);
                corpo.ShowDialog();
            }

        }
        private void atualizaLista() {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Orcamento>(_orcamentoRepositorio.getOrcamentos(txtFornecedor_nome.Text, txtAtividade_nome.Text)), null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

    }
}
