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
    
    public partial class permissoes
    {
        public int id { get; set; }
        public Nullable<int> idusuario { get; set; }
        public string gerenciarusuario { get; set; }
        public string publicarimovel { get; set; }
        public string gerenciarvisita { get; set; }
        public string gerenciarvendaaluguel { get; set; }
        public string gerenciarpermissoes { get; set; }
        public string gerenciarpagamentoaluguel { get; set; }
    
        public virtual usuario usuario { get; set; }
    }
}