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
    public partial class FrmOrcamentoCorpo : Form
    {
        private Operacao _op;
        private repositorio.OrcamentoRepositorio _orcamentoRepositorio;
        private model.Orcamento _orcamento;
        private repositorio.Orcamento_itemRepositorio _orcamento_itemRepositorio;

        public FrmOrcamentoCorpo(Operacao op, repositorio.OrcamentoRepositorio orcamentoRepositorio, model.Orcamento orcamento)
        {
            InitializeComponent();
            Util.acertaTabOrder(this);
            this._op = op;
            this._orcamento = orcamento;
            this._orcamentoRepositorio = orcamentoRepositorio;
            this._orcamento_itemRepositorio = new repositorio.Orcamento_itemRepositorio();
        }

        private void preencheForm()
        {

            /*Aba principal*/
            txtID.Enabled = true;
            txtData_emissao.Enabled = true;
            txtData_confirmacao.Enabled = true;
            txtData_confirmacao.Enabled = true;
            txtFornecedor_id.Enabled = true;
            txtFornecedor_nome.Enabled = true;

            //txtAtividade_id.Enabled = true;
            //txtAtividade_nome.Enabled = true;

            txtID.Text = _orcamento.id.ToString().Trim();
            txtData_emissao.Text = _orcamento.data_emissao.ToString();
            txtData_confirmacao.Text = _orcamento.data_confirmacao.ToString();
            txtFornecedor_id.Text = _orcamento.fornecedor_id.ToString().Trim();
            if (_orcamento.fornecedor != null)
                txtFornecedor_nome.Text = _orcamento.fornecedor.nome;
            //txtAtividade_id.Text   = orcamento.atividade.id.ToString();
            //txtAtividade_nome.Text = orcamento.atividade.nome;


            txtID.Enabled = false;
            txtData_confirmacao.Enabled = false;
            
            txtFornecedor_nome.Enabled = false;
            txtData_emissao.Enabled = false;
            txtFornecedor_id.Enabled = false;
            //txtAtividade_id.Enabled = false;
            //txtAtividade_nome.Enabled = false;

            //Aba Itens
            gridItens.DataSource = new BindingSource(new BindingList<model.Orcamento_item>(_orcamento_itemRepositorio.getOrcamento_itens(_orcamento.id)), null);
            gridItens.Refresh();

            btnConfirmar.Enabled = true;
            btnInserir.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            if (_op == Operacao.Consulta)
            {
                btnConfirmar.Enabled = false;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            else {
                btnFechar.Enabled = false;
            }

            carregaAbas();

        }

        private void FrmOrcamentoCorpo_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void tabAbas_Selected(object sender, TabControlEventArgs e)
        {
            carregaAbas();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 1) //Itens
            {
                FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Insercao, _orcamento, _orcamento_itemRepositorio, new model.Orcamento_item());
                item.ShowDialog();
            }
            preencheForm();
        }
        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 0) //Principal
            {
                FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Alteracao, _orcamentoRepositorio, _orcamento);
                formulario.ShowDialog();
                formulario.Dispose();

            } else { // Itens
                if (gridItens.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var orcamento_item = (model.Orcamento_item)gridItens.CurrentRow.DataBoundItem;
                    FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Alteracao, _orcamento, _orcamento_itemRepositorio, orcamento_item);
                    item.ShowDialog();
                }
            }
            preencheForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 1) //Itens
            {
                if (gridItens.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var orcamento_item = (model.Orcamento_item)gridItens.CurrentRow.DataBoundItem;
                    FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Exclusao, _orcamento, _orcamento_itemRepositorio, orcamento_item);
                    item.ShowDialog();
                }
            }
            preencheForm();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 0) //Principal
            {
                FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Consulta, _orcamentoRepositorio, _orcamento);
                formulario.ShowDialog();
                formulario.Dispose();
            }
            else
            { // Itens
                if (gridItens.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var orcamento_item = (model.Orcamento_item)gridItens.CurrentRow.DataBoundItem;
                    FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Consulta, _orcamento, _orcamento_itemRepositorio, orcamento_item);
                    item.ShowDialog();
                }
            }
        }

        private void carregaAbas() {
            btnInserir.Enabled = true;
            btnExcluir.Enabled = true;
            if (tabAbas.SelectedIndex == 0) // Principal
            {
                btnInserir.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
