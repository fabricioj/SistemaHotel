using SistemaHotel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.repositorio
{
    public class FuncionarioRepositorio
    {
        private SistemaHotelContext _context;
        public FuncionarioRepositorio(SistemaHotelContext context)
        {
            _context = context;
        }
        public void incluir(Funcionario funcionario)
        {

            _context.funcionario.Add(funcionario);

        }
        public void alterar(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = System.Data.Entity.EntityState.Modified;

        }
        public void excluir(Funcionario funcionario)
        {

            var funcionarioTemp = getFuncionarioporID(funcionario.id);
            _context.funcionario.Remove(funcionarioTemp);

        }
        public Funcionario getFuncionarioporID(int id)
        {
            Funcionario funcionario = null;

            funcionario = _context.funcionario.Find(id);

            return funcionario;
        }

        public List<Funcionario> getFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios = _context.funcionario.ToList();

            return funcionarios;
        }

        public List<Funcionario> getFuncionarios(string nome)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            funcionarios = _context.funcionario.Where(f => f.nome.Contains(nome)).ToList();
            return funcionarios;
        }

        public void salvar()
        {
            _context.SaveChanges();
        }
    }
}
