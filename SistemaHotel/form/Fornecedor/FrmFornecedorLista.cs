using SistemaHotel.dao;
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

namespace SistemaHotel.form.Fornecedor
{
    public partial class FrmFornecedorLista : Form
    { 
        private repositorio.FornecedorRepositorio _fornecedorRepositorio;
        private model.Permissao_old _permissoes;

        public FrmFornecedorLista()
        {
            InitializeComponent();
            _fornecedorRepositorio = new repositorio.FornecedorRepositorio();
            Util.acertaTabOrder(this);

        }

        private void atualizaLista()
        {

            gridRegistros.DataSource = new BindingSource(new BindingList<model.Fornecedor>(_fornecedorRepositorio.getFornecedores(txtNome.Text)), null);
            gridRegistros.Refresh();
        }

        private void FrmFornecedorLista_Load(object sender, EventArgs e)
        {
            _permissoes = dao.PermissaoDao.getPermissaoFuncionalidadeNome(Name);
            if (_permissoes.consultar == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            atualizaLista();
            if (_permissoes.supervisor == util.SimNao.NAO) {
                btnPermissao.Visible = false;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.inserir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmFornecedorFormulario formulario = new FrmFornecedorFormulario(Operacao.Insercao, _fornecedorRepositorio, new model.Fornecedor());
                formulario.ShowDialog();
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
                    var fornecedor = (model.Fornecedor)gridRegistros.CurrentRow.DataBoundItem;
                    FrmFornecedorFormulario formulario = new FrmFornecedorFormulario(Operacao.Alteracao, _fornecedorRepositorio,  fornecedor);
                    formulario.ShowDialog();
                    atualizaLista();
                }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.excluir == util.SimNao.NAO && _permissoes.supervisor == util.SimNao.NAO)
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
                    var fornecedor = (model.Fornecedor)gridRegistros.CurrentRow.DataBoundItem;
                    FrmFornecedorFormulario formulario = new FrmFornecedorFormulario(Operacao.Exclusao, _fornecedorRepositorio, fornecedor);
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
                var fornecedor = (model.Fornecedor)gridRegistros.CurrentRow.DataBoundItem;
                FrmFornecedorFormulario formulario = new FrmFornecedorFormulario(Operacao.Consulta, _fornecedorRepositorio, fornecedor);
                formulario.ShowDialog();
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }
    }
}
