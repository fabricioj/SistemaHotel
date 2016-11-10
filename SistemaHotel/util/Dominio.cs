using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.util
{
    public enum Operacao {
        Insercao,
        Alteracao,
        Exclusao,
        Consulta
    }

    public enum SimNao {
        [Description("SIM")]
        SIM,
        [Description("NÃO")]
        NAO
    }
}
