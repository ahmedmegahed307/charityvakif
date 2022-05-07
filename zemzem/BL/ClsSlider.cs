using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem.BL
{
    public class ClsSlider : ISliderService
    {
        ZemzemContext ctx;
        public ClsSlider(ZemzemContext context)
        {
            ctx = context;
        }
        public bool addslider(TbSlider slider)
        {
            ctx.TbSlider.Add(slider);
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteSlider(int id)
        {
            var result = ctx.TbSlider.Where(a => a.TbSliderId == id).FirstOrDefault();
            ctx.TbSlider.Remove(result);
            ctx.SaveChanges();
            return true;
        }

        public bool editslider(TbSlider slider)
        {
            ctx.Entry(slider).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public TbSlider GetSliderById(int id)
        {
            
                var item = ctx.TbSlider.Where(a => a.TbSliderId == id).FirstOrDefault();
                return item;
            
        }
        public List<TbSlider> _slider()
        {
            var item = ctx.TbSlider.ToList();
            return item;
        }
    }
}
