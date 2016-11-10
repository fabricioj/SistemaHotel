namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.prestacao")]
    public partial class Prestacao
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_prestacao { get; set; }

        [StringLength(245)]
        public string observacao { get; set; }

        public int? prestador_id { get; set; }

        public int? apartamento_id { get; set; }

        public virtual Apartamento apartamento { get; set; }

        public virtual Prestador prestador { get; set; }
    }
}
