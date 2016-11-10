namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.orcamento")]
    public partial class Orcamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orcamento()
        {
            orcamento_item = new HashSet<Orcamento_item>();
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Emissão")]
        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_confirmacao { get; set; }

        [Browsable(false)]
        public int? atividade_id { get; set; }

        [Browsable(false)]
        public int? fornecedor_id { get; set; }

        [Browsable(false)]
        public virtual Atividade atividade { get; set; }

        [DisplayName("Atividade")]
        public string atividade_nome {get { return atividade != null ? atividade.nome : string.Empty; } }

        [Browsable(false)]
        public virtual Fornecedor fornecedor { get; set; }

        [DisplayName("Fornecedor")]
        public string fornecedor_nome { get { return fornecedor != null ? fornecedor.nome : string.Empty; } }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento_item> orcamento_item { get; set; }
    }
}
