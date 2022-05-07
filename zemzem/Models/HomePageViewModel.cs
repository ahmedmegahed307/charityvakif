using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zemzem.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<TbSlider> ListSlider { get; set; }
        public IEnumerable<TbBanner> ListBanner { get; set; }
        public IEnumerable<TbProduct> ListAllProducts { get; set; }
        public IEnumerable<TbProduct> ListCategory { get; set; }
        public IEnumerable<TbProduct> Instagram { get; set; }


    }
}
