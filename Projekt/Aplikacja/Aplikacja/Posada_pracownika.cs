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
    
    public partial class Posada_pracownika
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Posada_pracownika()
        {
            this.Umowa = new HashSet<Umowa>();
        }
    
        public int ID_posada_pracownika { get; set; }
        public Nullable<int> ID_etat { get; set; }
        public System.DateTime Data_od { get; set; }
        public Nullable<System.DateTime> Data_do { get; set; }
    
        public virtual Etat Etat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Umowa> Umowa { get; set; }
    }
}
