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
    
    public partial class Nr_telefon_pracownik
    {
        public int ID_Nr_telefon_pracownik { get; set; }
        public int ID_pracownik { get; set; }
        public string Numer { get; set; }
        public System.DateTime Data_od { get; set; }
        public Nullable<System.DateTime> Data_do { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
    }
}
