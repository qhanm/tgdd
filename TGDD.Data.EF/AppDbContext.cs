using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TGDD.Data.EF.Configurations;
using TGDD.Data.EF.Extensions;
using TGDD.Data.Entities;
using TGDD.Data.Interfaces;

namespace TGDD.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });
            #endregion
            builder.AddConfiguration(new TagConfiguration());
            builder.AddConfiguration(new BlogTagConfiguration());
            builder.AddConfiguration(new ContactDetailConfiguration());
            builder.AddConfiguration(new FooterConfiguration());
            builder.AddConfiguration(new PageConfiguration());
            builder.AddConfiguration(new FooterConfiguration());
            builder.AddConfiguration(new ProductTagConfiguration());
            builder.AddConfiguration(new SystemConfigConfiguration());
            builder.AddConfiguration(new AdvertistmentPositionConfiguration());

            //base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach(EntityEntry item in modified)
            {
                var changeOrAddedItem = item.Entity as IDateTracking;

                if(changeOrAddedItem != null)
                {
                    if(item.State == EntityState.Added)
                    {
                        changeOrAddedItem.DateCreated = DateTime.Now;
                    }
                    else
                    {
                        changeOrAddedItem.DateModified = DateTime.Now;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}
