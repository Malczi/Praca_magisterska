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
    
    public partial class Typ_parametr_pojazd_transport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Typ_parametr_pojazd_transport()
        {
            this.Parametr_rodzaj_transport = new HashSet<Parametr_rodzaj_transport>();
        }
    
        public int ID_typ_parametr_pojazd_transport { get; set; }
        public string Nazwa { get; set; }
        public int ID_jednostka { get; set; }
    
        public virtual Jednostka Jednostka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Parametr_rodzaj_transport> Parametr_rodzaj_transport { get; set; }
    }
}
