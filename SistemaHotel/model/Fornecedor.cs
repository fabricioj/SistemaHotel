namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.fornecedor")]
    public partial class Fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fornecedor()
        {
            orcamento = new HashSet<Orcamento>();
        }
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [StringLength(45)]
        public string nome { get; set; }

        [DisplayName("Razão social")]
        [StringLength(45)]
        public string razao_social { get; set; }

        [DisplayName("CNPJ")]
        [StringLength(25)]
        public string cnpj { get; set; }

        [DisplayName("Telefone")]
        [StringLength(15)]
        public string telefone { get; set; }

        [Browsable(false)]
        [StringLength(245)]
        public string endereco { get; set; }

        [Browsable(false)]
        [StringLength(100)]
        public string bairro { get; set; }

        [DisplayName("Cidade")]
        [StringLength(50)]
        public string cidade { get; set; }

        [Browsable(false)]
        [StringLength(15)]
        public string cep { get; set; }

        [DisplayName("Estado")]
        [StringLength(2)]
        public string estado { get; set; }

        [Browsable(false)]
        [StringLength(10)]
        public string numero { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento> orcamento { get; set; }
    }
}
