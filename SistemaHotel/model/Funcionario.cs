namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.funcionario")]
    public partial class Funcionario: Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Funcionario()
        {
            editEstado_civil = EstadoCivil.Nenhum;
            atividade = new HashSet<Atividade>();
        }

        [Browsable(false)]
        [StringLength(15)]
        public string rg { get; set; }

        [Browsable(false)]
        [StringLength(15)]
        public string cpf { get; set; }

        [Browsable(false)]
        [StringLength(1)]
        public string estado_civil { get; set; }

        [NotMapped]
        [Browsable(false)]
        public EstadoCivil editEstado_civil { get { return (EstadoCivil)(int.Parse(estado_civil)); } set { estado_civil = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [Browsable(false)]
        public string dspEstado_civil { get { return EnumHelper.GetDescription(editEstado_civil); } }

        [Browsable(false)]
        [StringLength(50)]
        public string nome_conjuge { get; set; }

        [Browsable(false)]
        [StringLength(50)]
        public string nome_mae { get; set; }

        [Browsable(false)]
        [StringLength(50)]
        public string nome_pai { get; set; }

        [Browsable(false)]
        [StringLength(20)]
        public string nacionalidade { get; set; }

        [DisplayName("Função")]
        [StringLength(100)]
        public string funcao { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [DisplayName("Dt contratação")]
        [Column(TypeName = "date")]
        public DateTime? data_contratacao { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atividade> atividade { get; set; }
    }
}
