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
    public class AccountController : Controller
    {
        public AccountController(UserManager<AppUsers> userManager,
            SignInManager<AppUsers> signIn)
        {
            UserManager = userManager;
            SignIn = signIn;
        }

        public UserManager<AppUsers> UserManager { get; }
        public SignInManager<AppUsers> SignIn { get; }

        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> login(login_ViewModel login_)
        {
            if (ModelState.IsValid)
            {
                var result = await SignIn.PasswordSignInAsync(login_.Email, login_.password, false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashbord");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(login_);
        }
        public IActionResult Registre()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registre(Create_Register_ViewModel model)
        {
            if (ModelState.IsValid)
            {
                var users = new AppUsers()
                {
                    nom = model.nom,
                    prenom = model.prenom,
                    Email = model.Email,
                    UserName=model.Email
                };
                var result = await UserManager.CreateAsync(users, model.password);
                if (result.Succeeded)
                {
                    await SignIn.SignInAsync(users, isPersistent: false);
                    return RedirectToAction("Index", "Categories");
                }
            }
            return View(model);
        }
        public async Task<IActionResult> logout()
        {
            await SignIn.SignOutAsync();
            return RedirectToAction("login");
        }
    }
}