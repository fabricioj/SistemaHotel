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

    public enum EstadoCivil
    {
        [Description("0 - NENHUM")]
        Nenhum,

        [Description("1 - SOLTEIRO")]
        Solteiro,

        [Description("2 - CASADO")]
        Casado,

        [Description("3 - VIÚVO")]
        Viuvo,

        [Description("4 - DIVORCIADO")]
        Divorciado,

        [Description("5 - SEPARADO")]
        Separado
    }
}
