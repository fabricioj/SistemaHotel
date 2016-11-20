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
    public partial class FrmModeloFormulario : Form
    {
        private Operacao _op;
        //private model.SistemaHotelContext _context;
        //private model.Modelo _modelo;
        //private repositorio.ModeloRepositorio _modeloRepositorio;

        public FrmModeloFormulario(Operacao op, model.SistemaHotelContext context/*, model.Modelo modelo*/)
        {
            _op = op;
            //_context = context;
            //_modelo = modelo;
            //_modeloRepositorio = new repositorio.ModeloRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        //_modeloRepositorio.incluir(_modelo);
                        //_modeloRepositorio.salvar();
                        //_modelo = new model.Modelo();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        //_modeloRepositorio.alterar(_modelo);
                        //_modeloRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        //_modeloRepositorio.excluir(_modelo);
                        //_modeloRepositorio.salvar();
                        Dispose();
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmModeloFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm()
        {
            txtID.Enabled = true;

            //txtID.Text = _modelo.id.ToString().Trim();

            txtID.Enabled = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao) {



                if (_op == Operacao.Exclusao)
                {
                    lblExcluir.Visible = true;
                }

                if (_op == Operacao.Consulta)
                {
                    btnConfirmar.Enabled = false;
                }
            }
        }

        private void preencheObjeto() {
            //_modelo.id = int.Parse(txtID.Text);
        }
    }
}
