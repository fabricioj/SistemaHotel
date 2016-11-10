namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.ocorrencia")]
    public partial class Ocorrencia
    {
        public int id { get; set; }

        [StringLength(245)]
        public string observacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data { get; set; }

        public int morador_id { get; set; }

        public virtual Morador morador { get; set; }
    }
}
