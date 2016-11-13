namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.fornecedor")]
    public partial class Fornecedor: Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedor()
        {
            orcamento = new HashSet<Orcamento>();
        }

        [DisplayName("Razão social")]
        [StringLength(50)]
        public string razao_social { get; set; }

        [Browsable(false)]
        [StringLength(25)]
        public string cnpj { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento> orcamento { get; set; }
    }
}
