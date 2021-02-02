using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Boutique_Natural.Controllers
{
    public class DashbordController : Controller
    {
        public ApplicationDbContext Context { get; }
        public SignInManager<AppUsers> SignInManager { get; }
        public UserManager<AppUsers> UserManager { get; }

        public DashbordController(ApplicationDbContext context,
            SignInManager<AppUsers> signInManager,
              UserManager<AppUsers> userManager
)
        {
            Context = context;
            SignInManager = signInManager;
            UserManager = userManager;
        }
        public IActionResult Index()
        {
            if (Valide_User() == true)
            {
                getCommandeValider();
                var NbClt = Context.ligne_Commandes.Count(l => l.pos == 3);
                var artAchat = Context.ligne_Commandes.Where(l => l.pos == 3).Sum(l => l.qte);
                var total = Context.ligne_Commandes.Where(l => l.pos == 3).Sum(l => l.qte * l.article.prix_unitaire);
                var qte = Context.articles.Sum(a => a.qte_Stck);
                var nb_Cmd_Refuser = Context.ligne_Commandes.Count(lg => lg.pos == 4);
                ViewBag.ttl = total;
                ViewBag.nb_Art_Achat = artAchat;
                ViewBag.nbClt = NbClt;
                ViewBag.cmd_Refuser = nb_Cmd_Refuser;
                return View();
            }

            return getUserLogin();
        }

        public ActionResult getCommandeValider()
        {
            var dbContext_Projet = Context.ligne_Commandes.
                                    Include(l => l.article).
                                    OrderBy(l => l.commande.date_Cmd).
                                    Include(l => l.commande).
                                    Include(l => l.article.GetCategories).
                                    Include(l => l.commande.client).
                                    Where(lg => lg.pos == 3);
            ViewBag.List = dbContext_Projet;
            return View(ViewBag.List);
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
        public ActionResult getUserLogin()
        {
            return RedirectToAction("login", "Account_Admin");
        }

    }
}