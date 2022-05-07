using Domains;
using zemzem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;

namespace zemzem.InfraStructure
{
    public class CategoriesViewComponent : ViewComponent
    {
        ZemzemContext ctx;
        public CategoriesViewComponent(ZemzemContext context)
        {
            ctx = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await GetCategoriesAsync();
            return View(categories);
        }

        private Task<List<TbCategory>> GetCategoriesAsync()
        {
            return ctx.TbCategory.ToListAsync();
        }
    }
}
