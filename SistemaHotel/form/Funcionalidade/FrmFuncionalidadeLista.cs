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
        private repositorio.FuncionalidadeRepositorio _funcionalidadeRepositorio;
        private model.Permissao_old _permissao;

        public FrmFuncionalidadeLista()
        {
            InitializeComponent();
            _funcionalidadeRepositorio = new repositorio.FuncionalidadeRepositorio();
            Util.acertaTabOrder(this);
        }

        private void atualiza()
        {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Funcionalidade>(_funcionalidadeRepositorio.getFuncionalidades()), null);
             gridRegistros.Refresh();//
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void FrmFuncionalidadeLista_Load(object sender, EventArgs e)
        {

        }
    }
}
