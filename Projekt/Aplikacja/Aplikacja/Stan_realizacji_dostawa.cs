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
    
    public partial class Stan_realizacji_dostawa
    {
        public int ID_stan_realizacji_dostawa { get; set; }
        public int ID_dostawa { get; set; }
        public int ID_status_dostawa { get; set; }
        public System.DateTime Data_st { get; set; }
        public int ID_pracownik { get; set; }
    
        public virtual Dostawa Dostawa { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Status_dostawa Status_dostawa { get; set; }
    }
}
