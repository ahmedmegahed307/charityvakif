using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zemzem.IntefaceClasses
{
    public interface ICategoryService
    {
        List<TbCategory> GetAll();
        TbCategory GetById(int id);
        bool addcategory(TbCategory category);
        bool editcategory(TbCategory category);
        bool Delete(string name);
    }
}
