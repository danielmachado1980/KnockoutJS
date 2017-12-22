using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    public class ProvaContext : DbContext
    {
        public ProvaContext()
              : base("Avaliacao")
        { }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Contato> Contatos { get; set; }
    }
}
