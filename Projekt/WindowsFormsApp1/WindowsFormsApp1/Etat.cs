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
    
    public partial class Etat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Etat()
        {
            this.Posada_pracownika = new HashSet<Posada_pracownika>();
        }
    
        public int ID_etat { get; set; }
        public int ID_stanowisko { get; set; }
        public int Liczba_miejsc { get; set; }
    
        public virtual Stanowisko Stanowisko { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posada_pracownika> Posada_pracownika { get; set; }
    }
}
