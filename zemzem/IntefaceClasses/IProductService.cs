using Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zemzem.IntefaceClasses
{
    public interface IProductService
    {
        List<TbProduct> GetAll();
        List<TbProductImages> GetAllPhotos();
        TbProduct GetById(int id);
        TbProductImages GetPhotoById(int id);
        bool additem(TbProduct product);
        bool Edit(TbProduct product);
        bool Delete(int id);
        bool Deletephoto(int id);
        TbProduct ProductWithImage(int id);
        bool additem(TbProductImages image);
       
    }
}
