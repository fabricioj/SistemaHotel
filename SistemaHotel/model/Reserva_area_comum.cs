namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.reserva_area_comum")]
    public partial class Reserva_area_comum
    {
        public int id { get; set; }

        [StringLength(100)]
        public string observacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_devolucao { get; set; }

        public int? solicitacao_id { get; set; }

        public virtual Solicitacao solicitacao { get; set; }
    }
}
