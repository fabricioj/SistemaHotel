using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.model
{
    public class Orcamento_item_old
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Orçamento")]
        public int orcamento_id { get; set; }

        public Orcamento_old orcamento { get; set; }

        [DisplayName("Produto")]
        public int produto_id { get; set; }

        public Produto_old produto { get; set; }

        [DisplayName("Quantidade")]
        public Double quantidade { get; set; }

        [DisplayName("Valor")]
        public Double valor { get; set; }

        [DisplayName("Observação")]
        public String observacao { get; set; }

        [DisplayName("Qtd comprada")]
        public Double quantidade_comprada { get; set; }
    }
}
