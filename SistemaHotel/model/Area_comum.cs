namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.area_comum")]
    public partial class Area_comum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area_comum()
        {
            solicitacao = new HashSet<Solicitacao>();
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [StringLength(50)]
        public string nome { get; set; }

        [DisplayName("Dt cadastro")]
        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Browsable(false)]
        [StringLength(245)]
        public string observacao { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitacao> solicitacao { get; set; }
    }
}
