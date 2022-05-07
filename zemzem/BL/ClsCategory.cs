using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem.BL
{
    public class ClsCategory : ICategoryService
    {
        ZemzemContext ctx;
        public ClsCategory(ZemzemContext context)
        {
            ctx = context;
        }
        public List<TbCategory> GetAll()
        {
            var item = ctx.TbCategory.ToList();
            return item;
        }
        public TbCategory GetById(int id)
        {
            var item = ctx.TbCategory.Where(a => a.TbCategoryId == id).FirstOrDefault();
            return item;
        }
        public bool addcategory(TbCategory category)
        {
            ctx.TbCategory.Add(category);
            ctx.SaveChanges();
            return true;
        }
        public bool editcategory(TbCategory category)
        {


            
            ctx.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            ctx.SaveChanges();
            return true;
        }

       
        public bool Delete(string name)
        {
            var result = ctx.TbCategory.Where(a => a.CategoryName == name).FirstOrDefault();
            ctx.TbCategory.Remove(result);
            ctx.SaveChanges();
            return true;
        }
    }
}
