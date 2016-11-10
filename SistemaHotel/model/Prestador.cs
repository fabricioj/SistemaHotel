namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.prestador")]
    public partial class Prestador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestador()
        {
            prestacao = new HashSet<Prestacao>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string razao_social { get; set; }

        [StringLength(25)]
        public string cnpj { get; set; }

        [StringLength(15)]
        public string telefone { get; set; }

        [StringLength(100)]
        public string endereco { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        [StringLength(70)]
        public string cidade { get; set; }

        [StringLength(20)]
        public string cep { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prestacao> prestacao { get; set; }
    }
}
