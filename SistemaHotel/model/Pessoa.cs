using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.model
{
    public abstract class Pessoa
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Telefone")]
        public string telefone { get; set; }

        [Browsable(false)]
        public string endereco { get; set; }

        [Browsable(false)]
        public string numero { get; set; }

        [Browsable(false)]
        public string bairro { get; set; }

        [Browsable(false)]
        public string cep { get; set; }

        [DisplayName("Cidade")]
        public string cidade { get; set; }

        [DisplayName("Estado")]
        public string estado { get; set; }

        [DisplayName("Email")]
        public string email { get; set; }

    }
}
