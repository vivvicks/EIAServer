using Entities.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
    public partial class EIA_DEVContext_View : DbContext
    {
        public virtual DbSet<VW_UserDetail> VW_UserDetail { get; set; }

        public EIA_DEVContext_View(DbContextOptions<EIA_DEVContext_View> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VW_UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserMstID);
                entity.ToTable("VW_UserDetail");

            });

            modelBuilder.Entity<VWEDT_COURIERMST>(entity =>
            {
                entity.HasKey(e => e.CourierCoId);
                entity.ToTable("vwedt_couriermst");

            });
        }
    }
}
