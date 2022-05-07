using Domains;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;

namespace zemzem.Controllers
{
    public class CategoryController : Controller
    {
        ZemzemContext ctx;

       
        public CategoryController( ZemzemContext context)
        {
            ctx = context;

        }
        public IActionResult ProductsByCategory(string catname)
        {
            TbCategory category = ctx.TbCategory.Where(x => x.CategoryName == catname).FirstOrDefault();
            if (category == null) return RedirectToAction("Index");
            return View(category);
        }
        //public IActionResult ProductsByCategory1(string categorySlug)
        //{
        //    TbCategory category = ctx.TbCategory.Where(x => x.Slug == categorySlug).FirstOrDefault();
        //    if (category == null) return RedirectToAction("Index");
        //    return View(category);
        //}


    }
}
