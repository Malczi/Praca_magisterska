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
    
    public partial class Sprzedaz_szczegol_hurt
    {
        public int ID_sprzedaz_szczegol_hurt { get; set; }
        public int ID_sprzedaz_hurt { get; set; }
        public int ID_produkt { get; set; }
        public int ID_jednostka { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Jednostka Jednostka { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Sprzedaz_hurt Sprzedaz_hurt { get; set; }
    }
}
