namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.orcamento_item")]
    public partial class Orcamento_item
    {
        public int id { get; set; }

        public double? quantidade { get; set; }

        public int? orcamento_id { get; set; }

        public int? produto_id { get; set; }

        public double? quantidade_comprada { get; set; }

        public double? valor { get; set; }

        [StringLength(254)]
        public string observacao { get; set; }

        public virtual Orcamento orcamento { get; set; }

        public virtual Produto produto { get; set; }
    }
}
