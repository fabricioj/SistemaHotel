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

namespace SistemaHotel.form.Funcionalidade
{
    public partial class FrmFuncionalidadeLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.FuncionalidadeRepositorio _funcionalidadeRepositorio;
        private model.Permissao _permissoes;

        public FrmFuncionalidadeLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            InitializeComponent();
            _funcionalidadeRepositorio = new repositorio.FuncionalidadeRepositorio(_context);
            Util.acertaTabOrder(this);
        }

        private void atualizaLista()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Funcionalidade>(_funcionalidadeRepositorio.getFuncionalidades()), null);
             gridRegistros.Refresh();
        }

        private void FrmFuncionalidadeLista_Load(object sender, EventArgs e)
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
       

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editInserir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                FrmFuncionalidadeFormulario formulario = new FrmFuncionalidadeFormulario(Operacao.Insercao, _context, new model.Funcionalidade());
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
            else {
                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var funcionaldade = (model.Funcionalidade)gridRegistros.CurrentRow.DataBoundItem;
                    FrmFuncionalidadeFormulario formulario = new FrmFuncionalidadeFormulario(Operacao.Alteracao, _context, funcionaldade);
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
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var funcionalidade = (model.Funcionalidade)gridRegistros.CurrentRow.DataBoundItem;
                FrmFuncionalidadeFormulario formulario = new FrmFuncionalidadeFormulario(Operacao.Exclusao, _context, funcionalidade);
                formulario.ShowDialog();
                atualizaLista();
            }
        }
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (_permissoes == null || (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO))
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                var funcionalidade = (model.Funcionalidade)gridRegistros.CurrentRow.DataBoundItem;
                FrmFuncionalidadeFormulario formulario = new FrmFuncionalidadeFormulario(Operacao.Consulta, _context, funcionalidade);
                    formulario.ShowDialog();
                atualizaLista();
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            using (var permissaoLista = new Permissao.FrmPermissaoLista(_context, _usuarioLogado, Name))
            {
                permissaoLista.ShowDialog();
            }
        }
    }
}
