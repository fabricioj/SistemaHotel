namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição do passo")]
        [StringLength(245)]
        public string descricao_passo { get; set; }

        [DisplayName("Ordem de execução")]
        public int? ordem_execucao { get; set; }

        [Browsable(false)]
        public int? procedimento_id { get; set; }

        [Browsable(false)]
        public virtual Procedimento procedimento { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimento_passo_produto> procedimento_passo_produto { get; set; }
    }
}
