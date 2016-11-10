using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.model
{
    public class Fornecedor_old : Pessoa
    {
        [Browsable(false)]
        public string razao_social { get; set; }

        [Browsable(false)]
        public string cnpj { get; set; }
    }
}
