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
    
    public partial class Sprzedaz_usluga_detal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprzedaz_usluga_detal()
        {
            this.Szczegol_sprzedaz_usluga_detal = new HashSet<Szczegol_sprzedaz_usluga_detal>();
            this.Wysylka_detal = new HashSet<Wysylka_detal>();
        }
    
        public int ID_sprzedaz_usluga_detal { get; set; }
        public int ID_sprzedaz_detal { get; set; }
        public int ID_pracownik { get; set; }
        public System.DateTime Termin_zaplata { get; set; }
        public int ID_forma_platnosc { get; set; }
    
        public virtual Forma_platnosc Forma_platnosc { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Sprzedaz_detal Sprzedaz_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegol_sprzedaz_usluga_detal> Szczegol_sprzedaz_usluga_detal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wysylka_detal> Wysylka_detal { get; set; }
    }
}
