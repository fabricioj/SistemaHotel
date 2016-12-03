using SistemaHotel.form.AreaComum;
using SistemaHotel.form.Atividade;
using SistemaHotel.form.Fornecedor;
using SistemaHotel.form.Funcionalidade;
using SistemaHotel.form.Funcionario;
using SistemaHotel.form.Orcamento;
using SistemaHotel.form.Perfil;
using SistemaHotel.form.Procedimento;
using SistemaHotel.form.Produto;
using SistemaHotel.form.ReservaAreaComum;
using SistemaHotel.form.Solicitacao;
using SistemaHotel.form.UsuarioLogin;
using SistemaHotel.form.Usuario;
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
            _usuarioLogado = new model.Usuario { id = 1, perfil_id = 1, perfil = new model.Perfil { id = 1, editSupervisor = util.SimNao.SIM} };
            InitializeComponent();
        }

        private void FrmSistemaHotel_Load(object sender, EventArgs e)
        {
            login();
        }

        private void mnuTrocaUsuario_Click(object sender, EventArgs e)
        {
            login();
        }
        private void mnuTrocaSenha_Click(object sender, EventArgs e)
        {
            using (var trocaSenha = new FrmUsuarioTrocaSenha(_context, _usuarioLogado))
            {
                trocaSenha.ShowDialog();
            }
        }

        private void login() {
            using (var login = new FrmUsuarioLogin(_context))
            {
                login.ShowDialog();
                _usuarioLogado = login.usuario;
                if (_usuarioLogado == null)
                {
                    Dispose();
                    return;
                }
            };
        }

        private void preencheForm() {

            mnuSolicitacoes.ToolTipText = string.Empty;
            mnuSolicitacoes.Image = null;
            var permissoes = repositorio.PermissaoRepositorio.getPermissaoFuncionalidadeNome(_context, _usuarioLogado, "FrmSolicitacaoVisualizar");
            if (permissoes != null && (permissoes.editEspecial == util.SimNao.SIM || permissoes.editSupervisor == util.SimNao.SIM))
            {
                var qtdSolicitacoes = new repositorio.SolicitacaoRepositorio(_context).getQuantidadeSolicitacoesNVistas();

                if (qtdSolicitacoes > 0)
                {
                    mnuSolicitacoes.ToolTipText = "Existe(m) " + qtdSolicitacoes.ToString().Trim() + " solicitação(ões) não vista(s).";
                    mnuSolicitacoes.Image = SistemaHotel.Properties.Resources.alerta;
                }
            }
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmProdutoLista(_context, _usuarioLogado)) {
                lista.ShowDialog();
            } ;
            
        }

        private void mnuFornecedores_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmFornecedorLista(_context, _usuarioLogado)) {
                lista.ShowDialog();
            };
        }

        private void mnuOrcamentos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmOrcamentoLista(_context, _usuarioLogado)) {
                lista.ShowDialog();
            };
        }

        private void mnuFuncionarios_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmFuncionarioLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }

        private void mnuAreasComuns_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmAreaComumLista(_context, _usuarioLogado))
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

        private void mnuReservasAreasComuns_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmReservaAreaComumLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }

        private void FrmSistemaHotel_Activated(object sender, EventArgs e)
        {
            preencheForm();
        }

        private void mnuProcedimentos_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmProcedimentoLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }

        private void mnuAtividades_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmAtividadeLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }

        private void mnuFuncionalidades_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmFuncionalidadeLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }

        private void mnuPerfis_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmPerfilLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            using (var lista = new FrmUsuarioLista(_context, _usuarioLogado))
            {
                lista.ShowDialog();
            }
        }
    }
}
