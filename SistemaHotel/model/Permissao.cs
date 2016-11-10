namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.permissao")]
    public partial class Permissao
    {
        public int id { get; set; }

        [StringLength(1)]
        public string consultar { get; set; }

        [StringLength(1)]
        public string inserir { get; set; }

        [StringLength(1)]
        public string alterar { get; set; }

        [StringLength(1)]
        public string excluir { get; set; }

        public int? funcionalidade_id { get; set; }

        public int? perfil_id { get; set; }

        public int? usuario_id { get; set; }

        public virtual Funcionalidade funcionalidade { get; set; }

        public virtual Perfil perfil { get; set; }

        public virtual Usuario usuario { get; set; }
    }
}
