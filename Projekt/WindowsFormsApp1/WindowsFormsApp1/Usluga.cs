//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usluga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usluga()
        {
            this.Szczegol_sprzedaz_usluga_detal = new HashSet<Szczegol_sprzedaz_usluga_detal>();
            this.Szczegol_sprzedaz_usluga_hurt = new HashSet<Szczegol_sprzedaz_usluga_hurt>();
        }
    
        public int ID_usluga { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegol_sprzedaz_usluga_detal> Szczegol_sprzedaz_usluga_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegol_sprzedaz_usluga_hurt> Szczegol_sprzedaz_usluga_hurt { get; set; }
    }
}
