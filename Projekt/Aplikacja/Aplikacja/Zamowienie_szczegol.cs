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
    
    public partial class Zamowienie_szczegol
    {
        public int ID_zamowienie_szczegol { get; set; }
        public int ID_zamowienie { get; set; }
        public int ID_produkt { get; set; }
        public int Ilosc { get; set; }
    
        public virtual Produkt Produkt { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
