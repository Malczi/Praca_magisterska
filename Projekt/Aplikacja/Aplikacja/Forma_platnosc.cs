//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplikacja
{
    using System;
    using System.Collections.Generic;
    
    public partial class Forma_platnosc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Forma_platnosc()
        {
            this.Sprzedaz_usluga_detal = new HashSet<Sprzedaz_usluga_detal>();
            this.Sprzedaz_hurt = new HashSet<Sprzedaz_hurt>();
            this.Sprzedaz_detal = new HashSet<Sprzedaz_detal>();
            this.Sprzedaz_usluga_hurt = new HashSet<Sprzedaz_usluga_hurt>();
        }
    
        public int ID_forma_platnosc { get; set; }
        public string Nazwa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_usluga_detal> Sprzedaz_usluga_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_hurt> Sprzedaz_hurt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_detal> Sprzedaz_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_usluga_hurt> Sprzedaz_usluga_hurt { get; set; }
    }
}
