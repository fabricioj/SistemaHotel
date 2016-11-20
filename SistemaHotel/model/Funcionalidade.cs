namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.funcionalidade")]
    public partial class Funcionalidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionalidade()
        {
            permissao = new HashSet<Permissao>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string nome_funcionalidade { get; set; }

        [StringLength(45)]
        public string nome_tela { get; set; }

        [Browsable(false)]
        [StringLength(1)]
        public string tipo { get; set; }

        [NotMapped]
        [Browsable(false)]
        public TipoFuncionalidade editTipo { get { return (TipoFuncionalidade)(int.Parse(tipo)); } set { tipo = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Tipo")]
        public string dspEspecial { get { return EnumHelper.GetDescription(editTipo); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permissao> permissao { get; set; }
    }
}
