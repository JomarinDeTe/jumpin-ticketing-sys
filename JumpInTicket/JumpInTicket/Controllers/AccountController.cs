using Domain;
using Infrastructure;
using JumpInTicket.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Utility;

namespace JumpInTicket.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IUserService UserService;
        public AccountController(IConfiguration Configuration, IUserService UserService)
        {
            this.Configuration = Configuration;
            this.UserService = UserService;
        }


        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {

                var userRoles = ((ClaimsIdentity)User.Identity).Claims
                                                               .Where(c => c.Type == ClaimTypes.Role)
                                                               .Select(c => c.Value).ToList();

                if (userRoles.Contains(Enums.UserRoles.Admin.GetEnumDescription()))
                    return RedirectToAction("Index", "AdminDashboard");
                if (userRoles.Contains(Enums.UserRoles.Employee.GetEnumDescription()))
                    return RedirectToAction("Index", "EmployeeDashboard");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginModel loginModel, string returnUrl)
        {
           

            return View();
        }



        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            //return LocalRedirect("Account/Login");
            return RedirectToAction("Login", "Account");
        }
        public ActionResult AccessDenied()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
