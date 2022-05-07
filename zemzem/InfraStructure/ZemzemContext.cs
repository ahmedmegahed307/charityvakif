using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domains;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace zemzem.InfraStructure
{
    public class ZemzemContext : IdentityDbContext
    {
        public ZemzemContext(DbContextOptions<ZemzemContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TbProduct> TbProduct { get; set; }
        public virtual DbSet<TbProductImages> TbProductImages{ get; set; }
        public virtual DbSet<TbCategory> TbCategory { get; set; }
        public virtual DbSet<TbSlider> TbSlider { get; set; }
        public virtual DbSet<TbContact> TbContact { get; set; }
        public virtual DbSet<TbBanner> TbBanner { get; set; }
        public virtual DbSet<TbHaber> TbHaber { get; set; }

    }
}
