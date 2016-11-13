using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.model
{
    public abstract class Pessoa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [StringLength(50)]
        public string nome { get; set; }


        [DisplayName("Telefone")]
        [StringLength(15)]
        public string telefone { get; set; }

        [Browsable(false)]
        [StringLength(50)]
        public string endereco { get; set; }

        [Browsable(false)]
        [StringLength(10)]
        public string numero { get; set; }

        [Browsable(false)]
        [StringLength(30)]
        public string bairro { get; set; }

        [Browsable(false)]
        [StringLength(15)]
        public string cep { get; set; }

        [DisplayName("Cidade")]
        [StringLength(50)]
        public string cidade { get; set; }

        [DisplayName("Estado")]
        [StringLength(2)]
        public string estado { get; set; }

        [Browsable(false)]
        [StringLength(100)]
        public string email { get; set; }

    }
}
