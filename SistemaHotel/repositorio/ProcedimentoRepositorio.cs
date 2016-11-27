using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class ProcedimentoRepositorio
    {
        private SistemaHotelContext _context;

        public ProcedimentoRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(ref Procedimento procedimento)
        {
            _context.procedimento.Add(procedimento);
        }
        public void alterar(Procedimento procedimento)
        {
            _context.Entry(procedimento).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Procedimento procedimento)
        {
            (new Procedimento_passoRepositorio(_context)).excluir(procedimento.id);
            _context.procedimento.Remove(procedimento);
        }

        public Procedimento getProcedimentoporID(int id)
        {
            return _context.procedimento.Find(id);
        }

        public List<Procedimento> getProcedimentos()
        {
            List<Procedimento> procedimentos = new List<Procedimento>();
            procedimentos = _context.procedimento.ToList();
            return procedimentos;
        }

        public List<Procedimento> getProcedimentos(string descricao)
        {
            List<Procedimento> procedimentos = new List<Procedimento>();
            procedimentos = _context.procedimento.Where(p => p.descricao.Contains(descricao)).ToList();
            return procedimentos;
        }

        public void salvar() {
            _context.SaveChanges();
        }
    }
}
