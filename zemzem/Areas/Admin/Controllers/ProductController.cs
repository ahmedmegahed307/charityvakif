using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using zemzem.BL;
using zemzem.InfraStructure;
using zemzem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using zemzem.IntefaceClasses;

namespace zemzem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        ZemzemContext ctx;
        IProductService IProduct;
        ICategoryService ICategory;
        public ProductController(ZemzemContext context,IProductService service, ICategoryService sas)
        {
            ctx = context;
            IProduct = service;
           ICategory = sas;
        }
        public IActionResult List(int page=1)
        {
            int pagesize = 10;
            var products = IProduct.GetAll().Skip((page - 1) * pagesize).Take(pagesize);
            ViewBag.PageNumber = page;
            ViewBag.PageRange = pagesize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)ctx.TbProduct.Count() / pagesize);
            return View(products.ToList());
        }
        public IActionResult ProductsInProject(int page=1)
        {
            int pagesize = 16;
            var products = IProduct.GetAll().Skip((page - 1) * pagesize).Take(pagesize);
            ViewBag.PageNumber = page;
            ViewBag.PageRange = pagesize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)ctx.TbProduct.Count() / pagesize);
            return View(products.ToList());
            
        }

        public IActionResult Edit(int?id)
        {
            ViewBag.cat = ICategory.GetAll();
            ///drop down list
            if (id!=null)
            {
                

                return View(IProduct.GetById(Convert.ToInt32(id)));
            }
            else
            {
                return View();
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> Save(TbProduct product, List<IFormFile> Files)
        {
            
            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                    }
                    product.ProductImageName = ImageName;
                }
            }

            if (product.TbProductId == 0)
            {
                IProduct.additem(product);

            }
            else
            {
                IProduct.Edit(product);
            }
            return RedirectToAction("List");

        }
        public IActionResult Delete(int id)
        {
            IProduct.Delete(id);
            return RedirectToAction("List");
        }

        public IActionResult ShowPhoto(int page = 1)
        {
            
                int pagesize = 10;
                var products = IProduct.GetAllPhotos().Skip((page - 1) * pagesize).Take(pagesize);
                ViewBag.PageNumber = page;
                ViewBag.PageRange = pagesize;
                ViewBag.TotalPages = (int)Math.Ceiling((decimal)ctx.TbProduct.Count() / pagesize);
                return View(products.ToList());
        }
        public IActionResult EditPhoto(int ? id)
        {
            if (id != null)
            {


                return View(IProduct.GetPhotoById(Convert.ToInt32(id)));
            }
            else
            {
                return View();
            }
           
        }
        public IActionResult DeletePhoto(int id)
        {
            IProduct.Deletephoto(id);
            return RedirectToAction("ShowPhoto");
            
        }
        [HttpPost]
        public async Task<IActionResult> SavePhoto(TbProductImages photo, List<IFormFile> Files2)
        {
            foreach (var file in Files2)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", ImageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                    }
                    photo.ImageName = ImageName;
                }
            }

            IProduct.additem(photo);

            return RedirectToAction("ShowPhoto");
        }
       
    }
}
