namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.produto")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            entrega_mercadorias = new HashSet<Entrega_mercadorias>();
            orcamento_item = new HashSet<Orcamento_item>();
            procedimento_passo_produto = new HashSet<Procedimento_passo_produto>();
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Descrição")]
        [StringLength(245)]
        public string descricao { get; set; }

        [Browsable(false)]
        [StringLength(1)]
        public string controla_estoque { get; set; }

        [NotMapped]
        [Browsable(false)]
        public util.SimNao editControla_estoque { get { return (SimNao)(int.Parse(controla_estoque)); } set { controla_estoque = ((int)value).ToString().Trim(); } }

        [DisplayName("Controla estoque")]
        public string dspcontrola_estoque { get { return EnumHelper.GetDescription(editControla_estoque); } }

        [DisplayName("Qtd estoque")]
        public double? quantidade { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entrega_mercadorias> entrega_mercadorias { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento_item> orcamento_item { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimento_passo_produto> procedimento_passo_produto { get; set; }
    }
}
