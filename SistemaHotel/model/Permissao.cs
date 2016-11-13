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

        public int? funcionalidade_id { get; set; }

        public int? perfil_id { get; set; }

        public int? usuario_id { get; set; }

        public virtual Funcionalidade funcionalidade { get; set; }

        public virtual Perfil perfil { get; set; }

        public virtual Usuario usuario { get; set; }

        [NotMapped]
        [Browsable(false)]
        public SimNao editSupervisor { get; set; }
    }
}
