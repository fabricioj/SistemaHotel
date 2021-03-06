﻿using SistemaHotel.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.form.Orcamento
{
    public partial class FrmOrcamentoLista : Form
    {
        private model.SistemaHotelContext _context;
        private model.Usuario _usuarioLogado;
        private repositorio.OrcamentoRepositorio _orcamentoRepositorio;
        private model.Permissao _permissoes;

        public FrmOrcamentoLista(model.SistemaHotelContext context, model.Usuario usuarioLogado)
        {
            _context = context;
            _usuarioLogado = usuarioLogado;
            _orcamentoRepositorio = new repositorio.OrcamentoRepositorio(_context);
            InitializeComponent();
            Util.acertaTabOrder(this);
        }

        private void FrmOrcamentoLista_Load(object sender, EventArgs e)
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editInserir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
            {
                MessageBox.Show("Usuário não tem permissão para inserir registros", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Insercao, _context, new model.Orcamento());
                formulario.ShowDialog();
                if (formulario.orcamento.id != 0)
                {
                    FrmOrcamentoCorpo corpo = new FrmOrcamentoCorpo(Operacao.Insercao, _context, formulario.orcamento);
                    corpo.ShowDialog();
                }
                formulario.Dispose();
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
                    var orcamento = (model.Orcamento)gridRegistros.CurrentRow.DataBoundItem;
                    FrmOrcamentoCorpo corpo = new FrmOrcamentoCorpo(Operacao.Alteracao, _context, orcamento);
                    corpo.ShowDialog();
                    atualizaLista();
                }

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_permissoes.editExcluir == util.SimNao.NAO && _permissoes.editSupervisor == util.SimNao.NAO)
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
                    var orcamento = (model.Orcamento)gridRegistros.CurrentRow.DataBoundItem;
                    FrmOrcamentoFormulario formulario = new FrmOrcamentoFormulario(Operacao.Exclusao, _context, orcamento);
                    formulario.ShowDialog();
                    formulario.Dispose();
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
                var orcamento = (model.Orcamento)gridRegistros.CurrentRow.DataBoundItem;
                FrmOrcamentoCorpo corpo = new FrmOrcamentoCorpo(Operacao.Consulta, _context, orcamento);
                corpo.ShowDialog();
            }

        }
        private void atualizaLista() {
            gridRegistros.DataSource = new BindingSource(new BindingList<model.Orcamento>(_orcamentoRepositorio.getOrcamentos(txtFornecedor_nome.Text, txtAtividade_nome.Text)), null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atualizaLista();
        }

        private void btnPermissao_Click(object sender, EventArgs e)
        {
            using (var permissaoLista = new Permissao.FrmPermissaoLista(_context, _usuarioLogado, Name))
            {
                permissaoLista.ShowDialog();
            }
        }
    }
}
