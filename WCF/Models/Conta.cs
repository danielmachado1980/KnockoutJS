//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conta
    {
        public Conta()
        {
            this.Contato = new HashSet<Contato>();
        }
    
        public int IdConta { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    
        public virtual ICollection<Contato> Contato { get; set; }
    }
}
