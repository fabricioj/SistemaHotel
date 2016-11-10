using SistemaHotel.form.Fornecedor;
using SistemaHotel.form.Orcamento;
using SistemaHotel.form.Produto;
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
        public FrmSistemaHotel()
        {
            InitializeComponent();
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmProdutoLista()) {
                lista.ShowDialog();
            } ;
            
        }

        private void mnuFornecedores_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmFornecedorLista()) {
                lista.ShowDialog();
            };
        }

        private void mnuOrcamentos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmOrcamentoLista()) {
                lista.ShowDialog();
            };
        }
    }
}
