using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class Procedimento_passoRepositorio
    {
        private SistemaHotelContext _context;

        public Procedimento_passoRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(ref Procedimento_passo procedimento_passo)
        {
            _context.procedimento_passo.Add(procedimento_passo);
        }
        public void alterar(Procedimento_passo procedimento_passo)
        {
            _context.Entry(procedimento_passo).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Procedimento_passo procedimento_passo)
        {
            (new Procedimento_passo_produtoRepositorio(_context)).excluir(procedimento_passo.id);
            _context.procedimento_passo.Remove(procedimento_passo);
        }

        public void excluir(int procedimento_id)
        {
            getProcedimento_passos(procedimento_id).ForEach(p => {
                (new Procedimento_passo_produtoRepositorio(_context)).excluir(p.id);
                excluir(p);
            });
        }

        public Procedimento_passo getProcedimento_passoporID(int id)
        {
            return _context.procedimento_passo.Find(id);
        }

        public List<Procedimento_passo> getProcedimento_passos(int procedimento_id)
        {
            List<Procedimento_passo> procedimento_passos = new List<Procedimento_passo>();
            procedimento_passos = _context.procedimento_passo.Where(p => p.procedimento_id == procedimento_id).ToList();
            return procedimento_passos;
        }

        public List<Procedimento_passo> getProcedimento_passos(string descricao)
        {
            List<Procedimento_passo> procedimento_passos = new List<Procedimento_passo>();
            procedimento_passos = _context.procedimento_passo.Where(p => p.descricao_passo.Contains(descricao)).ToList();
            return procedimento_passos;
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}