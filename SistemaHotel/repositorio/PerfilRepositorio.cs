using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class PerfilRepositorio
    {
        private SistemaHotelContext _context;
        public PerfilRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir (Perfil perfil)
        {
            _context.perfil.Add(perfil);
        }

        public void alterar(Perfil perfil)
        {
            _context.Entry(perfil).State = System.Data.Entity.EntityState.Modified;
        }

        public void excluir (Perfil perfil)
        {
            var perfilTemp = getPerfilporID(perfil.id);
            _context.perfil.Remove(perfilTemp);

        }

        public Perfil getPerfilporID(int id)
        {
            Perfil perfil = null;
            perfil = _context.perfil.Find(id);
            return perfil;
        }

        public List<Perfil> getPerfis()
        {
            List<Perfil> perfis = new List<Perfil>();
            perfis = _context.perfil.ToList();//
            return perfis;
        }

        public List<Perfil> getPerfis(String nome)
        {
            List<Perfil> perfis = new List<Perfil>();
            perfis = _context.perfil.Where(p => p.nome.Contains(nome)).ToList();
            return perfis;
        }
        public void salvar()
        {
            _context.SaveChanges();
        }

    }
}
