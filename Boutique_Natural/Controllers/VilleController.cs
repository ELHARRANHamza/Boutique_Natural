using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Boutique_Natural.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Boutique_Natural.Controllers
{
    public class VilleController : Controller
    {
        public Repository<Ville> Rep_Ville { get; }

        public VilleController(Repository<Ville> rep_Ville)
        {
            Rep_Ville = rep_Ville;
        }
        // GET: Ville
        public ActionResult Index()
        {
            var list_Ville = Rep_Ville.List();
            return View(list_Ville);
        }

        // GET: Ville/Details/5
        public ActionResult Details(int id)
        {
            var getVille = Rep_Ville.Find(id);
            return View(getVille);
        }

        // GET: Ville/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ville/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ville ville)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var vl = new Ville()
                    {
                        ville_Name = ville.ville_Name
                    };
                    Rep_Ville.Add(vl);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View(ville);
        }

        // GET: Ville/Edit/5
        public ActionResult Edit(int id)
        {
            var findVille = Rep_Ville.Find(id);
            return View(findVille);
        }

        // POST: Ville/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Ville ville)
        {
            try
            {
                var findVille = Rep_Ville.Find(id);
                findVille.ville_Name = ville.ville_Name;
                Rep_Ville.Update(id, findVille);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ville/Delete/5
        public ActionResult Delete(int id)
        {
            var find_Ville = Rep_Ville.Find(id);
            return View(find_Ville);
        }

        // POST: Ville/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Rep_Ville.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}