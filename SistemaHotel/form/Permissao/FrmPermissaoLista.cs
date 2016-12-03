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

namespace SistemaHotel.form.Permissao
{
    public partial class FrmPermissaoLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.PermissaoRepositorio _permissaoRepositorio;
        private model.Funcionalidade _funcionalidadeEntrada;
        private model.Permissao _permissoes;

        public FrmPermissaoLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _funcionalidadeEntrada = null;
            _permissaoRepositorio = new repositorio.PermissaoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        public FrmPermissaoLista(model.SistemaHotelContext context, model.Usuario usuarioLogado, string nome_tela)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _funcionalidadeEntrada = (new repositorio.FuncionalidadeRepositorio(_context)).getFuncionalidadeporNome_tela(nome_tela);
            _permissaoRepositorio = new repositorio.PermissaoRepositorio(_context);
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
                FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Insercao, _context, _funcionalidadeEntrada, new model.Permissao());
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
                    var permissao = (model.Permissao)gridRegistros.CurrentRow.DataBoundItem;
                    FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Alteracao, _context, _funcionalidadeEntrada, permissao);
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
                    var permissao = (model.Permissao)gridRegistros.CurrentRow.DataBoundItem;
                    FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Exclusao, _context, _funcionalidadeEntrada, permissao);
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
                var permissao = (model.Permissao)gridRegistros.CurrentRow.DataBoundItem;
                FrmPermissaoFormulario formulario = new FrmPermissaoFormulario(Operacao.Consulta, _context, _funcionalidadeEntrada, permissao);
                formulario.ShowDialog();
            }
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            FrmPermissaoLista permissaoLista = new FrmPermissaoLista(_context, _usuarioLogado, Name);
            permissaoLista.ShowDialog();

        }

        private void FrmPermissao_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, Name);
            if (_permissoes == null || (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO))
            {
                MessageBox.Show("Usuário não tem permissão para consultar informações das permissões", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }

            if (_funcionalidadeEntrada != null)
            {
                txtFuncionalidade_id.Enabled = true;
                txtFuncionalidade_nome_funcionalidade.Enabled = true;

                txtFuncionalidade_id.Text = _funcionalidadeEntrada.id.ToString().Trim();
                txtFuncionalidade_nome_funcionalidade.Text = _funcionalidadeEntrada.nome_funcionalidade;

                txtFuncionalidade_id.Enabled = false;
                txtFuncionalidade_nome_funcionalidade.Enabled = false;

            }

            atualizaLista();
        }

        private void atualizaLista()
        {
            if (string.IsNullOrEmpty(txtFuncionalidade_id.Text))
                txtFuncionalidade_id.Text = "0";
            int funcionalidade_id = int.Parse(txtFuncionalidade_id.Text);
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Permissao>(_permissaoRepositorio.getPermissoes(funcionalidade_id, txtFuncionalidade_nome_funcionalidade.Text)), null);
            gridRegistros.Refresh();
        }
    }
}
