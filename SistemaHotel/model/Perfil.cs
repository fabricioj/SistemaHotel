namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.perfil")]
    public partial class Perfil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Perfil()
        {
            permissao = new HashSet<Permissao>();
            usuario = new HashSet<Usuario>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string nome { get; set; }

        [StringLength(1)]
        public string supervisor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permissao> permissao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> usuario { get; set; }

        [NotMapped]
        public SimNao editSupervisor { get { return (SimNao)(int.Parse(supervisor)); } set { supervisor = ((int)value).ToString().Trim(); } }
        }
}
