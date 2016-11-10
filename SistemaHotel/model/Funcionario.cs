namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.funcionario")]
    public partial class Funcionario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            atividade = new HashSet<Atividade>();
        }

        public int id { get; set; }

        [StringLength(45)]
        public string nome { get; set; }

        [StringLength(12)]
        public string rg { get; set; }

        [StringLength(15)]
        public string cpf { get; set; }

        [StringLength(1)]
        public string estado_civil { get; set; }

        [StringLength(45)]
        public string nom_conjuge { get; set; }

        [StringLength(45)]
        public string nom_mae { get; set; }

        [StringLength(45)]
        public string nom_pai { get; set; }

        [StringLength(20)]
        public string nacionalidade { get; set; }

        [StringLength(100)]
        public string funcao { get; set; }

        [StringLength(100)]
        public string endereco { get; set; }

        [StringLength(100)]
        public string cidade { get; set; }

        [StringLength(45)]
        public string bairro { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_contratacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atividade> atividade { get; set; }
    }
}
