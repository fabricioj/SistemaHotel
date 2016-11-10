using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.dao
{
    public class Orcamento_itemDao
    {
        public void incluir(ref Orcamento_item_old orcamento_item)
        {
            throw new Exception("Erro ao inserir");
        }
        public void alterar(Orcamento_item_old orcamento_item)
        {
        }
        public void excluir(Orcamento_item_old orcamento_item)
        {
        }
        public Orcamento_item_old getOrcamento_itemporID(int id)
        {
            return new Orcamento_item_old();
        }

        public List<Orcamento_item_old> getOrcamento_itens(int OrcamentoID)
        {
            return new List<Orcamento_item_old>();
        }
    }
}
