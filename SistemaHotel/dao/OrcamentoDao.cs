using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.dao
{
    public class OrcamentoDao
    {
        public void incluir(ref Orcamento_old orcamento)
        {
            orcamento.id = 1;
            //throw new Exception("Erro ao inserir");
        }
        public void alterar(Orcamento_old orcamento)
        {
        }
        public void excluir(Orcamento_old orcamento)
        {
        }
        public Orcamento_old getOrcamentoporID(int id)
        {
            return new Orcamento_old();
        }

        public List<Orcamento_old> getOrcamentos()
        {
            return new List<Orcamento_old>();
        }
    }
}
