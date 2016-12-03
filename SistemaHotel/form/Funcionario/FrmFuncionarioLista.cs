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

namespace SistemaHotel.form.Funcionario
{
    public partial class FrmFuncionarioLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.FuncionarioRepositorio _funcionarioRepositorio;
        private model.Permissao _permissoes;

        public FrmFuncionarioLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _funcionarioRepositorio = new repositorio.FuncionarioRepositorio(_context);
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
                FrmFuncionarioFormulario formulario = new FrmFuncionarioFormulario(Operacao.Insercao, _context, new model.Funcionario());
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
                    var funcionario = (model.Funcionario)gridRegistros.CurrentRow.DataBoundItem;
                    FrmFuncionarioFormulario formulario = new FrmFuncionarioFormulario(Operacao.Alteracao, _context, funcionario);
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
                    var funcionario = (model.Funcionario)gridRegistros.CurrentRow.DataBoundItem;
                    FrmFuncionarioFormulario formulario = new FrmFuncionarioFormulario(Operacao.Exclusao, _context, funcionario);
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
                var funcionario = (model.Funcionario)gridRegistros.CurrentRow.DataBoundItem;
                FrmFuncionarioFormulario formulario = new FrmFuncionarioFormulario(Operacao.Consulta, _context, funcionario);
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

        private void FrmFuncionarioLista_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
            if (_permissoes == null || (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO))
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }
            atualizaLista();
        }

        private void atualizaLista()
        {

            gridRegistros.DataSource = new BindingSource(new BindingList<model.Funcionario>(_funcionarioRepositorio.getFuncionarios(txtNome.Text)), null);
            gridRegistros.Refresh();
        }
        
    }
}
