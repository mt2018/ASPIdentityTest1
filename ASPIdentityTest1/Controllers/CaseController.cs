using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPIdentityTest1.Models;
using ASPIdentityTest1.Models.AccountViewModels;
using ASPIdentityTest1.Models.CaseViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPIdentityTest1.Controllers
{
    public class CaseController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult SubmitCase(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitCase(CaseViewModel model,string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var newcase = new Case
                {
                    CaseNumber = model.CaseNumber,
                    Title = model.Title,
                    Description = model.Description,
                    SalaryLevel = model.SalaryLevel.ToString(),
                    MissedSalary = model.MissedSalary,
                    PayCycle = model.PayCycle,
                    Priority = model.Priority.ToString()
                };
            }
            
            //TODO: 
            //Send to CRM 
            return View(model);
        }
    }
}