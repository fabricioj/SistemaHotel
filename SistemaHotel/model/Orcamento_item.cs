namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.orcamento_item")]
    public partial class Orcamento_item
    {
        public Orcamento_item()
        {
            valor = 0;
            quantidade = 0;
            quantidade_comprada = 0;
        }
        [DisplayName("ID")]
        public int id { get; set; }

        [Browsable(false)]
        public int? orcamento_id { get; set; }

        [Browsable(false)]
        public int? produto_id { get; set; }

        [NotMapped]        
        [DisplayName("ID produto")]
        public int edtProduto_id { get { return produto_id != null ? (int)produto_id : 0; } set { produto_id = value != 0 ? (int?)value : null; } }

        [NotMapped]
        [DisplayName("Descrição produto")]
        public string produto_descricao { get { return produto != null ? produto.descricao : string.Empty; } }

        [DisplayName("Quantidade")]
        public double? quantidade { get; set; }

        [DisplayName("Qtd comprada")]
        public double? quantidade_comprada { get; set; }

        [DisplayName("Valor")]
        public double? valor { get; set; }

        [NotMapped]
        [DisplayName("Total")]
        public double total { get { return (quantidade != null ? (double)quantidade : 0) * (valor != null ? (double)valor : 0); } }

        [Browsable(false)]
        [DisplayName("Observação")]
        [StringLength(254)]
        public string observacao { get; set; }

        [Browsable(false)]
        public virtual Orcamento orcamento { get; set; }

        [Browsable(false)]
        public virtual Produto produto { get; set; }
    }
}
