using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpAlain.EntityFrameworkCore
{
    public static class AbpAlainDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpAlainDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<AbpAlainDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
}
