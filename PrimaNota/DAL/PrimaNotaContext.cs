using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimaNota.Models;

namespace PrimaNota.DAL
{
    public class PrimaNotaContext : DbContext
    {
        public PrimaNotaContext(): base("PrimaNota")
        {
            //Database.SetInitializer<PrimaNotaContext>(new CreateDatabaseIfNotExists<PrimaNotaContext>());
            Database.SetInitializer<PrimaNotaContext>(new PrimaNotaDBInitializer());
        }

        public DbSet<Movimento> Movimenti { get; set; }
        public DbSet<DescrizioneMovimento> DescrizioniMovimento { get; set; }
    }
}
