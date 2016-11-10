namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.vaga")]
    public partial class Vaga
    {
        public int id { get; set; }

        public int? apartamento_id { get; set; }

        public int? numero_vaga { get; set; }

        public int? morador_ocupante_id { get; set; }

        public virtual Apartamento apartamento { get; set; }

        public virtual Morador morador { get; set; }
    }
}
