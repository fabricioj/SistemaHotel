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
        public int? fornecedor_id { get; set; }

        [NotMapped]
        [DisplayName("ID fornecedor")]
        public int edtFornecedor_id { get { return fornecedor_id != null ? (int)fornecedor_id : 0; } set { fornecedor_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public virtual Fornecedor fornecedor { get; set; }

        [DisplayName("Fornecedor")]
        public string fornecedor_nome { get { return fornecedor != null ? fornecedor.nome : string.Empty; } }

        [Browsable(false)]
        public int? atividade_id { get; set; }

        [NotMapped]
        [DisplayName("ID atividade")]
        public int edtAtividade_id { get { return atividade_id != null ? (int)atividade_id : 0; } set { atividade_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public virtual Atividade atividade { get; set; }

        [DisplayName("Atividade")]
        public string atividade_nome { get { return atividade != null ? atividade.nome : string.Empty; } }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento_item> orcamento_item { get; set; }
    }
}
