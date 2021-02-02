using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models.Repository
{
    public class Rep_Ville:Repository<Ville>
    {
        public Rep_Ville(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public ApplicationDbContext DbContext { get; }

        public void Add(Ville entity)
        {
            DbContext.GetVilles.Add(entity);
            save();
        }

        public void Delete(int id)
        {
            var find_Ville = Find(id);
            DbContext.GetVilles.Remove(find_Ville);
            save();
        }

        public Ville Find(int id)
        {
            var find_Ville = DbContext.GetVilles.SingleOrDefault(v =>v.id==id);
            return find_Ville;
        }

        public IList<Ville> List()
        {
            var liste_Ville = DbContext.GetVilles.ToList();
            return liste_Ville;
        }

        public void Update(int id, Ville entity)
        {
            DbContext.GetVilles.Update(entity);
            save();
        }
        public void save()
        {
            DbContext.SaveChanges();
        }
    }
}
