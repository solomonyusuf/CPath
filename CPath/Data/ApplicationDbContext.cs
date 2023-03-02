using CPath.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CPath.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
            Database.EnsureCreatedAsync();
            if (Database.GetPendingMigrationsAsync().Result.Count() > 0)
                Database.MigrateAsync();
        }

        public DbSet<CPath.Models.ParentInfo> ParentInfo { get; set; }

        public DbSet<CPath.Models.Result> Result { get; set; }

        public DbSet<CPath.Models.Subject> Subject { get; set; }
    }
}
