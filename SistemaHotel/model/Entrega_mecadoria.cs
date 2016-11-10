namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.entrega_mecadoria")]
    public partial class Entrega_mecadoria
    {
        public int id { get; set; }

        [StringLength(45)]
        public string nf { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_receb { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_entreg_destin { get; set; }

        public int morador_id { get; set; }

        public virtual Morador morador { get; set; }
    }
}
