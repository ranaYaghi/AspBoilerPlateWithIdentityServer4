using Abp.IdentityServer4vNext;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IdentityServer.Authorization.Roles;
using IdentityServer.Authorization.Users;
using IdentityServer.MultiTenancy;

namespace IdentityServer.EntityFrameworkCore
{
    public class IdentityServerDbContext : AbpZeroDbContext<Tenant, Role, User, IdentityServerDbContext> , IAbpPersistedGrantDbContext
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<PersistedGrantEntity> PersistedGrants { get; set; }
        public IdentityServerDbContext(DbContextOptions<IdentityServerDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
