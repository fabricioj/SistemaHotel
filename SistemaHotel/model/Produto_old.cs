using SistemaHotel.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.model
{
    public class Produto_old
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Descrição")]
        public string descricao { get; set; }
        [Browsable(false)]
        public SimNao controla_estoque { get; set; }

        [DisplayName("Controla estoque")]
        public string dspcontrola_estoque { get { return EnumHelper.GetDescription(controla_estoque); } }
        [DisplayName("Qtd estoque")]
        public double quantidade { get; set; }
    }
}
