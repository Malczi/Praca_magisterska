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
    
    public partial class Nieobecnosc
    {
        public int ID_nieobecnosc { get; set; }
        public Nullable<int> ID_pracownik { get; set; }
        public Nullable<int> ID_rodzaj_nieobecnosci { get; set; }
        public System.DateTime Data_od { get; set; }
        public System.DateTime Data_do { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Rodzaj_nieobecnosci Rodzaj_nieobecnosci { get; set; }
    }
}
