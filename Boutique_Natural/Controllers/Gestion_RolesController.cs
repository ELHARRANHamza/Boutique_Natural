using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Boutique_Natural.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Boutique_Natural.Controllers
{
    public class Gestion_RolesController : Controller
    {
        public RoleManager<IdentityRole> RoleManager { get; }
        public UserManager<AppUsers> UserManager { get; }
        public SignInManager<AppUsers> SignInManager { get; }

        public Gestion_RolesController(RoleManager<IdentityRole> roleManager,
            UserManager<AppUsers> userManager,
            SignInManager<AppUsers> signInManager)
        {
            RoleManager = roleManager;
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public ActionResult Index()
        {
            if (Valide_User())
            {
                var List_roles = RoleManager.Roles.ToList();

                return View(List_roles);
            }
            return getUserLogin();
        }

        // GET: Gestion_Roles/Details/5
        public ActionResult Details(string id)
        {
            if (Valide_User())
            {
                var roles = RoleManager.Roles.SingleOrDefault(r => r.Id == id);
                return View(roles);
            }
            return getUserLogin();

        }

        public ActionResult Create()
        {
            if (Valide_User())
            {
                return View();
            }
            return getUserLogin();
        }

        // POST: Gestion_Roles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Create_Roles create_Roles)
        {
            if (Valide_User())
            {
                if (ModelState.IsValid)
                {
                    var roles = new IdentityRole()
                    {
                        Name = create_Roles.nom_role
                    };
                    var result = await RoleManager.CreateAsync(roles);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                return View(create_Roles);
            }
            return getUserLogin();
        }

        // GET: Gestion_Roles/Edit/5
        public ActionResult Edit(string id)
        {
            if (Valide_User())
            {
                var roles = RoleManager.Roles.SingleOrDefault(r => r.Id == id);
                var create_Roles = new Create_Roles()
                {
                    nom_role = roles.Name
                };
                return View(create_Roles);
            }
            return getUserLogin();

        }

        // POST: Gestion_Roles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Create_Roles create_Roles)
        {
            if (Valide_User())
            {
                var role = RoleManager.Roles.SingleOrDefault(r => r.Id == id);
                role.Name = create_Roles.nom_role;
                var result = await RoleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                return View(role);
            }
            return getUserLogin();
        }

        // GET: Gestion_Roles/Delete/5
        public ActionResult Delete(string id)
        {
            if (Valide_User())
            {
                var roles = RoleManager.Roles.SingleOrDefault(r => r.Id == id);
                return View(roles);
            }
            return getUserLogin();
        }

        // POST: Gestion_Roles/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string id, IFormCollection collection)
        {
            if (Valide_User())
            {
                var role = RoleManager.Roles.SingleOrDefault(r => r.Id == id);
                var result = await RoleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                return View(role);
            }
            return getUserLogin();
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
            return RedirectToAction("login", "Account");
        }

    }
}