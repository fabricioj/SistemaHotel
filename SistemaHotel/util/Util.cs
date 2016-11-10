using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.util
{
    public class Util
    {
        public static void acertaTabOrder(System.Windows.Forms.Control control) {
            (new SMcMaster.TabOrderManager(control)).SetTabOrder(SMcMaster.TabOrderManager.TabScheme.AcrossFirst);
        }

    }
}
