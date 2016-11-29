namespace SistemaHotel.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using util;

    [Table("sistemahoteldb.permissao")]
    public partial class Permissao
    {
        public Permissao()
        {
            editConsultar = SimNao.NAO;
            editInserir = SimNao.NAO;
            editAlterar = SimNao.NAO;
            editExcluir = SimNao.NAO;
            editEspecial = SimNao.NAO;
        }
        public int id { get; set; }

        [Browsable(false)]
        [StringLength(1)]
        public string consultar { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editConsultar { get { return (SimNao)(int.Parse(consultar)); } set { consultar = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Consultar")]
        public string dspConsultar { get { return EnumHelper.GetDescription(editConsultar); } }

        [Browsable(false)]
        [StringLength(1)]
        public string inserir { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editInserir { get { return (SimNao)(int.Parse(inserir)); } set { inserir = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Inserir")]
        public string dspInserir { get { return EnumHelper.GetDescription(editInserir); } }

        [Browsable(false)]
        [StringLength(1)]
        public string alterar { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editAlterar { get { return (SimNao)(int.Parse(alterar)); } set { alterar = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Alterar")]
        public string dspAlterar { get { return EnumHelper.GetDescription(editAlterar); } }

        [Browsable(false)]
        [StringLength(1)]
        public string excluir { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editExcluir { get { return (SimNao)(int.Parse(excluir)); } set { excluir = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Excluir")]
        public string dspExcluir { get { return EnumHelper.GetDescription(editExcluir); } }

        [Browsable(false)]
        [StringLength(1)]
        public string especial { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editEspecial { get { return (SimNao)(int.Parse(especial)); } set { especial = ((int)value).ToString().Trim(); } }

        [NotMapped]
        [DisplayName("Especial")]
        public string dspEspecial { get { return EnumHelper.GetDescription(editEspecial); } }

        [Browsable(false)]
        public int? funcionalidade_id { get; set; }

        [Browsable(false)]
        [NotMapped]
        public int editFuncionalidade_id { get { return funcionalidade_id != null ? (int)funcionalidade_id : 0; } set { funcionalidade_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Funcionalidade")]
        [NotMapped]
        public string dspFuncionalidade_nome { get { return funcionalidade != null ? funcionalidade.nome_funcionalidade : string.Empty; }}

        [Browsable(false)]
        public int? perfil_id { get; set; }

        [Browsable(false)]
        [NotMapped]
        public int editPerfil_id { get { return perfil_id != null ? (int)perfil_id : 0; } set { perfil_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Perfil")]
        [NotMapped]
        public string dspPerfil_nome { get { return perfil != null ? perfil.nome : string.Empty; } }

        [Browsable(false)]
        public int? usuario_id { get; set; }

        [Browsable(false)]
        [NotMapped]
        public int editUsuario_id { get { return usuario_id != null ? (int)usuario_id : 0; } set { usuario_id = value != 0 ? (int?)value : null; } }

        [DisplayName("Usuário")]
        [NotMapped]
        public string dspUsuario_nome { get { return usuario != null ? usuario.nome : string.Empty; } }

        [Browsable(false)]
        public virtual Funcionalidade funcionalidade { get; set; }

        [Browsable(false)]
        public virtual Perfil perfil { get; set; }

        [Browsable(false)]
        public virtual Usuario usuario { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editSupervisor { get; set; }
    }
}
