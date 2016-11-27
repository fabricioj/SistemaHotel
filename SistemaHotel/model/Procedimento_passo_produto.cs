namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.procedimento_passo_produto")]
    public partial class Procedimento_passo_produto
    {

        [DisplayName("ID")]
        public int id { get; set; }

        [Browsable(false)]
        public int? procedimento_passo_id { get; set; }

        [Browsable(false)]
        public int? produto_id { get; set; }

        [DisplayName("ID produto")]
        [NotMapped]
        public int editProduto_id { get { return produto_id != null ? (int)produto_id : 0; } set { produto_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Descrição produto")]
        [NotMapped]
        public string produto_descricao { get { return produto != null ? produto.descricao : string.Empty; } }

        [DisplayName("Qtd utilizada")]
        public double? quantidade_utilizada { get; set; }

        [Browsable(false)]
        public virtual Procedimento_passo procedimento_passo { get; set; }

        [Browsable(false)]
        public virtual Produto produto { get; set; }
    }
}
