using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Boutique_Natural.Models.Repository;
using Boutique_Natural.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Boutique_Natural.Controllers
{
    public class ArticlesController : Controller
    {
        public Repository<Produit> Repository { get; }
        public Repository<Categories> Rep_Cat { get; }
        public IHostingEnvironment Hosting { get; }
        public UserManager<AppUsers> UserManager { get; }
        public SignInManager<AppUsers> SignIn { get; }

        public ArticlesController(Repository<Produit> repository,
            Repository<Categories> rep_Cat,
            IHostingEnvironment hosting,
            UserManager<AppUsers> userManager,
            SignInManager<AppUsers> signIn)
        {
            Repository = repository;
            Rep_Cat = rep_Cat;
            Hosting = hosting;
            UserManager = userManager;
            SignIn = signIn;
        }
        // GET: Articles
        public ActionResult Index()
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    var art = Repository.List();
                    return View(art);
                }
                else
                {
                    return NotFound();

                }
            }
            return RedirectToAction("login", "Account");
        }

        // GET: Articles/Details/5
        public ActionResult Details(int id)
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    var art = Repository.Find(id);
                    return View(art);
                }
                else
                {
                    return NotFound();

                }
            }
            return RedirectToAction("login", "Account");
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    var art = new Article_ViewModel();
                    art.categories = Rep_Cat.List();
                    return View(art);
                }
                else
                {
                    return NotFound();

                }
            }
            return RedirectToAction("login", "Account");
        }

        // POST: Articles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article_ViewModel model)
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    string fileName1 = "";
                    try
                    {
                        var cat = Rep_Cat.Find(model.Cat_Id);
                        if (model.file1 != null)
                        {
                            fileName1 = Add_Image(model.file1);
                        }

                        var article = new Produit()
                        {
                            img1 = fileName1,
                            Description = model.Description,
                            GetCategories = cat,
                            Titre_Art = model.libelle,
                            qte_Stck = model.qte_Stck,
                            prix_unitaire = model.prix_unitaire
                        };
                        Repository.Add(article);
                        return RedirectToAction(nameof(Index), new { article.id });
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

        // GET: Articles/Edit/5
        public ActionResult Edit(int id)
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    var art = Repository.Find(id);
                    var cat = Rep_Cat.Find(id);
                    var lis_cat = Rep_Cat.List();
                    var model = new Article_ViewModel()
                    {
                        id = art.id,
                        img1 = art.img1,

                        libelle = art.Titre_Art,
                        Description = art.Description,
                        prix_unitaire = art.prix_unitaire,
                        qte_Stck = art.qte_Stck,
                        Cat_Id = cat.id,
                        categories = lis_cat
                    };
                    return View(model);
                }
                else
                {
                    return NotFound();

                }
            }
            return RedirectToAction("login", "Account");
        }

        // POST: Articles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Article_ViewModel model)
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    try
                    {
                        string fileName1 = "";

                        var edit_Article = Repository.Find(id);
                        var cat = Rep_Cat.Find(model.Cat_Id);
                        if (model.file1 != null)
                        {
                            fileName1 = edit_Image(model.file1, model.img1);
                        }
                        else
                        {
                            fileName1 = model.img1;
                        }
                        edit_Article.img1 = fileName1;

                        edit_Article.Titre_Art = model.libelle;
                        edit_Article.prix_unitaire = model.prix_unitaire;
                        edit_Article.qte_Stck = model.qte_Stck;
                        edit_Article.Description = model.Description;
                        edit_Article.GetCategories = cat;
                        Repository.Update(id, edit_Article);
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

        // GET: Articles/Delete/5
        public ActionResult Delete(int id)
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    var art = Repository.Find(id);
                    return View(art);
                }
                else
                {
                    return NotFound();

                }
            }
            return RedirectToAction("login", "Account");
        }

        // POST: Articles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (SignIn.IsSignedIn(User))
            {

                if (get_Admin() == "Admin")
                {
                    try
                    {
                        Repository.Delete(id);
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
        public string Add_Image(IFormFile file)
        {
            string file_Name = "";
            string chemain = Path.Combine(Hosting.WebRootPath, "Image_Article");
            file_Name = file.FileName;
            string path = Path.Combine(chemain, file_Name);
            file.CopyTo(new FileStream(path, FileMode.Create));
            return file_Name;
        }
        public string edit_Image(IFormFile file, string old_image)
        {
            string fileName = "";
            string upload = Path.Combine(Hosting.WebRootPath, "Image_Article");
            fileName = file.FileName;
            string fullpath = Path.Combine(upload, fileName);
            string oldFileName = old_image;
            string fullOldPath = Path.Combine(upload, oldFileName);
            if (fullpath != fullOldPath)
            {
                System.IO.File.Delete(fullOldPath);
                file.CopyTo(new FileStream(fullpath, FileMode.Create));
            }
            return fileName;
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