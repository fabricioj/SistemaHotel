using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.dao
{
    class PermissaoDao
    {
        public void incluir(Permissao_old permissao)
        {
        }
        public void alterar(Permissao_old permissao)
        {
        }
        public void excluir(Permissao_old permissao)
        {
        }
        public Permissao_old getPermissaoporID(int id)
        {
            return new Permissao_old();
        }

        public List<Permissao_old> getPermissaoes()
        {
            return new List<Permissao_old>();
        }

        public static Permissao_old getPermissaoFuncionalidadeNome(string nome) {
            return new Permissao_old();
        }
    }
}
