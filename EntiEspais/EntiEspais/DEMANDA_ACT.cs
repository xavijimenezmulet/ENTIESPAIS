
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
    
public partial class DEMANDA_ACT
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DEMANDA_ACT()
    {

        this.ACTIVITATS = new HashSet<ACTIVITATS>();

        this.DIA_SEMANA = new HashSet<DIA_SEMANA>();

    }


    public int id { get; set; }

    public string nom { get; set; }

    public System.TimeSpan duracio { get; set; }

    public byte num_espais { get; set; }

    public byte num_dies { get; set; }

    public bool es_asignada { get; set; }

    public int id_equip { get; set; }

    public int id_interval_hores { get; set; }

    public int id_espai { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ACTIVITATS> ACTIVITATS { get; set; }

    public virtual EQUIPS EQUIPS { get; set; }

    public virtual ESPAIS ESPAIS { get; set; }

    public virtual HORES HORES { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DIA_SEMANA> DIA_SEMANA { get; set; }

}

}
