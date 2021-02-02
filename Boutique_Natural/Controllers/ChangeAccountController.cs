using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Boutique_Natural.Models;
using Boutique_Natural.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Boutique_Natural.Controllers
{
    public class ChangeAccountController : Controller
    {
        public ChangeAccountController(UserManager<AppUsers> userManager,
          SignInManager<AppUsers> signInManager,
          IHostingEnvironment hosting)
        {
            UserManager = userManager;
            SignInManager = signInManager;
            Hosting = hosting;
        }

        public UserManager<AppUsers> UserManager { get; }
        public SignInManager<AppUsers> SignInManager { get; }
        public IHostingEnvironment Hosting { get; }

        // GET: Image_Password
        public ActionResult Change_Image()
        {
            if (Valide_User())
            {
                var user_Id = UserManager.GetUserId(User);
                var getUser = UserManager.Users.SingleOrDefault(u => u.Id == user_Id);
                var model = new AddImage_ViewModel()
                {
                    image = getUser.image
                };
                return View(model);
            }
            return getUserLogin();
        }
        [HttpPost]
        public async Task<IActionResult> change_Image(AddImage_ViewModel addImage_)
        {
            if (Valide_User())
            {
                string image = addImage_.image;
                string fileName1 = "";
                var user_Id = UserManager.GetUserId(User);
                var getUser = UserManager.Users.SingleOrDefault(u => u.Id == user_Id);
                if (addImage_.file != null)
                {
                    if (image == null)
                    {
                        string upload = Path.Combine(Hosting.WebRootPath, "Admin/Image_User");
                        fileName1 = addImage_.file.FileName;
                        string path1 = Path.Combine(upload, fileName1);
                        addImage_.file.CopyTo(new FileStream(path1, FileMode.Create));
                    }
                    else
                    {
                        string upload = Path.Combine(Hosting.WebRootPath, "Admin/Image_User");
                        fileName1 = addImage_.file.FileName;
                        string old_Path = Path.Combine(upload, image);
                        string new_Path = Path.Combine(upload, fileName1);
                        if (old_Path != new_Path)
                        {
                            System.IO.File.Delete(old_Path);
                            addImage_.file.CopyTo(new FileStream(new_Path, FileMode.Create));
                        }
                    }
                    getUser.image = fileName1;
                    var result = await UserManager.UpdateAsync(getUser);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Dashbord");
                    }
                }
                return View(getUser);
            }
            return getUserLogin();
        }
        public IActionResult changePassword()
        {
            if (Valide_User())
            {
                return View();
            }
            return getUserLogin();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> changePassword(Change_Password change)
        {
            if (Valide_User())
            {
                if (ModelState.IsValid)
                {
                    var user = await UserManager.GetUserAsync(User);
                    if (user == null)
                    {
                        return RedirectToAction("login", "Account");
                    }
                    var result = await UserManager.ChangePasswordAsync(user, change.OldPassword, change.newPassword);
                    if (!result.Succeeded)
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                    await SignInManager.RefreshSignInAsync(user);
                    return RedirectToAction("Index", "Dashbord");
                }
                return View(change);
            }
            return RedirectToAction("Index", "Dashbord");
        }

        public ActionResult getUserLogin()
        {
            return RedirectToAction("login", "Account");
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
    }
}