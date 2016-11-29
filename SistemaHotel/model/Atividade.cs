namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.atividade")]
    public partial class Atividade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Atividade()
        {
            orcamento = new HashSet<Orcamento>();
            editGerar_orcamento = SimNao.NAO;
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [StringLength(50)]
        public string nome { get; set; }

        [DisplayName("Dt cadastro")]
        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Browsable(false)]
        [Column(TypeName = "date")]
        public DateTime? data_confirmacao { get; set; }

        [Browsable(false)]
        [StringLength(254)]
        public string observacao_confirmacao { get; set; }

        [Browsable(false)]
        [StringLength(1)]
        public string gerar_orcamento { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editGerar_orcamento { get { return (SimNao)(int.Parse(gerar_orcamento)); } set { gerar_orcamento = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Gerar orçamento")]
        public string dspGerar_orcamento { get { return EnumHelper.GetDescription(editGerar_orcamento); } }

        [Browsable(false)]
        public int? solicitacao_id { get; set; }

        [NotMapped]
        [DisplayName("ID solicitação")]
        public int editSolicitacao_id { get { return solicitacao_id != null ? (int)solicitacao_id : 0; } set { solicitacao_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Solicitante")]
        [NotMapped]
        public string dspSolicitacao_solicitante { get { return solicitacao != null ? solicitacao.dspUsuario_solicitante_nome : string.Empty; } }

        [Browsable(false)]
        public int? procedimento_id { get; set; }

        [NotMapped]
        [DisplayName("ID procedimento")]
        public int editProcedimento_id{ get { return procedimento_id != null ? (int)procedimento_id : 0; } set { procedimento_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public int? funcionario_id { get; set; }

        [NotMapped]
        [DisplayName("ID funcionário")]
        public int editFuncionario_id { get { return funcionario_id != null ? (int)funcionario_id : 0; } set { funcionario_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public int? usuario_confirmacao_id { get; set; }

        [NotMapped]
        [Browsable(false)]
        public int editUsuario_confirmacao_id { get { return usuario_confirmacao_id != null ? (int)usuario_confirmacao_id : 0; } set { usuario_confirmacao_id = value != 0 ? (int?)value : null; } }

        [Browsable(false)]
        public virtual Funcionario funcionario { get; set; }

        [Browsable(false)]
        public virtual Procedimento procedimento { get; set; }

        [Browsable(false)]
        public virtual Solicitacao solicitacao { get; set; }

        [Browsable(false)]
        public virtual Usuario usuario_confirmacao { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orcamento> orcamento { get; set; }
    }
}
