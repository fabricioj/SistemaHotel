namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.solicitacao")]
    public partial class Solicitacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitacao()
        {
            atividade = new HashSet<Atividade>();
            reserva_area_comum = new HashSet<Reserva_area_comum>();
        }

        public int id { get; set; }

        [StringLength(245)]
        public string servico { get; set; }

        [StringLength(245)]
        public string local { get; set; }

        [StringLength(245)]
        public string observacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fim { get; set; }

        public TimeSpan? hora_inicio { get; set; }

        public TimeSpan? hora_fim { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_visualizacao { get; set; }

        [StringLength(254)]
        public string observacao_visualizacao { get; set; }

        [StringLength(2)]
        public string resultado_visualizacao { get; set; }

        public int? area_comum_id { get; set; }

        public virtual Area_comum area_comum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atividade> atividade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva_area_comum> reserva_area_comum { get; set; }
    }
}
