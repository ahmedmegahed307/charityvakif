using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zemzem.IntefaceClasses
{
    public interface IBannerService
    {
        public List<TbBanner> _banner();
        bool editbanner(TbBanner banner);
        bool addbanner(TbBanner banner);
        bool DeleteBanner(int id);
        public TbBanner GetBannerById(int id);
    }
}
