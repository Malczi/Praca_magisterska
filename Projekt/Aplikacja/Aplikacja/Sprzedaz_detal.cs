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
    
    public partial class Sprzedaz_detal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprzedaz_detal()
        {
            this.Reklamacja_detal = new HashSet<Reklamacja_detal>();
            this.Sprzedaz_szczegol_detal = new HashSet<Sprzedaz_szczegol_detal>();
            this.Sprzedaz_usluga_detal = new HashSet<Sprzedaz_usluga_detal>();
        }
    
        public int ID_sprzedaz_detal { get; set; }
        public System.DateTime Data_sprzedazy { get; set; }
        public System.DateTime Termin_zaplata { get; set; }
        public int ID_forma_platnosc { get; set; }
        public int ID_Typ_odbioru { get; set; }
    
        public virtual Forma_platnosc Forma_platnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reklamacja_detal> Reklamacja_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_szczegol_detal> Sprzedaz_szczegol_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_usluga_detal> Sprzedaz_usluga_detal { get; set; }
        public virtual Typ_odbioru Typ_odbioru { get; set; }
    }
}