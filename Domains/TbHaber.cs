using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
   public class TbHaber
    {
        public int TbHaberId { get; set; }
        public DateTime HaberDate { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public string HaberImage { get; set; }
    }
}
