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
    
    public partial class Szczegol_sprzedaz_usluga_hurt
    {
        public int ID_szczegol_sprzedaz_usluga_hurt { get; set; }
        public int ID_sprzedaz_usuluga_hurt { get; set; }
        public int ID_usluga { get; set; }
        public System.DateTime Data_sprzedaz_usluga { get; set; }
    
        public virtual Sprzedaz_usluga_hurt Sprzedaz_usluga_hurt { get; set; }
        public virtual Usluga Usluga { get; set; }
    }
}
