using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zemzem.IntefaceClasses
{
  public  interface IHaber
    {
        public List<TbHaber> ListHaber();
        bool edithaber(TbHaber haber);
        bool addhaber(TbHaber haber);
        bool Deletehaber(int id);
        public TbHaber GethaberById(int id);
    }
}
