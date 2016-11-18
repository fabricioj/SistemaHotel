namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.atividade")]
    public partial class Atividade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Atividade()
        {
            orcamento = new HashSet<Orcamento>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_confirmacao { get; set; }

        public int? solicitacao_id { get; set; }

        public int? procedimento_id { get; set; }

        public int? funcionario_id { get; set; }

        public virtual Funcionario funcionario { get; set; }

        public virtual Procedimento procedimento { get; set; }

        public virtual Solicitacao solicitacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento> orcamento { get; set; }
    }
}
