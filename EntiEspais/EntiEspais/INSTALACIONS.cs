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
    
    public partial class INSTALACIONS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSTALACIONS()
        {
            this.ESPAIS = new HashSet<ESPAIS>();
            this.HORARI_INSTALACIO = new HashSet<HORARI_INSTALACIO>();
            this.TELEFONS_INSTALACIONS = new HashSet<TELEFONS_INSTALACIONS>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
        public string contrasenya { get; set; }
        public string adresa { get; set; }
        public string tipus { get; set; }
        public string email { get; set; }
        public string ruta_imagen { get; set; }
        public double altitut { get; set; }
        public double latitut { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESPAIS> ESPAIS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HORARI_INSTALACIO> HORARI_INSTALACIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONS_INSTALACIONS> TELEFONS_INSTALACIONS { get; set; }
    }
}
