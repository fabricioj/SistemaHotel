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
        private model.SistemaHotelContext _context;
        private model.Orcamento _orcamento;
        private repositorio.Orcamento_itemRepositorio _orcamento_itemRepositorio;

        public FrmOrcamentoCorpo(Operacao op, model.SistemaHotelContext context, model.Orcamento orcamento)
        {
            _op = op;
            _context = context;
            _orcamento = orcamento;
            _orcamento_itemRepositorio = new repositorio.Orcamento_itemRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);

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

            txtAtividade_id.Enabled = true;
            txtAtividade_nome.Enabled = true;

            txtID.Text = _orcamento.id.ToString().Trim();
            txtData_emissao.Text = _orcamento.data_emissao.ToString();
            txtData_confirmacao.Text = _orcamento.data_confirmacao.ToString();
            txtFornecedor_id.Text = _orcamento.edtFornecedor_id.ToString().Trim();
            txtFornecedor_nome.Text = string.Empty;
            if (_orcamento.fornecedor != null)
                txtFornecedor_nome.Text = _orcamento.fornecedor.nome;

            txtAtividade_id.Text   = _orcamento.edtAtividade_id.ToString();
            txtAtividade_nome.Text = string.Empty;
            if (_orcamento.atividade != null)
                txtAtividade_nome.Text = _orcamento.atividade.nome;


            txtID.Enabled = false;
            txtData_confirmacao.Enabled = false;

            txtFornecedor_nome.Enabled = false;
            txtData_emissao.Enabled = false;
            txtFornecedor_id.Enabled = false;
            txtAtividade_id.Enabled = false;
            txtAtividade_nome.Enabled = false;

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
            else
            {
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
                FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Insercao, _context, _orcamento, new model.Orcamento_item());
                item.ShowDialog();
            }
            preencheForm();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 0) //Principal
            {
                FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Alteracao, _context, _orcamento);
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
                    FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Alteracao, _context, _orcamento, orcamento_item);
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
                    FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Exclusao, _context, _orcamento, orcamento_item);
                    item.ShowDialog();
                }
            }
            preencheForm();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (tabAbas.SelectedIndex == 0) //Principal
            {
                FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Consulta, _context, _orcamento);
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
                    FrmOrcamentoItem item = new FrmOrcamentoItem(Operacao.Consulta, _context, _orcamento, orcamento_item);
                    item.ShowDialog();
                }
            }
        }

        private void carregaAbas()
        {
            if (_op != Operacao.Consulta)
            {
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
                if (tabAbas.SelectedIndex == 0) // Principal
                {
                    btnInserir.Enabled = false;
                    btnExcluir.Enabled = false;
                }
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
