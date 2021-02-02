using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Boutique_Natural.Models.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Boutique_Natural.Controllers
{
    public class CategoriesController : Controller
    {
        public Repository<Categories> Rep_Cat { get; }
        public UserManager<AppUsers> UserManager { get; }
        public SignInManager<AppUsers> SignIn { get; }
        public IHostingEnvironment Hosting { get; }

        public CategoriesController(Repository<Categories> rep_Cat,
            UserManager<AppUsers> userManager,
            SignInManager<AppUsers> signIn,
            IHostingEnvironment hosting)
        {
            Rep_Cat = rep_Cat;
            UserManager = userManager;
            SignIn = signIn;
            Hosting = hosting;
        }
        // GET: Categories
        public ActionResult Index()
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    var list_Cat = Rep_Cat.List();
                    return View(list_Cat);
                }
                else
                {
                    return NotFound();
                   
                }
            }
                return RedirectToAction("login", "Account");
            }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
                if (SignIn.IsSignedIn(User))
                {
                    if (get_Admin() == "Admin")
                    {
                        return View(find_Categories(id));
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction("login", "Accoun");
            }

        // GET: Categories/Create
        public ActionResult Create()
        {
                if (SignIn.IsSignedIn(User))
                {
                    if (get_Admin() == "Admin")
                    {
                        return View();
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                return RedirectToAction("login", "Account");
            }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categories categories)
        {
            if (SignIn.IsSignedIn(User))
            {
                if (get_Admin() == "Admin")
                {
                    if (ModelState.IsValid)
                    {
                        try
                        {

                            var cat = new Categories()
                            {
                                cat_Nom = categories.cat_Nom,
                            };
                            Rep_Cat.Add(cat);
                            return RedirectToAction(nameof(Index));
                        }
                        catch
                        {
                            return View();
                        }
                    }
                    return View(categories);

                    return View(categories);
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction("login", "Account");
        }

            // GET: Categories/Edit/5
            public ActionResult Edit(int id)
        {
            if (SignIn.IsSignedIn(User))
            {
                if (get_Admin() == "Admin")
                {
                    var find = find_Categories(id);

                    return View(find);
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction("login", "Account");
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Categories categories)
        {
            if (SignIn.IsSignedIn(User))
            {
                if (get_Admin() == "Admin")
                {
                    if (ModelState.IsValid)
                    {
                        try
                        {

                            var find = find_Categories(id);

                            find.cat_Nom = categories.cat_Nom;
                            Rep_Cat.Update(id, find);
                            return RedirectToAction(nameof(Index));
                        }
                        catch
                        {
                            return View();
                        }
                    }
                    return View(categories);
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction("login", "Account");
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            if (SignIn.IsSignedIn(User))
            {
                if (get_Admin() == "Admin")
                {
                    return View(find_Categories(id));
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction("login", "Account");
        }

        // POST: Categories/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Categories categories)
        {
            if (SignIn.IsSignedIn(User))
            {
                if (get_Admin() == "Admin")
                {
                    try
                    {
                        Rep_Cat.Delete(id);
                        return RedirectToAction(nameof(Index));
                    }
                    catch
                    {
                        return View();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            return RedirectToAction("login", "Account");
        }
        public Categories find_Categories(int id)
        {
            var find = Rep_Cat.Find(id);
            return find;
        }
        public string get_Admin()
        {
            var userId = UserManager.GetUserId(User);
            var user = UserManager.Users.SingleOrDefault(u => u.Id == userId);
            if (user.UserType == "Admin")
            {
                return "Admin";
            }
            else
            {
                return "no Admin";
            }
        }
    }
}
