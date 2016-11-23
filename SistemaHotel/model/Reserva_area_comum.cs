namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.reserva_area_comum")]
    public partial class Reserva_area_comum
    {
        [DisplayName("ID")]
        public int id { get; set; }

        [Browsable(false)]
        [StringLength(254)]
        public string observacao { get; set; }

        [Browsable(false)]
        [StringLength(254)]
        public string observacao_devolucao { get; set; }

        [Browsable(false)]
        public int? solicitacao_id { get; set; }

        [NotMapped]
        [DisplayName("ID solicitação")]
        public int editSolicitacao_id { get { return solicitacao_id != null ? (int)solicitacao_id : 0; } set { solicitacao_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public virtual Solicitacao solicitacao { get; set; }

        [DisplayName("Solicitante")]
        [NotMapped]
        public string dspSolicitacao_solicitante { get { return solicitacao != null ? solicitacao.dspUsuario_solicitante_nome : string.Empty; } }

        [DisplayName("Área comum")]
        [NotMapped]
        public string dspSolicitacao_area_comum_nome { get { return solicitacao != null ? solicitacao.area_comum.nome : string.Empty; }}

        [DisplayName("Dt devolução")]
        [Column(TypeName = "date")]
        public DateTime? data_devolucao { get; set; }

        [Browsable(false)]
        public TimeSpan? hora_devolucao { get; set; }
    }
}
