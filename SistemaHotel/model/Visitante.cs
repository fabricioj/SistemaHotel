namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.visitante")]
    public partial class Visitante
    {
        public int id { get; set; }

        public int? apartamento_id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(15)]
        public string rg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_chegada { get; set; }

        public TimeSpan? hora_chegada { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_saida { get; set; }

        public TimeSpan? hora_saida { get; set; }

        public int? morador_id { get; set; }

        public int? dependentes_id { get; set; }

        public virtual Apartamento apartamento { get; set; }

        public virtual Dependente dependentes { get; set; }

        public virtual Morador morador { get; set; }
    }
}
