using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models
{
    public class ApplicationDbContext
   : IdentityDbContext<AppUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<ApplicationUser>().ToTable("user");
        //}
        public DbSet<Produit> articles { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Commande> commandes { get; set; }
        public DbSet<Ligne_Commande> ligne_Commandes { get; set; }    
        public DbSet<Categories> categories { get; set; }
        public DbSet<Ville> GetVilles { get; set; }


    }
}
