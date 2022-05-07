using Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zemzem.InfraStructure;
using zemzem.IntefaceClasses;

namespace zemzem.BL
{
    public class ClsProduct : IProductService
    {
        ZemzemContext ctx;
        public ClsProduct(ZemzemContext context)
        {
            ctx = context;
        }

        public bool additem(TbProduct product)
        {
            ctx.TbProduct.Add(product);
            ctx.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var result = ctx.TbProduct.Where(a => a.TbProductId == id).FirstOrDefault();
            ctx.TbProduct.Remove(result);
            ctx.SaveChanges();
            return true;
        }
        public bool Deletephoto(int id)
        {
            var result = ctx.TbProductImages.Where(a => a.ProductId == id).FirstOrDefault();
            ctx.TbProductImages.Remove(result);
            ctx.SaveChanges();
            return true;
        }

        public bool Edit(TbProduct product)
        {
            ctx.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public List<TbProduct> GetAll()
        {
            List<TbProduct> product = ctx.TbProduct.Include(a => a.Category).ToList();
            return product;
        }
        public List<TbProductImages> GetAllPhotos()
        {
            List<TbProductImages> product = ctx.TbProductImages.Include(a=>a.Product).ToList();
            return product;
        }

        public TbProduct GetById(int id)
        {
            var item = ctx.TbProduct.Where(a => a.TbProductId == id).FirstOrDefault();
            return item;
        }
        public TbProductImages GetPhotoById(int id)
        {
            var item = ctx.TbProductImages.Where(a => a.ProductId == id).FirstOrDefault();
            return item;
        }
       
        public bool additem(TbProductImages image)
        {
            ctx.TbProductImages.Add(image);
            ctx.SaveChanges();
              

            return true;
        }
        
        public TbProduct ProductWithImage(int id)
        {

            var result = ctx.TbProduct.Include(a => a.FProductImages).Where(a => a.TbProductId == id).FirstOrDefault();
            return result;
        }

       

       

    }
}
