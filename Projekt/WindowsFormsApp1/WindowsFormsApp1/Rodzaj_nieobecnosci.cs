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
    
    public partial class Rodzaj_nieobecnosci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rodzaj_nieobecnosci()
        {
            this.Nieobecnosc = new HashSet<Nieobecnosc>();
        }
    
        public int ID_rodzaj_nieobecnosci { get; set; }
        public string Symbol { get; set; }
        public Nullable<decimal> Wspolczynnik_wynagrodzenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nieobecnosc> Nieobecnosc { get; set; }
    }
}
