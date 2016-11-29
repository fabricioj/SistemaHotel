using SistemaHotel.model;
using SistemaHotel.util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            _context.permissao.Add(permissao);
        }
        public void alterar(Permissao permissao)
        {
            _context.Entry<Permissao>(permissao).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Permissao permissao)
        {
            var permissaoTemp = _context.permissao.Find(permissao.id);
            _context.permissao.Remove(permissaoTemp);
        }
        public Permissao getPermissaoporID(int id)
        {
            Permissao permissao = null;
            permissao = _context.permissao.Find(id);
            return permissao;
        }

        public List<Permissao> getPermissoes()
        {
            return _context.permissao.Include(p => p.funcionalidade).Include(p => p.perfil).Include(p => p.usuario).ToList();
        }

        public void salvar() {
            _context.SaveChanges();
        }

        public static Permissao getPermissaoFuncionalidadeNome(SistemaHotelContext context, Usuario usuarioLogado, string nome)
        {
            Permissao permissao = context.permissao.Include(p => p.funcionalidade).Include(p => p.perfil).Include(p => p.usuario).Where(p => p.funcionalidade.nome_funcionalidade == nome).Where(p => p.usuario_id == usuarioLogado.id || p.perfil_id == usuarioLogado.perfil_id).OrderBy(p => p.perfil_id).FirstOrDefault();
            if (usuarioLogado.perfil.editSupervisor == SimNao.SIM) {
                permissao.editSupervisor = SimNao.SIM;
            }
            return permissao;
        }
    }
}
