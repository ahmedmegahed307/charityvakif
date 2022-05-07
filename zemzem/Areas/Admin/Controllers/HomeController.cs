using Domains;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HomeController : Controller
    {
        ZemzemContext ctx;
        ISliderService ISlider;
        IBannerService IBanner;
        IHaber _IHaber;
        public HomeController(ZemzemContext context,ISliderService slider,IBannerService banner, IHaber haber)
        {
            ctx = context;
            ISlider = slider;
            IBanner = banner;
            _IHaber = haber;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Slider()
        {
            return View(ISlider._slider());
        }

        public IActionResult EditSlider(int? id)
        {

            if (id != null)
            {


                return View(ISlider.GetSliderById(Convert.ToInt32(id)));
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> SaveSlider(TbSlider slider, List<IFormFile> Files)
        {

            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Slider", ImageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                    }
                    slider.SliderImage = ImageName;
                }
            }

            if (slider.TbSliderId == 0)
            {
                ISlider.addslider(slider);

            }
            else
            {
                ISlider.editslider(slider);
            }
            return RedirectToAction("Slider");

        }
        public IActionResult Delete(int id)
        {
            ISlider.DeleteSlider(id);
            return RedirectToAction("Slider");
        }
        //banner begin
        public IActionResult Banner()
        {
            return View(IBanner._banner());
        }

        public IActionResult EditBanner(int? id)
        {

            if (id != null)
            {


                return View(IBanner.GetBannerById(Convert.ToInt32(id)));
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> SaveBanner(TbBanner banner, List<IFormFile> Files)
        {

            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Banner", ImageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                    }
                    banner.BannerImage = ImageName;
                }
            }

            if (banner.TbBannerId == 0)
            {
                IBanner.addbanner(banner);

            }
            else
            {
                IBanner.editbanner(banner);
            }
            return RedirectToAction("Banner");

        }
        public IActionResult DeleteBanner(int id)
        {
            IBanner.DeleteBanner(id);
            return RedirectToAction("Banner");
        }
        //banner haber
        public IActionResult Haber()
        {
            return View(_IHaber.ListHaber());
        }

        public IActionResult EditHaber(int? id)
        {

            if (id != null)
            {


                return View(_IHaber.GethaberById(Convert.ToInt32(id)));
            }
            else
            {
                return View();
            }

        }
        [HttpPost]
        public async Task<IActionResult> SaveHaber(TbHaber haber, List<IFormFile> Files)
        {

            foreach (var file in Files)
            {
                if (file.Length > 0)
                {
                    string ImageName = Guid.NewGuid().ToString() + ".jpg";
                    var filePaths = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\haber", ImageName);
                    using (var stream = System.IO.File.Create(filePaths))
                    {
                        await file.CopyToAsync(stream);
                    }
                    haber.HaberImage = ImageName;
                }
            }

            if (haber.TbHaberId == 0)
            {
                _IHaber.addhaber(haber);

            }
            else
            {
                _IHaber.edithaber(haber);
            }
            return RedirectToAction("Haber");

        }
        public IActionResult DeleteHaber(int id)
        {
            _IHaber.Deletehaber(id);
            return RedirectToAction("Haber");
        }
    }
}
