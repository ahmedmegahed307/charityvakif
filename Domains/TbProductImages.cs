using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    public class TbProductImages
    {
        public int TbProductImagesId { get; set; }
        public string ImageName { get; set; }
        public int ProductId { get; set; }
        public virtual TbProduct Product { get; set; }
    }
}
