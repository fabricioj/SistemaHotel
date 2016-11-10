using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel.util
{
    public class BancoDados
    {
        public static MySqlConnection conectar()
        {
            return new MySqlConnection("Server=localhost;Port=3307;Database=SistemaHoteldb;Uid=root;Pwd=usbw;ConvertZeroDateTime = True;");
        }

    }
}
