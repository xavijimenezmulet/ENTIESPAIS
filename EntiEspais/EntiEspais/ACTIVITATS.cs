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
    
    public partial class ACTIVITATS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTIVITATS()
        {
            this.HORARI_ACTIVITAT = new HashSet<HORARI_ACTIVITAT>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
        public int id_demanda_act { get; set; }
        public int id_admin { get; set; }
        public int id_espai { get; set; }
    
        public virtual ADMINISTRADORS ADMINISTRADORS { get; set; }
        public virtual DEMANDA_ACT DEMANDA_ACT { get; set; }
        public virtual ESPAIS ESPAIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HORARI_ACTIVITAT> HORARI_ACTIVITAT { get; set; }
    }
}
