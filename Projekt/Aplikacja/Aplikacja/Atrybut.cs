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
    
    public partial class Atrybut
    {
        public int ID_atrybut { get; set; }
        public int ID_produkt { get; set; }
        public int ID_slownik_atrybut { get; set; }
        public decimal Wartosc { get; set; }
    
        public virtual Produkt Produkt { get; set; }
        public virtual Slownik_atrybut Slownik_atrybut { get; set; }
    }
}