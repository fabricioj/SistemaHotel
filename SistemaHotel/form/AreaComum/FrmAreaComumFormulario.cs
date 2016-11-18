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

namespace SistemaHotel.form.AreaComum
{
    public partial class FrmAreaComumFormulario : Form
    {
        private Operacao _op;
        private model.Area_comum _area_comum;
        private model.SistemaHotelContext _context;
        private repositorio.Area_comumRepositorio _area_comumRepositorio;
        public FrmAreaComumFormulario(util.Operacao op, model.SistemaHotelContext context, model.Area_comum area_comum)
        {
            _op = op;
            _context = context;
            _area_comum = area_comum;
            _area_comumRepositorio = new repositorio.Area_comumRepositorio(_context);
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
                        _area_comumRepositorio.incluir(_area_comum);
                        _area_comumRepositorio.salvar();
                        _area_comum = new model.Area_comum();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _area_comumRepositorio.alterar(_area_comum);
                        _area_comumRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _area_comumRepositorio.excluir(_area_comum);
                        _area_comumRepositorio.salvar();
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

        private void FrmAreaComumFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void preencheForm() {
            txtID.Enabled            = true;
            txtData_cadastro.Enabled = true;
            txtNome.Enabled          = true;
            txtObservacao.Enabled    = true;

            txtID.Text               = _area_comum.id.ToString().Trim(); 
            txtData_cadastro.Value   = _area_comum.data_cadastro != null && _area_comum.data_cadastro != DateTime.MinValue ? (DateTime)_area_comum.data_cadastro : DateTimePicker.MinimumDateTime;
            txtNome.Text             = _area_comum.nome;
            txtObservacao.Text       = _area_comum.observacao;

            txtID.Enabled            = false;
            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtData_cadastro.Enabled = false;
                txtNome.Enabled          = false;
                txtObservacao.Enabled    = false;
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
            _area_comum.id = int.Parse(txtID.Text);
            _area_comum.data_cadastro = txtData_cadastro.Value != DateTimePicker.MinimumDateTime ? txtData_cadastro.Value : DateTime.MinValue;
            _area_comum.nome = txtNome.Text;
            _area_comum.observacao = txtObservacao.Text;

        }

    }
}
