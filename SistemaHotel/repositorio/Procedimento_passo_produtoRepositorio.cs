using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class Procedimento_passo_produtoRepositorio
    {
        private SistemaHotelContext _context;

        public Procedimento_passo_produtoRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(ref Procedimento_passo_produto procedimento_passo_produto)
        {
            _context.procedimento_passo_produto.Add(procedimento_passo_produto);
        }
        public void alterar(Procedimento_passo_produto procedimento_passo_produto)
        {
            _context.Entry(procedimento_passo_produto).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Procedimento_passo_produto procedimento_passo_produto)
        {
            _context.procedimento_passo_produto.Remove(procedimento_passo_produto);
        }
        public void excluir(int procedimento_passo_id)
        {
            _context.procedimento_passo_produto.RemoveRange(_context.procedimento_passo_produto.Where(p => p.procedimento_passo_id == procedimento_passo_id));
        }

        public Procedimento_passo_produto getProcedimento_passo_produtoporID(int id)
        {
            return _context.procedimento_passo_produto.Find(id);
        }

        public List<Procedimento_passo_produto> getProcedimento_passo_produtos(int procedimento_passo_id)
        {
            List<Procedimento_passo_produto> procedimento_passo_produtos = new List<Procedimento_passo_produto>();
            procedimento_passo_produtos = _context.procedimento_passo_produto.Include(p => p.produto).Where(p => p.procedimento_passo_id == procedimento_passo_id).ToList();
            return procedimento_passo_produtos;
        }

        public void salvar() {
            _context.SaveChanges();
        }
    }
}
