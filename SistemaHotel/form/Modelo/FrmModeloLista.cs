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

namespace SistemaHotel.form.Modelo
{
    public partial class FrmModeloLista : Form
    {
        private model.SistemaHotelContext _context;
        //private repositorio.ModeloRepositorio _modeloRepositorio;
        private model.Permissao _permissoes;

        public FrmModeloLista(model.SistemaHotelContext context)
        {
            _context = context;
            //_modeloRepositorio = new repositorio.ModeloRepositorio(_context);
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
                //FrmModeloFormulario formulario = new FrmModeloFormulario(Operacao.Insercao, _context, new model.Modelo());
                //formulario.ShowDialog();
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
                    //var modelo = (model.Modelo)gridRegistros.CurrentRow.DataBoundItem;
                    //FrmModeloFormulario formulario = new FrmModeloFormulario(Operacao.Alteracao, _context, modelo);
                    //formulario.ShowDialog();
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
                    //var modelo = (model.Modelo)gridRegistros.CurrentRow.DataBoundItem;
                    //FrmModeloFormulario formulario = new FrmModeloFormulario(Operacao.Exclusao, _context, modelo);
                    //formulario.ShowDialog();
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
                //var modelo = (model.Modelo)gridRegistros.CurrentRow.DataBoundItem;
                //FrmModeloFormulario formulario = new FrmModeloFormulario(Operacao.Consulta, _context, modelo);
                //formulario.ShowDialog();
            }
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {

        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            _permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, Name);
            if (_permissoes.editConsultar == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para consultar registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            atualizaLista();
            if (_permissoes.editSupervisor == util.SimNao.NAO)
            {
                btnPermissao.Visible = false;
            }
        }

        private void atualizaLista()
        {

            //gridRegistros.DataSource = new BindingSource(new BindingList<model.Modelo>(_modeloRepositorio.getModelos(txtNome.Text)), null);
            //gridRegistros.Refresh();
        }
    }
}
