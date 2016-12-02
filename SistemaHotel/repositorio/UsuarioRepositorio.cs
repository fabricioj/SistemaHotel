using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaHotel.repositorio
{
    public class UsuarioRepositorio
    {
        private SistemaHotelContext _context;
        public UsuarioRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        
       
        public void incluir(Usuario usuario)
        {
            _context.usuario.Add(usuario);
        }

        public void alterar(Usuario usuario)
        {
            _context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
        }

        public void excluir(Usuario usuario)
        {
            var usuarioTemp = getUsuarioporID(usuario.id);
            _context.usuario.Remove(usuarioTemp);
        }

        public Usuario getUsuarioporID(int id)
        {
            Usuario usuario = null;

            usuario = _context.usuario.Find(id);

            return usuario;
        }
        public List<Usuario> getUsuarios()
        {
            List<Usuario> usuario = new List<Usuario>();
            usuario = _context.usuario.Include(u => u.perfil).Include(u => u.morador).ToList();
            return usuario;
        }
        
        public List<Usuario> getUsuarios(string nome)
        {
            List<Usuario> usuario = new List<Usuario>();

            usuario = _context.usuario.Include(u => u.perfil).Include(u => u.morador).Where(u => u.nome.Contains(nome)).ToList();

            return usuario;
        }
        public Usuario getUsuarioEmail(string email)
        {
            return _context.usuario.Where(u => u.email.Equals(email)).FirstOrDefault();
        }

        public Usuario getUsuarioEmailSenha(string email, string senha) {
            return _context.usuario.Include(u => u.perfil).Include(u => u.morador).Where(u => u.email.Equals(email) && u.senha.Equals(senha)).FirstOrDefault();
        }
        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
