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

namespace SistemaHotel.form.ReservaAreaComum
{
    public partial class FrmReservaAreaComumLista : Form
    {
        private model.SistemaHotelContext _context;
        //private repositorio.ReservaAreaComumRepositorio _modeloRepositorio;
        private model.Permissao _permissoes;

        public FrmReservaAreaComumLista(model.SistemaHotelContext context)
        {
            _context = context;
            //_modeloRepositorio = new repositorio.ReservaAreaComumRepositorio(_context);
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
                //FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Insercao, _context, new model.ReservaAreaComum());
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
                    //var modelo = (model.ReservaAreaComum)gridRegistros.CurrentRow.DataBoundItem;
                    //FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Alteracao, _context, fornecedor);
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
                    //var modelo = (model.ReservaAreaComum)gridRegistros.CurrentRow.DataBoundItem;
                    //FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Exclusao, _context, fornecedor);
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
                //var modelo = (model.ReservaAreaComum)gridRegistros.CurrentRow.DataBoundItem;
                //FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Consulta, _context, fornecedor);
                //formulario.ShowDialog();
            }
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {

        }

        private void FrmReservaAreaComum_Load(object sender, EventArgs e)
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

            //gridRegistros.DataSource = new BindingSource(new BindingList<model.ReservaAreaComum>(_modeloRepositorio.getReservaAreaComums(txtNome.Text)), null);
            //gridRegistros.Refresh();
        }
    }
}
