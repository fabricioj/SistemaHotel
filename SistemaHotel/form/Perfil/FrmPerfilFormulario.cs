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

namespace SistemaHotel.form.Perfil
{
    public partial class FrmPerfilFormulario : Form
    {
        private Operacao _op;
        private model.Perfil _perfil;
        private repositorio.PerfilRepositorio _perfilRepositorio;
        private model.SistemaHotelContext _context;

        public FrmPerfilFormulario(Operacao op, model.SistemaHotelContext context, model.Perfil perfil)
        {
            _op = op;
            _context = context;
            _perfil = perfil;
            _perfilRepositorio = new repositorio.PerfilRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }
        public void preencheForm() 
        {
            txtID.Enabled              = true;
            txtNome.Enabled            = true;
            cbSupervisor.DataSource = EnumHelper.ToList(typeof(SimNao));
            cbSupervisor.DisplayMember = "Value";
            cbSupervisor.ValueMember = "key";

            txtID.Text                 = _perfil.id.ToString().Trim();
            txtNome.Text               = _perfil.nome;
            cbSupervisor.SelectedItem = EnumHelper.SetValue(_perfil.editSupervisor);


            txtID.Enabled              = false;

            if (_op == Operacao.Consulta || _op == Operacao.Exclusao)
            {
                txtNome.Enabled = false;
                cbSupervisor.Enabled = false;


                if (_op == Operacao.Exclusao)
                    lblExcluir.Visible = true;
                if (_op == Operacao.Consulta)
                    btnConfirmar.Enabled = false;
            }
        }
        private void preencheObjeto() {
            _perfil.id              = int.Parse(txtID.Text)  ;
            _perfil.nome            = txtNome.Text           ;
            _perfil.editSupervisor = (SimNao)EnumHelper.GetValue(cbSupervisor.SelectedItem);
        }      


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                preencheObjeto();
                switch (_op)
                {
                    case Operacao.Insercao:
                        _perfilRepositorio.incluir(_perfil);
                        _perfilRepositorio.salvar();
                        _perfil = new model.Perfil();
                        preencheForm();
                        break;

                    case Operacao.Alteracao:
                        _perfilRepositorio.alterar(_perfil);
                        _perfilRepositorio.salvar();
                        Dispose();
                        break;

                    case Operacao.Exclusao:
                        _perfilRepositorio.excluir(_perfil);
                        _perfilRepositorio.salvar();
                        Dispose();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmPerfilFormulario_Load(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
