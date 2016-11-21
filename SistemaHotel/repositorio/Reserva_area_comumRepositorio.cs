using SistemaHotel.model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System;

namespace SistemaHotel.repositorio
{
    public class Reserva_area_comumRepositorio
    {
        private SistemaHotelContext _context;
        public Reserva_area_comumRepositorio(SistemaHotelContext context) {
            _context = context;
        }

        public void incluir(ref Reserva_area_comum reserva_area_comum)
        {
            _context.reserva_area_comum.Add(reserva_area_comum);
        }
        public void alterar(Reserva_area_comum reserva_area_comum)
        {
            _context.Entry(reserva_area_comum).State = System.Data.Entity.EntityState.Modified;
        }
        public void excluir(Reserva_area_comum reserva_area_comum)
        {
            _context.reserva_area_comum.Remove(reserva_area_comum);
        }

        public Reserva_area_comum getReserva_area_comumporID(int id)
        {
            Reserva_area_comum reserva_area_comum = null;
            reserva_area_comum = _context.reserva_area_comum.Find(id);
            return reserva_area_comum;
        }

        public List<Reserva_area_comum> getReservas_area_comum()
        {
            List<Reserva_area_comum> reservas_area_comum = new List<Reserva_area_comum>();
            reservas_area_comum = _context.reserva_area_comum
                .Include(r => r.solicitacao)
                .Include(r => r.solicitacao.area_comum)
           .ToList();
            return reservas_area_comum;
        }

        public List<Reserva_area_comum> getReservas_area_comum(bool somenteNDevolvida, string area_comum_nome)
        {
            List<Reserva_area_comum> reservas_area_comum = new List<Reserva_area_comum>();
            reservas_area_comum = _context.reserva_area_comum
                .Include(r => r.solicitacao)
                .Include(r => r.solicitacao.area_comum)
                .Where(r => (r.data_devolucao == null || r.data_devolucao == DateTime.MinValue && somenteNDevolvida) || !somenteNDevolvida)
                .Where(r => r.solicitacao.area_comum.nome.Contains(area_comum_nome))
            .ToList();
            return reservas_area_comum;
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
