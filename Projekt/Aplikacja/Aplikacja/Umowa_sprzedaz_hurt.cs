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
    
    public partial class Umowa_sprzedaz_hurt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Umowa_sprzedaz_hurt()
        {
            this.Zamowienie = new HashSet<Zamowienie>();
        }
    
        public int ID_umowa_sprzedaz_hurt { get; set; }
        public int ID_oferta_handlowa { get; set; }
        public int ID_klient { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Oferta_handlowa Oferta_handlowa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
