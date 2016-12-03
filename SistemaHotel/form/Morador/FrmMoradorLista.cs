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

namespace SistemaHotel.form.Morador
{
    public partial class FrmMoradorLista : Form
    {
        private model.Permissao _permissoes;
        private model.Usuario _usuarioLogado;
        private model.SistemaHotelContext _context;
        private repositorio.MoradorRepositorio _moradorReposistorio;

        public FrmMoradorLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _moradorReposistorio =  new repositorio.MoradorRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editInserir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                FrmMoradorFormulario formulario = new FrmMoradorFormulario(Operacao.Insercao, _context, new model.Morador());
                formulario.ShowDialog();
                atualizaLista();
            }
        }
        private void atualizaLista() 
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Morador>(_moradorReposistorio.getMoradores(txtNome.Text)), null);
            gridRegistros.Refresh();

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
                    var morador = (model.Morador)gridRegistros.CurrentRow.DataBoundItem;
                    FrmMoradorFormulario formulario = new FrmMoradorFormulario(Operacao.Alteracao, _context, morador);
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
            else {
                if (gridRegistros.CurrentRow == null)
                {
                    MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {
                    var morador = (model.Morador)gridRegistros.CurrentRow.DataBoundItem;
                    FrmMoradorFormulario formulario = new FrmMoradorFormulario(Operacao.Exclusao, _context, morador);
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
                var morador = (model.Morador)gridRegistros.CurrentRow.DataBoundItem;
                FrmMoradorFormulario formulario = new FrmMoradorFormulario(Operacao.Consulta, _context, morador);
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

        private void FrmMoradorLista_Load(object sender, EventArgs e)
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
    }
}
