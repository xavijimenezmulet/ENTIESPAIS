//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntiEspais
{
    using System;
    using System.Collections.Generic;
    
    public partial class EQUIPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EQUIPS()
        {
            this.DEMANDA_ACT = new HashSet<DEMANDA_ACT>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
        public bool te_discapacitat { get; set; }
        public int id_entitat { get; set; }
        public string temporada { get; set; }
        public int id_competicio { get; set; }
        public int id_categoria_edat { get; set; }
        public int id_categoria_equip { get; set; }
        public int id_sexe { get; set; }
        public int id_esport { get; set; }
    
        public virtual CATEGORIA_EDAT CATEGORIA_EDAT { get; set; }
        public virtual CATEGORIA_EQUIP CATEGORIA_EQUIP { get; set; }
        public virtual COMPETICIONS COMPETICIONS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEMANDA_ACT> DEMANDA_ACT { get; set; }
        public virtual ENTITATS ENTITATS { get; set; }
        public virtual ESPORTS ESPORTS { get; set; }
        public virtual SEXE SEXE { get; set; }
    }
}
