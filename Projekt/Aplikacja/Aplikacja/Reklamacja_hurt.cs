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
    
    public partial class Reklamacja_hurt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reklamacja_hurt()
        {
            this.Szczegol_reklamacja_hurt = new HashSet<Szczegol_reklamacja_hurt>();
        }
    
        public int ID_reklamacja_hurt { get; set; }
        public int ID_pracownik { get; set; }
        public int ID_sprzedaz_hurt { get; set; }
        public System.DateTime Data_reklamacja { get; set; }
        public string Opis_reklamacja { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Sprzedaz_hurt Sprzedaz_hurt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Szczegol_reklamacja_hurt> Szczegol_reklamacja_hurt { get; set; }
    }
}
