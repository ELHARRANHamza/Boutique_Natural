using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boutique_Natural.Models.Repository
{
    public class Rep_LigneCmd : Repository<Ligne_Commande>
    {
        public Rep_LigneCmd(ApplicationDbContext db)
        {
            Db = db;
        }

        public ApplicationDbContext Db { get; }

        public void Add(Ligne_Commande entity)
        {
            Db.ligne_Commandes.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var lcmd = Find(id);
            Db.ligne_Commandes.Remove(lcmd);
            Db.SaveChanges();
        }

        public Ligne_Commande Find(int id)
        {
            var lcmd = Db.ligne_Commandes.
                Include(l => l.commande.client).
                Include(l => l.commande).
                Include(l => l.article).
                SingleOrDefault(lc => lc.id == id);
            return lcmd;
        }

        public IList<Ligne_Commande> List()
        {
            var lcmd = Db.ligne_Commandes.
                Include(l => l.commande.client).
                Include(l => l.commande).
                Include(l => l.article).
                ToList();
            return lcmd;
        }

        public void Update(int id, Ligne_Commande entity)
        {
            Db.ligne_Commandes.Update(entity);
            Db.SaveChanges();
        }
    }
}