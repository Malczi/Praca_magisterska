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
    
    public partial class Miejsce_magazynowania
    {
        public int ID_miejsce_magazynowania { get; set; }
        public int ID_produkt { get; set; }
        public Nullable<int> ID_magazyn { get; set; }
        public int ID_typ_magazynowania { get; set; }
        public int ID_poziom_magazynowanie { get; set; }
        public int Nr_miejsca { get; set; }
    
        public virtual Magazyn Magazyn { get; set; }
        public virtual Poziom_magazynowanie Poziom_magazynowanie { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Typ_magazynowania Typ_magazynowania { get; set; }
    }
}
