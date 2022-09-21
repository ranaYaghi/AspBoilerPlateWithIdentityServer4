using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.EntityFrameworkCore
{
    public static class IdentityServerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IdentityServerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IdentityServerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
