namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            permissao = new HashSet<Permissao>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(15)]
        public string cpf { get; set; }

        [StringLength(15)]
        public string telefone { get; set; }

        [StringLength(15)]
        public string celular { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(8)]
        public string senha { get; set; }

        [StringLength(50)]
        public string cidade { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        public int? perfil_id { get; set; }

        public int? morador_id { get; set; }

        public virtual Morador morador { get; set; }

        public virtual Perfil perfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permissao> permissao { get; set; }
    }
}
