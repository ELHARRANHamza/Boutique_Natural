using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models.Repository
{
    public class Rep_Client : Repository<Client>
    {
        private readonly ApplicationDbContext db;
        public Rep_Client(ApplicationDbContext projet)
        {
            db = projet;
        }
        public void Add(Client entity)
        {
            db.clients.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var clt = Find(id);
            db.Remove(clt);
            db.SaveChanges();
        }

        public Client Find(int id)
        {
            var clt = db.clients.Include(c =>c.GetVille).SingleOrDefault(c => c.id == id);
            return clt;
        }

        public IList<Client> List()
        {
            var clt = db.clients.Include(c => c.GetVille).ToList();
            return clt;
        }

        public void Update(int id, Client entity)
        {
            db.clients.Update(entity);
            db.SaveChanges();
        }
    }
}
