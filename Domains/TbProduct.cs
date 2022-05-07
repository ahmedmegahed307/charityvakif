using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
  public  class TbProduct
    {

        public int TbProductId { get; set; }
        
        public string ProductName { get; set; }
       
        public string ProductImageName { get; set; }
        public DateTime ImageDate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual TbCategory Category { get; set; }
        public virtual ICollection<TbProductImages> FProductImages { get; set; }
    }
}
