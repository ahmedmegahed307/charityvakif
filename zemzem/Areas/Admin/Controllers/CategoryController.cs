using Domains;
using zemzem.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.IntefaceClasses;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace zemzem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        ICategoryService ICategory;
        public CategoryController(ICategoryService qq)
        {
            ICategory = qq;
        }

        public IActionResult CategoryList()
        {
            return View(ICategory.GetAll());
        }

        public IActionResult CategoryEdit(int? id)
        {
            ViewBag.cat = ICategory.GetAll();
            if (id != null)
            {
                return View(ICategory.GetById(Convert.ToInt32(id)));

            }
            else

                return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(TbCategory category, List<IFormFile> Files)
        {
           
            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\catimage", ImageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                    }
                    category.CategoryImage = ImageName;
                }
            }

            if (category.TbCategoryId == 0)
            {
                ICategory.addcategory(category);

            }
            else
            {
                ICategory.editcategory(category);
            }
            return RedirectToAction("CategoryList");
        }

        public IActionResult Delete(string name)
        {
            ICategory.Delete(name);
            return RedirectToAction("CategoryList");

        }
    }
}
