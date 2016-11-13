using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class PermissaoRepositorio
    {
        private SistemaHotelContext _context;
        public PermissaoRepositorio(SistemaHotelContext context) {
            _context = context;
        }

        public void incluir(Permissao permissao)
        {
        }
        public void alterar(Permissao permissao)
        {
        }
        public void excluir(Permissao permissao)
        {
        }
        public Permissao getPermissaoporID(int id)
        {
            return new Permissao();
        }

        public List<Permissao> getPermissoes()
        {
            return new List<Permissao>();
        }

        public static Permissao getPermissaoFuncionalidadeNome(SistemaHotelContext context, string nome)
        {
            return new Permissao { editSupervisor = util.SimNao.SIM };
        }
    }
}
