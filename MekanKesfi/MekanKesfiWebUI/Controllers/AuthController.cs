using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MekanKesfi.Entities.Concrete;
using MekanKesfiWebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MekanKesfiWebUI.Controllers
{
    public class AuthController : Controller
    {
        private UserManager<Kullanicilar> _userManager;
        private RoleManager<Roller> _roleManager;
        private SignInManager<Kullanicilar> _signInManager;

        public AuthController(UserManager<Kullanicilar> userManager, RoleManager<Roller> roleManager,
            SignInManager<Kullanicilar> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                Kullanicilar user = new Kullanicilar
                {
                    UserName = model.KullaniciAdi,
                    Email = model.Email
                };

                IdentityResult result =
                    _userManager.CreateAsync(user, model.Parola).Result;

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("User").Result)
                    {
                        Roller role = new Roller
                        {
                            Name = "User"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Rol Eklenemedi!");
                            return View(model);
                        }
                    }

                    _userManager.AddToRoleAsync(user, "User").Wait();
                    return RedirectToAction("Login", "Auth");
                }
            }

            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(model.KullaniciAdi,
                    model.Parola, model.BeniHatirla, false).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Liste", "Mekanlar");
                }

                ModelState.AddModelError("", "Geçersiz Giriş!");
            }

            return View(model);
        }

        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }
    }
}