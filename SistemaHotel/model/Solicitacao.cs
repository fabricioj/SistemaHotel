namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.solicitacao")]
    public partial class Solicitacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitacao()
        {
            atividade = new HashSet<Atividade>();
            reserva_area_comum = new HashSet<Reserva_area_comum>();
            editTipo = TipoSolicitacao.Nenhum;
            editResultado_visualizacao = TipoResultadoSolicitacao.Nenhum;
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [Browsable(false)]
        [StringLength(2)]
        public string tipo { get; set; }

        [NotMapped]
        [Browsable(false)]
        public TipoSolicitacao editTipo { get { return (TipoSolicitacao)(int.Parse(tipo)); } set { tipo = ((int)value).ToString().Trim(); } }

        [DisplayName("Tipo")]
        [NotMapped]        
        public string dspTipo { get { return EnumHelper.GetDescription(editTipo); } }

        [Browsable(false)]
        [StringLength(245)]
        public string servico { get; set; }

        [Browsable(false)]
        [StringLength(245)]
        public string local { get; set; }

        [Browsable(false)]
        [StringLength(245)]
        public string observacao { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_inicio { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_fim { get; set; }

        [Browsable(false)]
        public TimeSpan? hora_inicio { get; set; }

        [Browsable(false)]
        public TimeSpan? hora_fim { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_visualizacao { get; set; }

        [Browsable(false)]
        [StringLength(254)]
        public string observacao_visualizacao { get; set; }

        [Browsable(false)]
        [StringLength(2)]
        public string resultado_visualizacao { get; set; }

        [Browsable(false)]
        [NotMapped]
        public TipoResultadoSolicitacao editResultado_visualizacao { get { return (TipoResultadoSolicitacao)(int.Parse(resultado_visualizacao)); } set { resultado_visualizacao = ((int)value).ToString().Trim(); } }

        [Browsable(false)]
        [NotMapped]
        public string dspResultado_visualizacao { get { return EnumHelper.GetDescription(editResultado_visualizacao); } }

        [Browsable(false)]
        public int? area_comum_id { get; set; }

        [Browsable(false)]
        [NotMapped]        
        public int editArea_comum_id { get { return area_comum_id != null ? (int)area_comum_id : 0; } set { area_comum_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public virtual Area_comum area_comum { get; set; }

        [Browsable(false)]
        public int? usuario_solicitante_id { get; set; }

        [DisplayName("ID usuário solicitante")]
        [NotMapped]
        public int editUsuario_solicitante_id { get { return usuario_solicitante_id != null ? (int)usuario_solicitante_id : 0; } set { usuario_solicitante_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Nome usuário solicitante")]
        [NotMapped]
        public string dspUsuario_solicitante_nome { get { return usuario_solicitante != null ? usuario_solicitante.nome : string.Empty; } }

        [Browsable(false)]
        [NotMapped]
        public string dspSolicitante_nome { get { return usuario_solicitante != null ? usuario_solicitante.morador != null? usuario_solicitante.morador.nome: usuario_solicitante.nome : string.Empty; } }

        [Browsable(false)]
        public virtual Usuario usuario_solicitante { get; set; }

        [Browsable(false)]
        public int? usuario_visualizacao_id { get; set; }

        [Browsable(false)]
        [NotMapped]
        public int editUsuario_visualizacao_id { get { return usuario_visualizacao_id != null ? (int)usuario_visualizacao_id : 0; } set { usuario_visualizacao_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        [NotMapped]
        public string dspUsuario_visualizacao_nome { get { return usuario_visualizacao != null ? usuario_visualizacao.nome : string.Empty; } }

        [Browsable(false)]
        public virtual Usuario usuario_visualizacao { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atividade> atividade { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reserva_area_comum> reserva_area_comum { get; set; }
    }
}
