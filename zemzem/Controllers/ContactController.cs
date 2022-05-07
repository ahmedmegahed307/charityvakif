using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using zemzem.InfraStructure;
using zemzem.Models;
using Microsoft.AspNetCore.Mvc;

namespace zemzem.Controllers
{
    public class ContactController : Controller
    {
        ZemzemContext ctx;
        public ContactController(ZemzemContext context)
        {
            ctx = context;
        }
        public IActionResult contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(TbContact model)
        {
            ViewBag.first = model.FirstName; ViewBag.last = model.LastName;
            ctx.TbContact.Add(model);
            ctx.SaveChanges();
            return View("SuccessMessage");
        }
        public IActionResult SuccessMessage()
        {
            
            return View();
        }
        public IActionResult ShowMessages()
        {
            var item = ctx.TbContact.ToList();
            return View(item);

        }
        

    }
}
