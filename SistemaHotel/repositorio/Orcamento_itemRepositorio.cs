using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class Orcamento_itemRepositorio
    {
        private SistemaHotelContext _context;

        public Orcamento_itemRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }

        public void incluir(ref Orcamento_item orcamento_item)
        {
            _context.orcamento_item.Add(orcamento_item);
        }
        public void alterar(Orcamento_item orcamento_item)
        {
            _context.Entry(orcamento_item).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Orcamento_item orcamento_item)
        {
            var orcamento_ItemTemp = getOrcamento_itemporID(orcamento_item.id);
            _context.orcamento_item.Remove(orcamento_ItemTemp);
        }
        public Orcamento_item getOrcamento_itemporID(int id)
        {
            return _context.orcamento_item.Find(id);
        }

        public List<Orcamento_item> getOrcamento_itens(int Orcamento_ID)
        {
            List<Orcamento_item> lista = new List<Orcamento_item>();
            lista = _context.orcamento_item.Where(i => i.orcamento_id == Orcamento_ID).ToList();
            return lista;
        }
        public void salvar()
        {
            _context.SaveChanges();
        }

    }
}
