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
    
    public partial class Dostawca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dostawca()
        {
            this.Dostawa = new HashSet<Dostawa>();
        }
    
        public int ID_dostawca { get; set; }
        public string Nazwa { get; set; }
        public string Nr_telefon { get; set; }
        public string Adres_email { get; set; }
        public string Kod_pocztowy { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
        public int Nr_budynku { get; set; }
        public Nullable<int> Nr_lokalu { get; set; }
        public string NIP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dostawa> Dostawa { get; set; }
    }
}
