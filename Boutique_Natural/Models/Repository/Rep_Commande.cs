using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models.Repository
{
    public class Rep_Commande : Repository<Commande>
    {
        public Rep_Commande(ApplicationDbContext db)
        {
            Db = db;
        }

        public ApplicationDbContext Db { get; }

        public void Add(Commande entity)
        {
            Db.commandes.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var cmd = Find(id);
            Db.commandes.Remove(cmd);
            Db.SaveChanges();
        }

        public Commande Find(int id)
        {
            var cmd = Db.commandes.Include(c => c.client).Include(c => c.article).SingleOrDefault(c => c.id == id);
            return cmd;
        }

        public IList<Commande> List()
        {
            var cmd = Db.commandes.Include(c => c.client).Include(c => c.article).ToList();
            return cmd;
        }

        public void Update(int id, Commande entity)
        {
            Db.commandes.Update(entity);
            Db.SaveChanges();
        }
    }
}
