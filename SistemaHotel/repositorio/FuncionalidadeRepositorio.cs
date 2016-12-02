using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaHotel.repositorio
{
    class FuncionalidadeRepositorio
    {
        private SistemaHotelContext _context;
        public FuncionalidadeRepositorio()
        {
            _context = new SistemaHotelContext();
        }

        public FuncionalidadeRepositorio(SistemaHotelContext _context)
        {
            // TODO: Complete member initialization
            this._context = _context;
        }
        public void incluir(Funcionalidade funcionalidade)
        {
            _context.funcionalidade.Add(funcionalidade);
        }

        public void alterar(Funcionalidade funcionalidade)
        {
            _context.Entry(funcionalidade).State = System.Data.Entity.EntityState.Modified;
        }

        public void excluir(Funcionalidade funcionalidade)
        {
            var funcionaldidadeTemp = getFuncionalidadeporID(funcionalidade.id);

            _context.funcionalidade.Remove(funcionaldidadeTemp);


        }
        public Funcionalidade getFuncionalidadeporID(int id)
        {
            Funcionalidade funcionalidade = null;
            funcionalidade = _context.funcionalidade.Find(id);
            return funcionalidade;
        }

        public Funcionalidade getFuncionalidadeporNome_tela(string nome_tela)
        {
            return _context.funcionalidade.Where(f => f.nome_tela == nome_tela).FirstOrDefault();
        }

        public List<Funcionalidade> getFuncionalidades()
        {
            List<Funcionalidade> funcionalidades = new List<Funcionalidade>();
            funcionalidades = _context.funcionalidade.ToList();
            return funcionalidades;            
        }
        public List<Funcionalidade> getFuncionalidades(String nome)
        {
            List<Funcionalidade> funcionalidades = new List<Funcionalidade>();
            funcionalidades = _context.funcionalidade.Where(f => nome.Contains(nome)).ToList();
            return funcionalidades;
        }
        public void salvar() {
            _context.SaveChanges();
        }

    }
}
