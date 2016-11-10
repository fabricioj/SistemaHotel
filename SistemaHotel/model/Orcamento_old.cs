using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.model
{
    public class Orcamento_old
    {
        [DisplayName("ID")]
        public int id { get; set; }

        //public Atividade atividade { get; set; }

        [Browsable(false)]
        
        public int fornecedor_id { get; set; }

        [Browsable(false)]
        public virtual Fornecedor_old fornecedor { get; set; }

        [DisplayName("Fornecedor")]
        public string Fornecedor_nome { get { return fornecedor == null ? String.Empty : fornecedor.nome; } }

        [DisplayName("Dt emissão")]
        public DateTime data_emissao{ get; set; }

        [DisplayName("Dt confirmação")]
        public DateTime data_confirmacao { get; set; }
    }
}
