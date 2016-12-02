using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SistemaHotel.repositorio
{
    public class MoradorRepositorio
    {
        private SistemaHotelContext _context;

        public MoradorRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }

        public void incluir(Morador morador)
        {
            _context.morador.Add(morador);
        }

        public void alterar(Morador morador)
        {
            _context.Entry(morador).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Morador morador)
        {
            var moradorTemp = getMoradorporID(morador.id);
            _context.morador.Remove(moradorTemp);
        }

        public Morador getMoradorporID(int id)
        {
        Morador morador =  null;

        morador  = _context.morador.Find(id);
            
        return morador ;
        }

        public List<Morador> getMoradores()
        {
            List<Morador> moradores = new List<Morador>();
            moradores = _context.morador.ToList();

            return moradores;
        
        }

        public List<Morador> getMoradores(String nome)
        {
            List<Morador> moradores = new List<Morador>();
            moradores = _context.morador.Where( m => m.nome.Contains(nome)).ToList();

            return moradores;        
        }

        public void salvar() { 
        _context.SaveChanges();
        }
    }
}
