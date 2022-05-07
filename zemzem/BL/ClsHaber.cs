using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem.BL
{
    public class ClsHaber : IHaber
    {
        ZemzemContext ctx;
        public ClsHaber(ZemzemContext context)
        {
            ctx = context;
        }
        public bool addhaber(TbHaber haber)
        {
            ctx.TbHaber.Add(haber);
            ctx.SaveChanges();
            return true;
        }

        public bool Deletehaber(int id)
        {
            var result = ctx.TbHaber.Where(a => a.TbHaberId == id).FirstOrDefault();
            ctx.TbHaber.Remove(result);
            ctx.SaveChanges();
            return true;
        }

        public bool edithaber(TbHaber haber)
        {
            ctx.Entry(haber).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public TbHaber GethaberById(int id)
        {

            var item = ctx.TbHaber.Where(a => a.TbHaberId == id).FirstOrDefault();
            return item;

        }
        public List<TbHaber> ListHaber()
        {
            var item = ctx.TbHaber.ToList();
            return item;
        }
    }
}
