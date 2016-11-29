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

        [Browsable(false)]
        public int? morador_id { get; set; }

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
