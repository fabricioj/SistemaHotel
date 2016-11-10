namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.moradia")]
    public partial class Moradia
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_ini_contrato { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vigencia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_final { get; set; }

        [StringLength(245)]
        public string caminho_documento { get; set; }

        public int? morador_id { get; set; }

        public int? apartamento_id { get; set; }

        [StringLength(2)]
        public string tipo_contrato { get; set; }

        public virtual Apartamento apartamento { get; set; }

        public virtual Morador morador { get; set; }
    }
}
