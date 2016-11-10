namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.procedimento_passo")]
    public partial class Procedimento_passo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procedimento_passo()
        {
            procedimento_passo_produto = new HashSet<Procedimento_passo_produto>();
        }

        public int id { get; set; }

        [StringLength(245)]
        public string descricao_passo { get; set; }

        public int? ordem_execucao { get; set; }

        public int? procedimento_id { get; set; }

        public virtual Procedimento procedimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimento_passo_produto> procedimento_passo_produto { get; set; }
    }
}
