using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class DataContext : DbContext
    {
        public DbSet<Corpus> Corpora { get; set; }
        public DbSet<Document> Documents { get; set; }
        
        public DataContext(bool drop = false)
            : base("311sql")  // Name of the connection string.
        {            
            if (drop)
                Database.SetInitializer<DataContext>(new DropCreateDatabaseAlways<DataContext>());
            else
                Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corpus>()
                .HasKey(c => c.Id)
                .HasMany(c => c.Documents);
        }
    }
}
