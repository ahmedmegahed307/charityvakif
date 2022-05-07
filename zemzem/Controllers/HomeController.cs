using Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;
using zemzem.Models;

namespace zemzem.Controllers
{
    public class HomeController : Controller
    {
        ISliderService _slider;
        IProductService IProduct;
        IBannerService _banner;
        IHaber _haber;
        ZemzemContext ctx;
        public HomeController(ISliderService slider,IProductService product,IBannerService banner,ZemzemContext context,IHaber haber)
        {
            _slider = slider;
            IProduct = product;
            _banner = banner;
            ctx = context;
            _haber = haber;
        }
        public IActionResult Index()
        {
            HomePageViewModel model = new HomePageViewModel();
            model.ListSlider = _slider._slider().ToList();
            model.ListBanner = _banner._banner().ToList();
            model.ListAllProducts = IProduct.GetAll();
            model.Instagram = model.ListAllProducts.Skip(35).Take(10).ToList();
            return View(model);
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult burs()
        {
            return View();
        }
        public IActionResult manager()
        {
            return View();
        }
        public IActionResult goals()
        {
            return View();
        }
        public IActionResult questions()
        {
            return View();
        }
        public IActionResult kvkk()
        {
            return View();
        }
        public IActionResult haber()
        {
            return View(_haber.ListHaber());
        }
        public IActionResult galeri()
        {
            var item = IProduct.GetAllPhotos();
   
            return View(item.ToList());
        }
        //public async Task<IActionResult> ProductsByCategory1(string categorySlug)
        //{
        //    TbCategory category = await ctx.TbCategory.Where(x => x.Slug == categorySlug).FirstOrDefaultAsync();
        //    if (category == null) return RedirectToAction("Index");
           
        //    var products = ctx.TbProduct.Where(x => x.CategoryId == category.TbCategoryId);

        //    return View(await products.ToListAsync());
        //}


        //public  IActionResult ProductsByCategory(string categorySlug)
        //{
        //    TbCategory category = ctx.TbCategory.Where(x => x.Slug == categorySlug).FirstOrDefault();
        //    if (category == null) return RedirectToAction("Index");

        //    return View(category);
        //}
    }
}
