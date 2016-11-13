namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.prestador")]
    public partial class Prestador: Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestador()
        {
            prestacao = new HashSet<Prestacao>();
        }

        [StringLength(50)]
        public string razao_social { get; set; }

        [StringLength(25)]
        public string cnpj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prestacao> prestacao { get; set; }
    }
}
