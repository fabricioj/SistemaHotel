using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.form.Funcionario
{
    public partial class FrmFuncionarioLista : Form
    {
        private model.SistemaHotelContext _context;
        private repositorio.FuncionarioRepositorio retpositorio;
        public FrmFuncionarioLista()
        {
            InitializeComponent();
        }
    }
}
