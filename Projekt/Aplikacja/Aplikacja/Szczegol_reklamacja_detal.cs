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
    
    public partial class Szczegol_reklamacja_detal
    {
        public int ID_szczegol_reklamacja_detal { get; set; }
        public int ID_reklamacja_detal { get; set; }
        public int ID_typ_reklamacja { get; set; }
        public int ID_produkt { get; set; }
        public int Ilosc { get; set; }
        public bool Utylizacja { get; set; }
        public string Uwagi { get; set; }
    
        public virtual Produkt Produkt { get; set; }
        public virtual Reklamacja_detal Reklamacja_detal { get; set; }
        public virtual Typ_reklamacja Typ_reklamacja { get; set; }
    }
}
