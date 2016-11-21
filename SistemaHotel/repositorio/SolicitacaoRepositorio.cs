using SistemaHotel.model;
using SistemaHotel.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace SistemaHotel.repositorio
{
    public class SolicitacaoRepositorio
    {
        private SistemaHotelContext _context;
        public SolicitacaoRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }

        public void incluir(Solicitacao solicitacao)
        {
            _context.solicitacao.Add(solicitacao);

        }
        public void alterar(Solicitacao solicitacao)
        {
            _context.Entry(solicitacao).State = System.Data.Entity.EntityState.Modified;

        }
        public void excluir(Solicitacao solicitacao)
        {

            var solicitacaoTemp = getSolicitacaoporID(solicitacao.id);
            _context.solicitacao.Remove(solicitacaoTemp);

        }
        public Solicitacao getSolicitacaoporID(int id)
        {
            Solicitacao solicitacao = null;

            solicitacao = _context.solicitacao.Include(s => s.area_comum).Include(s => s.usuario_solicitante).SingleOrDefault(s => s.id == id);

            return solicitacao;
        }

        public List<Solicitacao> getSolicitacoes()
        {
            List<Solicitacao> solicitacoes = new List<Solicitacao>();

            solicitacoes = _context.solicitacao.Include(s => s.area_comum).Include(s => s.usuario_solicitante).Include(s => s.usuario_visualizacao).ToList();

            return solicitacoes;
        }

        public List<Solicitacao> getSolicitacoes(bool somenteNaoVisualizada, TipoSolicitacao tipoSolicitacao)
        {
            var strTipo = ((int)tipoSolicitacao).ToString().Trim();
            List<Solicitacao> solicitacoes = new List<Solicitacao>();
            solicitacoes = _context.solicitacao.Include(s => s.area_comum).Include(s => s.usuario_solicitante).Include(s => s.usuario_visualizacao)
                .Where(s => ((s.data_visualizacao == null || s.data_visualizacao == DateTime.MinValue) && somenteNaoVisualizada) || !somenteNaoVisualizada)
                .Where(f => f.tipo == strTipo || tipoSolicitacao == TipoSolicitacao.Nenhum).ToList();
            return solicitacoes;
        }

        public int getQuantidadeSolicitacoesNVistas()
        {
            return _context.solicitacao.Where(s => s.data_visualizacao == null || s.data_visualizacao == DateTime.MinValue).Count();
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
