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
    
    public partial class Umowa
    {
        public int ID_umowa { get; set; }
        public Nullable<int> ID_wymiar_pracy { get; set; }
        public Nullable<int> ID_rodzaj_umowy { get; set; }
        public Nullable<int> ID_pracownik { get; set; }
        public Nullable<int> ID_posada_pracownika { get; set; }
        public int Wynagrodzenie { get; set; }
    
        public virtual Posada_pracownika Posada_pracownika { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Rodzaj_umowy Rodzaj_umowy { get; set; }
        public virtual Wymiar_pracy Wymiar_pracy { get; set; }
    }
}
