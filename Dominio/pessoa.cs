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
    
    public partial class pessoa
    {
        public pessoa()
        {
            this.cliente = new HashSet<cliente>();
            this.corretor = new HashSet<corretor>();
            this.usuario = new HashSet<usuario>();
            this.interesse = new HashSet<interesse>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public Nullable<int> idendereco { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<cliente> cliente { get; set; }
        public virtual ICollection<corretor> corretor { get; set; }
        public virtual ICollection<usuario> usuario { get; set; }
        public virtual endereco endereco { get; set; }
        public virtual ICollection<interesse> interesse { get; set; }
    }
}
