using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class ProdutoRepositorio
    {
        private SistemaHotelContext _context;

        public ProdutoRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(ref Produto produto)
        {
            _context.produto.Add(produto);
        }
        public void alterar(Produto produto)
        {
            _context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Produto produto)
        {
            _context.produto.Remove(produto);
        }

        public Produto getProdutoporID(int id)
        {
            Produto produto = null;
            produto = _context.produto.Find(id);
            return produto;
        }

        public List<Produto> getProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            produtos = _context.produto.ToList();
            return produtos;
        }

        public List<Produto> getProdutos(string descricao)
        {
            List<Produto> produtos = new List<Produto>();
            produtos = _context.produto.Where(p => p.descricao.Contains(descricao)).ToList();
            return produtos;
        }

        public void salvar() {
            _context.SaveChanges();
        }
    }
}
