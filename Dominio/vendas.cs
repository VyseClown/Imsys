//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class vendas
    {
        public int id { get; set; }
        public Nullable<int> idvisita { get; set; }
        public Nullable<System.DateTime> datav { get; set; }
        public string status { get; set; }
        public Nullable<decimal> corretorcomissao { get; set; }
    
        public virtual visita visita { get; set; }
    }
}
