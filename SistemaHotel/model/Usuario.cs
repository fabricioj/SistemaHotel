namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sistemahoteldb.usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            permissao = new HashSet<Permissao>();
            solicitacao_solicitante = new HashSet<Solicitacao>();
            solicitacao_visualizacao = new HashSet<Solicitacao>();
        }

        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("Nome")]
        [StringLength(50)]
        public string nome { get; set; }

        [DisplayName("CPF")]
        [StringLength(15)]
        public string cpf { get; set; }

        [Browsable(false)]
        [StringLength(15)]
        public string telefone { get; set; }

        [Browsable(false)]
        [StringLength(15)]
        public string celular { get; set; }

        [DisplayName("Email")]
        [StringLength(50)]
        public string email { get; set; }
        
        [Browsable(false)]
        [StringLength(50)]
        public string senha { get; set; }

        [Browsable(false)]
        public int? perfil_id { get; set; }

        [DisplayName("ID perfil")]
        [NotMapped]
        public int editPerfil_id { get { return perfil_id != null ? (int)perfil_id : 0; } set { perfil_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Nome perfil")]
        [NotMapped]
        public string dspPerfil_nome { get { return perfil != null ? perfil.nome : string.Empty; } }

        [Browsable(false)]
        public int? morador_id { get; set; }

        [DisplayName("ID morador")]
        [NotMapped]
        public int editMorador_id { get { return morador_id != null ? (int)morador_id : 0; } set { morador_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Nome morador")]
        [NotMapped]
        public string dspMorador_nome { get { return morador != null ? morador.nome : string.Empty; } }

        [Browsable(false)]
        public virtual Morador morador { get; set; }

        [Browsable(false)]
        public virtual Perfil perfil { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permissao> permissao { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitacao> solicitacao_solicitante { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitacao> solicitacao_visualizacao { get; set; }

        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atividade> atividade_confirmacao { get; set; }
    }
}
