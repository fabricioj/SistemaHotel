using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class FornecedorRepositorio
    {
        private SistemaHotelContext _context;
        public FornecedorRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(Fornecedor fornecedor)
        {

            _context.fornecedor.Add(fornecedor);

        }
        public void alterar(Fornecedor fornecedor)
        {
            _context.Entry(fornecedor).State = System.Data.Entity.EntityState.Modified;
            
        }
        public void excluir(Fornecedor fornecedor)
        {

            var fornecedorTemp = getFornecedorporID(fornecedor.id);
            _context.fornecedor.Remove(fornecedorTemp);

        }
        public Fornecedor getFornecedorporID(int id)
        {
            Fornecedor fornecedor = null;

            fornecedor = _context.fornecedor.Find(id);

            return fornecedor;
        }

        public List<Fornecedor> getFornecedores()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();

            fornecedores = _context.fornecedor.ToList();

            return fornecedores;
        }

        public List<Fornecedor> getFornecedores(string nome)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            fornecedores = _context.fornecedor.Where(f => f.nome.Contains(nome)).ToList();
            return fornecedores;
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
