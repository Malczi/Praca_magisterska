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
    
    public partial class Nadgodziny
    {
        public int ID_nadgodziny { get; set; }
        public int ID_pracownik { get; set; }
        public System.DateTime Data_nadgodziny { get; set; }
        public int ID_rodzaj_nadgodziny { get; set; }
        public int Czas { get; set; }
    
        public virtual Pracownik Pracownik { get; set; }
        public virtual Rodzaj_nadgodziny Rodzaj_nadgodziny { get; set; }
    }
}
