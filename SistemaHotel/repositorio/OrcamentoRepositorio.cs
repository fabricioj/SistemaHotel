using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class OrcamentoRepositorio
    {
        private SistemaHotelContext _context;

        public OrcamentoRepositorio() {
            _context = new SistemaHotelContext();
        }

        public void incluir(Orcamento orcamento)
        {

            _context.orcamento.Add(orcamento);
            _context.SaveChanges();

        }
        public void alterar(Orcamento orcamento)
        {
            _context.Entry(orcamento).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();

        }
        public void excluir(Orcamento orcamento)
        {

            var orcamentoTemp = getOrcamentoporID(orcamento.id);
            _context.orcamento.Remove(orcamentoTemp);
            _context.SaveChanges();

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

            orcamentoes = _context.orcamento.Include(o => o.).ToList();

            return orcamentoes;
        }

        public List<Orcamento> getOrcamentos(string nome)
        {
            List<Orcamento> orcamentoes = new List<Orcamento>();
            orcamentoes = _context.orcamento.Where(o => o.nome.Contains(nome)).ToList();
            return orcamentoes;
        }
    }
}
