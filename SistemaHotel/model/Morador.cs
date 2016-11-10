namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.morador")]
    public partial class Morador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Morador()
        {
            dependentes = new HashSet<Dependentes>();
            entrega_mecadoria = new HashSet<Entrega_mecadoria>();
            entrega_mercadorias = new HashSet<Entrega_mercadorias>();
            moradia = new HashSet<Moradia>();
            ocorrencia = new HashSet<Ocorrencia>();
            usuario = new HashSet<Usuario>();
            vaga = new HashSet<Vaga>();
            veiculo = new HashSet<Veiculo>();
            visitante = new HashSet<Visitante>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(12)]
        public string rg { get; set; }

        [StringLength(14)]
        public string cpf { get; set; }

        [StringLength(9)]
        public string celular { get; set; }

        [StringLength(15)]
        public string tel_fixo { get; set; }

        [StringLength(35)]
        public string email { get; set; }

        [StringLength(45)]
        public string empresa { get; set; }

        [StringLength(15)]
        public string tel_comercial { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dependentes> dependentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_mecadoria> entrega_mecadoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_mercadorias> entrega_mercadorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moradia> moradia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocorrencia> ocorrencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vaga> vaga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Veiculo> veiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visitante> visitante { get; set; }
    }
}
