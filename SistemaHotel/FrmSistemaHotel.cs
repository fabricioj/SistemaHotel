using SistemaHotel.form.AreaComum;
using SistemaHotel.form.Fornecedor;
using SistemaHotel.form.Funcionario;
using SistemaHotel.form.Orcamento;
using SistemaHotel.form.Produto;
using SistemaHotel.form.Solicitacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmSistemaHotel : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;

        public FrmSistemaHotel()
        {
            _context = new model.SistemaHotelContext();
            _usuarioLogado = new model.Usuario { id = 1 };
            InitializeComponent();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmProdutoLista(_context)) {
                lista.ShowDialog();
            } ;
            
        }

        private void mnuFornecedores_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmFornecedorLista(_context)) {
                lista.ShowDialog();
            };
        }

        private void mnuOrcamentos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmOrcamentoLista(_context)) {
                lista.ShowDialog();
            };
        }

        private void mnuFuncionarios_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmFuncionarioLista(_context))
            {
                lista.ShowDialog();
            }
        }

        private void mnuAreasComuns_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmAreaComumLista(_context))
            {
                lista.ShowDialog();
            }
        }

        private void mnuSolicitacoes_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmSolicitacaoLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }
    }
}
