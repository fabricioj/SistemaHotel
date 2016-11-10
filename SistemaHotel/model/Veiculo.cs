namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.veiculo")]
    public partial class Veiculo
    {
        public int id { get; set; }

        [StringLength(45)]
        public string marca { get; set; }

        [StringLength(50)]
        public string modelo { get; set; }

        [StringLength(20)]
        public string cor { get; set; }

        [StringLength(9)]
        public string placa { get; set; }

        [StringLength(254)]
        public string observacao { get; set; }

        public int? morador_id { get; set; }

        public virtual Morador morador { get; set; }
    }
}
