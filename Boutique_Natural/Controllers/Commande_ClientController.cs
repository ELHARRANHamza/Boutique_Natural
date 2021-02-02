using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Boutique_Natural.Models.Repository;
using Boutique_Natural.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Boutique_Natural.Controllers
{
    public class Commande_ClientController : Controller
    {
        private readonly ApplicationDbContext context;

        public Repository<Ligne_Commande> Lcmd { get; }
        public Repository<Produit> Art { get; }
        public Repository<Ville> Rep_Ville { get; }
        public Repository<Commande> Cmd { get; }
        public Repository<Client> Clt { get; }
        public SignInManager<AppUsers> SignInManager { get; }
        public UserManager<AppUsers> UserManager { get; }

        // GET: Commande_Client
        public Commande_ClientController(Repository<Ligne_Commande> lcmd,
            Repository<Produit> art,
            Repository<Ville> rep_Ville,
            Repository<Commande> cmd,
            Repository<Client> clt,
            ApplicationDbContext _Context,
             SignInManager<AppUsers> signInManager,
              UserManager<AppUsers> userManager)
        {
            Lcmd = lcmd;
            Art = art;
            Rep_Ville = rep_Ville;
            Cmd = cmd;
            Clt = clt;
            context = _Context;
            SignInManager = signInManager;
            UserManager = userManager;
        }
        public IActionResult Index()
        {
            if (Valide_User())
            {
                var ligne_Commande = GetLigne_Commande(1);
                return View(ligne_Commande);
            }
            return RedirectToAction("login", "Account");
        }

        public IActionResult Commande(int id)
        {
            var list_Ville = Rep_Ville.List();
            var find_Art = Art.Find(id);
            var model = new CommandeViewModel()
            {
                GetVilles = list_Ville,
                img=find_Art.img1
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Commande(int id,CommandeViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var id_Ville = model.id_Ville;
                    var find_Ville = Rep_Ville.Find(id_Ville);
                    var Client = new Client() { 
                    nom=model.nom,
                    Adresse=model.Adresse,
                    email=model.email,
                    prenom=model.prenom,
                    Tele=model.Tele,
                    GetVille=find_Ville
                    };
                    Clt.Add(Client);
                    var id_Client = Clt.List().Max(c => c.id);
                    var find_Client = Clt.Find(id_Client);
                    var commande = new Commande()
                    {
                        date_Cmd=DateTime.Now,
                        client=find_Client
                    };
                    Cmd.Add(commande);
                    var id_Cmd=Cmd.List().Max(c => c.id);
                    var find_Cmd = Cmd.Find(id_Cmd);
                    var find_Art = Art.Find(id);
                    var ligne_Cmd = new Ligne_Commande()
                    {
                        commande = find_Cmd,
                        article = find_Art,
                        pos = 1,
                        qte = 1
                    };
                    Lcmd.Add(ligne_Cmd);
                  
                    var list_Ville = Rep_Ville.List();
                    var model_Cmd = new CommandeViewModel()
                    {
                        GetVilles = list_Ville,
                        id_Ville = model.id_Ville,
                        img = find_Art.img1
                    };
                    ViewBag.Valide = "Operation accomplished Succefully";
                    return View(model_Cmd);
                }
                catch
                {
                    return View();
                }
            }
            return View(model);
        }

            public ActionResult Commande_Valider()
        {
            if (Valide_User())
            {
                var ligne_Commande = GetLigne_Commande(3);
                return View(ligne_Commande);
            }
            return RedirectToAction("login", "Account");
        }
        public ActionResult Commande_Attente()
        {
            if (Valide_User())
            {
                var ligne_Commande = GetLigne_Commande(2);
                return View(ligne_Commande);
            }
            return RedirectToAction("login", "Account");

        }
        public ActionResult Commande_Refuser()
        {
            if (Valide_User())
            {
                var ligne_Commande = GetLigne_Commande(4);
                return View(ligne_Commande);
            }
            return RedirectToAction("login", "Account");

        }

        // GET: Commande_Client/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return RedirectToAction("Error404", "Home1");
            }

            var ligne_Commande = await context.ligne_Commandes
                .Include(l => l.article)
                .Include(l => l.commande)
                .Include(l => l.commande.client)
                .FirstOrDefaultAsync(m => m.id == id);
            if (ligne_Commande == null)
            {
                return RedirectToAction("Error404", "Home1");
            }

            return View(ligne_Commande);
        }
        // GET: Commande_Client/Create


        // POST: Commande_Client/Create

        public ActionResult Edit(int id)
        {
            if (Valide_User())
            {

                return View(Information_Client(id));
            }
            return RedirectToAction("login", "Account");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Ligne_Cmd_ViewModel ligne_Commande)
        {
            if (Valide_User())
            {
                try
                {
                    EditCommande(id, ligne_Commande, 2);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return RedirectToAction("Error404", "Home1");
                }
            }
            return RedirectToAction("login", "Account");
        }


        public ActionResult Valide_Attente(int id)
        {
            if (Valide_User())
            {
                return View(Information_Client(id));
            }
            return RedirectToAction("login", "Account");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Valide_Attente(int id, Ligne_Cmd_ViewModel ligne_Commande)
        {
            if (Valide_User())
            {
                try
                {
                    EditCommande(id, ligne_Commande, 3);
                    return RedirectToAction(nameof(Commande_Attente));
                }
                catch
                {
                    return View();
                }
            }
            return RedirectToAction("login", "Account");
        }


        // GET: Commande_Client/Delete/5
        public ActionResult Delete(int id)
        {
            if (Valide_User())
            {

                return View(Information_Client(id));
            }
            return RedirectToAction("login", "Account");
        }

        // POST: Commande_Client/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Ligne_Cmd_ViewModel ligne_Commande)
        {
            if (Valide_User())
            {
                try
                {
                    EditCommande(id, ligne_Commande, 4);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return getUserLogin();
        }
        private bool Ligne_CommandeExists(int id)
        {
            return context.ligne_Commandes.Any(e => e.id == id);
        }
        public int Dataa()
        {
            ViewBag.Test = context.ligne_Commandes.Count(l => l.pos == 1);
            return ViewBag.Test;
        }
        public ActionResult getNotification()
        {
            Dataa();
            var dbContext_Projet = context.ligne_Commandes.
                                    Include(l => l.article).
                                   OrderByDescending(l => l.commande.date_Cmd).
                                    Include(l => l.commande).
                                    Include(l => l.article.GetCategories).
                                    Include(l => l.commande.client).
                                    Where(lg => lg.pos == 1);
            ViewBag.List = dbContext_Projet;
            return View(ViewBag.List);
        }
        public Ligne_Cmd_ViewModel Information_Client(int id)
        {

            var licmd = Lcmd.Find(id);
            var cm = Cmd.Find(licmd.id_Commande);
            var cl = Clt.Find(licmd.commande.client.id);
            Ligne_Cmd_ViewModel ligne_Cmd = new Ligne_Cmd_ViewModel()
            {
                qte = licmd.qte,
                article = Art.Find(licmd.id_Article),
                id_art = licmd.id_Article,
                cmd = cm,
                clt = cl
            };
            return ligne_Cmd;
        }
        public List<Ligne_Commande> GetLigne_Commande(int pos)
        {

            var lg = Lcmd.List().Where(l => l.pos == pos).ToList();
            return lg;
        }
        public bool Valide_User()
        {
            if (SignInManager.IsSignedIn(User))
            {
                var id_user = UserManager.GetUserId(User);
                var getUser = UserManager.Users.SingleOrDefault(u => u.Id == id_user);
                if (getUser.UserType == "Admin")
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public void EditCommande(int id, Ligne_Cmd_ViewModel ligne_Commande, int pos)
        {
            var lg = Lcmd.Find(id);
            var art = Art.Find(lg.id_Article);

            if (pos == 4)
            {
                int qte_Stock = art.qte_Stck;
                int qte = lg.qte;
                art.qte_Stck = qte_Stock + qte;
                Art.Update(art.id, art);
            }
            lg.pos = pos;
            Lcmd.Update(ligne_Commande.id, lg);
        }
        public ActionResult getUserLogin()
        {
            return RedirectToAction("login", "Account");
        }

    }
}