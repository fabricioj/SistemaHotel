using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class AtividadeRepositorio
    {
        private SistemaHotelContext _context;

        public AtividadeRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(ref Atividade atividade)
        {
            _context.atividade.Add(atividade);
        }
        public void alterar(Atividade atividade)
        {
            _context.Entry(atividade).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Atividade atividade)
        {
            _context.atividade.Remove(atividade);
        }

        public Atividade getAtividadeporID(int id)
        {
            Atividade atividade = null;
            atividade = _context.atividade.Find(id);
            return atividade;
        }

        public List<Atividade> getAtividades()
        {
            List<Atividade> atividades = new List<Atividade>();
            atividades = _context.atividade.ToList();
            return atividades;
        }

        public List<Atividade> getAtividades(string nome)
        {
            List<Atividade> atividades = new List<Atividade>();
            atividades = _context.atividade.Where(p => p.nome.Contains(nome)).ToList();
            return atividades;
        }

        public void salvar() {
            _context.SaveChanges();
        }
    }
}
