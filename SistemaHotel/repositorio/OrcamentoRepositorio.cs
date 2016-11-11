using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class OrcamentoRepositorio
    {
        private SistemaHotelContext _context;

        public OrcamentoRepositorio(SistemaHotelContext context) {
            _context = context;
        }

        public void incluir(ref Orcamento orcamento)
        {
            _context.orcamento.Add(orcamento);            

        }
        public void alterar(Orcamento orcamento)
        {
            _context.Entry(orcamento).State = System.Data.Entity.EntityState.Modified;

        }
        public void excluir(Orcamento orcamento)
        {

            var orcamentoTemp = getOrcamentoporID(orcamento.id);
            _context.orcamento.Remove(orcamentoTemp);

        }
        public Orcamento getOrcamentoporID(int id)
        {
            Orcamento orcamento = null;

            orcamento = _context.orcamento.Find(id);

            return orcamento;
        }

        public List<Orcamento> getOrcamentos()
        {
            List<Orcamento> orcamentoes = new List<Orcamento>();

            orcamentoes = _context.orcamento.Include(o => o.fornecedor).Include(o => o.atividade).ToList();

            return orcamentoes;
        }

        public List<Orcamento> getOrcamentos(string fornecedor_nome, string atividade_nome)
        {
            List<Orcamento> orcamentoes = new List<Orcamento>();
            orcamentoes = _context.orcamento.Include(o => o.fornecedor).Include(o => o.atividade)
                                            .Where(o => o.fornecedor.nome.Contains(fornecedor_nome) || string.IsNullOrEmpty(fornecedor_nome))
                                            .Where(o => o.atividade.nome.Contains(atividade_nome) || string.IsNullOrEmpty(atividade_nome)).ToList();
            return orcamentoes;
        }
        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
