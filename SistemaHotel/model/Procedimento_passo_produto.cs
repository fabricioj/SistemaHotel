namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.procedimento_passo_produto")]
    public partial class Procedimento_passo_produto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? quantidade_utlilizada { get; set; }

        public int? procedimento_passo_id { get; set; }

        public int? produto_id { get; set; }

        public virtual Procedimento_passo procedimento_passo { get; set; }

        public virtual Produto produto { get; set; }
    }
}
