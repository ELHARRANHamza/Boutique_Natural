using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models.Repository
{
    public class Rep_Cat : Repository<Categories>
    {
        public Rep_Cat(ApplicationDbContext dbContext_)
        {
            DbContext_ = dbContext_;
        }

        public ApplicationDbContext DbContext_ { get; }

        public void Add(Categories entity)
        {
            DbContext_.categories.Add(entity);
            DbContext_.SaveChanges();

        }

        public void Delete(int id)
        {
            var cat = Find(id);
            DbContext_.categories.Remove(cat);
            DbContext_.SaveChanges();

        }

        public Categories Find(int id)
        {
            var cat = DbContext_.categories.AsEnumerable().AsParallel().SingleOrDefault(c => c.id == id);
            return cat;
        }

        public IList<Categories> List()
        {
            var cat = DbContext_.categories.ToList();
            return cat;
        }

        public void Update(int id, Categories entity)
        {
            DbContext_.categories.Update(entity);
            DbContext_.SaveChanges();
        }
    }
}
