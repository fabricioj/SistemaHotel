using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotel.util;

namespace SistemaHotel.model
{
    public class Permissao_old
    {
        public SimNao consultar { get; set; }

        public SimNao inserir { get; set; }

        public SimNao alterar { get; set; }

        public SimNao excluir { get; set; }

        public SimNao supervisor { get; set; }
    }
}
