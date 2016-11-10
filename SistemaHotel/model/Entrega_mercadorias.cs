namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.entrega_mercadorias")]
    public partial class Entrega_mercadorias
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_recebimento { get; set; }

        public int? produto_id { get; set; }

        public int? morador_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_entrega { get; set; }

        public TimeSpan? hora_entrega { get; set; }

        [StringLength(254)]
        public string recibo_entrega { get; set; }

        [StringLength(254)]
        public string observacao_entrega { get; set; }

        public virtual Morador morador { get; set; }

        public virtual Produto produto { get; set; }
    }
}
