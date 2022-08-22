using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class EFContext : DbContext
    {
    public EFContext() : base("Thiago")
    {
    Database.SetInitializer<EFContext>(
    new DropCreateDatabaseIfModelChanges<EFContext>());
    }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    }
}
