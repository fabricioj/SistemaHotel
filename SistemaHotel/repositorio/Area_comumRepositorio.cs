using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class Area_comumRepositorio
    {
        private SistemaHotelContext _context;
        public Area_comumRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }

        public void incluir(Area_comum area_comum)
        {

            _context.area_comum.Add(area_comum);

        }
        public void alterar(Area_comum area_comum)
        {
            _context.Entry(area_comum).State = System.Data.Entity.EntityState.Modified;

        }
        public void excluir(Area_comum area_comum)
        {

            var area_comumTemp = getArea_comumporID(area_comum.id);
            _context.area_comum.Remove(area_comumTemp);

        }
        public Area_comum getArea_comumporID(int id)
        {
            Area_comum area_comum = null;

            area_comum = _context.area_comum.Find(id);

            return area_comum;
        }

        public List<Area_comum> getArea_comuns()
        {
            List<Area_comum> area_comuns = new List<Area_comum>();

            area_comuns = _context.area_comum.ToList();

            return area_comuns;
        }

        public List<Area_comum> getArea_comuns(string nome)
        {
            List<Area_comum> area_comuns = new List<Area_comum>();
            area_comuns = _context.area_comum.Where(a => a.nome.Contains(nome)).ToList();
            return area_comuns;
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
