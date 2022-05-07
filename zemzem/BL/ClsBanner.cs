using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem.BL
{
    public class ClsBanner:IBannerService
    {
        ZemzemContext ctx;
        public ClsBanner(ZemzemContext context)
        {
            ctx = context;
        }
        public bool addbanner(TbBanner banner)
        {
            ctx.TbBanner.Add(banner);
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteBanner(int id)
        {
            var result = ctx.TbBanner.Where(a => a.TbBannerId == id).FirstOrDefault();
            ctx.TbBanner.Remove(result);
            ctx.SaveChanges();
            return true;
        }

        public bool editbanner(TbBanner banner)
        {
            ctx.Entry(banner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public TbBanner GetBannerById(int id)
        {

            var item = ctx.TbBanner.Where(a => a.TbBannerId == id).FirstOrDefault();
            return item;

        }
        public List<TbBanner> _banner()
        {
            var item = ctx.TbBanner.ToList();
            return item;
        }
    }
}
