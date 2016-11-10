namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.dependentes")]
    public partial class Dependentes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dependentes()
        {
            visitante = new HashSet<Visitante>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string nome { get; set; }

        [StringLength(14)]
        public string rg { get; set; }

        [StringLength(15)]
        public string cpf { get; set; }

        public int? morador_id { get; set; }

        [StringLength(15)]
        public string celular { get; set; }

        [StringLength(15)]
        public string telefone_comercial { get; set; }

        [StringLength(100)]
        public string profissao { get; set; }

        [StringLength(100)]
        public string empresa { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public virtual Morador morador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitante> visitante { get; set; }
    }
}
