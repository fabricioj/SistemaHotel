using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.dao
{
    class FuncionalidadeDao
    {
        public void incluir(Funcionalidade funcionalidade)
        {
            throw new Exception("Erro ao inserir");
        }
        public void alterar(Funcionalidade funcionalidade)
        { 
        
        }
        public void excluir(Funcionalidade funcionalidade)
        { 
        
        }
        public Funcionalidade getFuncionalidadeporID(int id)
        {
            return new Funcionalidade();
        }
        public List<Funcionalidade> getFuncionalidade() {
            return new List<Funcionalidade>();
        }

    }
}
