using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models.Repository
{
    public class Rep_Produit : Repository<Produit>
    {
        public Rep_Produit(ApplicationDbContext dbContext_)
        {
            DbContext_ = dbContext_;
        }

        public ApplicationDbContext DbContext_ { get; }

        public void Add(Produit entity)
        {
            DbContext_.articles.Add(entity);
            DbContext_.SaveChanges();
        }

        public void Delete(int id)
        {
            var Produit = Find(id);
            DbContext_.articles.Remove(Produit);
            DbContext_.SaveChanges();
        }

        public Produit Find(int id)
        {
            var Produit = DbContext_.articles.Include(a => a.GetCategories).SingleOrDefault(a => a.id == id);
            return Produit;
        }

        public IList<Produit> List()
        {
            var Produit = DbContext_.articles.
                Include(a => a.GetCategories).
                ToList();
            return Produit;
        }

        public void Update(int id, Produit entity)
        {
            DbContext_.Update(entity);
            DbContext_.SaveChanges();
        }
     
    }
}
