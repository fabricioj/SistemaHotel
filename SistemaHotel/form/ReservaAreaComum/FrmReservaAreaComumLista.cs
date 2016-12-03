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
        private model.Usuario _usuarioLogado;
        private repositorio.Reserva_area_comumRepositorio _reserva_area_comumRepositorio;
        private model.Permissao _permissoes;

        public FrmReservaAreaComumLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _reserva_area_comumRepositorio = new repositorio.Reserva_area_comumRepositorio(_context);
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
                FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Insercao, _context, new model.Reserva_area_comum());
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
                    var reserva_area_comum = (model.Reserva_area_comum)gridRegistros.CurrentRow.DataBoundItem;
                    FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Alteracao, _context, reserva_area_comum);
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
                    var reserva_area_comum = (model.Reserva_area_comum)gridRegistros.CurrentRow.DataBoundItem;
                    FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Exclusao, _context, reserva_area_comum);
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
                var reserva_area_comum = (model.Reserva_area_comum)gridRegistros.CurrentRow.DataBoundItem;
                FrmReservaAreaComumFormulario formulario = new FrmReservaAreaComumFormulario(Operacao.Consulta, _context, reserva_area_comum);
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

        private void FrmReservaAreaComum_Load(object sender, EventArgs e)
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
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Reserva_area_comum>(_reserva_area_comumRepositorio.getReservas_area_comum(ckSomenteNDevolvidas.Checked, txtArea_nome.Text)), null);
            gridRegistros.Refresh();
        }

        private void toolDevolucaoAreaComum_Click(object sender, EventArgs e)
        {
            if (gridRegistros.CurrentRow == null)
            {
                MessageBox.Show("Nenhum registro selecionado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var reserva_area_comum = (model.Reserva_area_comum)gridRegistros.CurrentRow.DataBoundItem;
                using (var devolucao = new FrmReservaAreaComumDevolucao(Operacao.Alteracao, _context, _usuarioLogado, reserva_area_comum)) {
                    devolucao.ShowDialog();
                } ;

                atualizaLista();
            }
        }
    }
}
