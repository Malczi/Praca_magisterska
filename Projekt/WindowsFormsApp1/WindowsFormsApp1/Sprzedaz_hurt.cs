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
    
    public partial class Sprzedaz_hurt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprzedaz_hurt()
        {
            this.Reklamacja_hurt = new HashSet<Reklamacja_hurt>();
            this.Sprzedaz_szczegol_hurt = new HashSet<Sprzedaz_szczegol_hurt>();
            this.Sprzedaz_usluga_hurt = new HashSet<Sprzedaz_usluga_hurt>();
        }
    
        public int ID_sprzedaz_hurt { get; set; }
        public int ID_zamowienie { get; set; }
        public System.DateTime Data_sprzedazy { get; set; }
        public System.DateTime Termin_zaplata { get; set; }
        public int ID_forma_platnosc { get; set; }
        public int ID_Typ_odbioru { get; set; }
    
        public virtual Forma_platnosc Forma_platnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reklamacja_hurt> Reklamacja_hurt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_szczegol_hurt> Sprzedaz_szczegol_hurt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaz_usluga_hurt> Sprzedaz_usluga_hurt { get; set; }
        public virtual Typ_odbioru Typ_odbioru { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
